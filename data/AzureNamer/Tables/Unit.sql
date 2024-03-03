CREATE TABLE [AN].[Unit]
(
    [Id] INT IDENTITY (1000, 1) NOT NULL,

    [Name] NVARCHAR(100) NOT NULL,
    [Abbreviation] NVARCHAR(10) NOT NULL,
    [Description] NVARCHAR(255) NULL,
    [SortOrder] INT NOT NULL CONSTRAINT [DF_Unit_SortOrder] DEFAULT (0),

    [OrganizationId] INT NOT NULL,

    [Created] DATETIMEOFFSET NOT NULL CONSTRAINT [DF_Unit_Created] DEFAULT (SYSUTCDATETIME()),
    [CreatedBy] NVARCHAR(100) NULL,
    [Updated] DATETIMEOFFSET NOT NULL CONSTRAINT [DF_Unit_Updated] DEFAULT (SYSUTCDATETIME()),
    [UpdatedBy] NVARCHAR(100) NULL,
    [RowVersion] ROWVERSION NOT NULL,


    CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Unit_Organization_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [AN].[Organization]([Id]),
);

GO
CREATE NONCLUSTERED INDEX [IX_Unit_Name]
ON [AN].[Unit] ([Name]);

GO
CREATE NONCLUSTERED INDEX [IX_Unit_OrganizationId]
ON [AN].[Unit] ([OrganizationId]);

