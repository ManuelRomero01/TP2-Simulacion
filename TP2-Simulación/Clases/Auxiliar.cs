using System.Collections.Generic;
using System.Linq;

namespace TP2_Simulación.Clases
{
    internal class Auxiliar
    {
        //QuickSort para ordenar vector y simplificar el calculo de frecuencia observada
        public static double[] quickSort(double[] vector, int izq, int der)
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
            return vector;
        }
        //Metodo busqueda binaria para calcular frecuencia observada
        public static int busquedaBinaria(double[] vector, double numeroBuscado)
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

            return izq;
        }

        //Metodo para calcular frecuencia Observada, se termino usando el metodo de busqueda binaria
        public static int buscarFrecuenciaObservada(double[] vector, double numeroBuscado)
        {
            int contador = 0;

            for (int i = 0; i < vector.Count(); i++)
            {
                if (vector[i] <= numeroBuscado)
                {
                    contador += 1;
                }
                else
                {
                    break;
                }
            }
            return contador;
        }
        
        //Metodo para calcular factorial para la probabilidad de poisson
        public static double calcularFactorial(double numero)
        {
            if (numero <= 0)
            {
                return 1;
            }
            else
            {   
                return numero * calcularFactorial(numero - 1);
            }
        }
        //Metodo para comprobar que el valor calculado sea menor o igual al tabulado y se rechace o no se rechace la prueba
        public static bool pruebaAceptada(double valorFinal, double valorTabulado)
        {
            if (valorFinal <= valorTabulado)
            {
                return true;
            }
            return false;
        }
        //Metodo para calcular frecuencia observada de Poisson

        //Creacion del Dictionary, tiene una key y un count, parecido a HashTable
        public static Dictionary<int, int> agruparPorValor(double[] listaVariablesPoisson)
        {

            var grupo = listaVariablesPoisson.GroupBy(x => x);
            Dictionary<int, int> valoresAgrupados = new Dictionary<int, int>();

            foreach (var g in grupo)
            {
                valoresAgrupados.Add((int)g.Key, g.Count());
            }

            return valoresAgrupados;
        }             

    }
}