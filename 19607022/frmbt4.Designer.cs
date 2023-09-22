namespace _19607022
{
    partial class frmbt4
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaphantucuoi = new System.Windows.Forms.Button();
            this.btnXoaphantudau = new System.Windows.Forms.Button();
            this.btnXoaphantuchon = new System.Windows.Forms.Button();
            this.btnChonlecuoi = new System.Windows.Forms.Button();
            this.btnChonchandau = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnKetthuc = new System.Windows.Forms.Button();
            this.lsbDanhsach = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(12, 22);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(85, 13);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "Nhập sô nguyên";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(103, 19);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(248, 20);
            this.txtNhap.TabIndex = 1;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(357, 17);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapnhat.TabIndex = 2;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaphantucuoi);
            this.groupBox1.Controls.Add(this.btnXoaphantudau);
            this.groupBox1.Controls.Add(this.btnXoaphantuchon);
            this.groupBox1.Controls.Add(this.btnChonlecuoi);
            this.groupBox1.Controls.Add(this.btnChonchandau);
            this.groupBox1.Controls.Add(this.btnTang2);
            this.groupBox1.Location = new System.Drawing.Point(239, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 236);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnXoaphantucuoi
            // 
            this.btnXoaphantucuoi.Location = new System.Drawing.Point(6, 164);
            this.btnXoaphantucuoi.Name = "btnXoaphantucuoi";
            this.btnXoaphantucuoi.Size = new System.Drawing.Size(208, 23);
            this.btnXoaphantucuoi.TabIndex = 8;
            this.btnXoaphantucuoi.Text = "Xóa phần tử cuối";
            this.btnXoaphantucuoi.UseVisualStyleBackColor = true;
            this.btnXoaphantucuoi.Click += new System.EventHandler(this.btnXoaphantucuoi_Click);
            // 
            // btnXoaphantudau
            // 
            this.btnXoaphantudau.Location = new System.Drawing.Point(6, 135);
            this.btnXoaphantudau.Name = "btnXoaphantudau";
            this.btnXoaphantudau.Size = new System.Drawing.Size(208, 23);
            this.btnXoaphantudau.TabIndex = 7;
            this.btnXoaphantudau.Text = "Xóa phần tử đầu";
            this.btnXoaphantudau.UseVisualStyleBackColor = true;
            this.btnXoaphantudau.Click += new System.EventHandler(this.btnXoaphantudau_Click);
            // 
            // btnXoaphantuchon
            // 
            this.btnXoaphantuchon.Location = new System.Drawing.Point(6, 106);
            this.btnXoaphantuchon.Name = "btnXoaphantuchon";
            this.btnXoaphantuchon.Size = new System.Drawing.Size(208, 23);
            this.btnXoaphantuchon.TabIndex = 6;
            this.btnXoaphantuchon.Text = "Xóa phần tử đang chọn";
            this.btnXoaphantuchon.UseVisualStyleBackColor = true;
            this.btnXoaphantuchon.Click += new System.EventHandler(this.btnXoaphantuchon_Click);
            // 
            // btnChonlecuoi
            // 
            this.btnChonlecuoi.Location = new System.Drawing.Point(6, 77);
            this.btnChonlecuoi.Name = "btnChonlecuoi";
            this.btnChonlecuoi.Size = new System.Drawing.Size(208, 23);
            this.btnChonlecuoi.TabIndex = 2;
            this.btnChonlecuoi.Text = "Chọn số lẻ cuối";
            this.btnChonlecuoi.UseVisualStyleBackColor = true;
            this.btnChonlecuoi.Click += new System.EventHandler(this.btnChonlecuoi_Click);
            // 
            // btnChonchandau
            // 
            this.btnChonchandau.Location = new System.Drawing.Point(6, 48);
            this.btnChonchandau.Name = "btnChonchandau";
            this.btnChonchandau.Size = new System.Drawing.Size(208, 23);
            this.btnChonchandau.TabIndex = 1;
            this.btnChonchandau.Text = "Chọn số chẵn đầu";
            this.btnChonchandau.UseVisualStyleBackColor = true;
            this.btnChonchandau.Click += new System.EventHandler(this.btnChonchandau_Click);
            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(6, 19);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(208, 23);
            this.btnTang2.TabIndex = 0;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnKetthuc
            // 
            this.btnKetthuc.Location = new System.Drawing.Point(15, 291);
            this.btnKetthuc.Name = "btnKetthuc";
            this.btnKetthuc.Size = new System.Drawing.Size(444, 23);
            this.btnKetthuc.TabIndex = 5;
            this.btnKetthuc.Text = "Kết thúc";
            this.btnKetthuc.UseVisualStyleBackColor = true;
            this.btnKetthuc.Click += new System.EventHandler(this.btnKetthuc_Click);
            // 
            // lsbDanhsach
            // 
            this.lsbDanhsach.FormattingEnabled = true;
            this.lsbDanhsach.Location = new System.Drawing.Point(12, 51);
            this.lsbDanhsach.Name = "lsbDanhsach";
            this.lsbDanhsach.Size = new System.Drawing.Size(221, 225);
            this.lsbDanhsach.TabIndex = 6;
            // 
            // frmbt4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 326);
            this.Controls.Add(this.lsbDanhsach);
            this.Controls.Add(this.btnKetthuc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lblN);
            this.MaximizeBox = false;
            this.Name = "frmbt4";
            this.Text = "Bài 4";
            this.Load += new System.EventHandler(this.frmbt4_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKetthuc;
        private System.Windows.Forms.Button btnXoaphantucuoi;
        private System.Windows.Forms.Button btnXoaphantudau;
        private System.Windows.Forms.Button btnXoaphantuchon;
        private System.Windows.Forms.Button btnChonlecuoi;
        private System.Windows.Forms.Button btnChonchandau;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.ListBox lsbDanhsach;
    }
}