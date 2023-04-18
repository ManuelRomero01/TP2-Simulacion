using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Simulación.Clases
{
    internal class GeneradorExpoNegativo
    {
        // Definición de atributos
        private double lambda;
        private double media;
        private int datos;


        // Generador de números pseudoaleatorios
        private Random random = new Random();
        private double rnd;

        // Constructor de la clase
        public GeneradorExpoNegativo(double lambda, double media, double datos)
        {
            lambda = this.lambda;
            media = this.media;
            datos = this.datos;
        }

        // Generador de variables aleatorias uniformes con Lambda
        public (double[], double[]) generarVariablesAleatoriasLambda()
        {
            double[] x = new double[this.datos];
            double[] y = new double[this.datos];
            for (int i = 0; i < this.datos; i++)
            {
                rnd = Math.Truncate(random.NextDouble() * 10000) / 10000;
                y[i] = rnd;
                x[i] = Math.Truncate(-1 / this.lambda) * Math.Log(1 - rnd * 10000) / 10000;

            }

            return (x, y);
        }

        // Generador de variables aleatorias uniformes con Media
        public (double[], double[]) generarVariablesAleatoriasMedia()
        {
            double[] x = new double[this.datos];
            double[] y = new double[this.datos];
            for (int i = 0; i < this.datos; i++)
            {
                rnd = Math.Truncate(random.NextDouble() * 10000) / 10000;
                x[i] = Math.Truncate((-this.media) * Math.Log(1 - rnd) * 10000) / 10000;
                y[i] = rnd;
            }
            return (x, y);
        }
    }
}

