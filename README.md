Final Project - IT-INTPROG32LEC-04671

Members :
JERMAINE AGUILAR, 
FRANCES DIANA CARSIDO, 
JOHN BENEDICT CINCO,
LEMARC EYAC,
SHYRELLE SHINE MANAGAYTAY



PoetryWebsite

This is a simple ASP.NET Core MVC application that allows users to post poetry without requiring registration or login.

Setup Instructions

Prerequisites

1. Visual Studio 2019 or later with the following workloads:
   - ASP.NET and web development
   - .NET Core cross-platform development

2. SQL Server Express or LocalDB (included with Visual Studio)

Steps to Run the Project

1. **Extract the Zip File:**
   - Extract the contents of the provided zip file to a local directory.

2. **Open the Project in Visual Studio:**
   - Open Visual Studio.
   - Click on `Open a project or solution`.
   - Navigate to the extracted folder and select the `.sln` file.

3. **Restore NuGet Packages:**
   - Go to `Tools` -> `NuGet Package Manager` -> `Package Manager Console`.
   - Run the following command to restore NuGet packages:
     ```sh
     dotnet restore
     ```

4. **Update the Database:**
   - In the Package Manager Console, ensure the Default Project is set to your project (e.g., `PoetryWebsite`).
   - Run the following command to apply migrations and create the database:
     ```sh
     Update-Database
     ```

5. **Run the Application:**
   - Press `F5` or click the `IIS Express`/`PoetryWebsite` button to run the application.
   - The application should open in your default web browser.

Troubleshooting

- **Connection Issues:**
  If you encounter issues connecting to the database, ensure that LocalDB is installed and running. You can check this by running `sqllocaldb info` in the command prompt.

- **Ports and URLs:**
  The application might run on a different port on your machine. Make sure to check the URL in the browser's address bar.
