using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CreditCardPreQualification.DataAccess
{
    public static class SqlDataAccess
    {
        public static string GetConnectionString(string connection = "Database")
        {
            return ConfigurationManager.ConnectionStrings[connection].ConnectionString;
        }

        public static List<T> Get<T>(string sql)
        {
            using (IDbConnection db = new SqlConnection(GetConnectionString()))
            {
                return db.Query<T>(sql).ToList();
            }
        }

        public static int Add<T>(string sql, T data)
        {
            using (IDbConnection db = new SqlConnection(GetConnectionString()))
            {
                return db.Execute(sql, data);
            }
        }
    }
}