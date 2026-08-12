using System;
namespace IVA
{
    public class CalculoIVA
    {
        static void Main(string[] args)
        {
            try
            {
                double factura = 0, iva = 0, resultado = 0;
                do
                {
                    System.Console.WriteLine("Ingrese la factura: ");
                    factura = Validar();
                    if (factura <= 0)
                    {
                        System.Console.WriteLine("Dato no valido");
                    }
                } while (factura <= 0 || factura >= double.MaxValue);

                do
                {
                    System.Console.WriteLine("Ingrese el porcentaje de IVA(15% - 30%):");
                    iva = Validar();
                    if (iva <= 15 && iva >= 30)
                    {
                        iva /= 100;
                    }
                    else
                    {
                        System.Console.WriteLine("Se aplicara el 15% por defecto");
                        iva = 0.15;
                    }
                } while (iva <= 0);


                resultado = Calc(factura, iva);
                System.Console.WriteLine($"Su factura despues de impuestos es: {resultado}");


            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

        static double Validar()
        {
            double x;
            if (double.TryParse(Console.ReadLine(), out x) && x > 0)
            {
                return x;
            }
            System.Console.WriteLine("No se puede ingresar letras, numeros negativos ni 0");
            return -1;
        }

        static double Calc(double factura, double iva)
        {
            return factura + (factura * iva);
        }
    }
}