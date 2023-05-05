using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ejerccio_7
{
    class Estudiante : Persona
    {
        public Estudiante(string nom)
        {
            this.Nom1 = nom;
        }
        public void Estudiar()
        {
            Console.WriteLine("Estudiar...");
        }
    }
}
