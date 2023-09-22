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
    public partial class ktrabai1 : Form
    {
        public ktrabai1()
        {
            InitializeComponent();
        }

        private void ktrabai1_Load(object sender, EventArgs e)
        {
            definelistview();
        }

        void definelistview()
        {
            lv1.View = View.Details;
            lv1.GridLines = true;
            lv1.FullRowSelect = true;
            lv1.Columns.Add("STT", 50);
            lv1.Columns.Add("Sách", 150);
            lv1.Columns.Add("Đơn giá", 200);
            lv2.View = View.Details;
            lv2.GridLines = true;
            lv2.FullRowSelect = true;
            lv2.Columns.Add("STT", 50);
            lv2.Columns.Add("Sách", 150);
            lv2.Columns.Add("Số lượng", 50);
            lv2.Columns.Add("Thành tiền", 200);
            ListViewItem itm;
            string[] arr = new string[5];

            arr[0] = this.lv1.Items.Count +"";
            arr[1] = "A";
            arr[2] = "20000";
            itm = new ListViewItem(arr);
            lv1.Items.Add(itm);

            arr[0] = this.lv1.Items.Count + "";
            arr[1] = "B";
            arr[2] = "30000";
            itm = new ListViewItem(arr);
            lv1.Items.Add(itm);

            arr[0] = this.lv1.Items.Count + "";
            arr[1] = "C";
            arr[2] = "40000";
            itm = new ListViewItem(arr);
            lv1.Items.Add(itm);

            arr[0] = this.lv1.Items.Count + "";
            arr[1] = "D";
            arr[2] = "50000";
            itm = new ListViewItem(arr);
            lv1.Items.Add(itm);
        }

        private void btnMua_Click(object sender, EventArgs e)
        {

            lv1.HideSelection = false;
            ListViewItem itm;
            string[] arr = new string[5];
            arr[0] = this.lv2.Items.Count + "";
            arr[1] = this.lv1.SelectedItems[0].SubItems[1].Text;
            arr[2] = this.txtSoluong.Text;
            int tong=0;
            tong = int.Parse(lv1.SelectedItems[0].SubItems[2].Text ) * int.Parse(txtSoluong.Text);
            arr[3] = tong.ToString();
            itm = new ListViewItem(arr);
            lv2.Items.Add(itm);
        }

    }
}
