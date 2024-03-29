USE EDIDB
GO
IF OBJECT_ID('IEnetUsers', 'U') IS NOT NULL 
	DROP TABLE IEnetUsers; 
CREATE TABLE IEnetUsers (
	Id INT PRIMARY KEY IDENTITY(1,1) not null,
	IdIEnetGroup INT not null,
	CodUsr NVARCHAR(128) not null,
	NomUsr NVARCHAR(128) not null,
	UsrPassword NVARCHAR(128) not null,
	ClienteID INT null,
	HashId NVARCHAR(128) null
)
GO
IF OBJECT_ID('IEnetGroups', 'U') IS NOT NULL 
	DROP TABLE IEnetGroups; 
GO
CREATE TABLE IEnetGroups (
	Id INT PRIMARY KEY IDENTITY(1,1) not null,
	Descr NVARCHAR(128)
)
GO
IF OBJECT_ID('IEnetAccesses', 'U') IS NOT NULL 
	DROP TABLE IEnetAccesses; 
GO
CREATE TABLE IEnetAccesses (
	Id INT PRIMARY KEY IDENTITY(1,1) not null,
	Descr NVARCHAR(128)
)
GO
IF OBJECT_ID('IEnetGroupsAccesses', 'U') IS NOT NULL 
	DROP TABLE IEnetGroupsAccesses; 
GO
CREATE TABLE IEnetGroupsAccesses (
	Id INT PRIMARY KEY IDENTITY(1,1) not null,
	IdIEnetGroup INT not null,
	IdIEnetAccess INT not null
)
GO
INSERT INTO IEnetGroups(Descr) VALUES ('Admins')
GO
INSERT INTO IEnetUsers(IdIEnetGroup, CodUsr, NomUsr, UsrPassword) VALUES(1, 'admin', 'Administrador total', 'PassGlc123456')
GO
INSERT INTO IEnetAccesses(Descr) VALUES ('Login')
GO
INSERT INTO IEnetAccesses(Descr) VALUES ('Crud_Usuarios')
GO
INSERT INTO IEnetAccesses(Descr) VALUES ('Crud_Grupos')
GO
INSERT INTO IEnetAccesses(Descr) VALUES ('Crud_Permisos')
GO
INSERT INTO IEnetAccesses(Descr) VALUES ('Crud_Grupos_Permisos')
GO
INSERT INTO IEnetAccesses(Descr) VALUES ('Logs')
GO
INSERT INTO IEnetAccesses(Descr) VALUES ('Admin_Pedidos_Lear')
GO
INSERT INTO IEnetAccesses(Descr) VALUES ('Admin_Pedidos_Payless')
GO
INSERT INTO IEnetAccesses(Descr) VALUES ('Admin_Confirmacion_Lear')
GO
INSERT INTO IEnetAccesses(Descr) VALUES ('Admin_Confirmacion_Lear_Enviar_NotificaciónEdi')
GO
INSERT INTO IEnetAccesses(Descr) VALUES ('Usuario_Pedidos_Payless')
GO
INSERT INTO IEnetAccesses(Descr) VALUES ('Usuario_Pedidos_Payless_Enviar')
GO
INSERT INTO IEnetAccesses(Descr) VALUES ('Usuario_Planilla_Ingreso_Payless')
GO

INSERT INTO IEnetAccesses(Descr) VALUES ('Usuario_Planilla_Ingreso_Payless_Carga')
GO
INSERT INTO IEnetAccesses(Descr) VALUES ('Usuario_Planilla_Ingreso_Payless_Carga')
GO
INSERT INTO IEnetAccesses(Descr) VALUES ('Usuario_Ordenes_Payless')
GO
INSERT INTO IEnetAccesses(Descr) VALUES ('Usuario_Estado_PedidosWms')
GO
