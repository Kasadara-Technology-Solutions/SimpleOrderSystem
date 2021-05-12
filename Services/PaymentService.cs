using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using SimpleOrderSystem.Models;

namespace SimpleOrderSystem.Services
{
    public class PaymentService:DbConnection
    {
        public void CreatePayment(Payment payment)
        {
            connection();
            string procedure = "AddPayment";
            sqlCommand.CommandText = procedure;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@CheckNum", payment.CheckNum);
            sqlCommand.Parameters.AddWithValue("@CustomerId", payment.CustomerID);
            sqlCommand.Parameters.AddWithValue("@PaymentDate", payment.PaymentDate);
            sqlCommand.Parameters.AddWithValue("@Amount", payment.Amount);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}