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

            string consulta = "select distinct products.name_product Nombre from products";

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

        
        public static DataTable buscaRegiones()
        {
            DataTable dtRegiones = new DataTable();

            string consulta = "select regions.area Region from regions";

            using (SqlConnection con = new SqlConnection(Parametros.getConnectionString()))
            {
                SqlCommand cmdSelect = new SqlCommand(consulta, con);

                con.Open();

                SqlDataReader readerRegiones = cmdSelect.ExecuteReader();

                dtRegiones.Load(readerRegiones);

                con.Close();
            }

            return dtRegiones;


        }


        public static DataTable informeVentas(string producto, DateTime desde, DateTime hasta)
        {
            DataTable dtVentas = new DataTable();

            string consulta =
            @"drop temporary table if EXISTS vta; 
            create temporary table vta(select  ven.date, ven.product_id, ven.quantity 
            from dbo.billing ven where ven.date between @desde and @hasta);

            drop temporary table if EXISTS precios; 
            create temporary table precios(select max(pr.date) fecha, pr.product_id 
            from prices pr inner join vta on pr.product_id = vta.product_id where pr.date <= vta.date group by pr.product_id); 
            
            select venta.date, (prices.price * venta.quantity) from dbo.billing venta inner join precios on venta.product_id = precios.product_id 
            inner join products on precios.product_id = products.id_product 
            inner join prices on precios.product_id = prices.product_id and precios.date = prices.date 
            where products.name_product = @producto;";

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



        public static DataTable informeRegiones(string region, DateTime desde, DateTime hasta)
        {
            DataTable dtVentas = new DataTable();

            string consulta = 
            @"drop temporary table if EXISTS vta; 
            create temporary table vta(
            select  ven.date, ven.product_id, ven.quantity 
            from dbo.billing ven 
            where ven.date between @desde and @hasta);

            drop temporary table if EXISTS precios; 
            create temporary table precios(select max(pr.date) fecha, pr.product_id,vta.customer_id 
            from prices pr inner join vta on pr.product_id = vta.product_id 
            where pr.date <= vta.date group by pr.product_id);

            drop temporary table if exists ciudades;
            create temporary table ciudades(
            select regiones.city   
            from dbo.Regions regiones
            where regiones.area = @area)


            drop temporary table if exists clir;
            create temporary table clir(
            select clienter.customer_id
            from dbo.customer_r clienter inner join ciudades
            on clienter.city = ciudades.city)

            drop temporary table if exists cliw;
            create temporary table cliw(
            select clientew.customer_id
            from dbo.customer_w clientew inner join ciudades
            on clientew.city = ciudades.city)

            drop temporary table if exists clientes;
            create temporary table clientes(
            select customer_id
            from clir union cliw)

            select venta.date, (prices.price * venta.quantity) 
            from dbo.billing venta inner join precios on venta.product_id = precios.product_id 
	            inner join products on precios.product_id = products.id_product 
	            inner join prices on precios.product_id = prices.product_id and precios.date = prices.date 
	            inner join clientes on precios.customer_id = clientes.customer_id";


            using (SqlConnection con = new SqlConnection(Parametros.getConnectionString()))
            {
                SqlCommand cmdSelect = new SqlCommand(consulta, con);

                cmdSelect.Parameters.Add("@desde", SqlDbType.DateTime);

                cmdSelect.Parameters["@desde"].Value = desde;

                cmdSelect.Parameters.Add("@hasta", SqlDbType.DateTime);

                cmdSelect.Parameters["@hasta"].Value = hasta;

                cmdSelect.Parameters.Add("@area", SqlDbType.Int);

                cmdSelect.Parameters["@area"].Value = region;


                con.Open();

                SqlDataReader readerVentas = cmdSelect.ExecuteReader();

                dtVentas.Load(readerVentas);

                con.Close();
            }

            return dtVentas;
        }



        public static DataTable informeVendedores(int antiguedad)
        {
            DataTable dtVendedores = new DataTable();

            string consulta =
            @"drop temporary table if exists empleados;
            create temporary table empleados(
            select emp.employee_id, emp.full_name
            from dbo.employee emp 
            where datediff(year,emp.employment_date,'01/01/2009') = @antiguedad);

            drop temporary table if EXISTS vta; 
            create temporary table vta(
            select  ven.date, ven.product_id, ven.quantity 
            from dbo.billing ven 
            where datepart(month,ven.date) = 2009);

            drop temporary table if EXISTS precios; 
            create temporary table precios(
            select max(pr.date) fecha, pr.product_id, 
            from prices pr inner join vta on pr.product_id = vta.product_id 
            where pr.date <= vta.date group by pr.product_id);

            select empleados.full_name, (prices.price * venta.quantity)
            from dbo.billing venta inner join precios on venta.product_id = precios.product_id
            inner join empleados on venta.employee_id = empleados.employee_id 
            inner join prices on precios.product_id = prices.product_id and precios.date = prices.date;";


            using (SqlConnection con = new SqlConnection(Parametros.getConnectionString()))
            {
                SqlCommand cmdSelect = new SqlCommand(consulta, con);

                cmdSelect.Parameters.Add("@antiguedad", SqlDbType.Int);

                cmdSelect.Parameters["@antiguedad"].Value = antiguedad;
                                

                con.Open();

                SqlDataReader readerVendedores = cmdSelect.ExecuteReader();

                dtVendedores.Load(readerVendedores);

                con.Close();
            }

            return dtVendedores;
        }

        
    }
}
