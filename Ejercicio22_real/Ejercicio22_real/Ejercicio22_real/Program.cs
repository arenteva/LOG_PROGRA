using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        /* 22.	Se quiere crear un algoritmo en C# que calcule el IMC de N pacientes y luego lo clasifique dentro de una categoría:

- Si el IMC del paciente es menor a 18,5, entonces tiene peso insuficiente.
- Si el IMC está entre 18,5 y 24,9 se encuentre en la categoría de Peso Saludable
- Si el IMC está entre 25,0 y 29,9 entonces tiene sobrepeso
- Si el IMC es mayor de 29.9 entonces tiene obesidad.

Mostrar en pantalla la categoría de cada uno de los pacientes. La aplicación debe 	estar en capacidad de pedirle al usuario si quiere volver a calcular*/


        //Valores de entrada estatura y peso
        //
        double estatura, peso, imc;
        bool continuar = true;
        int n;
        string respuesta;

        while (continuar) // se encarga simplemente de controlar si el medico quiere calcular un nuevo grupo de pacientes
        {
            Console.Clear();
            Console.Write("Ingrese el numero de pacientes: ");
            n = Convert.ToInt32(Console.ReadLine());

            //El for estara dentro del while
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el peso del paciente # {i + 1} en 'kg': ");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.Write($"Ingrese la estatura del paciente # {i + 1} en 'm' : ");
                estatura = Convert.ToDouble(Console.ReadLine());

                //calcuar el IMC
                imc = peso / Math.Pow(2, estatura); //esto es lo mismo que poner (estatura * estatura)

                switch (imc) 
                {
                    // esta es la forma de validar una variable si existe dentro de un rango
                    case double cat when cat < 18.5:
                        Console.WriteLine($"El paciente con el IMC: {imc} esta en la categoria de 'Peso Insuficiente'");
                        break;

                    case double cat when cat >= 18.5 && cat < 25:
                        Console.WriteLine($"\nEl paciente con el IMC: {imc} esta en la categoria de 'Peso saludable'");
                        break;

                    case double cat when cat >= 25 && cat < 30:
                        Console.WriteLine($"\nEl paciente con el IMC: {imc} esta en la categoria de 'Sobre peso'");
                        break;

                    case double cat when cat >= 30:
                        Console.WriteLine($"\nEl paciente con el IMC: {imc} esta en la categoria de 'Obesidad'");
                        break;

                        default:
                        Console.WriteLine($"\nEl paciente con el IMC: {imc} no se encuentra en ninguna categoria");
                        break;



                } 
            }
            //Reatorno a while
            Console.WriteLine("Señor medico; ¿Desea calcular el IMC de mas pacientes? (S/N)");
            respuesta = Console.ReadLine().ToUpper();

            if (respuesta == "N")
            {
                continuar = false;
            }


        }
        
    } 
   

}