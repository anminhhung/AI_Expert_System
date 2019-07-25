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
	class Rule_xl
	{
		// Tạo kết nối mới
		DataProvider provider = new DataProvider();
		/* Cấu trúc
	-	Tạo câu lệnh query
	-	Truyền query vào kết nối SQL
	-	Xây dựng câu lệnh thêm mới */
		public void Insert(Rule r)
		{
			String sql = "Insert into tblluat values('" + r.RuleID + "',N'" + r.Content + "')";
			//cn.Run(sql);
			provider.Run(sql);
		}
		// Xây dựng câu lệnh thay đổi
		public void Update(Rule r)
		{
			String sql = "Update tblluat set noidung = N'" + r.Content + "' where maluat = '" + r.RuleID + "' ";
			//cn.Run(sql);
			provider.Run(sql);
		}
		// Xây dựng câu lệnh xóa
		public void Deleted(String ruleID)
		{
			String sql = "Delete from tblluat where maluat = '" + ruleID + "' ";
			//cn.Run(sql);
			provider.Run(sql);
		}
		// Xây dựng câu lệnh tìm kiếm
		public DataTable Search(String ruleID)
		{
			String sql = "Select * from tblluat where maluat ='" + ruleID + "'";
			//return cn.GetTable(sql);
			return provider.ExcuteQuery(sql);
		}
		// Xây dựng câu lệnh lấy luật
		public DataTable loadRule()
		{
			String sql = "Select * from tblluat";
			return provider.ExcuteQuery(sql);
		}
	}
}

