using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using ExpertSystem.DAO;

namespace ExpertSystem
{
    class SuyDienTien
    {
		#region KhaiBao
		// Khởi tạo kết nói với database 
		private DataProvider cn = new DataProvider();

		// Khởi tạo cấu trúc dữ liệu
        List<RuleDefine> bin = new List<RuleDefine>();
        List<RuleDefine> SAT = new List<RuleDefine>();
        private int demluat = 0;
        #endregion

        public void readFile()
        {
			// Lấy nội dung từ bảng luật
			string qr = "Select noidung from tblluat";
            DataTable tbLuat = cn.ExcuteQuery(qr);

            for (int i=0; i<tbLuat.Rows.Count; i++)
            {
				// Lấy thông tin từ bảng luật theo thứ từ từ hàng đầu tiên trở xuống
				string buff = tbLuat.Rows[i][0].ToString();
                RuleDefine luatTG = new RuleDefine();

				/* Trong SQL, ranh giới giữa Giả thuyết và Kết luận 
                là dấu '>', ta định nghĩa dấu '>' trong C# */
				char[] delimiterChars = { '>' };
                string[] tg = buff.Split(delimiterChars);

				/* Bắt đầu việc xử lý các sự kiện được nối với nhau
                bằng dấu '^', ta định nghĩa dấu '^' trong C# */
				char[] delimiterChars1 = { '^' };
                string[] left = tg[0].Split(delimiterChars1);
                int j = 0;

				/* Trong C#, do ban dầu chưa có gì nên ta sẽ khai báo các chuỗi sự kiện trống, sau đó mới thực hiện lưu 
                từng chuỗi sự kiện kết hợp như trong SQL */
				string buff1 = left[0];
                while (buff1 != null)
                {
                    luatTG.left.Add(buff1);
                    j++;
                    try
                    {
                        buff1 = left[j];
                    }
                    catch { buff1 = null; }
                }
                j = 0;

				/* Trong SQL, dấu ',' là dấu ngăn cách giữa MÃ LUẬT và NỘI DUNG LUẬT 
				nên ta sẽ tiến hành đánh dấu và thêm nội dung luật tương ứng với mã luật */
				char[] delimiterChars2 = { ',' };
                string[] right = tg[1].Split(delimiterChars2);
                buff1 = right[0];
                while(buff1 != null)
                {
                    luatTG.right.Add(buff1);
                    j++;
                    try
                    {
                        buff1 = right[j];
                    }
                    catch { buff1 = null; }
                }
                bin.Add(luatTG);
                demluat++;
            }
        }

        public string printRule(List<RuleDefine> mangluat)
        {
			// Thêm thông tin vào bộ nhớ làm việc 
			/* Đầu tiên ta sẽ khai báo một mảng trống */
			/* Note : từ khoá foreach tượng tự như for ... in  trong Python, Foreach chỉ dùng đề duyệt mảng hoặc tập hợp */
			/* Mục đích của phần này là tạo một mảng và mảng này sẽ chưa nội dung của giả thuyết và kết luận */
			string tg = "";
            foreach (RuleDefine r in mangluat)
            {
                foreach (string s in r.left)
                {
                    tg += s + "^";
                }
                tg += "->";
                foreach (string s in r.right)
                {
                    tg += s + "^";
                }
                tg += "\n";
            }
            return tg;
        }

        public bool CheckIn(List<string> a, List<string> b)
        {
			/* Phần này chủ yếu kiểm tra là các sự kiện đã được chọn có trong nội dung luật ( sự kiện kết hợp ) hay không */
			// Xét luật đầu tiên
			int cnt = 0;
            foreach (string tg1 in a)
            {
                foreach (string tg2 in b)
                {
					// Nếu còn luật mà chưa gặp đích thì sẽ xét luật tiếp theo
					if (tg1 == tg2)
                        cnt++;
                }
            }
            if (cnt == a.Count)
                return true;
            else
                return false;
        }

        public void TimTapSat(List<string> L,List<RuleDefine> mangluat)
        {
			/* Tiến hành tìm kết luận tương ứng dựa trên kết các sự kiện kết hợp ( kiểm tra giả thuyết khớp với bộ nhớ lằm việc ) */
			foreach (RuleDefine lTG in mangluat)
            {
				/* Nếu giả thuyết khớp với các sự kiện trong bộ nhớ thì thêm kết luận vào bộ nhớ làm việc */
				if (CheckIn(lTG.left, L) == true && !SAT.Contains(lTG))
                {
                    SAT.Add(lTG);
                }
            }
        }

        public bool SuyDien(List<string> left, List<string> right)
        {
            List<RuleDefine> mangluat = new List<RuleDefine>();
            mangluat = bin;
            List<string> KL = right; // Dòng string trong phần kết luận của SQL
			List<string> TG = left; // Dòng sự kiện kết hợp trong SQL 
			TimTapSat(TG, mangluat);

            while (SAT.Count > 0 && CheckIn(KL, TG) == false)
            {
				// Lấy luật r ra áp dụng
				RuleDefine r = SAT.ElementAt(0);
                mangluat.Remove(r);
                SAT.RemoveAt(0);
				// Thêm sự kiện vào chuỗi sự kiện kết hợp ( Thêm kết luận vào bộ nhớ làm việc )
				foreach (string tg in r.right)
                {
                    if (!TG.Contains(tg))
                    {
                        TG.Add(tg);
                        Console.WriteLine(tg);
                    }
                }
				// Hàm tìm kết luận dựa trên tập các sự kiện kết hợp
				TimTapSat(TG, mangluat);
            }
			/* Bước này ta sẽ kiểm tra liệu giả thuyết có khớp với bộ nhớ hay không, nếu đúng thì thêm kết luận vào bộ nhớ làm việc,
			nếu sai thì xét các luật tiếp theo cho đến khi gặp đích ( đã xét hết các sự kiện trong luật ) */
			if (CheckIn(KL, TG) == false)
                return false;
            else
                return true;
        }
    }
}
