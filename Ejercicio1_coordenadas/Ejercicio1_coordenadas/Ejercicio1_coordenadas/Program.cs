// Lea las coordenadas de dos puntos y que muestre la distancia entre los dos puntos

using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        //Datos de Entrada
        //Declarar las variables en este caso son 4:
        double x1, y1, x2, y2, d;

        //Vamos a inicializar las variables pidiendoles sus valores por pantalla:
        Console.Write("Por favor ingrese el valor de x1: ");
        x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Por favor ingrese el valor de y1:  ");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Por favor ingrese el valor de x2:  ");
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Por favor ingrese el valor de y2:  ");
        y2 = Convert.ToDouble(Console.ReadLine());

        //Proceso - calcular la variable d
        double x = (x2 - x1) * (x2 - x1);
        double y = (y2 - y1) * (y2 - y1);


    }

  
}