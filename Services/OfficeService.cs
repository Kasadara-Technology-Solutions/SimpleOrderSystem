using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using SimpleOrderSystem.Models;

namespace SimpleOrderSystem.Services
{
    public class OfficeService:DbConnection
    {
        public void CreateOffice(Office office)
        {
            connection();
            string procedure = "AddOffice";
            sqlCommand.CommandText = procedure;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Code", office.Code);
            sqlCommand.Parameters.AddWithValue("@City", office.City);
            sqlCommand.Parameters.AddWithValue("@Phone", office.Phone);
            sqlCommand.Parameters.AddWithValue("@Address1", office.Address1);
            sqlCommand.Parameters.AddWithValue("@Address2", office.Address2);
            sqlCommand.Parameters.AddWithValue("@State", office.State);
            sqlCommand.Parameters.AddWithValue("@Country", office.Country);
            sqlCommand.Parameters.AddWithValue("@PostalCode", office.PostalCode);
            sqlCommand.Parameters.AddWithValue("@Territory", office.Territory);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }


        public void EditOffice(Office office)
        {
            connection();
            string procedure = "EditOffice";
            sqlCommand.CommandText = procedure;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Code", office.Code);
            sqlCommand.Parameters.AddWithValue("@City", office.City);
            sqlCommand.Parameters.AddWithValue("@Phone", office.Phone);
            sqlCommand.Parameters.AddWithValue("@Address1", office.Address1);
            sqlCommand.Parameters.AddWithValue("@Address2", office.Address2);
            sqlCommand.Parameters.AddWithValue("@State", office.State);
            sqlCommand.Parameters.AddWithValue("@Country", office.Country);
            sqlCommand.Parameters.AddWithValue("@PostalCode", office.PostalCode);
            sqlCommand.Parameters.AddWithValue("@Territory", office.Territory);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}