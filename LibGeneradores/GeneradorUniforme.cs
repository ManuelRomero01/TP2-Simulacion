using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibGeneradores
{
    public class GeneradorUniforme
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
        public (double[], string[]) generarRandomUniforme()
        {
            double rnd;
            double[] x = new double[cantidad];
            string[] y = new string[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                rnd = Math.Truncate(random.NextDouble() * 10000) / 10000;

                x[i] = Math.Truncate((rnd * (hasta - desde) + desde) * 10000) / 10000;
                y[i] = rnd.ToString();
            }

            return (x, y);
        }
    }
}
