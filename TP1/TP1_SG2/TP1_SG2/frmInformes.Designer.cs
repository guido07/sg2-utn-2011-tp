namespace TP1_SG2
{
    partial class frmInformes
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoBebida = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaDesde = new System.Windows.Forms.TextBox();
            this.txtFechaHasta = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabVenta = new System.Windows.Forms.TabPage();
            this.tabRegiones = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabVendedores = new System.Windows.Forms.TabPage();
            this.antiguedad = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl.SuspendLayout();
            this.tabVenta.SuspendLayout();
            this.tabRegiones.SuspendLayout();
            this.tabVendedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antiguedad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas por tipo de bebida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de bebida";
            // 
            // cbTipoBebida
            // 
            this.cbTipoBebida.FormattingEnabled = true;
            this.cbTipoBebida.Location = new System.Drawing.Point(144, 55);
            this.cbTipoBebida.Name = "cbTipoBebida";
            this.cbTipoBebida.Size = new System.Drawing.Size(121, 21);
            this.cbTipoBebida.TabIndex = 2;
            this.cbTipoBebida.SelectedValueChanged += new System.EventHandler(this.cbTipoBebida_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(536, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hasta";
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(388, 55);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.ReadOnly = true;
            this.txtFechaDesde.Size = new System.Drawing.Size(100, 20);
            this.txtFechaDesde.TabIndex = 5;
            this.txtFechaDesde.Text = "01/01/2006";
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(586, 55);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.ReadOnly = true;
            this.txtFechaHasta.Size = new System.Drawing.Size(100, 20);
            this.txtFechaHasta.TabIndex = 6;
            this.txtFechaHasta.Text = "31/08/2009";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabVenta);
            this.tabControl.Controls.Add(this.tabRegiones);
            this.tabControl.Controls.Add(this.tabVendedores);
            this.tabControl.Location = new System.Drawing.Point(2, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(781, 519);
            this.tabControl.TabIndex = 8;
            // 
            // tabVenta
            // 
            this.tabVenta.Controls.Add(this.label2);
            this.tabVenta.Controls.Add(this.reportViewer1);
            this.tabVenta.Controls.Add(this.label1);
            this.tabVenta.Controls.Add(this.txtFechaHasta);
            this.tabVenta.Controls.Add(this.cbTipoBebida);
            this.tabVenta.Controls.Add(this.txtFechaDesde);
            this.tabVenta.Controls.Add(this.label3);
            this.tabVenta.Controls.Add(this.label4);
            this.tabVenta.Location = new System.Drawing.Point(4, 22);
            this.tabVenta.Name = "tabVenta";
            this.tabVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenta.Size = new System.Drawing.Size(773, 493);
            this.tabVenta.TabIndex = 0;
            this.tabVenta.Text = "Ventas";
            this.tabVenta.UseVisualStyleBackColor = true;
            // 
            // tabRegiones
            // 
            this.tabRegiones.Controls.Add(this.label5);
            this.tabRegiones.Controls.Add(this.reportViewer2);
            this.tabRegiones.Controls.Add(this.label6);
            this.tabRegiones.Controls.Add(this.txtHasta);
            this.tabRegiones.Controls.Add(this.cbRegion);
            this.tabRegiones.Controls.Add(this.txtDesde);
            this.tabRegiones.Controls.Add(this.label7);
            this.tabRegiones.Controls.Add(this.label8);
            this.tabRegiones.Location = new System.Drawing.Point(4, 22);
            this.tabRegiones.Name = "tabRegiones";
            this.tabRegiones.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegiones.Size = new System.Drawing.Size(773, 493);
            this.tabRegiones.TabIndex = 1;
            this.tabRegiones.Text = "Regiones";
            this.tabRegiones.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Region de \r\nprocedencia";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer2
            // 
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "TP1_SG2.Informe_Regiones.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(6, 81);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ShowBackButton = false;
            this.reportViewer2.ShowContextMenu = false;
            this.reportViewer2.ShowCredentialPrompts = false;
            this.reportViewer2.ShowDocumentMapButton = false;
            this.reportViewer2.ShowExportButton = false;
            this.reportViewer2.ShowFindControls = false;
            this.reportViewer2.ShowParameterPrompts = false;
            this.reportViewer2.ShowPrintButton = false;
            this.reportViewer2.ShowRefreshButton = false;
            this.reportViewer2.ShowStopButton = false;
            this.reportViewer2.ShowZoomControl = false;
            this.reportViewer2.Size = new System.Drawing.Size(760, 406);
            this.reportViewer2.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(201, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ventas por region de procedencia del Cliente";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(560, 52);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.ReadOnly = true;
            this.txtHasta.Size = new System.Drawing.Size(100, 20);
            this.txtHasta.TabIndex = 15;
            this.txtHasta.Text = "2008";
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(179, 52);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(121, 21);
            this.cbRegion.TabIndex = 11;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(382, 52);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.ReadOnly = true;
            this.txtDesde.Size = new System.Drawing.Size(100, 20);
            this.txtDesde.TabIndex = 14;
            this.txtDesde.Text = "2006";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(327, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Desde";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(510, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Hasta";
            // 
            // tabVendedores
            // 
            this.tabVendedores.Controls.Add(this.antiguedad);
            this.tabVendedores.Controls.Add(this.label9);
            this.tabVendedores.Controls.Add(this.reportViewer3);
            this.tabVendedores.Controls.Add(this.label10);
            this.tabVendedores.Controls.Add(this.txtAño);
            this.tabVendedores.Controls.Add(this.label11);
            this.tabVendedores.Location = new System.Drawing.Point(4, 22);
            this.tabVendedores.Name = "tabVendedores";
            this.tabVendedores.Padding = new System.Windows.Forms.Padding(3);
            this.tabVendedores.Size = new System.Drawing.Size(773, 493);
            this.tabVendedores.TabIndex = 2;
            this.tabVendedores.Text = "Vendedores";
            this.tabVendedores.UseVisualStyleBackColor = true;
            // 
            // antiguedad
            // 
            this.antiguedad.Location = new System.Drawing.Point(264, 53);
            this.antiguedad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.antiguedad.Name = "antiguedad";
            this.antiguedad.Size = new System.Drawing.Size(83, 20);
            this.antiguedad.TabIndex = 24;
            this.antiguedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.antiguedad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(130, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Antigüedad en años";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer3
            // 
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "TP1_SG2.Informe_Vendedores.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(6, 81);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ShowBackButton = false;
            this.reportViewer3.ShowContextMenu = false;
            this.reportViewer3.ShowCredentialPrompts = false;
            this.reportViewer3.ShowDocumentMapButton = false;
            this.reportViewer3.ShowExportButton = false;
            this.reportViewer3.ShowFindControls = false;
            this.reportViewer3.ShowParameterPrompts = false;
            this.reportViewer3.ShowPrintButton = false;
            this.reportViewer3.ShowRefreshButton = false;
            this.reportViewer3.ShowStopButton = false;
            this.reportViewer3.ShowZoomControl = false;
            this.reportViewer3.Size = new System.Drawing.Size(760, 406);
            this.reportViewer3.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(252, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(268, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Productividad de los vendedores";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(505, 52);
            this.txtAño.Name = "txtAño";
            this.txtAño.ReadOnly = true;
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 21;
            this.txtAño.Text = "2009";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(469, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Año";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP1_SG2.Informe_Ventas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(7, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowPrintButton = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(760, 406);
            this.reportViewer1.TabIndex = 7;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 522);
            this.Controls.Add(this.tabControl);
            this.Name = "frmInformes";
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.Perfomace_Ventas_Load);
            this.tabControl.ResumeLayout(false);
            this.tabVenta.ResumeLayout(false);
            this.tabVenta.PerformLayout();
            this.tabRegiones.ResumeLayout(false);
            this.tabRegiones.PerformLayout();
            this.tabVendedores.ResumeLayout(false);
            this.tabVendedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antiguedad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoBebida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFechaDesde;
        private System.Windows.Forms.TextBox txtFechaHasta;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabVenta;
        private System.Windows.Forms.TabPage tabRegiones;
        private System.Windows.Forms.Label label5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabVendedores;
        private System.Windows.Forms.NumericUpDown antiguedad;
        private System.Windows.Forms.Label label9;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label11;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}

