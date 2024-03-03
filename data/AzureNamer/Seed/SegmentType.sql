/* Table [AN].[SegmentType] data */
SET IDENTITY_INSERT [AN].[SegmentType] ON;
GO


MERGE INTO [AN].[SegmentType] AS t
USING
(
    VALUES
    (1, N'Resource', N'An abbreviation that represents the type of Azure resource'),
    (2, N'Organization', N'Top-level name of the organization'),
    (3, N'Unit', N'Business unit, department or division that owns the resource'),
    (4, N'Project', N'Project, application, or service that the resource is a part of'),
    (5, N'Environment', N'The stage of the development lifecycle for the workload'),
    (6, N'Location', N'The region or cloud provider where the resource is deployed'),
    (7, N'Instance', N'The instance count for a specific resource'),
    (8, N'Random', N'Generate Random Value'),
    (9, N'Custom', N'Custom resource name segment')
)
AS s
([Id], [Name], [Description])
ON (t.[Id] = s.[Id])
WHEN NOT MATCHED BY TARGET THEN
    INSERT ([Id], [Name], [Description])
    VALUES (s.[Id], s.[Name], s.[Description])
WHEN MATCHED THEN
    UPDATE SET t.[Name] = s.[Name], t.[Description] = s.[Description]
OUTPUT $action as MergeAction;

SET IDENTITY_INSERT [AN].[SegmentType] OFF;
GO

