CREATE PROCEDURE [dbo].[spProduct_GetAll]

AS
begin
   set nocount on;

   select Id, ProductName, [Description], RetailPrice, QuantiyInStock, IsTaxable
   from dbo.Product
   order by ProductName;
end
