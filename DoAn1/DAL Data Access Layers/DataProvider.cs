using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Data_Access_Layers
{
    public class DataProvider
    {
        private static DataProvider instance; // Ctrl + R + E

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private string connectionSTR = "Data Source=LAPTOP-TRUONG\\SQLEXPRESS;Initial Catalog=DinhThienTruong_DoAn1;Integrated Security=True;";


        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))  //giải phóng bộ nhớ sau khi dùng
            {
                connection.Open();  // mở kết nối vật lý đến sql

                SqlCommand command = new SqlCommand(query, connection);  //chạy câu query trong sql trong connection chỉ định

                if (parameter != null)
                {
                    string[] listPara = query.Split(' '); //cắt khoảng trắng -> dấu phẩy phải tách khỏi từng biến khi viết query
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))  //nếu có chứa parameter
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);  //thay thế item bằng parameter[i]
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);  //lấy dữ liệu ra

                adapter.Fill(data);  //đổ dữ liệu lấy ra vào data

                connection.Close();
            }

            return data;
        }

        //trả ra số dòng thực thi thành công
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        //sử dụng khi truy vấn chỉ trả ra 1 giá trị duy nhất( truy vấn đếm số lượng, tính tổng,... )
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();  //trả về ô đầu tiên bảng kết quả 

                connection.Close();
            }

            return data;
        }

    }
}

