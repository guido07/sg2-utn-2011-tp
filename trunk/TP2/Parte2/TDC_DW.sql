# SQL Manager 2005 Lite for MySQL 3.7.0.1
# ---------------------------------------
# Host     : localhost
# Port     : 3306
# Database : tdc_dw


SET FOREIGN_KEY_CHECKS=0;

DROP DATABASE IF EXISTS `tdc_dw`;

CREATE DATABASE `tdc_dw`
    CHARACTER SET 'latin1'
    COLLATE 'latin1_spanish_ci';

USE `tdc_dw`;

#
# Structure for the `antiguedad` table : 
#

DROP TABLE IF EXISTS `antiguedad`;

CREATE TABLE `antiguedad` (
  `anios` int(11) NOT NULL,
  PRIMARY KEY (`anios`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

#
# Structure for the `clientes` table : 
#

DROP TABLE IF EXISTS `clientes`;

CREATE TABLE `clientes` (
  `cod_cliente` int(11) NOT NULL,
  `nombre` varchar(150) COLLATE latin1_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`cod_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

#
# Structure for the `edadempleado` table : 
#

DROP TABLE IF EXISTS `edadempleado`;

CREATE TABLE `edadempleado` (
  `edad` int(11) NOT NULL,
  PRIMARY KEY (`edad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `edadesclientes` table : 
#

DROP TABLE IF EXISTS `edadesclientes`;

CREATE TABLE `edadesclientes` (
  `edad` int(11) NOT NULL,
  `grupo` varchar(20) NOT NULL,
  PRIMARY KEY (`edad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `empleado` table : 
#

DROP TABLE IF EXISTS `empleado`;

CREATE TABLE `empleado` (
  `cod_empleado` int(11) NOT NULL,
  `nombre` varchar(150) NOT NULL,
  `sexo` varchar(20) NOT NULL,
  PRIMARY KEY (`cod_empleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `productos` table : 
#

DROP TABLE IF EXISTS `productos`;

CREATE TABLE `productos` (
  `cod_producto` int(11) NOT NULL,
  `detalle` varchar(100) DEFAULT NULL,
  `linea` varchar(100) DEFAULT NULL,
  `presentacion` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`cod_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `regiones` table : 
#

DROP TABLE IF EXISTS `regiones`;

CREATE TABLE `regiones` (
  `zona` varchar(20) COLLATE latin1_spanish_ci NOT NULL,
  PRIMARY KEY (`zona`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

#
# Structure for the `ventas` table : 
#

DROP TABLE IF EXISTS `ventas`;

CREATE TABLE `ventas` (
  `cod_cliente` int(11) NOT NULL DEFAULT '0',
  `cod_producto` int(11) NOT NULL,
  `cod_empleado` int(11) NOT NULL,
  `cod_edad_empleado` int(11) NOT NULL,
  `cod_edad_cliente` int(11) NOT NULL,
  `cod_zona` varchar(20) COLLATE latin1_spanish_ci NOT NULL,
  `cod_tiempo` date NOT NULL,
  `cod_antiguedad` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `litros` float(9,3) DEFAULT NULL,
  `monto` float(9,3) DEFAULT NULL,
  PRIMARY KEY (`cod_cliente`,`cod_producto`,`cod_empleado`,`cod_edad_empleado`,`cod_edad_cliente`,`cod_zona`,`cod_tiempo`,`cod_antiguedad`),
  KEY `FK_productos_ventas` (`cod_producto`),
  KEY `FK_empleados_ventas` (`cod_empleado`),
  KEY `FK_regiones_ventas` (`cod_zona`),
  KEY `FK_edademp_ventas` (`cod_edad_empleado`),
  KEY `FK_edadcli_ventas` (`cod_edad_cliente`),
  KEY `FK_antiguedad_ventas` (`cod_antiguedad`),
  KEY `FK_clientes_ventas` (`cod_cliente`),
  CONSTRAINT `FK_antiguedad_ventas` FOREIGN KEY (`cod_antiguedad`) REFERENCES `antiguedad` (`anios`),
  CONSTRAINT `FK_clientes_ventas` FOREIGN KEY (`cod_cliente`) REFERENCES `clientes` (`cod_cliente`),
  CONSTRAINT `FK_edadcli_ventas` FOREIGN KEY (`cod_edad_cliente`) REFERENCES `edadesclientes` (`edad`),
  CONSTRAINT `FK_edademp_ventas` FOREIGN KEY (`cod_edad_empleado`) REFERENCES `edadempleado` (`edad`),
  CONSTRAINT `FK_empleados_ventas` FOREIGN KEY (`cod_empleado`) REFERENCES `empleado` (`cod_empleado`),
  CONSTRAINT `FK_productos_ventas` FOREIGN KEY (`cod_producto`) REFERENCES `productos` (`cod_producto`),
  CONSTRAINT `FK_regiones_ventas` FOREIGN KEY (`cod_zona`) REFERENCES `regiones` (`zona`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

