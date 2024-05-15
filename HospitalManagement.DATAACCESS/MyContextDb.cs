using HospitalManagement.COMMON.MODELS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.DATAACCESS
{
    public class MyContextDb : DbContext
    {
        public DbSet<User> Users { get; set; }
        public MyContextDb(DbContextOptions<MyContextDb> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
