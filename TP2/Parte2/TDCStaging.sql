# SQL Manager 2005 Lite for MySQL 3.7.0.1
# ---------------------------------------
# Host     : localhost
# Port     : 3306
# Database : tdcstaging


SET FOREIGN_KEY_CHECKS=0;

DROP DATABASE IF EXISTS `tdcstaging`;

CREATE DATABASE `tdcstaging`
    CHARACTER SET 'latin1'
    COLLATE 'latin1_swedish_ci';

USE `tdcstaging`;

#
# Structure for the `descuentos` table : 
#

DROP TABLE IF EXISTS `descuentos`;

CREATE TABLE `descuentos` (
  `cod_descuento` int(11) NOT NULL,
  `fechadesde` date DEFAULT NULL,
  `fechahasta` date DEFAULT NULL,
  `total` float(9,3) DEFAULT NULL,
  `porcentaje` float(9,3) DEFAULT NULL,
  PRIMARY KEY (`cod_descuento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `detalle_ventas` table : 
#

DROP TABLE IF EXISTS `detalle_ventas`;

CREATE TABLE `detalle_ventas` (
  `cod_venta` int(10) NOT NULL,
  `cod_producto` smallint(5) NOT NULL,
  `cantidad` smallint(5) DEFAULT NULL,
  PRIMARY KEY (`cod_venta`,`cod_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `empleados` table : 
#

DROP TABLE IF EXISTS `empleados`;

CREATE TABLE `empleados` (
  `cod_empleado` int(11) NOT NULL,
  `nombreyapellido` varchar(150) DEFAULT NULL,
  `sexo` varchar(10) DEFAULT NULL,
  `categoria` varchar(100) DEFAULT NULL,
  `niveleducacion` varchar(100) DEFAULT NULL,
  `fechaingreso` date DEFAULT NULL,
  `fechanacimiento` date DEFAULT NULL,
  PRIMARY KEY (`cod_empleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `feriados` table : 
#

DROP TABLE IF EXISTS `feriados`;

CREATE TABLE `feriados` (
  `fecha` date NOT NULL,
  `descripcion` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`fecha`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `mayoristas` table : 
#

DROP TABLE IF EXISTS `mayoristas`;

CREATE TABLE `mayoristas` (
  `nombre` varchar(150) DEFAULT NULL,
  `cod_cliente` int(11) NOT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  PRIMARY KEY (`cod_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `minoristas` table : 
#

DROP TABLE IF EXISTS `minoristas`;

CREATE TABLE `minoristas` (
  `cod_cliente` int(11) NOT NULL,
  `nombre` varchar(150) DEFAULT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  PRIMARY KEY (`cod_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `precios` table : 
#

DROP TABLE IF EXISTS `precios`;

CREATE TABLE `precios` (
  `cod_producto` int(11) NOT NULL,
  `fechadesde` date DEFAULT NULL,
  `precio` float(9,3) DEFAULT NULL,
  KEY `cod_producto` (`cod_producto`,`fechadesde`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `productos` table : 
#

DROP TABLE IF EXISTS `productos`;

CREATE TABLE `productos` (
  `cod_producto` int(10) NOT NULL,
  `descripcion` varchar(150) DEFAULT NULL,
  `presentacion` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`cod_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `regiones` table : 
#

DROP TABLE IF EXISTS `regiones`;

CREATE TABLE `regiones` (
  `cod_postal` int(11) NOT NULL,
  `estado` varchar(20) DEFAULT NULL,
  `region` varchar(20) DEFAULT NULL,
  `ciudad` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`cod_postal`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `sadescuentos` table : 
#

DROP TABLE IF EXISTS `sadescuentos`;

CREATE TABLE `sadescuentos` (
  `cod_venta` int(11) NOT NULL,
  `porc_descuento` float(9,3) DEFAULT NULL,
  PRIMARY KEY (`cod_venta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `saventas` table : 
#

DROP TABLE IF EXISTS `saventas`;

CREATE TABLE `saventas` (
  `cod_venta` int(11) NOT NULL,
  `cod_producto` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `litros` float(9,3) DEFAULT NULL,
  PRIMARY KEY (`cod_venta`,`cod_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `totales` table : 
#

DROP TABLE IF EXISTS `totales`;

CREATE TABLE `totales` (
  `cod_venta` int(11) NOT NULL,
  `monto_total` float(9,3) DEFAULT NULL,
  PRIMARY KEY (`cod_venta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `totalventa` table : 
#

DROP TABLE IF EXISTS `totalventa`;

CREATE TABLE `totalventa` (
  `cod_venta` int(11) NOT NULL,
  `cod_producto` int(11) NOT NULL,
  `total` float(9,3) DEFAULT NULL,
  PRIMARY KEY (`cod_venta`,`cod_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `ventas` table : 
#

DROP TABLE IF EXISTS `ventas`;

CREATE TABLE `ventas` (
  `cod_venta` int(10) NOT NULL,
  `region` varchar(45) DEFAULT NULL,
  `cod_sucursal` int(10) DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `cod_cliente` int(11) DEFAULT NULL,
  `cod_empleado` int(11) DEFAULT NULL,
  PRIMARY KEY (`cod_venta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

