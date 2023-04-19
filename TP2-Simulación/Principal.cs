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
        public string[] ListaRandom;
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

        private void limpiarInterfaz()
        {
            txtCantValores.Text = "";
            txtPrimeraVariable.Text = "";
            txtSegundaVariable.Text = "";
            txtDesde.Text = "";
            txtHasta.Text = "";
            btnVisualizar.Visible = false;
            dataGridRND.Visible = false;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            limpiarInterfaz();
            lblPrimeraVariable.Visible = true;
            lblSegundaVariable.Visible = true;
            txtPrimeraVariable.Visible = true;
            txtSegundaVariable.Visible = true;

            VariablesDependientes = false;

            // Segun la Selección de Tipo De Distribución
            // Distribución Normal
            if (cmbTipoDistribucion.SelectedIndex == 0)
            {
                lblPrimeraVariable.Text = "Media: ";
                lblSegundaVariable.Text = "Desviacion estandar: ";
            }
            // Distribución Uniforme
            if (cmbTipoDistribucion.SelectedIndex == 1)
            {
                lblPrimeraVariable.Text = "Variable A: ";
                lblSegundaVariable.Text = "Variable B: ";
            }
            // Distribución Exponencial Negativa
            if (cmbTipoDistribucion.SelectedIndex == 2)
            {
                VariablesDependientes = true;

                lblPrimeraVariable.Text = "Lambda: ";
                lblSegundaVariable.Text = "Media: ";
            }
            // Distribución Poisson
            if (cmbTipoDistribucion.SelectedIndex == 3)
            {
                lblSegundaVariable.Visible = false;
                txtSegundaVariable.Visible = false;
                lblPrimeraVariable.Text = "Lambda / Media: ";
                SegundaVariableEditada = true;
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
                    if (int.Parse(txtHasta.Text) <= int.Parse(txtCantValores.Text))
                    {
                        if (int.Parse(txtDesde.Text) > 0)
                        {
                            if((int.Parse(txtHasta.Text) - int.Parse(txtDesde.Text)) <=  5000)
                            {
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("La cantidad de intervalos a visualizar es mayor a 5000. Por favor reduzca el valor del hasta o aumente el del desde");
                            }
                        }
                        else
                        {
                            MessageBox.Show("La cantidad desde debe ser un valor positivo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La cantidad hasta debe ser menor a la cantidad de valores a generar");
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad hasta debe ser mayor a la cantidad desde");
                }
            }
            else
            {
                MessageBox.Show("Los valores desde y hasta se encuentran vacios");
            }
            return false;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //Visualizacion de botones y label
            btnPrueba.Visible = true;
            lblCantIntervalos.Visible = true;
            cmbIntervalos.Visible = true;
            btnVisualizar.Visible = true;
            btnHistograma.Visible = true;

            //Verifica que los valores estén cargados
            if (txtCantValores.Text != "")
            {
                if (int.Parse(txtCantValores.Text) > 50000 || int.Parse(txtCantValores.Text) < 0)
                {
                    MessageBox.Show("Ingrese un valor valido en la cantidad de valores.");
                }
                else
                {
                    if (ValidarRango())
                    {
                        if (PrimeraVariableEditada && SegundaVariableEditada)
                        {
                            if (cmbTipoDistribucion.SelectedIndex == 0)
                            {
                                
                                GeneradorNormal generador = new GeneradorNormal(
                                    double.Parse(txtPrimeraVariable.Text),
                                    double.Parse(txtSegundaVariable.Text),
                                    int.Parse(txtCantValores.Text));

                                (ListaVariablesAleatorias, ListaRandom) = generador.generarDistribucionNormal();
                                    
                            }
                            if (cmbTipoDistribucion.SelectedIndex == 1)
                            {
                                GeneradorUniforme generador = new GeneradorUniforme(
                                    double.Parse(txtPrimeraVariable.Text),
                                    double.Parse(txtSegundaVariable.Text),
                                    int.Parse(txtCantValores.Text));

                                (ListaVariablesAleatorias, ListaRandom) = generador.generarRandomUniforme();
                            }
                            if (cmbTipoDistribucion.SelectedIndex == 2)
                            {
                                GeneradorExpoNegativo generador = new GeneradorExpoNegativo(
                                    double.Parse(txtPrimeraVariable.Text),
                                    double.Parse(txtSegundaVariable.Text),
                                    int.Parse(txtCantValores.Text));

                                if (primerMetodoExpNegativo)
                                {
                                    (ListaVariablesAleatorias, ListaRandom) = generador.generarVariablesAleatoriasLambda();
                                }
                                else
                                {
                                    (ListaVariablesAleatorias, ListaRandom) = generador.generarVariablesAleatoriasMedia();
                                }
                            }
                            if (cmbTipoDistribucion.SelectedIndex == 3)
                            {
                                GeneradorPoisson generador = new GeneradorPoisson(
                                    double.Parse(txtPrimeraVariable.Text),
                                    int.Parse(txtCantValores.Text));

                                (ListaVariablesAleatorias, ListaRandom) = generador.generarVariablesAleatorias();
                                
                            }

                            populateDataTable(ListaRandom, ListaVariablesAleatorias, int.Parse(txtDesde.Text), int.Parse(txtHasta.Text));
                            

                        }
                        else
                        {
                            MessageBox.Show("Complete las variables antes de continuar.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar el campo de la cantidad de variables a generar.");
            }
        }

        //Generar la labla con numeros y variables aleatorias
        public void populateDataTable(string[] randoms, double[] aleatoria, int desde, int hasta)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Index", typeof(int));
            dataTable.Columns.Add("Randoms", typeof(string));
            dataTable.Columns.Add("Aleatorios", typeof(double));
            
            for (int i = desde-1; i <= hasta-1; i++)
            {
                DataRow row = dataTable.NewRow();
                row["Index"] = i+1;
                row["Randoms"] = randoms[i];
                row["Aleatorios"] = aleatoria[i];
                dataTable.Rows.Add(row);
            }

            dataGridRND.DataSource = dataTable;
            dataGridRND.Visible = true;

            dataGridRND.Refresh();
        }

        //Funcion para limpiar los campos de las variables
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarInterfaz();
            dataGridRND.Visible = false;
        }

        //Cambia los valores de los rangos que se visualizan en la tabla
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            populateDataTable(ListaRandom, ListaVariablesAleatorias, int.Parse(txtDesde.Text), int.Parse(txtHasta.Text));

        }
        public bool validarIntervalos()
        {
            if(cmbIntervalos.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Genera las pruebas de bondad de ajuste
        private void btnPrueba_Click(object sender, EventArgs e)
        {
            if (validarIntervalos())
            {
                double segundaVariable = 0;
                if (cmbTipoDistribucion.SelectedIndex != 3) 
                {
                    segundaVariable = double.Parse(txtSegundaVariable.Text);
                }

                Prueba ventana = new Prueba(int.Parse(cmbIntervalos.Text), ListaVariablesAleatorias, double.Parse(txtPrimeraVariable.Text),segundaVariable, cmbTipoDistribucion.SelectedIndex);
                ventana.ShowDialog();
            }
            else
            {
                MessageBox.Show("Antes de generar la prueba o el histograma seleccione la cantidad de intervalos!");
            }
            
        }

        private int ConseguirCantIntervalos(int index)
        {
            switch (index)
            {
                case 0 : return 5;
                case 1 : return 8;
                case 2 : return 10;
                case 3 : return 12;
                case 4 : return 15;
                default: return 5;
            }
        }


        private void btnHistograma_Click(object sender, EventArgs e)
        {
            if (validarIntervalos())
            {
                Histograma ventana = new Histograma(ListaVariablesAleatorias, ConseguirCantIntervalos(cmbIntervalos.SelectedIndex));
                ventana.ShowDialog();
            }
            else
            {
                MessageBox.Show("Antes de generar la prueba o el histograma seleccione la cantidad de intervalos!");
            }
        }
    }
}
