using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnSuKien_Click(object sender, EventArgs e)
        {
            QuanLySuKien frm = new QuanLySuKien();
            frm.ShowDialog();
        }

        private void BtnLuat_Click(object sender, EventArgs e)
        {
            quanlyluat frm = new quanlyluat();
            frm.ShowDialog();
        }

        private void BtnTuVan_Click(object sender, EventArgs e)
        {
            TuVan frm = new TuVan();
            frm.ShowDialog();
        }

        private void BtnThongTin_Click(object sender, EventArgs e)
        {
            ThongTin frm = new ThongTin();
            frm.ShowDialog();
        }
    }
}
