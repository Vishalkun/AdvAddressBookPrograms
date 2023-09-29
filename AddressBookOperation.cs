using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdvAddressBookSystem
{
    internal class AddressBookOperation
    {
        public static void createdatabase()
        {
            SqlConnection con = new SqlConnection("data source=(localdb)\\MSSQLLocalDB;initial catalog=master;integrated security=true");
            string query = "create database Customer";
            SqlCommand cmd = new SqlCommand(query, con);
            //open connection
            con.Open();
            //Execut query
            cmd.ExecuteNonQuery();
            //Message
            Console.WriteLine("Database created successfully");
            Console.WriteLine("-----------------------------");
            //Close connection
            con.Close();
        }
    }
}
