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
        //public static IDbConnection PathFinderdb => new SqlConnection("metadata=res://*/PathFindermodel.csdl|res://*/PathFindermodel.ssdl|res://*/PathFindermodel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=pathfinder.database.windows.net;initial catalog=PathFinderdb;persist security info=True;user id=PathFinderAdmin;password=PathFinder123;MultipleActiveResultSets=True;App=EntityFramework&quot;providerName=System.Data.EntityClient");
        public static IDbConnection PathFinderdb => new SqlConnection("Server=tcp:pathfinder.database.windows.net,1433;Initial Catalog=PathFinderdb;Persist Security Info=False;User ID=PathFinderAdmin;Password=PathFinder123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }
}