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
    public partial class ktrabai1test : Form
    {
        public ktrabai1test()
        {
            InitializeComponent();
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

            ListViewItem itm = new ListViewItem(lv1.Items.Count.ToString());
            ListViewItem.ListViewSubItem sub = new ListViewItem.ListViewSubItem(itm, "A");
        }
    }
}
