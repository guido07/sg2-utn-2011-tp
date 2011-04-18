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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoBebida = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaDesde = new System.Windows.Forms.TextBox();
            this.txtFechaHasta = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabVenta = new System.Windows.Forms.TabPage();
            this.btnInforme1 = new System.Windows.Forms.Button();
            this.grafico1 = new ZedGraph.ZedGraphControl();
            this.grilla1 = new System.Windows.Forms.DataGridView();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRegiones = new System.Windows.Forms.TabPage();
            this.btnInforme2 = new System.Windows.Forms.Button();
            this.grafico2 = new ZedGraph.ZedGraphControl();
            this.grilla2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabVendedores = new System.Windows.Forms.TabPage();
            this.btnInforme3 = new System.Windows.Forms.Button();
            this.grafico3 = new ZedGraph.ZedGraphControl();
            this.grilla3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antiguedad = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla1)).BeginInit();
            this.tabRegiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla2)).BeginInit();
            this.tabVendedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antiguedad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas por tipo de bebida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de bebida";
            // 
            // cbTipoBebida
            // 
            this.cbTipoBebida.FormattingEnabled = true;
            this.cbTipoBebida.Location = new System.Drawing.Point(147, 45);
            this.cbTipoBebida.Name = "cbTipoBebida";
            this.cbTipoBebida.Size = new System.Drawing.Size(121, 21);
            this.cbTipoBebida.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(497, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(742, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hasta";
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(552, 45);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.ReadOnly = true;
            this.txtFechaDesde.Size = new System.Drawing.Size(100, 20);
            this.txtFechaDesde.TabIndex = 5;
            this.txtFechaDesde.Text = "01/01/2006";
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(792, 45);
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
            this.tabControl.Size = new System.Drawing.Size(981, 460);
            this.tabControl.TabIndex = 8;
            // 
            // tabVenta
            // 
            this.tabVenta.Controls.Add(this.label18);
            this.tabVenta.Controls.Add(this.label17);
            this.tabVenta.Controls.Add(this.label16);
            this.tabVenta.Controls.Add(this.label15);
            this.tabVenta.Controls.Add(this.btnInforme1);
            this.tabVenta.Controls.Add(this.grafico1);
            this.tabVenta.Controls.Add(this.grilla1);
            this.tabVenta.Controls.Add(this.label2);
            this.tabVenta.Controls.Add(this.label1);
            this.tabVenta.Controls.Add(this.txtFechaHasta);
            this.tabVenta.Controls.Add(this.cbTipoBebida);
            this.tabVenta.Controls.Add(this.txtFechaDesde);
            this.tabVenta.Controls.Add(this.label3);
            this.tabVenta.Controls.Add(this.label4);
            this.tabVenta.Location = new System.Drawing.Point(4, 22);
            this.tabVenta.Name = "tabVenta";
            this.tabVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenta.Size = new System.Drawing.Size(973, 434);
            this.tabVenta.TabIndex = 0;
            this.tabVenta.Text = "Ventas";
            this.tabVenta.UseVisualStyleBackColor = true;
            // 
            // btnInforme1
            // 
            this.btnInforme1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInforme1.Location = new System.Drawing.Point(307, 39);
            this.btnInforme1.Name = "btnInforme1";
            this.btnInforme1.Size = new System.Drawing.Size(132, 30);
            this.btnInforme1.TabIndex = 9;
            this.btnInforme1.Text = "Generar Informe";
            this.btnInforme1.UseVisualStyleBackColor = true;
            this.btnInforme1.Click += new System.EventHandler(this.btnInforme1_Click);
            // 
            // grafico1
            // 
            this.grafico1.Location = new System.Drawing.Point(388, 81);
            this.grafico1.Name = "grafico1";
            this.grafico1.ScrollGrace = 0;
            this.grafico1.ScrollMaxX = 0;
            this.grafico1.ScrollMaxY = 0;
            this.grafico1.ScrollMaxY2 = 0;
            this.grafico1.ScrollMinX = 0;
            this.grafico1.ScrollMinY = 0;
            this.grafico1.ScrollMinY2 = 0;
            this.grafico1.Size = new System.Drawing.Size(582, 350);
            this.grafico1.TabIndex = 8;
            // 
            // grilla1
            // 
            this.grilla1.AllowUserToAddRows = false;
            this.grilla1.AllowUserToDeleteRows = false;
            this.grilla1.AllowUserToResizeColumns = false;
            this.grilla1.AllowUserToResizeRows = false;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grilla1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.grilla1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Año,
            this.Bimestre,
            this.Monto});
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilla1.DefaultCellStyle = dataGridViewCellStyle32;
            this.grilla1.Location = new System.Drawing.Point(6, 82);
            this.grilla1.Name = "grilla1";
            this.grilla1.ReadOnly = true;
            this.grilla1.RowHeadersVisible = false;
            this.grilla1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla1.Size = new System.Drawing.Size(376, 349);
            this.grilla1.TabIndex = 7;
            // 
            // Año
            // 
            this.Año.DataPropertyName = "Año";
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            // 
            // Bimestre
            // 
            this.Bimestre.DataPropertyName = "Bimestre";
            this.Bimestre.HeaderText = "Bimestre";
            this.Bimestre.Name = "Bimestre";
            this.Bimestre.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // tabRegiones
            // 
            this.tabRegiones.Controls.Add(this.label14);
            this.tabRegiones.Controls.Add(this.label13);
            this.tabRegiones.Controls.Add(this.label12);
            this.tabRegiones.Controls.Add(this.btnInforme2);
            this.tabRegiones.Controls.Add(this.grafico2);
            this.tabRegiones.Controls.Add(this.grilla2);
            this.tabRegiones.Controls.Add(this.label5);
            this.tabRegiones.Controls.Add(this.label6);
            this.tabRegiones.Controls.Add(this.txtHasta);
            this.tabRegiones.Controls.Add(this.cbRegion);
            this.tabRegiones.Controls.Add(this.txtDesde);
            this.tabRegiones.Controls.Add(this.label7);
            this.tabRegiones.Controls.Add(this.label8);
            this.tabRegiones.Location = new System.Drawing.Point(4, 22);
            this.tabRegiones.Name = "tabRegiones";
            this.tabRegiones.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegiones.Size = new System.Drawing.Size(973, 434);
            this.tabRegiones.TabIndex = 1;
            this.tabRegiones.Text = "Regiones";
            this.tabRegiones.UseVisualStyleBackColor = true;
            // 
            // btnInforme2
            // 
            this.btnInforme2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInforme2.Location = new System.Drawing.Point(343, 39);
            this.btnInforme2.Name = "btnInforme2";
            this.btnInforme2.Size = new System.Drawing.Size(132, 30);
            this.btnInforme2.TabIndex = 18;
            this.btnInforme2.Text = "Generar Informe";
            this.btnInforme2.UseVisualStyleBackColor = true;
            this.btnInforme2.Click += new System.EventHandler(this.btnInforme2_Click);
            // 
            // grafico2
            // 
            this.grafico2.Location = new System.Drawing.Point(388, 81);
            this.grafico2.Name = "grafico2";
            this.grafico2.ScrollGrace = 0;
            this.grafico2.ScrollMaxX = 0;
            this.grafico2.ScrollMaxY = 0;
            this.grafico2.ScrollMaxY2 = 0;
            this.grafico2.ScrollMinX = 0;
            this.grafico2.ScrollMinY = 0;
            this.grafico2.ScrollMinY2 = 0;
            this.grafico2.Size = new System.Drawing.Size(582, 350);
            this.grafico2.TabIndex = 17;
            // 
            // grilla2
            // 
            this.grilla2.AllowUserToAddRows = false;
            this.grilla2.AllowUserToDeleteRows = false;
            this.grilla2.AllowUserToResizeColumns = false;
            this.grilla2.AllowUserToResizeRows = false;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grilla2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle33;
            this.grilla2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilla2.DefaultCellStyle = dataGridViewCellStyle34;
            this.grilla2.Location = new System.Drawing.Point(6, 82);
            this.grilla2.Name = "grilla2";
            this.grilla2.ReadOnly = true;
            this.grilla2.RowHeadersVisible = false;
            this.grilla2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla2.Size = new System.Drawing.Size(376, 349);
            this.grilla2.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Año";
            this.dataGridViewTextBoxColumn1.HeaderText = "Año";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Mes";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mes";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Monto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Region de \r\nprocedencia";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(301, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ventas por region de procedencia del Cliente";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(785, 45);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.ReadOnly = true;
            this.txtHasta.Size = new System.Drawing.Size(100, 20);
            this.txtHasta.TabIndex = 15;
            this.txtHasta.Text = "2008";
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(178, 45);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(121, 21);
            this.cbRegion.TabIndex = 11;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(584, 45);
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
            this.label7.Location = new System.Drawing.Point(529, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Desde";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(735, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Hasta";
            // 
            // tabVendedores
            // 
            this.tabVendedores.Controls.Add(this.btnInforme3);
            this.tabVendedores.Controls.Add(this.grafico3);
            this.tabVendedores.Controls.Add(this.grilla3);
            this.tabVendedores.Controls.Add(this.antiguedad);
            this.tabVendedores.Controls.Add(this.label9);
            this.tabVendedores.Controls.Add(this.label10);
            this.tabVendedores.Controls.Add(this.txtAño);
            this.tabVendedores.Controls.Add(this.label11);
            this.tabVendedores.Location = new System.Drawing.Point(4, 22);
            this.tabVendedores.Name = "tabVendedores";
            this.tabVendedores.Padding = new System.Windows.Forms.Padding(3);
            this.tabVendedores.Size = new System.Drawing.Size(973, 434);
            this.tabVendedores.TabIndex = 2;
            this.tabVendedores.Text = "Vendedores";
            this.tabVendedores.UseVisualStyleBackColor = true;
            // 
            // btnInforme3
            // 
            this.btnInforme3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInforme3.Location = new System.Drawing.Point(419, 40);
            this.btnInforme3.Name = "btnInforme3";
            this.btnInforme3.Size = new System.Drawing.Size(132, 30);
            this.btnInforme3.TabIndex = 27;
            this.btnInforme3.Text = "Generar Informe";
            this.btnInforme3.UseVisualStyleBackColor = true;
            this.btnInforme3.Click += new System.EventHandler(this.btnInforme3_Click);
            // 
            // grafico3
            // 
            this.grafico3.Location = new System.Drawing.Point(386, 81);
            this.grafico3.Name = "grafico3";
            this.grafico3.ScrollGrace = 0;
            this.grafico3.ScrollMaxX = 0;
            this.grafico3.ScrollMaxY = 0;
            this.grafico3.ScrollMaxY2 = 0;
            this.grafico3.ScrollMinX = 0;
            this.grafico3.ScrollMinY = 0;
            this.grafico3.ScrollMinY2 = 0;
            this.grafico3.Size = new System.Drawing.Size(582, 350);
            this.grafico3.TabIndex = 26;
            // 
            // grilla3
            // 
            this.grilla3.AllowUserToAddRows = false;
            this.grilla3.AllowUserToDeleteRows = false;
            this.grilla3.AllowUserToResizeColumns = false;
            this.grilla3.AllowUserToResizeRows = false;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grilla3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle35;
            this.grilla3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilla3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilla3.DefaultCellStyle = dataGridViewCellStyle36;
            this.grilla3.Location = new System.Drawing.Point(4, 82);
            this.grilla3.Name = "grilla3";
            this.grilla3.ReadOnly = true;
            this.grilla3.RowHeadersVisible = false;
            this.grilla3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla3.Size = new System.Drawing.Size(376, 349);
            this.grilla3.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Vendedor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Vendedor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Monto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // antiguedad
            // 
            this.antiguedad.Location = new System.Drawing.Point(291, 47);
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
            this.label9.Location = new System.Drawing.Point(157, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Antigüedad en años";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(352, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(268, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Productividad de los vendedores";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(645, 46);
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
            this.label11.Location = new System.Drawing.Point(609, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Año";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(463, 388);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "2006";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(626, 388);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "2007";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(803, 388);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "2008";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(460, 386);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 16);
            this.label15.TabIndex = 20;
            this.label15.Text = "2006";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(574, 386);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 16);
            this.label16.TabIndex = 21;
            this.label16.Text = "2007";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(701, 386);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 16);
            this.label17.TabIndex = 22;
            this.label17.Text = "2008";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(859, 386);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 16);
            this.label18.TabIndex = 23;
            this.label18.Text = "2009";
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.tabControl);
            this.Name = "frmInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informes - The Drinking Company";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tabControl.ResumeLayout(false);
            this.tabVenta.ResumeLayout(false);
            this.tabVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla1)).EndInit();
            this.tabRegiones.ResumeLayout(false);
            this.tabRegiones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla2)).EndInit();
            this.tabVendedores.ResumeLayout(false);
            this.tabVendedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla3)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabVendedores;
        private System.Windows.Forms.NumericUpDown antiguedad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView grilla1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private ZedGraph.ZedGraphControl grafico1;
        private ZedGraph.ZedGraphControl grafico2;
        private System.Windows.Forms.DataGridView grilla2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private ZedGraph.ZedGraphControl grafico3;
        private System.Windows.Forms.DataGridView grilla3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnInforme1;
        private System.Windows.Forms.Button btnInforme2;
        private System.Windows.Forms.Button btnInforme3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}

