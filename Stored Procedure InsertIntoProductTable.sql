create table product(NAME varchar(50),GROUPNAME varchar(50),MODIFIEDDATE datetime)

CREATE PROC  [DBO].[USP_INSERTDATAINTOPRODUCT](@IP1 VARCHAR(50),@IP2 VARCHAR(50))
AS
BEGIN
	BEGIN TRY
			BEGIN
				INSERT INTO DBO.PRODUCT (NAME,GROUPNAME,MODIFIEDDATE) VALUES(@IP1,@IP2,GETDATE())	
		END
		RETURN 1
		
	END TRY
	BEGIN CATCH
		RETURN -99
	END CATCH
END

