using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_Simulación.Clases;

namespace TP2_Simulación
{
    public partial class Prueba : Form
    {
        private double[][] tabla;
        private double tabulado;
        private double calculado;
        private int cantIntervalos;
        private double[] datos;
        private double primeraVariable;
        private double segundaVariable;
        private int tipoDistribucion;

        public Prueba(int cantIntervalos, double[] datos, double primeraVariable, double segundaVariable, int tipoDistr)
        {
            this.cantIntervalos = cantIntervalos;
            this.datos = datos;
            this.primeraVariable = primeraVariable;
            this.segundaVariable = segundaVariable;
            this.tipoDistribucion = tipoDistr;
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
            if (cmbTipoPrueba.SelectedIndex == 1)
            {
                dataTable.Columns.Add("Número de Intervalo", typeof(int));
                dataTable.Columns.Add("Límite Inferior", typeof(double));
                dataTable.Columns.Add("Límite Superior", typeof(double));
                dataTable.Columns.Add("Frecuencia Observada (FO)", typeof(int));
                dataTable.Columns.Add("Frecuencia Esperada (FE)", typeof(double));
                dataTable.Columns.Add("Probabilidad Observada (PO)", typeof(double));
                dataTable.Columns.Add("Probabilidad Esperada (PE)", typeof(double));
                dataTable.Columns.Add("Probabilidad Observada Acumulada (POA)", typeof(double));
                dataTable.Columns.Add("Probabilidad Esperada Acumulada (PEA)", typeof(double));
                dataTable.Columns.Add("Diferencia de |POA - PEA|", typeof(double));
                dataTable.Columns.Add("Máximo", typeof(double));


                for (int i = 0; i < cantIntervalos; i++)
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
            if (cmbTipoPrueba.SelectedIndex == 0)
            {
                if (tipoDistribucion != 3)
                {
                    dataTable.Columns.Add("Número de Intervalo", typeof(int));
                    dataTable.Columns.Add("Límite Inferior", typeof(double));
                    dataTable.Columns.Add("Límite Superior", typeof(double));
                    dataTable.Columns.Add("Frecuencia Observada (FO)", typeof(int));
                    dataTable.Columns.Add("Frecuencia Esperada (FE)", typeof(double));
                    dataTable.Columns.Add("(FO - FE)^2", typeof(double));
                    dataTable.Columns.Add("((FO - FE)^2)/FE", typeof(double));
                    dataTable.Columns.Add("Sumatoria ((FO - FE)^2)/FE", typeof(double));

                    for (int i = 0; i < cantIntervalos; i++)
                    {
                        if (tabla[i] is null)
                        {
                            continue;
                        }
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
                else
                {
                    dataTable.Columns.Add("Valor/Valores", typeof(int));
                    dataTable.Columns.Add("Frecuencia Observada (FO)", typeof(int));
                    dataTable.Columns.Add("Frecuencia Esperada (FE)", typeof(double));
                    dataTable.Columns.Add("(FO - FE)^2", typeof(double));
                    dataTable.Columns.Add("((FO - FE)^2)/FE", typeof(double));
                    dataTable.Columns.Add("Sumatoria ((FO - FE)^2)/FE", typeof(double));

                    //TERMINAR
                    for (int i = 0; i < cantIntervalos; i++)
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
            }

            gdrPrueba.DataSource = dataTable;
            gdrPrueba.Visible = true;
            gdrPrueba.Refresh();
        }
        public void generarPrueba()
        {
            bool poissonKS = false;

            if (cmbTipoPrueba.SelectedIndex == 0)
            {

                // Chi-Cuadrado
                if (tipoDistribucion != 3)
                {
                    (tabla, tabulado, calculado) = PruebaChiCuadrado.probarChiCuadradoContinua(cantIntervalos, datos, Convert.ToDouble(cmbSignificancia.SelectedItem), primeraVariable, segundaVariable, tipoDistribucion);
                    if (tabulado == 0)
                    {
                        MessageBox.Show("No se pudo encontrar el valor tabulado, pruebe con otra combinación de cantidad de datos e intervalos.");
                    }
                }
                else
                {
                    // Comento porque me da error
                    //(tabla, tabulado, calculado) = PruebaChiCuadrado.probarChiCuadradoDiscreta(cantIntervalos, datos, Convert.ToDouble(cmbSignificancia.SelectedValue), primeraVariable, segundaVariable, tipoDistribucion);
                }


            }
            else
            {

                // KS
                if (tipoDistribucion == 3)
                {
                    MessageBox.Show("La prueba K-S no se puede realizar con una distribución de Poisson.");
                    poissonKS = true;
                }
                else
                {
                    (tabla, tabulado, calculado) = PruebaKS.pruebaKS(cantIntervalos, datos, Convert.ToDouble(cmbSignificancia.SelectedValue), primeraVariable, segundaVariable, tipoDistribucion);
                    poissonKS = false;
                }

            }
            if (!poissonKS)
            {
                populatePruebaDataTable(tabla, cantIntervalos);
                txtCalculado.Text = calculado.ToString();
                txtTabulado.Text = tabulado.ToString();
                if (Auxiliar.pruebaAceptada(calculado, tabulado))
                {
                    txtResultado.Text = "Hipótesis No Rechazada";
                    txtResultado.BackColor = Color.LightGreen;
                }
                else
                {
                    txtResultado.Text = "Hipótesis Rechazada";
                    txtResultado.BackColor = Color.LightCoral;
                }
            }

        }
        private void cmbTipoPrueba_SelectedIndexChanged(object sender, EventArgs e)
        {
            generarPrueba();

        }

        private void cmbSignificancia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSignificancia.SelectedIndex != -1)
            {
                cmbTipoPrueba.Enabled = true;

            }
            if (cmbTipoPrueba.SelectedIndex != -1)
            {
                generarPrueba();
            }

        }

        private void cmbTipoPrueba_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmbSignificancia.SelectedIndex == -1)
            {
                MessageBox.Show("Antes de seleccionar el tipo de prueba, seleccione el nivel de significancia.");

            }
        }

        private void Prueba_Load(object sender, EventArgs e)
        {

        }
    }
}