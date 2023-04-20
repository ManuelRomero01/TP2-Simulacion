using System;

namespace LibGeneradores
{
    public class GeneradorExpoNegativo
    {
        // Definición de atributos
        private double lambda;
        private double media;
        private int datos;


        // Generador de números pseudoaleatorios
        private Random random = new Random();
        private double rnd;

        // Constructor de la clase
        public GeneradorExpoNegativo(double lambda, double media, int datos)
        {
            this.lambda = lambda;
            this.media = media;
            this.datos = datos;
        }

        // Generador de variables aleatorias uniformes con Lambda
        public (double[], string[]) generarVariablesAleatoriasLambda()
        {
            double[] x = new double[datos];
            string[] y = new string[datos];
            for (int i = 0; i < datos; i++)
            {
                rnd = Math.Truncate(random.NextDouble() * 10000) / 10000;

                y[i] = rnd.ToString();
                x[i] = Math.Truncate(((-1 / lambda) * Math.Log(1 - rnd)) * 10000) / 10000;

            }

            return (x, y);
        }

        // Generador de variables aleatorias uniformes con Media
        public (double[], string[]) generarVariablesAleatoriasMedia()
        {
            double[] x = new double[datos];
            string[] y = new string[datos];
            for (int i = 0; i < datos; i++)
            {

                rnd = Math.Truncate(random.NextDouble() * 10000) / 10000;

                while (rnd == 0.00)
                {
                    rnd = Math.Truncate(random.NextDouble() * 10000) / 10000;
                }

                x[i] = Math.Truncate((-media) * Math.Log(1 - rnd) * 10000) / 10000;
                y[i] = rnd.ToString();
            }
            return (x, y);
        }
    }
}
