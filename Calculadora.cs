using System;

namespace RoundTruncate.Test
{
    public class Calculadora
    {
        public double Suma(double num1, double num2)
        {
            var result = sumarDosNumeros(num1, num2);
            
            return result;
 }
        public double sumarDosNumeros(double num1,double num2)
        {
            return num1 + num2;

        }

        public double devolver( suma,numero)
        {
            return Math.Round(suma, numero);

        }

        public double Truncate(double num)
        {
        return Math.Truncate(num* 100)/ 100;

            }
    }
}