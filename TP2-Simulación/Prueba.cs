using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_Simulación
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }


        /*
        PRUEBA KS: K (Cant intervalos) - Limite inf y Limite sup - Frecuencia Observada - Frecuencia Esperada - Probabilidad observada - probabilidad esperada - Probabilidad observada acumulada - probabilidad esperada acumulada - Diferenciad de probabilidades - Máximo
        PRUEBA CHI CUADRADO: K (Cant intervalos) - Limite inf - Limite sup - Frecuencia Observada - Frecuencia Esperada - (Fe-Fo)^2 - ((Fe-Fo)^2 )/fe - Sumatoria   ((Fe-Fo)^2 )/fe
        */
        //limInf, limSup, fo, fe, po, pe, poAc, peAc, absDifProb, maxProb 

        public void populatePruebaDataTable(double[][] tabla, int cantIntervalos)
        {

            DataTable dataTable = new DataTable();

            // PRUEBA KS
            if (cmbTipoPrueba.SelectedIndex == 0)
            {
                dataTable.Columns.Add("Número de Intervalo", typeof(int));
                dataTable.Columns.Add("Límite Inferior", typeof(double));
                dataTable.Columns.Add("Límite Superior", typeof(double));
                dataTable.Columns.Add("Frecuencia Observada (FO)", typeof(double));
                dataTable.Columns.Add("Frecuencia Esperada (FE)", typeof(double));
                dataTable.Columns.Add("Probabilidad Observada (PO)", typeof(double));
                dataTable.Columns.Add("Probabilidad Esperada (PE)", typeof(double));
                dataTable.Columns.Add("Probabilidad Observada Acumulada (POA)", typeof(double));
                dataTable.Columns.Add("Probabilidad Esperada Acumulada (PEA)", typeof(double));
                dataTable.Columns.Add("Diferencia de |POA - PEA|", typeof(double));
                dataTable.Columns.Add("Máximo", typeof(double));


                for (int i = 0; i <= cantIntervalos; i++)
                {
                    DataRow row = dataTable.NewRow();
                    row["Número de Intervalo"] = i + 1;
                    row["Límite Inferior"] = tabla[i][0];
                    row["Límite Superior"] = tabla[i][1];
                    row["Frecuencia Observada (FO)"] = tabla[i][2];
                    row["Frecuencia Esperada (FE)"] = tabla[i][3];
                    row["Probabilidad Observada (PO)"] = tabla[i][4];
                    row["Probabilidad Esperada (PE)"] = tabla[i][5];
                    row["Probabilidad Observada Acumulada (POA)"] = tabla[i][6];
                    row["Probabilidad Esperada Acumulada (PEA)"] = tabla[i][7];
                    row["Diferencia de |POA - PEA|"] = tabla[i][8];
                    row["Máximo"] = tabla[i][9];
                    dataTable.Rows.Add(row);
                }
            }

            // PRUEBA CHI CUADRADO
            if (cmbTipoPrueba.SelectedIndex == 1)
            {
                dataTable.Columns.Add("Número de Intervalo", typeof(int));
                dataTable.Columns.Add("Límite Inferior", typeof(double));
                dataTable.Columns.Add("Límite Superior", typeof(double));
                dataTable.Columns.Add("Frecuencia Observada (FO)", typeof(double));
                dataTable.Columns.Add("Frecuencia Esperada (FE)", typeof(double));
                dataTable.Columns.Add("(FO - FE)^2", typeof(double));
                dataTable.Columns.Add("((FO - FE)^2)/FE", typeof(double));
                dataTable.Columns.Add("Sumatoria ((FO - FE)^2)/FE", typeof(double));             

                for (int i = 0; i <= cantIntervalos; i++)
                {
                    DataRow row = dataTable.NewRow();
                    row["Número de Intervalo"] = i + 1;
                    row["Límite Inferior"] = tabla[i][0];
                    row["Límite Superior"] = tabla[i][1];
                    row["Frecuencia Observada (FO)"] = tabla[i][2];
                    row["Frecuencia Esperada (FE)"] = tabla[i][3];
                    row["(FO - FE)^2"] = tabla[i][4];
                    row["((FO - FE)^2)/FE"] = tabla[i][5];
                    row["Sumatoria ((FO - FE)^2)/FE"] = tabla[i][6];
                    dataTable.Rows.Add(row);
                }
            }

            gdrPrueba.DataSource = dataTable;
            gdrPrueba.Visible = true;
            gdrPrueba.Refresh();
        }

        private void crearTabla(object sender, EventArgs e)
        {
            // TERMINAR,llamar a prueba chi cuadrado o ks segun el index del combo box.
        }
    }
}
