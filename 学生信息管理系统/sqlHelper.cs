using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32.SafeHandles;

namespace 学生信息管理系统
{
    public class sqlHelper
    {
        private static readonly string connstring = "server=.;database=StudentDB;uid=sa;pwd=123456";
        public static object ExecuteScalar(string sql, params SqlParameter[] paras)
        {
            object o = null;
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                //创建command命令
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(paras);
                //打开连接
                conn.Open();
                //执行命令
                o = cmd.ExecuteScalar();
                //释放连接
            }
            return o;
        }
        //执行查询 返回sqlDataReader
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] paras)
        {
            SqlConnection conn = new SqlConnection(connstring);
            
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(paras);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;
            }
            catch (SqlException ex)
            {
                conn.Close();
                throw new Exception("执行查询出现异常", ex);
            }
        }

        public static DataTable GetDataTable(string sql, params SqlParameter[] paras)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                //创建command命令
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (paras != null)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddRange(paras);
                }
                //打开连接
                //conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                //数据填充
                da.Fill(dt);

                //释放连接
            }
            return dt;
        }
        //返回受影响的行数 Insert Delete Update
        public static int ExecuteNonQuery(string sql,params SqlParameter[] paras)
        {
            int count = 0;
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                //创建command命令
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(paras);
                //打开连接
                conn.Open();
                //执行命令
                count= cmd.ExecuteNonQuery();//执行T-SQL语句，返回受影响的行数
                
            }
            return count;
        }
        
    }
}
    
  
  
