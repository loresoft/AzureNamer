/* Table [AN].[Segment] data */
SET IDENTITY_INSERT [AN].[Segment] ON;
GO


MERGE INTO [AN].[Segment] AS t
USING
(
    VALUES
    (1, N'Resource', 1, 1, 10, 1, 1, 0, 0, 1, 1, 1),
    (2, N'Organization', 2, 1, 5, 1, 1, 0, 0, 1, 2, 1),
    (3, N'Unit', 3, 1, 5, 1, 1, 1, 0, 1, 3, 1),
    (4, N'Project', 4, 1, 3, 1, 1, 1, 0, 1, 4, 1),
    (5, N'Environment', 5, 1, 5, 1, 1, 0, 0, 1, 5, 1),
    (6, N'Location', 6, 1, 10, 1, 1, 0, 0, 1, 6, 1),
    (7, N'Instance', 7, 1, 5, 1, 1, 1, 0, 1, 7, 1)
)
AS s
([Id], [Name], [SortOrder], [MinimumCharacters], [MaximumCharacters], [HasDelimterBefore], [HasDelimterAfter], [IsOptional], [IsLocked], [IsEnabled], [SegmentTypeId], [OrganizationId])
ON (t.[Id] = s.[Id])
WHEN NOT MATCHED BY TARGET THEN
    INSERT ([Id], [Name], [SortOrder], [MinimumCharacters], [MaximumCharacters], [HasDelimterBefore], [HasDelimterAfter], [IsOptional], [IsLocked], [IsEnabled], [SegmentTypeId], [OrganizationId])
    VALUES (s.[Id], s.[Name], s.[SortOrder], s.[MinimumCharacters], s.[MaximumCharacters], s.[HasDelimterBefore], s.[HasDelimterAfter], s.[IsOptional], s.[IsLocked], s.[IsEnabled], s.[SegmentTypeId], s.[OrganizationId])
WHEN MATCHED THEN
    UPDATE SET t.[Name] = s.[Name], t.[SortOrder] = s.[SortOrder], t.[MinimumCharacters] = s.[MinimumCharacters], t.[MaximumCharacters] = s.[MaximumCharacters], t.[HasDelimterBefore] = s.[HasDelimterBefore], t.[HasDelimterAfter] = s.[HasDelimterAfter], t.[IsOptional] = s.[IsOptional], t.[IsLocked] = s.[IsLocked], t.[IsEnabled] = s.[IsEnabled], t.[SegmentTypeId] = s.[SegmentTypeId], t.[OrganizationId] = s.[OrganizationId]
OUTPUT $action as MergeAction;

SET IDENTITY_INSERT [AN].[Segment] OFF;
GO

