using Microsoft.EntityFrameworkCore;
using Task_Manager.Database;

namespace Task_Manager;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        string connection = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));
        // Add services to the container.
        builder.Services.AddSwaggerGen();
        builder.Services.AddControllers();
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        
        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoint =>
        {
            endpoint.MapControllers();
        });

        app.Run();
    }
}