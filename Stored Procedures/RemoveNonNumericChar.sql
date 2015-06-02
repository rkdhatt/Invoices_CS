-- =============================================
-- Author:		Raman Dhatt
-- Create date: 02-06-2015
-- Description:	Return string with only numerical values (phone).
-- Source: http://stackoverflow.com/questions/106206/fastest-way-to-remove-non-numeric-characters-from-a-varchar-in-sql-server
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'RemoveNonNumericChar')
	DROP FUNCTION RemoveNonNumericChar
GO

create function RemoveNonNumericChar(@str varchar(500))  
returns varchar(500)  
begin  
declare @startingIndex int  
set @startingIndex=0  
while 1=1  
begin  
    set @startingIndex= patindex('%[^0-9]%',@str)  
    if @startingIndex <> 0  
    begin  
        set @str = replace(@str,substring(@str,@startingIndex,1),'') 
    end  
    else    break;   
end  
return @str  
end

go  
