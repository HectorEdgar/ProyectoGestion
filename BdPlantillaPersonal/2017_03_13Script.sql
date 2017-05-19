/*
Created		08/03/2017
Modified		13/03/2017
Project		
Model		
Company		
Author		
Version		
Database		MS SQL 7 
*/


Drop table [PlantillaHistorial] 
go
Drop table [ClavePresupuestal] 
go
Drop table [Sector] 
go
Drop table [RelacionLaboral] 
go
Drop table [Status] 
go
Drop table [Plantilla] 
go
Drop table [Cuenta] 
go


Create table [Cuenta] (
	[idCuenta] Integer Identity NOT NULL,
	[usuario] Varchar(100) NOT NULL,
	[contrasenia] Varchar(50) NOT NULL,
	[tipo] Varchar(50) NOT NULL,
	[nombre] Varchar(50) NOT NULL,
	[apellidoPaterno] Varchar(50) NOT NULL,
	[apellidoMaterno] Varchar(50) NOT NULL,
Primary Key  ([idCuenta])
) 
go

Create table [Plantilla] (
	[idPlantilla] Integer Identity NOT NULL,
	[PBPNUE] Integer NOT NULL,
	[RFC] Varchar(30) NOT NULL,
	[NMAPP] Varchar(20) NOT NULL,
	[NMAPM] Varchar(20) NOT NULL,
	[NMNOMB] Varchar(40) NOT NULL,
	[NMNOM] Varchar(80) NOT NULL,
	[NMFING] Datetime NOT NULL,
	[NIVEL] Varchar(5) NOT NULL,
	[CNOMCVE] Varchar(100) NOT NULL,
	[CNOMTIP] Varchar(100) NOT NULL,
	[CTICCVE] Varchar(100) NOT NULL,
	[CVEDEP] Varchar(100) NOT NULL,
	[NQS] Varchar(100) NOT NULL,
	[idSector] Integer NOT NULL,
	[idClavePresupuestal] Integer NOT NULL,
	[idStatus] Integer NOT NULL,
	[idRelacionLaboral] Integer NOT NULL,
Primary Key  ([idPlantilla])
) 
go

Create table [Status] (
	[idStatus] Integer Identity NOT NULL,
	[nombreStatus] Varchar(30) NOT NULL,
Primary Key  ([idStatus])
) 
go

Create table [RelacionLaboral] (
	[idRelacionLaboral] Integer Identity NOT NULL,
	[relacionLaboral] Varchar(100) Identity NOT NULL,
	[NMCATG] Varchar(100) NOT NULL,
	[TBDES] Varchar(100) NOT NULL,
Primary Key  ([idRelacionLaboral])
) 
go

Create table [Sector] (
	[idSector] Integer Identity NOT NULL,
	[sector] Varchar(100) NOT NULL,
Primary Key  ([idSector])
) 
go

Create table [ClavePresupuestal] (
	[idClavePresupuestal] Integer Identity NOT NULL,
	[clavePresupuestal] Varchar(100) NOT NULL,
Primary Key  ([idClavePresupuestal])
) 
go

Create table [PlantillaHistorial] (
	[idPlantilla] Integer Identity NOT NULL,
	[idRelacionLaboral] Integer NOT NULL,
	[idStatus] Integer NOT NULL,
	[idSector] Integer NOT NULL,
	[idClavePresupuestal] Integer NULL,
	[clavePresupuestalAnterior] Varchar(100) NOT NULL,
	[PBPNUE] Integer NOT NULL,
	[PBPNUP] Integer NULL,
	[RFC] Varchar(30) NOT NULL,
	[NMAPP] Varchar(20) NOT NULL,
	[NMAPM] Varchar(20) NOT NULL,
	[NMNOMB] Varchar(40) NOT NULL,
	[NMNOM] Varchar(80) NOT NULL,
	[NMFING] Datetime NOT NULL,
	[NMFSAL] Datetime NOT NULL,
	[NIVEL] Varchar(5) NOT NULL,
	[CNOMCVE] Varchar(100) NOT NULL,
	[CNOMTIP] Varchar(100) NOT NULL,
	[CTICCVE] Varchar(100) NOT NULL,
	[CVEDEP] Varchar(100) NOT NULL,
	[NQS] Varchar(100) NOT NULL,
Primary Key  ([idPlantilla])
) 
go


Alter table [Plantilla] add  foreign key([idStatus]) references [Status] ([idStatus]) 
go
Alter table [PlantillaHistorial] add  foreign key([idStatus]) references [Status] ([idStatus]) 
go
Alter table [Plantilla] add  foreign key([idRelacionLaboral]) references [RelacionLaboral] ([idRelacionLaboral]) 
go
Alter table [PlantillaHistorial] add  foreign key([idRelacionLaboral]) references [RelacionLaboral] ([idRelacionLaboral]) 
go
Alter table [Plantilla] add  foreign key([idSector]) references [Sector] ([idSector]) 
go
Alter table [PlantillaHistorial] add  foreign key([idSector]) references [Sector] ([idSector]) 
go
Alter table [Plantilla] add  foreign key([idClavePresupuestal]) references [ClavePresupuestal] ([idClavePresupuestal]) 
go
Alter table [PlantillaHistorial] add  foreign key([idClavePresupuestal]) references [ClavePresupuestal] ([idClavePresupuestal]) 
go


Set quoted_identifier on
go


Set quoted_identifier off
go


/* Roles permissions */


/* Users permissions */


