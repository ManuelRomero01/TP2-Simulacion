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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exponencialNegativaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uniformeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poissonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exponencialNegativaToolStripMenuItem,
            this.uniformeToolStripMenuItem,
            this.poissonToolStripMenuItem,
            this.normalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2035, 72);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exponencialNegativaToolStripMenuItem
            // 
            this.exponencialNegativaToolStripMenuItem.Name = "exponencialNegativaToolStripMenuItem";
            this.exponencialNegativaToolStripMenuItem.Size = new System.Drawing.Size(388, 52);
            this.exponencialNegativaToolStripMenuItem.Text = "Exponencial Negativa";
            this.exponencialNegativaToolStripMenuItem.Click += new System.EventHandler(this.exponencialNegativaToolStripMenuItem_Click);
            // 
            // uniformeToolStripMenuItem
            // 
            this.uniformeToolStripMenuItem.Name = "uniformeToolStripMenuItem";
            this.uniformeToolStripMenuItem.Size = new System.Drawing.Size(197, 52);
            this.uniformeToolStripMenuItem.Text = "Uniforme";
            this.uniformeToolStripMenuItem.Click += new System.EventHandler(this.uniformeToolStripMenuItem_Click);
            // 
            // poissonToolStripMenuItem
            // 
            this.poissonToolStripMenuItem.Name = "poissonToolStripMenuItem";
            this.poissonToolStripMenuItem.Size = new System.Drawing.Size(168, 52);
            this.poissonToolStripMenuItem.Text = "Poisson";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(167, 52);
            this.normalToolStripMenuItem.Text = "Normal";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(2035, 1084);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exponencialNegativaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uniformeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poissonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
    }
}

