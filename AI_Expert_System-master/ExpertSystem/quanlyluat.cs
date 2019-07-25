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
    public partial class quanlyluat : Form
    {
        Rule_xl xl = new Rule_xl();
        private int id;
        public quanlyluat()
        {
            InitializeComponent();
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            String mal;
            mal = txtTimKiem.Text;
            dataLuat.DataSource = xl.Search(mal);
            txtTimKiem.Text = "";
        }

        private void Quanlyluat_Load(object sender, EventArgs e)
        {
            dataLuat.DataSource = xl.loadRule();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLuat.Text != "" && txtNoiDung.Text != "")
                {
                    Rule r = new Rule();
                    r.RuleID = txtMaLuat.Text;
                    r.Content = txtNoiDung.Text;
                    xl.Insert(r);
                    dataLuat.DataSource = xl.loadRule();
                    txtMaLuat.Text = "";
                    txtNoiDung.Text = "";
                }
                else
                {
                    MessageBox.Show("Không được để trống!");
                }
            }
            catch
            {
                MessageBox.Show("Thêm thành công!");
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            Rule r = new Rule();
            r.RuleID = txtMaLuat.Text;
            r.Content = txtNoiDung.Text;
            xl.Update(r);
            dataLuat.DataSource = xl.loadRule();
            txtMaLuat.Text = "";
            txtNoiDung.Text = "";
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            String mal;
            mal = txtMaLuat.Text;
            xl.Deleted(mal);
            dataLuat.DataSource = xl.loadRule();
            txtMaLuat.Text = "";
            txtNoiDung.Text = "";
        }

        private void DataLuat_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            id = e.RowIndex;
            if (id >= 0 && id < dataLuat.Rows.Count)
            {
                this.txtMaLuat.Text = dataLuat.Rows[id].Cells[0].Value.ToString();
                this.txtNoiDung.Text = dataLuat.Rows[id].Cells[1].Value.ToString();

            }
        }
    }
}
