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
    * Then, enter in your own approppriate username (or enter 'root' in the YOUR-USERNAME-HERE field), and whichever password you used to open, use, and create the imported database in MySQL Workbench- use it and enter it as follows in this line <code>database=animal_shelter;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE]</code> *do NOT actually put []- this is just for visual purposes to see where to change the information*
    * Finally, paste it exactly like in this example, 
    ```
    {
        "Logging": {
            "LogLevel": {
            "Default": "Information",
            "Microsoft": "Warning",
            "Microsoft.Hosting.Lifetime": "Information"
            }
        },
        "AllowedHosts": "*",
        "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
        }
    }
    ```
    and paste it into the appsettings.json to use the database. *WARNING: This file should automatically be ignored AS LONG AS it is in the AnimalShelter directory and NOT the root directory (as it is listed in the .gitignore). However, Be aware of what you are committing and pushing to avoid pushing your personal username and password- as it is sensitive data* Your database should now be connected. 
    8. To create and run the database, navigate back to the root directory `cd AnimalShelter.Solution` and enter the command `dotnet tool install --global dotnet-ef` in the terminal to enable EF Core migrations if not already enabled.
    * Then, if you plan on changing the controller files at all or the models and do make changes, be sure to navigate back into the project folder `cd AnimalShelter`, and run the command `dotnet ef migrations add [NAME OF YOUR MIGRATION]` to add an updated migration so that the database updates correctly. Naming conventions for migrations work like a git commit- so be sure to be verbose. 
    * After you add migrations, or if you don't add any at all and just want to use the projects exsisting migrations, navigate into the `AnimalShelter` directory again if not there already, and run the command `dotnet ef database update`. You should now be able to open MySQL workbench and see a database named `animal_shelter` that includes all of the projects correct tables and be able to use the database for this API. 
10. Finally, navigate into root directory folder in terminal `cd AnimalShelter.Solution` and  enter command `dotnet run` or `dotnet watch run` to run the program. 

### Full API Documentation
1. If interested in viewing AnimalShelter API's endpoints, you can use Postman like so:
    * Start by running the command `dotnet run` in the `AnimalShelter` project folder if you haven't already to get a server up and running. 
    * Then, navigate to https://www.postman.com and make an account if you haven't already. Once signed in, press "Launch Postman". On the left-hand side, look for the "Workspaces" tab, and select it. Once inside, select "My Workspace". 
    * Once you are inside of your workspace, look almost directly under the search bar on the top- there will be an "Overview" and a "+" Tab. Navigate over to the "+" Tab.  
    * For GET requests: to get all the Animals in this API, enter http://localhost:5000/api/Animals into the "GET" search bar and select send. Then, the correct response should appear in the "Pretty" Tab as a JSON response exactly like this:
```
{
        "animalId": 1,
        "name": "Peppermint",
        "breed": "Tuxedo",
        "type": "Cat",
        "description": "The most chill cat you will ever meet. Peppermint loves snuggles, catnip, and his favorite mouse toy that has a bell inside of it. Adopt this sweet adult kitty today!",
        "age": 7,
        "gender": "Male"
    },
    {
        "animalId": 2,
        "name": "Weenie",
        "breed": "Dachshund",
        "type": "Dog",
        "description": "Even though he's got somewhat of a fiesty personality; Weenie is your average, loveable, Dachshund. His favorite toy is a giant stuffed pickle that makes crinkly sounds. Adopt Weenie today!",
        "age": 1,
        "gender": "Male"
    },
    {
        "animalId": 3,
        "name": "Lasagna",
        "breed": "Orange Tabby",
        "type": "Cat",
        "description": "Lasagna is your typical, spunky little kitten. He loves to zoomie around and play with anything that moves honestly. Lasagna is the perfect addition for a family with young children. Adopt today!",
        "age": 1,
        "gender": "Male"
    },
    {
        "animalId": 4,
        "name": "Peanut Butter",
        "breed": "Rottweiler",
        "type": "Dog",
        "description": "Looking for a loyal friend and protector of your home? Peanut Butter is the perfect combination of sweet, friendly, protective and loyal. Rescued from a hording situation, Peanut Butter has come a long way through our rehab program for rescues. Her favorite toy is a classic tennis ball to play fetch with. Adopt this deserving pupper today!",
        "age": 4,
        "gender": "Female"
    },
    {
        "animalId": 5,
        "name": "Smeagol",
        "breed": "Likoi",
        "type": "Cat",
        "description": "One of the shelters first werewolf cats, Smeagol is a sweet little lady who enjoys snuggling up and cuddling. Smeagol was a rescue from a bad breeding situation, but has aced our rehab program and is ready for a forever home! Her favorite thing ever is catnip. Bring Smeagol home today!",
        "age": 4,
        "gender": "Female"
    },
    {
        "animalId": 6,
        "name": "Aki",
        "breed": "Shiba Inu",
        "type": "Dog",
        "description": "Do you love to hike? Do you want a pup that will be your best outdoorsy friend? Aki the energetic and loving Shiba Inu is perfect for your family! Aki loves to get down and dirty and play in the mud sometimes, but give her a bath and she'll enjoy that just as much. Bring Aki home today!",
        "age": 2,
        "gender": "Female"
    },
    {
        "animalId": 7,
        "name": "Pierre",
        "breed": "Blue Iguana",
        "type": "Iguana",
        "description": "One of our only other species available, Pierre is a Blue Iguana that was rescued from a sketchy tropical pet store. Pierre is quiet, but will bring joy to any reptile-experienced family that passes a basic background check. Pierre likes to sun himself- especially on his favorite rock. If you qualify, adopt this big loveable dude today!",
        "age": 5,
        "gender": "Male"
}
```
 * To GET by querying the ID: simply enter http://localhost:5000/api/Animals/[ENTER-ID-NUMBER-HERE] into that same GET search bar and simpy replace the [ENTER-ID-NUMBER-HERE] with an Id number of choice you would like to see. For Example, http://localhost:5000/api/Animals/4 will return a response exactly like so:
 
 ```
{
    "animalId": 4,
    "name": "Peanut Butter",
    "breed": "Rottweiler",
    "type": "Dog",
    "description": "Looking for a loyal friend and protector of your home? Peanut Butter is the perfect combination of sweet, friendly, protective and loyal. Rescued from a hording situation, Peanut Butter has come a long way through our rehab program for rescues. Her favorite toy is a classic tennis ball to play fetch with. Adopt this deserving pupper today!",
    "age": 4,
    "gender": "Female"
}
```
* **Note**: You can also GET responses by querying by Breed (such as http://localhost:5000/api/Animals/?breed=Dachshund), by Gender (such as http://localhost:5000/api/Animals/?gender=female), by Name (http://localhost:5000/api/Animals/?name=Smeagol), or by Type (http://localhost:5000/api/Animals/?type=iguana). Finally, simply switch out the specific parameters to retrieve whichever specific data you want (i.e. - switching [?name=Smeagol] into [?name=Weenie] and so forth.)
* For POST requests: If you would like to add some Animals to this API, Switch the request in the dropdown to the left from GET to POST. Next, deselect the "Params" tab underneath and switch to the "Body" tab. Then, select the radio button that says "Raw" and paste this into the body- replacing all values with the values you want:
```
{
    "animalId": 0,
    "name": "string",
    "breed": "string",
    "type": "string",
    "description": "string",
    "age": "int",
    "gender": "string"
}
```
* Finally, after filling out your preferred values, enter in http://localhost5000/api/Animals into the search bar and press "Send".
* For PUT requests: To edit an exsisting entry with a PUT request, select the dropdown from GET or POST to PUT instead. Again, select the "Body" tab, and select the "raw" radio button. Post the following into the body and replace the values as you would like just as you would in the POST request:

```
{
    "animalId": 0,
    "name": "string",
    "breed": "string",
    "type": "string",
    "description": "string",
    "age": "int",
    "gender": "string"
}
```
   * Finally, after filling out your preffered values, enter in http://localhost5000/api/Animals/[THE-ID-NUMBER-YOU-WANT-TO-EDIT/REPLACE] Ex: If you wanted to replace Peppermint (who has the id of one), you'd put http://localhost5000/api/Animals/1.


