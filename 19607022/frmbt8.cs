using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _19607022
{
    public partial class frmbt8 : Form
    {
        public frmbt8()
        {
            InitializeComponent();
        }
        ArrayList arr = new ArrayList();
        private void btnRD_Click(object sender, EventArgs e)
        {
            arr.Clear();
            txtN.Clear();
            txtSapxep.Clear();
            int k;
            Random rd = new Random();
            for (int i = 0; i < 11; i++)
            {
                k = rd.Next(-10, 50);
                arr.Add(k);
                txtN.Text += k.ToString() + " ";
            }
        }

        private void btnSapxep_Click(object sender, EventArgs e)
        {
            txtSapxep.Clear();
            for (int i=0; i<arr.Count; i++)
            {
                for(int j=i+1; j<arr.Count; j++)
                    if(int.Parse(arr[i].ToString()) > int.Parse(arr[j].ToString()))
                    {
                        int tmp = int.Parse(arr[i].ToString());
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                txtSapxep.Text += arr[i].ToString() + " ";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtSapxep.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn thoát ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmbt8_Load(object sender, EventArgs e)
        {

        }
    }
}
