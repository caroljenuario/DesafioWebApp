﻿using CRUDWebApplication.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUDWebApplication.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
