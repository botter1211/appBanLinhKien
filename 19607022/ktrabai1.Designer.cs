namespace _19607022
{
    partial class ktrabai1
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
            this.lv1 = new System.Windows.Forms.ListView();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.btnMua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lv2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lv1
            // 
            this.lv1.Location = new System.Drawing.Point(12, 12);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(278, 243);
            this.lv1.TabIndex = 0;
            this.lv1.UseCompatibleStateImageBehavior = false;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(305, 57);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(100, 20);
            this.txtSoluong.TabIndex = 2;
            // 
            // btnMua
            // 
            this.btnMua.Location = new System.Drawing.Point(317, 83);
            this.btnMua.Name = "btnMua";
            this.btnMua.Size = new System.Drawing.Size(75, 23);
            this.btnMua.TabIndex = 3;
            this.btnMua.Text = "Mua";
            this.btnMua.UseVisualStyleBackColor = true;
            this.btnMua.Click += new System.EventHandler(this.btnMua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số lượng";
            // 
            // lv2
            // 
            this.lv2.Location = new System.Drawing.Point(411, 12);
            this.lv2.Name = "lv2";
            this.lv2.Size = new System.Drawing.Size(431, 243);
            this.lv2.TabIndex = 5;
            this.lv2.UseCompatibleStateImageBehavior = false;
            // 
            // ktrabai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 293);
            this.Controls.Add(this.lv2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMua);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.lv1);
            this.Name = "ktrabai1";
            this.Text = "ktrabai1";
            this.Load += new System.EventHandler(this.ktrabai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Button btnMua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv2;
    }
}