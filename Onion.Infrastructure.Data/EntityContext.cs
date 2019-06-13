using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using Onion.Domain.Core;

namespace Onion.Infrastructure.Data
{
    public class EntityContext: DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<City> Cities { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.1.5;Database=bcs_db1;Trusted_Connection=True;");
        }
    }
}
