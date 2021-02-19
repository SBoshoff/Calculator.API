# Calculator.API

## Description

This is a basic calculator application that runs off a .NET Framework API. Values are input on the web page and the calculations are performed in the API. A request log consisting of the requestor's IP address and date of access are stored in a SQL database for each calculation.

## What was used

* Visual Studio 2019
* .NET 5.0
* SQL Server 15
* SSMS 18.6

## Setting up the DB

* In the project root, open a Powershell terminal or command prompt.
* Run the following command
  * `Update-Database` for Powershell
  * `dotnet ef database update` for terminal
* Open your MSSQL Management Studio in a Windows authenticated server (localhost) and confirm that the database 'CalculatorSheldonBoshoff' with the table 'AccessLogs' exists.

## Starting the app

### Option 1
* Open a terminal in the root directory of the app.
* Run `dotnet run`
* Open http://localhost:5000 in your browser.
  * Depending on your browser, you can also try in https://localhost:5001, but this may be limited due to CORS policy and lack of any signed certificates.
* Enjoy.

### Option 2
* Open the project in Visual Studio 2019
* Run IIS Express. http://localhost:5000 should open in your browser automatically.

## Notes

* Due to the fact that the application is running off localhost, it is likely that all logged IP addresses will reflect as 0.0.0.1. This might not be the case in a live environment.
* The speed of the calculation is dependent on how quickly the app can write to the DB. There might be a delay between clicking equals and seeing the result.
