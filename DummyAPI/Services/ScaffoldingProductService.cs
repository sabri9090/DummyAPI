using DummyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DummyAPI.Services
{
    public class ScaffoldingProductService : IProductService
    {
        //campi privati iniziano con underscore

        //SCAFFOLDING: Gestione dei dati direttamente a livello di codice
        //in modo da avere un risultato immediato per mettere alla prova 
        //la nostra implementazione
        //Sono dati di prova

        private static ScaffoldingProductService _instance;
        private  static ScaffoldingProductService GetInstance()
        {
            if (_instance == null)
                _instance = new ScaffoldingProductService();
            return _instance;
        }


        private List<Product> _products = new List<Product> {
            new Product{
                Id=1, Name="Mouse da gaming", Category="Gaming", Price=19.99 
            },
            new Product{
                Id=2, Name="Notebook", Category="Informatica", Price=1200.99
            },
            new Product{
                Id=3, Name="Caricabatterie type-c", Category="Accessori", Price=9.99
            },
        };

        private int _lastId = 4;
        //Il prodotto che arriva al metodo molto probabilmente 
        //sarà sprovvisto di ID. Glie lo assegnamo noi
        public void AddProduct(Product product)
        {
            product.Id = _lastId++;
            _products.Add(product);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
