using System;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
       /*21.	Realice un programa que solicite dos números, luego debe pedirse un número que seleccionará alguna operación aritmética desde un menú. Si introduce 1 los números se deben sumar, si introduce 2 los números se deben restar, si es 3 los números se multiplican y si introduce 4 los números se dividen (validar división por cero). Independientemente de la selección, imprima el resultado. Además, el programa debe tener la posibilidad de volver al menú para pedir 2 nuevos números y hacer la elección de la operación aritmética o digitar cero para finalizar el programa*/

        //Varibles de entrega
        double num1 , num2;
        int opcion;
        double resultado = 0;
        bool continuar = true;

        //Relizo toda la logica del codigo

        do
        {
            Console.Write("Ingrese el primer numero: ");
            num1 = double.Parse(Console.ReadLine()); //double.parse es exactamente lo mismo que convert.Tobouble

            Console.Write("Ingrese el segundo numero: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Seleccione una operacion aritmetica");
            Console.WriteLine("1. sumar                           ");
            Console.WriteLine("2. restar                          ");
            Console.WriteLine("3. multiplicar                     ");
            Console.WriteLine("4. dividir                         ");
            Console.WriteLine("0. salir                           ");
            Console.WriteLine("-------------------------------------");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion) 
            {
                case 1:
                    //Aqui implementamos la logica para el caso 1 y despues colocamos la palabra "break" !!!!
                    resultado = num1 + num2;
                    Console.WriteLine($"Suma: {num1} + {num2} = {resultado}");
                    break;



            
            }
            

       



        }
        while (true);
    }



}