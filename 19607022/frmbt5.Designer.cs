namespace _19607022
{
    partial class frmbt5
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
            this.lblDanhsachsv = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsbLopA = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsbLopB = new System.Windows.Forms.ListBox();
            this.btnPhai = new System.Windows.Forms.Button();
            this.btnTrai = new System.Windows.Forms.Button();
            this.btnAllphai = new System.Windows.Forms.Button();
            this.btnAlltrai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKetthuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDanhsachsv
            // 
            this.lblDanhsachsv.AutoSize = true;
            this.lblDanhsachsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhsachsv.Location = new System.Drawing.Point(86, 9);
            this.lblDanhsachsv.Name = "lblDanhsachsv";
            this.lblDanhsachsv.Size = new System.Drawing.Size(279, 26);
            this.lblDanhsachsv.TabIndex = 0;
            this.lblDanhsachsv.Text = "DANH SÁCH SINH VIÊN";
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Location = new System.Drawing.Point(28, 46);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(57, 13);
            this.lblHoten.TabIndex = 1;
            this.lblHoten.Text = "Họ và tên:";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(91, 43);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(258, 20);
            this.txtHoten.TabIndex = 2;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(368, 41);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapnhat.TabIndex = 3;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsbLopA);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 200);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // lsbLopA
            // 
            this.lsbLopA.FormattingEnabled = true;
            this.lsbLopA.Location = new System.Drawing.Point(0, 17);
            this.lsbLopA.Name = "lsbLopA";
            this.lsbLopA.Size = new System.Drawing.Size(160, 173);
            this.lsbLopA.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsbLopB);
            this.groupBox2.Location = new System.Drawing.Point(294, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 200);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // lsbLopB
            // 
            this.lsbLopB.FormattingEnabled = true;
            this.lsbLopB.Location = new System.Drawing.Point(6, 16);
            this.lsbLopB.Name = "lsbLopB";
            this.lsbLopB.Size = new System.Drawing.Size(160, 173);
            this.lsbLopB.TabIndex = 1;
            // 
            // btnPhai
            // 
            this.btnPhai.Location = new System.Drawing.Point(184, 122);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(44, 23);
            this.btnPhai.TabIndex = 6;
            this.btnPhai.Text = ">";
            this.btnPhai.UseVisualStyleBackColor = true;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // btnTrai
            // 
            this.btnTrai.Location = new System.Drawing.Point(244, 122);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(44, 23);
            this.btnTrai.TabIndex = 7;
            this.btnTrai.Text = "<";
            this.btnTrai.UseVisualStyleBackColor = true;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // btnAllphai
            // 
            this.btnAllphai.Location = new System.Drawing.Point(184, 165);
            this.btnAllphai.Name = "btnAllphai";
            this.btnAllphai.Size = new System.Drawing.Size(44, 23);
            this.btnAllphai.TabIndex = 8;
            this.btnAllphai.Text = ">>";
            this.btnAllphai.UseVisualStyleBackColor = true;
            this.btnAllphai.Click += new System.EventHandler(this.btnAllphai_Click);
            // 
            // btnAlltrai
            // 
            this.btnAlltrai.Location = new System.Drawing.Point(244, 165);
            this.btnAlltrai.Name = "btnAlltrai";
            this.btnAlltrai.Size = new System.Drawing.Size(44, 23);
            this.btnAlltrai.TabIndex = 9;
            this.btnAlltrai.Text = "<<";
            this.btnAlltrai.UseVisualStyleBackColor = true;
            this.btnAlltrai.Click += new System.EventHandler(this.btnAlltrai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(47, 275);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKetthuc
            // 
            this.btnKetthuc.Location = new System.Drawing.Point(346, 275);
            this.btnKetthuc.Name = "btnKetthuc";
            this.btnKetthuc.Size = new System.Drawing.Size(75, 23);
            this.btnKetthuc.TabIndex = 11;
            this.btnKetthuc.Text = "Kết thúc";
            this.btnKetthuc.UseVisualStyleBackColor = true;
            this.btnKetthuc.Click += new System.EventHandler(this.btnKetthuc_Click);
            // 
            // frmbt5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 305);
            this.Controls.Add(this.btnKetthuc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnAlltrai);
            this.Controls.Add(this.btnAllphai);
            this.Controls.Add(this.btnTrai);
            this.Controls.Add(this.btnPhai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.lblHoten);
            this.Controls.Add(this.lblDanhsachsv);
            this.MaximizeBox = false;
            this.Name = "frmbt5";
            this.Text = "Bài 5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhsachsv;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsbLopA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lsbLopB;
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.Button btnTrai;
        private System.Windows.Forms.Button btnAllphai;
        private System.Windows.Forms.Button btnAlltrai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKetthuc;
    }
}