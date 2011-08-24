select 

	tot.idProducto, f.fecha, z.idZona, f.idCliente, f.idEmpleado,

	(YEAR(f.fecha)-YEAR(date(cli.fechaNacimiento))) - (right(cast(date(f.fecha) as char(10)),5) < right(cast(date(cli.fechaNacimiento) as char(10)),5)) as edadCliente,

	(YEAR(f.fecha)-YEAR(date(emp.fechaNacimiento))) - (right(cast(date(f.fecha) as char(10)),5) < right(cast(date(emp.fechaNacimiento) as char(10)),5)) as edadEmpleado,

	(YEAR(f.fecha)-YEAR(emp.fechaIngreso)) - (RIGHT(f.fecha,5)<RIGHT(emp.fechaIngreso,5)) as antEmpleado,

	(prod.presentacion*tot.cantidad) as cantLitros, tot.cantidad as cantProdVendidos,

	(1 - (de.descuento/100))* tot.totalLinea as montoVenta

from 

totalLineaFactura tot

	inner join

	facturas f on f.idFactura = tot.idFactura

	inner join 

	descuento_a_aplicar de on tot.idFactura = de.idFactura

	inner join

	clientes cli on f.idCliente = cli.idCliente

	inner join

	empleados emp on f.idEmpleado = emp.idEmpleado

	inner join

	productos_presentacion prod on tot.idProducto = prod.idProducto

	inner join

	zona z on f.zona like z.zona

;
