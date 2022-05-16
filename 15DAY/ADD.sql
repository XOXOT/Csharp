C WREATE DATABASE ADOTest;
GO
USE ADOTEST;
GO
CREATE TABLE tblPeople
(
Name NVARCHAR(10) PRIMARY KEY,
Age INT NOT NULL,
Male BIT NOT NULL
);
INSERT INTO tblPeople VALUES ('���켺', 36, 1);
INSERT INTO tblPeople VALUES ('��ҿ�', 32, 0);
INSERT INTO tblPeople VALUES ('�����', 37, 1);
INSERT INTO tblPeople VALUES ('������', 29, 0);GOCREATE TABLE tblSale
(
OrderNo INT IDENTITY (1,1) PRIMARY KEY,
Customer NVARCHAR(10) NOT NULL REFERENCES tblPeople(Name),
Item NVARCHAR(20) NOT NULL,
ODate DATETIME NOT NULL,
);
INSERT INTO tblSale (Customer, Item, ODate) VALUES ('���켺', '�鵵��', '2008/1/1');
INSERT INTO tblSale (Customer, Item, ODate) VALUES ('��ҿ�', 'ȭ��ǰ', '2008/1/2');
INSERT INTO tblSale (Customer, Item, ODate) VALUES ('������', '�ڵ���', '2008/1/3');
INSERT INTO tblSale (Customer, Item, ODate) VALUES ('������', '�ֹ���', '2008/1/4');
GO
SELECT *FROM tblPeople;
SELECT *FROM tblSale;
GO
UPDATE tblPeople SET Age = 36 WHERE Name = '���켺';
UPDATE tblPeople SET Age = 32 WHERE Name = '��ҿ�';
UPDATE tblPeople SET Age = 37 WHERE Name = '�����';
UPDATE tblPeople SET Age = 29 WHERE Name = '������';
GO
DELETE tblPeople WHERE Name = '����';
DELETE tblPeople WHERE Name = '����';
GO
--���ν��� ����
CREATE PROCEDURE IncAllAge
AS
UPDATE tblPeople Set Age = Age + 1; --���ǹ��� �����Ƿ� ��ü �����Ͱ� ����� ��GO--���ν��� ����CREATE PROCEDURE IncSomeAge
@Name NVARCHAR(10),
@Age INT OUTPUT
AS
UPDATE tblPeople SET Age = Age + 1 WHERE Name = @Name;
SELECT @Age = Age FROM tblPeople WHERE Name = @Name;GO