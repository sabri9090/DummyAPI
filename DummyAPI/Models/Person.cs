using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//La classe Person si trova nel namespace DummyAPI.Models che è differente 
//rispetto al namespace DummyAPI
namespace DummyAPI.Models
{
    //Per utilizzare questa classe al di fuori di questo namespace devo fare using DummyAPI.Models
    public class Person
    {
        //Nella maggior parte dei casi in una classe Entity/Model
        //Non c'è quasi mai business logic (Non ha per esempio metodi che effettuano calcoli)
        //Però non è una regola. E' soltanto dato dal fatto che queste classi hanno come scopo
        //finale quello di rappresentare un TIPO e basta.
        //SEPARATION OF CONCERN: separazione delle responsabilità
        //Ogni elemento deve avere una responsabilità precisa.
        //Es:
        //La classe Person non dev fare nient'altro che rappresentare un modello di Persona
        //Non deve (ad esempio) fare operazioni su database, non deve fare da controller
        //- Controller--> DEVE SOLO EFFETTUARE OPERAZIONI DI INPUT/OUTPUT
        //Non deve gestire la View, deve gestire il database.

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

       
    }
    //Attenzione che la classe Person è parte della business logic
    //Perchè verra utilizzata per effettuare delle operazioni interne al programma
}
