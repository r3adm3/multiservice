# MultiService
This service is a demonstration of moving from a monolithic code base to a more microservices based architecture.

This is paired up with the repo: http://github.com/r3adm3/monolithsvc

## Compiling in Development

Clone the repo. Ensure .Net Core 2 is installed. Any of the component microservices can be tested with a simple by cd'ing into its directory

```dotnetcore
dotnet run
```

Test should be able to be run using a browser, and going to http://localhost:5000/api/addservice?a=1&b=2
(replace add with add, minus or multiply). Front end service is hosted on http://localhost:5000 when run individually. 

## Making a docker image

Included in the project is a docker-compose.yml file which will create a docker image artifacts of each of the subcomponent webapi services, change into the source code directory and type:

```docker
docker-compose build
```

To run all containers that comprise this solution:

```docker
docker-compose up
```

Test should be able to be run using a browser, and going to http://localhost:18080
