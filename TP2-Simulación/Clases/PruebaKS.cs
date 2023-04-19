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
        

        public static(double[][], double, double) pruebaKS(int intervalos, double[] valoresAleatorios, double significancia, double variable1, double variable2, int tipoDistr)
        {
            double precision = 0.0001;
            double[][] tabla;

            // Cálculo de los datos iniciales
            double min = valoresAleatorios.Min();
            double max = valoresAleatorios.Max();
            double dif = max - min;
            double anchoIntervalo = Math.Truncate(((dif / intervalos) + precision) * 10000) / 10000;
            int cantidad = valoresAleatorios.Length;

            //definicion de la tabla
            tabla = new double [intervalos][];

            // Ordeno el vector
            Auxiliar.quickSort(valoresAleatorios, 0, cantidad - 1);

            // Creo las variables
            double limInf, limSup, fe, po, peI, peS, pe, poAc, peAc, absDifProb, maxProb;
            limInf = min;
            
            int fo = 0;
            poAc = 0;
            peAc = 0;
            maxProb = 0;

            for (int i = 0; i < intervalos; i++)
            {
                //calculo del limite superior corregido con la precision
                limSup = (limInf + anchoIntervalo) - (precision / 1000);
                // Calculo la frecuencia observada con el índice devuelto por la búsqueda binaria
                fo = Auxiliar.buscarFrecuenciaObservada(valoresAleatorios, limSup) - fo;
                //fo = Auxiliar.busquedaBinaria(valoresAleatorios, limSup) - fo;
                
               // calculo de la probabilidad observada
                po = fo / cantidad;

                //Calculo probabilidad esperada del intervalo inferior y superior, según tipo de distribución
                switch (tipoDistr)
                {
                    case 0:
                        pe = CalculoProbabilidad.probabilidadNormal(media: variable1, desviacion: variable2, limSup: limSup, limInf: limInf);
                        break;

                    case 1:
                        peI = CalculoProbabilidad.probabilidadUniforme(limInf, a: variable1, b: variable2);
                        peS = CalculoProbabilidad.probabilidadUniforme(limSup, a: variable1, b: variable2);
                        
                        //calculo de la probabilidad esperada
                        pe = peS - peI;
                        break;

                    case 2:
                        peI = CalculoProbabilidad.probabilidadExponencial(limInf, lambda: variable1);
                        peS = CalculoProbabilidad.probabilidadExponencial(limSup, lambda: variable1);

                        //calculo de la probabilidad esperada
                        pe = peS - peI;
                        break;

                    default:
                        pe = 0;
                        break;
                }

                //calculo de la frecuencia esperada
                fe = cantidad * pe;


                poAc = poAc + po;
                peAc = peAc + pe;
                absDifProb = Math.Abs(poAc - peAc);
                maxProb = Math.Max(maxProb, absDifProb);

                // Trunco datos para que solo tengan 4 decimales
                limInf = Math.Truncate(limInf * 10000) / 10000;
                limSup = Math.Truncate(limSup * 10000) / 10000;
                fe = Math.Truncate(fe * 10000) / 10000;
                po = Math.Truncate(po * 10000) / 10000;
                pe = Math.Truncate(pe * 10000) / 10000;
                poAc = Math.Truncate(poAc * 10000) / 10000;
                peAc = Math.Truncate(peAc * 10000) / 10000;
                absDifProb = Math.Truncate(absDifProb * 10000) / 10000;
                maxProb = Math.Truncate(maxProb * 10000) / 10000;

                // Guardar datos en la celda del vector
                double[] celda = { limInf, limSup, fo, fe, po, pe, poAc, peAc, absDifProb, maxProb };
                tabla[i] = celda;
                
                // calculo del siguiente limite inferior sin tomar la precision
                limInf = limInf + anchoIntervalo;

            }

            double maxCalculado = tabla[intervalos - 1][9];
            double ksTabulado = ValorTabulado.ksTabulado(intervalos,significancia);

            return (tabla, ksTabulado, maxCalculado);
        }

        
    }
}