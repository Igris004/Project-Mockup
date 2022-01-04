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
    public partial class FormGraphs : Form
    {
        Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
        Form form;
        public FormGraphs()
        {
            InitializeComponent();
        }

        private void FormGraphs_Load(object sender, EventArgs e)
        {
            form = new Form();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlFormLoader.Controls.Add(form);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string node1 = txtboxNodeOne.Text;
            string node2 = txtboxNodeTwo.Text;
            graph.AddEdge(node1, node2);
            viewer.Graph = graph;
            form.SuspendLayout();
            viewer.Dock = DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            form.Show();
            txtboxNodeOne.Text = "";
            txtboxNodeTwo.Text = "";
        }
    }
}
