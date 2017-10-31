CREATE PROCEDURE [dbo].[GetAllCustomers]
AS
BEGIN
    -- prevent extra result sets from interfering with SELECT statements
    SET NOCOUNT ON;

select *
from Customers

END