CREATE PROCEDURE [dbo].[GetAllCars]
AS
BEGIN
    -- prevent extra result sets from interfering with SELECT statements
    SET NOCOUNT ON;

select *
from Cars

END