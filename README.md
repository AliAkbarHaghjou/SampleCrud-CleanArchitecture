# SampleCrud with CleanArchitecture
This is a simple crud implementation with clean architecture;

## Architecture And Design Patterns Which Have Been Used :
* Clean architecture
* Unit Of Works

## Technologies and Libraries Which Have Been Used :
* Asp.net Core 5 MVC
* Entity Framework Core
* SQL Server for database
* Swashbuckle (For API documentation based on Swagger and OpenAPI specification)
* AutoMapper

## How to start it : 
* First of all, You have to create a database which name is **SimpleCrud**
* after being sure from creating a database, You have to run this command **dotnet ef --startup-project SimpleCrud.WebApi/SimpleCrud.WebApi.csproj migrations add InitialModel -p SimpleCrud.Persistence/SimpleCrud.Persistence.csproj** in the directory where the **SimpleCrud.sln** is located to create the initial migration.
* at last, run this command **dotnet ef --startup-project SimpleCrud.WebApi/SimpleCrud.WebApi.csproj database update** in the directory where the **SimpleCrud.sln** is located to create your tables.
* Open the project solution with visual studio and **press F5**.
