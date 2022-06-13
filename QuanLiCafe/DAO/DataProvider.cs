using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace QuanLiCafe.DAO
{
    class DataProvider
    {
        private static DataProvider instance;

        //Data Source=DESKTOP-8KRDSV7;Initial Catalog=Coffee;Integrated Security=True
        private string connectionStr = @"Data Source=DESKTOP-8KRDSV7;Initial Catalog=Coffee;Integrated Security=True";

        public static DataProvider Instance 
        {
            get {  if (instance == null) instance = new DataProvider(); return DataProvider.instance; } 
            private set => instance = value; 
        }

        private DataProvider() { }

        // trả về số dòng kết quả
        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                //cmd.Parameters.AddWithValue(parameter);
                if(parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data);

                connection.Close();
            };
           
            return data;
        }

        // trả về số dòng được thực thi : thêm, sửa, xóa
        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                //cmd.Parameters.AddWithValue(parameter);
                if (parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteNonQuery();

                connection.Close();
            };

            return data;
        }

        // trả về như câu lệnh select count (*)
        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                //cmd.Parameters.AddWithValue(parameter);
                if (parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteScalar();

                connection.Close();
            };

            return data;
        }

    }
}
