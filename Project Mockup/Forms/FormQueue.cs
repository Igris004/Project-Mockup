using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Mockup.Forms
{
    public partial class FormQueue : Form
    {
        Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        Microsoft.Msagl.Drawing.Graph graph;
        string last_node = "NULL";
        Queue<string> queue;
        Form form;
        public FormQueue()
        {
            InitializeComponent();
        }

        private void FormQueue_Load(object sender, EventArgs e)
        {
            queue = new Queue<string>();
            form = new Form();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlFormLoader.Controls.Add(form);
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            string input = txtboxInsert.Text;
            if (int.TryParse(input,out _))
            {
                if (!CheckDupes(input))
                {
                    graph = new Microsoft.Msagl.Drawing.Graph("graph");
                    if (last_node == "NULL")
                    {
                        queue.Enqueue(input);
                        MessageBox.Show("Inserted successfully! Now enter the second element.");
                        last_node = input;
                        txtboxInsert.Text = "";
                    }
                    else
                    {
                        queue.Enqueue(input);
                        update_graph(graph);
                        txtboxInsert.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Duplicates not allowed!");
                }
            }
            else 
            {
                MessageBox.Show("Please enter a valid integer");
            }
        }
        private void update_graph(Microsoft.Msagl.Drawing.Graph new_graph) 
        {
            foreach (string node in queue)
            {
                if (node == queue.Peek())
                {
                    last_node = node;
                    continue;
                }
                else
                {
                    graph.AddEdge(last_node, node);
                    last_node = node;
                }
            }
            viewer.Graph = new_graph;
            form.SuspendLayout();
            viewer.Dock = DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            form.Show();
        }
        private bool CheckDupes(string input)
        {
            try
            {
                Microsoft.Msagl.Drawing.Node dupes = graph.FindNode(input);
                if (dupes == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (NullReferenceException ex)
            {
                return false;
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            try
            {
                queue.Dequeue();
            }
            catch (Exception)
            {
                MessageBox.Show("Queue Underflow!!");
                return;
            }
            Microsoft.Msagl.Drawing.Graph new_graph = new Microsoft.Msagl.Drawing.Graph("new_graph");
            graph = new_graph;
            update_graph(new_graph);
        }
    }
}
