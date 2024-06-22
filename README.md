# GraphQL CRUD with EF 8, .NET 8, Hot Chocolate, and SQL Server 2022
This repository contains a GraphQL CRUD application built with Entity Framework 8.0.6 and .NET 8, using the Hot Chocolate 13.9.6 library for GraphQL implementation and SQL Server 2022 for the database. It showcases how to perform Create, Read, Update, and Delete operations through a GraphQL API.

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

# Test GraphQL Mutations 
    GraphQL Query: 
mutation ($addCake: CakeInput!) {
  saveCake(newCake: $addCake) {
    id
  }
}
    Variables:

{
  "addCake": {
    "id": 0,
    "description": "Choco flavored cake",
    "name": "Chocolate cake",
    "price": 75
  }
}

# Update a Cake

    GraphQL Query:

mutation ($updateCake: CakeInput!) {
  updateCake(updateCake: $updateCake) {
    id
    description
    name
    price
  }
}

    Variables:
{
  "updateCake": {
    "id": 1,
    "description": "Strawberry sweet flavored cake",
    "name": "Strawberry cake",
    "price": 80
  }
}

# Delete a Cake

    GraphQL Query:
mutation ($id: Int!) {
  deleteCake(id: $id)
}

    Variables:

{
  "id": 1
}
