using System;
using System.Collections.Generic;
using System.Linq;

namespace TP2_Simulación.Clases
{
    internal class PruebaChiCuadrado
    {
        public static (double[][], double, double) probarChiCuadradoContinua(int intervalos, double[] valoresAleatorios, double significancia, double variable1, double variable2, int tipoDistr)
        {
            double precision = 0.0001;

            // Cálculo de los datos iniciales
            double min = valoresAleatorios.Min();
            double max = valoresAleatorios.Max();
            double dif = max - min;
            double anchoIntervalo = Math.Truncate(((dif / intervalos) + precision) * 10000) / 10000;
            int cantidad = valoresAleatorios.Length;

            // Ordeno el vector
            valoresAleatorios = Auxiliar.quickSort(valoresAleatorios, 0, cantidad - 1);

            // Creo las variables que uso en la creacción de la tabla
            double fe, peI, peS, pe, difFrec, c, cAcum;
            double limInf = min;
            double limSup = 0;
            int fo;
            
            
            //Creacion de variables para realizar la prueba
            bool ultimaMenor = false;
            int vuelta = 1;
            int foAcumulada = 0;
            cAcum = 0;
            int intervalosDePrueba = 0;

            // Variable de datos empíricos
            int m = 0;

            // Creo la tabla
            double[][] tabla;
            tabla = new double[intervalos][];

            // Hace el cálculo por intervalo
            for (int i = 0; i < intervalos; i++)
            {
                // Calculo el límite superior corregido con la presición
                if (!ultimaMenor)
                {
                    limSup = (limInf + anchoIntervalo * vuelta) - (precision / 1000);
                }

                // Calculo la frecuencia observada con el índice devuelto por una búsqueda binaria
                fo = Auxiliar.busquedaBinaria(valoresAleatorios, limSup) - foAcumulada;

                // Calculo probabilidad esperada del intervalo inferior y superior, según tipo de distribución, tambien se setea m(cant datos empiricos) segun la dsitrbucion
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

                    tabla[intervalosDePrueba] = generarCelda(limInf, limSup, fo, fe, difFrec, c, cAcum);

                    // Preparación para la siguiente vuelta
                    limInf += anchoIntervalo * vuelta;
                    foAcumulada += fo;
                    vuelta = 1;
                    intervalosDePrueba += 1;
                }
                else if (i == intervalos - 1)
                {
                    
                    limInf = tabla[intervalosDePrueba - 1][0];
                    ultimaMenor = true;
                    intervalos += 1;
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

        public static (string[][], double, double) probarChiCuadradoDiscreta(double[] valoresAleatorios, double significancia, double lambda)
        {

            // Cálculo de los datos iniciales
            int cantidad = valoresAleatorios.Length;

            // Ordeno el vector
            valoresAleatorios = Auxiliar.quickSort(valoresAleatorios, 0, cantidad - 1);

            // obtengo los datos de los valores y cantidades
            Dictionary<int, int> diccionarioDeFrecuencias = Auxiliar.agruparPorValor(valoresAleatorios);
            int[] claves = diccionarioDeFrecuencias.Keys.ToArray();
            int[] valores = diccionarioDeFrecuencias.Values.ToArray();

            // Creo las variables que se usan en la creacción de la tabla
            double fe, pe, difFrec, c;
            int fo = 0;
            int valor = 0;
            double cAcum = 0;
            int cantidadValores = diccionarioDeFrecuencias.Count;
            int m = 1;  // para calcular los grados de libertad

            //creacion de variables para realizar la prueba
            int foAcum = 0;
            double feAcum = 0;
            string grupoDeValores = "";
            double feAnterior = 0;
            int foAnterior = 0;
            string grupoAnterior = "";
            bool ultimaMenor = false;
            int contCeldasGuardadas = 0;

            // Creo la tabla
            string[][] tabla;
            tabla = new string[cantidadValores][];
            

            for (int i = 0; i < cantidadValores; i++)
            //Metodo para que si fe < 5 que agrupe con el intervalo adyacente


            {
                if (ultimaMenor)
                {
                    foAcum += foAnterior;
                    feAcum += feAnterior;
                    grupoAnterior += " " + grupoDeValores;
                    grupoDeValores = grupoAnterior;
                }
                else
                {
                    valor = claves[i];
                    fo = valores[i];
                    grupoDeValores += " " + valor;
                    foAcum += fo;

                    pe = CalculoProbabilidad.probabilidadPoisson(valor, lambda);

                    fe = Math.Round(pe * cantidad, 0);
                    feAcum += fe;
                }
                

                if (feAcum > 5)
                {
                    difFrec = Math.Pow((foAcum - feAcum), 2);
                    c = difFrec / feAcum;
                    cAcum += c;

                    //Se truncan los valores a cuatro decimales
                    difFrec = Math.Truncate(difFrec * 10000) / 10000;
                    c = Math.Truncate(c * 10000) / 10000;
                    cAcum = Math.Truncate(cAcum * 10000) / 10000;

                    string[] celda = { grupoDeValores, foAcum.ToString(), feAcum.ToString(), difFrec.ToString(), c.ToString(), cAcum.ToString() };
                    tabla[contCeldasGuardadas] = celda;

                    // Preparo para la siguiente vuelta
                    foAnterior = foAcum;
                    feAnterior = feAcum;
                    grupoAnterior = grupoDeValores;

                    feAcum = 0;
                    foAcum = 0;
                    grupoDeValores = "";
                    contCeldasGuardadas += 1;
                }
                else if (i == cantidadValores - 1)
                {
                    ultimaMenor = true;
                    cantidadValores += 1;
                    contCeldasGuardadas -= 1;
                }
                
            }

            double cCalculado = double.Parse(tabla[contCeldasGuardadas - 1][5]);            
            double chiTab = ValorTabulado.chiTabulado(contCeldasGuardadas, m, significancia);
            return (tabla, chiTab, cCalculado);
        }
       
        private static double[] generarCelda(double limInf, double limSup, int fo, double fe, double difFrec, double c, double cAcum)
        {
           // Guardar datos en la celda del vector
            limInf = Math.Truncate(limInf * 10000) / 10000;
            limSup = Math.Truncate(limSup * 10000) / 10000;
            fe = Math.Truncate(fe * 10000) / 10000;
            difFrec = Math.Truncate(difFrec * 10000) / 10000;
            c = Math.Truncate(c * 10000) / 10000;
            cAcum = Math.Truncate(cAcum * 10000) / 10000;

            double[] celda = { limInf, limSup, fo, fe, difFrec, c, cAcum };
            return celda;
        }
    }
}
