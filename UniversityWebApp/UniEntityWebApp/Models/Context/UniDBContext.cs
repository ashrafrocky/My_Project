using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniEntityWebApp.Models.Context
{
    public class UniDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}