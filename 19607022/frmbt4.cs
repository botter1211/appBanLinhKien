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
    public partial class frmbt4 : Form
    {
        public frmbt4()
        {
            InitializeComponent();
        }

 
        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn thoát ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtNhap.Text);
                lsbDanhsach.Items.Add(txtNhap.Text.Trim());
                txtNhap.ResetText();
                txtNhap.Focus();
            }
            catch(Exception)
            {
                MessageBox.Show("Phải nhập kiểu số nguyên !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtNhap.ResetText();
                txtNhap.Focus();
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            int n = lsbDanhsach.Items.Count;
            for (int i = 0; i < n; i++)
                lsbDanhsach.Items[i] = int.Parse(lsbDanhsach.Items[i].ToString()) + 2 ;
          
        }

        private void btnChonchandau_Click(object sender, EventArgs e)
        {
            int n = lsbDanhsach.Items.Count;
            for(int i = 0; i < n; i++)
                if(int.Parse(lsbDanhsach.Items[i].ToString()) %2 == 0)
                {
                    lsbDanhsach.SelectedIndex = i;
                    return;
                }
        }

        private void btnChonlecuoi_Click(object sender, EventArgs e)
        {
            int n = lsbDanhsach.Items.Count;
            for (int i = n - 1; i >= 0; i--)
                if (int.Parse(lsbDanhsach.Items[i].ToString()) % 2 != 0)
                {
                    lsbDanhsach.SelectedIndex = i;
                    return;
                }
        }

        private void btnXoaphantuchon_Click(object sender, EventArgs e)
        {
            lsbDanhsach.Items.Remove(lsbDanhsach.SelectedItem);
        }

        private void btnXoaphantudau_Click(object sender, EventArgs e)
        {
            lsbDanhsach.Items.RemoveAt(0);
        }

        private void btnXoaphantucuoi_Click(object sender, EventArgs e)
        {
            lsbDanhsach.Items.RemoveAt(lsbDanhsach.Items.Count - 1);
        }

        private void frmbt4_Load(object sender, EventArgs e)
        {

        }

      
    }
}
