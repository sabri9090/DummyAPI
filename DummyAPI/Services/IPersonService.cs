using DummyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DummyAPI.Services
{   
    //Definire un contratto per tutte le classi che lo implementano
    //Fornire le operazioni CRUD sugli oggetti di tipo Person
    interface IPersonService
    {
        List<Person> GetAll();

        Person GetById(int id);

        void AddPerson(Person person);

        void UpdatePerson(int id, Person person);

        void DeletePerson(int id);

    }
}
