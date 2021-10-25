-- ------------------------------
# LMD DATABASE hotelSanCarlos
-- ------------------------------

USE hotelSanCarlos;

-- ---------------------------------------------------
-- INSERT COMPONENTE SEGURIDAD
-- ---------------------------------------------------
#usuario: admin
#contraseña: 12345
insert into empleado values("1","María","Hernandez");
INSERT INTO usuario(pkId,fkIdEmpleado, nombre, contraseña,estado,intento) VALUES ("1", "1", "admin","LKAekHU9EtweB49HAaTRfg==","1","0");

insert into perfil values("1","Administrador","1");
insert into perfil values("2","Vendedor","1");

INSERT INTO modulo VALUES ('1','Seguridad','Módulo de Seguridad',1);

INSERT INTO aplicacion VALUES ("0001","1","Login Seguridad HSC",1,0001,0);
INSERT INTO aplicacion VALUES ("0002","1","Registrar Usuario",1,0002,0);
INSERT INTO aplicacion VALUES ("0003","1","Mantenimiento Aplicación",1,0003,0);
INSERT INTO aplicacion VALUES ("0004","1","Mantenimiento Perfil",1,0004,0);
INSERT INTO aplicacion VALUES ("0005","1","Asignación de Aplicación a Perfiles",1,0005,0);
INSERT INTO aplicacion VALUES ("0006","1","Asignación de Aplicación a Usuarios",1,0006,0);
INSERT INTO aplicacion VALUES ("0007","1","Asignación de Perfiles a Usuarios",1,0007,0);
INSERT INTO aplicacion VALUES ("0008","1","Asignación Permisos",1,0008,0);
INSERT INTO aplicacion VALUES ("0009","1","Recuperar Contraseña",1,0009,0);
INSERT INTO aplicacion VALUES ("0010","1","Cambiar Contraseña",1,0010,0);
INSERT INTO aplicacion VALUES ("0011","1","Consulta Bitácora",1,0011,0);
INSERT INTO aplicacion VALUES ("0012","1","Mantenimiento Módulo",1,0012,0);

    
-- -----------------------------------------
-- INSERT COMPONENTE CONSULTAS INTELIGENTES
-- -----------------------------------------
INSERT INTO `registro_consultas` (`id_registro`, `nombre`, `consulta`) VALUES
(3, 'consulta1', 'SELECT  * FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\" OR id_linea=\"3\"  order by id_linea desc;'),
(4, 'consulta2', 'SELECT id_factura_header as fh FROM factura_header ;'),
(5, 'aniversario', 'SELECT nombre as nonono FROM proveedores ;'),
(8, 'todosprov', 'SELECT  * FROM proveedores ;'),
(10, 'nuevoprov', 'SELECT  * FROM proveedores '),
(11, 'Demostracion', 'SELECT  * FROM linea    ;'),
(12, 'Todos los campos', 'SELECT  * FROM proveedores '),
(13, 'simple', 'SELECT nombre FROM marca '),
(14, 'pruebasimple', 'SELECT nombre FROM linea     ;'),
(18, 'ejemplox', 'SELECT  * FROM linea  WHERE id_linea=\"1\"    ;'),
(19, 'pruebabiggs', 'SELECT  * FROM linea  WHERE id_linea=\"1\"    ;'),
(20, 'and', 'SELECT  * FROM linea  WHERE id_linea=\"1\"  AND nombre=\"1\"   ;'),
(21, 'orord', 'SELECT  * FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\"  order by id_linea desc ;'),
(22, 'error', 'SELECT  * FROM linea  WHERE nombre=\"1\"  AND id_linea=\"1\"  group by id_linea ;'),
(28, 'prueba', 'SELECT  * FROM registro_consultas  WHERE id_registro=\"1\"    ;'),
(29, 'Pruebadef', 'SELECT  * FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\"  order by id_linea desc ;'),
(30, 'pruebadef2', 'SELECT  * FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\" OR id_linea=\"3\"  order by id_linea desc ;'),
(31, 'pruebadef3', 'SELECT  * FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\"  order by id_linea asc ;'),
(36, 'esteban', 'SELECT id_linea as linea , nombre as esteban FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\"  order by id_linea asc;'),
(37, 'ejemplo36', 'SELECT  * FROM linea    ;'),
(38, 'pruebafinal', 'SELECT  * FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\"  group by id_linea;');

ALTER TABLE `registro_consultas` MODIFY `id_registro` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;
