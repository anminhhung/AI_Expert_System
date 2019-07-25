using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.DAO
{
	public class DataProvider
	{
		/* Để có thể sử dụng được database trong ứng dụng C#, đầu tiên chúng ta sẽ tạo database SQL ngay trên máy tính cá nhân của mình 
		-	Data Source : tên server dùng để lưu trữ database, thường đó là của Laptop, Desktop, … hoặc địa chỉ IP, domain name mà mình đang sử dụng. 
		Ví dụ : Data Source=LAPTOP-9UGO11Q00, DESKTOP-9P4D65MA 
		-	Initial Catalog : Đây là tên database mình đặt trong quá trình tạo database bằng SQL. Người dùng có thể đặt tên theo ý muốn của mình nhưng phải cẩn thận trong trường hợp lỗi ký tự hoặc không nhớ tên. 
		Ví dụ : Initial Catalog=HCG
		-	Trong SQL có 2 cách đăng nhập đó là đăng nhập thông qua Windows Authentication và SQL Server Authentication.
		Intergrated Security : là cách thức đăng nhập của SQL bằng quyền Windows trong C#. Để thuận tiện khi sử dụng, nhóm quyết định chọn đăng nhập bằng Windows Authentication, ta sẽ đặt theo cú pháp Integrated Security=True. */
		string str_conn = "Data Source=LAPTOP-9UGO1Q00; Initial Catalog=HCG; Integrated Security=True";
		/* Trong trường hợp muốn sử dụng theo SQL Server Authentication thì ta có thể thay thế tham số Intergrated Security bằng User ID và Password. 
		Ví dụ : string str_conn = "Data Source=DESKTOP-85J4UFB; Initial Catalog=ExpertSystem;User ID=sa;Password=BitterVirgin99"; */

		public DataTable ExcuteQuery(string query)
		{
			DataTable data = new DataTable();
			using (SqlConnection connection = new SqlConnection(str_conn))
			{
				// Mở kết nối
				connection.Open();
				// Mruyền câu lệnh query vào SQL
				// Thực hiện trả về kết quả
				SqlCommand cmd = new SqlCommand(query, connection);
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(data);
				// Đóng kết nối để tránh tràn data
				connection.Close();
			}
			return data;
		}
		// Thực hiện query không trả về kết quả
		public void Run(string sql)
		{
			SqlConnection connection = new SqlConnection(str_conn);
			connection.Open();
			SqlCommand cmd;
			cmd = connection.CreateCommand();
			cmd.CommandText = sql;
			cmd.ExecuteNonQuery();
			cmd.Dispose();
			connection.Close();
		}
		// Lệnh insert
		public void Insert(string sql)
		{
			SqlConnection conn = new SqlConnection(str_conn);
			SqlCommand cmd;
			cmd = conn.CreateCommand();
			cmd.CommandText = sql;
			cmd.ExecuteNonQuery();
			cmd.Dispose();
		}
	}
}

