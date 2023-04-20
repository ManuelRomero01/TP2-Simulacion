namespace TP2_Simulación
{
    partial class Histograma
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.chtHistograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chtHistograma)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(-3, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(345, 69);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Histograma";
            // 
            // chtHistograma
            // 
            chartArea3.Name = "ChartArea1";
            this.chtHistograma.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chtHistograma.Legends.Add(legend3);
            this.chtHistograma.Location = new System.Drawing.Point(184, 139);
            this.chtHistograma.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.chtHistograma.Name = "chtHistograma";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chtHistograma.Series.Add(series3);
            this.chtHistograma.Size = new System.Drawing.Size(2666, 1412);
            this.chtHistograma.TabIndex = 2;
            this.chtHistograma.Text = "chart1";
            // 
            // Histograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(3084, 1662);
            this.Controls.Add(this.chtHistograma);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Histograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histograma";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Histograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtHistograma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtHistograma;
    }
}