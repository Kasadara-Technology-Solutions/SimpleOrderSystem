using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using SimpleOrderSystem.Models;

namespace SimpleOrderSystem.Services
{
    public class EmployeeService:DbConnection
    {
        public void CreateEmployee(Employee employee)
        {
            connection();
            string procedure = "AddEmployee";
            sqlCommand.CommandText = procedure;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", employee.ID);
            sqlCommand.Parameters.AddWithValue("@OfficeCode", employee.OfficeCode);
            sqlCommand.Parameters.AddWithValue("@reportsTo", employee.reportsTo);
            sqlCommand.Parameters.AddWithValue("@LastName", employee.LastName);
            sqlCommand.Parameters.AddWithValue("@FirstName", employee.FirstName);
            sqlCommand.Parameters.AddWithValue("@Extension", employee.Extension);
            sqlCommand.Parameters.AddWithValue("@Email", employee.Email);
            sqlCommand.Parameters.AddWithValue("@JobTitle", employee.JobTitle);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }



        public void EditEmployee(Employee employee)
        {
            connection();
            string procedure = "EditEmployee";
            sqlCommand.CommandText = procedure;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", employee.ID);
            sqlCommand.Parameters.AddWithValue("@OfficeCode", employee.OfficeCode);
            sqlCommand.Parameters.AddWithValue("@reportsTo", employee.reportsTo);
            sqlCommand.Parameters.AddWithValue("@LastName", employee.LastName);
            sqlCommand.Parameters.AddWithValue("@FirstName", employee.FirstName);
            sqlCommand.Parameters.AddWithValue("@Extension", employee.Extension);
            sqlCommand.Parameters.AddWithValue("@Email", employee.Email);
            sqlCommand.Parameters.AddWithValue("@JobTitle", employee.JobTitle);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}