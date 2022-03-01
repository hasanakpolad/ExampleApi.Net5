FROM mcr.microsoft.com/dotnet/aspnet:6.0

COPY ./ ExampleApi/
WORKDIR /ExampleApi.Net5
EXPOSE 80

ENTRYPOINT ["dotnet", "ExampleApi.Net5.dll"]
