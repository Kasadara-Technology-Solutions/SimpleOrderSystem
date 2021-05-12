using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using SimpleOrderSystem.Models;
using ActionNameAttribute = System.Web.Http.ActionNameAttribute;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;


namespace SimpleOrderSystem.Services
{
    public class CustomerService:DbConnection
    {
      
        public void CreateCustomer(Customer customer)
        {
            connection();
            string procedure = "AddCustomer";
            sqlCommand.CommandText = procedure;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@ID", customer.ID);
            sqlCommand.Parameters.AddWithValue("@SalesRepEmployeeNumber", customer.SalesRepEmployeeNumber);
            sqlCommand.Parameters.AddWithValue("@Name", customer.Name);
            sqlCommand.Parameters.AddWithValue("@LastName", customer.LastName);
            sqlCommand.Parameters.AddWithValue("@FirstName", customer.FirstName);
            sqlCommand.Parameters.AddWithValue("@Phone", customer.Phone);
            sqlCommand.Parameters.AddWithValue("@Address1", customer.Address1);
            sqlCommand.Parameters.AddWithValue("@Address2", customer.Address2);
            sqlCommand.Parameters.AddWithValue("@City", customer.City);
            sqlCommand.Parameters.AddWithValue("@State", customer.State);
            sqlCommand.Parameters.AddWithValue("@PostalCode", customer.PostalCode);
            sqlCommand.Parameters.AddWithValue("@Country", customer.Country);
            sqlCommand.Parameters.AddWithValue("@CreditLimit", customer.CreditLimit);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }
        public void EditCustomer(Customer customer)
        {
            connection();
            string procedure = "EditCustomer";
            sqlCommand.CommandText = procedure;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@ID", customer.ID);
            sqlCommand.Parameters.AddWithValue("@SalesRepEmployeeNumber", customer.SalesRepEmployeeNumber);
            sqlCommand.Parameters.AddWithValue("@Name", customer.Name);
            sqlCommand.Parameters.AddWithValue("@LastName", customer.LastName);
            sqlCommand.Parameters.AddWithValue("@FirstName", customer.FirstName);
            sqlCommand.Parameters.AddWithValue("@Phone", customer.Phone);
            sqlCommand.Parameters.AddWithValue("@Address1", customer.Address1);
            sqlCommand.Parameters.AddWithValue("@Address2", customer.Address2);
            sqlCommand.Parameters.AddWithValue("@City", customer.City);
            sqlCommand.Parameters.AddWithValue("@State", customer.State);
            sqlCommand.Parameters.AddWithValue("@PostalCode", customer.PostalCode);
            sqlCommand.Parameters.AddWithValue("@Country", customer.Country);
            sqlCommand.Parameters.AddWithValue("@CreditLimit", customer.CreditLimit);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }
    }
}