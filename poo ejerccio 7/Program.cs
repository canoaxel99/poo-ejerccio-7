using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ejerccio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] Per = new Persona[3];
            Per[0] = new Profesor ("Juan");
            Per[1] = new Persona("Sarah");
            Per[2] = new Profesor("Calos");
            foreach (Persona p1 in Per)
            {
                Console.WriteLine(p1.ToString());
            }
            foreach (Persona p in Per)
            {
                if (p is Estudiante)
                {
                    ((Estudiante)p).Estudiar();
                }
                else
                {
                    ((Profesor)p).Explicar();   
                }
            }
            Console.ReadKey();
        }
    }
}
