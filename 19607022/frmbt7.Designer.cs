namespace _19607022
{
    partial class frmbt7
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
            this.lblSudung = new System.Windows.Forms.Label();
            this.txtNhapchuoi = new System.Windows.Forms.TextBox();
            this.lblNhapdulieu = new System.Windows.Forms.Label();
            this.lblChuoitim = new System.Windows.Forms.Label();
            this.lblChuoithaythe = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.txtThaythe = new System.Windows.Forms.TextBox();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThaythe = new System.Windows.Forms.Button();
            this.btnInhoa = new System.Windows.Forms.Button();
            this.btnInthuong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSudung
            // 
            this.lblSudung.AutoSize = true;
            this.lblSudung.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSudung.Location = new System.Drawing.Point(109, 9);
            this.lblSudung.Name = "lblSudung";
            this.lblSudung.Size = new System.Drawing.Size(318, 26);
            this.lblSudung.TabIndex = 0;
            this.lblSudung.Text = "Sử dụng các hàm xử lý chuỗi";
            // 
            // txtNhapchuoi
            // 
            this.txtNhapchuoi.Location = new System.Drawing.Point(90, 49);
            this.txtNhapchuoi.Multiline = true;
            this.txtNhapchuoi.Name = "txtNhapchuoi";
            this.txtNhapchuoi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNhapchuoi.Size = new System.Drawing.Size(405, 131);
            this.txtNhapchuoi.TabIndex = 1;
            this.txtNhapchuoi.TextChanged += new System.EventHandler(this.txtNhapchuoi_TextChanged);
            // 
            // lblNhapdulieu
            // 
            this.lblNhapdulieu.AutoSize = true;
            this.lblNhapdulieu.Location = new System.Drawing.Point(12, 52);
            this.lblNhapdulieu.Name = "lblNhapdulieu";
            this.lblNhapdulieu.Size = new System.Drawing.Size(70, 13);
            this.lblNhapdulieu.TabIndex = 2;
            this.lblNhapdulieu.Text = "Nhập dữ liệu:";
            // 
            // lblChuoitim
            // 
            this.lblChuoitim.AutoSize = true;
            this.lblChuoitim.Location = new System.Drawing.Point(38, 186);
            this.lblChuoitim.Name = "lblChuoitim";
            this.lblChuoitim.Size = new System.Drawing.Size(53, 13);
            this.lblChuoitim.TabIndex = 3;
            this.lblChuoitim.Text = "Chuỗi tìm:";
            // 
            // lblChuoithaythe
            // 
            this.lblChuoithaythe.AutoSize = true;
            this.lblChuoithaythe.Location = new System.Drawing.Point(12, 211);
            this.lblChuoithaythe.Name = "lblChuoithaythe";
            this.lblChuoithaythe.Size = new System.Drawing.Size(78, 13);
            this.lblChuoithaythe.TabIndex = 4;
            this.lblChuoithaythe.Text = "Chuỗi thay thế:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(97, 183);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(199, 20);
            this.txtTim.TabIndex = 5;
            // 
            // txtThaythe
            // 
            this.txtThaythe.Location = new System.Drawing.Point(97, 208);
            this.txtThaythe.Name = "txtThaythe";
            this.txtThaythe.Size = new System.Drawing.Size(199, 20);
            this.txtThaythe.TabIndex = 6;
            // 
            // lblKetqua
            // 
            this.lblKetqua.AutoSize = true;
            this.lblKetqua.Location = new System.Drawing.Point(56, 235);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(44, 13);
            this.lblKetqua.TabIndex = 7;
            this.lblKetqua.Text = "Kết quả";
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(15, 251);
            this.txtKetqua.Multiline = true;
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKetqua.Size = new System.Drawing.Size(352, 122);
            this.txtKetqua.TabIndex = 8;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(397, 202);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(98, 23);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThaythe
            // 
            this.btnThaythe.Location = new System.Drawing.Point(397, 237);
            this.btnThaythe.Name = "btnThaythe";
            this.btnThaythe.Size = new System.Drawing.Size(98, 23);
            this.btnThaythe.TabIndex = 10;
            this.btnThaythe.Text = "Thay thế";
            this.btnThaythe.UseVisualStyleBackColor = true;
            this.btnThaythe.Click += new System.EventHandler(this.btnThaythe_Click);
            // 
            // btnInhoa
            // 
            this.btnInhoa.Location = new System.Drawing.Point(397, 271);
            this.btnInhoa.Name = "btnInhoa";
            this.btnInhoa.Size = new System.Drawing.Size(98, 23);
            this.btnInhoa.TabIndex = 11;
            this.btnInhoa.Text = "In hoa";
            this.btnInhoa.UseVisualStyleBackColor = true;
            this.btnInhoa.Click += new System.EventHandler(this.btnInhoa_Click);
            // 
            // btnInthuong
            // 
            this.btnInthuong.Location = new System.Drawing.Point(397, 304);
            this.btnInthuong.Name = "btnInthuong";
            this.btnInthuong.Size = new System.Drawing.Size(98, 23);
            this.btnInthuong.TabIndex = 12;
            this.btnInthuong.Text = "In thường";
            this.btnInthuong.UseVisualStyleBackColor = true;
            this.btnInthuong.Click += new System.EventHandler(this.btnInthuong_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(397, 350);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 23);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmbt7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 385);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnInthuong);
            this.Controls.Add(this.btnInhoa);
            this.Controls.Add(this.btnThaythe);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.txtThaythe);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.lblChuoithaythe);
            this.Controls.Add(this.lblChuoitim);
            this.Controls.Add(this.lblNhapdulieu);
            this.Controls.Add(this.txtNhapchuoi);
            this.Controls.Add(this.lblSudung);
            this.Name = "frmbt7";
            this.Text = "frmbt7";
            this.Load += new System.EventHandler(this.frmbt7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSudung;
        private System.Windows.Forms.TextBox txtNhapchuoi;
        private System.Windows.Forms.Label lblNhapdulieu;
        private System.Windows.Forms.Label lblChuoitim;
        private System.Windows.Forms.Label lblChuoithaythe;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.TextBox txtThaythe;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThaythe;
        private System.Windows.Forms.Button btnInhoa;
        private System.Windows.Forms.Button btnInthuong;
        private System.Windows.Forms.Button btnThoat;
    }
}