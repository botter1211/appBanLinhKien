namespace _19607022
{
    partial class frmbt6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnDemchan = new System.Windows.Forms.Button();
            this.btnTongmang = new System.Windows.Forms.Button();
            this.btnXuatle = new System.Windows.Forms.Button();
            this.btnTimMaxMin = new System.Windows.Forms.Button();
            this.btnXuatNT = new System.Windows.Forms.Button();
            this.btnKetthuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhap);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mảng nhập";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(6, 19);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(218, 87);
            this.txtNhap.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKQ);
            this.groupBox2.Location = new System.Drawing.Point(248, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả tính toán";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(6, 19);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(218, 87);
            this.txtKQ.TabIndex = 1;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(18, 142);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(218, 28);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Nhập mảng";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnDemchan
            // 
            this.btnDemchan.Location = new System.Drawing.Point(254, 142);
            this.btnDemchan.Name = "btnDemchan";
            this.btnDemchan.Size = new System.Drawing.Size(218, 28);
            this.btnDemchan.TabIndex = 3;
            this.btnDemchan.Text = "Đếm phần tử chẵn";
            this.btnDemchan.UseVisualStyleBackColor = true;
            this.btnDemchan.Click += new System.EventHandler(this.btnDemchan_Click);
            // 
            // btnTongmang
            // 
            this.btnTongmang.Location = new System.Drawing.Point(18, 185);
            this.btnTongmang.Name = "btnTongmang";
            this.btnTongmang.Size = new System.Drawing.Size(218, 28);
            this.btnTongmang.TabIndex = 4;
            this.btnTongmang.Text = "Tính tổng mảng";
            this.btnTongmang.UseVisualStyleBackColor = true;
            this.btnTongmang.Click += new System.EventHandler(this.btnTongmang_Click);
            // 
            // btnXuatle
            // 
            this.btnXuatle.Location = new System.Drawing.Point(254, 185);
            this.btnXuatle.Name = "btnXuatle";
            this.btnXuatle.Size = new System.Drawing.Size(218, 28);
            this.btnXuatle.TabIndex = 5;
            this.btnXuatle.Text = "Xuất các phần tử lẻ";
            this.btnXuatle.UseVisualStyleBackColor = true;
            this.btnXuatle.Click += new System.EventHandler(this.btnXuatle_Click);
            // 
            // btnTimMaxMin
            // 
            this.btnTimMaxMin.Location = new System.Drawing.Point(18, 228);
            this.btnTimMaxMin.Name = "btnTimMaxMin";
            this.btnTimMaxMin.Size = new System.Drawing.Size(218, 28);
            this.btnTimMaxMin.TabIndex = 6;
            this.btnTimMaxMin.Text = "Tìm Max-Min của mảng";
            this.btnTimMaxMin.UseVisualStyleBackColor = true;
            this.btnTimMaxMin.Click += new System.EventHandler(this.btnTimMaxMin_Click);
            // 
            // btnXuatNT
            // 
            this.btnXuatNT.Location = new System.Drawing.Point(254, 228);
            this.btnXuatNT.Name = "btnXuatNT";
            this.btnXuatNT.Size = new System.Drawing.Size(218, 28);
            this.btnXuatNT.TabIndex = 7;
            this.btnXuatNT.Text = "Xuất các số nguyên tố";
            this.btnXuatNT.UseVisualStyleBackColor = true;
            this.btnXuatNT.Click += new System.EventHandler(this.btnXuatNT_Click);
            // 
            // btnKetthuc
            // 
            this.btnKetthuc.Location = new System.Drawing.Point(188, 265);
            this.btnKetthuc.Name = "btnKetthuc";
            this.btnKetthuc.Size = new System.Drawing.Size(112, 32);
            this.btnKetthuc.TabIndex = 8;
            this.btnKetthuc.Text = "Kết thúc";
            this.btnKetthuc.UseVisualStyleBackColor = true;
            this.btnKetthuc.Click += new System.EventHandler(this.btnKetthuc_Click);
            // 
            // frmbt6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 309);
            this.Controls.Add(this.btnKetthuc);
            this.Controls.Add(this.btnXuatNT);
            this.Controls.Add(this.btnTimMaxMin);
            this.Controls.Add(this.btnXuatle);
            this.Controls.Add(this.btnTongmang);
            this.Controls.Add(this.btnDemchan);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmbt6";
            this.Text = "Bài 6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnDemchan;
        private System.Windows.Forms.Button btnTongmang;
        private System.Windows.Forms.Button btnXuatle;
        private System.Windows.Forms.Button btnTimMaxMin;
        private System.Windows.Forms.Button btnXuatNT;
        private System.Windows.Forms.Button btnKetthuc;
    }
}