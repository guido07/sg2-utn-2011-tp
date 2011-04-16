using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;


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
                    fila["Monto"] = 0;

                    dtVentas.Rows.Add(fila);

                    cont++;
                }

            }
            dtVentas.Rows[dtVentas.Rows.Count - 1].Delete();
            dtVentas.Rows[dtVentas.Rows.Count - 1].Delete();

        }
        

        private void cbTipoBebida_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable ventas = AccesoDatos.informeVentas(cbTipoBebida.SelectedValue.ToString(), DateTime.Parse(txtFechaDesde.Text), DateTime.Parse(txtFechaHasta.Text));

                   
            //for (int i = 0; i < ventas.Rows.Count; i++)
            foreach (DataRow dr in ventas.Rows)
            {
                int anio = Convert.ToInt16(DateTime.Parse(dr["Fecha"].ToString()).Year);
                double fec = DateTime.Parse(dr["Fecha"].ToString()).Month / 2;                  //calcula bimestre segun la fecha de venta
                int bimestre = Convert.ToInt16(Math.Round(fec, MidpointRounding.ToEven));
                   
                
                //BUSCAR EL AÑO Y BIMESTRE DENTRO DEL DATATABLE Y AL MONTO SUMARLE EL MONTO DE ESTA VENTA (vamos acumulando)

                foreach (DataRow fila in dtVentas.Rows)
                {
                    if (Convert.ToInt16(fila["Año"]) == anio)
                    {
                        if (Convert.ToInt16(fila["Bimestre"]) == bimestre)
                          fila["Monto"] += dr["Monto"].ToString();
                    }
                }
       
            }





        }


        private void graficar()
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
                    
                            

                    for (double i = 0; i < 5 ; i = i + 0.001)
                    {
                        x = (double)i;
                        y = 1;
                        
                        list.Add(x, y);                      

                    }
                          
                        LineItem myCurve = myPane.AddCurve("",
                              list, Color.Blue, SymbolType.None);
                        myCurve.Line.Width = 3;
                    
                    //BUSCAR EL MÁXIMO "Y" PARA DETERMINAR LA ALTURA DEL GRAFICO

          //          myPane.XAxis.Scale.Max = ;
          //          myPane.YAxis.Scale.Max = ;
                    grafico1.AxisChange();
                    grafico1.Refresh();
               

            

        }



    }
}