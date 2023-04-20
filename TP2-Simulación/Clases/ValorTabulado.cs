using MathNet.Numerics.Distributions;
using System;

namespace TP2_Simulación.Clases
{
    internal class ValorTabulado
    {
        public static double ksTabulado(int intervalos, double significancia)
        {
            int n = intervalos;
            double nivelDeSignificancia = significancia;

            // Tabla KS
            double[][] tabla = new double[][]
            {
                //              0.10    0.05      0.01
                new double[] {0.95000, 0.97500, 0.99500}, //1
                new double[] {0.77639, 0.84189, 0.92929}, //2
                new double[] {0.63604, 0.70760, 0.82900}, //3
                new double[] {0.56522, 0.62394, 0.73424}, //4
                new double[] {0.50945, 0.56328, 0.66853}, //5
                new double[] {0.46799, 0.51926, 0.61661}, //6
                new double[] {0.43607, 0.48342, 0.57581}, //7
                new double[] {0.40962, 0.45427, 0.54179}, //8
                new double[] {0.38746, 0.43001, 0.51332}, //9
                new double[] {0.36866, 0.40925, 0.48893}, //10
                new double[] {0.35242, 0.39122, 0.46770}, //11
                new double[] {0.33815, 0.37543, 0.44905}, //12
                new double[] {0.32549, 0.36143, 0.43247}, //13
                new double[] {0.31417, 0.34890, 0.41762}, //14
                new double[] {0.30397, 0.33750, 0.40420}, //15
                new double[] {0.29472, 0.32733, 0.39201}, //16
                new double[] {0.28627, 0.31796, 0.38086}, //17
                new double[] {0.27851, 0.30936, 0.37062}, //18
                new double[] {0.27136, 0.30143, 0.36117}, //19
                new double[] {0.26473, 0.29408, 0.35241}, //20
                new double[] {0.25858, 0.28724, 0.34426}, //21
                new double[] {0.25283, 0.28087, 0.33666}, //22
                new double[] {0.24746, 0.27491, 0.32954}, //23
                new double[] {0.24242, 0.26931, 0.32286}, //24
                new double[] {0.23768, 0.26404, 0.31657}, //25
                new double[] {0.23320, 0.25908, 0.30963}, //26
                new double[] {0.22898, 0.25438, 0.30502}, //27
                new double[] {0.22497, 0.24993, 0.29971}, //28
                new double[] {0.22117, 0.24571, 0.29466}, //29
                new double[] {0.21756, 0.24170, 0.28986}, //30
                new double[] {0.21412, 0.23788, 0.28529}, //31
                new double[] {0.21085, 0.23424, 0.28094}, //32
                new double[] {0.20771, 0.23076, 0.27577}, //33
                new double[] {0.21472, 0.22743, 0.27271}, //34
                new double[] {0.20185, 0.22425, 0.26897}, //35
            };

            double valorCritico = 0.0;
            
            if (n < 35)
                
            {
                switch (significancia)
                {
                    case 0.10:
                        valorCritico = tabla[n-1][0];
                        break;
                    case 0.05:
                        valorCritico = tabla[n-1][1];
                        break;
                    case 0.01:
                        valorCritico = tabla[n-1][2];
                        break;
                }
            }
            else
            {
                switch (significancia)
                {
                    case 0.1:
                        valorCritico = 1.22 / Math.Sqrt(n);
                        break;
                    case 0.05:
                        valorCritico = 1.36 / Math.Sqrt(n);
                        break;
                    case 0.01:
                        valorCritico = 1.63 / Math.Sqrt(n);
                        break;
                }
            }
            return Math.Truncate(valorCritico * 10000) / 10000; ;
        }

        public static double chiTabulado(int k, int m, double significancia)
        {
            double gradosDeLibertad = k - 1 - m;

            if (gradosDeLibertad <= 0)
            {
                return 0;
            }

            double result = ChiSquared.InvCDF(gradosDeLibertad, 1 - significancia);
            
            return Math.Truncate(result * 10000) / 10000;
        }

    }
}












