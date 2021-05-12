using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace SimpleOrderSystem.Services
{
    public class DbConnection
    {
        //db connection string
        protected string connectionString = "Server=LAPTOP-RMMBR8JQ;Database=simplordersystem;Trusted_Connection=True;";
        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;
        protected void connection()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
        }
    }
}