# frontEnd

This frontend does different operations to two numbers together and forms part of a multiservice example that can be run in docker compose or kubernetes.

Parent repo: <http://github.com/r3adm3/multiservice>

## Dependencies

Current version of dotnet core this has been tested with is .NET Core 3.1.0 on Windows/Mac

## Compile it

In the frontEnd folder

```dotnetcore
dotnet build
```

## Test it

In the frontEnd folder

```dotnetcore
dotnet run
```

Go to URL <http://localhost:5000/>

## Docker Image

In the frontEnd folder

```docker
docker image build -t frontEnd:edam_dev .
```

## How do I run a test

Make sure you are in the frontEnd.Tests project folder and run the following:

```dotnetcore
dotnet test
```

or (for a bit more information)

```dotnetcore
dotnet test -v n
```
