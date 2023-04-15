using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP2_Simulación.Clases
{
    internal class CalculoProbabilidad
    {
        public static double probabilidadUniforme(double x, double a, double b)
        {
            return (x - a) / (b - a);
        }

        public static double probabilidadExponencial(double x, double lambda)
        {
            return 1 - Math.Exp(-lambda * x);
        }

        public static double probabilidadNormal(double x, double media, double desviacion)
        {
            double a = 1 / (desviacion * Math.Sqrt(2 * Math.PI));
            double b = (Math.Exp((-1 / 2) * (Math.Pow(((x - media) / desviacion), 2))));
            return a * b;
        }

        public static double probabilidadPoisson(double x, double lambda)
        {
            
            double a = Math.Pow(lambda, x) * Math.Exp(-lambda);
            return a / Math.Factorial(x);
        }





    }
}