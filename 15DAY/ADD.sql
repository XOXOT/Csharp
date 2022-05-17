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
INSERT INTO tblPeople VALUES ('정우성', 36, 1);
INSERT INTO tblPeople VALUES ('고소영', 32, 0);
INSERT INTO tblPeople VALUES ('배용준', 37, 1);
INSERT INTO tblPeople VALUES ('김태희', 29, 0);
GO
CREATE TABLE tblSale
(
OrderNo INT IDENTITY (1,1) PRIMARY KEY,
Customer NVARCHAR(10) NOT NULL REFERENCES tblPeople(Name),
Item NVARCHAR(20) NOT NULL,
ODate DATETIME NOT NULL,
);
INSERT INTO tblSale (Customer, Item, ODate) VALUES ('정우성', '면도기', '2008/1/1');
INSERT INTO tblSale (Customer, Item, ODate) VALUES ('고소영', '화장품', '2008/1/2');
INSERT INTO tblSale (Customer, Item, ODate) VALUES ('김태희', '핸드폰', '2008/1/3');
INSERT INTO tblSale (Customer, Item, ODate) VALUES ('김태희', '휘발유', '2008/1/4');
GO
SELECT *FROM tblPeople;
SELECT *FROM tblSale;
GO
UPDATE tblPeople SET Age = 36 WHERE Name = '정우성';
UPDATE tblPeople SET Age = 32 WHERE Name = '고소영';
UPDATE tblPeople SET Age = 37 WHERE Name = '배용준';
UPDATE tblPeople SET Age = 29 WHERE Name = '김태희';
GO
DELETE tblPeople WHERE Name = '춘이';
DELETE tblPeople WHERE Name = '훈이';
GO
--프로시저 생성
CREATE PROCEDURE IncAllAge
AS
UPDATE tblPeople Set Age = Age + 1; --조건문이 없으므로 전체 데이터가 대상이 됨
GO
--프로시저 생성
CREATE PROCEDURE IncSomeAge
@Name NVARCHAR(10),
@Age INT OUTPUT
AS
UPDATE tblPeople SET Age = Age + 1 WHERE Name = @Name;
SELECT @Age = Age FROM tblPeople WHERE Name = @Name;
GO

-----로그인 실습 테이블
create table t_login (
  id int identity (1,1) not null,
  userid varchar(30),
  userpwd varchar(30)
)

insert into t_login values ('stu1', 'stu1');
insert into t_login values ('stu2', 'stu2');

create table t_userinfo (
  id int identity (1,1) not null,
  userid varchar(30),
  edunum int,
  name nvarchar(30),
  birth varchar(30),
  email varchar(40),
  phone varchar(30)
)

insert into t_userinfo values ('stu1', 10, '홍길동', '20210323', 'test@test.com', '111-1111-1111');
insert into t_userinfo values ('stu2', 20, '강호동', '20210512', 'kang@kang.com', '222-2222-2222');

create table t_subject (
  id int identity (1,1) not null,
  subject varchar(50)
)

insert into t_subject values ('국어');
insert into t_subject values ('영어');
insert into t_subject values ('수학');

create table t_user_subject (
  id int identity (1,1) not null,
  edunum int,
  subject varchar(50)
)


insert into t_user_subject values (10, '국어');
insert into t_user_subject values (20, '국어');
insert into t_user_subject values (20, '수학');