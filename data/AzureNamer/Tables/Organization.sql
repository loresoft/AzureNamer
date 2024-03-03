CREATE TABLE [AN].[Organization]
(
    [Id] INT IDENTITY (1000, 1) NOT NULL,

    [Name] NVARCHAR(100) NOT NULL,
    [Abbreviation] NVARCHAR(10) NOT NULL,
    [Description] NVARCHAR(255) NULL,

    [Created] DATETIMEOFFSET NOT NULL CONSTRAINT [DF_Organization_Created] DEFAULT (SYSUTCDATETIME()),
    [CreatedBy] NVARCHAR(100) NULL,
    [Updated] DATETIMEOFFSET NOT NULL CONSTRAINT [DF_Organization_Updated] DEFAULT (SYSUTCDATETIME()),
    [UpdatedBy] NVARCHAR(100) NULL,
    [RowVersion] ROWVERSION NOT NULL,


    CONSTRAINT [PK_Organization] PRIMARY KEY CLUSTERED ([Id] ASC),
)

GO
CREATE NONCLUSTERED INDEX [IX_Organization_Name]
ON [AN].[Organization] ([Name])
