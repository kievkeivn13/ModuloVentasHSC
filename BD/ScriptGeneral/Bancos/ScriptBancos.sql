use hotelSanCarlos;

Create Table Banco (
IdBanco varchar(15) NOT NULL,
PRIMARY KEY (IdBanco),
nombreBanco varchar(20) NOT NULL,
direccionBanco varchar(25) NOT NULL
)ENGINE = InnoDB;

Create Table CuentasBancos (
IdCuenta varchar(15) NOT NULL,
PRIMARY KEY (idCuentaB),
FkidBanco varchar(15) not null,
nombreCuentaB varchar(20) NOT NULL,
tipoCuentaB varchar(25) NOT NULL,
direccionCuentaB varchar(25) NOT NULL,
EstadoCuentaB varchar(1) not null,
foreign key (FkidBanco) references Banco(IdBanco)
)ENGINE = InnoDB;


create table Moneda(
Pkid varchar(15) primary key,
nombreMoneda varchar(30) not null,
estadoMoneda varchar(1)
)engine=InnoDB;

create table TipoCambio (
idTipoc varchar(15) primary key,
fkidMoneda varchar(15) not null,
fechaTipoC date not null,
cambioTipoC float not null,

foreign key (fkidMoneda) references Moneda(idMoneda)
)engine=InnoDB;