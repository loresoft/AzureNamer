/* Table [AN].[Location] data */
SET IDENTITY_INSERT [AN].[Location] ON;
GO


MERGE INTO [AN].[Location] AS t
USING
(
    VALUES
    (100, 'cf83d7fc-92bb-4c0b-b89f-0327ecd6f57f', N'centralus', N'usc', N'(US) Central US', 1),
    (101, '174b2f8c-33af-4ed8-91fd-dc4be16afeef', N'eastus', N'use', N'(US) East US', 1),
    (102, '6c76ffd4-ab80-4f6e-a86e-54e04fef811f', N'eastus2', N'use2', N'(US) East US 2', 1),
    (103, 'fc157bc4-bf8f-44a6-b0a9-c882e0830e82', N'northcentralus', N'usnc', N'(US) North Central US', 1),
    (104, 'c0276dc4-6741-4ed7-b3a4-1a77515e5ce1', N'southcentralus', N'ussc', N'(US) South Central US', 1),
    (105, '3c2f86b6-6ab4-4a87-a375-f09a737eec4a', N'westcentralus', N'uswc', N'(US) West Central US', 1),
    (106, 'e370d9a4-7287-4471-818f-6ed00efeb229', N'westus', N'usw', N'(US) West US', 1),
    (107, 'aba3f2e0-d791-4a57-a8a5-bc5a2c34ea37', N'westus2', N'usw2', N'(US) West US 2', 1),
    (108, '689307a2-3971-4bc0-9bb8-3658f3158769', N'westus3', N'usw3', N'(US) West US 3', 1),
    (109, '1d8ea14f-ca74-4dc1-8c99-7ca65fad6b31', N'southafricanorth', N'zan', N'(Africa) South Africa North', 1),
    (110, '314ae6f6-953b-45cb-97b9-653291cab863', N'southafricawest', N'zaw', N'(Africa) South Africa West', 1),
    (111, '5ee77dde-db20-43ae-a95f-b5147591f162', N'australiacentral', N'auc', N'(Asia Pacific) Australia Central', 1),
    (112, 'ba76f000-d7f7-4d1c-9aad-a1240ea9a1e6', N'australiacentral2', N'auc2', N'(Asia Pacific) Australia Central 2', 1),
    (113, '0175e8a9-a538-47a3-84b1-cf5304384fef', N'australiaeast', N'aue', N'(Asia Pacific) Australia East', 1),
    (114, 'ae1ef294-1681-468d-a9a2-097f7f85447c', N'australiasoutheast', N'aus', N'(Asia Pacific) Australia Southeast', 1),
    (115, 'e699cb3a-651b-4291-b58f-a09aeaed3733', N'centralindia', N'inc', N'(Asia Pacific) Central India', 1),
    (116, '54929cbb-2781-41db-bedb-51c81a973256', N'eastasia', N'ase', N'(Asia Pacific) East Asia', 1),
    (117, 'f50321cb-0985-4671-8dea-c87925216e98', N'japaneast', N'jpe', N'(Asia Pacific) Japan East', 1),
    (118, '0eef3da7-6aca-4084-85be-7d06409b4086', N'japanwest', N'jpw', N'(Asia Pacific) Japan West', 1),
    (119, '7ffe6952-f892-439d-9797-641b5230d2d8', N'jioindiacentral', N'injc', N'(Asia Pacific) Jio India Central', 1),
    (120, '71176dd9-a430-48a7-9c5e-54fbe6f1acc1', N'jioindiawest', N'injw', N'(Asia Pacific) Jio India West', 1),
    (121, 'a1de9402-9396-46a5-b17c-91f113f1708f', N'koreacentral', N'krc', N'(Asia Pacific) Korea Central', 1),
    (122, '170831bb-1b23-471c-aba5-6387a52aae1b', N'koreasouth', N'krs', N'(Asia Pacific) Korea South', 1),
    (123, '7fb3fca1-4603-4821-a219-077cea99a51c', N'southindia', N'ins', N'(Asia Pacific) South India', 1),
    (124, '36f65e11-fd55-437a-923f-c0c6ab156bff', N'southeastasia', N'asse', N'(Asia Pacific) Southeast Asia', 1),
    (125, '353b2179-6115-4db5-b8c8-5a7cce2f3a26', N'westindia', N'inw', N'(Asia Pacific) West India', 1),
    (126, '84b80ad8-44fd-41de-a18b-c210ef257a57', N'canadacentral', N'cac', N'(Canada) Canada Central', 1),
    (127, '7c8b3bbe-c03a-4d54-8651-e27968be04e8', N'canadaeast', N'cae', N'(Canada) Canada East', 1),
    (128, '068531d1-a619-4844-94a9-b8c0b34030d3', N'chinaeast', N'cne', N'(China) China East', 1),
    (129, '371396a3-d5d7-4220-8dbd-94bb585b29d8', N'chinaeast2', N'cne2', N'(China) China East 2', 1),
    (130, '3b83d6b7-f43b-49a5-bbdc-2cf0b574945e', N'chinanorth', N'cnn', N'(China) China North', 1),
    (131, '6a3dd1fc-0788-429b-8ee8-661a0f68c7f7', N'chinanorth2', N'cnn2', N'(China) China North 2', 1),
    (132, '0addb440-9512-40f3-b6d0-cb1e4c76a87e', N'chinanorth3', N'cnn3', N'(China) China North 3', 1),
    (133, '88524dc9-536d-48fc-8a99-25cd294d5e14', N'francecentral', N'frc', N'(Europe) France Central', 1),
    (134, 'b2ebf198-6501-4030-acb7-e84a2a0b4c06', N'francesouth', N'frs', N'(Europe) France South', 1),
    (135, 'f2f044e8-8171-44ea-ad04-cc83ab35ed94', N'germanynorth', N'den', N'(Europe) Germany North', 1),
    (136, '4fe42a02-eaa2-4651-b218-b24574275fb4', N'germanywestcentral', N'dewc', N'(Europe) Germany West Central', 1),
    (137, 'fc266620-d8b0-4138-8052-74d9b37a8d31', N'italynorth', N'itn', N'(Europe) Italy North', 1),
    (138, 'f36c612f-01e3-4657-a1ec-08ab0dc1cde7', N'northeurope', N'eun', N'(Europe) North Europe', 1),
    (139, '4b664fd9-1017-4fd5-a556-103a75a2d6cf', N'norwayeast', N'noe', N'(Europe) Norway East', 1),
    (140, '337938b9-9a29-42e3-96a8-088d252890e9', N'norwaywest', N'now', N'(Europe) Norway West', 1),
    (141, '8bf64c77-977e-4b35-afc9-0a6628762ead', N'polandcentral', N'plc', N'(Europe) Poland Central', 1),
    (142, '8ac51ab2-6077-4dad-86c8-b041a4eb6ee3', N'swedencentral', N'sec', N'(Europe) Sweden Central', 1),
    (143, '298e9b27-4e4e-47e8-8978-43ef787d360a', N'switzerlandnorth', N'chn', N'(Europe) Switzerland North', 1),
    (144, 'f298a707-26cd-406e-ad52-15772dd8927d', N'switzerlandwest', N'chw', N'(Europe) Switzerland West', 1),
    (145, '360c1f06-7f97-4f8f-851b-fdb7783fe134', N'uksouth', N'uks', N'(Europe) UK South', 1),
    (146, 'ff429c37-0071-4a60-bcba-6d766349f14d', N'ukwest', N'ukw', N'(Europe) UK West', 1),
    (147, '079d51db-f214-4a8c-8c9f-6eaecdf49d57', N'westeurope', N'euw', N'(Europe) West Europe', 1),
    (148, 'a031fbd1-4dff-4c99-af6e-71b6fd5c0814', N'israelcentral', N'ilc', N'(Middle East) Israel Central', 1),
    (149, '5d244e92-d902-47bb-a2a2-c0e9ce1efe3b', N'qatarcentral', N'qac', N'(Middle East) Qatar Central', 1),
    (150, 'aa279093-e264-4ccf-b07e-3da6b90e0ca5', N'uaecentral', N'aec', N'(Middle East) UAE Central', 1),
    (151, 'b609750d-335e-4d87-9894-2de920c88fdc', N'uaenorth', N'aen', N'(Middle East) UAE North', 1),
    (152, 'c7777b18-2d99-4ed0-b1ec-a9bbb6da4c30', N'brazilsouth', N'brs', N'(South America) Brazil South', 1),
    (153, '5cbc4ee5-26c9-48b2-b485-09cb18f16ee1', N'brazilsoutheast', N'brse', N'(South America) Brazil Southeast', 1),
    (154, '67e8dbb6-7550-4dd6-8ce0-e4adfa855344', N'brazilus', N'brus', N'(South America) Brazil US', 1)
)
AS s
([Id], [Identifier], [Name], [Abbreviation], [Description], [OrganizationId])
ON (t.[Id] = s.[Id])
WHEN NOT MATCHED BY TARGET THEN
    INSERT ([Id], [Identifier], [Name], [Abbreviation], [Description], [OrganizationId])
    VALUES (s.[Id], s.[Identifier], s.[Name], s.[Abbreviation], s.[Description], s.[OrganizationId])
WHEN MATCHED THEN
    UPDATE SET t.[Name] = s.[Name], t.[Abbreviation] = s.[Abbreviation], t.[Description] = s.[Description], t.[OrganizationId] = s.[OrganizationId]
OUTPUT $action as MergeAction;

SET IDENTITY_INSERT [AN].[Location] OFF;
GO

