CREATE DATABASE ESTUDIANTEDB

GO

USE ESTUDIANTEDB

GO

CREATE TABLE ESTUDIANTE
(
ID INT PRIMARY KEY IDENTITY(1,1),
CODIGO NVARCHAR(15),
NOMBRE VARCHAR(50),
APELLIDO VARCHAR(50),
DIRECCION NVARCHAR(100),
)

