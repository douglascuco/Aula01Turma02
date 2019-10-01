create database BaseSistemaLocacao
GO
Use BaseSistemaLocacao
GO

create table Usuarios
(
    [Id]               INT         IDENTITY (1, 1) NOT NULL,
    [Nome]             NCHAR (100) NOT NULL,
    [Login]            NCHAR (50)  NOT NULL,
    [Senha]            NCHAR (50)  NOT NULL,
    [Ativo]            BIT         DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT         DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT         DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME    DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME    DEFAULT (getdate()) NULL
)

GO

create table Marcas 
(
    [Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Codigo] INT        NULL,
    [Nome]   NCHAR (20) NULL
)

Go

create table Locacoes
(
    [Id]               INT      IDENTITY (1, 1) NOT NULL,
    [UsuarioId]        INT      NOT NULL,
    [VeiculoId]        INT      NOT NULL,
    [Valor]            MONEY    NOT NULL,
    [DataInicio]       DATETIME DEFAULT (getdate()) NULL,
    [DataDevolucao]    DATETIME DEFAULT (dateadd(day, (5), getdate())) NULL,
    [Ativo]            BIT      DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT      DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT      DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME DEFAULT (getdate()) NULL
)

GO

create table Carros 
(
    [Id]               INT        IDENTITY (1, 1) NOT NULL,
    [MarcaCodigo]      INT        NOT NULL,
    [Modelo]           NCHAR (50) NOT NULL,
    [Placa]            NCHAR (7)  NOT NULL,
    [Ano]              INT        NOT NULL,
    [Ativo]            BIT        DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT        DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT        DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME   DEFAULT (getdate()) NULL
)

GO

INSERT INTO Usuarios ([Nome],[Login],[Senha]) values ('ADMIN','admin','admin')

GO

--SET IDENTITY_INSERT [dbo].[Carros] ON
--INSERT INTO [dbo].[Carros] ([Id], [MarcaCodigo], [Modelo], [Placa], [Ano], [Ativo], [UsuarioCriacao], [UsuarioAlteracao], [DataCriacao], [DataAlteracao]) VALUES (1, 1, N'Fusca                                             ', N'XXL6969', 1965, 1, 1, 1, N'2019-10-01 09:15:31', N'2019-10-01 09:15:31')
--INSERT INTO [dbo].[Carros] ([Id], [MarcaCodigo], [Modelo], [Placa], [Ano], [Ativo], [UsuarioCriacao], [UsuarioAlteracao], [DataCriacao], [DataAlteracao]) VALUES (2, 3, N'Uno                                               ', N'LOL2121', 2000, 1, 1, 1, N'2019-10-01 09:16:28', N'2019-10-01 09:16:28')
--INSERT INTO [dbo].[Carros] ([Id], [MarcaCodigo], [Modelo], [Placa], [Ano], [Ativo], [UsuarioCriacao], [UsuarioAlteracao], [DataCriacao], [DataAlteracao]) VALUES (3, 2, N'Chevette                                          ', N'TBR7474', 1984, 1, 1, 1, N'2019-10-01 09:19:18', N'2019-10-01 09:19:18')
--INSERT INTO [dbo].[Carros] ([Id], [MarcaCodigo], [Modelo], [Placa], [Ano], [Ativo], [UsuarioCriacao], [UsuarioAlteracao], [DataCriacao], [DataAlteracao]) VALUES (4, 1, N'Gol 1.6                                           ', N'MTH5689', 2004, 1, 1, 1, N'2019-10-01 10:28:11', N'2019-10-01 10:28:11')
--INSERT INTO [dbo].[Carros] ([Id], [MarcaCodigo], [Modelo], [Placa], [Ano], [Ativo], [UsuarioCriacao], [UsuarioAlteracao], [DataCriacao], [DataAlteracao]) VALUES (5, 5, N'TT                                                ', N'SSS1000', 2018, 1, 1, 1, N'2019-10-01 10:30:16', N'2019-10-01 10:30:16')
--INSERT INTO [dbo].[Carros] ([Id], [MarcaCodigo], [Modelo], [Placa], [Ano], [Ativo], [UsuarioCriacao], [UsuarioAlteracao], [DataCriacao], [DataAlteracao]) VALUES (6, 4, N'Cerato                                            ', N'KEK5986', 2016, 1, 1, 1, N'2019-10-01 10:30:55', N'2019-10-01 10:30:55')
--INSERT INTO [dbo].[Carros] ([Id], [MarcaCodigo], [Modelo], [Placa], [Ano], [Ativo], [UsuarioCriacao], [UsuarioAlteracao], [DataCriacao], [DataAlteracao]) VALUES (7, 3, N'Siena                                             ', N'LEP4735', 2013, 1, 1, 1, N'2019-10-01 10:32:23', N'2019-10-01 10:32:23')
--SET IDENTITY_INSERT [dbo].[Carros] OFF
--
--GO
--
--SET IDENTITY_INSERT [dbo].[Locacoes] ON
--INSERT INTO [dbo].[Locacoes] ([Id], [UsuarioId], [VeiculoId], [Valor], [DataInicio], [DataDevolucao], [Ativo], [UsuarioCriacao], [UsuarioAlteracao], [DataCriacao], [DataAlteracao]) VALUES (1, 1, 3, CAST(200.5000 AS Money), N'2019-09-30 16:45:25', N'2019-10-05 16:45:25', 1, 1, 1, N'2019-09-30 16:45:25', N'2019-09-30 16:45:25')
--INSERT INTO [dbo].[Locacoes] ([Id], [UsuarioId], [VeiculoId], [Valor], [DataInicio], [DataDevolucao], [Ativo], [UsuarioCriacao], [UsuarioAlteracao], [DataCriacao], [DataAlteracao]) VALUES (3, 1, 1, CAST(299.9900 AS Money), N'2019-10-01 09:24:49', N'2019-10-06 09:24:49', 1, 1, 1, N'2019-10-01 09:24:49', N'2019-10-01 09:24:49')
--INSERT INTO [dbo].[Locacoes] ([Id], [UsuarioId], [VeiculoId], [Valor], [DataInicio], [DataDevolucao], [Ativo], [UsuarioCriacao], [UsuarioAlteracao], [DataCriacao], [DataAlteracao]) VALUES (4, 1, 3, CAST(499.9500 AS Money), N'2019-10-01 09:25:26', N'2019-10-06 09:25:26', 1, 1, 1, N'2019-10-01 09:25:26', N'2019-10-01 09:25:26')
--INSERT INTO [dbo].[Locacoes] ([Id], [UsuarioId], [VeiculoId], [Valor], [DataInicio], [DataDevolucao], [Ativo], [UsuarioCriacao], [UsuarioAlteracao], [DataCriacao], [DataAlteracao]) VALUES (5, 1, 2, CAST(899.5000 AS Money), N'2019-10-01 09:26:19', N'2019-11-25 00:00:00', 1, 1, 1, N'2019-10-01 09:26:19', N'2019-10-01 09:26:19')
--SET IDENTITY_INSERT [dbo].[Locacoes] OFF
--
--GO 

SET IDENTITY_INSERT [dbo].[Marcas] ON
INSERT INTO [dbo].[Marcas] ([Id], [Codigo], [Nome]) VALUES (1, 1, N'Volkswagen          ')
INSERT INTO [dbo].[Marcas] ([Id], [Codigo], [Nome]) VALUES (2, 2, N'Chevrolet           ')
INSERT INTO [dbo].[Marcas] ([Id], [Codigo], [Nome]) VALUES (3, 3, N'Fiat                ')
INSERT INTO [dbo].[Marcas] ([Id], [Codigo], [Nome]) VALUES (4, 4, N'Kia                 ')
INSERT INTO [dbo].[Marcas] ([Id], [Codigo], [Nome]) VALUES (5, 5, N'Audi                ')
SET IDENTITY_INSERT [dbo].[Marcas] OFF