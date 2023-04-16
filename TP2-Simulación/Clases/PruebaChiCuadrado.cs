using System;
using System.Linq;

namespace TP2_Simulación.Clases
{
    internal class PruebaChiCuadrado
    {
        private double precision = 0.0001;
        private double[][] tabla;

        public (double[][], double) probarChiCuadrado(int intervalos, double[] valoresAleatorios, double significancia, double variable1, double variable2, int tipoDistr)
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

            // Variable de datos empíricos
            int m = 0;

            // Creo la tabla
            tabla = new double [intervalos][];

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
                        m = 2;
                        break;
                    case 1:
                        peI = CalculoProbabilidad.probabilidadUniforme(limInf, a: variable1, b: variable2);
                        peS = CalculoProbabilidad.probabilidadUniforme(limSup, a: variable1, b: variable2);
                        m = 0;
                        break;
                    case 2:
                        peI = CalculoProbabilidad.probabilidadExponencial(limInf, lambda: variable1);
                        peS = CalculoProbabilidad.probabilidadExponencial(limSup, lambda: variable1);
                        m = 1;
                        break;
                    case 3:
                        peI = CalculoProbabilidad.probabilidadPoisson(limInf, lambda: variable1);
                        peS = CalculoProbabilidad.probabilidadPoisson(limSup, lambda: variable1);
                        m = 1;
                        break;
                    default:
                        peI = 0;
                        peS = 0;
                        break;
                }

                // Calculo probabilidad esperada del intervalo
                pe = peI - peS;

                // Calculo frecuencia esperada y los cálculos de chi
                fe = cantidad * pe;
                difFrec = Math.Pow(fo - fe, 2);
                c = difFrec / fe;
                cAcum += c;

                // Guardar datos en la celda del vector
                double[] celda = { limInf, limSup, fo, fe, difFrec, c, cAcum }; 
                tabla[i] = celda;

                // Preparación para la siguiente vuelta
                limInf = limInf + anchoIntervalo; 
            }

            double chiTab = chiTabulado(intervalos, m, significancia);
            
            return (tabla, chiTab);
        }
        
        public double chiTabulado(int k, int m, double significancia)
        {
            // Con intervalos definidos, calculo todas las posibilidades
            // En todos los casos, el "else" es significancia de 0,025
            double tabulado = 0;

            switch (k - 1 - m)
            {
                case 2:
                    if (significancia == 0.05)
                    {
                        tabulado = 6;
                    }
                    else
                    {
                        tabulado = 7.4;
                    }
                    break;

                case 4:
                    if (significancia == 0.05)
                    {
                        tabulado = 9.5;
                    }
                    else
                    {
                        tabulado = 11.1;
                    }
                    break;

                case 5:
                    if (significancia == 0.05)
                    {
                        tabulado = 11.1;
                    }
                    else
                    {
                        tabulado = 12.8;
                    }
                    break;

                case 7:
                    if (significancia == 0.05)
                    {
                        tabulado = 14.1;
                    }
                    else
                    {
                        tabulado = 16.0;
                    }
                    break;

                case 8:
                    if (significancia == 0.05)
                    {
                        tabulado = 15.5;
                    }
                    else
                    {
                        tabulado = 17.5;
                    }
                    break;

                case 9:
                    if (significancia == 0.05)
                    {
                        tabulado = 16.9;
                    }
                    else
                    {
                        tabulado = 19.0;
                    }
                    break;

                case 10:
                    if (significancia == 0.05)
                    {
                        tabulado = 18.3;
                    }
                    else
                    {
                        tabulado = 20.5;
                    }
                    break;

                case 11:
                    if (significancia == 0.05)
                    {
                        tabulado = 19.7;
                    }
                    else
                    {
                        tabulado = 21.9;
                    }
                    break;

                case 12:
                    if (significancia == 0.05)
                    {
                        tabulado = 21;
                    }
                    else
                    {
                        tabulado = 23.3;
                    }
                    break;

                case 14:
                    if (significancia == 0.05)
                    {
                        tabulado = 23.7;
                    }
                    else
                    {
                        tabulado = 26.1;
                    }
                    break;

                case 15:
                    if (significancia == 0.05)
                    {
                        tabulado = 25.0;
                    }
                    else
                    {
                        tabulado = 27.5;
                    }
                    break;
            }

            return tabulado;
        }
    }
}
