USE [master]
GO
/****** Object:  Database [ECOM]    Script Date: 12/21/2022 2:03:15 AM ******/
CREATE DATABASE [ECOM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ECOM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ECOM.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ECOM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ECOM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ECOM] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ECOM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ECOM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ECOM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ECOM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ECOM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ECOM] SET ARITHABORT OFF 
GO
ALTER DATABASE [ECOM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ECOM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ECOM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ECOM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ECOM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ECOM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ECOM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ECOM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ECOM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ECOM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ECOM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ECOM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ECOM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ECOM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ECOM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ECOM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ECOM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ECOM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ECOM] SET  MULTI_USER 
GO
ALTER DATABASE [ECOM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ECOM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ECOM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ECOM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ECOM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ECOM] SET QUERY_STORE = OFF
GO
USE [ECOM]
GO
/****** Object:  Table [dbo].[CATEGORES]    Script Date: 12/21/2022 2:03:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORES](
	[IdCAT] [int] NOT NULL,
	[NamCAT] [varchar](200) NULL,
	[DescriptionCAT] [varchar](200) NULL,
 CONSTRAINT [PK_CATEGORES] PRIMARY KEY CLUSTERED 
(
	[IdCAT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CUSTOMERS]    Script Date: 12/21/2022 2:03:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUSTOMERS](
	[IdCustomer] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](20) NULL,
	[LastName] [varchar](20) NULL,
	[phone] [varchar](20) NULL,
	[email] [varchar](20) NULL,
	[city] [varchar](20) NULL,
	[img] [image] NULL,
 CONSTRAINT [PK_CUSTOMERS] PRIMARY KEY CLUSTERED 
(
	[IdCustomer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ECOM_USERS]    Script Date: 12/21/2022 2:03:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ECOM_USERS](
	[iduser] [int] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](20) NOT NULL,
	[PassWorde] [varchar](10) NOT NULL,
	[TypeUser] [varchar](20) NOT NULL,
	[img] [image] NULL,
	[SellerName] [varchar](25) NOT NULL,
 CONSTRAINT [PK_ECOM_USERS] PRIMARY KEY CLUSTERED 
(
	[iduser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDERS]    Script Date: 12/21/2022 2:03:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDERS](
	[IdOrder] [int] NOT NULL,
	[DateOrder] [datetime] NULL,
	[IdCustomer] [int] NULL,
	[Seller] [varchar](50) NULL,
	[OrderSomme] [float] NULL,
 CONSTRAINT [PK_ORDERS] PRIMARY KEY CLUSTERED 
(
	[IdOrder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDERS_DETAILS]    Script Date: 12/21/2022 2:03:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDERS_DETAILS](
	[IdProduct] [int] NOT NULL,
	[IdOrder] [int] NOT NULL,
	[Qte] [int] NOT NULL,
	[DESCOUNT] [float] NULL,
	[AMOUNT] [float] NOT NULL,
	[TOTALAMOUNT] [float] NOT NULL,
 CONSTRAINT [PK_ORDERS_DETAILS] PRIMARY KEY CLUSTERED 
(
	[IdProduct] ASC,
	[IdOrder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTS]    Script Date: 12/21/2022 2:03:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTS](
	[IdProduct] [int] IDENTITY(1,1) NOT NULL,
	[NamProduct] [varchar](20) NULL,
	[description] [varchar](300) NULL,
	[QteInStock] [int] NULL,
	[Price] [float] NULL,
	[img1] [image] NULL,
	[img2] [image] NULL,
	[img3] [image] NULL,
	[IdCAT] [int] NULL,
 CONSTRAINT [PK_PRODUCTS] PRIMARY KEY CLUSTERED 
(
	[IdProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ORDERS]  WITH CHECK ADD  CONSTRAINT [FK_ORDERS_CUSTOMERS] FOREIGN KEY([IdCustomer])
REFERENCES [dbo].[CUSTOMERS] ([IdCustomer])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ORDERS] CHECK CONSTRAINT [FK_ORDERS_CUSTOMERS]
GO
ALTER TABLE [dbo].[ORDERS_DETAILS]  WITH CHECK ADD  CONSTRAINT [FK_ORDERS_DETAILS_ORDERS] FOREIGN KEY([IdOrder])
REFERENCES [dbo].[ORDERS] ([IdOrder])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ORDERS_DETAILS] CHECK CONSTRAINT [FK_ORDERS_DETAILS_ORDERS]
GO
ALTER TABLE [dbo].[ORDERS_DETAILS]  WITH CHECK ADD  CONSTRAINT [FK_ORDERS_DETAILS_PRODUCTS] FOREIGN KEY([IdProduct])
REFERENCES [dbo].[PRODUCTS] ([IdProduct])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ORDERS_DETAILS] CHECK CONSTRAINT [FK_ORDERS_DETAILS_PRODUCTS]
GO
ALTER TABLE [dbo].[PRODUCTS]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTS_CATEGORES] FOREIGN KEY([IdCAT])
REFERENCES [dbo].[CATEGORES] ([IdCAT])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PRODUCTS] CHECK CONSTRAINT [FK_PRODUCTS_CATEGORES]
GO
/****** Object:  StoredProcedure [dbo].[ADD_CUSTOMER]    Script Date: 12/21/2022 2:03:16 AM ******/
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
/****** Object:  StoredProcedure [dbo].[Add_order_details]    Script Date: 12/21/2022 2:03:16 AM ******/
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
/****** Object:  StoredProcedure [dbo].[ADD_USER]    Script Date: 12/21/2022 2:03:16 AM ******/
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
/****** Object:  StoredProcedure [dbo].[AddOrdere]    Script Date: 12/21/2022 2:03:16 AM ******/
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
/****** Object:  StoredProcedure [dbo].[AddProduct]    Script Date: 12/21/2022 2:03:16 AM ******/
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
/****** Object:  StoredProcedure [dbo].[DELETE_CUSTOMER]    Script Date: 12/21/2022 2:03:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DELETE_CUSTOMER] @idcus int as
delete from [CUSTOMERS] where IdCustomer=@idcus
GO
/****** Object:  StoredProcedure [dbo].[DeleteProduct]    Script Date: 12/21/2022 2:03:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DeleteProduct] @id int 
as 
delete from PRODUCTS Where IdProduct=@id

GO
/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 12/21/2022 2:03:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteUser] 
@idUser int 
as
delete from ECOM_USERS where iduser=@idUser
GO
/****** Object:  StoredProcedure [dbo].[GET_ALL_ORDERS]    Script Date: 12/21/2022 2:03:16 AM ******/
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
/****** Object:  StoredProcedure [dbo].[GET_ALL_PRODUCTS]    Script Date: 12/21/2022 2:03:16 AM ******/
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
/****** Object:  StoredProcedure [dbo].[GET_ALL_PRODUCTS_AMAGES]    Script Date: 12/21/2022 2:03:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GET_ALL_PRODUCTS_AMAGES] AS
SELECT  img1,img2,img3 from PRODUCTS 
GO
/****** Object:  StoredProcedure [dbo].[GET_ALL_USERS]    Script Date: 12/21/2022 2:03:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GET_ALL_USERS] AS
select * from ECOM_USERS
GO
/****** Object:  StoredProcedure [dbo].[GET_LAST_ORDER_ID]    Script Date: 12/21/2022 2:03:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_LAST_ORDER_ID] AS
SELECT isnull( MAX(IdOrder)+1,1) from ORDERS
GO
/****** Object:  StoredProcedure [dbo].[GET_ORDER_DITAILLS]    Script Date: 12/21/2022 2:03:16 AM ******/
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
/****** Object:  StoredProcedure [dbo].[GET_PRODUCT_IMAGE1]    Script Date: 12/21/2022 2:03:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_PRODUCT_IMAGE1] @PID INT AS
SELECT  img1 from PRODUCTS where IdProduct=@PID
GO
/****** Object:  StoredProcedure [dbo].[GET_PRODUCT_IMAGE2]    Script Date: 12/21/2022 2:03:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_PRODUCT_IMAGE2] @PID INT AS
SELECT  img2 from PRODUCTS where IdProduct=@PID
GO
/****** Object:  StoredProcedure [dbo].[GET_PRODUCT_IMAGE3]    Script Date: 12/21/2022 2:03:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_PRODUCT_IMAGE3] @PID INT AS
SELECT  img3 from PRODUCTS where IdProduct=@PID
GO
/****** Object:  StoredProcedure [dbo].[GET_PRODUCT_IMAGES]    Script Date: 12/21/2022 2:03:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GET_PRODUCT_IMAGES] @PID INT AS
SELECT  img1,img2,img3 from PRODUCTS where IdProduct=@PID
GO
/****** Object:  StoredProcedure [dbo].[GetAllCustomers]    Script Date: 12/21/2022 2:03:16 AM ******/
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
/****** Object:  StoredProcedure [dbo].[GetAllGategores]    Script Date: 12/21/2022 2:03:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllGategores] as
select idCAT , NamCAT from CATEGORES
GO
/****** Object:  StoredProcedure [dbo].[PS_Chearch]    Script Date: 12/21/2022 2:03:16 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SEARCH_CUSTOMER]    Script Date: 12/21/2022 2:03:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SEARCH_CUSTOMER] @text varchar(20) as
select * from CUSTOMERS 
where FirstName+LastName+phone+email+city like '%'+@text+'%'
GO
/****** Object:  StoredProcedure [dbo].[SearchOrder]    Script Date: 12/21/2022 2:03:16 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SearchUser]    Script Date: 12/21/2022 2:03:16 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_LOGIN]    Script Date: 12/21/2022 2:03:16 AM ******/
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
/****** Object:  StoredProcedure [dbo].[UPDATE_CUSTOMER]    Script Date: 12/21/2022 2:03:16 AM ******/
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
/****** Object:  StoredProcedure [dbo].[UPDATE_USER]    Script Date: 12/21/2022 2:03:16 AM ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateProduct]    Script Date: 12/21/2022 2:03:16 AM ******/
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
/****** Object:  StoredProcedure [dbo].[VerifyQte]    Script Date: 12/21/2022 2:03:16 AM ******/
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
USE [master]
GO
ALTER DATABASE [ECOM] SET  READ_WRITE 
GO
