﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibGeneradores
{
    public class GeneradorNormal
    {
        // Definición de atributos
        private double media;
        private int cantidad;
        private double desviacion;
        

        // Constructor de la clase
        public GeneradorNormal(double media, double desviacion, int cantidad)
        {
            this.desviacion = desviacion;
            this.media = media;
            this.cantidad = cantidad;
            
        }

        // Generador de números pseudoaleatorios
        private Random random = new Random();
        double random1;
        double random2;


        // Box Muller
        private double calculoNormalN1(double random1, double random2)
        {
            double resultado = ((Math.Sqrt(-2 * Math.Log(random1)) * Math.Cos(2 * Math.PI * random2)) * desviacion) + media;

            return resultado;
        }

        private double calculoNormalN2(double random1, double random2)
        {
            double resultado = ((Math.Sqrt(-2 * Math.Log(random1)) * Math.Sin(2 * Math.PI * random2)) * desviacion) + media;

            return resultado;
        }

        // Generador de variables aleatorias normal
        public (double[], string[]) generarDistribucionNormalBM()
        {
            double[] x = new double[cantidad];
            string[] y = new string[cantidad];
            double variableAleatoria;


            random1 = Math.Truncate(random.NextDouble() * 10000) / 10000;
            //Evita valores infinitos
            while (random1 == 0.00)
            {
                random1 = Math.Truncate(random.NextDouble() * 10000) / 10000;
            }

            random2 = Math.Truncate(random.NextDouble() * 10000) / 10000;

            //Evita valores infinitos
            while (random2 == 0.00)
            {
                random2 = Math.Truncate(random.NextDouble() * 10000) / 10000;
            }

            for (int i = 0; i < cantidad; i++)
            {
                if (i % 2 == 0)
                {
                    variableAleatoria = calculoNormalN1(random1, random2);
                    y[i] = random1.ToString() + " | " + random2.ToString();
                }
                else
                {
                    variableAleatoria = calculoNormalN2(random1, random2);
                    y[i] = random1.ToString() + " | " + random2.ToString();

                    random1 = Math.Truncate(random.NextDouble() * 10000) / 10000;
                    //Evita valores infinitos
                    while (random1 == 0.00)
                    {
                        random1 = Math.Truncate(random.NextDouble() * 10000) / 10000;
                    }

                    random2 = Math.Truncate(random.NextDouble() * 10000) / 10000;

                    //Evita valores infinitos
                    while (random2 == 0.00)
                    {
                        random2 = Math.Truncate(random.NextDouble() * 10000) / 10000;
                    }
                }
                x[i] = Math.Truncate(variableAleatoria * 10000) / 10000;
            }
            return (x, y);
        }
        public (double[], string[]) generarDistribucionNormalCON()
        {
            double[] x = new double[cantidad];
            string[] y = new string[cantidad];
            double acumuladorRND = 0;

            double variableAleatoria;
            for (int j = 0; j < cantidad; j++)
            {
                for (int i = 0; i < 12; i++)
                {
                    random1 = Math.Truncate(random.NextDouble() * 10000) / 10000;
                    
                    
                    
                    y[j] += random1.ToString() + " | ";
                    acumuladorRND += random1;
                    

                }
                
                variableAleatoria = ((acumuladorRND - 6) * desviacion) + media;
                x[j] = Math.Truncate(variableAleatoria * 10000) / 10000;
                acumuladorRND = 0;
            }
            return (x, y);


                

        }
    }
}
