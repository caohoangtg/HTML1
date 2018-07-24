using Project1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project1.DAL
{
    public class ProjectContext : DbContext
    {
        public ProjectContext() : base("ProjectContext")
        {
                
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}