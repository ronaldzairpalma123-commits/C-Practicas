using System;
namespace CalcularSalariototal;

class CalcularSalariototal
{
    static void Main(string[] args)
    {
        int categoria, horasextras;
        double salariobase, preciohoraextra, salariototal;
        do
        {
            Console.WriteLine("Ingrese la categoría del trabajador (1, 2, 3 o 4):");
            categoria = (int)Validad(); 
        } while (categoria <= 0 || categoria > 4);

        do
        {
            Console.WriteLine("Ingrese el salario base del trabajador:");
            salariobase = Validad();

            Console.WriteLine("Ingrese el número de horas extras trabajadas:");
            horasextras = (int)Validad();
        }while (salariobase <= 0 || horasextras < 0);

        switch (categoria)
        {
            case 1:
                preciohoraextra = 30;
                break;
            case 2:
                preciohoraextra = 38;
                break;
            case 3:
                preciohoraextra = 50;
                break;
            case 4:
                preciohoraextra = 70;
                break;
            default:
                Console.WriteLine("Categoría no válida.");
                return;
        }

        salariototal = CalcularSalarioTotal(salariobase, horasextras, preciohoraextra);
        Console.WriteLine($"El salario total del trabajador es: {salariototal}");
    }

    static double Validad()
    {
        double val;
        if (double.TryParse(Console.ReadLine(), out val) && val > 0)
        {
            return val;
        }
        else
        {
            Console.WriteLine("Valor no válido. Intente de nuevo.");
            return -1;
        }
    }

    static double CalcularSalarioTotal(double salariobase, int horasextras, double preciohoraextra)
    {
        return salariobase + (horasextras * preciohoraextra);
    }
}