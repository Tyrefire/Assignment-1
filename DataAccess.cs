using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;

namespace Assignment_1
{
    public class DataAccess
    {

        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public String name { get; set; }
        public bool a { get; set; }
        public bool b { get; set; }
        public bool c { get; set; }
        public bool d { get; set; }

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public void insert()
        {
            con.ConnectionString = @"Server=tcp:tyler-cs3750-assignment-1.database.windows.net,1433;Initial Catalog=NameNChoice;Persist Security Info=False;User ID=tylermadsen;Password=Myf1rstserver;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            //con.ConnectionString = @"Data Source=tcp:tyler-cs3750-assignment-1.database.windows.net,1433;Initial Catalog=NameNChoice;User ID=tylermadsen;Password=Myf1rstserver";

            con.Open();

                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Stuffs VALUES('" + this.name + "', '" + a + "', '" + b + "', '" + c + "', '" + d + "');";
                cmd.ExecuteNonQuery();
                
            con.Close();
        }

        public void select()
        {
            con.ConnectionString = @"Server=tcp:tyler-cs3750-assignment-1.database.windows.net,1433;Initial Catalog=NameNChoice;Persist Security Info=False;User ID=tylermadsen;Password=Myf1rstserver;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            //con.ConnectionString = @"Data Source=tcp:tyler-cs3750-assignment-1.database.windows.net,1433;Initial Catalog=NameNChoice;User ID=tylermadsen;Password=Myf1rstserver";

            con.Open();

                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Stuffs WHERE ID = (SELECT MAX(ID) FROM Stuffs);";
            dt.Load(cmd.ExecuteReader());
            ds.Tables.Add(dt);

            name = ds.Tables[0].Rows[0][1].ToString();

            if(ds.Tables[0].Rows[0][2].ToString() == "True")
            {
                Debug.Write("a Flagged");
                a = true;
            }
            else { a = false; }
            if (ds.Tables[0].Rows[0][3].ToString() == "True")
            {
                Debug.Write("b Flagged");
                b = true;
            }
            else { b = false; }
            if (ds.Tables[0].Rows[0][4].ToString() == "True")
            {
                c = true;
            }
            else { c = false; }
            if (ds.Tables[0].Rows[0][5].ToString() == "True")
            {
                d = true;
            }
            else { d = false; }

            con.Close();
        }

    }
}