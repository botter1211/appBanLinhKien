namespace _19607022
{
    partial class frmbt8
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
            this.lblN = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnRD = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSapxep = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSapxep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(12, 9);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(101, 13);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "Các số cần sắp xếp";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(12, 36);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(347, 20);
            this.txtN.TabIndex = 1;
            // 
            // btnRD
            // 
            this.btnRD.Location = new System.Drawing.Point(365, 34);
            this.btnRD.Name = "btnRD";
            this.btnRD.Size = new System.Drawing.Size(75, 23);
            this.btnRD.TabIndex = 2;
            this.btnRD.Text = "Random";
            this.btnRD.UseVisualStyleBackColor = true;
            this.btnRD.Click += new System.EventHandler(this.btnRD_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(446, 34);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSapxep
            // 
            this.btnSapxep.Location = new System.Drawing.Point(365, 63);
            this.btnSapxep.Name = "btnSapxep";
            this.btnSapxep.Size = new System.Drawing.Size(156, 23);
            this.btnSapxep.TabIndex = 4;
            this.btnSapxep.Text = "Sắp xếp";
            this.btnSapxep.UseVisualStyleBackColor = true;
            this.btnSapxep.Click += new System.EventHandler(this.btnSapxep_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(365, 92);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(156, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kết quả sau khi sắp xếp";
            // 
            // txtSapxep
            // 
            this.txtSapxep.Location = new System.Drawing.Point(12, 94);
            this.txtSapxep.Name = "txtSapxep";
            this.txtSapxep.Size = new System.Drawing.Size(347, 20);
            this.txtSapxep.TabIndex = 7;
            // 
            // frmbt8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 135);
            this.Controls.Add(this.txtSapxep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSapxep);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnRD);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblN);
            this.MaximizeBox = false;
            this.Name = "frmbt8";
            this.Text = "Bài 8";
            this.Load += new System.EventHandler(this.frmbt8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnRD;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSapxep;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSapxep;
    }
}