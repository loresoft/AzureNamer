/* Table [AN].[Environment] data */
SET IDENTITY_INSERT [AN].[Environment] ON;
GO


MERGE INTO [AN].[Environment] AS t
USING
(
    VALUES
    (1, '8f9b1cd8-15a0-4a70-a22d-d28b809e4112', N'Development', N'dev', N'Development Environment', 1, 1),
    (2, '0b87f963-bcab-43d6-854f-969c3a7a5600', N'Production', N'prd', N'Production Environment', 2, 1),
    (3, '84c26e47-a253-491d-a9d5-47fa7f6390f5', N'Sandbox', N'sbx', N'Sandbox Environment', 3, 1),
    (4, '0480337f-55fb-4049-a578-a3fe31f6b883', N'Shared', N'shd', N'Shared Environment', 4, 1),
    (5, 'd6420ae2-302b-4f3d-bbaa-0d16076b43ea', N'Staging', N'stg', N'Staging Environment', 5, 1),
    (6, 'e0d28ab8-b795-4c9d-ba4a-425114941f76', N'Test', N'tst', N'Test Environment', 6, 1),
    (7, 'ae2cee4b-ac8f-43ab-ab81-5e340e2313c2', N'UAT', N'uat', N'User Acceptance Testing Environment', 7, 1)
)
AS s
([Id], [Identifier], [Name], [Abbreviation], [Description], [SortOrder], [OrganizationId])
ON (t.[Id] = s.[Id])
WHEN NOT MATCHED BY TARGET THEN
    INSERT ([Id], [Identifier], [Name], [Abbreviation], [Description], [SortOrder], [OrganizationId])
    VALUES (s.[Id], s.[Identifier], s.[Name], s.[Abbreviation], s.[Description], s.[SortOrder], s.[OrganizationId])
WHEN MATCHED THEN
    UPDATE SET t.[Name] = s.[Name], t.[Abbreviation] = s.[Abbreviation], t.[Description] = s.[Description], t.[SortOrder] = s.[SortOrder], t.[OrganizationId] = s.[OrganizationId]
OUTPUT $action as MergeAction;

SET IDENTITY_INSERT [AN].[Environment] OFF;
GO

