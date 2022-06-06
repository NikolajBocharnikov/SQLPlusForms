# SQLPlusForms

Для проверки работоспособности проекта нужно:
 * После открытия создать виртуальную базу данных
 * В App.Config изменить ConnectionStrings на свой
 * Создать две таблицы Clients и Table
 * Clients создать так :
    CREATE TABLE [dbo].[Clients] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Login]       NVARCHAR (50) NOT NULL,
    [Password]    NVARCHAR (50) NOT NULL,
    [Name]        NVARCHAR (50) NOT NULL,
    [Surname]     NVARCHAR (50) NOT NULL,
    [PhoneNumber] INT           NOT NULL,
    [ANumber]     NCHAR (10)    NULL,
    [Available]   NCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
    );
    
  * Table создать так :
    CREATE TABLE [dbo].[Table] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50) NULL,
    [PhoneNumber] INT           NULL,
    [AMark]       NVARCHAR (50) NULL,
    [Photo]       IMAGE         NULL,
    [ANumber]     NVARCHAR (50) NULL,
    [Price]       NCHAR (10)    NULL,
    [Taken]       NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
    );
    
  * После компиляции создать аккаунт и войти в него 
  * После входа вы сможите писать запросы к БазеДанных 
