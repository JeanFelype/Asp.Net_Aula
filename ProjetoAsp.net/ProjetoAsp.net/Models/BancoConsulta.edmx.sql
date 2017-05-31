
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/31/2017 10:20:45
-- Generated from EDMX file: C:\Users\1614833\Asp-Net\ProjetoAsp.net\ProjetoAsp.net\Models\BancoConsulta.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BancoConsulta];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Pacientes'
CREATE TABLE [dbo].[Pacientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [DataNascimento] nvarchar(max)  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- Creating table 'Consultas'
CREATE TABLE [dbo].[Consultas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Preco] decimal(18,0)  NOT NULL,
    [Data] nvarchar(max)  NOT NULL,
    [Ativo] nvarchar(max)  NOT NULL,
    [PacienteId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Pacientes'
ALTER TABLE [dbo].[Pacientes]
ADD CONSTRAINT [PK_Pacientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Consultas'
ALTER TABLE [dbo].[Consultas]
ADD CONSTRAINT [PK_Consultas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PacienteId] in table 'Consultas'
ALTER TABLE [dbo].[Consultas]
ADD CONSTRAINT [FK_PacienteConsulta]
    FOREIGN KEY ([PacienteId])
    REFERENCES [dbo].[Pacientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteConsulta'
CREATE INDEX [IX_FK_PacienteConsulta]
ON [dbo].[Consultas]
    ([PacienteId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------