CREATE TABLE [AN].[Invite]
(
    [Id] INT IDENTITY (1000, 1) NOT NULL,

    [Name] NVARCHAR(100) NOT NULL,
    [Email] NVARCHAR(255) NOT NULL,

    [SecurityKey] NVARCHAR(255) NOT NULL,

    [OrganizationId] INT NOT NULL,

    [Created] DATETIMEOFFSET NOT NULL CONSTRAINT [DF_Invite_Created] DEFAULT (SYSUTCDATETIME()),
    [CreatedBy] NVARCHAR(100) NULL,
    [Updated] DATETIMEOFFSET NOT NULL CONSTRAINT [DF_Invite_Updated] DEFAULT (SYSUTCDATETIME()),
    [UpdatedBy] NVARCHAR(100) NULL,
    [RowVersion] ROWVERSION NOT NULL,


    CONSTRAINT [PK_Invite] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Invite_Organization_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [AN].[Organization]([Id]),
);

GO
CREATE NONCLUSTERED INDEX [IX_Invite_SecurityKey]
ON [AN].[Invite] ([SecurityKey]);

GO
CREATE NONCLUSTERED INDEX [IX_Invite_Email]
ON [AN].[Invite] ([Email]);

GO
CREATE NONCLUSTERED INDEX [IX_Invite_OrganizationId]
ON [AN].[Invite] ([OrganizationId]);

