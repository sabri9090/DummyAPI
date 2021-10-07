using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DummyAPI.Models
{
    public class Book
    {

        //La classe Book può richiamare la classe Person senza aggiungere using
        // perchè fanno parte delo stesso namespace (cartella Models)
        public Person Author { get; set; }

        public void Print()
        {
            Console.WriteLine("Print from book");
        }
    }
}
