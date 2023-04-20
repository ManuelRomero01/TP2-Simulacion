using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP2_Simulación
{
    public partial class Histograma : Form
    {
        double[] data;
        int numIntervalos;

        public Histograma(double[] datos, int numIntervalos)
        {
            this.data = datos;
            this.numIntervalos = numIntervalos;
            InitializeComponent();
        }

        private void Histograma_Load(object sender, EventArgs e)
        {
            populate_graph();
        }

        private void populate_graph()
        {
            // Create a new series for the histogram
            var series = new Series("Observaciones");
            chtHistograma.Series[0].IsVisibleInLegend = false;
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.Double;

            // Add some sample data to the series
            double min = Math.Truncate(data.Min() * 10000) / 10000;
            double max = Math.Truncate(data.Max() * 10000) / 10000;
            double intervalWidth = (max - min) / numIntervalos;

            // Calculate the frequency of each interval
            int[] freqs = new int[numIntervalos];
            foreach (double d in data)
            {
                int index = (int)((d - data.Min()) / intervalWidth);
                if (index >= numIntervalos)
                {
                    index = numIntervalos - 1;
                }
                freqs[index]++;
                
            }

            // Add the interval boundaries and frequencies to the series
            for (int i = 0; i < numIntervalos; i++)
            {
                double xValue = data.Min() + i * intervalWidth;
                series.Points.AddXY(xValue, freqs[i]);
                series.Points[i].Label = freqs[i].ToString();
            }

            // Add the series to the chart and adjust the X-axis interval
            chtHistograma.Series.Add(series);
            chtHistograma.ChartAreas[0].AxisX.Interval = intervalWidth;


            chtHistograma.Series[0].XValueType = ChartValueType.Double;

            // Set the X-axis properties
            chtHistograma.ChartAreas[0].AxisX.Title = "Límites Inferiores";
            chtHistograma.ChartAreas[0].AxisY.Title = "Cantidad Observada";
            chtHistograma.ChartAreas[0].AxisX.Minimum = min;
            chtHistograma.ChartAreas[0].AxisX.Maximum = max;
            chtHistograma.ChartAreas[0].AxisX.IntervalOffset = 0;
            chtHistograma.ChartAreas[0].AxisX.LabelStyle.Format = "0.0000";
            chtHistograma.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
        }
    }
}
