using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServerApp.Model;

namespace ServerApp.Repository
{
    public class ProductRepository : DatabaseRepository
    {
       public Products Add(Products product)
        {
            if (product != null)
            {
                DatabaseContext.Products.Add(product);
                DatabaseContext.SaveChanges();
                return product;
            }

            var obj = new Products();

            return obj;
            
        }

        public List<Products> GetAll()
        {
            return DatabaseContext.Products.ToList();
        }

        public Products GetById(int productId)
        {
            return DatabaseContext.Products.SingleOrDefault(product=>product.id==productId);
        }

        public Products Update(Products product)
        {
            DatabaseContext.Products.Update(product);
            DatabaseContext.SaveChanges();
            return product;
        }

        public bool Delete(Products product)
        {
            DatabaseContext.Products.Remove(product);
            DatabaseContext.SaveChanges();
            return true;
        }
    }
}
