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
    public partial class FormHeaps : Form
    {
        Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        Microsoft.Msagl.Drawing.Graph graph;
        Form form = new Form();
        public FormHeaps()
        {
            InitializeComponent();
            graph = new Microsoft.Msagl.Drawing.Graph();
            graph.AddEdge("2", "3");
            graph.AddEdge("2", "1");
            viewer.Graph = graph;
            form.SuspendLayout();
            viewer.Dock = DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            form.Show();
        }
    }
}
