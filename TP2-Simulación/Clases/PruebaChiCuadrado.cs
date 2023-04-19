using MathNet.Numerics;
using System;
using System.Linq;

namespace TP2_Simulación.Clases
{
    internal class PruebaChiCuadrado
    {

        public static (double[][], double, double) probarChiCuadradoContinua(int intervalos, double[] valoresAleatorios, double significancia, double variable1, double variable2, int tipoDistr)
        {
            double precision = 0.0001;
            double[][] tabla;

            // Cálculo de los datos iniciales
            double min = valoresAleatorios.Min();
            double max = valoresAleatorios.Max();
            double dif = max - min;
            double anchoIntervalo = Math.Truncate(((dif / intervalos) + precision) * 10000) / 10000;
            int cantidad = valoresAleatorios.Length;

            // Ordeno el vector
            valoresAleatorios = Auxiliar.quickSort(valoresAleatorios, 0, cantidad - 1);

            // Creo las variables que uso en la creacción de la table
            double limInf, limSup, fe, peI, peS, pe, difFrec, c, cAcum;
            limInf = min;
            int fo;
            int intervalosDePrueba = 0;
            int vuelta = 1;
            int foAcumulada = 0;
            cAcum = 0;

            // Variable de datos empíricos
            int m = 0;

            // Creo la tabla
            tabla = new double[intervalos][];

            // Hace el cálculo por intervalo
            for (int i = 0; i < intervalos; i++)
            {
                // Calculo el límite superior corregido con la presición
                limSup = (limInf + anchoIntervalo * vuelta) - (precision / 1000);

                // Calculo la frecuencia observada con el índice devuelto por una búsqueda binaria
                fo = Auxiliar.busquedaBinaria(valoresAleatorios, limSup) - foAcumulada;

                // Calculo probabilidad esperada del intervalo inferior y superior, según tipo de distribución 
                switch (tipoDistr)
                {
                    case 0:
                        pe = CalculoProbabilidad.probabilidadNormal(media: variable1, desviacion: variable2, limSup: limSup, limInf: limInf);
                        m = 2;
                        break;

                    case 1:
                        peI = CalculoProbabilidad.probabilidadUniforme(limInf, a: variable1, b: variable2);
                        peS = CalculoProbabilidad.probabilidadUniforme(limSup, a: variable1, b: variable2);

                        // Calculo probabilidad esperada del intervalo
                        pe = peS - peI;
                        m = 0;
                        break;

                    case 2:
                        peI = CalculoProbabilidad.probabilidadExponencial(limInf, lambda: variable1);
                        peS = CalculoProbabilidad.probabilidadExponencial(limSup, lambda: variable1);

                        // Calculo probabilidad esperada del intervalo
                        pe = peS - peI;
                        m = 1;
                        break;

                    case 3:
                        peI = CalculoProbabilidad.probabilidadPoisson(limInf, lambda: variable1);
                        peS = CalculoProbabilidad.probabilidadPoisson(limSup, lambda: variable1);

                        // Calculo probabilidad esperada del intervalo
                        pe = peS - peI;
                        m = 1;
                        break;

                    default:
                        pe = 0;
                        break;
                }

                // Calculo frecuencia esperada y los cálculos de chi
                fe = cantidad * pe;
                if (fe > 5.00)
                {
                    difFrec = Math.Pow((fo - fe), 2);
                    c = difFrec / fe;
                    cAcum += c;

                    // Guardar datos en la celda del vector
                    limInf = Math.Truncate(limInf * 10000) / 10000;
                    limSup = Math.Truncate(limSup * 10000) / 10000;
                    fe = Math.Truncate(fe * 10000) / 10000;
                    difFrec = Math.Truncate(difFrec * 10000) / 10000;
                    c = Math.Truncate(c * 10000) / 10000;
                    cAcum = Math.Truncate(cAcum * 10000) / 10000;

                    double[] celda = { limInf, limSup, fo, fe, difFrec, c, cAcum };
                    tabla[intervalosDePrueba] = celda;

                    // Preparación para la siguiente vuelta
                    limInf += anchoIntervalo * vuelta;
                    foAcumulada += fo;
                    vuelta = 1;
                    intervalosDePrueba += 1;
                }
                else
                {
                    vuelta += 1;
                }
            }

            double cCalculado = tabla[intervalosDePrueba - 1][6];
            double chiTab = ValorTabulado.chiTabulado(intervalosDePrueba, m, significancia);

            return (tabla, chiTab, cCalculado);
        }


        // Tiene que devolver (double[][], double, double)
        public static int probarChiCuadradoDiscreta(int intervalos, double[] valoresAleatorios, double significancia, double variable1, double variable2, int tipoDistr)
        {
            double[][] tabla;

            // Cálculo de los datos iniciales

            int cantidad = valoresAleatorios.Length;

            // Ordeno el vector
            Auxiliar.quickSort(valoresAleatorios, 0, cantidad - 1);

            // Creo las variables que uso en la creacción de la table
            int valor, fo, fe;
            double pe, difFrec, c, cAcum;

            return 0;
        }
       
    }
}
