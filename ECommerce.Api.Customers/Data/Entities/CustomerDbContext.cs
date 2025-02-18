﻿using Microsoft.EntityFrameworkCore;

namespace ECommerce.Api.Customers.Data.Entities
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
