drop database ModuloVentas;
create database ModuloVentas;

use ModuloVentas;

create table Servicio(
Pkid varchar(15) primary key,
Nombre varchar(30) not null,
Estatus varchar(1)
)engine=InnoDB;

create table Cliente(
Pkid varchar(15) primary key,
Nombre varchar(30) not null,
Apellido varchar(30) not null,
Nit varchar(15) not null,
Telefono varchar(15) not null,
Direccion varchar(50) not null,
Correo varchar(50) not null,
Estatus varchar(1)
)engine=InnoDB;

create table Fraccionamiento(
Pkid varchar(15) primary key,
Nombre varchar(30) not null,
Cuotas int not null,
Estatus varchar(1)
)engine=InnoDB;

create table TipoDocumento(
Pkid varchar(15) primary key,
Nombre varchar(30) not null,
Estatus varchar(1)
)engine=InnoDB;

create table FormaPago(
Pkid varchar(15) primary key,
Nombre varchar(30) not null,
Estatus varchar(1)
)engine=InnoDB;

create table Caja(
Pkid varchar(15) primary key,
Nombre varchar(30) not null,
Estatus varchar(1)
)engine=InnoDB;

create table Banco(
Pkid varchar(15) primary key,
Nombre varchar(30) not null,
Estatus varchar(1)
)engine=InnoDB;

create table CuentaBancaria(
Pkid varchar(15) primary key,
Nombre varchar(30) not null,
Estatus varchar(1)
)engine=InnoDB;

create table Moneda(
Pkid varchar(15) primary key,
Nombre varchar(30) not null,
Estatus varchar(1)
)engine=InnoDB;

create table Mora(
Pkid varchar(15) primary key,
Nombre varchar(30) not null,
Cantidad float not null,
Estatus varchar(1) not null
)engine=InnoDB;

create table CuentasporCobrar(
Pkid varchar(15) primary key,
Fkcliente varchar(15) not null,
Fechaemision date not null,
Fechavencimiento date not null,
Fkfraccionamiento varchar(15) not null,
Fktipodocumento varchar(15) not null,
Fkformapago varchar(15),
Fkcaja varchar(15),
Fkmoneda varchar(15),
Fkbanco varchar(15),
Fkcuentabancaria varchar(15),
Fkmora varchar(15) not null,
Totalmonto float not null,
Faltantemonto float not null,

foreign key (Fkcliente) references Cliente (Pkid),
foreign key (Fkfraccionamiento) references Fraccionamiento (Pkid),
foreign key (Fktipodocumento) references TipoDocumento (Pkid),
foreign key (Fkformapago) references FormaPago (PKid),
foreign key (Fkcaja) references Caja (Pkid),
foreign key (Fkmoneda) references Moneda (Pkid),
foreign key (Fkbanco) references Banco (Pkid),
foreign key (Fkmora) references Mora (Pkid),
foreign key (Fkcuentabancaria) references CuentaBancaria (Pkid)
)engine=InnoDB;

create table TipoInventario(
Pkid varchar(15) primary key,
Nombre varchar(30) not null,
Estatus varchar(1)
)engine=InnoDB;

create table Inventario(
Pkid varchar(15) primary key,
Nombre varchar(30) not null,
Fktipoinventario varchar(15) not null,
Stock int not null,
Costo float not null,
Precio float not null,
Estatus varchar(1),

foreign key (Fktipoinventario) references TipoInventario (Pkid)
)engine=InnoDB;

create table CotizacionEncabezado(
Pkid varchar(15) primary key,
Fkidcliente varchar(15) not null,
Fechaemision date not null,
Fechavencimiento date not null,
Total float not null,

foreign key (Fkidcliente) references Cliente (Pkid)
)engine=InnoDB;

create table CotizacionDetalle(
Pkid varchar(15) primary key,
Fkencabezado varchar(15) not null,
Fkinventario varchar(15),
Fkservicio varchar(15),

foreign key (Fkencabezado) references Cliente (Pkid),
foreign key (Fkinventario) references Inventario (Pkid),
foreign key (Fkservicio) references Servicio (Pkid)
)engine=InnoDB;

create table FacturacionEncabezado(
Pkid varchar(15) primary key,
Fkidcliente varchar(15) not null,
Fechaemision date not null,
Fechavencimiento date not null,
Total float not null,

foreign key (Fkidcliente) references Cliente (Pkid)
)engine=InnoDB;

create table FacturacionDetalle(
Pkid varchar(15) primary key,
Fkencabezado varchar(15) not null,
Fkinventario varchar(15),
Fkservicio varchar(15),

foreign key (Fkencabezado) references Cliente (Pkid),
foreign key (Fkinventario) references Inventario (Pkid),
foreign key (Fkservicio) references Servicio (Pkid)
)engine=InnoDB;

