using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using SimpleOrderSystem.Models;

namespace SimpleOrderSystem.Services
{
    public class ProductService:DbConnection
    {
        public IEnumerable<Product> GetAllProducts()
        {
            connection();
            List<Product> products = new List<Product>();
            string GetallProducts = "GetallProducts";
            sqlCommand.CommandText = "select * from [Product]";
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Product product = new Product();
                product.Code = Convert.ToInt32(dataReader["Code"]);
                product.ProductlineID = Convert.ToInt32(dataReader["ProductlineId"]);
                product.Name = Convert.ToString(dataReader["Name"]);
                product.Scale = Convert.ToInt32(dataReader["Scale"]);
                product.Vendor = Convert.ToString(dataReader["Vendor"]);
                product.PdtDescription = Convert.ToString(dataReader["PdtDescription"]);
                product.QtyInStock = Convert.ToInt32(dataReader["QtyInStock"]);
                product.BuyPrice = Convert.ToInt32(dataReader["BuyPrice"]);
                product.MSRP = Convert.ToString(dataReader["MSRP"]);
                products.Add(product);
            }

            sqlConnection.Close();
            var enumProducts = products.AsEnumerable<Product>();
            return enumProducts;
        }

        public List<Product> GetProductsById(int ID)
        {
            List<Product> products = new List<Product>();
            connection();
            //sqlCommand.CommandText = "select * from Product where ProductlineId = @id";
            string sample = "ProductsByID";
            sqlCommand.CommandText = sample;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@ID",ID);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Product product = new Product();
                Productline productline = new Productline();
                product.Code = Convert.ToInt32(dataReader["Code"]);
                product.ProductlineID = Convert.ToInt32(dataReader["ProductlineID"]);
                product.Name = Convert.ToString(dataReader["Name"]);
                product.Scale = Convert.ToInt32(dataReader["Scale"]);
                product.Vendor = Convert.ToString(dataReader["Vendor"]);
                product.PdtDescription = Convert.ToString(dataReader["PdtDescription"]);
                product.QtyInStock = Convert.ToInt32(dataReader["QtyInStock"]);
                product.BuyPrice = Convert.ToInt32(dataReader["BuyPrice"]);
                product.MSRP = Convert.ToString(dataReader["MSRP"]);
                productline.ID = Convert.ToInt32(dataReader["ID"]);
               // productline.DesclnHTML = Convert.ToString(dataReader["DesclnHTML"]);
                productline.DesclnText = Convert.ToString(dataReader["DesclnText"]);
                productline.Image = Convert.ToString(dataReader["Image"]);
                product.productline = productline;
                products.Add(product);
            }
            sqlConnection.Close();
            return products;
        }

        public Product GetProductByName(string name)
        {
            List<Product> products = new List<Product>();
            connection();
            sqlCommand.CommandText = "select * from Product where Name = @name";
            sqlCommand.Parameters.AddWithValue("@name", name);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            Product product = new Product();
            while (dataReader.Read())
            {
                product.Code = Convert.ToInt32(dataReader["Code"]);
                product.ProductlineID = Convert.ToInt32(dataReader["ProductlineId"]);
                product.Name = Convert.ToString(dataReader["Name"]);
                product.Scale = Convert.ToInt32(dataReader["Scale"]);
                product.Vendor = Convert.ToString(dataReader["Vendor"]);
                product.PdtDescription = Convert.ToString(dataReader["PdtDescription"]);
                product.QtyInStock = Convert.ToInt32(dataReader["QtyInStock"]);
                product.BuyPrice = Convert.ToInt32(dataReader["BuyPrice"]);
                product.MSRP = Convert.ToString(dataReader["MSRP"]);
                products.Add(product);
            }
            sqlConnection.Close();
            return product;
        }


        public Order_Product GetProductsByOrderId(int ID)
        {
            connection();
            string procedure = "ProductbyOrderId";
            sqlCommand.CommandText = procedure;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@ID", ID);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            Product product = new Product();
            Order order = new Order();
            Order_Product order_Product = new Order_Product();
            while (dataReader.Read())
            {
              
                order.ID = Convert.ToInt32(dataReader["ID"]);
                order.CustomerID = Convert.ToInt32(dataReader["CustomerID"]);
                order.OrderDate = Convert.ToDateTime(dataReader["OrderDate"]);
                order.RequiredDate = Convert.ToDateTime(dataReader["RequiredDate"]);
                order.ShippedDate = Convert.ToDateTime(dataReader["ShippedDate"]);
                order.Status = Convert.ToInt32(dataReader["Status"]);
                order.Comments = Convert.ToString(dataReader["Comments"]);
                product.Code = Convert.ToInt32(dataReader["Code"]);
                product.ProductlineID = Convert.ToInt32(dataReader["ProductlineID"]);
                product.Name = Convert.ToString(dataReader["Name"]);
                product.Scale = Convert.ToInt32(dataReader["Scale"]);
                product.Vendor = Convert.ToString(dataReader["Vendor"]);
                product.PdtDescription = Convert.ToString(dataReader["PdtDescription"]);
                product.QtyInStock = Convert.ToInt32(dataReader["QtyInStock"]);
                product.BuyPrice = Convert.ToInt32(dataReader["BuyPrice"]);
                product.MSRP = Convert.ToString(dataReader["MSRP"]);
                order_Product.product = product;
                order_Product.order = order;
            }
            sqlConnection.Close();
            return order_Product;
        }

        public Order_Product GetProductsByCustomerId(int ID)
        {
            connection();
            string procedure = "ProductbyCustomerId";
            sqlCommand.CommandText = procedure;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@ID", ID);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            Product product = new Product();
            Order order = new Order();
            Order_Product order_Product = new Order_Product();
            while (dataReader.Read())
            {

                order.ID = Convert.ToInt32(dataReader["ID"]);
                order.CustomerID = Convert.ToInt32(dataReader["CustomerID"]);
                order.OrderDate = Convert.ToDateTime(dataReader["OrderDate"]);
                order.RequiredDate = Convert.ToDateTime(dataReader["RequiredDate"]);
                order.ShippedDate = Convert.ToDateTime(dataReader["ShippedDate"]);
                order.Status = Convert.ToInt32(dataReader["Status"]);
                order.Comments = Convert.ToString(dataReader["Comments"]);
                product.Code = Convert.ToInt32(dataReader["Code"]);
                product.ProductlineID = Convert.ToInt32(dataReader["ProductlineID"]);
                product.Name = Convert.ToString(dataReader["Name"]);
                product.Scale = Convert.ToInt32(dataReader["Scale"]);
                product.Vendor = Convert.ToString(dataReader["Vendor"]);
                product.PdtDescription = Convert.ToString(dataReader["PdtDescription"]);
                product.QtyInStock = Convert.ToInt32(dataReader["QtyInStock"]);
                product.BuyPrice = Convert.ToInt32(dataReader["BuyPrice"]);
                product.MSRP = Convert.ToString(dataReader["MSRP"]);
                order_Product.product = product;
                order_Product.order = order;
            }
            sqlConnection.Close();
            return order_Product;
        }

        public void CreateProduct(Product product)
        {
            connection();
            string procedure = "AddProduct";
            sqlCommand.CommandText = procedure;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@code", product.Code);
            sqlCommand.Parameters.AddWithValue("@ProductlineId", product.ProductlineID);
            sqlCommand.Parameters.AddWithValue("@Name", product.Name);
            sqlCommand.Parameters.AddWithValue("@Scale", product.Scale);
            sqlCommand.Parameters.AddWithValue("@Vendor", product.Vendor);
            sqlCommand.Parameters.AddWithValue("@PdtDescription", product.PdtDescription);
            sqlCommand.Parameters.AddWithValue("@QtyInStock", product.QtyInStock);
            sqlCommand.Parameters.AddWithValue("@BuyPrice", product.BuyPrice);
            sqlCommand.Parameters.AddWithValue("@MSRP", product.MSRP);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }


        public void EditProduct(Product product)
        {
            connection();
            string procedure = "EditProduct";
            sqlCommand.CommandText = procedure;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@code", product.Code);
            sqlCommand.Parameters.AddWithValue("@ProductlineId", product.ProductlineID);
            sqlCommand.Parameters.AddWithValue("@Name", product.Name);
            sqlCommand.Parameters.AddWithValue("@Scale", product.Scale);
            sqlCommand.Parameters.AddWithValue("@Vendor", product.Vendor);
            sqlCommand.Parameters.AddWithValue("@PdtDescription", product.PdtDescription);
            sqlCommand.Parameters.AddWithValue("@QtyInStock", product.QtyInStock);
            sqlCommand.Parameters.AddWithValue("@BuyPrice", product.BuyPrice);
            sqlCommand.Parameters.AddWithValue("@MSRP", product.MSRP);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }




    }
}