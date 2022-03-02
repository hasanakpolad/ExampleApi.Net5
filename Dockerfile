FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
FROM mcr.microsoft.com/dotnet/sdk:5.0

COPY /publish ExampleApi/
WORKDIR /ExampleApi
EXPOSE 80

ENTRYPOINT ["dotnet", "ExampleApi.Net5.dll"]
