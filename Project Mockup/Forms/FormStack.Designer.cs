
namespace Project_Mockup.Scripts
{
    partial class FormStack
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
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.txtboxInsert = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Location = new System.Drawing.Point(-3, 2);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(756, 461);
            this.pnlFormLoader.TabIndex = 0;
            // 
            // txtboxInsert
            // 
            this.txtboxInsert.Location = new System.Drawing.Point(12, 520);
            this.txtboxInsert.Name = "txtboxInsert";
            this.txtboxInsert.Size = new System.Drawing.Size(100, 20);
            this.txtboxInsert.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(118, 520);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(68, 19);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Push";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(651, 520);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(68, 19);
            this.btnPop.TabIndex = 3;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // FormStack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(748, 539);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtboxInsert);
            this.Controls.Add(this.pnlFormLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStack";
            this.Text = "FormStack";
            this.Load += new System.EventHandler(this.FormStack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.TextBox txtboxInsert;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnPop;
    }
}