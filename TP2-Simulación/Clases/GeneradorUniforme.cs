using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Simulación.Clases
{
    internal class GeneradorUniforme
    {
        // Definición de atributos
        private double desde;
        private double hasta; 
        private int cantidad; 

        // Generador de números pseudoaleatorios
        private Random random = new Random();

        // Constructor de la clase
        public GeneradorUniforme(double desde, double hasta, int cant)
        {
            this.desde = desde;
            this.hasta = hasta;
            this.cantidad = cant;
        }

        // Generador de variables aleatorias uniformes
        public (double[], double[]) generarRandomUniforme()
        {
            double rnd;
            double[] x = new double[cantidad];
            double[] y = new double[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                rnd = Math.Truncate(random.NextDouble() * 10000) / 10000;
                x[i] = Math.Truncate((rnd * (hasta - desde) + desde) * 10000) / 10000;
                y[i] = rnd;
            }

            return (x, y);
        }
    }
}
