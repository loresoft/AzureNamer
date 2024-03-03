CREATE TABLE [AN].[Environment]
(
    [Id] INT IDENTITY (1000, 1) NOT NULL,
    [Identifier] UNIQUEIDENTIFIER NOT NULL,

    [Name] NVARCHAR(100) NOT NULL,
    [Abbreviation] NVARCHAR(10) NOT NULL,
    [Description] NVARCHAR(255) NULL,
    [SortOrder] INT NOT NULL CONSTRAINT [DF_Environment_SortOrder] DEFAULT (0),

    [OrganizationId] INT NOT NULL,

    [Created] DATETIMEOFFSET NOT NULL CONSTRAINT [DF_Environment_Created] DEFAULT (SYSUTCDATETIME()),
    [CreatedBy] NVARCHAR(100) NULL,
    [Updated] DATETIMEOFFSET NOT NULL CONSTRAINT [DF_Environment_Updated] DEFAULT (SYSUTCDATETIME()),
    [UpdatedBy] NVARCHAR(100) NULL,
    [RowVersion] ROWVERSION NOT NULL,


    CONSTRAINT [PK_Environment] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Environment_Organization_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [AN].[Organization]([Id]),
);

GO
CREATE NONCLUSTERED INDEX [IX_Environment_Name]
ON [AN].[Environment] ([Name]);

GO
CREATE NONCLUSTERED INDEX [IX_Environment_OrganizationId]
ON [AN].[Environment] ([OrganizationId]);

