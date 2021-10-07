using DummyAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DummyAPI.Services
{
    //Un servizio è n elemento che mi fornisce la business logic
    public class ScaffoldingPersonService : IPersonService
    {

        //Implementazione del Singleton
        private static ScaffoldingPersonService _instance;

        public static ScaffoldingPersonService GetInstance()
        {
            if (_instance is null)
                _instance = new ScaffoldingPersonService();
            return _instance;
        }

        //Il seguente è un campo non un metodo. stiamo dichiarando la lista
        private List<Person> _people = new List<Person>
        {
            new Person
            {
                Id=1, Name="Mario", Age=25
            },
            new Person
            {
                Id=2, Name="Paola", Age=22
            },
            new Person
            {
                Id=3, Name="Francesca", Age=35
            }
        };

        private int lastId = 4;


        public void AddPerson(Person person)
        {
            person.Id = lastId++;
            _people.Add(person);
        }

        public void DeletePerson(int id)
        {
            //quando è -1 vuol dire che non esiste l'oggetto ricercato
            var indexOfPerson = _people.FindIndex(p => p.Id == id);
            if (indexOfPerson >= 0)
            {
                _people.RemoveAt(indexOfPerson);
            }
        }

        public List<Person> GetAll()
        {
            return _people;
        }

        public Person GetById(int id)
        {
            /*foreach (var p in _people)
            {
                if (p.Id == id)
                    return p;
            }
                return null;
            */

            return _people.Where(p => p.Id == id).FirstOrDefault();
            
        }

    


        public void UpdatePerson(int id, Person person)
        {
            var indexOfExisting = _people.FindIndex(p => p.Id == id);
            if (indexOfExisting >= 0)
            {
                person.Id = id;
                _people[indexOfExisting] = person;
            }
        }
    }
}
