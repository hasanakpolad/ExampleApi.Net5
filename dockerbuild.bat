dotnet publish ExampleApi.Net5/ExampleApi.Net5.csproj -c Debug -o publish

docker build -t first_demo:latest .

docker tag first_demo:latest hsnakpld/first_demo:latest

docker push hsnakpld/first_demo:latest
