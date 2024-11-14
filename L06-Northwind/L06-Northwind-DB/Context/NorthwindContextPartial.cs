using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace L06_Northwind_DB.Context;

public partial class NorthwindContext
{
    protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            SqliteConnectionStringBuilder builder = new SqliteConnectionStringBuilder();
            //Path.Combine(AppContext.BaseDirectory, "Data", "Northwind.db");
            builder.DataSource =
                "/Users/kevs/Documents/workshop/Curso-Dotnet/L06-Northwind/L06-Northwind-DB/northwind.db";

            optionsBuilder.UseSqlite(builder.ConnectionString);
        }
    }
}