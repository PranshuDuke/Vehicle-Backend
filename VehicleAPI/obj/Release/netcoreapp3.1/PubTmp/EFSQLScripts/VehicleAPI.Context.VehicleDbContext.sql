IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220711043234_FirstMigrationToDb')
BEGIN
    CREATE TABLE [Vehicles] (
        [RegistrationNo] nvarchar(450) NOT NULL,
        [ModelName] nvarchar(max) NULL,
        [VehicleType] nvarchar(max) NULL,
        [NumberOfSeat] int NOT NULL,
        [AcAvailable] nvarchar(max) NULL,
        CONSTRAINT [PK_Vehicles] PRIMARY KEY ([RegistrationNo])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220711043234_FirstMigrationToDb')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RegistrationNo', N'AcAvailable', N'ModelName', N'NumberOfSeat', N'VehicleType') AND [object_id] = OBJECT_ID(N'[Vehicles]'))
        SET IDENTITY_INSERT [Vehicles] ON;
    INSERT INTO [Vehicles] ([RegistrationNo], [AcAvailable], [ModelName], [NumberOfSeat], [VehicleType])
    VALUES (N'AP02CD0202', N'No', N'Chevrolet Tavera', 9, N'SUV'),
    (N'KL03EF0303', N'Yes', N'Chevrolet Enjoy', 7, N'SUV'),
    (N'KA04GH0404', N'Yes', N'Mahindra Tourister', 15, N'Van'),
    (N'TN01AB0202', N'Yes', N'Chevrolet Tavera', 9, N'SUV');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RegistrationNo', N'AcAvailable', N'ModelName', N'NumberOfSeat', N'VehicleType') AND [object_id] = OBJECT_ID(N'[Vehicles]'))
        SET IDENTITY_INSERT [Vehicles] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220711043234_FirstMigrationToDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220711043234_FirstMigrationToDb', N'3.1.26');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220714125706_MigrationToAzure')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220714125706_MigrationToAzure', N'3.1.26');
END;

GO

