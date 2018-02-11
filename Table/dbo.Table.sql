CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1),
	Title NVarChar(140) Not Null,
	Iscompleted BIT,
	CreationDate DateTime Default(GetData())
)