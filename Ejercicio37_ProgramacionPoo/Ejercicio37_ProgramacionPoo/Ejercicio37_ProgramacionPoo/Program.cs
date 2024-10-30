using Ejercicio37_ProgramacionPoo;

internal class Program
{
    private static void Main(string[] args)
    {
        /*37.	Desarrollar un programa en C# utilizando los conceptos básicos de la Programación Orientada a Objetos (POO) y bucles para permitir la creación y presentación de N personas. El programa debe solicitar al usuario el número de personas que desea ingresar, obtener los datos de cada una (nombre y edad), y luego mostrar una presentación de cada persona junto con la verificación de si es mayor de edad*/

        //Solicitar por pantalla cuantas personas quiero presentar y validar numero de edad 
        Console.WriteLine("¿Cuantas personas quieres presentar?:");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Ingrese el nombre de la persona:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la edad de la persona:");
            int edad = Convert.ToInt32(Console.ReadLine());

            //Vamos a crear una nueva instancia de la clase persona, Esto significa que vamos a crear un nuevo objeto de la clase persona

            Personas personas = new Personas(); //estamos creando un nuevo objeto de la clase persona

            //Vamos a asignar los valores que el usuario ingreso a las propiedades a la clase persona
            personas.Nombre = nombre; 

        
        
        }




    }
}