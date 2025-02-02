<a id="readme-top"></a>
## Video preview:
[![Books DB](https://img.youtube.com/vi/0Df7lZarIMk/0.jpg)](https://www.youtube.com/watch?v=0Df7lZarIMk)

## About The Project

A books database that utilizes Winforms to perform CRUD operations and interact with Sql Server.

<b>Project Objective:</b> Sql Server db interaction

### Built With
 [![Csharp][csharp-badge]][csharp-url]
 [![Dotnet][dotnet-badge]][Dotnet-url]
 [![MSSQL][mssql-badge]][mssql-url]
 [![Winforms][winforms-badge]][winforms-url]


## Getting Started

### Prerequisites
Before you can run this application locally, make sure you have the following tools and software installed:

1. **Visual Studio 2022** (or higher) with the **.NET Desktop Development** workload enabled
   - Download from [Visual Studio](https://visualstudio.microsoft.com/)
2. **SQL Server** or **SQL Server Express** installed and running (or use a cloud-based SQL Server instance)
   - You can download SQL Server Express from [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads).
3. **SQL Server Management Studio (SSMS)** (optional, for managing your database)
   - Download from [SSMS](https://aka.ms/ssmsfullsetup).



### Installation
1. Clone the repo
   ```
   > git clone https://github.com/MMdevworks/BooksDbCRUD.git
   > cd BooksDbCRUD
   ```
3. Open the project
   ```
   Open WinFormsCrudApp.sln in Visual Studio
   ```
4. Restore NuGet package dependancies
   ```
   In Visual Studio go to: 
		Tools > NuGet Package Manager > Manage NuGet Packages for Solution > Restore dependencies

   Packages Used:
	- Microsoft.EntityFrameworkCore.SqlServer
	  Microsoft SQL Server database provider for Entity Framework Core.

   ```
5. Configure Database Connection
   Open App.config (or appsettings.json, depending on your setup) in the project and update the connection string to point to your local SQL Server instance. Example connection string for SQL Server:
   
   ```
   <connectionStrings>
    <add name="DefaultConnection" connectionString="Server=localhost;Database=YourDatabase;Trusted_Connection=True;" providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```
5. Run the application
   ```
   Run the program via play button or press f5 in Visual Studio
   ```
### Interface Instructions:
<b>Create:</b> Select the Add button > Fill out the form > press Sumbit to create a new record

<b>Edit:</b> Click a record in the table > press Select to edit the record information > press Update to finalize

<b>Delete:</b> Click a record in the table > press Delete to remove the record

<p align="right">(<a href="#readme-top">Back to top</a>)</p>

[dotnet-badge]: https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white
[Dotnet-url]: https://dotnet.microsoft.com/
[csharp-badge]: https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white
[csharp-url]: https://learn.microsoft.com/en-us/dotnet/csharp/
[mssql-badge]: https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white
[mssql-url]: https://www.microsoft.com/en-us/sql-server
[winforms-badge]: https://img.shields.io/badge/WinForms-0078D4?style=for-the-badge&logo=windows&logoColor=white
[winforms-url]: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-9.0
