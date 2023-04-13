using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Simulación.Clases
{
    internal class PruebaChiCuadrado
    {
        private double precision = 0.0001;

        public (double[], double) probarChiCuadrado(int intervalos, double[] valoresAleatorios, double significancia)
        {
            // Cálculo de los datos iniciales
            double min = valoresAleatorios.Min();
            double max = valoresAleatorios.Max();
            double dif = max - min;
            double anchoIntervalo = Math.Truncate(((dif / intervalos) + precision) * 10000) / 10000;
            int cantidad = valoresAleatorios.Length;

            // Ordeno el vector
            quickSort(valoresAleatorios, 0, cantidad - 1);

            // Creo las variables
            double limInf, limSup, fo, fe, difFrec, c, cAcum;
            limInf = min;

            for (int i = 0; i < intervalos; i++)
            {
                limSup = (limInf + anchoIntervalo) - (precision / 1000);

            }

            double[] x = { 0.0 }; //borrar
            return (x, 0.0);
        }

        private void quickSort(double[] vector, int izq, int der)
        {
            int i = izq;
            int j = der;
            double pivote = vector[(izq + der) / 2];
            double auxiliar;

            while (i <= j)
            {
                while (vector[i] < pivote)
                {
                    i++;
                }

                while (vector[j] > pivote)
                {
                    j--;
                }

                if (i <= j)
                {
                    auxiliar = vector[i];
                    vector[i] = vector[j];
                    vector[j] = auxiliar;
                    i++;
                    j--;
                }
            }

            if (izq < j)
            {
                quickSort(vector, izq, j);
            }

            if (i < der)
            {
                quickSort(vector, i, der);
            }
        }

        private int busquedaBinaria(double[] vector, double numeroBuscado)
        {
            int izq = 0;
            int der = vector.Length - 1;

            while (izq <= der)
            {
                int medio = (izq + der) / 2;

                if (vector[medio] == numeroBuscado)
                {
                    return medio;
                }
                else if (vector[medio] < numeroBuscado)
                {
                    izq = medio + 1;
                }
                else
                {
                    der = medio - 1;
                }
            }

            return -1;
        }
    }
}
