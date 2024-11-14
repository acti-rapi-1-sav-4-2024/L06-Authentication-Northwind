using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace L06_Northwind_DB.Context;

public static class NorthwindContextExtensions
{
    public static IServiceCollection AddNorthwindContext(this IServiceCollection services, string? connectionString = null)
    {
        if (connectionString == null)
        {
            SqliteConnectionStringBuilder builder = new SqliteConnectionStringBuilder();
            //Path.Combine(AppContext.BaseDirectory, "Data", "Northwind.db");
            builder.DataSource =
                "/Users/kevs/Documents/workshop/Curso-Dotnet/L06-Northwind/L06-Northwind-DB/northwind.db";
            
            connectionString = builder.ConnectionString;
        }

        services.AddDbContext<NorthwindDbContext>(options =>
        {
            options.UseSqlite(connectionString);
        });

        return services;
    }
}