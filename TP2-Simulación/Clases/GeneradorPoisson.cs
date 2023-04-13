using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Simulación.Clases
{
    internal class GenearadorPoisson
    {
        private double lambda;
        private int datos;


        private Random random = new Random();
        private List<double> rnd;

        public GenearadorPoisson(double lamda, int datos)
        {
            this.lambda = lamda;
            this.datos = datos;
        }

        public double[] generarVariablesAleatorias()
        {
            double[] x = new double[this.datos];
            for(int i = 0; i < this.datos; i++)
            {
                x[i] = Math.Truncate(generarValorX() *10000) / 10000;
            }

            return x;
        }

        public double generarValorX()
        {
            double p = 1;
            double x = -1;
            double a = Math.Exp(-(this.lambda));

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
