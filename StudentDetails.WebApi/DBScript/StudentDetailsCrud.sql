create table StudentDetails
(
ID bigint primary key identity(1,1),
Name nvarchar(100) not null,
Emailid nvarchar(40) not null,
DateofBirth Datetime2(7) not null, 
Address nvarchar(40),
MobileNumber bigint not null
)
--drop table StudentDetails

select * from StudentDetails
--insert

create procedure StudentDetailsInsert
(
@Name varchar (100),
@Emailid nvarchar(40),
@DateOfBirth datetime2(7),
@Address nvarchar(40),
@Mobilenumber bigint 
)
as
begin
insert into StudentDetails values(@Name,@Emailid,@DateOfBirth,@Address,@Mobilenumber)
end

exec StudentDetailsInsert 'xxxx',poojasusi1001@gamil,'11/03/2003','24,AnnaNagar,Covai',9876543210
exec StudentDetailsInsert 'yyyy',lekhasusi0312@gamil,'03/12/2007','27,SrinivasaStreet,Udumalpet',8973439600
exec StudentDetailsInsert 'zzzz',susisusi1234@gamail,'12/08/1988','47,AnnaMazhaiStreet,chennai',86670986567
select * from StudentDetails
delete StudentDetails
--update

create procedure StudentDetailsUpdate
(
@ID bigint,
@Name varchar (100),
@Emailid nvarchar(40),
@DateOfBirth datetime2(7),
@Address nvarchar(40),
@Mobilenumber bigint 
)

as
begin
update StudentDetails set Name=@Name,Emailid=@Emailid,DateOfBirth=@DateOfBirth,Address=@Address,@Mobilenumber=@Mobilenumber where ID = @ID
end 

exec StudentDetailsUpdate 6,'rrrr',susisusi1234@gamail,'11/08/1988','48,AnnaMazhaiStreet,chennai',86670986567

--read
--drop procedure StudentDetailsRead
create procedure StudentDetailsRead
as
begin
select * from StudentDetails
end
exec StudentDetailsRead
--delete

create procedure StudentDetailsDelete

(@ID bigint)
as
begin
delete from StudentDetails where ID=@ID
end
exec StudentDetailsDelete 6

select * from StudentDetails