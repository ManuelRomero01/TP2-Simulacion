using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_Simulación.Clases;

namespace TP2_Simulación.Clases
{
    internal class PruebaKS
    {
        private double precision = 0.0001;
        double int[][] tabla = new double[][];




        public (double[], double) pruebaKS(int intervalos, double[] valoresAleatorios, double significancia, double variable1, double variable2, int tipoDistr)
        {
            
            // Cálculo de los datos iniciales
            double min = valoresAleatorios.Min();
            double max = valoresAleatorios.Max();
            double dif = max - min;
            double anchoIntervalo = Math.Truncate(((dif / intervalos) + precision) * 10000) / 10000;
            int cantidad = valoresAleatorios.Length;

            //definicion de la tabla
            tabla = [intervalos][10];


            // Ordeno el vector
            quickSort(valoresAleatorios, 0, cantidad - 1);

            // Creo las variables
            double limInf, limSup, fo, fe, difFrec, po, peI, peS, pe, poAc, peAc, absDifProb, maxProb;
            limInf = min;
            fo = 0;
            poAc = 0;
            peAc = 0;
            maxProb = 0;

            for (int i = 0; i < intervalos; i++)
            {
                limSup = (limInf + anchoIntervalo) - (precision / 1000);
                fo = Auxiliar.busquedaBinaria(valoresAleatorios, limSup) - fo;
                po = fo / cantidad;
                switch (tipoDistr)
                {
                    case 0:
                        peI = CalculoProbabilidad.probabilidadNormal(limInf, media: variable1, desviacion: variable2);
                        peS = CalculoProbabilidad.probabilidadNormal(limSup, media: variable1, desviacion: variable2);
                        break;
                    case 1:
                        peI = CalculoProbabilidad.probabilidadUniforme(limInf, a: variable1, b: variable2);
                        peS = CalculoProbabilidad.probabilidadUniforme(limSup, a: variable1, b: variable2);
                        break;
                    case 2:
                        peI = CalculoProbabilidad.probabilidadExponencial(limInf, lambda: variable1);
                        peS = CalculoProbabilidad.probabilidadExponencial(limSup, lambda: variable1);
                        break;
                    case 3:
                        peI = CalculoProbabilidad.probabilidadPoisson(limInf, lambda: variable1);
                        peS = CalculoProbabilidad.probabilidadPoisson(limSup, lambda: variable1);
                        break;
                }

                pe = peI - peS;
                fe = po * cantidad; 
                poAc = poAc + po;
                peAc = peAc + pe;
                absDifProb = Math.Abs(poAc - peAc);
                maxProb = Math.Max(maxProb, absDifProb);

                x[i] = [limInf, limSup, fo, fe, po, pe, poAc, peAc, absDifProb, maxProb];

                limInf = limInf + anchoIntervalo;

            }

            double[] x = { 0.0 }; //borrar
            return (x, 0.0);
        }
    }
}