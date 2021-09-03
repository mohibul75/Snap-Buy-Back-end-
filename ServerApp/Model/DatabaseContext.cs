using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ServerApp.Model
{
    public class DatabaseContext: DbContext
    {
        private const string ConnectionString = @"Server=DESKTOP-N8GTP72;Database=snapBuy;Trusted_Connection=true";


        public DbSet<Products> Products { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Cart> Cart { get; set; }

        public DbSet<Admin> Admin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
