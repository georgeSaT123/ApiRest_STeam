Anotaciones  
PAQUETES
WebApi
Microsoft.AspNetCore.Authentication.JwtBearer
Microsoft.AspNetCore.Identity.EntityFrameworkCore
Microsoft.AspNetCore.Identity.UI
Microsoft.EntityFrameworkCore.Tools

DataAccess
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

Comandos Terminal
dotnet build: compila proyecto
dotnet run: en Proyecto principal y ejecuta el proyecto
dotnet add package NOMBRE VERSION

Hacer Migracion CodeFirst
Crear la BD, el nombre 
definir ConnectionStrings en app Settings 
 con valor en "DefaultConnection": "Data Source = localhost; Initial Catalog = ApiRest; Integrated Security = true;"
dotnet ef migrations add "NOMBRE": inicia la migracion
dotnet ef database update: actualiza en la bd los cambios
