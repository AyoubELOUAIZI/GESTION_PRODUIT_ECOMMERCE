------------toute les procedure-------

-----login
*************************************************************************
create proc SP_LOGIN
@user varchar(20),@PASS VARCHAR(10)
AS
SELECT* FROM ECOM_USERS 
WHERE userName=@user and PassWorde=@PASS
*************************************************************************
create proc GetAllGategores as
select idCAT , NamCAT from CATEGORES
*************************************************************************
create proc AddProduct 
@pname varchar(20),@desc varchar(500),@qte int,@price float,@img1 image,@img2 image,@img3 image,@idcat INT 
as
begin

INSERT INTO [dbo].[PRODUCTS]
           ([NamProduct]
		   ,[description]
           ,[QteInStock]
           ,[Price]
           ,[img1]
           ,[img2]
           ,[img3]
           ,[IdCAT])
     VALUES
           (@pname
		   ,@desc
           ,@qte
           ,@price
           ,@img1
           ,@img2
           ,@img3
           ,@idcat)
 end
*************************************************************************
create proc GET_ALL_PRODUCTS
as
SELECT 
       IdProduct as 'ID',
      [NamProduct] as 'Product'
      ,[description] as 'Description'
      ,[QteInStock] as 'Available quantity'
      ,[Price]    
      ,[NamCAT] as 'Categorie'
  FROM [dbo].[PRODUCTS],CATEGORES
  where PRODUCTS.IdCAT=CATEGORES.IdCAT

*************************************************************************
create proc PS_Chearch @input varchar(20) as
SELECT 
	IdProduct as 'ID',
      [NamProduct] as 'Product'
      ,[description] as 'Description'
      ,[QteInStock] as 'Available quantity'
      ,[Price]    
      ,[NamCAT] as 'Categorie'
  FROM [dbo].[PRODUCTS],CATEGORES
  where PRODUCTS.IdCAT=CATEGORES.IdCAT
  and [NamProduct]+[description]+convert(varchar,[QteInStock])+convert(varchar,[Price])+[NamCAT] Like '%'+@input+'%'

*************************************************************************
create proc DeleteProduct @id int 
as 
delete from PRODUCTS Where IdProduct=@id
*************************************************************************
create proc GET_PRODUCT_IMAGE1 @PID INT AS
SELECT  img1 from PRODUCTS where IdProduct=@PID
GO
create proc GET_PRODUCT_IMAGE2 @PID INT AS
SELECT  img2 from PRODUCTS where IdProduct=@PID
go
create proc GET_PRODUCT_IMAGE3 @PID INT AS
SELECT  img3 from PRODUCTS where IdProduct=@PID
*************************************************************************
create proc UpdateProduct 
@pname varchar(20),@desc varchar(300),@qte int,@price float,@img1 image,@img2 image,@img3 image,@idcat INT ,@id int
as
begin
UPDATE [PRODUCTS]
   SET [NamProduct] = @pname
      ,[description] = @desc
      ,[QteInStock] = @qte
      ,[Price] = @price
      ,[img1] =  @img1
      ,[img2] =  @img2
      ,[img3] =  @img3 WHERE IdProduct = @id
end
*************************************************************************
CREATE PROC ADD_CUSTOMER @FirstName varchar(20),@LastName varchar(20),@phone varchar(20),
		@email varchar(20),	@city varchar(20),@img image
as 
begin
INSERT INTO [dbo].[CUSTOMERS]
           ([FirstName]
           ,[LastName]
           ,[phone]
           ,[email]
           ,[city]
           ,[img])
     VALUES
           ( @FirstName ,@LastName ,@phone ,@email ,	@city ,@img)		   
 end
*************************************************************************
create proc GetAllCustomers 
as

SELECT [IdCustomer]
      ,[FirstName]
      ,[LastName]
      ,[phone]
      ,[email]
      ,[city]
       ,[img]
  FROM [dbo].[CUSTOMERS]

*************************************************************************
CREATE PROC UPDATE_CUSTOMER @FirstName varchar(20),@LastName varchar(20),@phone varchar(20),
		@email varchar(20),	@city varchar(20),@img image,@idcus int
as 
begin

UPDATE [dbo].[CUSTOMERS]
   SET [FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[phone] = @phone
      ,[email] =@email
      ,[city] = @city
      ,[img] = @img
 WHERE IdCustomer=@idcus

 end
*************************************************************************
CREATE PROC DELETE_CUSTOMER @idcus int as
delete from [CUSTOMERS] where IdCustomer=@idcus
*************************************************************************
create proc SEARCH_CUSTOMER @text varchar(20) as
select * from CUSTOMERS 
where FirstName+LastName+phone+email+city like '%'+@text+'%'

*************************************************************************
create proc GET_LAST_ORDER_ID AS
SELECT isnull( MAX(IdOrder)+1,1) from ORDERS
*************************************************************************

*************************************************************************
create proc AddOrdere 
@IdOrder int,
@DateOrder datetime,
@IdCustomer int,
@Seller varchar(50)
as
INSERT INTO [ORDERS]
           ([IdOrder]
           ,[DateOrder]
           ,[IdCustomer]
           ,[Seller])
     VALUES
           (@IdOrder
           ,@DateOrder
           ,@IdCustomer
           ,@Seller)
*************************************************************************
create proc Add_order_details
@IdProduct int,
@IdOrder  int,
@Qte int,
@DESCOUNT FLOAT,
@AMOUNT float,
@TOTALAMOUNT FLOAT
AS
INSERT INTO [ORDERS_DETAILS]
           ([IdProduct]
           ,[IdOrder]
           ,[Qte]
           ,[DESCOUNT]
           ,[AMOUNT]
           ,[TOTALAMOUNT])
     VALUES
           (@IdProduct
           ,@IdOrder
           ,@Qte
           ,@DESCOUNT
           ,@AMOUNT
           ,@TOTALAMOUNT)
-------------------------------------------------------------------------------------------
create proc VerifyQte 
@idproduct int ,@Qteinput int
as
select * from PRODUCTS 
where IdProduct=@idproduct and QteInStock >= @Qteinput
-------------------------------------------------------------------------------------------
USE [ECOM]
GO
/****** Object:  StoredProcedure [dbo].[Add_order_details]    Script Date: 12/16/2022 2:57:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[Add_order_details]
@IdProduct int,
@IdOrder  int,
@Qte int,
@DESCOUNT FLOAT,
@AMOUNT float,
@TOTALAMOUNT FLOAT
AS
begin
INSERT INTO [ORDERS_DETAILS]
           ([IdProduct]
           ,[IdOrder]
           ,[Qte]
           ,[DESCOUNT]
           ,[AMOUNT]
           ,[TOTALAMOUNT])
     VALUES
           (@IdProduct
           ,@IdOrder
           ,@Qte
           ,@DESCOUNT
           ,@AMOUNT
           ,@TOTALAMOUNT)

update PRODUCTS set QteInStock=QteInStock-@Qte where IdProduct=@IdProduct
end
-------------------------------------------------------------------------------------------
create proc ADD_USER
@username varchar(50),
@password varchar(20),
@typeuser varchar(20),
@image image,
@SellerName varchar(25)
as
INSERT INTO [dbo].[ECOM_USERS]
           (
            [userName]
           ,[PassWorde]
           ,[TypeUser]
           ,[img]
           ,[SellerName])
     VALUES
           (@username
           ,@password
           ,@typeuser
           ,@image 
           ,@SellerName)
GO
-------------------------------------------------------------------------------------------
CREATE PROC GET_ALL_USERS AS
select * from ECOM_USERS
-------------------------------------------------------------------------------------------
create proc SearchUser
@input varchar(20)
as
select * from ECOM_USERS
where userName+PassWorde+TypeUser+SellerName like '%'+@input+'%'
-------------------------------------------------------------------------------------------
create proc DeleteUser 
@idUser int 
as
delete from ECOM_USERS where iduser=@idUser
-------------------------------------------------------------------------------------------
create proc UPDATE_USER
@username varchar(20),
@password varchar(10),
@typeuser varchar(20),
@image image,
@SellerName varchar(25),
@iduser int
as
UPDATE [dbo].[ECOM_USERS]
   SET [userName] =@username
      ,[PassWorde] =@password
      ,[TypeUser] = @typeuser
      ,[img] =@image
      ,[SellerName] = @SellerName
 WHERE iduser=@iduser
-------------------------------------------------------------------------------------------
CREATE PROC GET_ALL_ORDERS 
AS 
select IdOrder as 'Order',DateOrder as 'Date of Order',FirstName+' '+LastName as 'Customer',Seller
from ORDERS,CUSTOMERS
WHERE ORDERS.IdCustomer=CUSTOMERS.IdCustomer
-------------------------------------------------------------------------------------------
CREATE PROC SearchOrder 
@text varchar(20)
AS 
select IdOrder as 'Order',DateOrder as 'Date of Order',FirstName+' '+LastName as 'Customer',Seller
from ORDERS,CUSTOMERS
WHERE ORDERS.IdCustomer=CUSTOMERS.IdCustomer and 'Order'+'Date of Order'+'Customer'+Seller like '%'+@text+'%'


-------------------------------------------------------------------------------------------
CREATE PROC GET_ORDER_DITAILLS
@IdOrder int
as
select ORDERS.IdOrder,DateOrder,Seller,FirstName+' '+LastName as 'Customer',city,phone,email,
NamProduct,description,Price,Qte,DESCOUNT,AMOUNT,NamCAT,img1,img2,img3,
ORDERS.IdOrder,ORDERS_DETAILS.IdOrder , ORDERS.IdCustomer,CUSTOMERS.IdCustomer
  , CATEGORES.IdCAT,PRODUCTS.IdCAT , PRODUCTS.IdProduct,ORDERS_DETAILS.IdProduct
from  ORDERS,ORDERS_DETAILS,PRODUCTS,CUSTOMERS,CATEGORES
WHERE ORDERS.IdOrder=ORDERS_DETAILS.IdOrder AND ORDERS.IdCustomer=CUSTOMERS.IdCustomer
  and CATEGORES.IdCAT=PRODUCTS.IdCAT and PRODUCTS.IdProduct=ORDERS_DETAILS.IdProduct and ORDERS.IdOrder=1


-------------------------------------------------------------------------------------------
CREATE PROC GET_ORDER_DITAILLS
@IdOrder int
as
select ORDERS.IdOrder,DateOrder,Seller,FirstName+' '+LastName as 'Customer',city,phone,email,
NamProduct,description,Price,Qte,DESCOUNT,AMOUNT,NamCAT,img1,img2,img3
from  ORDERS,ORDERS_DETAILS,PRODUCTS,CUSTOMERS,CATEGORES
WHERE ORDERS.IdOrder=ORDERS_DETAILS.IdOrder AND ORDERS.IdCustomer=CUSTOMERS.IdCustomer
  and CATEGORES.IdCAT=PRODUCTS.IdCAT and PRODUCTS.IdProduct=ORDERS_DETAILS.IdProduct and ORDERS.IdOrder=11

-------------------------------------------------------------------------------------------
USE [ECOM]
GO
/****** Object:  StoredProcedure [dbo].[AddOrdere]    Script Date: 12/18/2022 11:06:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[AddOrdere] 
@IdOrder int,
@DateOrder datetime,
@IdCustomer int,
@Seller varchar(50)
,@somme float
as
INSERT INTO [ORDERS]
           ([IdOrder]
           ,[DateOrder]
           ,[IdCustomer]
           ,[Seller]
		   ,OrderSomme)
     VALUES
           (@IdOrder
           ,@DateOrder
           ,@IdCustomer
           ,@Seller
		   ,@somme)

-------------------------------------------------------------------------------------------
alter PROC GET_ORDER_DITAILLS
@IdOrder int
as
select ORDERS.IdOrder,DateOrder,Seller,FirstName+' '+LastName as 'Customer',city,phone,email,
NamProduct,description,Price,Qte,DESCOUNT,AMOUNT,NamCAT,img1,img2,img3,TOTALAMOUNT,OrderSomme
from  ORDERS,ORDERS_DETAILS,PRODUCTS,CUSTOMERS,CATEGORES
WHERE ORDERS.IdOrder=ORDERS_DETAILS.IdOrder AND ORDERS.IdCustomer=CUSTOMERS.IdCustomer
  and CATEGORES.IdCAT=PRODUCTS.IdCAT and PRODUCTS.IdProduct=ORDERS_DETAILS.IdProduct and ORDERS.IdOrder=11


-------------------------------------------------------------------------------------------
CREATE PROC GET_ALL_PRODUCTS_AMAGES AS
SELECT  img1,img2,img3 from PRODUCTS 
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------

