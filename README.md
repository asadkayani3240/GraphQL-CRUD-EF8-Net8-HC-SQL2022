# GraphQL CRUD with EF 8, .NET 8, Hot Chocolate, and SQL Server 2022
This repository contains a GraphQL CRUD application built with Entity Framework 8.0.6 and .NET 8, using the Hot Chocolate 13.9.6 library for GraphQL implementation and SQL Server 2022 for the database. It showcases how to perform Create, Read, Update, and Delete operations through a GraphQL API.
# This tutorial covers the implementation of a GraphQL CRUD application using Entity Framework 8.0.6 and .NET 8, with the Hot Chocolate 13.9.6 library for GraphQL and SQL Server 2022 for the database. The application showcases Create, Read, Update, and Delete operations through a GraphQL API.
# Prerequisites

    Visual Studio 2022 installed
    SQL Server 2022 setup
    Basic knowledge of C#, .NET, and GraphQL

# Step 1: Setting Up the Project

    Create a New ASP.NET Core Web API Project
        Open Visual Studio 2022
        Create a new ASP.NET Core Web API project

# Install Necessary NuGet Packages
    Open the Package Manager Console and run the following commands:
Install-Package HotChocolate.AspNetCore -Version 13.9.6
Install-Package HotChocolate.Data -Version 13.9.6
Install-Package HotChocolate.Data.EntityFramework -Version 13.9.6
Install-Package Microsoft.EntityFrameworkCore -Version 8.0.6
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 8.0.6
