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
        public DataTable dtVentas;

        public frmInformes()
        {
            InitializeComponent();

            dtVentas = new DataTable();
            dtVentas.Columns.Add("Año");
            dtVentas.Columns.Add("Bimestre");
            dtVentas.Columns.Add("Monto");

            
            
            grilla1.DataSource = dtVentas;

        }

        
        private void Perfomace_Ventas_Load(object sender, EventArgs e)
        {                    

            cbTipoBebida.DataSource = AccesoDatos.buscaProductos();


            for (int anio = 2006; anio <= 2009; anio++)         //inicializo el Datatable con todos los años y bimestres entre las 2 fechas
            {
                int cont = 0;

                for (int bim = 1; bim < 7; bim++)
                {
                    DataRow fila = dtVentas.NewRow();
                    fila["Año"] = anio;
                    fila["Bimestre"] = bim;

                    dtVentas.Rows.Add(fila);

                    cont++;
                }

            }

        }
        

        private void cbTipoBebida_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable ventas = AccesoDatos.informeVentas(cbTipoBebida.SelectedValue.ToString(), DateTime.Parse(txtFechaDesde.Text), DateTime.Parse(txtFechaHasta.Text));

                   
            for (int i = 0; i < ventas.Rows.Count; i++)
            {                
                double fec = DateTime.Parse(ventas.Rows[i]["Fecha"].ToString()).Month / 2;
                double bimestre = Math.Round(fec, MidpointRounding.ToEven);   //calcula bimestre segun la fecha de venta
                
                //BUSCAR EL AÑO Y BIMESTRE DENTRO DEL DATATABLE Y AL MONTO SUMARLE EL MONTO DE ESTA VENTA (vamos acumulando)
            
            }


        }



    }
}