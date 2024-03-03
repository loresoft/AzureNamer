CREATE TABLE [AN].[Project]
(
    [Id] INT IDENTITY (1000, 1) NOT NULL,

    [Name] NVARCHAR(100) NOT NULL,
    [Abbreviation] NVARCHAR(10) NOT NULL,
    [Description] NVARCHAR(255) NULL,
    [SortOrder] INT NOT NULL CONSTRAINT [DF_Project_SortOrder] DEFAULT (0),

    [OrganizationId] INT NOT NULL,

    [Created] DATETIMEOFFSET NOT NULL CONSTRAINT [DF_Project_Created] DEFAULT (SYSUTCDATETIME()),
    [CreatedBy] NVARCHAR(100) NULL,
    [Updated] DATETIMEOFFSET NOT NULL CONSTRAINT [DF_Project_Updated] DEFAULT (SYSUTCDATETIME()),
    [UpdatedBy] NVARCHAR(100) NULL,
    [RowVersion] ROWVERSION NOT NULL,


    CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Project_Organization_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [AN].[Organization]([Id]),
);

GO
CREATE NONCLUSTERED INDEX [IX_Project_Name]
ON [AN].[Project] ([Name]);

GO
CREATE NONCLUSTERED INDEX [IX_Project_OrganizationId]
ON [AN].[Project] ([OrganizationId]);

