# _Animal Shelter API_

### _Building an API with Swagger Documentation_

##### By:
#####  _**Jamie Knutsen**_ _©2021_


## Technologies Used

* _Visual Studio Code_
* _.NET_
* _C#_
* _Entity Framework Core (EF Core)_
* _ASP.NET Core MVC_
* _MySQL_
* _Swagger_
* _Postman_


## Description: 
This project was designed as practice for building a basic Web API from scratch using C# and .NET with the implementation of Swagger documentation.


## Setup/Installation Requirements
_You can view this webpage by checking out the url:_
https://github.com/Knutsenjamie/AnimalShelter.Solution

### Prerequisites
* [C# & .NET] Install at (https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.100-macos-x64-installer) (If Mac) OR https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.102-windows-x64-installer (If Windows)
* [dotnet script] After installing C# and .NET, run the command 'dotnet tool install -g dotnet-script' in your computer's terminal or text editors terminal. 
* A text editor such as [VS Code] (https://code.visualstudio.com/)
* For the database, you'll need to install MySQL (https://dev.mysql.com/downloads/file/?id=484914). I also suggest using MySQL workbench as a GUI for viewing databases to check that they're up to date. 

### Installation
1. Open terminal
2. Input these commands into terminal's command line `cd desktop`
3. Clone this repo https://github.com/Knutsenjamie/AnimalShelter.Solution from github.
4. Run the command `code .` in your computer's terminal
5. Open VS Code or other preffered text editor terminal within the project file
6. To install and make sure all needed packages are up-to-date, navigate into the AnimalShelter folder from root directory by entering `cd AnimalShelter` in terminal.
    * Type the command `dotnet restore` to update and restore all needed packages and dependencies to run application.
7. In order to use the database you must make an appsettings.json file. Run the command `touch appsettings.json` in the `AnimalShelter` directory of the project. 
    * Then, enter in your own approppriate username (or enter 'root' in the YOUR-USERNAME-HERE field), and whichever password you used to open, use, and create the imported database in MySQL Workbench- use it and enter it as follows in this line 'database=animal_shelter;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE]' *do NOT actually put []- this is just for visual purposes to see where to change the information*
    <code> 
    Test
    {
        blah blah blah 
    
    }
    </code>