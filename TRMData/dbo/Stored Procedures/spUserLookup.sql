CREATE PROCEDURE [dbo].[spUserLookup]
	@Id nvarchar(128)
	
AS
Begin
    set nocount on;

	SELECT Id, FirstName, Lastname, EmailAdress, CreateDate
	from [dbo].[User]
	where Id = @Id;
end
