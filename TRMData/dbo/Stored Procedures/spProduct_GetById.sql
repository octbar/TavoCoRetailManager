CREATE PROCEDURE [dbo].[spProduct_GetById]
	@Id int
AS
begin
	set nocount on;

	 select Id, ProductName, [Description], RetailPrice, QuantiyInStock, IsTaxable
   from dbo.Product
   where Id = @Id;
end