CREATE DATABASE [EQUIPMENT_ACCOUNTING]
CONTAINMENT = NONE
ON PRIMARY
( NAME = N'EQUIPMENT_ACCOUNTING', FILENAME = N'C:\EquipmentAccounting\BD\EQUIPMENT_ACCOUNTING.mdf' , SIZE = 2048 , MAXSIZE = 4096, FILEGROWTH = 10%)
LOG ON
( NAME = N'EQUIPMENT_ACCOUNTING_log', FILENAME = N'C:\EquipmentAccounting\BD\EQUIPMENT_ACCOUNTING.ldf' , SIZE = 1024KB , MAXSIZE = 4096KB , FILEGROWTH = 10%)
GO

USE [EQUIPMENT_ACCOUNTING]
GO

-- Таблицы 
CREATE TABLE [dbo].[Provider](
[IdProvider] [integer] IDENTITY(1,1) PRIMARY KEY NOT NULL,
[CompanyName] [nvarchar](40) COLLATE Cyrillic_General_CS_AS NOT NULL,
[CompanyPhone] [nvarchar](20) COLLATE Cyrillic_General_CI_AS NOT NULL,
[FioRepresent] [nvarchar](40) COLLATE Cyrillic_General_CS_AS NOT NULL
)
GO
CREATE TABLE [dbo].[Employee](
[IdEmployee] [integer] IDENTITY(1,1) PRIMARY KEY NOT NULL,
[FioEmployee] [nvarchar](30) COLLATE Cyrillic_General_CS_AS,
[DateBirth] [nvarchar](20) NOT NULL,
[Position] [nvarchar](25) COLLATE Cyrillic_General_CS_AS NOT NULL,
[Address] [nvarchar](50) COLLATE Cyrillic_General_CS_AS NOT NULL
)
GO
CREATE TABLE [dbo].[Department](
[IdDepartment] [integer] IDENTITY(1,1) PRIMARY KEY NOT NULL,
[DepartNumber] [nvarchar](6) NOT NULL,
[DepartmentPhone] [nvarchar](20) COLLATE Cyrillic_General_CI_AS NOT NULL
)
GO
CREATE TABLE [dbo].[EquipDirectory](
[IdNameEquip] [integer] IDENTITY(1,1) PRIMARY KEY NOT NULL,
[EquipName] [nvarchar](30) NOT NULL,
[Price] [integer] NOT NULL,
[Weight] [nvarchar](30) NOT NULL
)
GO
CREATE TABLE [dbo].[Equipment](
[IdEquipment][integer] IDENTITY(1,1) PRIMARY KEY NOT NULL,
[IdNameEquip] [integer] NOT NULL,
[Quantity] [integer] NOT NULL,
CONSTRAINT FK_Equipment_To_EquipDirectory FOREIGN KEY (IdNameEquip)  REFERENCES EquipDirectory (IdNameEquip)
)
GO
CREATE TABLE [dbo].[Order](
[IdOrder][integer] IDENTITY(1,1) PRIMARY KEY NOT NULL,
[IdProvider] [integer] NOT NULL, 
[IdEmployee] [integer] NOT NULL,
[IdEquipment] [integer] NOT NULL,
[Quantity] [integer] NOT NULL,
[Value] [integer] NOT NULL,
[OrderDate] [nvarchar](20) NOT NULL
CONSTRAINT FK_Orders_To_Provider FOREIGN KEY (IdProvider)  REFERENCES Provider (IdProvider),
CONSTRAINT FK_Orders_To_Employee FOREIGN KEY (IdEmployee)  REFERENCES Employee (IdEmployee),
CONSTRAINT FK_Orders_To_Equipment FOREIGN KEY (IdEquipment)  REFERENCES Equipment (IdEquipment)
)
GO
CREATE TABLE [dbo].[Coming](
[IdComing] [integer] IDENTITY(1,1) PRIMARY KEY NOT NULL,
[IdOrder][integer] NOT NULL,
[IdEmployee] [integer] NOT NULL,
[IdEquipment] [integer] NOT NULL,
[InvoiseNumber] [integer] NOT NULL,
[Quantity] [integer] NOT NULL,
[DeliveryDate] [nvarchar](20) NOT NULL,
CONSTRAINT FK_Coming_To_Order FOREIGN KEY (IdOrder)  REFERENCES [dbo].[Order] (IdOrder),
CONSTRAINT FK_Coming_To_Employee FOREIGN KEY (IdEmployee)  REFERENCES Employee (IdEmployee),
CONSTRAINT FK_Coming_To_Equipment FOREIGN KEY (IdEquipment)  REFERENCES Equipment (IdEquipment)
)
GO
CREATE TABLE [dbo].[Application](
[IdApplication] [integer] IDENTITY(1,1) PRIMARY KEY NOT NULL,
[IdDepartment][integer] NOT NULL,
[IdEmployee] [integer] NOT NULL,
[IdEquipment] [integer] NOT NULL,
[Quantity] [integer] NOT NULL,
[ApplicationDate] [nvarchar](20) NOT NULL,
[ExecutionStatus] [bit] DEFAULT 0 NOT NULL
CONSTRAINT FK_Application_To_Department FOREIGN KEY (IdDepartment)  REFERENCES Department (IdDepartment),
CONSTRAINT FK_Application_To_Employee FOREIGN KEY (IdEmployee)  REFERENCES Employee (IdEmployee),
CONSTRAINT FK_Application_To_Equipment FOREIGN KEY (IdEquipment)  REFERENCES Equipment (IdEquipment)
)
GO
CREATE TABLE [dbo].[Consumption](
[IdConsumption] [integer] IDENTITY(1,1) PRIMARY KEY NOT NULL,
[IdApplication][integer] NOT NULL UNIQUE,
[IdEmployee] [integer] NOT NULL,
[IdEquipment] [integer] NOT NULL,
[Quantity] [integer] NULL,
[ConsumptionDate] [nvarchar](20) NOT NULL,
CONSTRAINT FK_Consumption_To_Application FOREIGN KEY (IdApplication)  REFERENCES [dbo].[Application] (IdApplication),
CONSTRAINT FK_Consumption_To_Employee FOREIGN KEY (IdEmployee)  REFERENCES Employee (IdEmployee),
CONSTRAINT FK_Consumption_To_Equipment FOREIGN KEY (IdEquipment)  REFERENCES Equipment (IdEquipment)
)
GO
CREATE TABLE [dbo].[WriteOff](
[IdWriteOff] [integer] IDENTITY(1,1) PRIMARY KEY NOT NULL,
[IdEmployee] [integer] NOT NULL,
[IdEquipment] [integer] NOT NULL,
[Quantity] [integer] NOT NULL,
[WriteOffDate] [nvarchar](20) NOT NULL
CONSTRAINT FK_WriteOff_To_Employee FOREIGN KEY (IdEmployee)  REFERENCES Employee (IdEmployee),
CONSTRAINT FK_WriteOff_To_Equipment FOREIGN KEY (IdEquipment)  REFERENCES Equipment (IdEquipment)
)
GO
CREATE TABLE [dbo].[Balance](
[IdBalance] [integer] IDENTITY(1,1) PRIMARY KEY NOT NULL,
[IdEquipment] [integer] NOT NULL,
[Quantity] [integer] NOT NULL,
[BalanceFixationDate] [nvarchar](20) NOT NULL
CONSTRAINT FK_Balance_To_Equipment FOREIGN KEY (IdEquipment)  REFERENCES Equipment (IdEquipment)
)
GO
CREATE TABLE [dbo].[UserAccount](
[IdUser] [int] identity (1,1) NOT NULL,
[LoginUser] [nvarchar](50) NOT NULL,
[PasswordUser] [nvarchar](100) NOT NULL,
[IsAdmin] [bit] DEFAULT 0 NOT NULL
)
GO

--Добавление данных в таблицу "Поставщик"
INSERT INTO dbo.Provider(CompanyName, CompanyPhone, FioRepresent)
VALUES
('ООО "ПромСнаб"', '+7(953)353-24-24', 'Карбазов А.О.'),
('ООО "Вертекс"', '+7(953)352-34-71', 'Патрушев В.О.'),
('U-Technology Group', '+7(956)752-21-76', 'Баринов Б.А.')
GO
--Добавление данных в таблицу "Сотрудник"
INSERT INTO dbo.Employee(FioEmployee, DateBirth, Position, Address)
VALUES
('Иванов А.Г.', '04.08.1989', 'Заведующий складом', 'ул. Строителей, д.3, кв. 59'),
('Логинов Б.А.', '01.09.1996', 'Кладовщик', 'ул. Баумана, д.55, кв. 55'),
('Карлов Д.В.', '12.04.2000', 'Кладовщик', 'ул. Пролетарская, д.12, кв.12'),
('Александров Р.С.', '07.03.1996', 'Кладовщик', 'ул. Радищева, д.34, кв.34'),
('Петров А.А.', '02.05.1991', 'Кладовщик', 'ул. Ленина, д.53, кв 53')
GO

--Добавление данных в таблицу "Отдел"
INSERT INTO dbo.Department(DepartNumber, DepartmentPhone)
VALUES
('a55','43-43'),
('55','45-54'),
('b45','61-61'),
('35','62-62')
GO

--Добавление данных в таблицу "Справочник оборудования"
INSERT INTO dbo.EquipDirectory(EquipName, Price, Weight)
VALUES
('Процессор', 20000, 0.1),
('Материнская плата', 5000, 1),
('Компьютерная мышь', 500, 0.2),
('Видеокарта', 40000, 0.9),
('Монитор', 15000, 2.5)
GO

--Добавление данных в таблицу "Оборудование"
INSERT INTO dbo.Equipment(IdNameEquip, Quantity)
VALUES
(1, 5),
(2, 10),
(3, 25),
(4, 6),
(5, 12)
GO
--Добавление данных в таблицу "Заказ"
INSERT INTO dbo.[Order](IdProvider, IdEmployee, IdEquipment, Quantity, Value, OrderDate)
VALUES
(1, 2, 1, 2, 40000, '03.07.2022'),
(1, 3, 2, 5, 25000, '03.07.2022'),
(3, 3, 3, 10, 5000, '03.07.2022'),
(2, 2, 4, 5, 200000, '04.07.2022'),
(3, 4, 5, 5, 75000, '05.07.2022')
GO
--Добавление данных в таблицу "Приход"
INSERT INTO dbo.Coming(IdOrder, IdEmployee, IdEquipment, InvoiseNumber, Quantity, DeliveryDate)
VALUES
(1, 2, 1, 503, 2, '07.07.2022'),
(2, 3, 2, 504, 5, '07.07.2022'),
(3, 3, 3, 505, 10, '08.07.2022'),
(4, 2, 4, 506, 5, '10.07.2022'),
(5, 4, 5, 507, 5, '10.07.2022')
GO
--Добавление данных в таблицу "Заявка"
INSERT INTO dbo.Application(IdDepartment, IdEmployee, IdEquipment, Quantity, ApplicationDate, ExecutionStatus)
VALUES
(3, 4, 1, 1, '11.07.2022', 1),
(2, 2, 3, 5, '12.07.2022', 1),
(1, 3, 2, 1, '12.07.2022', 1),
(1, 2, 1, 2, '13.07.2022', 0)
GO
--Добавление данных в таблицу "Расход"
INSERT INTO dbo.Consumption(IdApplication, IdEmployee, IdEquipment, Quantity, ConsumptionDate)
VALUES
(1, 2, 2, 1, '11.07.2022'),
(2, 2, 3, 3, '13.07.2022'),
(3, 3, 2, 1, '13.07.2022')
GO

--Добавление данных в таблицу "Списание"
INSERT INTO dbo.WriteOff(IdEmployee, IdEquipment, Quantity, WriteOffDate)
VALUES
(1, 1, 2, '11.07.2022'),
(1, 2, 1, '12.07.2022')

GO
--Добавление данных в таблицу "Остаток"
INSERT INTO dbo.Balance(IdEquipment, Quantity, BalanceFixationDate)
VALUES
(1, 4, '31.05.2022'),
(2, 8, '31.05.2022'),
(3, 23, '31.05.2022'),
(4, 8, '31.05.2022'),
(5, 10, '31.05.2022'),
(1, 5, '30.06.2022'),
(2, 9, '30.06.2022'),
(3, 21, '30.06.2022'),
(4, 7, '30.06.2022'),
(5, 10, '30.06.2022')
GO
INSERT INTO dbo.UserAccount(LoginUser, PasswordUser, IsAdmin)
VALUES
('admin', '21232f297a57a5a743894a0e4a801fc3', 1),
('user', 'ee11cbb19052e40b07aac0ca060c23ee', 0),
('user1', '24c9e15e52afc47c225b757e7bee1f9d', 0),
('user2', '7e58d63b60197ceb55a1c487989a3720', 0)
GO

IF OBJECT_ID('dbo.u_coming') IS NOT NULL
DROP TRIGGER dbo.u_coming;
GO

CREATE TRIGGER u_coming ON Coming 
INSTEAD OF INSERT 
AS 
SET NOCOUNT ON; --Нет необходимости выводить количество обработанных строк.
BEGIN

--Объявляю временную таблицу с полями, аналогичными ComResult (кроме первичного ключа).
	DECLARE @ComResult TABLE 
	(
		[IdOrder][integer] NOT NULL,
		[IdEmployee] [integer] NOT NULL,
		[IdEquipment] [integer] NOT NULL,
		[InvoiseNumber] [integer] NOT NULL,
		[Quantity] [nvarchar](10) NULL,
		[DeliveryDate] [nvarchar](20) NULL
	)
--Переписываю в таблицу только что добавленные данные.
	INSERT INTO @ComResult (IdOrder, IdEmployee, IdEquipment, InvoiseNumber, Quantity, DeliveryDate)
	SELECT
		I.[IdOrder],
		I.[IdEmployee], 
		I.[IdEquipment], 
		I.[InvoiseNumber], 
		I.[Quantity],
		I.[DeliveryDate] 
	FROM INSERTED AS I;

	DECLARE @IdOrder INTEGER =
		(SELECT
			C.IdOrder
		 FROM @ComResult AS C);

	DECLARE @IdEmployee INTEGER =
		(SELECT
			C.IdEmployee
		 FROM @ComResult AS C);

	DECLARE @IdEquipment INTEGER =
		(SELECT
			C.IdEquipment
		 FROM @ComResult AS C);

	DECLARE @InvoiseNumber INTEGER =
		(SELECT
			C.InvoiseNumber
		 FROM @ComResult AS C);

	DECLARE @Quantity INTEGER =
		(SELECT
			C.Quantity
		 FROM @ComResult AS C);

	DECLARE @DeliveryDate NVARCHAR(20) =
		(SELECT
			C.DeliveryDate
		 FROM @ComResult AS C);
	
BEGIN
UPDATE Equipment 
SET Quantity = Quantity + @Quantity
WHERE IdEquipment = @IdEquipment
END;

INSERT INTO Coming (IdOrder, IdEmployee, IdEquipment, InvoiseNumber, Quantity, DeliveryDate) VALUES (@IdOrder, @IdEmployee, @IdEquipment, @InvoiseNumber, @Quantity, @DeliveryDate);
END
GO

IF OBJECT_ID('dbo.u_Consumption') IS NOT NULL
DROP TRIGGER dbo.u_Consumption;
GO

CREATE TRIGGER u_Consumption ON Consumption 
INSTEAD OF INSERT 
AS 
SET NOCOUNT ON; --Нет необходимости выводить количество обработанных строк.
BEGIN

--Объявляю временную таблицу с полями, аналогичными ComResult (кроме первичного ключа).
	DECLARE @ComResult TABLE 
	(
		[IdApplication][integer] NOT NULL,
		[IdEmployee] [integer] NOT NULL,
		[IdEquipment] [integer] NOT NULL,
		[Quantity] [nvarchar](10) NULL,
		[ConsumptionDate] [nvarchar](20) NULL
	);

--Переписываю в таблицу только что добавленные данные.
	INSERT INTO @ComResult (IdApplication, IdEmployee, IdEquipment, Quantity, ConsumptionDate)
	SELECT
		I.[IdApplication],
		I.[IdEmployee], 
		I.[IdEquipment], 
		I.[Quantity],
		I.[ConsumptionDate]
	FROM INSERTED AS I;
	
	DECLARE @IdApplication INTEGER =
		(SELECT
			C.IdApplication
		 FROM @ComResult AS C);

	DECLARE @IdEmployee INTEGER =
		(SELECT
			C.IdEmployee
		 FROM @ComResult AS C);

	DECLARE @IdEquipment INTEGER =
		(SELECT
			C.IdEquipment
		 FROM @ComResult AS C);

	DECLARE @Quantity INTEGER =
		(SELECT
			C.Quantity
		 FROM @ComResult AS C);

		 DECLARE @ConsumptionDate NVARCHAR(20) =
		(SELECT
			C.ConsumptionDate
		 FROM @ComResult AS C);

BEGIN
UPDATE Equipment 
SET Quantity = Quantity - @Quantity
WHERE IdEquipment = @IdEquipment
END;

INSERT INTO Consumption (IdApplication, IdEmployee, IdEquipment, Quantity, ConsumptionDate) VALUES (@IdApplication, @IdEmployee, @IdEquipment, @Quantity, @ConsumptionDate);
END
GO


IF OBJECT_ID('dbo.u_WriteOff') IS NOT NULL
DROP TRIGGER dbo.u_WriteOff;
GO

CREATE TRIGGER u_WriteOff  ON WriteOff 
INSTEAD OF INSERT 
AS 
SET NOCOUNT ON; --Нет необходимости выводить количество обработанных строк.
BEGIN

--Объявляю временную таблицу с полями, аналогичными ComResult (кроме первичного ключа).
	DECLARE @ComResult TABLE 
	(
		[IdEquipment] [integer] NOT NULL,
		[IdEmployee] [integer] NOT NULL,
		[Quantity] [nvarchar](10) NULL,
		[WriteOffDate] [nvarchar](20) NULL
	);

--Переписываю в таблицу только что добавленные данные.
	INSERT INTO @ComResult (IdEquipment, IdEmployee, Quantity, WriteOffDate)
	SELECT
		I.[IdEquipment], 
		I.[IdEmployee], 
		I.[Quantity],
		I.[WriteOffDate]
	FROM INSERTED AS I;

	DECLARE @IdEquipment INTEGER =
		(SELECT
			C.IdEquipment
		 FROM @ComResult AS C);

	DECLARE @IdEmployee INTEGER =
		(SELECT
			C.IdEmployee
		 FROM @ComResult AS C);

	DECLARE @Quantity INTEGER =
		(SELECT
			C.Quantity
		 FROM @ComResult AS C);

	DECLARE @WriteOffDate NVARCHAR(20) =
		(SELECT
			C.WriteOffDate
		 FROM @ComResult AS C);

BEGIN
UPDATE Equipment 
SET Quantity = Quantity - @Quantity
WHERE IdEquipment = @IdEquipment
END;
INSERT INTO WriteOff (IdEquipment, IdEmployee, Quantity, WriteOffDate) VALUES (@IdEquipment, @IdEmployee, @Quantity, @WriteOffDate);
END
GO

CREATE PROCEDURE PriceSortUp AS
BEGIN
	SELECT * 
	FROM EquipDirectory
	ORDER BY Price
END;
GO

CREATE PROCEDURE PriceSortDown AS
BEGIN
	SELECT * 
	FROM EquipDirectory
	ORDER BY Price DESC
END;


