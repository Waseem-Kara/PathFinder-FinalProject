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
        public static IDbConnection PathFinderdb => new SqlConnection("Server=tcp:pathfinder.database.windows.net,1433;Initial Catalog=PathFinderdb;Persist Security Info=False;User ID={PathFinderAdmin};Password={PathFinder123};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }
}