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
*************************************************************************
*************************************************************************
*************************************************************************
*************************************************************************
*************************************************************************
*************************************************************************
*************************************************************************
*************************************************************************

