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
    public partial class FormLinkedList : Form
    {
        Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        Microsoft.Msagl.Drawing.Graph graph;
        string last_node = "NULL";
        LinkedList<string> linkedlist;
        Form form;
        public FormLinkedList()
        {
            InitializeComponent();
        }

        private void FormLinkedList_Load(object sender, EventArgs e)
        {
            linkedlist = new LinkedList<string>();
            form = new Form();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlFormLoader.Controls.Add(form);
        }

        private void btnSInsert_Click(object sender, EventArgs e)
        {
            string input = txtboxValue.Text;
            if (!CheckDupes(input))
            {
                graph = new Microsoft.Msagl.Drawing.Graph("graph");
                if (last_node == "NULL")
                {
                    if (int.TryParse(input, out _))
                    {
                        linkedlist.AddFirst(input);
                        MessageBox.Show("Inserted successfully! Now enter the second element.");
                        last_node = input;
                        txtboxValue.Text = "";
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
                        linkedlist.AddFirst(input);
                        foreach (string node in linkedlist)
                        {
                            if (node == linkedlist.First.Value.ToString()) 
                            {
                                last_node = node;
                                continue;
                            }
                            else
                            {
                                graph.AddEdge(last_node, node);
                                graph.AddEdge(node, last_node);
                                last_node = node;
                            }
                        }
                        graph.FindNode(linkedlist.First.Value.ToString()).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Turquoise;
                        graph.FindNode(linkedlist.Last.Value.ToString()).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Teal;
                        if (linkedlist.Count > 2)
                        {
                            graph.AddEdge(graph.FindNode(linkedlist.First.Value.ToString()).Id, graph.FindNode(linkedlist.Last.Value.ToString()).Id);
                            graph.AddEdge(graph.FindNode(linkedlist.Last.Value.ToString()).Id, graph.FindNode(linkedlist.First.Value.ToString()).Id);
                        }
                        viewer.Graph = graph;
                        form.SuspendLayout();
                        viewer.Dock = DockStyle.Fill;
                        form.Controls.Add(viewer);
                        form.ResumeLayout();
                        form.Show();
                        txtboxValue.Text = "";
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

        private void btnEInsert_Click(object sender, EventArgs e)
        {
            string input = txtboxValue.Text;
            if (!CheckDupes(input))
            {
                graph = new Microsoft.Msagl.Drawing.Graph("graph");
                if (last_node == "NULL")
                {
                    if (int.TryParse(input, out _))
                    {
                        linkedlist.AddLast(input);
                        MessageBox.Show("Inserted successfully! Now enter the second element.");
                        last_node = input;
                        txtboxValue.Text = "";
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
                        linkedlist.AddLast(input);
                        foreach (string node in linkedlist)
                        {
                            if (node == linkedlist.First.Value.ToString())
                            {
                                last_node = node;
                                continue;
                            }
                            else
                            {
                                graph.AddEdge(last_node, node);
                                graph.AddEdge(node, last_node);
                                last_node = node;
                            }
                        }
                        graph.FindNode(linkedlist.First.Value.ToString()).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Turquoise;
                        graph.FindNode(linkedlist.Last.Value.ToString()).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Teal;
                        if (linkedlist.Count > 2)
                        {
                            graph.AddEdge(graph.FindNode(linkedlist.First.Value.ToString()).Id, graph.FindNode(linkedlist.Last.Value.ToString()).Id);
                            graph.AddEdge(graph.FindNode(linkedlist.Last.Value.ToString()).Id, graph.FindNode(linkedlist.First.Value.ToString()).Id);
                        }
                        viewer.Graph = graph;
                        form.SuspendLayout();
                        viewer.Dock = DockStyle.Fill;
                        form.Controls.Add(viewer);
                        form.ResumeLayout();
                        form.Show();
                        txtboxValue.Text = "";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string input = txtboxValue.Text;
            if (input == "") 
            {
                MessageBox.Show("Enter a value into the textbox!");
                return;
            }
            if (linkedlist.Remove(input))
            {
                Microsoft.Msagl.Drawing.Graph new_graph = new Microsoft.Msagl.Drawing.Graph("new_graph");
                foreach (string node in linkedlist)
                {
                    if (node == linkedlist.First.Value.ToString())
                    {
                        last_node = node;
                        continue;
                    }
                    else
                    {
                        new_graph.AddEdge(last_node, node);
                        new_graph.AddEdge(node, last_node);
                        last_node = node;
                    }
                }
                if (linkedlist.Count >= 2)
                {
                    new_graph.FindNode(linkedlist.First.Value.ToString()).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Turquoise;
                    new_graph.FindNode(linkedlist.Last.Value.ToString()).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Teal;
                }
                if (linkedlist.Count > 2)
                {
                    new_graph.AddEdge(new_graph.FindNode(linkedlist.First.Value.ToString()).Id, new_graph.FindNode(linkedlist.Last.Value.ToString()).Id);
                    new_graph.AddEdge(new_graph.FindNode(linkedlist.Last.Value.ToString()).Id, new_graph.FindNode(linkedlist.First.Value.ToString()).Id);
                }
                if (linkedlist.Count == 0) 
                {
                    last_node = "NULL";
                }
                viewer.Graph = new_graph;
                form.SuspendLayout();
                viewer.Dock = DockStyle.Fill;
                form.Controls.Add(viewer);
                form.ResumeLayout();
                form.Show();
                graph = new_graph;
                txtboxValue.Text = "";
            }
            else 
            {
                MessageBox.Show("Value does not exist in the list!");
                return;
            }
        }
    }
}
