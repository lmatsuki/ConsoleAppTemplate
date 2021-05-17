# ConsoleAppTemplate for .NET 5
 A simple starter Console application template with preconfigured settings.
 
 This example uses the .NET Generic Host with a Stop.Application call at the end to shutdown the application once it is started.

## Preconfigured Settings
* Includes the non-HTTP workload defaults setup by CreateHostBuilder() method ([see more info](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/generic-host?view=aspnetcore-5.0#default-builder-settings))
* Setup to use Serilog as the logger
* Reads logger configuration from appsettings.json
* Ends application after processing by calling StopApplication()
* Only references two nuget packages ([Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting/) and [Serilog.AspNetCore](https://www.nuget.org/packages/Serilog.AspNetCore/))
