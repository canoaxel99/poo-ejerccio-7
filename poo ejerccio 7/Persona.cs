using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ejerccio_7
{
    class Persona
    {
        string Nom;
        public Persona()
        {

        }
        public Persona(string nom)
        {
            Nom = nom;
        }
        public string Nom1 { get => Nom; set => Nom = value; }

        public override string ToString()
        {
            return "nombre" + Nom;
        }

    }
}
