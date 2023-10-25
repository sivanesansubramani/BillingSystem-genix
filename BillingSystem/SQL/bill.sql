create table AddProduct
(
No int primary key identity(1,1),
Code nvarchar(100) not null,
ProductName nvarchar(200) not null,
Quantity int not null,
Unitprice int not null,
Subtotal int not null
)
select*from AddProduct

create or alter procedure Selectproduct(@Code nvarchar(100),@ProductName nvarchar(200),@Quantity int,@Unitprice int,@Subtotal int)
as
begin
insert into AddProduct(Code,ProductName,Quantity,Unitprice,Subtotal)values(@Code,@ProductName,@Quantity,@Unitprice,@Subtotal)
end
exec Selectproduct 'DELL5000','Logitec mouse',2,100,200

create or alter procedure GetproductNo
as
begin
select*from AddProduct 
end 
exec GetproductNo

create or alter procedure GetproductbyNo (@No int)
as
begin
select*from AddProduct where (No=@No)
end 
exec GetproductbyNo 1 

create or alter procedure Deleteproduct(@No int)
as
begin 
delete AddProduct where (No=@No)
end
exec Deleteproduct 1

create or alter procedure Total
as
begin
select SUM (Subtotal) as TOTAL from AddProduct
end
exec Total

create table Product
(
id int primary key identity(1,1),
ProductName nvarchar(200) not null
)
drop table Product
select*from Product
select*from AddProduct

create or alter procedure insertproductname (@Product nvarchar(200))
as
begin
insert into Product(ProductName)values(@Product)
end
exec insertproductname 'DELL Laptop'

create or alter procedure dropNo
as
begin
select*from Product 
end 
exec dropNo

create or alter procedure Getpro(@id int)
as
begin
select*from Product where (id=@id)
end 
exec Getpro 1

create table Joinproduct
(
Productid int primary key identity(1,1),
Code nvarchar(100) not null,
ProductName nvarchar(200) not null,
Unitprice int not null,
No int  null
)
select * from Joinproduct

create or alter procedure Selectproduct(@Code nvarchar(100),@ProductName nvarchar(200),@Unitprice int)
as
begin
insert into Joinproduct(Code,ProductName,Unitprice)values(@Code,@ProductName,@Unitprice)
end
exec Selectproduct 'LOGI5002','Logitec Keyboard',1000

Create or alter procedure List
as
begin
 select 

 a.No,j.Code,a.ProductName,a.Quantity,j.Unitprice , a.Quantity*j.Unitprice as Subtotal from  AddProduct a inner join Joinproduct j on
  a.ProductName = j.ProductName   
  

  end 

  exec List

  create or alter procedure ListNo (@No int)
as
begin
select
 a.No,j.Code,a.ProductName,a.Quantity,j.Unitprice , a.Quantity*j.Unitprice as Subtotal from  AddProduct a inner join Joinproduct j on
  a.ProductName = j.ProductName where a.No=@No 
end 
exec ListNo 4003 

  create or alter procedure DeleteRecord
as
begin
Delete
 a.No,j.Code,a.ProductName,a.Quantity,j.Unitprice , a.Quantity*j.Unitprice as Subtotal from  AddProduct a inner join Joinproduct j on
  a.ProductName = j.ProductName 
end 
exec DeleteRecord  
