using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TestWebApp2
{
    public class DAL
    {
        SqlConnection con = new SqlConnection("Data source =(local); initial catalog = test db; user id = sa; password = root");
        public void insert(string name, string email,int gender)
        {
            SqlDataAdapter da = new SqlDataAdapter("insert into tbl_Person values('" + name + "', '" + email + "','" + gender + "')",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        public DataTable select()
        {
            SqlCommand cmd = new SqlCommand("Select * from tbl_student",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
    }
}