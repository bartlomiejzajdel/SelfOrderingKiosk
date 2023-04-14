using SelfOrderingKiosk.Configuration;
using SelfOrderingKiosk.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SelfOrderingKiosk.DataAccess
{
    public static class DatabaseService
    {

        private static DataTable SelectFromDatabase(string dbName, string procedureName, SqlParameter[] parameters)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(DbConnection.ConnectionString);
                using SqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = $"{dbName}.{procedureName}";
                cmd.Parameters.AddRange(parameters);

                using SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                using DataSet resultSet = new DataSet();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                dataAdapter.Fill(resultSet);

                return resultSet.Tables[0];
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static DataTable GetProducts()
        {
            var dbName = "Mcdonalds";
            var storedProcedureName = "[dbo].[usp_ProductsGet]";

            return SelectFromDatabase(dbName, storedProcedureName, Array.Empty<SqlParameter>());
        }

        public static List<Product> GetProductsList()
        {
            var table = GetProducts();
            var collection = new List<Product>();
            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    collection.Add(new Product()
                    {
                        Id = row.Field<short>("Id"),
                        Name = row.Field<string>("Name"),
                        Type = row.Field<short>("Type"),
                        Price = row.Field<decimal>("Price"),
                        ImagePath = row.Field<string>("ImagePath"),
                    });
                }
            }
            return collection;
        }

    }
}
