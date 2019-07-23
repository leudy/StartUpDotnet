using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities;
using Domain.DAL;

namespace Domain.Test
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se esta ejecutando la creacion de un producto usando el Repository Pattern");
            AddOneProduct();
            Console.ReadKey();
        }
        public static void AddOneProduct()
        {
            Product newProduct = new Product();
            newProduct.Name = "Agua Dasani";
            newProduct.Description = "Agua para evitar la desidratacion";
            newProduct.UnitInStock = 120;
            newProduct.UnitPrice = 40;
            using (var db =  RepostiryFactory.CreateRepository())
            {
                var producto = db.Create<Product>(newProduct);
                Console.WriteLine(String.Format(" Se ha Creado un nuevo producto con el Id {0}",producto.Id));
            }



        }
    }
}
