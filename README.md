# Message Board

#### A C# API Message Board

#### By Paul LeTourneau, Ian Bravo, and Jake Elsberry

## Technologies Used

- _C#_
- _.NET 6_
- _ASP.NET Core_
- _MySQL Workbench_
- _MySQL Community Server_
- _Entity Framework Core_

## Description

- _This API will allow a user to manage a message board. Adding groups, users, and messages. Messages are able to have an author listed, and belong within a group heading. _

- _Technical Details:_

  - _This web application was written using C#, run using .NET framework, and database query and relationships handled using Entity Framework Core._
  - _Full CRUD functionality works for messages._
  - _The list of messages belonging to a specific group has been paginated_
  - _Data storage is managed using MySQL. Entity Framework Core .NET Command-line Tools (or dotnet ef) is used for database version control -- migrations are created to tell MySQL how the database is structured and updated as needed._


## Setup/Installation Requirements

### Required Technology

- _Verify that you have the required technology installed for MySQL (https://dev.mysql.com/doc/mysql-installation-excerpt/5.7/en/) and MySQL Workbench (https://dev.mysql.com/doc/workbench/en/)._
- _Also check that Entity Framework Core's `dotnet-ef` tool is installed on your system so that it can perform database migrations and updates. Run the following command in your terminal:_
  > ```
  > $ dotnet tool install --global dotnet-ef --version 6.0.0
  > ```

### Setting Up the Project

_1. Open your terminal (e.g., Terminal or GitBash)._

_2. Navigate to where you want to place the cloned directory._

_3. Clone the repository from the GitHub link by entering in this command:_

> ```
> $ git clone https://github.com/pletourneau/MessageBoardApi
> ```

_4. Navigate to the project's production directory `MessageBoardApi`, and create a new file called `appsettings.json`._

_5. Within `appsettings.json`, add the following code, replacing the `uid`, and `pwd` values with your username and password for MySQL. Under `database`, add any name that you deem fit -- although `message_board_api` is suggested for organization sake and clarity of purpose._

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATABASE-NAME-HERE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}

```

_6. In the terminal, while in the project's production directory `MessageBoardApi`, run the following command. It will utilize the repository's migrations to create and update the database. You may opt to verify that the database has been created successfully in MySQL Workbench._

> ```
> $ dotnet ef database update
> ```

## Running the Project

- _In the command line, while in the project's production directory `MessageBoardApi`, run this command to compile and execute the web application. A new browser window should open, allowing you to interact the API via Swagger._

> ```
> $ dotnet watch run
> ```

- _Alternatively, using the command `dotnet run` will execute the application. Manually open a browser window and navigate to the application url (ex: `https://localhost:5001` or `http://localhost:5000`)_

> ```
> $ dotnet run
> ```

- _Optionally, to compile this web app without running it, enter:_

> ```
> $ dotnet build
> ```

## API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

### Note on Pagination
There is no default for the `pageIndex` (on which page to begin) or `pageSize` (how many results will be displayed on each page) when returning the paginated messages within a group.

To modify this, alter the query parameters (the integer after the equal signs) of `pageIndex` and `pageSize` in the example query below.

#### Example Query
```
https://localhost:5001/api/Groups/1/messages?pageIndex=1&pageSize=3

```
..........................................................................................

### Endpoints
Base URL: `https://localhost:5000`

### Messages
Create, read, edit, and update messsages in a specific group authored by a specific user

#### HTTP Request
```
GET /api/Messages
POST /api/Messages
GET /api/Messages/{id}
PUT /api/Messages/{id}
DELETE /api/Messages/{id}
GET /api/Messages/{datetime}
```


#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| MessageName | string | none | false | Return matches by message name.
| GroupId | int | none | false | Return messages belonging to a specific group based on its GroupId.
| UserName | string | none | false | Return messages posted by a specific user based on their username. |
| fromDate | string | none | false | Return messages posted on or after the specified date (format: yyyy-MM-dd).
| toDate | string | none | false | Return messages posted on or before the specified date (format: yyyy-MM-dd). |

#### Example Query
```
https://localhost:5001/api/Messages

```

#### Sample JSON Response
```
{
    "messageId": 114,
    "userName": "ScarySpice",
    "groupId": "1",
    "messageTime": "2023-10-05T12:01:42"
}
``` 


## Known Bugs

- _none. Please email Paul at <pletourneau62@gmail.com> if any are found!_

## License

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Copyright (c) _2023_ _Paul LeTourneau_