CREATE TABLE [AN].[Segment]
(
    [Id] INT IDENTITY (1000, 1) NOT NULL,

    [Name] NVARCHAR(100) NOT NULL,

    [SortOrder] INT NOT NULL CONSTRAINT [DF_Segment_SortOrder] DEFAULT (0),

    [MinimumCharacters] INT NOT NULL CONSTRAINT [DF_Segment_MinimumCharacters] DEFAULT (1),
    [MaximumCharacters] INT NOT NULL CONSTRAINT [DF_Segment_MaximumCharacters] DEFAULT (5),

    [HasDelimterBefore] BIT NOT NULL CONSTRAINT [DF_Segment_HasDelimterBefore] DEFAULT (1),
    [HasDelimterAfter] BIT NOT NULL CONSTRAINT [DF_Segment_HasDelimterAfter] DEFAULT (1),

    [IsOptional] BIT NOT NULL CONSTRAINT [DF_Segment_IsOptional] DEFAULT (0),
    [IsLocked] BIT NOT NULL CONSTRAINT [DF_Segment_IsLocked] DEFAULT (0),
    [IsEnabled] BIT NOT NULL CONSTRAINT [DF_Segment_IsEnabled] DEFAULT (1),

    [SegmentTypeId] INT NOT NULL,
    [OrganizationId] INT NOT NULL,

    [Created] DATETIMEOFFSET NOT NULL CONSTRAINT [DF_Segment_Created] DEFAULT (SYSUTCDATETIME()),
    [CreatedBy] NVARCHAR(100) NULL,
    [Updated] DATETIMEOFFSET NOT NULL CONSTRAINT [DF_Segment_Updated] DEFAULT (SYSUTCDATETIME()),
    [UpdatedBy] NVARCHAR(100) NULL,
    [RowVersion] ROWVERSION NOT NULL,


    CONSTRAINT [PK_Segment] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Segment_SegmentType_SegmentTypeId] FOREIGN KEY ([SegmentTypeId]) REFERENCES [AN].[SegmentType]([Id]),
    CONSTRAINT [FK_Segment_Organization_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [AN].[Organization]([Id]),
);

GO
CREATE NONCLUSTERED INDEX [IX_Segment_Name]
ON [AN].[Segment] ([Name]);

GO
CREATE NONCLUSTERED INDEX [IX_Segment_SegmentTypeId]
ON [AN].[Segment] ([SegmentTypeId]);

GO
CREATE NONCLUSTERED INDEX [IX_Segment_OrganizationId]
ON [AN].[Segment] ([OrganizationId]);

