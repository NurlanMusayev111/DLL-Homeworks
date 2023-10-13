using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class ProductService
    {
        private Product[] GetAll()
        {
            return new Product[]
            {
                new Product{Id = 1,Name = "Iphone 14pro",Color = "Purple" , Price = 3000,Count = 10},
                new Product{Id = 1,Name = "Iphone 13pro",Color = "Blue" , Price = 2600,Count = 15},
                new Product{Id = 1,Name = "Iphone 12pro",Color = "Gray" , Price = 2000,Count = 7},
                new Product{Id = 1,Name = "Iphone 11pro",Color = "White" , Price = 1800,Count = 18},
            };
        }


        public Product[] GetAllByCount(int count)
        {
            Product[] products = GetAll();

            var result = products.Where(m => m.Count > count).ToArray();

            return result;
        }
            
    }
}
