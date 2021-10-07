//using nome.namespace ci permette di utilizzare tutti gli elementi di quel determinato namespace
using DummyAPI.Models;
using DummyAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//I metodi dei controller gestisscono le chiamate
// i metodi interni restituiscono qualcosa
namespace DummyAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    //ControllerBase a differenza di quello "normale"
    //Non è in grado di gestire le view, ma soltanto le risorse pure
    //Implicitamente andrà a SERIALIZZARE gli oggetti restituiti dai vari
    //metodi MAPPATI in un formato "standard", cioè il JSON
    {
        private IProductService _productService = new ScaffoldingProductService();

        //Serve a dire al framwork che questo metodo dovrà rispondere
        //alle chiamate HTTP di tipo (verbo/metodo) GET
        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return _productService.GetAll();
        }

        [HttpPost]

        public IActionResult AddProduct(
            //Fa in modo che il body della chiamata venga passata come
            //parametro al metodo. Effettua la 
            [FromBody]Product newProduct)
        {
            _productService.AddProduct(newProduct);
            //Ok è un metodo derivato da baseController che mi permette
            //di restituire in modo immediato uno stato positivo della chiamata
            return Ok();
        }

    }
}
