using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ExpertSystem.DAO;

namespace ExpertSystem
{
	class SuKien_xl
	{
		// Khởi tạo kết nối
		DataProvider provider = new DataProvider();
		/* Cấu trúc dữ liệu:
        Tạo câu lệnh query, truyền query tới SQL, tạo lệnh thêm mới */
		public void Insert(SuKien sk)
		{
			String sql = "Insert into tblsukien values('" + sk.MaSuKien + "',N'" + sk.MotaSuKien + "','" + sk.LoaiSuKien + "')";
			// cn.Run(sql);
			provider.Run(sql);
		}

		// Tạo lệnh cập nhật sự kiện sẵn có
		public void Update(SuKien sk)
		{
			String sql = "Update tblsukien set motasukien = N'" + sk.MotaSuKien + "', loaisukien='" + sk.LoaiSuKien + "' where masukien = '" + sk.MaSuKien + "' ";
			// cn.Run(sql);
			provider.Run(sql);
		}

		// Tạo lệnh xóa sự kiện
		public void Delete(String mask)
		{
			String sql = "Delete from tblsukien where masukien ='" + mask + "'";
			// cn.GetTable(sql);
			provider.Run(sql);
		}
		// Tạo lệnh tìm kiếm
		public DataTable Search(String mask)
		{
			String sql = "Select * from tblsukien where masukien ='" + mask + "'";
			// return cn.GetTable(sql);
			return provider.ExcuteQuery(sql);
		}
		// Lấy sự kiện từ SQL
		public DataTable LoadSuKien()
		{
			String sql = "Select * from tblsukien";
			// Return cn.GetTable(sql);
			return provider.ExcuteQuery(sql);
		}
		public DataTable LoadLoaiSK()
		{
			String sql = "Select distinct LoaiSuKien from tblsukien";
			// return cn.GetTable(sql);
			return provider.ExcuteQuery(sql);
		}
	}
}

