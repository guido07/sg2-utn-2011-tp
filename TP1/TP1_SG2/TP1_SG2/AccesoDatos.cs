using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TP1_SG2
{
    class AccesoDatos
    {

        public static DataTable buscaProductos()
        {
            DataTable dtProductos = new DataTable();

            string consulta = "select distinct productos.name_product Nombre from products";

            using (SqlConnection con = new SqlConnection(Parametros.getConnectionString()))
            {
                SqlCommand cmdSelect = new SqlCommand(consulta, con);

                con.Open();

                SqlDataReader readerProductos = cmdSelect.ExecuteReader();

                dtProductos.Load(readerProductos);

                con.Close();
            }

            return dtProductos;

        }

        public static DataTable informeVentas(string producto, DateTime desde, DateTime hasta)
        {
            DataTable dtVentas = new DataTable();

            string consulta = "drop temporary table if EXISTS vta; create temporary table vta(select  ven.date, ven.product_id, ven.quantity from dbo.billing ven where ven.date between @desde and @hasta); drop temporary table if EXISTS precios; create temporary table precios(select max(pr.date) fecha, pr.product_id from prices pr inner join vta on pr.product_id = vta.product_id where pr.date <= vta.date group by pr.product_id); select venta.date, prices.price from dbo.billing venta inner join precios on venta.product_id = precios.product_id inner join products on precios.product_id = products.id_product inner join prices on precios.product_id = prices.product_id and precios.date = prices.date where products.name_product = @producto;";

            using (SqlConnection con = new SqlConnection(Parametros.getConnectionString()))
            {
                SqlCommand cmdSelect = new SqlCommand(consulta, con);

                cmdSelect.Parameters.Add("@desde", SqlDbType.DateTime);

                cmdSelect.Parameters["@desde"].Value = desde;

                cmdSelect.Parameters.Add("@hasta", SqlDbType.DateTime);

                cmdSelect.Parameters["@hasta"].Value = hasta;

                cmdSelect.Parameters.Add("@id", SqlDbType.Int);

                cmdSelect.Parameters["@id"].Value = producto;


                con.Open();

                SqlDataReader readerVentas = cmdSelect.ExecuteReader();

                dtVentas.Load(readerVentas);

                con.Close();
            }

            return dtVentas;
        }
    }
}
