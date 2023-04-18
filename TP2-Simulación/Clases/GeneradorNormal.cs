using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Simulación.Clases
{
    internal class GeneradorNormal
    {
        // Definición de atributos
        private double media;
        private int cantidad;
        private double desviacion;

        // Constructor de la clase
        public GeneradorNormal(double desviacion, double media, int cantidad)
        {
            this.desviacion = desviacion;
            this.media = media;
            this.cantidad = cantidad;
        }

        // Generador de números pseudoaleatorios
        private Random random = new Random();
        double random1;
        double random2;


        // Box Muller
        private double calculoNormalN1(double random1, double random2)
        {
            double resultado = (Math.Sqrt(-2 * Math.Log(random1)) * Math.Cos(2 * Math.PI * random2)) * desviacion + media;
            return resultado;
        }
        
        private double calculoNormalN2(double random1, double random2)
        {
            double resultado = (Math.Sqrt(-2 * Math.Log(random1)) * Math.Sin(2 * Math.PI * random2)) * desviacion + media;
            return resultado;
        }

        // Generador de variables aleatorias normal
        public (double[], double[]) generarDistribucionNormal()
        {
            double[] x = new double[cantidad];
            double[] y = new double[cantidad];
            double variableAleatoria;
            

            random1 = Math.Truncate(random.NextDouble() * 10000) / 10000;
            random2 = Math.Truncate(random.NextDouble() * 10000) / 10000;

            for (int i = 0; i < cantidad ; i++)
            {
                if (i % 2 == 0)
                {
                    variableAleatoria = calculoNormalN1(random1, random2);
                    y[i] = random1;
                }
                else
                {             
                    variableAleatoria = calculoNormalN2(random1, random2);
                    y[i] = random2;
                    random1 = Math.Truncate(random.NextDouble() * 10000) / 10000;
                    random2 = Math.Truncate(random.NextDouble() * 10000) / 10000;
                }
                x[i] = variableAleatoria;
            }
            return (x, y);
        }
    }
}