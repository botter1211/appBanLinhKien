namespace _19607022
{
    partial class frmbt3
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
            this.btnRD = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBQ = new System.Windows.Forms.Button();
            this.btnLK = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRD);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnBQ);
            this.groupBox1.Controls.Add(this.btnLK);
            this.groupBox1.Controls.Add(this.txtN);
            this.groupBox1.Controls.Add(this.lblN);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnRD
            // 
            this.btnRD.Location = new System.Drawing.Point(119, 41);
            this.btnRD.Name = "btnRD";
            this.btnRD.Size = new System.Drawing.Size(75, 23);
            this.btnRD.TabIndex = 5;
            this.btnRD.Text = "Random";
            this.btnRD.UseVisualStyleBackColor = true;
            this.btnRD.Click += new System.EventHandler(this.btnRD_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(281, 27);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBQ
            // 
            this.btnBQ.Location = new System.Drawing.Point(200, 27);
            this.btnBQ.Name = "btnBQ";
            this.btnBQ.Size = new System.Drawing.Size(75, 23);
            this.btnBQ.TabIndex = 3;
            this.btnBQ.Text = "Bỏ qua";
            this.btnBQ.UseVisualStyleBackColor = true;
            this.btnBQ.Click += new System.EventHandler(this.btnBQ_Click);
            // 
            // btnLK
            // 
            this.btnLK.Location = new System.Drawing.Point(119, 13);
            this.btnLK.Name = "btnLK";
            this.btnLK.Size = new System.Drawing.Size(75, 23);
            this.btnLK.TabIndex = 2;
            this.btnLK.Text = "Liệt kê";
            this.btnLK.UseVisualStyleBackColor = true;
            this.btnLK.Click += new System.EventHandler(this.btnLK_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(6, 29);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 1;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(6, 13);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(47, 13);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "Nhập N:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTC);
            this.groupBox2.Controls.Add(this.lblTC);
            this.groupBox2.Controls.Add(this.txtKQ);
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các số nguyên tố";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(258, 159);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 2;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(190, 162);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(62, 13);
            this.lblTC.TabIndex = 1;
            this.lblTC.Text = "Tổng cộng:";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(6, 19);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(352, 134);
            this.txtKQ.TabIndex = 0;
            // 
            // frmbt3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 285);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmbt3";
            this.Text = "Bài 3";
            this.Load += new System.EventHandler(this.frmbt3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBQ;
        private System.Windows.Forms.Button btnLK;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnRD;
    }
}