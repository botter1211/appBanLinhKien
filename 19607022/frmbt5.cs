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
    public partial class frmbt5 : Form
    {
        public frmbt5()
        {
            InitializeComponent();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
             string Hoten = this.txtHoten.Text ;
             lsbLopA.Items.Add(txtHoten.Text.Trim());
             txtHoten.ResetText();
             txtHoten.Focus();
            
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            if (lsbLopA.SelectedItem != null)
                lsbLopB.Items.Add(lsbLopA.SelectedItem);
            else MessageBox.Show("Bạn hãy chọn 1 tên !");
                lsbLopA.Items.Remove(lsbLopA.SelectedItem);
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            if (lsbLopB.SelectedItem != null)
                lsbLopA.Items.Add(lsbLopB.SelectedItem);
            else MessageBox.Show("Bạn hãy chọn 1 tên !");
                lsbLopB.Items.Remove(lsbLopB.SelectedItem);
        }

        private void btnAllphai_Click(object sender, EventArgs e)
        {
            lsbLopB.Items.AddRange(lsbLopA.Items);
            lsbLopA.Items.Clear();
        }

        private void btnAlltrai_Click(object sender, EventArgs e)
        {
            lsbLopA.Items.AddRange(lsbLopB.Items);
            lsbLopB.Items.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lsbLopA.Items.Remove(lsbLopA.SelectedItem);
        }

        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

   

     
    }
}
