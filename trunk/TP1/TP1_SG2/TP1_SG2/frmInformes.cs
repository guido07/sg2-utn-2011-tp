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
        public DataTable regiones;
        public DataTable dtVentas;
        public DataTable dtRegiones;
        public DataTable dtVendedores;
        public CultureInfo cultura = new CultureInfo("es-AR");
        public double max = 0, min = double.MaxValue;

        public frmInformes()
        {
            InitializeComponent();

            //INICIALIZO DATATABLE INTERMEDIO DE VENTAS
            ventas = new DataTable();
            ventas.Columns.Add("Fecha");
            ventas.Columns.Add("Monto");


            //INICIALIZO DATATABLE INTERMEDIO DE regiones
            regiones = new DataTable();
            regiones.Columns.Add("Fecha");
            regiones.Columns.Add("Monto");
            
               


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
            inicializarSegundaPestaña();
            inicializarTercerPestaña();
            
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

        private void btnInforme2_Click(object sender, EventArgs e)
        {
            resetearMaxMin();
            

            regiones = AccesoDatos.informeRegiones(cbRegion.SelectedValue.ToString(), DateTime.Parse("01/01/2006"), DateTime.Parse("31/12/2008"));


            foreach (DataRow dr in regiones.Rows)
            {
                int month = int.Parse(dr["Fecha"].ToString().Substring(3, 2))-1;

                string mes = cultura.TextInfo.ToTitleCase(cultura.DateTimeFormat.MonthNames[month]);
                
                int anio = Convert.ToInt16(DateTime.Parse(dr["Fecha"].ToString()).Year);
                              


                foreach (DataRow fila in dtRegiones.Rows)
                {
                    if (Convert.ToInt16(fila["Año"]) == anio)
                    {                                                               //BUSCA EL AÑO Y MES DENTRO DEL DATATABLE Y AL MONTO LE ACUMULA EL MONTO DE ESTA VENTA
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
            graficar2();
        }


        private void graficar2()
        {

            grafico2.GraphPane = new GraphPane(grafico2.GraphPane.Rect, "", "t", "$");

            GraphPane myPane = grafico2.GraphPane;

            // Set the Titles

            myPane.Title.Text = "";
            myPane.XAxis.Title.Text = "t";
            myPane.YAxis.Title.Text = "$";



            double x, y;

            PointPairList list = new PointPairList();


            int i = 1;
            for (; i <= 36; i++)                                    
            {
                x = (double)i;
                y = Convert.ToDouble(dtRegiones.Rows[i - 1]["Monto"]);        //USAMOS i-1 PARA MOSTRAR MEJOR LOS BIMESTRES

                list.Add(x, y);

            }



            LineItem myCurve = myPane.AddCurve("", list, Color.SteelBlue, SymbolType.Circle);
            myCurve.Line.Width = 3;
            myCurve.Symbol.Fill = new Fill(Color.LightBlue);
            myCurve.Symbol.Size = 10;

                       
            myPane.XAxis.Scale.Max = i;
            myPane.YAxis.Scale.Max = max * 1.2;

            grafico2.AxisChange();
            grafico2.Refresh();

        }



        private void btnInforme3_Click(object sender, EventArgs e)
        {
            resetearMaxMin();
            
            dtVendedores = AccesoDatos.informeVendedores(Convert.ToInt16(antiguedad.Value));

            if (dtVendedores.Rows.Count == 0)
            {
                string mensaje = "No hay empleados con " + antiguedad.Value.ToString() + " años de antigüedad";
                MessageBox.Show(mensaje);

            }
            else
            {          


                grilla3.DataSource = dtVendedores;

                foreach (DataRow fila in dtVendedores.Rows)
                {
                    if (Convert.ToDouble(fila["Monto"]) > max)
                        max = Convert.ToDouble(fila["Monto"]);
                    if (Convert.ToDouble(fila["Monto"]) < min)
                        min = Convert.ToDouble(fila["Monto"]);
                }


                graficar3();
            }

            

        }



        private void graficar3()
        {           

            grafico3.GraphPane = new GraphPane(grafico3.GraphPane.Rect, "", "t", "$");

            GraphPane myPane = grafico3.GraphPane;

            // Set the Titles

            myPane.Title.Text = "";
            myPane.XAxis.Title.Text = "t";
            myPane.YAxis.Title.Text = "$";



            double x, y;

            PointPairList list = new PointPairList();


            int i = 1;
            for (; i <= dtVendedores.Rows.Count; i++)                                    
            {
                x = (double)i;
                y = Convert.ToDouble(dtVendedores.Rows[i - 1]["Monto"]);        

                list.Add(x, y);

            }



            BarItem myCurve = myPane.AddBar("", list, Color.SteelBlue);
                        
            myPane.XAxis.Scale.Max = i;
            myPane.YAxis.Scale.Max = max * 1.2;

            grafico3.AxisChange();
            grafico3.Refresh();

        }









    }
}