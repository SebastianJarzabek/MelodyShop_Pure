ALTER DATABASE [$(DatabaseName)]
    ADD FILE (NAME = [MelodyShopDB.mdf], FILENAME = 'C:\Repo\New\MelodyShop\MelodyShop\App_Data\MelodyShopDB.mdf', SIZE = 8192 KB, FILEGROWTH = 65536 KB) TO FILEGROUP [PRIMARY];

