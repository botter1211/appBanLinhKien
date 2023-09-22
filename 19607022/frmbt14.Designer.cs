namespace _19607022
{
    partial class frmbt14
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
            this.cboSoCanh = new System.Windows.Forms.ComboBox();
            this.lblSoO = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // cboSoCanh
            // 
            this.cboSoCanh.FormattingEnabled = true;
            this.cboSoCanh.Location = new System.Drawing.Point(15, 25);
            this.cboSoCanh.Name = "cboSoCanh";
            this.cboSoCanh.Size = new System.Drawing.Size(121, 21);
            this.cboSoCanh.TabIndex = 0;
            this.cboSoCanh.SelectedIndexChanged += new System.EventHandler(this.cboSoCanh_SelectedIndexChanged);
            // 
            // lblSoO
            // 
            this.lblSoO.AutoSize = true;
            this.lblSoO.Location = new System.Drawing.Point(12, 9);
            this.lblSoO.Name = "lblSoO";
            this.lblSoO.Size = new System.Drawing.Size(106, 13);
            this.lblSoO.TabIndex = 1;
            this.lblSoO.Text = "Số ô / 1 cạnh (3 -10)";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 325);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmbt14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 389);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSoO);
            this.Controls.Add(this.cboSoCanh);
            this.Name = "frmbt14";
            this.Text = "frmbt14";
            this.Load += new System.EventHandler(this.frmbt14_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSoCanh;
        private System.Windows.Forms.Label lblSoO;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}