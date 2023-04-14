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
    public partial class Principal : Form
    {

        public bool VariablesDependientes = false;
        public double[] ListaVariablesAleatorias;
        public bool primerMetodoExpNegativo;
        public bool PrimeraVariableEditada = false;
        public bool SegundaVariableEditada = false;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            cmbTipoDistribucion.SelectedIndex = 0;
            lblPrimeraVariable.Text = "Media";
            lblSegundaVariable.Text = "Desviacion estandar:";
        }

        private void ComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            lblPrimeraVariable.Visible = true;
            lblSegundaVariable.Visible = true;
            txtPrimeraVariable.Visible = true;
            txtSegundaVariable.Visible = true;

            VariablesDependientes = false;

            if (cmbTipoDistribucion.SelectedIndex == 0)
            {
                lblPrimeraVariable.Text = "Media";
                lblSegundaVariable.Text = "Desviacion estandar:";
            }
            if (cmbTipoDistribucion.SelectedIndex == 1)
            {
                lblPrimeraVariable.Text = "Variable A:";
                lblSegundaVariable.Text = "Variable B:";
            }
            if (cmbTipoDistribucion.SelectedIndex == 2)
            {
                VariablesDependientes = true;

                lblPrimeraVariable.Text = "Lambda:";
                lblSegundaVariable.Text = "Media:";
            }
            if (cmbTipoDistribucion.SelectedIndex == 3)
            {
                lblSegundaVariable.Visible = false;
                txtSegundaVariable.Visible = false;
                SegundaVariableEditada = true;
                lblPrimeraVariable.Text = "Lambda:";
            }
        }

        private void txtPrimeraVariable_OnClick(object sender, System.EventArgs e)
        {
            primerMetodoExpNegativo = true;
        }

        private void txtSegundaVariable_OnClick(object sender, System.EventArgs e)
        {
            primerMetodoExpNegativo = false;
        }

        private void txtPrimeraVariable_ValueChanged(object sender, System.EventArgs e)
        {
            if (txtPrimeraVariable.Text != "" && verificarTipoDeValor(txtPrimeraVariable.Text))
            {
                PrimeraVariableEditada = true;
            }
            else
            {
                PrimeraVariableEditada = false;
            }

            if (VariablesDependientes && primerMetodoExpNegativo)
            {
                try
                {
                    if (double.Parse(txtPrimeraVariable.Text) == 0)
                    {
                        txtSegundaVariable.Text = "";
                    }
                    else
                    {
                        txtSegundaVariable.Text = (1 / double.Parse(txtPrimeraVariable.Text)).ToString();
                    }
                }
                catch (Exception) 
                {
                    txtSegundaVariable.Text = "";
                }
            }
        }

        private void txtSegundaVariable_ValueChanged(object sender, System.EventArgs e)
        {
            if (txtSegundaVariable.Text != "" && verificarTipoDeValor(txtSegundaVariable.Text))
            {
                SegundaVariableEditada = true;
            }
            else
            {
                SegundaVariableEditada = false;
            }

            if (VariablesDependientes && !primerMetodoExpNegativo)
            {
                try
                {
                    if (double.Parse(txtSegundaVariable.Text) == 0)
                    {
                        txtPrimeraVariable.Text = "";
                    }
                    else
                    {
                        txtPrimeraVariable.Text = (1 / double.Parse(txtSegundaVariable.Text)).ToString();
                    }
                }
                catch (Exception) 
                {
                    txtSegundaVariable.Text = "";
                }
            }
        }

        public bool verificarTipoDeValor(string valor)
        {
            try
            {
                double.Parse(valor);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool ValidarRango()
        {
            if (txtHasta.Text != "" && txtDesde.Text != "")
            {
                if (int.Parse(txtHasta.Text) > int.Parse(txtDesde.Text))
                {
                    if (int.Parse(txtHasta.Text) < int.Parse(txtCantValores.Text))
                    {
                        if (int.Parse(txtDesde.Text) > 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtCantValores.Text != "")
            {
                if (int.Parse(txtCantValores.Text) > 5000 && int.Parse(txtCantValores.Text) < 0)
                {
                    MessageBox.Show("Ingrese un valor valido.");
                }
                else
                {
                    if (ValidarRango())
                    {
                        if (PrimeraVariableEditada && SegundaVariableEditada)
                        {
                            if (cmbTipoDistribucion.SelectedIndex == 0)
                            {
                                GeneradorNormal generador = new GeneradorNormal();

                                ListaVariablesAleatorias = generador.generarDistribucionNormal(
                                    double.Parse(txtPrimeraVariable.Text),
                                    double.Parse(txtSegundaVariable.Text),
                                    int.Parse(txtCantValores.Text));
                            }
                            if (cmbTipoDistribucion.SelectedIndex == 1)
                            {
                                GeneradorUniforme generador = new GeneradorUniforme(
                                    double.Parse(txtPrimeraVariable.Text),
                                    double.Parse(txtSegundaVariable.Text),
                                    int.Parse(txtCantValores.Text));

                                ListaVariablesAleatorias = generador.generarRandomUniforme();
                            }
                            if (cmbTipoDistribucion.SelectedIndex == 2)
                            {
                                GeneradorExpoNegativo generador = new GeneradorExpoNegativo(
                                    double.Parse(txtPrimeraVariable.Text),
                                    double.Parse(txtSegundaVariable.Text),
                                    int.Parse(txtCantValores.Text));

                                if (primerMetodoExpNegativo)
                                {
                                    ListaVariablesAleatorias = generador.generarVariablesAleatoriasLambda();
                                }
                                else
                                {
                                    ListaVariablesAleatorias = generador.generarVariablesAleatoriasMedia();
                                }
                            }
                            if (cmbTipoDistribucion.SelectedIndex == 3)
                            {
                                GeneradorPoisson generador = new GeneradorPoisson(
                                    double.Parse(txtPrimeraVariable.Text),
                                    int.Parse(txtCantValores.Text));

                                ListaVariablesAleatorias = generador.generarVariablesAleatorias();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Complete las variables antes de continuar.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El rango ingresado es invalido");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar el campo de la cantidad de variables a generar.");
            }
        }
    }
}
