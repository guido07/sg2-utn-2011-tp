using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace TP1_SG2
{
    public partial class frmInformes : Form
    {
        public frmInformes()
        {
            InitializeComponent();
        }

        private void Perfomace_Ventas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

            cbTipoBebida.DataSource = AccesoDatos.buscaProductos();            

        }

        private void cbTipoBebida_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable ventas = AccesoDatos.informeVentas(cbTipoBebida.SelectedValue.ToString(), DateTime.Parse(txtFechaDesde.Text), DateTime.Parse(txtFechaHasta.Text));

            ReportDataSource rds = new ReportDataSource();
            rds.Value = ventas;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();

        }

        

    }
}