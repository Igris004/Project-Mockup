
namespace Project_Mockup.Forms
{
    partial class FormQueue
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
            this.btnDequeue = new System.Windows.Forms.Button();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.txtboxInsert = new System.Windows.Forms.TextBox();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnDequeue
            // 
            this.btnDequeue.Location = new System.Drawing.Point(687, 518);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(65, 19);
            this.btnDequeue.TabIndex = 7;
            this.btnDequeue.Text = "Dequeue";
            this.btnDequeue.UseVisualStyleBackColor = true;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.Location = new System.Drawing.Point(102, 518);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(65, 19);
            this.btnEnqueue.TabIndex = 6;
            this.btnEnqueue.Text = "Enqueue";
            this.btnEnqueue.UseVisualStyleBackColor = true;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // txtboxInsert
            // 
            this.txtboxInsert.Location = new System.Drawing.Point(-1, 517);
            this.txtboxInsert.Name = "txtboxInsert";
            this.txtboxInsert.Size = new System.Drawing.Size(97, 20);
            this.txtboxInsert.TabIndex = 5;
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Location = new System.Drawing.Point(-1, 0);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(753, 461);
            this.pnlFormLoader.TabIndex = 4;
            // 
            // FormQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(748, 539);
            this.Controls.Add(this.btnDequeue);
            this.Controls.Add(this.btnEnqueue);
            this.Controls.Add(this.txtboxInsert);
            this.Controls.Add(this.pnlFormLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQueue";
            this.Text = "FormQueue";
            this.Load += new System.EventHandler(this.FormQueue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.TextBox txtboxInsert;
        private System.Windows.Forms.Panel pnlFormLoader;
    }
}