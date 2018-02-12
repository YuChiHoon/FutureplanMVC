CREATE TABLE [dbo].[Communities]
(
	[CommunityId] INT Identity(1,1) NOT NULL PRIMARY KEY,
	[CommunityName] VarChar(25) NOT NULL,
	[CommunityDescription] VarChar(255) NULL,
	[CreationDate] DateTime Default(GetDate()) NULL,

	[MeaderHtnl] [varchar](8000) NULL,
	[FooterHtnl] [varchar](8000) NULL
)
Go