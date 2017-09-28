# Create a web API with ASP.NET Core 1.0 and Visual Studio for Windows

This is a sample web API using ASP.NET Core 1.0. It has been developed following the [ASP.NET Core 2.0 tutorial](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api). For the most part it follows the tutorial well, but there was a small differences.

## Differences with 2.0 setup

The only major difference I found was in updating `Startup.cs`. In the tutorial, they suggest using an in memory database for storage. This is made possible by `UseInMemoryDatabase()`:

```c#
public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TodoContext>(o => o.UseInMemoryDatabase());
            //rest of the configuration
 ```
In 2.0 it appears this extension method is available with the corrosponding EntityFramework for ASP.NET Core 2.0. In other words this `using Microsoft.EntityFrameworkCore;` at the top of `Startup.cs` is enough. However with 1.0 version the EntityFramework is not loaded with this method. To load it you will need to get the package for it. In the nuget package manager console:

```
PM> Install-Package Microsoft.EntityFrameworkCore.InMemory -Version 1.0.0
```
Now the `UseInMemoryDatabase()` method should be available.
