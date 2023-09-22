using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19607022
{
    public partial class frmbt7 : Form
    {
        public frmbt7()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn thoát ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmbt7_Load(object sender, EventArgs e)
        {
            btnTim.Enabled = false;
            btnThaythe.Enabled = false;
            btnInthuong.Enabled = false;
            btnInhoa.Enabled = false;
            txtNhapchuoi.Focus();
        }
        string str, str1, str2;
       
            
            
        
        private void txtNhapchuoi_TextChanged(object sender, EventArgs e)
        {
            str = Console.ReadLine();
            btnTim.Enabled = true;
            btnThaythe.Enabled = true;
            btnInthuong.Enabled = true;
            btnInhoa.Enabled = true;
            if(txtNhapchuoi.TextLength.Equals(0))
            {
                btnTim.Enabled = false;
                btnThaythe.Enabled = false;
                btnInthuong.Enabled = false;
                btnInhoa.Enabled = false;
            }
            
                
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            str= this.txtNhapchuoi.Text;
            str1 = this.txtTim.Text;
            int Vitri = str.IndexOf(str1);
            if (Vitri >= 0)
            {
                txtKetqua.Text = "Vị trí tìm thấy: ";
                txtKetqua.Text += str.IndexOf(str1) +1;
            }
            else
                txtKetqua.Text = "Không xuất hiện";
        }

        private void btnThaythe_Click(object sender, EventArgs e)
        {
            str = this.txtNhapchuoi.Text;
            str1 = this.txtTim.Text;
            str2 = this.txtThaythe.Text;
            if (str.IndexOf(str1) >= 0)
            {
                txtKetqua.Text = (str.Replace(str1, str2));
            }
        }

        private void btnInhoa_Click(object sender, EventArgs e)
        {
            str = this.txtNhapchuoi.Text;
            string INHOA = str.ToUpper();
            txtKetqua.Text = INHOA;
        }

        private void btnInthuong_Click(object sender, EventArgs e)
        {
            str = this.txtNhapchuoi.Text;
            string INTHUONG = str.ToLower();
            txtKetqua.Text = INTHUONG;
        }
    }
}
