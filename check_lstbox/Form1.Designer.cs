namespace check_lstbox
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
            this.clsbNhap = new System.Windows.Forms.CheckedListBox();
            this.lstXuat = new System.Windows.Forms.ListBox();
            this.btnChuyen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clsbNhap
            // 
            this.clsbNhap.FormattingEnabled = true;
            this.clsbNhap.Location = new System.Drawing.Point(21, 12);
            this.clsbNhap.Name = "clsbNhap";
            this.clsbNhap.Size = new System.Drawing.Size(263, 304);
            this.clsbNhap.TabIndex = 0;
            this.clsbNhap.SelectedIndexChanged += new System.EventHandler(this.clsbNhap_SelectedIndexChanged);
            // 
            // lstXuat
            // 
            this.lstXuat.FormattingEnabled = true;
            this.lstXuat.Location = new System.Drawing.Point(448, 23);
            this.lstXuat.Name = "lstXuat";
            this.lstXuat.Size = new System.Drawing.Size(277, 290);
            this.lstXuat.TabIndex = 1;
            // 
            // btnChuyen
            // 
            this.btnChuyen.Location = new System.Drawing.Point(339, 127);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(75, 23);
            this.btnChuyen.TabIndex = 2;
            this.btnChuyen.Text = "Chuyển ";
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.lstXuat);
            this.Controls.Add(this.clsbNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clsbNhap;
        private System.Windows.Forms.ListBox lstXuat;
        private System.Windows.Forms.Button btnChuyen;
    }
}

