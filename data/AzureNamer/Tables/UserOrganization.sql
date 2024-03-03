CREATE TABLE [AN].[UserOrganization]
(
    [Id] INT IDENTITY (1, 1) NOT NULL,

    [UserId] INT NOT NULL,
    [OrganizationId] INT NOT NULL,

    [IsOwner] BIT NOT NULL CONSTRAINT [DF_UserOrganization_IsOwner] DEFAULT (0),

    CONSTRAINT [PK_UserOrganization] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_UserOrganization_User_UserId] FOREIGN KEY ([UserId]) REFERENCES [AN].[User]([Id]),
    CONSTRAINT [FK_UserOrganization_Organization_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [AN].[Organization]([Id]),
)

GO
CREATE NONCLUSTERED INDEX [IX_UserOrganization_OrganizationId]
ON [AN].[UserOrganization] ([OrganizationId])

GO
CREATE NONCLUSTERED INDEX [IX_UserOrganization_UserId]
ON [AN].[UserOrganization] ([UserId])
