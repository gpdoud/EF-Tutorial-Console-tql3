using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tutorial;

public class AppDbContext : DbContext {

    public DbSet<User> Users { get; set; }
    public DbSet<Vendor> Vendors { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Request> Requests { get; set; }


    public AppDbContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

        var connectionString = "server=localhost\\sqlexpress;" +
                               "database=tqlprsdb;" +
                               "trusted_connection=true;" +
                               "trustServerCertificate=true;";

        optionsBuilder.UseSqlServer(connectionString);
    }

}
