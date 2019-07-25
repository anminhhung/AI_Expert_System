using ExpertSystem.DAO;
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
    public partial class TuVan : Form
    {
        private List<string> ListMaNganh = new List<string>();
        private List<string> ListTenNganh = new List<string>();
        //private Connect cn = new Connect();
        DataProvider provider = new DataProvider();
        private bool run = false;
        private object btnTuVan;
        private object ricKQ;

        public TuVan()
        {
            InitializeComponent();
            Load_TuVan();
        }

        private void Load_TuVan(/*object sender, EventArgs e*/)
        {
            //Load list ngành
            string qr = "Select masukien, motasukien from tblsukien where loaisukien='nganhnghe'";
            //DataTable tbTruong = cn.GetTable(qr);
            DataTable tbTruong = provider.ExcuteQuery(qr);
            for(int i=0; i<tbTruong.Rows.Count; i++)
            {
                ListMaNganh.Add(tbTruong.Rows[i][0].ToString());
                ListTenNganh.Add(tbTruong.Rows[i][1].ToString());
            }

            //Load học lực
            qr = "Select masukien, motasukien from tblsukien where loaisukien='hocluc'";
            //DataTable tbCN = cn.GetTable(qr);
            cbHocLuc.DataSource = provider.ExcuteQuery(qr);
            cbHocLuc.DisplayMember = "motasukien";
            cbHocLuc.ValueMember = "masukien";

            //Load khối thi
            qr = "Select masukien,motasukien from tblsukien where loaisukien='khoithi'";
            //DataTable tbKhoi = cn.GetTable(qr);
            //cbKhoi.DataSource = tbKhoi;
            cbKhoi.DataSource = provider.ExcuteQuery(qr);
            cbKhoi.DisplayMember = "motasukien";
            cbKhoi.ValueMember = "masukien";

            //Load nhóm ngành nghề
            qr = "Select masukien,motasukien from tblsukien where loaisukien='nhomnganhnghe'";
            //DataTable tbNhom = cn.GetTable(qr);
            //cbNhomNganh.DataSource = tbNhom;
            cbNhomNganh.DataSource = provider.ExcuteQuery(qr);
            cbNhomNganh.DisplayMember = "motasukien";
            cbNhomNganh.ValueMember = "masukien";

            //Load sở thích
            qr = "Select masukien,motasukien from tblsukien where loaisukien='sothic'";
            //DataTable tbST = cn.GetTable(qr);
            //cbSoThich.DataSource = tbST;
            cbSoThich.DataSource = provider.ExcuteQuery(qr);
            cbSoThich.DisplayMember = "motasukien";
            cbSoThich.ValueMember = "masukien";
        }

        //button Tu vấn
        private void Button1_Click_1(object sender, EventArgs e)
        {
            SuyDienTien sd = new SuyDienTien();
            sd.readFile();
            run = true;

            cbHocLuc.Enabled = false;
            cbKhoi.Enabled = false;
            cbNhomNganh.Enabled = false;
            cbSoThich.Enabled = false;
            button1.Enabled = false;

            List<string> gt = new List <string>();
            richKQ.Text = "";
            if (cbHocLuc.SelectedValue.ToString() != "")
            {
                gt.Add(cbHocLuc.SelectedValue.ToString());
            }
            if (cbKhoi.SelectedValue.ToString() != "")
            {
                gt.Add(cbKhoi.SelectedValue.ToString());
            }
            if (cbNhomNganh.SelectedValue.ToString() != "")
            {
                gt.Add(cbNhomNganh.SelectedValue.ToString());
            }
            if (cbSoThich.SelectedValue.ToString() != "")
            {
                gt.Add(cbSoThich.SelectedValue.ToString());
            }

            int d = 0;
            progressBar.Maximum = ListMaNganh.Count - 1;
            progressBar.Minimum = 0;

            if (gt.Count > 0)
            {
                int dem = 0;
                foreach(string s in ListMaNganh)
                {
                    if (!run)
                    {
                        btnReset.Enabled = false;
                        break;
                    }
                    progressBar.Value = dem;
                    List<string> kl = new List<string>();
                    kl.Add(s);

                    if(sd.SuyDien(gt,kl) == true)
                    {
                        richKQ.Text += ListTenNganh.ElementAt(dem) + "\n";
                        d++;
                    }
                    dem++;
                    SendKeys.Flush();
                }
                if (d==0 && run != false)
                {
                    richKQ.Text = "Không có ngành phù hợp với yêu cầu lựa chọn!!!\nXin vui lòng chọn lại!!\nChúng tôi sẽ cập nhật thông trong thời gian tới";
                }
            }
            else
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin!");
            }
            cbHocLuc.Enabled = true;
            cbKhoi.Enabled = true;
            cbNhomNganh.Enabled = true;
            cbSoThich.Enabled = true;
            button1.Enabled = true; //Tư vấn nha!! Do quên design tên nên để button1
        }

        private int FinIndex(string input, List<string> s)
        {
            int i = 0;
            foreach(string a in s)
            {
                if (input == a)
                {
                    return i;
                }
                i++;
            }
            return 0;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            richKQ.Text = "";
            cbHocLuc.Text = "";
            cbKhoi.Text = "";
            cbNhomNganh.Text = "";
            cbSoThich.Text = "";
            run = false;
            progressBar.Value = progressBar.Maximum;
        }
    }
}
