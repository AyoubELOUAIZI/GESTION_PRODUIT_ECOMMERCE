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

-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------

