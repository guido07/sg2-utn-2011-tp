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

            string consulta = "select distinct name_product Producto from dbo.products";

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

            string consulta = "select distinct regions.area Region from dbo.regions";

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
            @"
CREATE TABLE #vta (date smalldatetime, product_id int, quantity int)
INSERT INTO #vta SELECT date, product_id, quantity  
	FROM dbo.billing WHERE date between @desde and @hasta
 

CREATE TABLE #precios (date datetime, product_id int)
INSERT INTO #precios SELECT max(pr.date), pr.product_id  
	FROM dbo.prices pr inner join #vta on pr.product_id = #vta.product_id where pr.date <= #vta.date group by pr.product_id

            
select #vta.date Fecha, (prices.price * #vta.quantity) Monto from #vta inner join #precios on #vta.product_id = #precios.product_id
inner join dbo.products on #precios.product_id = dbo.products.id_product 
inner join dbo.prices on #precios.product_id = dbo.prices.product_id and #precios.date = dbo.prices.date 
where dbo.products.name_product = @producto;";

            using (SqlConnection con = new SqlConnection(Parametros.getConnectionString()))
            {
                SqlCommand cmdSelect = new SqlCommand(consulta, con);

                cmdSelect.Parameters.Add("@desde", SqlDbType.SmallDateTime);

                cmdSelect.Parameters["@desde"].Value = desde;

                cmdSelect.Parameters.Add("@hasta", SqlDbType.SmallDateTime);

                cmdSelect.Parameters["@hasta"].Value = hasta;

                cmdSelect.Parameters.Add("@producto", SqlDbType.VarChar);

                cmdSelect.Parameters["@producto"].Value = producto;


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
            @"CREATE TABLE #vta(date smallDateTime, product_id int, quantity int)
            INSERT INTO #vta
            SELECT  ven.date, ven.product_id, ven.quantity 
            from dbo.billing ven 
            where ven.date between @desde and @hasta
            and ven.region = @region 
           
            CREATE TABLE #precios(date DateTime, product_id int)
            INSERT INTO #precios
            SELECT  max(pr.date) , pr.product_id 
            from prices pr inner join #vta on pr.product_id = #vta.product_id 
            where pr.date <= #vta.date group by pr.product_id
                          

            select #vta.date Fecha, (prices.price * #vta.quantity) Monto
            from #vta inner join #precios on #vta.product_id = #precios.product_id 
	              inner join prices on #precios.product_id = prices.product_id and #precios.date = prices.date";


            using (SqlConnection con = new SqlConnection(Parametros.getConnectionString()))
            {
                SqlCommand cmdSelect = new SqlCommand(consulta, con);

                cmdSelect.Parameters.Add("@desde", SqlDbType.SmallDateTime);

                cmdSelect.Parameters["@desde"].Value = desde;

                cmdSelect.Parameters.Add("@hasta", SqlDbType.SmallDateTime);

                cmdSelect.Parameters["@hasta"].Value = hasta;

                cmdSelect.Parameters.Add("@region", SqlDbType.VarChar);

                cmdSelect.Parameters["@region"].Value = region;


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

 /*           string consulta =
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
*/


            string consulta =
            @"create table #empleados( employee_id int, name_employ varchar(50))
            insert into #empleados 
            select emp.employee_id, emp.full_name
            from dbo.employee emp 
            where datediff(year,emp.employment_date,'01/01/2009') = @antiguedad;
            
            create table #vta(date smalldatetime, prod_id int, qua int, emp int)
            insert into #vta
            select ven.date, ven.product_id, ven.quantity, ven.employee_id 
            from dbo.billing ven 
            where datepart(year,ven.date) = '2009';
            
            create table #precios(date DateTime, prod_id int)
            insert into #precios
            select max(pr.date) fecha, pr.product_id
            from dbo.Prices pr inner join dbo.Billing vta on pr.product_id = vta.product_id 
            where pr.date <= vta.date group by pr.product_id;

            select #empleados.name_employ as Vendedor, sum(dbo.prices.price * #vta.qua) as Monto
            from #vta inner join #precios on #vta.prod_id = #precios.prod_id
            inner join #empleados on #vta.emp = #empleados.employee_id 
            inner join dbo.prices on #precios.prod_id = dbo.prices.product_id and #precios.date = dbo.prices.date
            group by #empleados.name_employ";

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
