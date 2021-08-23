
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/20/2021 17:19:09
-- Generated from EDMX file: C:\Users\Nastya.Nazarycheva\source\repos\CsProjects\VetClinicApp\VetClinicModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Dbconnection];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Pet_Owner]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pet] DROP CONSTRAINT [FK_Pet_Owner];
GO
IF OBJECT_ID(N'[dbo].[FK_TreatmentСase_DoctorId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TreatmentСase] DROP CONSTRAINT [FK_TreatmentСase_DoctorId];
GO
IF OBJECT_ID(N'[dbo].[FK_TreatmentСase_PetId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TreatmentСase] DROP CONSTRAINT [FK_TreatmentСase_PetId];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Doctor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Doctor];
GO
IF OBJECT_ID(N'[dbo].[Images]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Images];
GO
IF OBJECT_ID(N'[dbo].[Owner]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Owner];
GO
IF OBJECT_ID(N'[dbo].[Pet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pet];
GO
IF OBJECT_ID(N'[dbo].[Service]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Service];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[TreatmentСase]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TreatmentСase];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Doctors'
CREATE TABLE [dbo].[Doctors] (
    [DoctorId] int  NOT NULL,
    [Lastname] nchar(50)  NOT NULL,
    [Firstname] nchar(50)  NOT NULL,
    [Fathername] nchar(50)  NULL,
    [Birthday] datetime  NULL,
    [Qualification] nchar(50)  NULL,
    [Phone] nchar(30)  NULL,
    [Photo] int  NULL
);
GO

-- Creating table 'Owners'
CREATE TABLE [dbo].[Owners] (
    [OwnerId] int  NOT NULL,
    [LastName] nchar(50)  NOT NULL,
    [FirstName] nchar(50)  NOT NULL,
    [FatherName] nchar(50)  NULL,
    [Birthday] datetime  NOT NULL,
    [Telephone] nchar(50)  NOT NULL,
    [E_mail] nchar(50)  NULL,
    [Address] nchar(250)  NULL
);
GO

-- Creating table 'Pets'
CREATE TABLE [dbo].[Pets] (
    [PetId] int  NOT NULL,
    [Name] nchar(50)  NOT NULL,
    [Sex] nchar(10)  NOT NULL,
    [Birthday] nchar(15)  NULL,
    [Species] nchar(10)  NOT NULL,
    [BreedType] nchar(10)  NULL,
    [Colour] nchar(10)  NOT NULL,
    [OwnerID] int  NULL,
    [Сomment] nvarchar(max)  NULL
);
GO

-- Creating table 'Services'
CREATE TABLE [dbo].[Services] (
    [ServiceId] int  NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Price] nchar(10)  NULL
);
GO

-- Creating table 'TreatmentСase'
CREATE TABLE [dbo].[TreatmentСase] (
    [TreatmentСaseId] int  NOT NULL,
    [Data] datetime  NOT NULL,
    [Number] int  NOT NULL,
    [DoctorID] int  NOT NULL,
    [PetID] int  NOT NULL,
    [VisualInspection] nvarchar(250)  NULL,
    [Anamnesis] nvarchar(250)  NULL,
    [Diagnosis] nchar(30)  NULL,
    [Cause] nchar(50)  NULL,
    [Conclusion] nvarchar(250)  NULL
);
GO

-- Creating table 'Images'
CREATE TABLE [dbo].[Images] (
    [Id] int  NOT NULL,
    [Images] varchar(max)  NOT NULL,
    [Path] varchar(max)  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [DoctorId] in table 'Doctors'
ALTER TABLE [dbo].[Doctors]
ADD CONSTRAINT [PK_Doctors]
    PRIMARY KEY CLUSTERED ([DoctorId] ASC);
GO

-- Creating primary key on [OwnerId] in table 'Owners'
ALTER TABLE [dbo].[Owners]
ADD CONSTRAINT [PK_Owners]
    PRIMARY KEY CLUSTERED ([OwnerId] ASC);
GO

-- Creating primary key on [PetId] in table 'Pets'
ALTER TABLE [dbo].[Pets]
ADD CONSTRAINT [PK_Pets]
    PRIMARY KEY CLUSTERED ([PetId] ASC);
GO

-- Creating primary key on [ServiceId] in table 'Services'
ALTER TABLE [dbo].[Services]
ADD CONSTRAINT [PK_Services]
    PRIMARY KEY CLUSTERED ([ServiceId] ASC);
GO

-- Creating primary key on [TreatmentСaseId] in table 'TreatmentСase'
ALTER TABLE [dbo].[TreatmentСase]
ADD CONSTRAINT [PK_TreatmentСase]
    PRIMARY KEY CLUSTERED ([TreatmentСaseId] ASC);
GO

-- Creating primary key on [Id] in table 'Images'
ALTER TABLE [dbo].[Images]
ADD CONSTRAINT [PK_Images]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DoctorID] in table 'TreatmentСase'
ALTER TABLE [dbo].[TreatmentСase]
ADD CONSTRAINT [FK_TreatmentСase_DoctorId]
    FOREIGN KEY ([DoctorID])
    REFERENCES [dbo].[Doctors]
        ([DoctorId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TreatmentСase_DoctorId'
CREATE INDEX [IX_FK_TreatmentСase_DoctorId]
ON [dbo].[TreatmentСase]
    ([DoctorID]);
GO

-- Creating foreign key on [OwnerID] in table 'Pets'
ALTER TABLE [dbo].[Pets]
ADD CONSTRAINT [FK_Pet_Owner]
    FOREIGN KEY ([OwnerID])
    REFERENCES [dbo].[Owners]
        ([OwnerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Pet_Owner'
CREATE INDEX [IX_FK_Pet_Owner]
ON [dbo].[Pets]
    ([OwnerID]);
GO

-- Creating foreign key on [PetID] in table 'TreatmentСase'
ALTER TABLE [dbo].[TreatmentСase]
ADD CONSTRAINT [FK_TreatmentСase_PetId]
    FOREIGN KEY ([PetID])
    REFERENCES [dbo].[Pets]
        ([PetId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TreatmentСase_PetId'
CREATE INDEX [IX_FK_TreatmentСase_PetId]
ON [dbo].[TreatmentСase]
    ([PetID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------