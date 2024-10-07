//Una frutería ofrece las manzanas con descuento según la siguiente tabla

//Datos de entrada: cantida de kilos de manzanas
//proceso: 

internal class Program
{
    private static void Main(string[] args)
    {
        const decimal precioKiloManzana = 5000;
        decimal descuento, precioBruto, precioNeto, precioDescuento;

        Console.Write("Ingrese la cantidad de kilos de manzanas a comprar: ");
        decimal KilosManzanas = Convert.ToDecimal(Console.ReadLine());

        //calculos

        if (KilosManzanas >= 0 && KilosManzanas <= 2)
        {
            descuento = 0;
        }
        else if (KilosManzanas > 2 && KilosManzanas <= 5)
        {
            descuento = 10;
        }
        else if (KilosManzanas > 5 && KilosManzanas <= 10)
        {
            descuento = 15;
        }
        else
        {
            descuento = 20;
        }

        //calculo del precio bruto
        precioBruto = precioKiloManzana * KilosManzanas;

        //calculo precio decuento
        precioDescuento = precioBruto * (descuento / 100);

        //precio neto
        precioNeto = precioBruto - precioDescuento;

        //Mostrar los resultados:
        Console.WriteLine($"El valor a pagar por {KilosManzanas} kilos es de: {precioNeto:C0} ");
        Console.WriteLine($"Se aplicado un descuento del {descuento}% que equivale a {precioDescuento:C0} ");
    }
}