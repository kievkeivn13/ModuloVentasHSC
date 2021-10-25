-- drop database contabilidad;
create database contabilidad;

use contabilidad;

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
idEncabezado varchar(15),
fechaPartida date,
idTipoPoliza varchar(15), -- foranea con tipo poliza
concepto varchar(65),

primary key(idEncabezado,fechaPartida),
foreign key (idTipoPoliza) references tipoPoliza (idTipoPoliza)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;



create table tipoOperacion(
idTipoOperacion varchar(15),
nombre varchar(65), 
estado varchar(1),-- A-Activo , I-Inactivo

primary key (idTipoOperacion)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

create table polizaDetallle(
idPolizaDetalle varchar (15),
idEncabezado varchar(15), -- foranea con Encabezado
idCuenta varchar(15), -- foranea con cuenta
saldo float,
idTipoOperacion varchar(15), -- debe/haber


fechaPartida date, -- foranea con partida
primary key(idPolizaDetalle),
foreign key (idCuenta) references Cuenta (idCuenta),
foreign key (idTipoOperacion) references tipoOperacion (idTipoOperacion),
foreign key (idEncabezado) references polizaEncabezado (idEncabezado)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;