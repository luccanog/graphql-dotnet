# GraphQL 

## How to run

1. Requirements
	a.  [Docker](https://www.docker.com/products/docker-desktop/) for running the application container.
	b. [dotnet](https://dotnet.microsoft.com/pt-br/download/dotnet/thank-you/sdk-7.0.403-windows-x64-installer) and [dotnet-ef](https://learn.microsoft.com/en-us/ef/core/cli/dotnet) tool to auto create the database or debug the application.
2. Run `docker-compose up`. It is going to start both the API and the Sql Server database.
3. If it is the first running, you might run  `dotnet ef database update` to create the database. Don't worry about the tables, they are going to be created automatically by *ef migrations*.
