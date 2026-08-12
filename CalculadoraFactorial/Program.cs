using System;

namespace CCalculadoraFactorial;

public class CalculadoraFactorial
{
    static void Main(string[] args)
    {
        try
        {
            int n = 0;
            while (true)
            {
                Console.WriteLine("Ingrese el numero que desea realizar su factorial (o escriba 'salir' para terminar):");

                string entrada = Console.ReadLine();

                if (entrada.ToLower() == "salir")
                {
                    break;
                }

                if (!int.TryParse(entrada, out n) || n <= 0)
                {
                    Console.WriteLine("Ingrese un numero positivo o caracter valido.\n");
                    continue;
                }

                long resultado = calcularFactorial(n);
                Console.WriteLine("Su resultado es " + resultado + "\n");

                Console.WriteLine("Presione cualquier tecla para limpiar la pantalla y continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocurrió un error desconocido: " + ex.Message);
        }

        Console.WriteLine("Presione una tecla para finalizar el programa...");
        Console.ReadKey();
    }

    static long calcularFactorial(int n)
    {
        long factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}