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
    public partial class frmbt12 : Form
    {
        public frmbt12()
        {
            InitializeComponent();
            

        }
        
        private void btnRD_Click(object sender, EventArgs e)
        {
            txtN.ReadOnly = true;
            txtN.Clear();
            Random rd = new Random();
            txtN.Text = rd.Next(0, 1000).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem itm = new ListViewItem(lsvKetqua.Items.Count.ToString());
            ListViewItem.ListViewSubItem sub = new ListViewItem.ListViewSubItem(itm, txtN.Text);
            itm.SubItems.Add(sub);
            lsvKetqua.Items.Add(itm);
            lblN.Text = lsvKetqua.Items.Count +"";
            txtN.ResetText();
            txtN.Focus();
        }

        private void frmbt12_Load(object sender, EventArgs e)
        {
            definelistview();
        }

        void definelistview()
        {
            lsvKetqua.View = View.Details;
            lsvKetqua.GridLines = true;
            lsvKetqua.FullRowSelect = true;
            lsvKetqua.Columns.Add("STT", 50);
            lsvKetqua.Columns.Add("Số", 100);
        }

        private void btnXoachon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsvKetqua.Items.Count;i++ )
            {
                if (lsvKetqua.Items[i].Selected == true)
                    lsvKetqua.Items.RemoveAt(i);
            }
            lblN.Text = lsvKetqua.Items.Count + "";
        }

        private void btnTimMax_Click(object sender, EventArgs e)
        {
            int max = int.Parse(lsvKetqua.Items[0].SubItems[1].Text);
            int vt = 0;
            for (int i = 1; i < lsvKetqua.Items.Count; i++)
            {
                if (int.Parse(lsvKetqua.Items[i].SubItems[1].Text) > max)
                    max = int.Parse(lsvKetqua.Items[i].SubItems[1].Text);
                vt = i;
            }
            lblSLN.Text = "Số có giá trị lớn nhất: " + max.ToString();
            lblVTSLN.Text = "Số lớn nhất xuất hiện tại vị trí: " + vt.ToString();
      
        }

      

        private void btnXoaMax_Click(object sender, EventArgs e)
        {
            int max = int.Parse(lsvKetqua.Items[0].SubItems[1].Text);
            int vt = 0;
            for (int i = 1; i < lsvKetqua.Items.Count; i++)
            {
                if (int.Parse(lsvKetqua.Items[i].SubItems[1].Text) > max)
                {
                    max = int.Parse(lsvKetqua.Items[i].SubItems[1].Text);
                    vt = i;
                }
                lsvKetqua.Items.RemoveAt(vt);
            }
        }
     
    }
}
