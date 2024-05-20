using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using invcom_BE.Models;
using Microsoft.EntityFrameworkCore;

namespace invcom_BE.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContextOptions)
        : base(dbContextOptions)
        {
            
        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}