using System;

namespace Matematica
{
    public class Calculadora
    {
        public int Sumar(int primerNumero, int segundoNumero)
        {
            return primerNumero + segundoNumero;
        }
        public int Restar(int primerNumero, int segundoNumero)
        {
            return primerNumero - segundoNumero;
        }
        public int Multiplicar(int primerNumero, int segundoNumero)
        {
            return primerNumero * segundoNumero;
        }
        public double Dividir(int primerNumero, int segundoNumero)
        {
            return (double)primerNumero / segundoNumero;
        }
        public double Mitad(int numeroUnico)
        {
            return (double)1 / numeroUnico;
        }
        public int Potencia(int numeroUnico)
        {
            return (int)Math.Pow(numeroUnico, 2);
        }
        public double Raiz(int numeroUnico)
        {
            return (double)Math.Sqrt(numeroUnico);
        }
    }
}
