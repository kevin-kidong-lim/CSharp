using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace purchageIns
{
    class con_Database
    {
        // Server=(LocalDB)\MSSQLLocalDB; Integrated Security = true; AttachDbFileName=D:\Data\MyDB1.mdf
        //(localdb)\MSSQLLocalDB;Integrated Security=true
        //(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kevin\source\repos\purchageIns\purchageIns\Database1.mdf;Integrated Security=True
        public static string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Work\Ins\purchageIns\purchageIns\insDB.mdf;Integrated Security=True";
                //public static string constring = @"Data Source=아이피주소;Initial Catalog=데이터베이스명;Persist Security Info=True;User ID=아이디;Password=비밀번호";
                //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kevin\source\repos\purchageIns\purchageIns\Database1.mdf;Integrated Security=True
                // 출처: https://jongtae5673.tistory.com/entry/C-과-Database-연동하기예제 [별이지는밤]
                //https://jongtae5673.tistory.com/entry/C-과-Database-연동하기예제

                SqlConnection conn = new SqlConnection();
        
        private string sConnString = "";

        public SqlConnection getConnection()
        {
            return conn;
        }
        // db Connect
        public SqlConnection ConnectDB()
        {
            try
            {
                sConnString = constring;
                Console.WriteLine("conn.State.ToString() : " + conn.State.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("ConnectDB : " + e.ToString());
            }
            if ( conn.State.ToString().Equals("Closed"))
            {
                try
                {
                    conn.ConnectionString = sConnString;
                    conn.Open();
                    Console.WriteLine("conn.State.ToString() : " + conn.State.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(" conn Exception : " + e.ToString());
                }
              
            }
            return conn;
        }
        // db Close
        public void CloseDB()
        {
            if ( conn != null )
            {
                conn.Close();
            }
        }

        public DataTable GetDBTable(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        
    }
}
