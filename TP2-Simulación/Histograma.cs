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
            // Calculate the bin width
            double min = Math.Truncate(data.Min() * 10000) / 10000;
            double max = Math.Truncate(data.Max() * 10000) / 10000;
            double binWidth = (max - min + 1) / (double)numIntervalos;

            // Create an array to store the bin boundaries
            double[] binBoundaries = new double[numIntervalos + 1];
            for (int i = 0; i <= numIntervalos; i++)
            {
                binBoundaries[i] = min + i * binWidth;
            }

            // Count the number of occurrences of each value in the specified bins
            var counts = from d in data
                         let binIndex = Math.Min((int)((d - min) / binWidth), numIntervalos - 1)
                         group d by binIndex into g
                         orderby g.Key
                         select new { BinLowerBound = Math.Truncate(binBoundaries[g.Key] * 10000) / 10000, BinUpperBound = Math.Truncate(binBoundaries[g.Key + 1] * 10000) / 10000, Count = g.Count() };

            // Add the data to the Chart control
            chtHistograma.Series[0].Points.DataBind(counts, "BinLowerBound", "Count", $"ToolTip=Bin [{0:#,##0.0} - {1:#,##0.0}): {2:#,##0}");
            chtHistograma.Series[0].XValueType = ChartValueType.Double;

            // Set the X-axis properties
            chtHistograma.ChartAreas[0].AxisX.Minimum = min - binWidth / 2.0;
            chtHistograma.ChartAreas[0].AxisX.Maximum = binBoundaries[numIntervalos];
            chtHistograma.ChartAreas[0].AxisX.Interval = binWidth;
            chtHistograma.ChartAreas[0].AxisX.IntervalOffset = 0;
            chtHistograma.ChartAreas[0].AxisX.IntervalOffsetType = DateTimeIntervalType.Number;
        }

    }
}
