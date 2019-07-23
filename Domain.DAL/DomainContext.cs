using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Domain.Entities;
namespace Domain.DAL
{
   public class DomainContext:DbContext
    {
       public DomainContext()
           : base("name=InitDatabase")
       {

       }
       public DbSet<Product> Products { get; set; }
    }
}
