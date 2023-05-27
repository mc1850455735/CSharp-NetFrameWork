create database testdb;

use testdb;

create table [User](
	UserId int primary key identity(1, 1),
	UserName nchar(20) not null,
	Password nvarchar(20) not null
);

create table Category(
	CategoryID int not null identity(1,1),
	CategoryName nchar(20) not null,
	IsPayout bit not null default(1),
	Remark varchar(50),
	primary key (CategoryID)
);

create table Item(
	ItemID int not null identity(1,1),
	ItemName nchar(20) not null,
	CategoryID int not null,
	Remark varchar(50),
	primary key (ItemID),
	foreign key (CategoryID) references Category(CategoryID)
);

create table List(
	ListID int not null identity(1,1),
	ItemID int not null,
	TradeDate datetime not null default(getdate()),
	Explain nchar(20),
	Remark varchar(100),
	primary key (ListID),
	foreign key (ItemID) references Item(ItemID)
);

alter table List add Amount real not null;

insert into [User](UserName, Password) 
values ('admin', '123');

select * from [User];
select * from [Category];
select * from [Item];
select * from [List];

select 
a.ListID as ID, c.ItemName as 收支项, b.CategoryName as 类别, 
b.IsPayout as 是否支出, a.TradeDate as 收支日期, a.Amount as 金额, 
a.Explain as 说明 
from List as a, Category as b, Item as c 
where a.ItemID = c.ItemID and c.CategoryID = b.CategoryID
and b.CategoryName like '%餐%';




