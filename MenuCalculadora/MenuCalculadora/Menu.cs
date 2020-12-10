using Matematica;
using System;

namespace MenuCalculadora
{
    class Menu
    {
        static void Main(string[] args)
        {
            var opcion = 0;
            var primerNumero = "";
            var segundoNumero = "";
            var numeroUnico = "";
            var calculadora = new Calculadora();
            do
            {
                Console.Clear();
                Console.WriteLine("**************************");
                Console.WriteLine("*    Kevin Guachagmira   *");
                Console.WriteLine("*       09/12/2020       *");
                Console.WriteLine("*                        *");
                Console.WriteLine("*    CALCULADORA EN C#   *");
                Console.WriteLine("*                        *");
                Console.WriteLine("**************************");
                Console.WriteLine("(1) Sumar");
                Console.WriteLine("(2) Restar");
                Console.WriteLine("(3) Multiplicar");
                Console.WriteLine("(4) Dividir");
                Console.WriteLine("(5) Número partido 1/x");
                Console.WriteLine("(6) Cuadrado de un número");
                Console.WriteLine("(7) Raiz de un número");
                Console.WriteLine("(8) Salir");
                Console.WriteLine("Seleccione una opción del menú: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Elegiste sumar");
                        ingresarValidar("sumar");
                        Console.WriteLine("La suma de " + primerNumero + " + " + segundoNumero + " es: " + calculadora.Sumar(int.Parse(primerNumero), int.Parse(segundoNumero)));
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Elegiste restar");
                        ingresarValidar("restar");
                        Console.WriteLine("La resta de " + primerNumero + " - " + segundoNumero + " es: " + calculadora.Restar(int.Parse(primerNumero), int.Parse(segundoNumero)));
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Elegiste multiplicar");
                        ingresarValidar("multiplicar");
                        Console.WriteLine("La multiplicación de " + primerNumero + " X " + segundoNumero + " es: " + calculadora.Multiplicar(int.Parse(primerNumero), int.Parse(segundoNumero)));
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Elegiste dividir");
                        ingresarValidar("dividir");
                        Console.WriteLine("La división de " + primerNumero + " / " + segundoNumero + " es: " + calculadora.Dividir(int.Parse(primerNumero), int.Parse(segundoNumero)));
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Elegiste mitad de un número");
                        ingresarValidar("mitad");
                        Console.WriteLine("La solución para 1/" + numeroUnico + " es: " + calculadora.Mitad(int.Parse(numeroUnico)));
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Elegiste el cuadrado de un número");
                        ingresarValidar("cuadrado");
                        Console.WriteLine("El número " + numeroUnico + " elevado al cuadrado es: " + calculadora.Potencia(int.Parse(numeroUnico)));
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Elegiste la raiz de un número");
                        ingresarValidar("raiz");
                        Console.WriteLine("La raiz cuadrada de " + numeroUnico + " es: " + calculadora.Raiz(int.Parse(numeroUnico)));
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine("Muchas gracias por usar este programita");
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        opcion = 8;
                        break;
                    default:
                        Console.WriteLine("La opción escogida no esta dentro del menú vuelve a digitarlo porfavor");
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                }
            } while (opcion != 8);

            void ingresarValidar(string clave)
            {
                if (clave == "sumar" || clave == "restar" || clave == "multiplicar")
                {
                    Console.WriteLine("Ingrese el primer número");
                    primerNumero = Console.ReadLine();
                    Console.WriteLine("Ingrese el segundo número");
                    segundoNumero = Console.ReadLine();
                }
                if (clave == "dividir")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Ingrese el dividendo");
                        primerNumero = Console.ReadLine();
                        Console.WriteLine("Ingrese el divisor");
                        segundoNumero = Console.ReadLine();
                        if (int.Parse(segundoNumero) == 0)
                        {
                            Console.WriteLine("El divisor no puede ser 0 ingrese de nuevo porfavor");
                            Console.WriteLine("Presiona una tecla para continuar");
                            Console.ReadLine();

                        }
                    } while (int.Parse(segundoNumero) == 0);

                }
                if (clave == "mitad" || clave == "cuadrado")
                {
                    Console.WriteLine("Ingrese el número a ser evaluado");
                    numeroUnico = Console.ReadLine();
                }
                if (clave == "raiz")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Ingrese el número a ser evaluado");
                        numeroUnico = Console.ReadLine();

                        if (int.Parse(numeroUnico) < 0)
                        {
                            Console.WriteLine("La base de la raiz no puede ser negativa ingrese de nuevo porfavor");
                            Console.WriteLine("Presiona una tecla para continuar");
                            Console.ReadLine();
                        }

                    } while (int.Parse(numeroUnico) < 0);
                }

            }
        }
    }
}
