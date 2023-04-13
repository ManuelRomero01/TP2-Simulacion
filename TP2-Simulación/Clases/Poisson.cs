using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Simulación.Clases
{
    internal class Poisson
    {
        private double lambda;
        private int datos;


        private Random random = new Random();
        private List<double> rnd;

        public Poisson(double lamda, int datos)
        {
            this.lambda = lamda;
            this.datos = datos;
        }

        public double[] generarVariablesAleatorias()
        {
            double[] x = new double[this.datos];
            List<double> rnd = new List<double>();
            for(int i = 0; i < this.datos; i++)
            {
                x[i] = generarValorX();
            }

            return x;
        }

        public double generarValorX()
        {
            List<double> numerosAleatorios = new List<double>();
            double p = 1;
            double x = -1;
            double a = Math.Exp(-(this.lambda));
            numerosAleatorios.Add(a);

            do
            {
                double u = Math.Truncate(random.NextDouble() * 10000) / 10000;
                p = p * u;
                x = x + 1;

            } while (p >= a);
            return (x);
        }
    }

}
