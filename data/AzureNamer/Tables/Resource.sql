CREATE TABLE [AN].[Resource]
(
    [Id] INT IDENTITY (1, 1) NOT NULL,
    [Identifier] UNIQUEIDENTIFIER NOT NULL,

    [Name] NVARCHAR(100) NULL,

    [Namespace] NVARCHAR(255) NOT NULL,
    [Abbreviation] NVARCHAR(10) NOT NULL,

    [ValidationDescription] NVARCHAR(4000) NULL,

    [MinimumCharacters] INT NULL,
    [MaximumCharacters] INT NULL,

    [AllowDelimter] BIT NOT NULL CONSTRAINT [DF_Resource_AllowDelimter] DEFAULT (1),

    [ValidationExpression] NVARCHAR(2000) NULL,

    [OrganizationId] INT NOT NULL,

    [Created] DATETIMEOFFSET NOT NULL CONSTRAINT [DF_Resource_Created] DEFAULT (SYSUTCDATETIME()),
    [CreatedBy] NVARCHAR(100) NULL,
    [Updated] DATETIMEOFFSET NOT NULL CONSTRAINT [DF_Resource_Updated] DEFAULT (SYSUTCDATETIME()),
    [UpdatedBy] NVARCHAR(100) NULL,
    [RowVersion] ROWVERSION NOT NULL,


    CONSTRAINT [PK_Resource] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Resource_Organization_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [AN].[Organization]([Id]),
);

GO
CREATE NONCLUSTERED INDEX [IX_Resource_Name]
ON [AN].[Resource] ([Name]);

GO
CREATE NONCLUSTERED INDEX [IX_Resource_OrganizationId]
ON [AN].[Resource] ([OrganizationId]);

