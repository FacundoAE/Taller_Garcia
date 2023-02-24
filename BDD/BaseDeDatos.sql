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
select propietarios.nombre_prop,autos.id_propietario,SUM(ingresos_tareas.importe) As Total_Tareas,SUM(ingresos_respuestos.importe) As Total_Repuestos from ingresos
inner join autos on ingresos.nro_patente = autos.nro_patente
inner join propietarios on autos.id_propietario = propietarios.id_propietario
inner join ingresos_tareas on ingresos.id_ingreso = ingresos_tareas.id_ingreso
inner join ingresos_respuestos on ingresos.id_ingreso = ingresos_respuestos.id_ingreso
where fecha_ing between @fecha_ingreso and @fecha_salida and autos.id_propietario = 1
group by autos.id_propietario,propietarios.nombre_prop
END
-- FIN