
namespace Project_Mockup.Forms
{
    partial class FormLinkedList
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
            this.btnSInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtboxValue = new System.Windows.Forms.TextBox();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnEInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSInsert
            // 
            this.btnSInsert.Location = new System.Drawing.Point(117, 516);
            this.btnSInsert.Name = "btnSInsert";
            this.btnSInsert.Size = new System.Drawing.Size(86, 20);
            this.btnSInsert.TabIndex = 7;
            this.btnSInsert.Text = "Start Insert";
            this.btnSInsert.UseVisualStyleBackColor = true;
            this.btnSInsert.Click += new System.EventHandler(this.btnSInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(650, 516);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 20);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtboxValue
            // 
            this.txtboxValue.Location = new System.Drawing.Point(11, 516);
            this.txtboxValue.Name = "txtboxValue";
            this.txtboxValue.Size = new System.Drawing.Size(100, 20);
            this.txtboxValue.TabIndex = 5;
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Location = new System.Drawing.Point(-4, 10);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(756, 475);
            this.pnlFormLoader.TabIndex = 4;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblValue.Location = new System.Drawing.Point(12, 488);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(57, 23);
            this.lblValue.TabIndex = 9;
            this.lblValue.Text = "Value:";
            // 
            // btnEInsert
            // 
            this.btnEInsert.Location = new System.Drawing.Point(209, 516);
            this.btnEInsert.Name = "btnEInsert";
            this.btnEInsert.Size = new System.Drawing.Size(86, 20);
            this.btnEInsert.TabIndex = 10;
            this.btnEInsert.Text = "End Insert";
            this.btnEInsert.UseVisualStyleBackColor = true;
            this.btnEInsert.Click += new System.EventHandler(this.btnEInsert_Click);
            // 
            // FormLinkedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(748, 539);
            this.Controls.Add(this.btnEInsert);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.btnSInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtboxValue);
            this.Controls.Add(this.pnlFormLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLinkedList";
            this.Text = "FormLinkedList";
            this.Load += new System.EventHandler(this.FormLinkedList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtboxValue;
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnEInsert;
    }
}