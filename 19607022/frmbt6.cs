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
using Microsoft.VisualBasic;

namespace _19607022
{
    public partial class frmbt6 : Form
    {
        public frmbt6()
        {
            InitializeComponent();
            
        }
        
        ArrayList arr = new ArrayList();

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string content = Interaction.InputBox("Nhập giá trị phần tử", "Nhập mảng", this.txtNhap.Text);
            if(content != "")
            {
                MessageBox.Show(content);
            }
            txtNhap.ReadOnly = true;
            arr.Clear();
            txtNhap.Clear();
            txtKQ.Clear();
            int k;
            Random rd = new Random();
            for(int i=0; i<Convert.ToInt32(content.ToString()); i++)
            {
                k = rd.Next(-10, 20);
                arr.Add(k);
                txtNhap.Text += k.ToString() + " ";
            }
        }

        private void btnDemchan_Click(object sender, EventArgs e)
        {
            int d = 0;
            for(int i=0; i<arr.Count; i++)
            {
                if (int.Parse(arr[i].ToString()) % 2 == 0)
                    d++;
            }
            txtKQ.Text = d.ToString();
        }

        private void btnTongmang_Click(object sender, EventArgs e)
        {
            int s = 0;
            for(int i=0; i<arr.Count; i++)
            {
                s += int.Parse(arr[i].ToString());
            }
            txtKQ.Text = s.ToString();
        }

        private void btnXuatle_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
            for(int i=0; i<arr.Count; i++)
            {
                if(int.Parse(arr[i].ToString()) %2!=0)
                    txtKQ.Text += arr[i].ToString() + ","; 
            }
        }

        private void btnXuatNT_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
            for (int i = 0; i < arr.Count; i++)
            {
                if (laSNT(int.Parse(arr[i].ToString())))
                {
                    txtKQ.Text += arr[i].ToString() + ",";
                }
            }
        }
        bool laSNT(int k)
        {
            int d = 0;
            for(int i=1; i<=k; i++)
            {
                if(k % i == 0)
                    d++;
            }
            return (d == 2);
        }

        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn thoát ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTimMaxMin_Click(object sender, EventArgs e)
        {
            int Max = 0;
            int Min = 0;
            for(int i=0; i<arr.Count; i++)
            {
                if (int.Parse(arr[i].ToString()) > Max)
                    Max = int.Parse(arr[i].ToString());
                if (int.Parse(arr[i].ToString()) < Min)
                    Min = int.Parse(arr[i].ToString());
            }
            txtKQ.Text = "Max:" + Max.ToString() +" "+ "Min:" + Min.ToString();
                
        }
    }
}
