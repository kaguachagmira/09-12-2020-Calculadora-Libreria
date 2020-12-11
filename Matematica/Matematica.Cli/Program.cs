using System;
using Matematica.negocio;

namespace Matematica.Cli
{
    class Program
    {
        static void Main(string[] args)
        {

            var primerNumero = "";
            var opcion = 0;
            var segundoNumero = "";
            var miCalculadora = new Calculadora();
            do
            {
                Console.Clear();
                Console.WriteLine("**************************");
                Console.WriteLine("*    Kevin Guachagmira   *");
                Console.WriteLine("*       09/12/2020       *");
                Console.WriteLine("*                        *");
                Console.WriteLine("*    CALCULADORA EN C#   *");
                Console.WriteLine("*     USANDO UNITTEST    *");
                Console.WriteLine("**************************");
                Console.WriteLine("(1) Sumar Enteros");
                Console.WriteLine("(2) Sumar Imaginarios");
                Console.WriteLine("(3) Salir");
                Console.WriteLine("Seleccione una opción del menú: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Elegiste sumar");
                        Console.WriteLine("Ingrese el primer numero");
                        primerNumero = Console.ReadLine();
                        Console.WriteLine("Ingrese el segundo numero");
                        segundoNumero = Console.ReadLine();
                        var respuesta = miCalculadora.Sumar(double.Parse(primerNumero), double.Parse(segundoNumero));
                        Console.WriteLine("La respuesta es: " + respuesta);
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 2:
                        
                        Console.WriteLine("Elegiste Sumar numeros complejos");
                        Console.WriteLine("Ingrese la parte real del primer numero complejo");
                        var realA = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la parte imaginaria del primer numero complejo");
                        var imaginarioA = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la parte real del segundo numero complejo");
                        var realB = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la parte imaginaria del segundo numero complejo");
                        var imaginarioB = int.Parse(Console.ReadLine());
                        var primerComplejo = new Complejo(realA, imaginarioA);
                        var segundoComplejo = new Complejo(realB, imaginarioB);

                        var respuestaSumaComplejos = miCalculadora.SumarComplejos(primerComplejo, segundoComplejo);

                        Console.WriteLine("La respuesa de la suma de los complejos es: " + respuestaSumaComplejos.getX() + "," + respuestaSumaComplejos.getY());
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("La opción escogida no esta dentro del menú vuelve a digitarlo porfavor");
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                }
            } while (opcion != 3);
            
        }
    }
}
