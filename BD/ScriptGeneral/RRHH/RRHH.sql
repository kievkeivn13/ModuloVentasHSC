USE hotelSanCarlos;

CREATE TABLE prestacionlaboral (
  pkIdPrestacionLaboral VARCHAR(11) PRIMARY KEY,
  nombre VARCHAR(45) NULL DEFAULT NULL,
  descripcion VARCHAR(45) NULL DEFAULT NULL)
 ENGINE=InnoDB DEFAULT CHARSET=latin1;



CREATE TABLE totalPrestacion (
  pkPrestacion VARCHAR(11) PRIMARY KEY,
  fkIdEmpleado VARCHAR(11) NOT NULL,
  fkIdPrestacionLaboral VARCHAR(11) NOT NULL,
  fechaInicio DATETIME NULL,
  fechaFInal DATETIME NULL,
  totalDiasTrabajados INT NULL,
  totalPrestacion DECIMAL NULL,
  
  FOREIGN KEY (fkIdEmpleado) REFERENCES empleado (pkIdEmpleado),
  FOREIGN KEY (fkIdPrestacionLaboral) REFERENCES prestacionlaboral (pkIdPrestacionLaboral))
 ENGINE=InnoDB DEFAULT CHARSET=latin1;



CREATE TABLE totalLiquidacion (
  fkIdPrestacion VARCHAR(11) NOT NULL,
  totalLiquidacion INT NULL,
  
  FOREIGN KEY (fkIdPrestacion) REFERENCES totalPrestacion (pkPrestacion))
 ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE desarrollodecarrrera (
  pkIdDesarrolloDeCarrera VARCHAR(11) PRIMARY KEY,
  observaciones VARCHAR(45) NULL DEFAULT NULL,
  aspiradorSueldo VARCHAR(45) NULL DEFAULT NULL,
  ausencias VARCHAR(45) NULL DEFAULT NULL,
  fkIdEmpleado VARCHAR(11) NOT NULL,
  
  FOREIGN KEY (fkIdEmpleado) REFERENCES empleado (pkIdEmpleado))
 ENGINE=InnoDB DEFAULT CHARSET=latin1;



CREATE TABLE mediodecontacto (
  pkIdMedioDeContacto VARCHAR(11) PRIMARY KEY,
  nombre VARCHAR(45) NULL DEFAULT NULL,
  costoMensual VARCHAR(45) NULL DEFAULT NULL,
  mediodecontactocol VARCHAR(45) NULL DEFAULT NULL
  )
 ENGINE=InnoDB DEFAULT CHARSET=latin1;



CREATE TABLE reclutamiento (
  pkIdReclutamiento VARCHAR(11) PRIMARY KEY,
  fkIdEmpleado VARCHAR(11) NOT NULL,
  fkIdMedioDeContacto VARCHAR(11) NOT NULL,
  
  FOREIGN KEY (fkIdEmpleado) REFERENCES empleado (pkIdEmpleado),
  FOREIGN KEY (fkIdMedioDeContacto) REFERENCES mediodecontacto (pkIdMedioDeContacto))
 ENGINE=InnoDB DEFAULT CHARSET=latin1;


