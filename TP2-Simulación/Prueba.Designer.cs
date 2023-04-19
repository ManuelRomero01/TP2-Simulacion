namespace TP2_Simulación
{
    partial class Prueba
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTipoPrueba = new System.Windows.Forms.Label();
            this.cmbTipoPrueba = new System.Windows.Forms.ComboBox();
            this.gdrPrueba = new System.Windows.Forms.DataGridView();
            this.lblTabulado = new System.Windows.Forms.Label();
            this.txtTabulado = new System.Windows.Forms.TextBox();
            this.lblCalculado = new System.Windows.Forms.Label();
            this.txtCalculado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblSignificancia = new System.Windows.Forms.Label();
            this.cmbSignificancia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPrueba)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, -2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(815, 69);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Prueba de Bondad de Ajuste";
            // 
            // lblTipoPrueba
            // 
            this.lblTipoPrueba.AutoSize = true;
            this.lblTipoPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPrueba.Location = new System.Drawing.Point(1149, 109);
            this.lblTipoPrueba.Name = "lblTipoPrueba";
            this.lblTipoPrueba.Size = new System.Drawing.Size(511, 46);
            this.lblTipoPrueba.TabIndex = 1;
            this.lblTipoPrueba.Text = "Tipo de prueba a ejecutar:";
            // 
            // cmbTipoPrueba
            // 
            this.cmbTipoPrueba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPrueba.Enabled = false;
            this.cmbTipoPrueba.FormattingEnabled = true;
            this.cmbTipoPrueba.Items.AddRange(new object[] {
            "Chi-Cuadrado",
            "Kolmorogov-Smirnov"});
            this.cmbTipoPrueba.Location = new System.Drawing.Point(1796, 110);
            this.cmbTipoPrueba.Name = "cmbTipoPrueba";
            this.cmbTipoPrueba.Size = new System.Drawing.Size(387, 45);
            this.cmbTipoPrueba.TabIndex = 2;
            this.cmbTipoPrueba.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPrueba_SelectedIndexChanged);
            this.cmbTipoPrueba.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbTipoPrueba_MouseClick);
            // 
            // gdrPrueba
            // 
            this.gdrPrueba.AllowUserToAddRows = false;
            this.gdrPrueba.AllowUserToDeleteRows = false;
            this.gdrPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrPrueba.Location = new System.Drawing.Point(31, 195);
            this.gdrPrueba.Name = "gdrPrueba";
            this.gdrPrueba.ReadOnly = true;
            this.gdrPrueba.RowHeadersWidth = 123;
            this.gdrPrueba.RowTemplate.Height = 46;
            this.gdrPrueba.Size = new System.Drawing.Size(2152, 861);
            this.gdrPrueba.TabIndex = 3;
            // 
            // lblTabulado
            // 
            this.lblTabulado.AutoSize = true;
            this.lblTabulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabulado.Location = new System.Drawing.Point(33, 1081);
            this.lblTabulado.Name = "lblTabulado";
            this.lblTabulado.Size = new System.Drawing.Size(378, 55);
            this.lblTabulado.TabIndex = 4;
            this.lblTabulado.Text = "Valor Tabulado:";
            // 
            // txtTabulado
            // 
            this.txtTabulado.Location = new System.Drawing.Point(579, 1093);
            this.txtTabulado.Name = "txtTabulado";
            this.txtTabulado.ReadOnly = true;
            this.txtTabulado.Size = new System.Drawing.Size(376, 44);
            this.txtTabulado.TabIndex = 5;
            // 
            // lblCalculado
            // 
            this.lblCalculado.AutoSize = true;
            this.lblCalculado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculado.Location = new System.Drawing.Point(33, 1171);
            this.lblCalculado.Name = "lblCalculado";
            this.lblCalculado.Size = new System.Drawing.Size(392, 55);
            this.lblCalculado.TabIndex = 6;
            this.lblCalculado.Text = "Valor Calculado:";
            // 
            // txtCalculado
            // 
            this.txtCalculado.Location = new System.Drawing.Point(579, 1183);
            this.txtCalculado.Name = "txtCalculado";
            this.txtCalculado.ReadOnly = true;
            this.txtCalculado.Size = new System.Drawing.Size(376, 44);
            this.txtCalculado.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(33, 1257);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(264, 55);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Control;
            this.txtResultado.Location = new System.Drawing.Point(579, 1268);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(376, 44);
            this.txtResultado.TabIndex = 9;
            // 
            // lblSignificancia
            // 
            this.lblSignificancia.AutoSize = true;
            this.lblSignificancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignificancia.Location = new System.Drawing.Point(23, 105);
            this.lblSignificancia.Name = "lblSignificancia";
            this.lblSignificancia.Size = new System.Drawing.Size(434, 46);
            this.lblSignificancia.TabIndex = 10;
            this.lblSignificancia.Text = "Nivel de Significancia:";
            // 
            // cmbSignificancia
            // 
            this.cmbSignificancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSignificancia.FormattingEnabled = true;
            this.cmbSignificancia.Items.AddRange(new object[] {
            "0,01",
            "0,05",
            "0,10"});
            this.cmbSignificancia.Location = new System.Drawing.Point(611, 114);
            this.cmbSignificancia.Name = "cmbSignificancia";
            this.cmbSignificancia.Size = new System.Drawing.Size(387, 45);
            this.cmbSignificancia.TabIndex = 11;
            this.cmbSignificancia.SelectedIndexChanged += new System.EventHandler(this.cmbSignificancia_SelectedIndexChanged);
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(2282, 1468);
            this.Controls.Add(this.cmbSignificancia);
            this.Controls.Add(this.lblSignificancia);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtCalculado);
            this.Controls.Add(this.lblCalculado);
            this.Controls.Add(this.txtTabulado);
            this.Controls.Add(this.lblTabulado);
            this.Controls.Add(this.gdrPrueba);
            this.Controls.Add(this.cmbTipoPrueba);
            this.Controls.Add(this.lblTipoPrueba);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Prueba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba";
            ((System.ComponentModel.ISupportInitialize)(this.gdrPrueba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipoPrueba;
        private System.Windows.Forms.ComboBox cmbTipoPrueba;
        private System.Windows.Forms.DataGridView gdrPrueba;
        private System.Windows.Forms.Label lblTabulado;
        private System.Windows.Forms.TextBox txtTabulado;
        private System.Windows.Forms.Label lblCalculado;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtCalculado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblSignificancia;
        private System.Windows.Forms.ComboBox cmbSignificancia;
    }
}