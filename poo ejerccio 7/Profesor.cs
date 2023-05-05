using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ejerccio_7
{
    class Profesor : Persona
    {
        public Profesor (string Nom)
        {
            this.Nom1 = Nom;
        }
        public void Explicar() 
        {
            Console.WriteLine("Explicar...");
        }

    }
}
