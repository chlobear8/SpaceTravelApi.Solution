# Leeloo's Space Travel Agency
#### By Chloe ONeil, Najma Abdi and Mike Wilkes
#### Web application for space travel bookings.

## Technologies Used
- MARKDOWN
- C#
- .NET
- Razor
- MySql
- RestSharp

## Description
This project is built to allow users to book their futuristic vacation spots through Leeloo's travel agency. Splash page contains hot vacation spots and an API from NASA that shows a random space photo. The destinations page features the current bookable spots. Bookings can only be accomplished through signing in with authentication. It can be found at <https://github.com/chlobear8/SpaceTravelApi.Solution>. Contact us with any questions, comments or concerns at <chloesporri@yahoo.com>.

## Setup/Installation Requirements
- Clone this repository to your desktop.
- Download these packages from your terminal:
```bash
$ dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
$ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0 
```
- Acquire an API key from <https://api.nasa.gov/index.html>.
- CD into SpaceTravel and create an appsettings.json file.
- In said file include:
```javascript
{ "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE]"},
        "NASA":[YOUR-API-KEY] }
```
- Run `$ dotnet ef database update` after appsettings.json has been completed to recreate the database in MySql.
- Start a development server with `$ dotnet run`. 

## Known bugs

no known errors.

## License information
Copyright 2023 Chloe ONeil, Najma Abdi and Mike Wilkes
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.




