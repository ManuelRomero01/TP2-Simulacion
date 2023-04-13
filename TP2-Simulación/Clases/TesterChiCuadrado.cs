using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Simulación.Clases
{
    internal class TesterChiCuadrado
    {
        private double precision = 0.0001

        public (double[], double) probarChiCuadrado(int intervalos, double[] valoresAleatorios, int cantidad, double significancia)
        {
            min = valoresAleatorios.Min();
            max = valoresAleatorios.Max();
            dif = max - min;
            anchoIntervalo = Math.Truncate(((dif / intervalos) + precision) * 10000) / 10000;

            for (int i = 0; i < intervalos; i ++)
            {
               
            }
        }

       
    }
}
