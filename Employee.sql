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
gender nvarchar(255),
placebirth nvarchar(255),
iddepart nvarchar(10))

INSERT INTO Department_2119110224 VALUES ('IT', N'C�ng ngh? th�ng tin')
INSERT INTO Department_2119110224 VALUES ('KT', N'K? to�n')
INSERT INTO Department_2119110224 VALUES ('KSNB', N'Ki?m so�t n?i b?')

INSERT INTO Employee_2119110224 VALUES (N'XYZ0104', N'Tr??ng V?n Ti?n', '01/04/2001',	N'Gi?i t�nh Nam',N'Qu?ng B�nh','KSNB')
INSERT INTO Employee_2119110224 VALUES (N'CCQ1911G', N'L� Th? � Nhi','12/06/2001', N'Gi?i t�nh N?', N'Qu?ng B�nh','IT')
INSERT INTO Employee_2119110224 VALUES (N'CCQ1911G', N'Nguy?n Th? Linh', '12/06/2001',N'Gi?i t�nh N?',N'??ng Nai','IT')
INSERT INTO Employee_2119110224 VALUES (N'ABC1706', N'Tr??ng Quang Nam', '17/06/2001',	N'Gi?i t�nh Nam',N'Qu?ng B�nh','KT')
INSERT INTO Employee_2119110224 VALUES (N'CC1911H', N'Nguy?n H?ng Ph�c', '30/01/2001',	N'Gi?i t�nh Nam',N'??ng Nai','IT')
INSERT INTO Employee_2119110224 VALUES (N'CC1911H', N'Nguy?n Thu� Thanh', '30/09/2001',N'Gi?i t�nh N?',N'Long An','IT')


delete from Employee_2119110224
drop table Department_2119110224
drop table Employee_2119110224




/*Department*/
Create Proc GetDepartment
as
begin
�����select * from Department_2119110224
end
go

EXEC GetDepartment



/*Employee*/
Create Proc GetEmployee
as
begin
�����select * from Employee_2119110224
end
go

EXEC GetEmployee

drop proc GetEmployee

create proc InsertEmployee
@idemploy nvarchar(255),
@name nvarchar(255),
@datebirth datetime,
@gender nvarchar(255),
@playbirth nvarchar(255),
@iddepart nvarchar(255)
as
begin
����insert Employee(idemploy,name,datebirth,gender,playbirth,iddepart) values(@idemploy,@name,@datebirth,@gender,@playbirth,@iddepart)
end
go


create proc UpdateEmployee
@idemploy nvarchar(255),
@name nvarchar(255),
@datebirth datetime,
@gender nvarchar(255),
@playbirth nvarchar(255),
@iddepart nvarchar(255)
as
begin
����update Employee
����set
�������name= @name,
	   datebirth=@datebirth,
	   gender = @gender,
	   playbirth=@playbirth,
	   iddepart = @iddepart
����where idemploy = @idemploy
end
go



create proc DeleteEmployee
@idemploy nvarchar(255)
as
begin
����delete Employee where idemploy = @idemploy
end
go

drop proc InsertEmployee
drop proc UpdateEmployee
drop proc DeleteEmployee


drop database HR