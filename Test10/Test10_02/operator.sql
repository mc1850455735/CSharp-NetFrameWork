create database bookshop;

use bookshop;

create table books(
	id int identity(1, 1),
	title nvarchar(200) not null, 
	author nvarchar(200),
	unitPrice money,
	primary key (id)
);

insert into books(title) 
values (N'数据结构'),
(N'数据库原理'),
(N'算法设计'),
(N'数字电路');

select * from books;
