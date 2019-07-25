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
    public partial class QuanLySuKien : Form
    {
        SuKien_xl xl = new SuKien_xl();
        private int id;
        public QuanLySuKien()
        {
            InitializeComponent();
        }

        private void DataSuKien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = e.RowIndex;
            if (id >= 0 && id < dataSuKien.Rows.Count)
            {
                this.txtMaSK.Text = dataSuKien.Rows[id].Cells[0].Value.ToString();
                this.txtMoTaSK.Text = dataSuKien.Rows[id].Cells[1].Value.ToString();
                this.cmbLoaiSK.Text = dataSuKien.Rows[id].Cells[2].Value.ToString();
            }
        }

        private void QuanLySuKien_Load(object sender, EventArgs e)
        {
            dataSuKien.DataSource = xl.LoadSuKien();
            cmbLoaiSK.DataSource = xl.LoadLoaiSK();
            cmbLoaiSK.DisplayMember = "loaisukien";
            cmbLoaiSK.ValueMember = "loaisukien";
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSK.Text != "" && txtMoTaSK.Text != "")
                {
                    SuKien sk = new SuKien();
                    sk.MaSuKien = txtMaSK.Text;
                    sk.MotaSuKien = txtMoTaSK.Text;
                    sk.LoaiSuKien = cmbLoaiSK.SelectedValue.ToString();
                    xl.Insert(sk);
                    dataSuKien.DataSource = xl.LoadSuKien();
                }
                else
                {
                    MessageBox.Show("Không được để trống!");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            SuKien sk = new SuKien();
            sk.MaSuKien = txtMaSK.Text;
            sk.MotaSuKien = txtMoTaSK.Text;
            sk.LoaiSuKien = cmbLoaiSK.SelectedValue.ToString();
            xl.Update(sk);
            dataSuKien.DataSource = xl.LoadSuKien();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            String mask;
            mask = txtMaSK.Text;
            xl.Delete(mask);
            dataSuKien.DataSource = xl.LoadSuKien();
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            String mask;
            mask = txtTimKiem.Text;
            dataSuKien.DataSource = xl.Search(mask);
        }
    }
}
