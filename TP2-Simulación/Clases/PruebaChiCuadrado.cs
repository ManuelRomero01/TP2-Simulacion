﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_Simulación.Clases;
namespace TP2_Simulación.Clases
{
    internal class PruebaChiCuadrado
    {
        private double precision = 0.0001;
        private double[][] tabla;

        public (double[], double) probarChiCuadrado(int intervalos, double[] valoresAleatorios, double significancia, double variable1, double variable2, int tipoDistr)
        {
            // Cálculo de los datos iniciales
            double min = valoresAleatorios.Min();
            double max = valoresAleatorios.Max();
            double dif = max - min;
            double anchoIntervalo = Math.Truncate(((dif / intervalos) + precision) * 10000) / 10000;
            int cantidad = valoresAleatorios.Length;

            // Ordeno el vector
            Auxiliar.quickSort(valoresAleatorios, 0, cantidad - 1);

            // Creo las variables que uso en la creacción de la table
            double limInf, limSup, fo, fe, peI, peS, pe, difFrec, c, cAcum;
            limInf = min;
            fo = 0;
            cAcum = 0;

            // Creo la tabla
            tabla = double[intervalos][7];

            // Hace el cálculo por intervalo
            for (int i = 0; i < intervalos; i++)
            {
                // Calculo el límite superior corregido con la presición
                limSup = (limInf + anchoIntervalo) - (precision / 1000);

                // Calculo la frecuencia observada con el índice devuelto por la búsqueda binaria
                fo = Auxiliar.busquedaBinaria(valoresAleatorios, limSup) - fo;

                // Calculo probabilidad esperada del intervalo inferior y superior, según tipo de distribución 
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

                // Calculo probabilidad esperada del intervalo
                pe = peI - peS;

                // Calculo frecuencia esperada y los cálculos de chi
                fe = cantidad * pe;
                difFrec = Math.Pow(fo - fe, 2);
                c = difFrec / fe;
                cAcum += c; 

                // HACER Guardar datos en vector

                // Preparación para la siguiente vuelta
                limInf = limInf + anchoIntervalo; 
            }

            double[] x = { 0.0 }; //borrar
            return (x, 0.0);
        }
    }
}
