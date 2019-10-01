CREATE DATABASE BaseDeDadosHbsis

GO

USE BaseDeDadosHbsis

GO

CREATE TABLE [dbo].[Usuarios] (
    [Id]               INT         IDENTITY (1, 1) NOT NULL,
    [Nome]             NVARCHAR (60)  NOT NULL,
    [Login]            NVARCHAR (50)  NOT NULL,
    [Senha]            NVARCHAR (50)  NOT NULL,
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
    [Modelo]           NVARCHAR (50) NOT NULL,
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
    [Tipo]   NVARCHAR (20) NULL
)

GO

CREATE TABLE [dbo].[Marcas] (
    [Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Codigo] INT        NULL,
    [Nome]   NVARCHAR (20) NULL
)