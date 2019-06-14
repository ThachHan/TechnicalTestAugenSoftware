using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AspnetCoreSPA.Data.Entity;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace AspnetCoreSPA.Data.DbManager
{
    public partial class EntityCoreContext : DbContext
    {
        public EntityCoreContext(DbContextOptions<EntityCoreContext> options)
            : base(options)
        {

        }
        public DbSet<Customer> Customer { get; set; }        
    }
}
