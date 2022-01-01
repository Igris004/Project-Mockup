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
        private Form currentChildForm;
        Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
        string last_node = "NULL";
        Form form = new Form();
        public FormStack()
        {
            InitializeComponent();
        }

        private void FormStack_Load(object sender, EventArgs e)
        {
        }
        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlFormLoader.Controls.Add(childForm);
            pnlFormLoader.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string input = txtboxInsert.Text;
            if (!CheckDupes(input))
            {
                if (last_node == "NULL")
                {
                    bool isNumeric;
                    if (isNumeric = int.TryParse(input, out _))
                    {
                        MessageBox.Show("Inserted successfully! Now enter the second element.");
                        last_node = input;

                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid integer!");
                    }
                }
                else
                {
                    bool isNumeric;
                    if (isNumeric = int.TryParse(input, out _))
                    {
                        graph.AddEdge(input, last_node);
                        viewer.Graph = graph;
                        form.SuspendLayout();
                        viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                        form.Controls.Add(viewer);
                        form.ResumeLayout();
                        last_node = input;
                        form.Show();
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
    }
}
