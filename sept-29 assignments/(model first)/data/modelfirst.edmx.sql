
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/29/2022 18:55:34
-- Generated from EDMX file: E:\c# assignment\sept-29 assignments(model first)\data\modelfirst.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Northwind];
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

-- Creating table 'borrows'
CREATE TABLE [dbo].[borrows] (
    [borrow_id] int IDENTITY(1,1) NOT NULL,
    [borrow_name] nvarchar(max)  NOT NULL,
    [city] nvarchar(max)  NOT NULL,
    [state] nvarchar(max)  NOT NULL,
    [country] nvarchar(max)  NOT NULL,
    [street] nvarchar(max)  NOT NULL,
    [company_name] nvarchar(max)  NOT NULL,
    [jobname] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'loans'
CREATE TABLE [dbo].[loans] (
    [loanid] int IDENTITY(1,1) NOT NULL,
    [loanname] nvarchar(max)  NOT NULL,
    [amount] nvarchar(max)  NOT NULL,
    [duration] nvarchar(max)  NOT NULL,
    [rateofinterest] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [borrow_id] in table 'borrows'
ALTER TABLE [dbo].[borrows]
ADD CONSTRAINT [PK_borrows]
    PRIMARY KEY CLUSTERED ([borrow_id] ASC);
GO

-- Creating primary key on [loanid] in table 'loans'
ALTER TABLE [dbo].[loans]
ADD CONSTRAINT [PK_loans]
    PRIMARY KEY CLUSTERED ([loanid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------