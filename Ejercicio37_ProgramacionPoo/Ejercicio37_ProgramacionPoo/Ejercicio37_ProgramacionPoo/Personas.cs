using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37_ProgramacionPoo
{
    internal class Personas
    {
        //propiedades de mi clase persona:

        public string Nombre { get; set; } //forma de definir las propiedades

        public int Edad { get; set; }

        //Metodos de mi clase persona:

        //Esta es la forma de crear un metodo en C#:
        //Modificador de acceso + tipo de datos que retorna el metodo + nombre del metodo + seccion de parametros ()
        public void Presentar() //void significa que el metodo no retorna nada

        {
            Console.WriteLine($"Hola! Mi nombre es {Nombre} y tengo {Edad} años.");
        }

        public void EsMayorDeEdad()
        {
            if (Edad >=18)
            {
                Console.WriteLine("Soy mayor de edad.");
            }
            else
            {
                Console.WriteLine("Soy menor de edad.");
            }
        }
    }
}
