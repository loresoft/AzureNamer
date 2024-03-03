/* Table [AN].[Organization] data */
SET IDENTITY_INSERT [AN].[Organization] ON;
GO

MERGE INTO [AN].[Organization] AS t
USING
(
    VALUES
    (1, N'- default -', N'org', N'Default Organization')
)
AS s
([Id], [Name], [Abbreviation], [Description])
ON (t.[Id] = s.[Id])
WHEN NOT MATCHED BY TARGET THEN
    INSERT ([Id], [Name], [Abbreviation], [Description])
    VALUES (s.[Id], s.[Name], s.[Abbreviation], s.[Description])
WHEN MATCHED THEN
    UPDATE SET t.[Name] = s.[Name], t.[Abbreviation] = s.[Abbreviation], t.[Description] = s.[Description]
OUTPUT $action as MergeAction;

SET IDENTITY_INSERT [AN].[Organization] OFF;
GO

