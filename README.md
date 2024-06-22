# GraphQL-CRUD-EF8-Net8-HC-SQL2022
This repository contains a GraphQL CRUD application built with Entity Framework 8.0.6 and .NET 8, using the Hot Chocolate 13.9.6 library for GraphQL implementation and SQL Server 2022 for the database. It showcases how to perform Create, Read, Update, and Delete operations through a GraphQL API.
 GraphQL CRUD Operations with ASP.NET Core, Entity Framework, and HotChocolate 
 
#  Prerequisites

    Visual Studio 2022 installed
    SQL Server 2022 setup
    Basic knowledge of C#, .NET, and GraphQL

# Step 1: Setting Up the Project

    Create a New ASP.NET Core Web API Project
        Open Visual Studio 2022
        Create a new ASP.NET Core Web API project

#    Install Necessary NuGet Packages

    Open the Package Manager Console and run the following commands: 

Install-Package HotChocolate.AspNetCore -Version 13.9.6
Install-Package HotChocolate.Data -Version 13.9.6
Install-Package HotChocolate.Data.EntityFramework -Version 13.9.6
Install-Package Microsoft.EntityFrameworkCore -Version 8.0.6
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 8.0.6
