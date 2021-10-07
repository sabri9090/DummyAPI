using DummyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DummyAPI.Services
{
    interface IProductService
    {
        //Il service deve fornire in qualche modo un IEnumerable di Product
        IEnumerable<Product> GetAll();

        Product GetById(int id);

        void AddProduct(Product product);

        void UpdateProduct(int id, Product product);
        void Delete(int id);

    }
}
