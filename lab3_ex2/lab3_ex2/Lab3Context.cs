﻿using lab3_ex2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace lab3_ex2.Data
{
    public class Lab3Context : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public Lab3Context(DbContextOptions<Lab3Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
