using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.DAL
{
   public class RepostiryFactory
    {
       public static IRepository CreateRepository()
       {
           return new EFRepository(new DomainContext());
       }
    }
}
