﻿CREATE PROCEDURE [dbo].[spProduct_GetAll]

AS
begin
   set nocount on;

   select Id, ProductName, [Description], RetailPrice, QuantiyInStock
   from dbo.Product
   order by ProductName;
end
