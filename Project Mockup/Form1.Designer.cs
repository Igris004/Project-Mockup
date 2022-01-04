
namespace Project_Mockup
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnShiftToSort = new System.Windows.Forms.Button();
            this.btnHeaps = new System.Windows.Forms.Button();
            this.btnTrees = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.btnLinkedList = new System.Windows.Forms.Button();
            this.btnGraphs = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.pnl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnl.Controls.Add(this.pnlNav);
            this.pnl.Controls.Add(this.btnShiftToSort);
            this.pnl.Controls.Add(this.btnHeaps);
            this.pnl.Controls.Add(this.btnTrees);
            this.pnl.Controls.Add(this.btnQueue);
            this.pnl.Controls.Add(this.btnStack);
            this.pnl.Controls.Add(this.btnLinkedList);
            this.pnl.Controls.Add(this.btnGraphs);
            this.pnl.Controls.Add(this.panel2);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(200, 577);
            this.pnl.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 151);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 207);
            this.pnlNav.TabIndex = 9;
            // 
            // btnShiftToSort
            // 
            this.btnShiftToSort.FlatAppearance.BorderSize = 0;
            this.btnShiftToSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShiftToSort.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftToSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnShiftToSort.Location = new System.Drawing.Point(0, 540);
            this.btnShiftToSort.Name = "btnShiftToSort";
            this.btnShiftToSort.Size = new System.Drawing.Size(200, 37);
            this.btnShiftToSort.TabIndex = 8;
            this.btnShiftToSort.Text = "Sorts";
            this.btnShiftToSort.UseVisualStyleBackColor = true;
            this.btnShiftToSort.Click += new System.EventHandler(this.btnShiftToSort_Click);
            this.btnShiftToSort.Leave += new System.EventHandler(this.btnShiftToSort_Leave);
            // 
            // btnHeaps
            // 
            this.btnHeaps.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHeaps.FlatAppearance.BorderSize = 0;
            this.btnHeaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaps.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeaps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnHeaps.Location = new System.Drawing.Point(0, 329);
            this.btnHeaps.Name = "btnHeaps";
            this.btnHeaps.Size = new System.Drawing.Size(200, 37);
            this.btnHeaps.TabIndex = 7;
            this.btnHeaps.Text = "Heaps";
            this.btnHeaps.UseVisualStyleBackColor = true;
            this.btnHeaps.Click += new System.EventHandler(this.btnHeaps_Click);
            this.btnHeaps.Leave += new System.EventHandler(this.btnHeaps_Leave);
            // 
            // btnTrees
            // 
            this.btnTrees.AllowDrop = true;
            this.btnTrees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrees.FlatAppearance.BorderSize = 0;
            this.btnTrees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrees.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTrees.Location = new System.Drawing.Point(0, 292);
            this.btnTrees.Name = "btnTrees";
            this.btnTrees.Size = new System.Drawing.Size(200, 37);
            this.btnTrees.TabIndex = 6;
            this.btnTrees.Text = "Sorted BST";
            this.btnTrees.UseVisualStyleBackColor = true;
            this.btnTrees.Click += new System.EventHandler(this.button4_Click);
            this.btnTrees.Leave += new System.EventHandler(this.btnTrees_Leave);
            // 
            // btnQueue
            // 
            this.btnQueue.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQueue.FlatAppearance.BorderSize = 0;
            this.btnQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQueue.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnQueue.Location = new System.Drawing.Point(0, 255);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(200, 37);
            this.btnQueue.TabIndex = 5;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            this.btnQueue.Leave += new System.EventHandler(this.btnQueue_Leave);
            // 
            // btnStack
            // 
            this.btnStack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStack.FlatAppearance.BorderSize = 0;
            this.btnStack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStack.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnStack.Location = new System.Drawing.Point(0, 218);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(200, 37);
            this.btnStack.TabIndex = 4;
            this.btnStack.Text = "Stack";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.button2_Click);
            this.btnStack.Leave += new System.EventHandler(this.btnStack_Leave);
            // 
            // btnLinkedList
            // 
            this.btnLinkedList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLinkedList.FlatAppearance.BorderSize = 0;
            this.btnLinkedList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkedList.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinkedList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLinkedList.Location = new System.Drawing.Point(0, 181);
            this.btnLinkedList.Name = "btnLinkedList";
            this.btnLinkedList.Size = new System.Drawing.Size(200, 37);
            this.btnLinkedList.TabIndex = 3;
            this.btnLinkedList.Text = "Linked List";
            this.btnLinkedList.UseVisualStyleBackColor = true;
            this.btnLinkedList.Click += new System.EventHandler(this.button1_Click);
            this.btnLinkedList.Leave += new System.EventHandler(this.btnLinkedList_Leave);
            // 
            // btnGraphs
            // 
            this.btnGraphs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGraphs.FlatAppearance.BorderSize = 0;
            this.btnGraphs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraphs.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraphs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnGraphs.Location = new System.Drawing.Point(0, 144);
            this.btnGraphs.Name = "btnGraphs";
            this.btnGraphs.Size = new System.Drawing.Size(200, 37);
            this.btnGraphs.TabIndex = 2;
            this.btnGraphs.Text = "Graphs";
            this.btnGraphs.UseVisualStyleBackColor = true;
            this.btnGraphs.Click += new System.EventHandler(this.btnArray_Click);
            this.btnGraphs.Leave += new System.EventHandler(this.btnArray_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 144);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Structures Visualizer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(914, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "X\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.Enter += new System.EventHandler(this.button1_Enter);
            this.button1.Leave += new System.EventHandler(this.button1_Leave);
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Location = new System.Drawing.Point(204, 38);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(748, 539);
            this.pnlFormLoader.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGraphs;
        private System.Windows.Forms.Button btnTrees;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.Button btnLinkedList;
        private System.Windows.Forms.Button btnShiftToSort;
        private System.Windows.Forms.Button btnHeaps;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlFormLoader;
    }
}

