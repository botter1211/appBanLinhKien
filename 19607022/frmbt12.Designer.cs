namespace _19607022
{
    partial class frmbt12
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
            this.lsvKetqua = new System.Windows.Forms.ListView();
            this.lblSL = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnRD = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnXoachon = new System.Windows.Forms.Button();
            this.btnTimMax = new System.Windows.Forms.Button();
            this.btnXoaMax = new System.Windows.Forms.Button();
            this.lblSLN = new System.Windows.Forms.Label();
            this.lblVTSLN = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsvKetqua
            // 
            this.lsvKetqua.BackColor = System.Drawing.SystemColors.Window;
            this.lsvKetqua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvKetqua.Location = new System.Drawing.Point(195, 31);
            this.lsvKetqua.MultiSelect = false;
            this.lsvKetqua.Name = "lsvKetqua";
            this.lsvKetqua.Size = new System.Drawing.Size(180, 186);
            this.lsvKetqua.TabIndex = 0;
            this.lsvKetqua.UseCompatibleStateImageBehavior = false;
            this.lsvKetqua.View = System.Windows.Forms.View.Details;
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(180, 9);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(158, 13);
            this.lblSL.TabIndex = 1;
            this.lblSL.Text = "Số lượng số có trong danh sách";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(50, 12);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 2;
            this.txtN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRD
            // 
            this.btnRD.Location = new System.Drawing.Point(12, 38);
            this.btnRD.Name = "btnRD";
            this.btnRD.Size = new System.Drawing.Size(168, 30);
            this.btnRD.TabIndex = 3;
            this.btnRD.Text = "Số ngẫu nhiên";
            this.btnRD.UseVisualStyleBackColor = true;
            this.btnRD.Click += new System.EventHandler(this.btnRD_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm vào danh sách";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnXoachon
            // 
            this.btnXoachon.Location = new System.Drawing.Point(12, 110);
            this.btnXoachon.Name = "btnXoachon";
            this.btnXoachon.Size = new System.Drawing.Size(168, 30);
            this.btnXoachon.TabIndex = 5;
            this.btnXoachon.Text = "Xóa số đang được chọn";
            this.btnXoachon.UseVisualStyleBackColor = true;
            this.btnXoachon.Click += new System.EventHandler(this.btnXoachon_Click);
            // 
            // btnTimMax
            // 
            this.btnTimMax.Location = new System.Drawing.Point(12, 146);
            this.btnTimMax.Name = "btnTimMax";
            this.btnTimMax.Size = new System.Drawing.Size(168, 30);
            this.btnTimMax.TabIndex = 6;
            this.btnTimMax.Text = "Tìm số lớn nhất";
            this.btnTimMax.UseVisualStyleBackColor = true;
            this.btnTimMax.Click += new System.EventHandler(this.btnTimMax_Click);
            // 
            // btnXoaMax
            // 
            this.btnXoaMax.Location = new System.Drawing.Point(12, 182);
            this.btnXoaMax.Name = "btnXoaMax";
            this.btnXoaMax.Size = new System.Drawing.Size(168, 30);
            this.btnXoaMax.TabIndex = 7;
            this.btnXoaMax.Text = "Xóa số lớn nhất";
            this.btnXoaMax.UseVisualStyleBackColor = true;
            this.btnXoaMax.Click += new System.EventHandler(this.btnXoaMax_Click);
            // 
            // lblSLN
            // 
            this.lblSLN.AutoSize = true;
            this.lblSLN.Location = new System.Drawing.Point(125, 220);
            this.lblSLN.Name = "lblSLN";
            this.lblSLN.Size = new System.Drawing.Size(107, 13);
            this.lblSLN.TabIndex = 8;
            this.lblSLN.Text = "Số có giá trị lớn nhất:";
            // 
            // lblVTSLN
            // 
            this.lblVTSLN.AutoSize = true;
            this.lblVTSLN.Location = new System.Drawing.Point(125, 239);
            this.lblVTSLN.Name = "lblVTSLN";
            this.lblVTSLN.Size = new System.Drawing.Size(148, 13);
            this.lblVTSLN.TabIndex = 9;
            this.lblVTSLN.Text = "Số lớn nhất xuất hiện tại vị trí:";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(344, 9);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(0, 13);
            this.lblN.TabIndex = 10;
            // 
            // frmbt12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 261);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblVTSLN);
            this.Controls.Add(this.lblSLN);
            this.Controls.Add(this.btnXoaMax);
            this.Controls.Add(this.btnTimMax);
            this.Controls.Add(this.btnXoachon);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRD);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.lsvKetqua);
            this.Name = "frmbt12";
            this.Text = "Bài 12";
            this.Load += new System.EventHandler(this.frmbt12_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvKetqua;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnRD;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnXoachon;
        private System.Windows.Forms.Button btnTimMax;
        private System.Windows.Forms.Button btnXoaMax;
        private System.Windows.Forms.Label lblSLN;
        private System.Windows.Forms.Label lblVTSLN;
        private System.Windows.Forms.Label lblN;
    }
}