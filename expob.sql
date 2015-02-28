/*
Navicat MySQL Data Transfer

Source Server         : local
Source Server Version : 50617
Source Host           : 127.0.0.1:3306
Source Database       : expob

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2015-01-08 11:43:12
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for clientes
-- ----------------------------
DROP TABLE IF EXISTS `clientes`;
CREATE TABLE `clientes` (
  `codcliente` int(255) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) DEFAULT NULL,
  `direccion` varchar(255) DEFAULT NULL,
  `telefono` varchar(11) DEFAULT NULL,
  PRIMARY KEY (`codcliente`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of clientes
-- ----------------------------
INSERT INTO `clientes` VALUES ('1', 'Carlos', 'col', '4564');
INSERT INTO `clientes` VALUES ('2', 'ljl', 'fhg', '64745');
INSERT INTO `clientes` VALUES ('3', 'dfg', 'fwef', 'ererg');
INSERT INTO `clientes` VALUES ('4', 'Juan Jose Lazo', 'camalote 4 esquina', '9806-1723');
INSERT INTO `clientes` VALUES ('5', 'Aida Contreras', 'Residencial Las Acasias', '9749-4802');
INSERT INTO `clientes` VALUES ('6', 'benigna megia', 'campo monterey', '96494504');
INSERT INTO `clientes` VALUES ('7', 'benigna megia', 'campo monterey', '96494504');
INSERT INTO `clientes` VALUES ('8', 'kevin pineda', 'aldea miler', '97983609');
INSERT INTO `clientes` VALUES ('9', 'ANTONIA', 'COL SAN JORGE ', '9733-1276');
INSERT INTO `clientes` VALUES ('10', 'CARLOS VIDEA', 'COL. JASMINES', '95364490');
INSERT INTO `clientes` VALUES ('11', 'FERMIN SUNIGA', 'PAJUILES', '98818390');
INSERT INTO `clientes` VALUES ('12', 'yajaira rodrigues', 'colonia suazo cordoba casa #32 de la panaderia 2 cuadras a mano izquierda cor rosada', '88856120');
INSERT INTO `clientes` VALUES ('13', 'deisi flores', 'col. corocol', '99652705');
INSERT INTO `clientes` VALUES ('14', 'Jose Sanchez', 'col. los jasmines', '98844481');
INSERT INTO `clientes` VALUES ('15', 'Digna Tome', 'Col. Corocol', '000000000');
INSERT INTO `clientes` VALUES ('16', 'Elsilia', 'Barrio Los Angeles', '2647-1463');
INSERT INTO `clientes` VALUES ('17', 'Cliente1', 'El Progreso', '0000-0000');
INSERT INTO `clientes` VALUES ('18', 'c', null, null);
INSERT INTO `clientes` VALUES ('19', 'Chris', 'col melgar', '9594-4418');
INSERT INTO `clientes` VALUES ('20', 'Ceramicas Terranova', 'Barrio El centro', '9922-5294');

-- ----------------------------
-- Table structure for cotizacion
-- ----------------------------
DROP TABLE IF EXISTS `cotizacion`;
CREATE TABLE `cotizacion` (
  `codfactura` int(255) unsigned NOT NULL AUTO_INCREMENT,
  `codcliente` int(100) DEFAULT NULL,
  `vendedor` varchar(255) DEFAULT NULL,
  `fecha` datetime NOT NULL,
  `descuento` decimal(10,2) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`codfactura`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of cotizacion
-- ----------------------------

-- ----------------------------
-- Table structure for detallecotizacion
-- ----------------------------
DROP TABLE IF EXISTS `detallecotizacion`;
CREATE TABLE `detallecotizacion` (
  `coddetalle` int(255) NOT NULL AUTO_INCREMENT,
  `codfactura` int(11) NOT NULL,
  `codproducto` int(255) DEFAULT NULL,
  `unidad` varchar(255) DEFAULT NULL,
  `precio` decimal(65,2) DEFAULT NULL,
  `cantidad` decimal(11,2) DEFAULT NULL,
  `valor` decimal(65,2) DEFAULT NULL,
  PRIMARY KEY (`coddetalle`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of detallecotizacion
-- ----------------------------

-- ----------------------------
-- Table structure for detallefactura
-- ----------------------------
DROP TABLE IF EXISTS `detallefactura`;
CREATE TABLE `detallefactura` (
  `coddetalle` int(255) NOT NULL AUTO_INCREMENT,
  `codfactura` int(11) NOT NULL,
  `codproducto` int(255) DEFAULT NULL,
  `unidad` varchar(255) DEFAULT NULL,
  `precio` decimal(65,2) DEFAULT NULL,
  `cantidad` decimal(11,2) DEFAULT NULL,
  `valor` decimal(65,2) DEFAULT NULL,
  PRIMARY KEY (`coddetalle`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of detallefactura
-- ----------------------------
INSERT INTO `detallefactura` VALUES ('3', '2', '2', null, '7.00', '8.00', null);
INSERT INTO `detallefactura` VALUES ('4', '2', '5', null, '2.00', '9.00', null);
INSERT INTO `detallefactura` VALUES ('5', '3', '1', null, '5.00', '4.00', null);
INSERT INTO `detallefactura` VALUES ('6', '3', '5', null, '7.00', '6.00', null);
INSERT INTO `detallefactura` VALUES ('7', '4', '5', null, '2.00', '3.00', null);
INSERT INTO `detallefactura` VALUES ('8', '4', '1', null, '2.00', '4.00', null);
INSERT INTO `detallefactura` VALUES ('9', '5', '1', null, '4.00', '3.00', null);
INSERT INTO `detallefactura` VALUES ('10', '5', '5', null, '2.00', '2.00', null);
INSERT INTO `detallefactura` VALUES ('11', '6', '2', null, '16.00', '2.00', null);
INSERT INTO `detallefactura` VALUES ('12', '6', '1', null, '15.00', '3.00', null);
INSERT INTO `detallefactura` VALUES ('13', '7', '2', null, '16.00', '3.00', null);
INSERT INTO `detallefactura` VALUES ('14', '7', '1', null, '15.00', '5.00', null);
INSERT INTO `detallefactura` VALUES ('15', '9', '12', null, '1366.00', '7.00', null);
INSERT INTO `detallefactura` VALUES ('16', '9', '8', null, '1366.00', '2.00', null);
INSERT INTO `detallefactura` VALUES ('17', '10', '14', null, '1366.00', '5.00', null);
INSERT INTO `detallefactura` VALUES ('18', '11', '6', null, '1249.00', '6.00', null);
INSERT INTO `detallefactura` VALUES ('19', '12', '11', null, '1366.00', '2.00', null);
INSERT INTO `detallefactura` VALUES ('20', '13', '11', null, '1366.00', '7.00', null);
INSERT INTO `detallefactura` VALUES ('21', '14', '6', null, '1249.00', '8.00', null);
INSERT INTO `detallefactura` VALUES ('22', '15', '14', null, '1366.00', '2.00', null);
INSERT INTO `detallefactura` VALUES ('23', '16', '11', null, '1366.00', '2.00', null);
INSERT INTO `detallefactura` VALUES ('24', '17', '23', null, '2415.00', '1.00', null);
INSERT INTO `detallefactura` VALUES ('25', '17', '43', null, '2537.00', '1.00', null);
INSERT INTO `detallefactura` VALUES ('26', '18', '20', null, '1435.00', '3.00', null);
INSERT INTO `detallefactura` VALUES ('27', '18', '39', null, '3981.00', '4.00', null);
INSERT INTO `detallefactura` VALUES ('28', '19', '1', null, '3072.00', '2.00', null);
INSERT INTO `detallefactura` VALUES ('29', '19', '24', null, '1680.00', '1.00', null);

-- ----------------------------
-- Table structure for empleados
-- ----------------------------
DROP TABLE IF EXISTS `empleados`;
CREATE TABLE `empleados` (
  `empleado` varchar(255) NOT NULL DEFAULT '',
  PRIMARY KEY (`empleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of empleados
-- ----------------------------

-- ----------------------------
-- Table structure for facturas
-- ----------------------------
DROP TABLE IF EXISTS `facturas`;
CREATE TABLE `facturas` (
  `codfactura` int(255) unsigned NOT NULL AUTO_INCREMENT,
  `codcliente` int(100) DEFAULT NULL,
  `vendedor` varchar(255) DEFAULT NULL,
  `fecha` datetime NOT NULL,
  `descuento` decimal(10,2) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`codfactura`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of facturas
-- ----------------------------
INSERT INTO `facturas` VALUES ('1', '1', 'Chris', '2014-12-30 00:00:00', '0.00', '31.05');
INSERT INTO `facturas` VALUES ('2', '1', 'Chris', '2014-12-30 00:00:00', '0.00', '85.10');
INSERT INTO `facturas` VALUES ('3', '1', 'Chris', '2015-01-01 00:00:00', '0.00', '71.30');
INSERT INTO `facturas` VALUES ('4', '17', 'Chris', '2015-01-01 00:00:00', '0.00', '16.10');
INSERT INTO `facturas` VALUES ('5', '17', 'Chris', '2015-01-01 00:00:00', '0.00', '18.40');
INSERT INTO `facturas` VALUES ('6', '1', 'Chris', '2015-01-02 00:00:00', '0.00', '88.55');
INSERT INTO `facturas` VALUES ('7', '10', 'Chris', '2015-01-02 00:00:00', '0.00', '141.45');
INSERT INTO `facturas` VALUES ('8', null, null, '0000-00-00 00:00:00', null, null);
INSERT INTO `facturas` VALUES ('9', '1', 'Chris', '2015-01-05 08:18:08', '75571.22', '-61433.12');
INSERT INTO `facturas` VALUES ('10', '1', 'Chris', '2015-01-05 08:21:44', '0.00', '7854.50');
INSERT INTO `facturas` VALUES ('11', '1', 'Chris', '2015-01-05 08:24:50', '28080.02', '-19461.92');
INSERT INTO `facturas` VALUES ('12', '1', 'Chris', '2015-01-05 08:25:52', '0.00', '3141.80');
INSERT INTO `facturas` VALUES ('13', '10', 'Chris', '2015-01-05 12:17:39', '0.00', '10996.30');
INSERT INTO `facturas` VALUES ('14', '1', 'Chris', '2015-01-05 12:18:52', '0.00', '11490.80');
INSERT INTO `facturas` VALUES ('15', '1', 'Chris', '2015-01-05 12:26:59', '0.00', '3005.20');
INSERT INTO `facturas` VALUES ('16', '10', 'Chris', '2015-01-05 12:31:39', '0.00', '3005.20');
INSERT INTO `facturas` VALUES ('17', '10', 'Karol', '2015-01-06 12:45:29', '148.56', '5546.24');
INSERT INTO `facturas` VALUES ('18', '10', 'Karol', '2015-01-07 18:38:59', '0.00', '23263.35');
INSERT INTO `facturas` VALUES ('19', '20', 'Karol', '2015-01-08 10:41:30', '0.00', '8997.60');

-- ----------------------------
-- Table structure for inventario
-- ----------------------------
DROP TABLE IF EXISTS `inventario`;
CREATE TABLE `inventario` (
  `codproducto` int(6) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL DEFAULT '',
  `precio` decimal(11,2) NOT NULL,
  `precioTerranova` decimal(11,2) DEFAULT NULL,
  `existencia` decimal(11,2) NOT NULL,
  `proveedor` varchar(255) NOT NULL,
  `unidad` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`codproducto`)
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of inventario
-- ----------------------------
INSERT INTO `inventario` VALUES ('000001', 'Sanitario Montecarlo Alongado Blanco ', '3840.00', '3072.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000002', 'Sanitario Montecarlo Alongado Bone', '4050.00', '3240.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000003', 'Lavamano Maximo Bone 103 con Pedestal ', '1170.00', '936.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000004', 'Lavamano Maximo Blanco 100 con Pedestal ', '1125.00', '900.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000005', 'Lavamano Acuacer Blanco (100)', '348.00', '348.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000006', 'Sanitario Acuacer Blanco (100)', '1086.00', '1086.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000007', 'Sanitario Blanco Eco', '1020.00', '1020.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000008', 'Sanitario Acuacer Rosa Bahama (125)', '1188.00', '1188.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000009', 'Lavamano Acuacer Rosa Bahama (125)', '378.00', '378.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000010', 'Pedestal Acuacer Rosa Bahama (125)', '288.00', '288.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000011', 'Sanitario Acuacer Bone (103)', '1188.00', '1188.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000012', 'Sanitario Acuacer Verde Claro (141)', '1188.00', '1188.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000013', 'Lavamanos Acuacer Verde Claro (141)', '378.00', '378.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000014', 'Sanitario Acuacer Azul Cielo (111)', '1188.00', '1188.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000015', 'Lavamano Acuacer Azul Cielo (111)', '378.00', '378.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000016', 'Pedestal Acuacer Azul Cielo (111)', '288.00', '288.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000017', 'Sanitario Acuacer Vino Tinto (129)', '1248.00', '1248.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000018', 'Lavamano Acuacer Vino Tinto (129)', '396.00', '396.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000019', 'Pedestal Acuacer Vino Tinto (129)', '300.00', '300.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000020', 'Sanitario Acuacer Verde Oscuro (149)', '1248.00', '1248.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000021', 'Lavamano Acuacer Verde Oscuro (149)', '396.00', '396.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000022', 'Pedestal Acuacer Verde Oscuro (149)', '300.00', '300.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000023', 'Sanitario Avanti Alongado Vino Tinto (129)', '2240.00', '1680.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000024', 'Sanitario Avanti Alongado Verde Oscuro (149)', '2240.00', '1680.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000025', 'Llave p/Lavamanos Gerfor Almaguer ', '165.10', '152.40', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000026', 'Llave p/Lavamanos Gerfor Atrato', '165.10', '152.40', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000027', 'Lavamanos p/empotrar Marsella Bone (103)', '864.00', '576.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000028', 'Lavamanos p/empotrar Ornato Blanco ', '1098.00', '732.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000029', 'Sanitario Mazara plus rdo. Bone c/a 103', '3038.45', '2604.38', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000030', 'Sanitario Mazara plus rdo. Blanco c/a 100 ', '3038.45', '2604.38', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000031', 'Lavamano Mazara bone c/p s/a 103', '2576.00', '2208.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000032', 'Lavamano Mazara blanco c/p s/a', '2576.00', '2208.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000033', 'Sanitario potenza al plus bone c/a 103', '3808.00', '2856.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000034', 'Sanitario potenza al plus blanco c/a 100', '3808.00', '2856.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000035', 'Sanitario piamonte bone c/a 203', '4050.00', '3240.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000036', 'Lavamano piamonte con pedestal bone 50328103', '2394.00', '1915.20', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000037', 'Sanitario piamonte blanco c/a 100', '3535.50', '2828.40', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000038', 'Lavamano piamonte c/p blanco 50328100', '2041.50', '1633.20', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000039', 'Sanitario siena c/a blanco 100 32042', '3461.40', '2769.12', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000040', 'Lavamano torino blanco c/p s/a', '1182.03', '945.62', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000041', 'Lavamano torino bone 103 c/p s/a', '1360.50', '1088.40', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000042', 'Sanitario avanti rosa bahama plus alongado c/a', '2112.00', '1584.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000043', 'Sanitario avanti plus bone alongado c/a 30280103', '2206.50', '1765.20', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000044', 'Lavamano valencia empotrable blanco', '882.32', '588.22', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000045', 'Lavamano valencia empotrable bone', '882.32', '588.22', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000046', 'Lavamano marsella empotrable bone ', '893.32', '595.55', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000047', 'Lavatrasto a la derecha MK102 C/Accesorios', '1364.30', '1169.40', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000048', 'Lavatrasto 1 pila K112 C/Accesorios', '1263.04', '1082.60', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000049', 'Lavatrasto de 2 pilas M110 C/Accesorios', '1593.34', '1365.72', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000050', 'Lavatrastos Teka/ Mex 1 Fosa y 1  ESC Izq. 1.00X0.5Mts C/Accesorios', '845.00', '780.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000051', 'Lavatrastro Teka/Mex 1 Fosa y 1 ESC Der 1.00Xo.5Mts C/Accesorios', '845.00', '780.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000052', 'Lavatrasto Teka/Mex 2 Fosas 33X22X6 C/Accesorios', '1078.00', '924.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000053', 'Lavatrasto Teka/Mex 2 ESC 2Fosas 1.5X.50Mts C/Accesorios', '1855.00', '1590.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000054', 'Lavatrasto Teka/Mex 1 Fosa 25X22X6 C/Accesorios', '910.00', '780.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000055', 'Juegos de Accesorios para Lavatrastos Mex  ', '267.80', '247.20', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000056', 'Llave p/lavatrasto 8 Gerfor Almaguer ', '435.50', '402.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000057', 'Tubos de abasto miber 1/2x3/8x16 p/lavamanos', '39.00', '36.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000058', 'Tubo de abasto miber 7/8x3/8x16 p/sanitario', '42.90', '39.60', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000059', 'Tubo de abasto yee miber 1/2x1/2x3/8', '130.00', '120.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000060', 'Valvula recta miber 1/2x3/8', '65.00', '60.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000061', 'Valvula escuadra miber 1/2x3/8', '65.00', '60.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000062', 'Grifo \"4 chroma p/lavabo man.p', '701.40', '601.20', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000063', 'Grifo chroma sencillo man.cruz', '260.40', '223.20', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000064', 'Sanitario avanti alongado blanco ', '2145.00', '1716.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000065', 'pedestal acuacer blanco', '288.00', '288.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000066', 'Sanitario avanti plus blanco alongado c/a 3029', '2145.00', '1716.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000067', 'Pedestal acuacer verde claro', '321.60', '321.60', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000068', 'Lavamano acuacer bone', '374.98', '374.98', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000069', 'Pedestal acuacer bone', '321.60', '321.60', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000070', 'Lavamano maximo vino tinto', '1076.90', '861.52', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000071', 'Llave plastica p/lavamano B25-14', '52.20', '48.18', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000072', 'Llave plastica p/lavamano B25-10', '84.90', '78.37', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000073', 'Sifon con centro p/lavamano coflex', '47.31', '43.67', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000074', 'Lavatrasto Teka/Mex 2 fosas un esc. Derecho C/Accesorios', '1498.00', '1284.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000075', 'Lavamanos p/empotrar Ornato Bone ', '1152.00', '768.00', '0.00', '', null);
INSERT INTO `inventario` VALUES ('000076', 'Llave p/lavamano emerald', '231.20', '163.20', '0.00', '', null);

-- ----------------------------
-- Table structure for usuarios
-- ----------------------------
DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) NOT NULL,
  `pw` varchar(255) NOT NULL,
  `derechos` varchar(255) NOT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of usuarios
-- ----------------------------
INSERT INTO `usuarios` VALUES ('1', 'chris', '97423', 'admin', 'Chris Escalon');
INSERT INTO `usuarios` VALUES ('2', 'carlos', '111', 'gerente', 'Carlos Sanchez');
INSERT INTO `usuarios` VALUES ('3', 'zeneida', 'zen123', 'emple', 'Zeneida Sanchez');
INSERT INTO `usuarios` VALUES ('4', 'angela', 'josue', 'gerente', 'Angela Licona');
