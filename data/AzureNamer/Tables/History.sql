CREATE TABLE [AN].[History]
(
    [Id] INT IDENTITY (1000, 1) NOT NULL,

    [Name] NVARCHAR(100) NOT NULL,

    [UserId] INT NOT NULL,

    [OrganizationId] INT NULL,

    [Created] DATETIMEOFFSET NOT NULL CONSTRAINT [DF_History_Created] DEFAULT (SYSUTCDATETIME()),
    [CreatedBy] NVARCHAR(100) NULL,
    [Updated] DATETIMEOFFSET NOT NULL CONSTRAINT [DF_History_Updated] DEFAULT (SYSUTCDATETIME()),
    [UpdatedBy] NVARCHAR(100) NULL,
    [RowVersion] ROWVERSION NOT NULL,


    CONSTRAINT [PK_History] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_History_User_UserId] FOREIGN KEY ([UserId]) REFERENCES [AN].[User]([Id]),
    CONSTRAINT [FK_History_Organization_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [AN].[Organization]([Id]),
);

GO
CREATE NONCLUSTERED INDEX [IX_History_Name]
ON [AN].[History] ([Name]);

GO
CREATE NONCLUSTERED INDEX [IX_History_UserId]
ON [AN].[History] ([UserId]);

GO
CREATE NONCLUSTERED INDEX [IX_History_OrganizationId]
ON [AN].[History] ([OrganizationId]);

