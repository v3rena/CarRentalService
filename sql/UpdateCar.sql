CREATE PROCEDURE [dbo].[UpdateCar]
    -- Add the parameters for the stored procedure here
    @CarId int,
    @Model varchar(50),
    @price float,
	@timeShouldReturn Date,
	@isAvailable bit,
	@CustomerId int
	
AS
BEGIN
    -- prevent extra result sets from interfering with SELECT statements.
    SET NOCOUNT ON;

    Update [dbo].[Cars] 
    set Model = @Model,Price = @price, TimeShouldReturn = @timeShouldReturn, IsAvailable = @isAvailable, CustomerId = @CustomerId
    where id = @CarId;

END