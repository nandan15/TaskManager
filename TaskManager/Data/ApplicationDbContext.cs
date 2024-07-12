﻿using Microsoft.EntityFrameworkCore;
using TaskManager.Models;

namespace TaskManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TaskManager.Models.Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TaskManager.Models.Task>()
                .HasKey(t => t.TaskId);
        }
    }
}
