# NetCore8CRUD


Step by Step
1. Install DotNet SDK 8.0
2. Restore All Nuget Package
3. Run the following command on CMD in application folder path:
   - dotnet add package Microsoft.EntityFrameworkCore.SqlServer
   - dotnet tool install --global dotnet-ef
   - dotnet add package Microsoft.EntityFrameworkCore.SqlServer 
6. Setting ConnectionStrings value on file : appsetting.json
7. Create DB on SQL Server : D8CRUD
8. Restore Database Migration : dotnet ef database update
9. dotnet build
10. dotnet run
