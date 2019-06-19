using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinansalTablolarAnalizi
{
    class ConnectionQuerry
    {
        static string ConnectionString = "Data Source=IBRAHIM-KARACA\\MSSQLSERVER01;Initial Catalog=Finans;Integrated Security=True";
        static SqlConnection con;

        public static void OpenConnection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }

        public static void CloseConnection()
        {
            con.Close();
        }

        public static void ExecuteQueries(string Query_)
        {//insert update delete işlemleri için
            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlConnection.ClearAllPools();
            SqlConnection.ClearPool(con);
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }

        public static SqlDataReader DataReader(string Query_)
        {//select işlemlerinde, verileri çekmek için
            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlConnection.ClearAllPools();
            SqlConnection.ClearPool(con);
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public static object ShowDataInGridView(string Query_)
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlConnection.ClearAllPools();
            SqlConnection.ClearPool(con);
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
    }
}



