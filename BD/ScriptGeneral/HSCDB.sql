-- --------------------------
# LDD Database hotelSanCarlos
-- --------------------------

-- DROP DATABASE hotelSanCarlos;
CREATE DATABASE hotelSanCarlos;
USE hotelSanCarlos;

-- ------------------------------------------------------------------------------------------------------------
-- 	COMPONENTE SEGURIDAD
-- ------------------------------------------------------------------------------------------------------------
CREATE TABLE empleado(
	pkIdEmpleado varchar(15) PRIMARY KEY,
	nombre varchar(25) NOT NULL,
	apellido varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE usuario(
	pkId VARCHAR(15) PRIMARY KEY,
	fkIdEmpleado varchar(15) NOT NULL, 
	nombre VARCHAR(30) NOT NULL,
	contraseña VARCHAR(100) NOT NULL,
	estado VARCHAR(1) NOT NULL,
	intento INT NULL,

	FOREIGN KEY (fkIdEmpleado) REFERENCES empleado(pkIdEmpleado)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE modulo(
	pkId VARCHAR(15) PRIMARY KEY,
	nombre VARCHAR(30) NOT NULL,
	descripcion VARCHAR(200) NOT NULL,
	estado VARCHAR(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
	
CREATE TABLE aplicacion(
	pkId VARCHAR(15) PRIMARY KEY,
	fkIdModulo VARCHAR(15) NOT NULL,
	nombre VARCHAR(45) NULL,
	estado INT NOT NULL,
	rutaChm varchar(180) not null,
	rutaHtml varchar(180) not null,
	FOREIGN KEY (fkIdModulo) REFERENCES modulo(pkId)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE bitacoraUsuario(
	pkId INT AUTO_INCREMENT PRIMARY KEY,
	fkIdUsuario VARCHAR(15) NOT NULL,
	`host` VARCHAR(45) NULL DEFAULT NULL,
	ip VARCHAR(20) NULL,
	fkIdModulo VARCHAR(15) NOT NULL,
	fkIdAplicacion VARCHAR(15) NOT NULL,
	accion VARCHAR(200) NOT NULL,
	conexionFecha DATE NULL,
	conexionHora TIME NULL,
  
	FOREIGN KEY (fkIdUsuario) REFERENCES usuario (pkId),
	FOREIGN KEY (fkIdModulo) REFERENCES modulo (pkId),
	FOREIGN KEY (fkIdAplicacion) REFERENCES aplicacion(pkID)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE perfil(
	pkId VARCHAR(15) PRIMARY KEY,
	nombre VARCHAR(45) NULL,
	estado VARCHAR(45) NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE usuarioPerfil(
	fkIdUsuario VARCHAR(15) NOT NULL,
	fkIdPerfil VARCHAR(15) NOT NULL,

	FOREIGN KEY (fkIdPerfil) REFERENCES Perfil (pkId),
	FOREIGN KEY (fkIdUsuario) REFERENCES Usuario (pkId)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE usuarioAplicacion(
	fkIdUsuario VARCHAR(15) NOT NULL,
	fkIdAplicacion VARCHAR(15) NOT NULL,
	permisoEscritura int,
	permisoLectura int,
	permisoModificar int,
	permisoEliminar int,
	permisoImprimir int,

	FOREIGN KEY (fkIdAplicacion) REFERENCES Aplicacion (pkId),
	FOREIGN KEY (fkIdUsuario) REFERENCES Usuario (pkId)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
   
CREATE TABLE aplicacionPerfil (
	fkIdPerfil VARCHAR(15) NOT NULL,
	fkIdAplicacion VARCHAR(15) NOT NULL,
	permisoEscritura int,
	permisoLectura int,
	permisoModificar int,
	permisoEliminar int,
	permisoImprimir int,

	FOREIGN KEY (fkIdAplicacion) REFERENCES Aplicacion (pkId),
	FOREIGN KEY (fkIdPerfil) REFERENCES Perfil (pkId)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Vista #1
CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`localhost` 
    SQL SECURITY DEFINER
VIEW `hotelSanCarlos`.`vwpermisosperfil` AS
    SELECT 
        `a`.`permisoEscritura` AS `permisoEscritura`,
        `a`.`permisoLectura` AS `permisoLectura`,
        `a`.`permisoModificar` AS `permisoModificar`,
        `a`.`permisoEliminar` AS `permisoEliminar`,
        `a`.`permisoImprimir` AS `permisoImprimir`,
        `b`.`pkId` AS `pkIdPerfil`,
        `b`.`nombre` AS `Perfil`,
        `c`.`pkId` AS `pkIdAplicacion`,
        `c`.`nombre` AS `Aplicacion`
    FROM
        ((`hotelSanCarlos`.`aplicacionperfil` `a`
        JOIN `hotelSanCarlos`.`perfil` `b` ON ((`b`.`pkId` = `a`.`fkIdPerfil`)))
        JOIN `hotelSanCarlos`.`aplicacion` `c` ON ((`c`.`pkId` = `a`.`fkIdAplicacion`)))
    ORDER BY `a`.`fkIdPerfil`;

-- Vista #2
CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`localhost` 
    SQL SECURITY DEFINER
VIEW `hotelSanCarlos`.`vwpermisosusuario` AS
    SELECT 
        `a`.`permisoEscritura` AS `permisoEscritura`,
        `a`.`permisoLectura` AS `permisoLectura`,
        `a`.`permisoModificar` AS `permisoModificar`,
        `a`.`permisoEliminar` AS `permisoEliminar`,
        `a`.`permisoImprimir` AS `permisoImprimir`,
        `b`.`pkId` AS `pkIdUsuario`,
        `b`.`nombre` AS `Usuario`,
        `c`.`pkId` AS `pkIdAplicacion`,
        `c`.`nombre` AS `Aplicacion`
    FROM
        ((`hotelSanCarlos`.`usuarioaplicacion` `a`
        JOIN `hotelSanCarlos`.`usuario` `b` ON ((`b`.`pkId` = `a`.`fkIdUsuario`)))
        JOIN `hotelSanCarlos`.`aplicacion` `c` ON ((`c`.`pkId` = `a`.`fkIdAplicacion`)))
    ORDER BY `a`.`fkIdUsuario`;
    

CREATE TABLE usuarioAplicacionAsignados(
	fkIdUsuario VARCHAR(15) NOT NULL,
	fkIdAplicacion VARCHAR(15) NOT NULL,

	FOREIGN KEY (fkIdAplicacion) REFERENCES Aplicacion (pkId),
	FOREIGN KEY (fkIdUsuario) REFERENCES Usuario (pkId)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


-- ------------------------------------------------------------------------------------------------------------
-- 												CONSULTAS INTELIGENTES
-- ------------------------------------------------------------------------------------------------------------
CREATE TABLE registro_consultas (
   id_registro int primary key auto_increment NOT NULL,
   nombre varchar(200) DEFAULT NULL,
   consulta varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


-- ------------------------------------------------------------------------------------------------------------
-- 							MÓDULO CONTABILIDAD - PÓLIZAS
-- ------------------------------------------------------------------------------------------------------------
create table tipoCuenta(
	idTipoCuenta varchar(15), -- si es activo o pasivo
	nombre varchar(65), -- escribir nombre completo ej Activo Corriente
	estado varchar(1),

	primary key (idTipoCuenta)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

create table cuenta(
	idCuenta varchar(15),
	nombre varchar(65),
	idTipoCuenta varchar(15), -- foranea con Tipo Cuenta
	estado varchar(1) ,-- A-Activo , I-Inactivo

	primary key (idCuenta),
	foreign key (idTipoCuenta) references tipoCuenta (idTipoCuenta)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

create table tipoPoliza(
	idTipoPoliza varchar(15),
	descripcion varchar(65),
	estado varchar(1), -- A-Activo , I-Inactivo

	primary key (idTipoPoliza)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

create table polizaEncabezado(
	idPolizaEncabezado varchar(15),
	fechaPoliza date,
	idTipoPoliza varchar(15), -- foranea con tipo poliza
	concepto varchar(65),

	primary key(idPolizaEncabezado,fechaPoliza),
    
	foreign key (idTipoPoliza) references tipoPoliza (idTipoPoliza)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

create table tipoOperacion(
	idTipoOperacion varchar(15),
	nombre varchar(65), 
	estado varchar(1),-- A-Activo , I-Inactivo

	primary key (idTipoOperacion)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

create table polizaDetalle(
	idPolizaEncabezado varchar(15), 
    fechaPoliza date,
	idCuenta varchar(15), 		-- foranea con cuenta
	saldo float,
	idTipoOperacion varchar(15), -- debe/haber
	
	primary key(idPolizaEncabezado, fechaPoliza, idCuenta),
    
    foreign key (idPolizaEncabezado) references polizaEncabezado (idPolizaEncabezado),
	foreign key (idCuenta) references Cuenta (idCuenta),
	foreign key (idTipoOperacion) references tipoOperacion (idTipoOperacion)
	
) ENGINE = InnoDB DEFAULT CHARSET=latin1;