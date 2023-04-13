using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Simulación.Clases
{
    internal class GenearadorNormal
    {
        public double calculoNormalN1(double random1, double random2, double desviacion, double media)
        {
            double resultado = (Math.Sqrt(-2 * Math.Log(random1)) * Math.Cos(2 * Math.PI * random2)) * desviacion - media;
            return resultado;
        }

        public double calculoNormalN2(double random1, double random2, double desviacion, double media)
        {
            double resultado = (Math.Sqrt(-2 * Math.Log(random1)) * Math.Sin(2 * Math.PI * random2)) * desviacion - media;
            return resultado;
        }

        // Generador de variables aleatorias uniformes
        public double[] generarDistribucionNormal(double media, double desviacion, int cantidad)
        {
            double[] listadoX = new double[cantidad];
            double variableAleatoria;
            double random1;
            double random2;
            Random random = new Random();

            for (int i = 0; i < cantidad ; i++)
            {
                if (i % 2 == 0)
                {
                    random1 = Math.Truncate(random.NextDouble() * 10000) / 10000;
                    random2 = Math.Truncate(random.NextDouble() * 10000) / 10000;
                    variableAleatoria = calculoNormalN1(random1, random2, desviacion, media);
                }
                else
                {
                    //Genere de nuevo dos random porque sino daba error, ver de solucionar esto
                    random1 = Math.Truncate(random.NextDouble() * 10000) / 10000;
                    random2 = Math.Truncate(random.NextDouble() * 10000) / 10000;
                    variableAleatoria = calculoNormalN2(random1, random2, desviacion, media);
                    
                }
                listadoX[i] = variableAleatoria;
            }

            return listadoX;

        }
    }
}