namespace TP2_Simulación
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVariables = new System.Windows.Forms.Label();
            this.lblCantidadValores = new System.Windows.Forms.Label();
            this.txtPrimeraVariable = new System.Windows.Forms.TextBox();
            this.lblPrimeraVariable = new System.Windows.Forms.Label();
            this.txtSegundaVariable = new System.Windows.Forms.TextBox();
            this.lblSegundaVariable = new System.Windows.Forms.Label();
            this.lblTipoDistribucion = new System.Windows.Forms.Label();
            this.cmbTipoDistribucion = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtCantValores = new System.Windows.Forms.MaskedTextBox();
            this.txtDesde = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.MaskedTextBox();
            this.dataGridRND = new System.Windows.Forms.DataGridView();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.btnHistograma = new System.Windows.Forms.Button();
            this.lblIntervalos = new System.Windows.Forms.Label();
            this.lblCantIntervalos = new System.Windows.Forms.Label();
            this.cmbIntervalos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRND)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVariables
            // 
            this.lblVariables.AutoSize = true;
            this.lblVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariables.Location = new System.Drawing.Point(68, 46);
            this.lblVariables.Name = "lblVariables";
            this.lblVariables.Size = new System.Drawing.Size(110, 25);
            this.lblVariables.TabIndex = 0;
            this.lblVariables.Text = "Variables:";
            // 
            // lblCantidadValores
            // 
            this.lblCantidadValores.AutoSize = true;
            this.lblCantidadValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadValores.Location = new System.Drawing.Point(70, 100);
            this.lblCantidadValores.Name = "lblCantidadValores";
            this.lblCantidadValores.Size = new System.Drawing.Size(138, 17);
            this.lblCantidadValores.TabIndex = 1;
            this.lblCantidadValores.Text = "Cantidad de valores:";
            // 
            // txtPrimeraVariable
            // 
            this.txtPrimeraVariable.Location = new System.Drawing.Point(215, 150);
            this.txtPrimeraVariable.Name = "txtPrimeraVariable";
            this.txtPrimeraVariable.Size = new System.Drawing.Size(100, 20);
            this.txtPrimeraVariable.TabIndex = 2;
            this.txtPrimeraVariable.Click += new System.EventHandler(this.txtPrimeraVariable_OnClick);
            this.txtPrimeraVariable.TextChanged += new System.EventHandler(this.txtPrimeraVariable_ValueChanged);
            // 
            // lblPrimeraVariable
            // 
            this.lblPrimeraVariable.AutoSize = true;
            this.lblPrimeraVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeraVariable.Location = new System.Drawing.Point(70, 150);
            this.lblPrimeraVariable.Name = "lblPrimeraVariable";
            this.lblPrimeraVariable.Size = new System.Drawing.Size(115, 17);
            this.lblPrimeraVariable.TabIndex = 3;
            this.lblPrimeraVariable.Text = "Primera variable:";
            // 
            // txtSegundaVariable
            // 
            this.txtSegundaVariable.Location = new System.Drawing.Point(215, 202);
            this.txtSegundaVariable.Name = "txtSegundaVariable";
            this.txtSegundaVariable.Size = new System.Drawing.Size(100, 20);
            this.txtSegundaVariable.TabIndex = 3;
            this.txtSegundaVariable.Click += new System.EventHandler(this.txtSegundaVariable_OnClick);
            this.txtSegundaVariable.TextChanged += new System.EventHandler(this.txtSegundaVariable_ValueChanged);
            // 
            // lblSegundaVariable
            // 
            this.lblSegundaVariable.AutoSize = true;
            this.lblSegundaVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundaVariable.Location = new System.Drawing.Point(70, 200);
            this.lblSegundaVariable.Name = "lblSegundaVariable";
            this.lblSegundaVariable.Size = new System.Drawing.Size(123, 17);
            this.lblSegundaVariable.TabIndex = 5;
            this.lblSegundaVariable.Text = "Segunda variable:";
            // 
            // lblTipoDistribucion
            // 
            this.lblTipoDistribucion.AutoSize = true;
            this.lblTipoDistribucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDistribucion.Location = new System.Drawing.Point(417, 52);
            this.lblTipoDistribucion.Name = "lblTipoDistribucion";
            this.lblTipoDistribucion.Size = new System.Drawing.Size(157, 17);
            this.lblTipoDistribucion.TabIndex = 7;
            this.lblTipoDistribucion.Text = "Tipo de distribucion:";
            // 
            // cmbTipoDistribucion
            // 
            this.cmbTipoDistribucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDistribucion.FormattingEnabled = true;
            this.cmbTipoDistribucion.Items.AddRange(new object[] {
            "Normal",
            "Uniforme",
            "Exponencial negativa",
            "Poisson"});
            this.cmbTipoDistribucion.Location = new System.Drawing.Point(589, 54);
            this.cmbTipoDistribucion.Name = "cmbTipoDistribucion";
            this.cmbTipoDistribucion.Size = new System.Drawing.Size(138, 21);
            this.cmbTipoDistribucion.TabIndex = 10;
            this.cmbTipoDistribucion.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(586, 92);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(138, 69);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtCantValores
            // 
            this.txtCantValores.Location = new System.Drawing.Point(215, 100);
            this.txtCantValores.Mask = "00000";
            this.txtCantValores.Name = "txtCantValores";
            this.txtCantValores.Size = new System.Drawing.Size(100, 20);
            this.txtCantValores.TabIndex = 1;
            this.txtCantValores.ValidatingType = typeof(int);
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(419, 110);
            this.txtDesde.Mask = "00000";
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(61, 20);
            this.txtDesde.TabIndex = 4;
            this.txtDesde.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rango a visualizar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hasta:";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(419, 136);
            this.txtHasta.Mask = "00000";
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(61, 20);
            this.txtHasta.TabIndex = 5;
            this.txtHasta.ValidatingType = typeof(int);
            // 
            // dataGridRND
            // 
            this.dataGridRND.AllowUserToAddRows = false;
            this.dataGridRND.AllowUserToDeleteRows = false;
            this.dataGridRND.AllowUserToResizeRows = false;
            this.dataGridRND.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridRND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRND.Location = new System.Drawing.Point(72, 237);
            this.dataGridRND.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridRND.MultiSelect = false;
            this.dataGridRND.Name = "dataGridRND";
            this.dataGridRND.ReadOnly = true;
            this.dataGridRND.RowHeadersWidth = 123;
            this.dataGridRND.RowTemplate.Height = 46;
            this.dataGridRND.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridRND.Size = new System.Drawing.Size(434, 229);
            this.dataGridRND.TabIndex = 16;
            this.dataGridRND.Visible = false;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(586, 171);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(138, 50);
            this.btnLimpiarCampos.TabIndex = 11;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(363, 171);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(115, 50);
            this.btnVisualizar.TabIndex = 18;
            this.btnVisualizar.Text = "Modificar Rango";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Visible = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnPrueba
            // 
            this.btnPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrueba.Location = new System.Drawing.Point(586, 352);
            this.btnPrueba.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(138, 53);
            this.btnPrueba.TabIndex = 9;
            this.btnPrueba.Text = "Generar Prueba";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Visible = false;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // btnHistograma
            // 
            this.btnHistograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistograma.Location = new System.Drawing.Point(586, 287);
            this.btnHistograma.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnHistograma.Name = "btnHistograma";
            this.btnHistograma.Size = new System.Drawing.Size(138, 53);
            this.btnHistograma.TabIndex = 8;
            this.btnHistograma.Text = "Generar Histograma";
            this.btnHistograma.UseVisualStyleBackColor = true;
            this.btnHistograma.Visible = false;
            this.btnHistograma.Click += new System.EventHandler(this.btnHistograma_Click);
            // 
            // lblIntervalos
            // 
            this.lblIntervalos.AutoSize = true;
            this.lblIntervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervalos.Location = new System.Drawing.Point(590, 237);
            this.lblIntervalos.Name = "lblIntervalos";
            this.lblIntervalos.Size = new System.Drawing.Size(0, 17);
            this.lblIntervalos.TabIndex = 22;
            // 
            // lblCantIntervalos
            // 
            this.lblCantIntervalos.AutoSize = true;
            this.lblCantIntervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantIntervalos.Location = new System.Drawing.Point(541, 248);
            this.lblCantIntervalos.Name = "lblCantIntervalos";
            this.lblCantIntervalos.Size = new System.Drawing.Size(153, 17);
            this.lblCantIntervalos.TabIndex = 23;
            this.lblCantIntervalos.Text = "Cantidad de Intervalos:";
            this.lblCantIntervalos.Visible = false;
            // 
            // cmbIntervalos
            // 
            this.cmbIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntervalos.FormattingEnabled = true;
            this.cmbIntervalos.Items.AddRange(new object[] {
            "5",
            "8",
            "10",
            "12",
            "15"});
            this.cmbIntervalos.Location = new System.Drawing.Point(709, 248);
            this.cmbIntervalos.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cmbIntervalos.Name = "cmbIntervalos";
            this.cmbIntervalos.Size = new System.Drawing.Size(47, 21);
            this.cmbIntervalos.TabIndex = 7;
            this.cmbIntervalos.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(832, 496);
            this.Controls.Add(this.cmbIntervalos);
            this.Controls.Add(this.lblCantIntervalos);
            this.Controls.Add(this.lblIntervalos);
            this.Controls.Add(this.btnHistograma);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.dataGridRND);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantValores);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cmbTipoDistribucion);
            this.Controls.Add(this.lblTipoDistribucion);
            this.Controls.Add(this.txtSegundaVariable);
            this.Controls.Add(this.lblSegundaVariable);
            this.Controls.Add(this.txtPrimeraVariable);
            this.Controls.Add(this.lblPrimeraVariable);
            this.Controls.Add(this.lblCantidadValores);
            this.Controls.Add(this.lblVariables);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(865, 552);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(43, 61);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRND)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVariables;
        private System.Windows.Forms.Label lblCantidadValores;
        private System.Windows.Forms.TextBox txtPrimeraVariable;
        private System.Windows.Forms.Label lblPrimeraVariable;
        private System.Windows.Forms.TextBox txtSegundaVariable;
        private System.Windows.Forms.Label lblSegundaVariable;
        private System.Windows.Forms.Label lblTipoDistribucion;
        private System.Windows.Forms.ComboBox cmbTipoDistribucion;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.MaskedTextBox txtCantValores;
        private System.Windows.Forms.MaskedTextBox txtDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtHasta;
        private System.Windows.Forms.DataGridView dataGridRND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAleatoria;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Button btnHistograma;
        private System.Windows.Forms.Label lblIntervalos;
        private System.Windows.Forms.Label lblCantIntervalos;
        private System.Windows.Forms.ComboBox cmbIntervalos;
    }
}

