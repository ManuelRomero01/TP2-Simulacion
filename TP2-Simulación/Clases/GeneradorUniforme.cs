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
        // Atributos de la clase
        private double a; // desde
        private double b; // hasta
        private int cantidad; // a generar

        // Generador de números pseudoaleatorios
        private Random random = new Random();

        // Constructor de la clase
        public GeneradorUniforme(double a, double b, int cant)
        {
            this.a = a;
            this.b = b;
            this.cantidad = cant;
        }

        // Generador de variables aleatorias uniformes
        public double[] generarRandomUniforme()
        {
            double rnd;
            double[] x = new double[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                rnd = Math.Truncate(random.NextDouble() * 10000) / 10000;
                x[i] = Math.Truncate((rnd * (b - a) + a) * 10000) / 10000; 
            }

            return x;
        }
    }
}
