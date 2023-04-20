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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblTipoNormal = new System.Windows.Forms.Label();
            this.cmbTipoNormal = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRND)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVariables
            // 
            this.lblVariables.AutoSize = true;
            this.lblVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariables.Location = new System.Drawing.Point(218, 34);
            this.lblVariables.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblVariables.Name = "lblVariables";
            this.lblVariables.Size = new System.Drawing.Size(305, 69);
            this.lblVariables.TabIndex = 0;
            this.lblVariables.Text = "Variables:";
            // 
            // lblCantidadValores
            // 
            this.lblCantidadValores.AutoSize = true;
            this.lblCantidadValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadValores.Location = new System.Drawing.Point(51, 142);
            this.lblCantidadValores.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblCantidadValores.Name = "lblCantidadValores";
            this.lblCantidadValores.Size = new System.Drawing.Size(384, 46);
            this.lblCantidadValores.TabIndex = 1;
            this.lblCantidadValores.Text = "Cantidad de valores:";
            // 
            // txtPrimeraVariable
            // 
            this.txtPrimeraVariable.Location = new System.Drawing.Point(684, 289);
            this.txtPrimeraVariable.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtPrimeraVariable.Name = "txtPrimeraVariable";
            this.txtPrimeraVariable.Size = new System.Drawing.Size(375, 44);
            this.txtPrimeraVariable.TabIndex = 2;
            this.txtPrimeraVariable.Click += new System.EventHandler(this.txtPrimeraVariable_OnClick);
            this.txtPrimeraVariable.TextChanged += new System.EventHandler(this.txtPrimeraVariable_ValueChanged);
            // 
            // lblPrimeraVariable
            // 
            this.lblPrimeraVariable.AutoSize = true;
            this.lblPrimeraVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeraVariable.Location = new System.Drawing.Point(51, 284);
            this.lblPrimeraVariable.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblPrimeraVariable.Name = "lblPrimeraVariable";
            this.lblPrimeraVariable.Size = new System.Drawing.Size(319, 46);
            this.lblPrimeraVariable.TabIndex = 3;
            this.lblPrimeraVariable.Text = "Primera variable:";
            // 
            // txtSegundaVariable
            // 
            this.txtSegundaVariable.Location = new System.Drawing.Point(684, 417);
            this.txtSegundaVariable.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtSegundaVariable.Name = "txtSegundaVariable";
            this.txtSegundaVariable.Size = new System.Drawing.Size(375, 44);
            this.txtSegundaVariable.TabIndex = 3;
            this.txtSegundaVariable.Click += new System.EventHandler(this.txtSegundaVariable_OnClick);
            this.txtSegundaVariable.TextChanged += new System.EventHandler(this.txtSegundaVariable_ValueChanged);
            // 
            // lblSegundaVariable
            // 
            this.lblSegundaVariable.AutoSize = true;
            this.lblSegundaVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundaVariable.Location = new System.Drawing.Point(51, 412);
            this.lblSegundaVariable.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblSegundaVariable.Name = "lblSegundaVariable";
            this.lblSegundaVariable.Size = new System.Drawing.Size(339, 46);
            this.lblSegundaVariable.TabIndex = 5;
            this.lblSegundaVariable.Text = "Segunda variable:";
            // 
            // lblTipoDistribucion
            // 
            this.lblTipoDistribucion.AutoSize = true;
            this.lblTipoDistribucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDistribucion.Location = new System.Drawing.Point(1311, 142);
            this.lblTipoDistribucion.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTipoDistribucion.Name = "lblTipoDistribucion";
            this.lblTipoDistribucion.Size = new System.Drawing.Size(399, 46);
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
            this.cmbTipoDistribucion.Location = new System.Drawing.Point(1856, 148);
            this.cmbTipoDistribucion.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cmbTipoDistribucion.Name = "cmbTipoDistribucion";
            this.cmbTipoDistribucion.Size = new System.Drawing.Size(428, 45);
            this.cmbTipoDistribucion.TabIndex = 10;
            this.cmbTipoDistribucion.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(1856, 262);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(437, 196);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtCantValores
            // 
            this.txtCantValores.Location = new System.Drawing.Point(684, 147);
            this.txtCantValores.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtCantValores.Mask = "00000";
            this.txtCantValores.Name = "txtCantValores";
            this.txtCantValores.Size = new System.Drawing.Size(375, 44);
            this.txtCantValores.TabIndex = 1;
            this.txtCantValores.ValidatingType = typeof(int);
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(1327, 313);
            this.txtDesde.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtDesde.Mask = "00000";
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(184, 44);
            this.txtDesde.TabIndex = 4;
            this.txtDesde.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1140, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rango a visualizar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1140, 322);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 46);
            this.label2.TabIndex = 13;
            this.label2.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1140, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 46);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hasta:";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(1327, 387);
            this.txtHasta.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtHasta.Mask = "00000";
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(184, 44);
            this.txtHasta.TabIndex = 5;
            this.txtHasta.ValidatingType = typeof(int);
            // 
            // dataGridRND
            // 
            this.dataGridRND.AllowUserToAddRows = false;
            this.dataGridRND.AllowUserToDeleteRows = false;
            this.dataGridRND.AllowUserToResizeRows = false;
            this.dataGridRND.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridRND.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridRND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRND.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRND.Location = new System.Drawing.Point(59, 675);
            this.dataGridRND.MultiSelect = false;
            this.dataGridRND.Name = "dataGridRND";
            this.dataGridRND.ReadOnly = true;
            this.dataGridRND.RowHeadersVisible = false;
            this.dataGridRND.RowHeadersWidth = 123;
            this.dataGridRND.RowTemplate.Height = 46;
            this.dataGridRND.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridRND.Size = new System.Drawing.Size(1452, 652);
            this.dataGridRND.TabIndex = 16;
            this.dataGridRND.Visible = false;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(1856, 487);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(437, 142);
            this.btnLimpiarCampos.TabIndex = 11;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(1150, 487);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(364, 142);
            this.btnVisualizar.TabIndex = 18;
            this.btnVisualizar.Text = "Modificar Rango";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Visible = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnPrueba
            // 
            this.btnPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrueba.Location = new System.Drawing.Point(1856, 1002);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(437, 151);
            this.btnPrueba.TabIndex = 9;
            this.btnPrueba.Text = "Generar Prueba";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Visible = false;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // btnHistograma
            // 
            this.btnHistograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistograma.Location = new System.Drawing.Point(1856, 817);
            this.btnHistograma.Name = "btnHistograma";
            this.btnHistograma.Size = new System.Drawing.Size(437, 151);
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
            this.lblIntervalos.Location = new System.Drawing.Point(1868, 675);
            this.lblIntervalos.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblIntervalos.Name = "lblIntervalos";
            this.lblIntervalos.Size = new System.Drawing.Size(0, 46);
            this.lblIntervalos.TabIndex = 22;
            // 
            // lblCantIntervalos
            // 
            this.lblCantIntervalos.AutoSize = true;
            this.lblCantIntervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantIntervalos.Location = new System.Drawing.Point(1713, 706);
            this.lblCantIntervalos.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblCantIntervalos.Name = "lblCantIntervalos";
            this.lblCantIntervalos.Size = new System.Drawing.Size(427, 46);
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
            this.cmbIntervalos.Location = new System.Drawing.Point(2245, 706);
            this.cmbIntervalos.Name = "cmbIntervalos";
            this.cmbIntervalos.Size = new System.Drawing.Size(200, 45);
            this.cmbIntervalos.TabIndex = 7;
            this.cmbIntervalos.Visible = false;
            // 
            // lblTipoNormal
            // 
            this.lblTipoNormal.AutoSize = true;
            this.lblTipoNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoNormal.Location = new System.Drawing.Point(51, 534);
            this.lblTipoNormal.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTipoNormal.Name = "lblTipoNormal";
            this.lblTipoNormal.Size = new System.Drawing.Size(505, 46);
            this.lblTipoNormal.TabIndex = 24;
            this.lblTipoNormal.Text = "Tipo de Generador Normal:";
            this.lblTipoNormal.Visible = false;
            // 
            // cmbTipoNormal
            // 
            this.cmbTipoNormal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoNormal.FormattingEnabled = true;
            this.cmbTipoNormal.Items.AddRange(new object[] {
            "Box-Müller",
            "Convolución"});
            this.cmbTipoNormal.Location = new System.Drawing.Point(684, 544);
            this.cmbTipoNormal.Name = "cmbTipoNormal";
            this.cmbTipoNormal.Size = new System.Drawing.Size(375, 45);
            this.cmbTipoNormal.TabIndex = 25;
            this.cmbTipoNormal.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(2625, 1278);
            this.Controls.Add(this.cmbTipoNormal);
            this.Controls.Add(this.lblTipoNormal);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2661, 1381);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(58, 103);
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
        private System.Windows.Forms.Label lblTipoNormal;
        private System.Windows.Forms.ComboBox cmbTipoNormal;
    }
}

