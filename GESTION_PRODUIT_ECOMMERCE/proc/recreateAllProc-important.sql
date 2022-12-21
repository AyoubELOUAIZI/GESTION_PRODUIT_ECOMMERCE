USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[ADD_CUSTOMER]    Script Date: 12/21/2022 2:39:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[ADD_CUSTOMER] @FirstName varchar(20),@LastName varchar(20),@phone varchar(20),
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
GO

----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[Add_order_details]    Script Date: 12/21/2022 2:41:30 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Add_order_details]
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
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[ADD_USER]    Script Date: 12/21/2022 2:41:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[ADD_USER]
@username varchar(20),
@password varchar(10),
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


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[AddOrdere]    Script Date: 12/21/2022 2:42:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[AddOrdere] 
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
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[AddProduct]    Script Date: 12/21/2022 2:42:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[AddProduct] 
@pname varchar(20),@desc varchar(300),@qte int,@price float,@img1 image,@img2 image,@img3 image,@idcat INT 
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
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[DELETE_CUSTOMER]    Script Date: 12/21/2022 2:43:01 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[DELETE_CUSTOMER] @idcus int as
delete from [CUSTOMERS] where IdCustomer=@idcus
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[DeleteProduct]    Script Date: 12/21/2022 2:43:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[DeleteProduct] @id int 
as 
delete from PRODUCTS Where IdProduct=@id

GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 12/21/2022 2:43:37 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[DeleteUser] 
@idUser int 
as
delete from ECOM_USERS where iduser=@idUser
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[GET_ALL_ORDERS]    Script Date: 12/21/2022 2:43:55 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GET_ALL_ORDERS] 
AS 
select IdOrder as 'Order',DateOrder as 'Date of Order',FirstName+' '+LastName as 'Customer',Seller
from ORDERS,CUSTOMERS
WHERE ORDERS.IdCustomer=CUSTOMERS.IdCustomer
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[GET_ALL_PRODUCTS]    Script Date: 12/21/2022 2:44:15 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[GET_ALL_PRODUCTS]
as
SELECT IdProduct as 'ID',
      [NamProduct] as 'Product'
      ,[description] as 'Description'
      ,[QteInStock] as 'Available quantity'
      ,[Price]    
      ,[NamCAT] as 'Categorie'
  FROM [dbo].[PRODUCTS],CATEGORES
  where PRODUCTS.IdCAT=CATEGORES.IdCAT
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[GET_ALL_PRODUCTS_AMAGES]    Script Date: 12/21/2022 2:44:38 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GET_ALL_PRODUCTS_AMAGES] AS
SELECT  img1,img2,img3 from PRODUCTS 
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[GET_ALL_USERS]    Script Date: 12/21/2022 2:44:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GET_ALL_USERS] AS
select * from ECOM_USERS
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[GET_LAST_ORDER_ID]    Script Date: 12/21/2022 2:45:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GET_LAST_ORDER_ID] AS
SELECT isnull( MAX(IdOrder)+1,1) from ORDERS
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[GET_ORDER_DITAILLS]    Script Date: 12/21/2022 2:45:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GET_ORDER_DITAILLS]
@IdOrder int
as
select ORDERS.IdOrder,DateOrder,Seller,FirstName+' '+LastName as 'Customer',city,phone,email,
NamProduct,description,Price,Qte,DESCOUNT,AMOUNT,NamCAT,img1,img2,img3,ROUND(TOTALAMOUNT, 2),ROUND(OrderSomme, 2)
from  ORDERS,ORDERS_DETAILS,PRODUCTS,CUSTOMERS,CATEGORES
WHERE ORDERS.IdOrder=ORDERS_DETAILS.IdOrder AND ORDERS.IdCustomer=CUSTOMERS.IdCustomer
  and CATEGORES.IdCAT=PRODUCTS.IdCAT and PRODUCTS.IdProduct=ORDERS_DETAILS.IdProduct and ORDERS.IdOrder=@IdOrder
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[GET_PRODUCT_IMAGE1]    Script Date: 12/21/2022 2:46:00 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GET_PRODUCT_IMAGE1] @PID INT AS
SELECT  img1 from PRODUCTS where IdProduct=@PID
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[GET_PRODUCT_IMAGE2]    Script Date: 12/21/2022 2:46:17 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GET_PRODUCT_IMAGE2] @PID INT AS
SELECT  img2 from PRODUCTS where IdProduct=@PID
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[GET_PRODUCT_IMAGE3]    Script Date: 12/21/2022 2:46:33 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GET_PRODUCT_IMAGE3] @PID INT AS
SELECT  img3 from PRODUCTS where IdProduct=@PID
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[GET_PRODUCT_IMAGES]    Script Date: 12/21/2022 2:46:50 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[GET_PRODUCT_IMAGES] @PID INT AS
SELECT  img1,img2,img3 from PRODUCTS where IdProduct=@PID
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[GetAllCustomers]    Script Date: 12/21/2022 2:47:06 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[GetAllCustomers] 
as

SELECT [IdCustomer]
      ,[FirstName]
      ,[LastName]
      ,[phone]
      ,[email]
      ,[city]
      ,[img]
  FROM [dbo].[CUSTOMERS]
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[GetAllGategores]    Script Date: 12/21/2022 2:47:24 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetAllGategores] as
select idCAT , NamCAT from CATEGORES
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[PS_Chearch]    Script Date: 12/21/2022 2:47:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[PS_Chearch] @input varchar(20) as
SELECT 
	IdProduct as 'ID',
      [NamProduct] as 'Product'
      ,[description] as 'Description'
      ,[QteInStock] as 'Available quantity'
      ,[Price]    
      ,[NamCAT] as 'Categorie'
  FROM [dbo].[PRODUCTS],CATEGORES
  where PRODUCTS.IdCAT=CATEGORES.IdCAT
  and convert(varchar,IdProduct)+[NamProduct]+[description]+convert(varchar,[QteInStock])+convert(varchar,[Price])+[NamCAT] Like '%'+@input+'%'
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[SEARCH_CUSTOMER]    Script Date: 12/21/2022 2:48:04 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SEARCH_CUSTOMER] @text varchar(20) as
select * from CUSTOMERS 
where FirstName+LastName+phone+email+city like '%'+@text+'%'
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[SearchOrder]    Script Date: 12/21/2022 2:48:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SearchOrder] 
@text varchar(20)
AS 
select IdOrder as 'Order',DateOrder as 'Date of Order',FirstName+' '+LastName as 'Customer',Seller
from ORDERS,CUSTOMERS
WHERE ORDERS.IdCustomer=CUSTOMERS.IdCustomer and convert(varchar, IdOrder)+convert(varchar, DateOrder)+FirstName+LastName+Seller like '%'+@text+'%'

GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[SearchUser]    Script Date: 12/21/2022 2:48:35 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SearchUser]
@input varchar(20)
as
select * from ECOM_USERS
where userName+PassWorde+TypeUser+SellerName like '%'+@input+'%'
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[SP_LOGIN]    Script Date: 12/21/2022 2:48:56 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_LOGIN]
@user varchar(20),@PASS VARCHAR(10)
AS
SELECT* FROM ECOM_USERS 
WHERE userName=@user and PassWorde=@PASS
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[UPDATE_CUSTOMER]    Script Date: 12/21/2022 2:49:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[UPDATE_CUSTOMER] @FirstName varchar(20),@LastName varchar(20),@phone varchar(20),
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
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[UPDATE_USER]    Script Date: 12/21/2022 2:49:31 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[UPDATE_USER]
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
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[UpdateProduct]    Script Date: 12/21/2022 2:49:49 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

 CREATE proc [dbo].[UpdateProduct] 
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
      ,[img3] =  @img3
	  ,IdCAT=@idcat
	  WHERE IdProduct = @id
end
GO


----------------------------------------------------------------------------------------------------
USE [ECOM]
GO

/****** Object:  StoredProcedure [dbo].[VerifyQte]    Script Date: 12/21/2022 2:50:08 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[VerifyQte] 
@idproduct int ,@Qteinput int
as
select * from PRODUCTS 
where IdProduct=@idproduct and QteInStock >= @Qteinput
GO


----------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------
