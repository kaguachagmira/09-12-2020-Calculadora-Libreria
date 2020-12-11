using System;

namespace Matematica.negocio
{
    public class Calculadora
    {
        public Calculadora()
        {
        }

        public double Sumar(double primerNumero, double segundoNumero)
        {
            return primerNumero + segundoNumero;
        }
        public Complejo SumarComplejos(Complejo primerComplejo, Complejo segundoComplejo)
        {
            var parteReal = primerComplejo.getX() + segundoComplejo.getX();
            var parteImaginaria = primerComplejo.getY() + segundoComplejo.getY();

            return new Complejo(parteReal, parteImaginaria);
        }
    }
}