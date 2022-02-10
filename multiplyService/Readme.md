# multiplyService

This service adds two numbers together and forms part of a multiservice example that can be run in docker compose or kubernetes.

Parent repo: <http://github.com/r3adm3/multiservice>

## Dependencies

Current version of dotnet core this has been tested with is .NET 5.0 on Windows/Mac

## Compile it

In the multiplyService folder

```dotnetcore
dotnet build
```

## Test it

In the multiplyService folder

```dotnetcore
dotnet run
```

Go to URL <http://localhost:5000/api/multiply?a=1&b=2>

Change "a" and "b" to whatever you want. Result that comes back is JSON, including the hostname of the server it runs on, the .NET version is running and the addition result

## Docker Image

In the multiplyService folder

```docker
docker image build -t multiplysvc:edam_dev .
```

## How do I run a test

Make sure you are in the multiplyService.Tests project folder and run the following:

```dotnetcore
dotnet test
```

or (for a bit more information)

```dotnetcore
dotnet test -v n
```
*ver: halloumi*