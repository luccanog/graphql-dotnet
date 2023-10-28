# GraphQL 

## How to run

1. Requirements
	* [Docker](https://www.docker.com/products/docker-desktop/) for running the application container.
	* [dotnet](https://dotnet.microsoft.com/pt-br/download/dotnet/thank-you/sdk-7.0.403-windows-x64-installer) and [dotnet-ef](https://learn.microsoft.com/en-us/ef/core/cli/dotnet) tool to auto create the database or debug the application.
2. Run `docker-compose up`. It is going to start both the API and the Sql Server database.
3. If it is the first running, you might run  `dotnet ef database update` to create the database. The tables  are going to be created automatically by *ef migrations*, but if you wish, you can create them with the script below:

#### Categories table


```SQL
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](80) NOT NULL,
	[ImageUrl] [nvarchar](300) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Categories] ADD  CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
```

#### Products table
 
```SQL
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](80) NOT NULL,
	[Description] [nvarchar](300) NOT NULL,
	[Value] [decimal](18, 2) NOT NULL,
	[ImageUrl] [nvarchar](300) NOT NULL,
	[Quantity] [real] NOT NULL,
	[CreationDate] [datetime2](7) NOT NULL,
	[CategoryId] [uniqueidentifier] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
</code>code>
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
```
