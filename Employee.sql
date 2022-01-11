CREATE DATABASE HR
CREATE TABLE Department_2119110224
(
id nvarchar(10),
name nvarchar(255)
)
CREATE TABLE Employee_2119110224
(
idemploy nvarchar(255),
name nvarchar(255),
datebirth nvarchar(255),
gender bit,
placebirth nvarchar(255),
iddepart nvarchar(10))

INSERT INTO Department_2119110224 VALUES ('IT', N'Cong nghe thong tin')
INSERT INTO Department_2119110224 VALUES ('KT', N'Ke toan')
INSERT INTO Department_2119110224 VALUES ('KSNB', N'Kiem soat noi bo')

INSERT INTO Employee_2119110224 VALUES (N'C53418', 'Tran Tien','11/10/2000', 1, 'Ha Noi','IT')
INSERT INTO Employee_2119110224 VALUES (N'X53416', 'Nguyen Cuong', '21/07/1999',	0,	'Dak Lak','KT')
INSERT INTO Employee_2119110224 VALUES (N'M53417', 'Nguyen Hao ', '25/12/2001',	1,	'TP Ho Chi Minh','KSNB')
delete from Employee_2119110224
drop table Department_2119110224
drop table Employee_2119110224




/*Department*/
Create Proc GetDepartment
as
begin
     select * from Department_2119110224
end
go

EXEC GetDepartment



/*Employee*/
Create Proc GetEmployee
as
begin
     select * from Employee_2119110224
end
go

EXEC GetEmployee

create proc InsertEmployee
@idemploy nvarchar(255),
@name nvarchar(255),
@datebirth datetime,
@gender int,
@playbirth nvarchar(255),
@iddepart nvarchar(255)
as
begin
    insert Employee(idemploy,name,datebirth,gender,playbirth,iddepart) values(@idemploy,@name,@datebirth,@gender,@playbirth,@iddepart)
end
go


create proc UpdateEmployee
@idemploy nvarchar(255),
@name nvarchar(255),
@datebirth datetime,
@gender int,
@playbirth nvarchar(255),
@iddepart nvarchar(255)
as
begin
    update Employee
    set
       name= @name,
	   datebirth=@datebirth,
	   gender = @gender,
	   playbirth=@playbirth,
	   iddepart = @iddepart
    where idemploy = @idemploy
end
go



create proc DeleteEmployee
@idemploy nvarchar(255)
as
begin
    delete Employee where idemploy = @idemploy
end
go

drop proc InsertEmployee
drop proc UpdateEmployee
drop proc DeleteEmployee


drop database HR