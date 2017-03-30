using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PathFinder.Models
{
    public static class DatabaseConnection
    {
        public static IDbConnection PathFinderDb => new SqlConnection("Server=localhost;Database=PathFinderDb;Trusted_Connection=True;");
    }
}