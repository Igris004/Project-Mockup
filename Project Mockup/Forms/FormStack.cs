using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Mockup.Scripts
{
    public partial class FormStack : Form
    {
        Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        Microsoft.Msagl.Drawing.Graph graph;
        string last_node = "NULL";
        Stack<string> stack;
        Form form;
        public FormStack()
        {
            InitializeComponent();
        }
        private void FormStack_Load(object sender, EventArgs e)
        {
            stack = new Stack<string>();
            form = new Form();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlFormLoader.Controls.Add(form);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string input = txtboxInsert.Text;
            if (!CheckDupes(input))
            {
                graph = new Microsoft.Msagl.Drawing.Graph("graph");
                if (last_node == "NULL")
                {
                    if (int.TryParse(input, out _))
                    {
                        stack.Push(input);
                        MessageBox.Show("Inserted successfully! Now enter the second element.");
                        last_node = input;
                        txtboxInsert.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid integer!");
                    }
                }
                else
                {
                    if (int.TryParse(input, out _))
                    {
                        stack.Push(input);
                        foreach (string node in stack)
                        {
                            if (node == stack.Peek())
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
                        viewer.Graph = graph;
                        form.SuspendLayout();
                        viewer.Dock = DockStyle.Fill;
                        form.Controls.Add(viewer);
                        form.ResumeLayout();
                        form.Show();
                        txtboxInsert.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid integer!");
                    }
                }
            }
            else 
            {
                MessageBox.Show("Duplicates not allowed");
            }
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

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (form.Visible) 
            {
                form.Visible = false;
            }
            try
            {
                stack.Pop();
            }
            catch (Exception)
            {
                MessageBox.Show("Stack Underflow!!");
                return;
            }
            Microsoft.Msagl.Drawing.Graph new_graph = new Microsoft.Msagl.Drawing.Graph("new_graph");
            foreach (string node in stack) 
            {
                if (node == stack.Peek())
                {
                    last_node = node;
                    continue;
                }
                else 
                {
                    new_graph.AddEdge(last_node, node);
                    last_node = node;
                }
            }
            viewer.Graph = new_graph;
            form.SuspendLayout();
            viewer.Dock = DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            form.Show();
            graph = new_graph;
        }
    }
}
