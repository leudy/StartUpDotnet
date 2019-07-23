using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
