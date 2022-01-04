using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Project_Mockup.Scripts;
using Project_Mockup.Forms;

namespace Project_Mockup
{
    public partial class Form1 : Form
    {
        private Form currentChildForm;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public Form1()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnGraphs.Height;
            pnlNav.Top = btnGraphs.Top;
            pnlNav.Left = btnGraphs.Left;
            btnGraphs.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new FormGraphs());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLinkedList.Height;
            pnlNav.Top = btnLinkedList.Top;
            pnlNav.Left = btnLinkedList.Left;
            btnLinkedList.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new FormLinkedList());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnStack.Height;
            pnlNav.Top = btnStack.Top;
            pnlNav.Left = btnStack.Left;
            openChildForm(new FormStack());
            btnStack.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTrees.Height;
            pnlNav.Top = btnTrees.Top;
            pnlNav.Left = btnTrees.Left;
            btnTrees.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnGraphs.Height;
            pnlNav.Top = btnGraphs.Top;
            pnlNav.Left = btnGraphs.Left;
            btnGraphs.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new FormGraphs());
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnQueue.Height;
            pnlNav.Top = btnQueue.Top;
            pnlNav.Left = btnQueue.Left;
            btnQueue.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new FormQueue());
        }

        private void btnHeaps_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHeaps.Height;
            pnlNav.Top = btnHeaps.Top;
            pnlNav.Left = btnHeaps.Left;
            btnHeaps.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnShiftToSort_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnShiftToSort.Height;
            pnlNav.Top = btnShiftToSort.Top;
            pnlNav.Left = btnShiftToSort.Left;
            btnShiftToSort.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnArray_Leave(object sender, EventArgs e)
        {
            btnGraphs.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLinkedList_Leave(object sender, EventArgs e)
        {
            btnLinkedList.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnStack_Leave(object sender, EventArgs e)
        {
            btnStack.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnQueue_Leave(object sender, EventArgs e)
        {
            btnQueue.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnTrees_Leave(object sender, EventArgs e)
        {
            btnTrees.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnHeaps_Leave(object sender, EventArgs e)
        {
            btnHeaps.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnShiftToSort_Leave(object sender, EventArgs e)
        {
            btnShiftToSort.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(200, 0, 0);
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
    }
}
