CREATE DATABASE taller_garcia
use taller_garcia
CREATE TABLE especialidades(
	id_especialidad INT PRIMARY KEY,
	especialidad nvarchar(60)
)

CREATE TABLE operarios(
	id_operario INT PRIMARY KEY,
	nombre_operario nvarchar(60),
	id_especialidad int FOREIGN KEY REFERENCES especialidades(id_especialidad),
	importe_hora decimal(18,2)
)

CREATE TABLE propietarios(
	id_propietario INT PRIMARY KEY,
	nombre_prop nvarchar(60),
	telefono_prop nvarchar(20)
)

CREATE TABLE autos(
	nro_patente nvarchar(20) PRIMARY KEY,
	marca nvarchar(60),
	modelo nvarchar(60),
	color nvarchar(60),
	id_propietario int FOREIGN KEY REFERENCES propietarios(id_propietario)
)

CREATE TABLE repuestos(
	cod_repuesto INT PRIMARY KEY,
	descripcion_rep nvarchar(60),
	importe_rep decimal(18,2)
)

CREATE TABLE tareas(
	cod_tarea INT PRIMARY KEY,
	descripcion_tarea NVARCHAR(60),
	horas_tarea decimal(10,1),
	id_especialidad int FOREIGN KEY REFERENCES especialidades(id_especialidad)
)

CREATE TABLE ingresos(
	id_ingreso INT IDENTITY(1,1) PRIMARY KEY,
	fecha_ing datetime,
	nro_patente nvarchar(20) FOREIGN KEY REFERENCES autos(nro_patente)
)

CREATE TABLE ingresos_tareas(
	id_ingreso INT FOREIGN KEY REFERENCES ingresos(id_ingreso),
	cod_tarea INT FOREIGN KEY REFERENCES tareas(cod_tarea),
	importe decimal(18,2),
	PRIMARY KEY(id_ingreso,cod_tarea)
)

CREATE TABLE ingresos_respuestos(
	id_ingreso INT FOREIGN KEY REFERENCES ingresos(id_ingreso),
	cod_respuesto INT FOREIGN KEY REFERENCES repuestos(cod_repuesto),
	importe_rep decimal(18,2),
	cantidad int,
	importe decimal(18,2),
	PRIMARY KEY(id_ingreso,cod_respuesto)
)

CREATE TABLE usuarios(
    id_usuario int primary key,
    usuario nvarchar(60),
    psw nvarchar(8)
)

--3.1
CREATE PROCEDURE patente 
@patente NVARCHAR(20)
As
BEGIN
SELECT ingresos.nro_patente,tareas.descripcion_tarea FROM ingresos_tareas
INNER JOIN ingresos ON ingresos.id_ingreso = ingresos_tareas.id_ingreso
INNER JOIN tareas ON tareas.cod_tarea = ingresos_tareas.cod_tarea
WHERE ingresos.nro_patente = @patente
END

EXEC patente 'ejw 121'

--3.2
CREATE PROCEDURE propietario
@propietario INT 
As
BEGIN
SELECT nro_patente, marca, modelo, color FROM autos
INNER JOIN propietarios ON propietarios.id_propietario = autos.id_propietario
WHERE autos.id_propietario = @propietario
END

EXEC propietario 1

--3.3
CREATE PROCEDURE totales
@propietario INT,
@fecha_ingreso DATE,
@fecha_salida DATE
As
BEGIN
SELECT p.nombre_prop, a.id_propietario,
       SUM(it.importe) AS total_tareas, 
       SUM(ir.importe_rep) AS total_repuestos
FROM propietarios p
LEFT JOIN autos a ON p.id_propietario = a.id_propietario
LEFT JOIN ingresos i ON a.nro_patente = i.nro_patente
LEFT JOIN ingresos_tareas it ON i.id_ingreso = it.id_ingreso
LEFT JOIN ingresos_respuestos ir ON i.id_ingreso = ir.id_ingreso
WHERE p.id_propietario = @propietario
  AND i.fecha_ing BETWEEN @fecha_ingreso AND @fecha_salida
GROUP BY p.nombre_prop, a.id_propietario;
END

EXEC totales 2, '2023/01/01', '2023/03/01'

--3.4

CREATE PROCEDURE extraespecialidades As
BEGIN
SELECT es.especialidad AS Especialidad,COUNT(es.especialidad) As Cantidad_Operarios FROM operarios op
INNER JOIN especialidades es ON es.id_especialidad = op.id_especialidad
GROUP BY es.especialidad ORDER BY Cantidad_Operarios DESC
END

--3.5
CREATE PROCEDURE extratareas As
BEGIN
SELECT tr.descripcion_tarea AS DESCRIPCION,COUNT(it.cod_tarea) AS DEMANDA from ingresos_tareas it
INNER JOIN tareas tr ON tr.cod_tarea = it.cod_tarea
GROUP BY it.cod_tarea, tr.descripcion_tarea ORDER BY DEMANDA DESC
END
-- FIN

--USUARIO
INSERT INTO usuarios VALUES(1,'admin','admin')

--ESPECIALIDADES
INSERT INTO especialidades VALUES(1,'Mecanica'),(2,'Chaperia')

--PROPIETARIOS
INSERT INTO propietarios VALUES(1,'Facundo','3410000000'),(2,'Alberto','3410000000')

--REPUESTOS
INSERT INTO repuestos VALUES(30303,'limpia parabrizas','500'),(20202,'espejo retrovisor','2000'),(10101,'bujia','1000')

--OPERARIOS
INSERT INTO operarios VALUES(1,'Martin',1,'500'),(2,'Cacho',2,'550'),(3,'Pocho',2,'450')

--AUTOS
INSERT INTO autos VALUES('EVV 671','Chevrolet','Corsa','Gris',1),('EOK 521','FIAT','DUNA','AZUL',1),('EWA 700','Peugeot','208','Rojo',2)

--TAREAS
INSERT INTO tareas VALUES(1,'abolladura',10,2),(2,'pintar techo',20,2),(3,'cambiar bujias',1,1),(4,'Revisar motor',3,1),(5,'Lustrado',2,2)

--INGRESOS
INSERT INTO ingresos VALUES
('2023-02-28 19:25:00.000','EOK 521'),
('2023-02-20 12:25:00.000','EOK 521'),
('2023-03-01 15:00:00.000','EOK 521'),
('2023-01-20 09:50:00.000','EVV 671'),
('2023-02-12 15:00:00.000','EWA 700')

--INGRESOS TAREAS
INSERT INTO ingresos_tareas VALUES(1,1,20000),(2,2,10000),(3,3,2000),(4,4,5000),(5,4,9000)

--INGRESOS REPUESTOS
INSERT INTO ingresos_respuestos VALUES(4,30303,3500,2,7000),(5,10101,1200,8,9600)