ALTER DATABASE [$(DatabaseName)]
    ADD LOG FILE (NAME = [MelodyShopDB_log.ldf], FILENAME = 'C:\Repo\New\MelodyShop\MelodyShop\App_Data\MelodyShopDB_log.ldf', SIZE = 8192 KB, MAXSIZE = 2097152 MB, FILEGROWTH = 65536 KB);

