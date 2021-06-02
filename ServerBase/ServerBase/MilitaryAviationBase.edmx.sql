
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/30/2021 21:23:29
-- Generated from EDMX file: H:\Baze Podataka 2\Projekat\ServerBase\ServerBase\MilitaryAviationBase.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MilitaryAviationBase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AvioTehnicarPretpoletniPregled]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PretpoletniPregleds] DROP CONSTRAINT [FK_AvioTehnicarPretpoletniPregled];
GO
IF OBJECT_ID(N'[dbo].[FK_AvionPretpoletniPregled]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PretpoletniPregleds] DROP CONSTRAINT [FK_AvionPretpoletniPregled];
GO
IF OBJECT_ID(N'[dbo].[FK_Leti]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pilots] DROP CONSTRAINT [FK_Leti];
GO
IF OBJECT_ID(N'[dbo].[FK_IzvestavaOZL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Izvestavas] DROP CONSTRAINT [FK_IzvestavaOZL];
GO
IF OBJECT_ID(N'[dbo].[FK_Radi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AvioTehnicari] DROP CONSTRAINT [FK_Radi];
GO
IF OBJECT_ID(N'[dbo].[FK_OZLPilot]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pilots] DROP CONSTRAINT [FK_OZLPilot];
GO
IF OBJECT_ID(N'[dbo].[FK_NaoruzanjeLovac]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Naoruzanjes] DROP CONSTRAINT [FK_NaoruzanjeLovac];
GO
IF OBJECT_ID(N'[dbo].[FK_NaoruzanjeElektroOpremaVazduhoplova]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Naoruzanjes] DROP CONSTRAINT [FK_NaoruzanjeElektroOpremaVazduhoplova];
GO
IF OBJECT_ID(N'[dbo].[FK_OCUzima]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Uzimas] DROP CONSTRAINT [FK_OCUzima];
GO
IF OBJECT_ID(N'[dbo].[FK_NaoruzanjeUzima]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Uzimas] DROP CONSTRAINT [FK_NaoruzanjeUzima];
GO
IF OBJECT_ID(N'[dbo].[FK_AvioTehnicarEskadrila]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AvioTehnicari] DROP CONSTRAINT [FK_AvioTehnicarEskadrila];
GO
IF OBJECT_ID(N'[dbo].[FK_IzvestavaPretpoletniPregled]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Izvestavas] DROP CONSTRAINT [FK_IzvestavaPretpoletniPregled];
GO
IF OBJECT_ID(N'[dbo].[FK_EskadrilaPilot]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pilots] DROP CONSTRAINT [FK_EskadrilaPilot];
GO
IF OBJECT_ID(N'[dbo].[FK_Lovac_inherits_Avion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Avions_Lovac] DROP CONSTRAINT [FK_Lovac_inherits_Avion];
GO
IF OBJECT_ID(N'[dbo].[FK_ElektroOpremaVazduhoplova_inherits_AvioTehnicar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AvioTehnicari_ElektroOpremaVazduhoplova] DROP CONSTRAINT [FK_ElektroOpremaVazduhoplova_inherits_AvioTehnicar];
GO
IF OBJECT_ID(N'[dbo].[FK_VazduhoplovIMotor_inherits_AvioTehnicar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AvioTehnicari_VazduhoplovIMotor] DROP CONSTRAINT [FK_VazduhoplovIMotor_inherits_AvioTehnicar];
GO
IF OBJECT_ID(N'[dbo].[FK_ElektronskaOpremaVazduhoplova_inherits_AvioTehnicar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AvioTehnicari_ElektronskaOpremaVazduhoplova] DROP CONSTRAINT [FK_ElektronskaOpremaVazduhoplova_inherits_AvioTehnicar];
GO
IF OBJECT_ID(N'[dbo].[FK_Transportni_inherits_Avion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Avions_Transportni] DROP CONSTRAINT [FK_Transportni_inherits_Avion];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Radionice]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Radionice];
GO
IF OBJECT_ID(N'[dbo].[AvioTehnicari]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AvioTehnicari];
GO
IF OBJECT_ID(N'[dbo].[Eskadrile]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Eskadrile];
GO
IF OBJECT_ID(N'[dbo].[Avions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Avions];
GO
IF OBJECT_ID(N'[dbo].[PretpoletniPregleds]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PretpoletniPregleds];
GO
IF OBJECT_ID(N'[dbo].[Pilots]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pilots];
GO
IF OBJECT_ID(N'[dbo].[OZLs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OZLs];
GO
IF OBJECT_ID(N'[dbo].[Izvestavas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Izvestavas];
GO
IF OBJECT_ID(N'[dbo].[Naoruzanjes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Naoruzanjes];
GO
IF OBJECT_ID(N'[dbo].[OCs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OCs];
GO
IF OBJECT_ID(N'[dbo].[Uzimas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Uzimas];
GO
IF OBJECT_ID(N'[dbo].[Avions_Lovac]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Avions_Lovac];
GO
IF OBJECT_ID(N'[dbo].[AvioTehnicari_ElektroOpremaVazduhoplova]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AvioTehnicari_ElektroOpremaVazduhoplova];
GO
IF OBJECT_ID(N'[dbo].[AvioTehnicari_VazduhoplovIMotor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AvioTehnicari_VazduhoplovIMotor];
GO
IF OBJECT_ID(N'[dbo].[AvioTehnicari_ElektronskaOpremaVazduhoplova]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AvioTehnicari_ElektronskaOpremaVazduhoplova];
GO
IF OBJECT_ID(N'[dbo].[Avions_Transportni]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Avions_Transportni];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Radionice'
CREATE TABLE [dbo].[Radionice] (
    [ID_RAD] int IDENTITY(1,1) NOT NULL,
    [IME_RAD] nvarchar(max)  NOT NULL,
    [BM_RAD] int  NOT NULL
);
GO

-- Creating table 'AvioTehnicari'
CREATE TABLE [dbo].[AvioTehnicari] (
    [ID_AT] int IDENTITY(1,1) NOT NULL,
    [IME_AT] nvarchar(max)  NOT NULL,
    [BG_AT] int  NOT NULL,
    [RadionicaID_RAD] int  NULL,
    [EskadrilaID_ESK] int  NULL,
    [TIP_AT] int  NOT NULL
);
GO

-- Creating table 'Eskadrile'
CREATE TABLE [dbo].[Eskadrile] (
    [ID_ESK] int IDENTITY(1,1) NOT NULL,
    [GRB_ESK] nvarchar(max)  NOT NULL,
    [IME_ESK] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Avions'
CREATE TABLE [dbo].[Avions] (
    [ID_AV] int IDENTITY(1,1) NOT NULL,
    [HP_AV] int  NOT NULL,
    [BL_AV] nvarchar(max)  NOT NULL,
    [TIP_AV] int  NOT NULL
);
GO

-- Creating table 'PretpoletniPregleds'
CREATE TABLE [dbo].[PretpoletniPregleds] (
    [AvioTehnicarID_AT] int  NOT NULL,
    [AvionID_AV] int  NOT NULL
);
GO

-- Creating table 'Pilots'
CREATE TABLE [dbo].[Pilots] (
    [ID_PIL] int IDENTITY(1,1) NOT NULL,
    [RN_PIL] nvarchar(max)  NOT NULL,
    [AvionID_AV] int  NULL,
    [OZLID_OZL] int  NULL,
    [EskadrilaID_ESK1] int  NULL
);
GO

-- Creating table 'OZLs'
CREATE TABLE [dbo].[OZLs] (
    [ID_OZL] int IDENTITY(1,1) NOT NULL,
    [ADR_OZL] nvarchar(max)  NOT NULL,
    [NO_OZL] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Izvestavas'
CREATE TABLE [dbo].[Izvestavas] (
    [ID_OZL] int IDENTITY(1,1) NOT NULL,
    [PretpoletniPregledID_AV] int  NOT NULL,
    [PretpoletniPregledID_AT] int  NOT NULL,
    [OZL_ID_OZL] int  NOT NULL,
    [PretpoletniPregled_AvioTehnicarID_AT] int  NOT NULL,
    [PretpoletniPregled_AvionID_AV] int  NOT NULL
);
GO

-- Creating table 'Naoruzanjes'
CREATE TABLE [dbo].[Naoruzanjes] (
    [LovacID_AV] int  NOT NULL,
    [ElektroOpremaVazduhoplovaID_AT] int  NOT NULL
);
GO

-- Creating table 'OCs'
CREATE TABLE [dbo].[OCs] (
    [ID_OC] int IDENTITY(1,1) NOT NULL,
    [BBG_OC] int  NOT NULL
);
GO

-- Creating table 'Uzimas'
CREATE TABLE [dbo].[Uzimas] (
    [OCID_OC] int  NOT NULL,
    [NaoruzanjeLovacID_AV] int  NOT NULL,
    [NaoruzanjeElektroOpremaVazduhoplovaID_AT] int  NOT NULL
);
GO

-- Creating table 'Avions_Lovac'
CREATE TABLE [dbo].[Avions_Lovac] (
    [SMR_AV] nvarchar(max)  NOT NULL,
    [ID_AV] int  NOT NULL
);
GO

-- Creating table 'AvioTehnicari_ElektroOpremaVazduhoplova'
CREATE TABLE [dbo].[AvioTehnicari_ElektroOpremaVazduhoplova] (
    [ID_AT] int  NOT NULL
);
GO

-- Creating table 'AvioTehnicari_VazduhoplovIMotor'
CREATE TABLE [dbo].[AvioTehnicari_VazduhoplovIMotor] (
    [ID_AT] int  NOT NULL
);
GO

-- Creating table 'AvioTehnicari_ElektronskaOpremaVazduhoplova'
CREATE TABLE [dbo].[AvioTehnicari_ElektronskaOpremaVazduhoplova] (
    [ID_AT] int  NOT NULL
);
GO

-- Creating table 'Avions_Transportni'
CREATE TABLE [dbo].[Avions_Transportni] (
    [SMP_AV] nvarchar(max)  NOT NULL,
    [ID_AV] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID_RAD] in table 'Radionice'
ALTER TABLE [dbo].[Radionice]
ADD CONSTRAINT [PK_Radionice]
    PRIMARY KEY CLUSTERED ([ID_RAD] ASC);
GO

-- Creating primary key on [ID_AT] in table 'AvioTehnicari'
ALTER TABLE [dbo].[AvioTehnicari]
ADD CONSTRAINT [PK_AvioTehnicari]
    PRIMARY KEY CLUSTERED ([ID_AT] ASC);
GO

-- Creating primary key on [ID_ESK] in table 'Eskadrile'
ALTER TABLE [dbo].[Eskadrile]
ADD CONSTRAINT [PK_Eskadrile]
    PRIMARY KEY CLUSTERED ([ID_ESK] ASC);
GO

-- Creating primary key on [ID_AV] in table 'Avions'
ALTER TABLE [dbo].[Avions]
ADD CONSTRAINT [PK_Avions]
    PRIMARY KEY CLUSTERED ([ID_AV] ASC);
GO

-- Creating primary key on [AvioTehnicarID_AT], [AvionID_AV] in table 'PretpoletniPregleds'
ALTER TABLE [dbo].[PretpoletniPregleds]
ADD CONSTRAINT [PK_PretpoletniPregleds]
    PRIMARY KEY CLUSTERED ([AvioTehnicarID_AT], [AvionID_AV] ASC);
GO

-- Creating primary key on [ID_PIL] in table 'Pilots'
ALTER TABLE [dbo].[Pilots]
ADD CONSTRAINT [PK_Pilots]
    PRIMARY KEY CLUSTERED ([ID_PIL] ASC);
GO

-- Creating primary key on [ID_OZL] in table 'OZLs'
ALTER TABLE [dbo].[OZLs]
ADD CONSTRAINT [PK_OZLs]
    PRIMARY KEY CLUSTERED ([ID_OZL] ASC);
GO

-- Creating primary key on [ID_OZL], [PretpoletniPregledID_AV], [PretpoletniPregledID_AT] in table 'Izvestavas'
ALTER TABLE [dbo].[Izvestavas]
ADD CONSTRAINT [PK_Izvestavas]
    PRIMARY KEY CLUSTERED ([ID_OZL], [PretpoletniPregledID_AV], [PretpoletniPregledID_AT] ASC);
GO

-- Creating primary key on [LovacID_AV], [ElektroOpremaVazduhoplovaID_AT] in table 'Naoruzanjes'
ALTER TABLE [dbo].[Naoruzanjes]
ADD CONSTRAINT [PK_Naoruzanjes]
    PRIMARY KEY CLUSTERED ([LovacID_AV], [ElektroOpremaVazduhoplovaID_AT] ASC);
GO

-- Creating primary key on [ID_OC] in table 'OCs'
ALTER TABLE [dbo].[OCs]
ADD CONSTRAINT [PK_OCs]
    PRIMARY KEY CLUSTERED ([ID_OC] ASC);
GO

-- Creating primary key on [OCID_OC], [NaoruzanjeLovacID_AV], [NaoruzanjeElektroOpremaVazduhoplovaID_AT] in table 'Uzimas'
ALTER TABLE [dbo].[Uzimas]
ADD CONSTRAINT [PK_Uzimas]
    PRIMARY KEY CLUSTERED ([OCID_OC], [NaoruzanjeLovacID_AV], [NaoruzanjeElektroOpremaVazduhoplovaID_AT] ASC);
GO

-- Creating primary key on [ID_AV] in table 'Avions_Lovac'
ALTER TABLE [dbo].[Avions_Lovac]
ADD CONSTRAINT [PK_Avions_Lovac]
    PRIMARY KEY CLUSTERED ([ID_AV] ASC);
GO

-- Creating primary key on [ID_AT] in table 'AvioTehnicari_ElektroOpremaVazduhoplova'
ALTER TABLE [dbo].[AvioTehnicari_ElektroOpremaVazduhoplova]
ADD CONSTRAINT [PK_AvioTehnicari_ElektroOpremaVazduhoplova]
    PRIMARY KEY CLUSTERED ([ID_AT] ASC);
GO

-- Creating primary key on [ID_AT] in table 'AvioTehnicari_VazduhoplovIMotor'
ALTER TABLE [dbo].[AvioTehnicari_VazduhoplovIMotor]
ADD CONSTRAINT [PK_AvioTehnicari_VazduhoplovIMotor]
    PRIMARY KEY CLUSTERED ([ID_AT] ASC);
GO

-- Creating primary key on [ID_AT] in table 'AvioTehnicari_ElektronskaOpremaVazduhoplova'
ALTER TABLE [dbo].[AvioTehnicari_ElektronskaOpremaVazduhoplova]
ADD CONSTRAINT [PK_AvioTehnicari_ElektronskaOpremaVazduhoplova]
    PRIMARY KEY CLUSTERED ([ID_AT] ASC);
GO

-- Creating primary key on [ID_AV] in table 'Avions_Transportni'
ALTER TABLE [dbo].[Avions_Transportni]
ADD CONSTRAINT [PK_Avions_Transportni]
    PRIMARY KEY CLUSTERED ([ID_AV] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AvioTehnicarID_AT] in table 'PretpoletniPregleds'
ALTER TABLE [dbo].[PretpoletniPregleds]
ADD CONSTRAINT [FK_AvioTehnicarPretpoletniPregled]
    FOREIGN KEY ([AvioTehnicarID_AT])
    REFERENCES [dbo].[AvioTehnicari]
        ([ID_AT])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [AvionID_AV] in table 'PretpoletniPregleds'
ALTER TABLE [dbo].[PretpoletniPregleds]
ADD CONSTRAINT [FK_AvionPretpoletniPregled]
    FOREIGN KEY ([AvionID_AV])
    REFERENCES [dbo].[Avions]
        ([ID_AV])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AvionPretpoletniPregled'
CREATE INDEX [IX_FK_AvionPretpoletniPregled]
ON [dbo].[PretpoletniPregleds]
    ([AvionID_AV]);
GO

-- Creating foreign key on [AvionID_AV] in table 'Pilots'
ALTER TABLE [dbo].[Pilots]
ADD CONSTRAINT [FK_Leti]
    FOREIGN KEY ([AvionID_AV])
    REFERENCES [dbo].[Avions]
        ([ID_AV])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Leti'
CREATE INDEX [IX_FK_Leti]
ON [dbo].[Pilots]
    ([AvionID_AV]);
GO

-- Creating foreign key on [OZL_ID_OZL] in table 'Izvestavas'
ALTER TABLE [dbo].[Izvestavas]
ADD CONSTRAINT [FK_IzvestavaOZL]
    FOREIGN KEY ([OZL_ID_OZL])
    REFERENCES [dbo].[OZLs]
        ([ID_OZL])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IzvestavaOZL'
CREATE INDEX [IX_FK_IzvestavaOZL]
ON [dbo].[Izvestavas]
    ([OZL_ID_OZL]);
GO

-- Creating foreign key on [RadionicaID_RAD] in table 'AvioTehnicari'
ALTER TABLE [dbo].[AvioTehnicari]
ADD CONSTRAINT [FK_Radi]
    FOREIGN KEY ([RadionicaID_RAD])
    REFERENCES [dbo].[Radionice]
        ([ID_RAD])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Radi'
CREATE INDEX [IX_FK_Radi]
ON [dbo].[AvioTehnicari]
    ([RadionicaID_RAD]);
GO

-- Creating foreign key on [OZLID_OZL] in table 'Pilots'
ALTER TABLE [dbo].[Pilots]
ADD CONSTRAINT [FK_OZLPilot]
    FOREIGN KEY ([OZLID_OZL])
    REFERENCES [dbo].[OZLs]
        ([ID_OZL])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OZLPilot'
CREATE INDEX [IX_FK_OZLPilot]
ON [dbo].[Pilots]
    ([OZLID_OZL]);
GO

-- Creating foreign key on [LovacID_AV] in table 'Naoruzanjes'
ALTER TABLE [dbo].[Naoruzanjes]
ADD CONSTRAINT [FK_NaoruzanjeLovac]
    FOREIGN KEY ([LovacID_AV])
    REFERENCES [dbo].[Avions_Lovac]
        ([ID_AV])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ElektroOpremaVazduhoplovaID_AT] in table 'Naoruzanjes'
ALTER TABLE [dbo].[Naoruzanjes]
ADD CONSTRAINT [FK_NaoruzanjeElektroOpremaVazduhoplova]
    FOREIGN KEY ([ElektroOpremaVazduhoplovaID_AT])
    REFERENCES [dbo].[AvioTehnicari_ElektroOpremaVazduhoplova]
        ([ID_AT])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NaoruzanjeElektroOpremaVazduhoplova'
CREATE INDEX [IX_FK_NaoruzanjeElektroOpremaVazduhoplova]
ON [dbo].[Naoruzanjes]
    ([ElektroOpremaVazduhoplovaID_AT]);
GO

-- Creating foreign key on [OCID_OC] in table 'Uzimas'
ALTER TABLE [dbo].[Uzimas]
ADD CONSTRAINT [FK_OCUzima]
    FOREIGN KEY ([OCID_OC])
    REFERENCES [dbo].[OCs]
        ([ID_OC])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NaoruzanjeLovacID_AV], [NaoruzanjeElektroOpremaVazduhoplovaID_AT] in table 'Uzimas'
ALTER TABLE [dbo].[Uzimas]
ADD CONSTRAINT [FK_NaoruzanjeUzima]
    FOREIGN KEY ([NaoruzanjeLovacID_AV], [NaoruzanjeElektroOpremaVazduhoplovaID_AT])
    REFERENCES [dbo].[Naoruzanjes]
        ([LovacID_AV], [ElektroOpremaVazduhoplovaID_AT])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NaoruzanjeUzima'
CREATE INDEX [IX_FK_NaoruzanjeUzima]
ON [dbo].[Uzimas]
    ([NaoruzanjeLovacID_AV], [NaoruzanjeElektroOpremaVazduhoplovaID_AT]);
GO

-- Creating foreign key on [EskadrilaID_ESK] in table 'AvioTehnicari'
ALTER TABLE [dbo].[AvioTehnicari]
ADD CONSTRAINT [FK_AvioTehnicarEskadrila]
    FOREIGN KEY ([EskadrilaID_ESK])
    REFERENCES [dbo].[Eskadrile]
        ([ID_ESK])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AvioTehnicarEskadrila'
CREATE INDEX [IX_FK_AvioTehnicarEskadrila]
ON [dbo].[AvioTehnicari]
    ([EskadrilaID_ESK]);
GO

-- Creating foreign key on [PretpoletniPregled_AvioTehnicarID_AT], [PretpoletniPregled_AvionID_AV] in table 'Izvestavas'
ALTER TABLE [dbo].[Izvestavas]
ADD CONSTRAINT [FK_IzvestavaPretpoletniPregled]
    FOREIGN KEY ([PretpoletniPregled_AvioTehnicarID_AT], [PretpoletniPregled_AvionID_AV])
    REFERENCES [dbo].[PretpoletniPregleds]
        ([AvioTehnicarID_AT], [AvionID_AV])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IzvestavaPretpoletniPregled'
CREATE INDEX [IX_FK_IzvestavaPretpoletniPregled]
ON [dbo].[Izvestavas]
    ([PretpoletniPregled_AvioTehnicarID_AT], [PretpoletniPregled_AvionID_AV]);
GO

-- Creating foreign key on [EskadrilaID_ESK1] in table 'Pilots'
ALTER TABLE [dbo].[Pilots]
ADD CONSTRAINT [FK_EskadrilaPilot]
    FOREIGN KEY ([EskadrilaID_ESK1])
    REFERENCES [dbo].[Eskadrile]
        ([ID_ESK])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EskadrilaPilot'
CREATE INDEX [IX_FK_EskadrilaPilot]
ON [dbo].[Pilots]
    ([EskadrilaID_ESK1]);
GO

-- Creating foreign key on [ID_AV] in table 'Avions_Lovac'
ALTER TABLE [dbo].[Avions_Lovac]
ADD CONSTRAINT [FK_Lovac_inherits_Avion]
    FOREIGN KEY ([ID_AV])
    REFERENCES [dbo].[Avions]
        ([ID_AV])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ID_AT] in table 'AvioTehnicari_ElektroOpremaVazduhoplova'
ALTER TABLE [dbo].[AvioTehnicari_ElektroOpremaVazduhoplova]
ADD CONSTRAINT [FK_ElektroOpremaVazduhoplova_inherits_AvioTehnicar]
    FOREIGN KEY ([ID_AT])
    REFERENCES [dbo].[AvioTehnicari]
        ([ID_AT])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ID_AT] in table 'AvioTehnicari_VazduhoplovIMotor'
ALTER TABLE [dbo].[AvioTehnicari_VazduhoplovIMotor]
ADD CONSTRAINT [FK_VazduhoplovIMotor_inherits_AvioTehnicar]
    FOREIGN KEY ([ID_AT])
    REFERENCES [dbo].[AvioTehnicari]
        ([ID_AT])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ID_AT] in table 'AvioTehnicari_ElektronskaOpremaVazduhoplova'
ALTER TABLE [dbo].[AvioTehnicari_ElektronskaOpremaVazduhoplova]
ADD CONSTRAINT [FK_ElektronskaOpremaVazduhoplova_inherits_AvioTehnicar]
    FOREIGN KEY ([ID_AT])
    REFERENCES [dbo].[AvioTehnicari]
        ([ID_AT])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ID_AV] in table 'Avions_Transportni'
ALTER TABLE [dbo].[Avions_Transportni]
ADD CONSTRAINT [FK_Transportni_inherits_Avion]
    FOREIGN KEY ([ID_AV])
    REFERENCES [dbo].[Avions]
        ([ID_AV])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------