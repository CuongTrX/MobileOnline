using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MobileStoreOnline.App_Code.DAL
{
    public class DBLib
    {
        //Khai báo biến thành viên
        private SqlConnection cnn;
        private SqlCommand cmd;
        private bool isOpen; //Kiểm tra tình trạng kết nối

        //Phương thức khởi tạo
        public DBLib()
        {
            //Khai báo chuỗi kết nối
            string strcnn = ConfigurationManager.ConnectionStrings["MSOConnect"].ConnectionString;
            //Khởi tạo đối tượng SqlConnection
            cnn = new SqlConnection();
            cnn.ConnectionString = strcnn;
            //Khởi tạo đối tượng SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = cnn;
        }

        //Phương thức mở kết nối CSDL
        public void Open()
        {
            if (isOpen)
                return;
            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
                isOpen = true;
            }
        }

        //Phương thức đóng kết nối
        public void Close()
        {
            cmd.Connection.Close();
            isOpen = false;
        }

        //Phương thức truyền tham số với tên tham số và giá trị
        public void AddParameter(string paraName, object paraValue)
        {
            SqlParameter para = new SqlParameter();
            para.ParameterName = paraName;
            para.Value = paraValue;
            cmd.Parameters.Add(para);
        }

        //Phương thức thực thi câu lệnh SQL với câu lệnh Sql và kiểu câu lệnh
        public int ExecuteNonQuery(string cmdText, CommandType cmdType)
        {
            int count;
            try
            {
                //Mở kết nối
                this.Open();
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            return count;
        }

        public object ExecuteScalar(string cmdText, CommandType cmdType)
        {
            object oES;
            try
            {
                //Mở kết nối
                this.Open();
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                oES = cmd.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }
            return oES;
        }

        public SqlDataReader ExecuteReader(string cmdText, CommandType cmdType)
        {
            SqlDataReader sdrER;
            try
            {
                this.Open();
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                sdrER = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }
            return sdrER;
        }
        //Phương thức điền dư liệu vào DataTable
        public DataTable FillDataTable(string cmdText, CommandType cmdType)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            try
            {
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                adapter.Fill(table);
                adapter.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return table;
        }
        //Phương thức điền dữ liệu vào DataTable với câu lệnh, kiểu câu lệnh, mảng tham số
        public DataTable FillDataTable(string cmdText, CommandType cmdType,
            string[] arrayPara, object[] arrayValue, SqlDbType[] arrayDbType)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            try
            {
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                SqlParameter para;
                for (int i = 0; i < arrayPara.Length; i++)
                {
                    para = new SqlParameter();
                    para.ParameterName = arrayPara[i];
                    para.Value = arrayValue[i];
                    para.SqlDbType = arrayDbType[i];
                    cmd.Parameters.Add(para);
                }
                adapter.Fill(table);
                adapter.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return table;
        }
    }
}