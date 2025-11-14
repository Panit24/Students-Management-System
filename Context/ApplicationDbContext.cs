using Microsoft.EntityFrameworkCore;
using StudentsManagementSystem.Models;
using System;

namespace StudentsManagementSystem.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
