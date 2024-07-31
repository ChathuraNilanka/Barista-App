
CREATE TABLE `Cafes` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Description` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Logo` longtext CHARACTER SET utf8mb4 NULL,
    `Location` longtext CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_Cafes` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Images` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `FileDescription` longtext CHARACTER SET utf8mb4 NULL,
    `FileExtension` longtext CHARACTER SET utf8mb4 NOT NULL,
    `FileSizeInBytes` bigint NOT NULL,
    `FilePath` longtext CHARACTER SET utf8mb4 NOT NULL,
    `CafeId` char(36) COLLATE ascii_general_ci NOT NULL,
    CONSTRAINT `PK_Images` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Employees` (
    `Id` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
    `EmailAddress` longtext CHARACTER SET utf8mb4 NOT NULL,
    `PhoneNumber` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Gender` longtext CHARACTER SET utf8mb4 NOT NULL,
    `StartDate` datetime(6) NULL,
    `CafeId` char(36) COLLATE ascii_general_ci NULL,
    CONSTRAINT `PK_Employees` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Employees_Cafes_CafeId` FOREIGN KEY (`CafeId`) REFERENCES `Cafes` (`Id`)
) CHARACTER SET=utf8mb4;

CREATE INDEX `IX_Employees_CafeId` ON `Employees` (`CafeId`);



COMMIT;

