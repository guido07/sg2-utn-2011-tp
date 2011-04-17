using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using System.Globalization;


namespace TP1_SG2
{
    public partial class frmInformes : Form
    {
        public DataTable dtVentas;
        public DataTable dtRegiones;
        public DataTable dtVendedores;
        public CultureInfo cultura = new CultureInfo("es-AR");
        public double max = 0, min = double.MaxValue;

        public frmInformes()
        {
            InitializeComponent();

            //INICIALIZO DATATABLE PARA EL PRIMER INFORME
            dtVentas = new DataTable();
            dtVentas.Columns.Add("Año");
            dtVentas.Columns.Add("Bimestre");
            dtVentas.Columns.Add("Monto");           
            
            grilla1.DataSource = dtVentas;


            //INICIALIZO DATATABLE PARA EL SEGUNDO INFORME
            dtRegiones = new DataTable();
            dtRegiones.Columns.Add("Año");
            dtRegiones.Columns.Add("Mes");
            dtRegiones.Columns.Add("Monto");

            grilla2.DataSource = dtRegiones;


            //INICIALIZO DATATABLE PARA EL TERCER INFORME
            dtVendedores = new DataTable();
            dtVendedores.Columns.Add("Vendedor");
            dtVendedores.Columns.Add("Monto");

            grilla3.DataSource = dtVendedores;

        }

        
        private void Form_Load(object sender, EventArgs e)
        {
            inicializarPrimerPestaña();
            
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabVenta)
                inicializarPrimerPestaña();

            if (tabControl.SelectedTab == tabRegiones)
                inicializarSegundaPestaña();
                       
            if (tabControl.SelectedTab == tabVendedores)
                inicializarTercerPestaña();

        }



        private void inicializarPrimerPestaña()
        {
            dtVentas.Clear();

            cbTipoBebida.DataSource = AccesoDatos.buscaProductos();

            for (int anio = 2006; anio <= 2009; anio++)         //inicializo el Datatable con todos los años y bimestres entre las 2 fechas
            {
                int cont = 0;

                for (int bim = 1; bim < 7; bim++)
                {
                    DataRow fila = dtVentas.NewRow();
                    fila["Año"] = anio;
                    fila["Bimestre"] = bim;
                    fila["Monto"] = 0;

                    dtVentas.Rows.Add(fila);

                    cont++;
                }

            }
            dtVentas.Rows[dtVentas.Rows.Count - 1].Delete();
            dtVentas.Rows[dtVentas.Rows.Count - 1].Delete();                       

        }


        private void inicializarSegundaPestaña()
        {
            dtRegiones.Clear();

            cbRegion.DataSource = AccesoDatos.buscaRegiones();


            for (int anio = 2006; anio <= 2008; anio++)         //inicializo el Datatable con todos los años y bimestres entre las 2 fechas
            {
                int cont = 0;

                for (int mes = 0; mes < 12; mes++)
                {
                    DataRow fila = dtRegiones.NewRow();
                    fila["Año"] = anio;
                    fila["Mes"] = cultura.TextInfo.ToTitleCase(cultura.DateTimeFormat.MonthNames[mes]);     //Busca el mes en la instancia cultura de la clase CultureInfo
                    fila["Monto"] = 0;                                                                      // y la trae con mayúscula en la primer letra

                    dtRegiones.Rows.Add(fila);

                    cont++;
                }

            }

        }


        private void inicializarTercerPestaña()
        {
            dtVendedores.Clear();

        }

        private void resetearMaxMin()
        {
            min = double.MaxValue;
            max = 0;
        }
        

        private void cbTipoBebida_SelectedValueChanged(object sender, EventArgs e)
        {
            resetearMaxMin();            

            DataTable ventas = AccesoDatos.informeVentas(cbTipoBebida.SelectedValue.ToString(), DateTime.Parse(txtFechaDesde.Text), DateTime.Parse(txtFechaHasta.Text));

                        
            foreach (DataRow dr in ventas.Rows)
            {
                int anio = Convert.ToInt16(DateTime.Parse(dr["Fecha"].ToString()).Year);
                double fec = DateTime.Parse(dr["Fecha"].ToString()).Month / 2;                  //calcula bimestre segun la fecha de venta
                int bimestre = Convert.ToInt16(Math.Round(fec, MidpointRounding.ToEven));
                                          

                foreach (DataRow fila in dtVentas.Rows)
                {
                    if (Convert.ToInt16(fila["Año"]) == anio)
                    {                                                               //BUSCA EL AÑO Y BIMESTRE DENTRO DEL DATATABLE Y AL MONTO LE ACUMULA EL MONTO DE ESTA VENTA
                        if (Convert.ToInt16(fila["Bimestre"]) == bimestre)
                        {
                            double monto = Convert.ToDouble(fila["Monto"]) + Convert.ToDouble(dr["Monto"]);

                            fila["Monto"] = monto.ToString();

                            if (Convert.ToDouble(fila["Monto"]) > max)
                                max = Convert.ToDouble(fila["Monto"]);
                            if (Convert.ToDouble(fila["Monto"]) < min)
                                min = Convert.ToDouble(fila["Monto"]);
                        }                        
                    }
                }
       
            }





        }


        private void graficar1()
        {

            grafico1.GraphPane = new GraphPane(grafico1.GraphPane.Rect, "", "t", "$");

            GraphPane myPane = grafico1.GraphPane;

            // Set the Titles

            myPane.Title.Text = "";
            myPane.XAxis.Title.Text = "t";
            myPane.YAxis.Title.Text = "$";

            // Make up some data arrays based on the Sine function

            double x, y;

            PointPairList list = new PointPairList();


            int i = 0;
            for( ; i < 5; i++)
            {
                x = (double)i;
                y = Convert.ToDouble(dtVentas.Rows[i]["Monto"]);

                list.Add(x, y);

            }

            LineItem myCurve = myPane.AddCurve("",
                  list, Color.Blue, SymbolType.None);
            myCurve.Line.Width = 3;

            

            myPane.XAxis.Scale.Max = i;
            myPane.YAxis.Scale.Max = max;
            grafico1.AxisChange();
            grafico1.Refresh();




        }

        private void cbRegion_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable ventas = AccesoDatos.informeRegiones(cbRegion.SelectedValue.ToString(), DateTime.Parse("01/01/2006"), DateTime.Parse("31/12/2008"));
        }


        


        



    }
}