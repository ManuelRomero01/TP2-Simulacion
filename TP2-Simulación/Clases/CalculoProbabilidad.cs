using System;


namespace TP2_Simulación.Clases
{
    internal class CalculoProbabilidad
    {
        //Calculo de probabilidades segun la dsitribucion requerida
        public static double probabilidadUniforme(double x, double a, double b)
        {
            return (x - a) / (b - a);
        }

        public static double probabilidadExponencial(double x, double lambda)
        {
            return 1 - Math.Exp(-lambda * x);
        }

        public static double probabilidadNormal(double media, double desviacion, double limSup, double limInf)
        {
            double marcaDeClase = (limInf + limSup) / 2;
            double difLimites = (limSup - limInf);

            double a = Math.Exp(-0.5 * (Math.Pow(((marcaDeClase - media) / desviacion), 2)));
            double b = desviacion * Math.Sqrt(2 * Math.PI);
            return (a / b) * difLimites;
        }

        public static double probabilidadPoisson(double x, double lambda)
        {
            
            double a = Math.Pow(lambda, x) * Math.Exp(-lambda);
            return a / Auxiliar.calcularFactorial(x);
        }

    }
}