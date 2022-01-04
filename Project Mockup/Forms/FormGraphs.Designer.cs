
namespace Project_Mockup.Forms
{
    partial class FormGraphs
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
            this.lblNodeOne = new System.Windows.Forms.Label();
            this.txtboxNodeOne = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtboxNodeTwo = new System.Windows.Forms.TextBox();
            this.lblNodeTwo = new System.Windows.Forms.Label();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblNodeOne
            // 
            this.lblNodeOne.AutoSize = true;
            this.lblNodeOne.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNodeOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblNodeOne.Location = new System.Drawing.Point(12, 492);
            this.lblNodeOne.Name = "lblNodeOne";
            this.lblNodeOne.Size = new System.Drawing.Size(69, 23);
            this.lblNodeOne.TabIndex = 0;
            this.lblNodeOne.Text = "Node 1:";
            // 
            // txtboxNodeOne
            // 
            this.txtboxNodeOne.Location = new System.Drawing.Point(12, 518);
            this.txtboxNodeOne.Name = "txtboxNodeOne";
            this.txtboxNodeOne.Size = new System.Drawing.Size(100, 20);
            this.txtboxNodeOne.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(672, 516);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtboxNodeTwo
            // 
            this.txtboxNodeTwo.Location = new System.Drawing.Point(118, 519);
            this.txtboxNodeTwo.Name = "txtboxNodeTwo";
            this.txtboxNodeTwo.Size = new System.Drawing.Size(100, 20);
            this.txtboxNodeTwo.TabIndex = 4;
            // 
            // lblNodeTwo
            // 
            this.lblNodeTwo.AutoSize = true;
            this.lblNodeTwo.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNodeTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblNodeTwo.Location = new System.Drawing.Point(118, 493);
            this.lblNodeTwo.Name = "lblNodeTwo";
            this.lblNodeTwo.Size = new System.Drawing.Size(69, 23);
            this.lblNodeTwo.TabIndex = 3;
            this.lblNodeTwo.Text = "Node 2:";
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Location = new System.Drawing.Point(1, 1);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(746, 461);
            this.pnlFormLoader.TabIndex = 5;
            // 
            // FormGraphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(748, 539);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.txtboxNodeTwo);
            this.Controls.Add(this.lblNodeTwo);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtboxNodeOne);
            this.Controls.Add(this.lblNodeOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGraphs";
            this.Text = "FormGraphs";
            this.Load += new System.EventHandler(this.FormGraphs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNodeOne;
        private System.Windows.Forms.TextBox txtboxNodeOne;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtboxNodeTwo;
        private System.Windows.Forms.Label lblNodeTwo;
        private System.Windows.Forms.Panel pnlFormLoader;
    }
}