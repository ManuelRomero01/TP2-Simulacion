namespace TP2_Simulación.Clases
{
    internal class Auxiliar
    {
        public static void quickSort(double[] vector, int izq, int der)
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

        public static double calcularFactorial(double numero)
        {
            if (numero == 0)
            {
                return 1;
            }
            else
            {
                return numero * calcularFactorial(numero - 1);
            }
        }
    }
}