using System;
using System.Linq;


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
            valoresAleatorios = Auxiliar.quickSort(valoresAleatorios, 0, cantidad - 1);

            // Creo las variables
            double limInf, limSup, fe, po, peI, peS, pe, poAc, peAc, absDifProb, maxProb;
            limInf = min;
            
            int fo = 0;
            int foAcumulada = 0;
            poAc = 0;
            peAc = 0;
            maxProb = 0;

            for (int i = 0; i < intervalos; i++)
            {
                //Calculo del limite superior corregido con la precision
                limSup = (limInf + anchoIntervalo) - (precision / 1000);
                
                // Calculo la frecuencia observada con el índice devuelto por la búsqueda binaria
                fo = Auxiliar.busquedaBinaria(valoresAleatorios, limSup) - foAcumulada;
                
                // calculo de la probabilidad observada
                po = (double) fo / (double)cantidad;

                //Calculo probabilidad esperada del intervalo inferior y superior, según tipo de distribución
                switch (tipoDistr)
                {
                    case 0:
                        pe = CalculoProbabilidad.probabilidadNormal(media: variable1, desviacion: variable2, limSup: limSup, limInf: limInf);
                        break;

                    case 1:
                        peI = CalculoProbabilidad.probabilidadUniforme(limInf, a: variable1, b: variable2);
                        peS = CalculoProbabilidad.probabilidadUniforme(limSup, a: variable1, b: variable2);
                        
                        //Calculo de la probabilidad esperada
                        pe = peS - peI;
                        break;

                    case 2:
                        peI = CalculoProbabilidad.probabilidadExponencial(limInf, lambda: variable1);
                        peS = CalculoProbabilidad.probabilidadExponencial(limSup, lambda: variable1);

                        //Calculo de la probabilidad esperada
                        pe = peS - peI;
                        break;

                    default:
                        pe = 0;
                        break;
                }

                //Calculo de la frecuencia esperada
                fe = cantidad * pe;

                poAc += po;
                peAc += pe;
                absDifProb = Math.Abs(poAc - peAc);
                maxProb = Math.Max(maxProb, absDifProb);

                // Guardar datos en la celda del vector
                tabla[i] = generarCelda(limInf, limSup, fo, fe, po, pe, poAc, peAc, absDifProb, maxProb);
                
                // Prepararse para la segunda vuelta
                limInf = limInf + anchoIntervalo;
                foAcumulada += fo;
            }

            double maxCalculado = tabla[intervalos - 1][9];
            double ksTabulado = ValorTabulado.ksTabulado(intervalos, significancia);

            return (tabla, ksTabulado, maxCalculado);
        }

        private static double[] generarCelda(double limInf, double limSup, int fo, double fe, double po, double pe, double poAc, double peAc, double absDifProb, double maxProb)
        {
            // Guardar datos en la celda del vector
            limInf = Math.Truncate(limInf * 10000) / 10000;
            limSup = Math.Truncate(limSup * 10000) / 10000;
            fe = Math.Truncate(fe * 10000) / 10000;
            po = Math.Truncate(po * 10000) / 10000;
            pe = Math.Truncate(pe * 10000) / 10000;
            poAc = Math.Truncate(poAc * 10000) / 10000;
            peAc = Math.Truncate(peAc * 10000) / 10000;
            absDifProb = Math.Truncate(absDifProb * 10000) / 10000;
            maxProb = Math.Truncate(maxProb * 10000) / 10000;

            double[] celda = { limInf, limSup, fo, fe, po, pe, poAc, peAc, absDifProb, maxProb };
            return celda;
        }


    }
}