CREATE TABLE [AN].[Location]
(
    [Id] INT IDENTITY (1000, 1) NOT NULL,
    [Identifier] UNIQUEIDENTIFIER NOT NULL,

    [Name] NVARCHAR(100) NOT NULL,
    [Abbreviation] NVARCHAR(10) NOT NULL,
    [Description] NVARCHAR(255) NULL,

    [OrganizationId] INT NOT NULL,

    [Created] DATETIMEOFFSET NOT NULL CONSTRAINT [DF_Location_Created] DEFAULT (SYSUTCDATETIME()),
    [CreatedBy] NVARCHAR(100) NULL,
    [Updated] DATETIMEOFFSET NOT NULL CONSTRAINT [DF_Location_Updated] DEFAULT (SYSUTCDATETIME()),
    [UpdatedBy] NVARCHAR(100) NULL,
    [RowVersion] ROWVERSION NOT NULL,


    CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Location_Organization_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [AN].[Organization]([Id]),
);

GO
CREATE NONCLUSTERED INDEX [IX_Location_Name]
ON [AN].[Location] ([Name]);

GO
CREATE NONCLUSTERED INDEX [IX_Location_OrganizationId]
ON [AN].[Location] ([OrganizationId]);

