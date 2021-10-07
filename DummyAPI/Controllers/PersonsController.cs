using DummyAPI.Models;
using DummyAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DummyAPI.Controllers
{
    //I controller gestiscono INPUT/OUTPUT, questi controller
    //gestiscono chiamate attraverso il protocollo http (usando la rete ed uno specifico protocollo)

    [Route("[controller]")] //Rooute serve per mappare le chiamate che arrivano su "/nomeController"
    //in modo che vengono gestite dai metodi definiti dentro la classe
    [ApiController] //Questa class è un controller che gestisce risorse

    public class PersonsController : ControllerBase
    {
        /*Gestisco le chiamate di tipo Get
        [HttpGet]
        public string HelloWorld()
        {
            return "Ciao";
        }
        */

        //Assegno ad un nostro campo l'istanza (singleton) del service (nostro "DAO")
        private IPersonService _personService = ScaffoldingPersonService.GetInstance();
        //L'utilizzo di un'interfaccia serve ad avere un livello di astrazione
        //rispetto all'implementazione concreta
        //in un futuro potrò andare a sostituire la classe che sto utilizzando adesso
        //con un'altra che implementa lo stesso concetto

        [HttpGet] //Tramite la chiamata http arriva una richiesta di dati
        //IIl controller non può gestire ai dati, lo chiede aimodel
        public List<Person> Get()
        {
            var res= _personService.GetAll();
            return res;
        }
        //Noi gestiamo direttamente oggetti C°, ci pensa asp.net core a 
        // convertire questi oggetti in stringhe JSON

        [HttpPost] //le chiamate post si verificano in postman
        public void AddNewPerson([FromBody] Person person)
        {
            //[FromBody] dice esplicitamente da dove arriva il valore
            //(In realtà abbiamo visto che funziona anche senza, perchè lo prende come
            //"configurazione" di default, conviene però includerlo per chiarezza)
            //I client manderanno stringhe JSON

            //JQUERY E' UNA LIBRERIA
            //NUGGET IN C# E UNA LIBRERIA
            //Un framework è un insieme di strumenti che permettono di ottenere
            //dei risultati adottando un approccio imposto dal framework.
            //ASP.NET è un framework
            _personService.AddPerson(person);
        }

        [HttpGet("{id}")]
        public Person GetById([FromRoute]int id)
        {
            return _personService.GetById(id);
        }

        [HttpDelete("{id}")]
        public void RemoveById([FromRoute] int id)
        {
            _personService.DeletePerson(id);
        }

        //La differenza del put rispetto al resto è che è leggermente più complesso 
        //in quanto devo andare a recuperare due informazioni diverse in due parti 
        //diverse della chiamata http

        [HttpPut("{id}")]
        public void UpdatePerson([FromRoute] int id, [FromBody] Person person)
        {
            _personService.UpdatePerson(id, person);
        }


    }
}
