
# .NET Core Web API Country App Api

This is an App to display all countries and their flags including details.
This leverages .NET 8.0, You can learn .NET 8 more on [ASP.NET Core 8.0](https://learn.microsoft.com/en-us/aspnet/core/release-notes/aspnetcore-8.0?view=aspnetcore-9.0).

## Versioning
| GitHub Release | .NET Core Version |
|----------------|------------ |
| main | .8.0 | 

## Project Structure
```
├── Controllers
│   └── CountryController.cs
├── Models
├── Program.cs
├── Properties
│   └── launchSettings.json
├── README.md
├── Repositories
│   └── CountryRespoitory.cs
├── Startup.cs
├── appsettings.Development.json
├── bin
│   └── Debug
├── configs
│   └── prod
├── CountryAPI.csproj
├── CountryAPI.sln
├── manifests
│   ├── deployment.yaml

```

- `appsettings.Development.json` is .NET Core Web API development environment config
- `Startup.cs` is .NET Core Web API startup & path routing config 
- `Program.cs` is .NET Core Web API environment variable mapping config 

## Setting Up

To setup this project, you need to clone the git repo

```sh
$ git clone https://github.com/TsireledzoRambuwani/CountryApp.git
$ cd CountryApp
```

followed by

```sh
$ dotnet restore
```

