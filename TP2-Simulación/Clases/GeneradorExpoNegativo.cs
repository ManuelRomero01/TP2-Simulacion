using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Simulación.Clases
{
    internal class GeneradorExpoNegativo
    {
        //Definición de variables
        private double lambda;
        private double media;
        private int datos;


        //Definición del numero aleatorio
        private Random random = new Random();
        private double[] rnd;

        public GeneradorExpoNegativo(double lambda, double media, double datos)
        {
            lambda = this.lambda;
            media = this.media;
            datos = this.datos;
        }

        public (double[], double[]) generarVariablesAleatoriasLambda()
        {
            double[] x = new double[this.datos];
            rnd = new double[this.datos];
            for (int i = 0; i < this.datos; i++)
            {
                rnd[i] = Math.Truncate(random.NextDouble() * 10000) / 10000;
                x[i] = (-1 / this.lambda) * Math.Log(1 - rnd[i]);

            }

            return (x, rnd);
        }


        public (double[], double[]) generarVariablesAleatoriasMedia()
        {
            double[] x = new double[this.datos];
            rnd = new double[this.datos];
            for (int i = 0; i < this.datos; i++)
            {
                rnd[i] = Math.Truncate(random.NextDouble() * 10000) / 10000;
                x[i] = (-this.media) * Math.Log(1 - rnd[i]);

            }

            return (x, rnd);

        }
    }
}
