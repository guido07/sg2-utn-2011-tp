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
        public DataTable ventas;
        public DataTable dtVentas;
        public DataTable dtRegiones;
        public DataTable dtVendedores;
        public CultureInfo cultura = new CultureInfo("es-AR");
        public double max = 0, min = double.MaxValue;

        public frmInformes()
        {
            InitializeComponent();

            //INICIALIZO DATATABLE INTERMEDIO
            ventas = new DataTable();
            ventas.Columns.Add("Fecha");
            ventas.Columns.Add("Monto");


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
        

        private void inicializarPrimerPestaña()
        {
            dtVentas.Clear();

            cbTipoBebida.DataSource = AccesoDatos.buscaProductos();
            cbTipoBebida.DisplayMember = "Producto";
            cbTipoBebida.ValueMember = "Producto";
            
            
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
            cbRegion.DisplayMember = "Region";
            cbRegion.ValueMember = "Region";
      

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
        

        //ELIJO EL TIPO DE BEBIDA PARA EL PRIMER INFORME

        


        private void graficar1()
        {

            grafico1.GraphPane = new GraphPane(grafico1.GraphPane.Rect, "", "t", "$");

            GraphPane myPane = grafico1.GraphPane;

            // Set the Titles

            myPane.Title.Text = "";
            myPane.XAxis.Title.Text = "t";
            myPane.YAxis.Title.Text = "$";

            

            double x, y;

            PointPairList list = new PointPairList();


            int i = 1;
            for( ; i <= 22; i++)                                    //SON 22 BIMESTRES
            {
                x = (double)i;
                y = Convert.ToDouble(dtVentas.Rows[i - 1]["Monto"]);        //USAMOS i-1 PARA MOSTRAR MEJOR LOS BIMESTRES

                list.Add(x, y);

            }
            
            

            LineItem myCurve = myPane.AddCurve("", list, Color.SteelBlue, SymbolType.Circle);
            myCurve.Line.Width = 3;
            myCurve.Symbol.Fill = new Fill(Color.LightBlue);
            myCurve.Symbol.Size = 10;


            
            myPane.XAxis.Scale.Max = i;
            myPane.YAxis.Scale.Max = max * 1.2;
            
            grafico1.AxisChange();
            grafico1.Refresh();
        
        }


        //ELIJO LA REGION PARA EL SEGUNDO INFORME

        private void cbRegion_SelectedValueChanged(object sender, EventArgs e)
        {
            resetearMaxMin();

            ventas = AccesoDatos.informeRegiones(cbRegion.SelectedValue.ToString(), DateTime.Parse("01/01/2006"), DateTime.Parse("31/12/2008"));


            foreach (DataRow dr in ventas.Rows)
            {
                int anio = Convert.ToInt16(DateTime.Parse(dr["Fecha"].ToString()).Year);
                string mes = cultura.TextInfo.ToTitleCase(cultura.DateTimeFormat.MonthNames[Convert.ToInt16(dr["Fecha"])]);                 


                foreach (DataRow fila in dtRegiones.Rows)
                {
                    if (Convert.ToInt16(fila["Año"]) == anio)
                    {                                                               //BUSCA EL AÑO Y BIMESTRE DENTRO DEL DATATABLE Y AL MONTO LE ACUMULA EL MONTO DE ESTA VENTA
                        if (fila["Mes"].ToString() == mes)
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

        private void btnInforme1_Click(object sender, EventArgs e)
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
                    {                                                              //BUSCA EL AÑO Y BIMESTRE DENTRO DEL DATATABLE Y AL MONTO LE ACUMULA EL MONTO DE ESTA VENTA
                      
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

            graficar1();
        }

       
               



    }
}