------------toute les procedure-------

-----login
********************************
create proc SP_LOGIN
@user varchar(20),@PASS VARCHAR(10)
AS
SELECT* FROM ECOM_USERS 
WHERE userName=@user and PassWorde=@PASS

********************************

********************************
