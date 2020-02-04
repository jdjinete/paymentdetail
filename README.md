# paymentdetail
This is the repo for work in Api dot net core 3 and Sql server with docker 


1. dotnet new webapi -o paymentdetailapi
2. dotnet run
3. Create Dockerfile and config csprog and dll.
4. Create folder Models and your model.
5. Create class DBContext.
6. Add package  dotnet add package Microsoft.EntityFrameworkCore -
7. Config the conexionstring
8. Add packade Microsoft.EntityFrameworkCore.SqlServer
9. dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
10. dotnet add package Microsoft.EntityFrameworkCore.Design
11. dotnet tool install --global dotnet-aspnet-codegenerator
12. dotnet aspnet-codegenerator controller -name PaymentDetailController -async -api -m PaymentDetail -dc PaymentDetailContext -outDir Controllers
13. dotnet tool install --global dotnet-ef
14. dotnet ef migrations add PaymentDetailDB
15. dotnet run 
16. dotnet add paymentdetailapi.csproj package Swashbuckle.AspNetCore -v 5.0.0
17. using Microsoft.OpenApi.Models; in startup.
18.   services.AddSwaggerGen
19. Configure UseSwagger() and UseSwaggerUI.
20.  GenerateDocumentationFile in csprog.



