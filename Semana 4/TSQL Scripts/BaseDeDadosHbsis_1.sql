CREATE DATABASE BaseDeDadosHbsis

GO

USE BaseDeDadosHbsis

GO

CREATE TABLE [dbo].[Usuarios] (
    [Id]               INT         IDENTITY (1, 1) NOT NULL,
    [Nome]             NCHAR (60)  NOT NULL,
    [Login]            NCHAR (50)  NOT NULL,
    [Senha]            NCHAR (50)  NOT NULL,
    [Ativo]            BIT         DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT         DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT         DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME    DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME    DEFAULT (getdate()) NULL
)

GO

CREATE TABLE [dbo].[Veiculos] (
    [Id]               INT        IDENTITY (1, 1) NOT NULL,
    [TipoCodigo]       INT        NOT NULL,
	[MarcaCodigo]      INT        NOT NULL,
    [Modelo]           NCHAR (50) NOT NULL,
    [Placa]            NCHAR (7)  DEFAULT ('XXX9999')NULL,
    [Ano]              INT        DEFAULT ((1800))NULL,
    [Ativo]            BIT        DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT        DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT        DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME   DEFAULT (getdate()) NULL
)

GO

CREATE TABLE [dbo].[TipoVeiculo] (
    [Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Codigo] INT        NULL,
    [Tipo]   NCHAR (20) NULL
)

GO

CREATE TABLE [dbo].[Marcas] (
    [Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Codigo] INT        NULL,
    [Nome]   NCHAR (20) NULL
)

GO

INSERT INTO TipoVeiculo ([Codigo],[Tipo]) VALUES ((1),'Carro') , ((2),'Moto')

GO

INSERT INTO Usuarios ([Nome],[Login],[Senha]) VALUES ('ADMIN','admin','admin')

GO


INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 1, N'100         ', 1, 1)
GO							 
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 1, N'100 Avant   ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 1, N'80          ', 1, 1)
GO							 
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 1, N'80 Avant    ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 1, N'80 Cabriolet', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (2, 20,	N'Concours	   ', 1, 1)
GO							   
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (2, 20,	N'D tracker x  ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (2, 20,	N'ER 5		   ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (2, 20,	N'ER 6n		   ', 1, 1)
GO							
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (2, 20,	N'KLX		   ', 1, 1)
GO							 
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (2, 20,	N'KX		   ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (2, 20,	N'KZ		   ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (2, 20,	N'Maxi II	   ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (2, 20,	N'Ninja		   ', 1, 1)
GO							   
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (2, 20,	N'Versys	   ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (2, 20,	N'Voyager	   ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (2, 20,	N'Vulcan	   ', 1, 1)
GO							   
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (2, 20,	N'Z 1000	   ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (2, 20,	N'Z 300		   ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (2, 20,	N'Z 650		   ', 1, 1)
GO							 
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (2, 20,	N'Z 750		   ', 1, 1)
GO							   
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (2, 20,	N'Z 800		   ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (2, 20,	N'Z 900		   ', 1, 1)
GO							 
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Besta		  ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Bongo		  ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Cadenza		  ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Carens		  ', 1, 1)
GO							 
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Carnival		  ', 1, 1)
GO							 
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Cerato		  ', 1, 1)
GO							 
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Ceres		  ', 1, 1)
GO							 
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Clarus		  ', 1, 1)
GO							
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Grand Carnival ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Magentis		  ', 1, 1)
GO							
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Mohave		  ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Opirus		  ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Optima		  ', 1, 1)
GO							
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Picanto		  ', 1, 1)
GO							
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Quoris		  ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Rio			  ', 1, 1)
GO							
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Sephia		  ', 1, 1)
GO							
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Shuma		  ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Sorento		  ', 1, 1)
GO							 
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Soul			  ', 1, 1)
GO							  
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Sportage		  ', 1, 1)
GO							
INSERT INTO [dbo].[Veiculos] ([TipoCodigo], [MarcaCodigo], [Modelo], [UsuarioCriacao], [UsuarioAlteracao]) VALUES (1, 10, 'Stinger		  ', 1, 1)
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (1, N'Audi     ')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (2, N'BMW      ')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (3, N'Chevrolet')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (4, N'Citröen	')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (5, N'Fiat		')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (6, N'Ford		')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (7, N'Honda	')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (8, N'Hyundai	')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (9, N'Jeep		')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (10,N'Kia		')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (11,N'Mitsubishi')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (12,N'Nissan	 ')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (13,N'Peugeot	 ')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (14,N'Renault	 ')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (15,N'Toyota	 ')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (16,N'Volkswagen ')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (17,N'Dafra')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (18,N'Suzuki	 ')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (19,N'Yamaha	 ')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (20,N'Kawasaki	 ')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (21,N'Ducati	 ')
