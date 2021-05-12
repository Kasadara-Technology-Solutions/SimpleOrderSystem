using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using SimpleOrderSystem.Services;
using System.Data;
using System.Data.SqlClient;
using SimpleOrderSystem.Models;

namespace SimpleOrderSystem.Services
{
    public class OrderServices : DbConnection
    {
       
        public IEnumerable<Order> GetAllOrders()
        {
            connection();
            List<Order> orders = new List<Order>();
            sqlCommand.CommandText = "select * from [Order]";
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {

                Order order1 = new Order();
                order1.ID = Convert.ToInt32(dataReader[0]);
                order1.CustomerID = Convert.ToInt32(dataReader["CustomerID"]);
                order1.OrderDate = Convert.ToDateTime(dataReader["OrderDate"]);
                order1.RequiredDate = Convert.ToDateTime(dataReader["RequiredDate"]);
                order1.ShippedDate = Convert.ToDateTime(dataReader["ShippedDate"]);
                order1.Status = Convert.ToInt32(dataReader["Status"]);
                order1.Comments = Convert.ToString(dataReader["Comments"]);
                orders.Add(order1);
            }
            sqlConnection.Close();
            var enumOrders = orders.AsEnumerable<Order>();
            return enumOrders;
        }

       
        public List<Order> GetOrderById(int ID)
        {
            connection();
            List<Order> orders = new List<Order>();
            sqlCommand.CommandText = "select * from [Order] where ID ="+ @ID +";";
            sqlCommand.Parameters.AddWithValue("@ID", ID);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Order order = new Order();
                order.ID = Convert.ToInt32(dataReader[0]);
                order.CustomerID = Convert.ToInt32(dataReader["CustomerID"]);
                order.OrderDate = Convert.ToDateTime(dataReader["OrderDate"]);
                order.RequiredDate = Convert.ToDateTime(dataReader["RequiredDate"]);
                order.ShippedDate = Convert.ToDateTime(dataReader["ShippedDate"]);
                order.Status = Convert.ToInt32(dataReader["Status"]);
                order.Comments = Convert.ToString(dataReader["Comments"]);
                orders.Add(order);
            }
            sqlConnection.Close();
            return orders;
        }
        public List<Order> GetOrdersByCustomerId(int id)
        {
            connection();
            List<Order> orders = new List<Order>();
            string procedure = "OrderByCustomerId";
            sqlCommand.CommandText = procedure;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Customer customer = new Customer();
                Order order = new Order();
                customer.ID = Convert.ToInt32(dataReader["ID"]);
                customer.SalesRepEmployeeNumber = Convert.ToInt32(dataReader["SalesRepEmployeeNumber"]);
                customer.Name = Convert.ToString(dataReader["Name"]);
                customer.FirstName = Convert.ToString(dataReader["FirstName"]);
                customer.LastName = Convert.ToString(dataReader["LastName"]);
                customer.Address1 = Convert.ToString(dataReader["Address1"]);
                customer.Address2 = Convert.ToString(dataReader["Address2"]);
                customer.Phone = Convert.ToString(dataReader["Phone"]);
                customer.City = Convert.ToString(dataReader["City"]);
                customer.State = Convert.ToString(dataReader["State"]);
                customer.PostalCode = Convert.ToString(dataReader["PostalCode"]);
                customer.Country = Convert.ToString(dataReader["Country"]);
                customer.CreditLimit = Convert.ToString(dataReader["CreditLimit"]);
                order.ID = Convert.ToInt32(dataReader["ID"]);
                order.CustomerID = Convert.ToInt32(dataReader["CustomerID"]);
                order.OrderDate = Convert.ToDateTime(dataReader["OrderDate"]);
                order.RequiredDate = Convert.ToDateTime(dataReader["RequiredDate"]);
                order.ShippedDate = Convert.ToDateTime(dataReader["ShippedDate"]);
                order.Status = Convert.ToInt32(dataReader["Status"]);
                order.Comments = Convert.ToString(dataReader["Comments"]);
                order.customer = customer;
                orders.Add(order);
            }
            sqlConnection.Close();
            return orders;
        }


        public List<Order> ListOrdersBySalesRepresentative(int id)
        {
            connection();
            List<Order> orders = new List<Order>();
            sqlCommand.CommandText = "select o.ID, o.CustomerID, o.OrderDate, o.RequiredDate, o.ShippedDate, o.Status,o.Comments from [dbo].[Order] as o left join (select c.ID, c.SalesRepEmployeeNumber from Customer as c left join Employee as e on c.SalesRepEmployeeNumber = e.Id where c.SalesRepEmployeeNumber = @id) as temp on o.CustomerID = temp.ID";
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Order order = new Order();
                order.ID = Convert.ToInt32(dataReader["ID"]);
                order.CustomerID = Convert.ToInt32(dataReader["CustomerID"]);
                order.OrderDate = Convert.ToDateTime(dataReader["OrderDate"]);
                order.RequiredDate = Convert.ToDateTime(dataReader["RequiredDate"]);
                order.ShippedDate = Convert.ToDateTime(dataReader["ShippedDate"]);
                order.Status = Convert.ToInt32(dataReader["Status"]);
                order.Comments = Convert.ToString(dataReader["Comments"]);
                orders.Add(order);
            }
            sqlConnection.Close();
            return orders;
        }

        public List<Order> ListOrdersBySalesOffice(int id)
        {
            connection();
            List<Order> orders = new List<Order>();
            sqlCommand.CommandText = "select o.ID, o.CustomerID, o.OrderDate, o.RequiredDate, o.ShippedDate, o.Status,o.Comments from [dbo].[Order] as o left join (select c.ID, c.SalesRepEmployeeNumber from Customer as c left join Employee as e on c.SalesRepEmployeeNumber = e.Officecode where c.SalesRepEmployeeNumber = @Officecode) as temp on o.CustomerID = temp.Officecode";
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Order order = new Order();
                order.ID = Convert.ToInt32(dataReader["ID"]);
                order.CustomerID = Convert.ToInt32(dataReader["CustomerID"]);
                order.OrderDate = Convert.ToDateTime(dataReader["OrderDate"]);
                order.RequiredDate = Convert.ToDateTime(dataReader["RequiredDate"]);
                order.ShippedDate = Convert.ToDateTime(dataReader["ShippedDate"]);
                order.Status = Convert.ToInt32(dataReader["Status"]);
                order.Comments = Convert.ToString(dataReader["Comments"]);
                orders.Add(order);
            }
            sqlConnection.Close();
            return orders;
        }





        public void CreateOrder(Order order)
        {
            connection();
            string procedure = "AddOrder";
            sqlCommand.CommandText = procedure;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@id", order.ID);
            sqlCommand.Parameters.AddWithValue("@CustomerId", order.CustomerID);
            sqlCommand.Parameters.AddWithValue("@OrderDate", order.OrderDate);
            sqlCommand.Parameters.AddWithValue("@RequiredDate", order.RequiredDate);
            sqlCommand.Parameters.AddWithValue("@ShippedDate", order.ShippedDate);
            sqlCommand.Parameters.AddWithValue("@Status", order.Status);
            sqlCommand.Parameters.AddWithValue("@Comments", order.Comments);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void EditOrder(Order order)
        {
            connection();
            string procedure = "EditOrder";
            sqlCommand.CommandText = procedure;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@id", order.ID);
            sqlCommand.Parameters.AddWithValue("@CustomerId", order.CustomerID);
            sqlCommand.Parameters.AddWithValue("@OrderDate", order.OrderDate);
            sqlCommand.Parameters.AddWithValue("@RequiredDate", order.RequiredDate);
            sqlCommand.Parameters.AddWithValue("@ShippedDate", order.ShippedDate);
            sqlCommand.Parameters.AddWithValue("@Status", order.Status);
            sqlCommand.Parameters.AddWithValue("@Comments", order.Comments);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

    }
}