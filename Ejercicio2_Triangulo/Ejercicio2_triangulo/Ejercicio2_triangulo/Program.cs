using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Lea la longitud de tres segmentos y que muestre si se puede construir un triángulo con estos segmento

        double seg1, seg2, seg3, suma;
        bool esTriangulo;
        string msj;

        //perdir los datos
        Console.Write("Ingrese el primer segmento: ");
        seg1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo segmento: ");
        seg2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer segmento: ");
        seg3 = Convert.ToDouble(Console.ReadLine());

        //Proceso - Validacion

        if ((seg1 + seg2) > seg3)
        {
            if ((seg1 + seg3) > seg2)
            {
                if ((seg2 + seg3) > seg1)
                {
                    esTriangulo = true; 
                }
                else
                {
                    esTriangulo = false;
                }
            }
            else
            {
                esTriangulo = false;
            }
            
        }
        else
        {
            esTriangulo = false;
        }

        //mostrar mensaje - salida
        if (esTriangulo)
        {
            Console.Write("Se puede contruir el triangulo");
        }
        else
        {
            Console.Write("No se puede contruir el triangulo");
        }
    }
}