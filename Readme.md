# MultiService (docker service example)
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

To run all containers that comprise this solution using docker-compose:

```docker
docker-compose up
```

...and cleanup

```docker
docker-compose down
```

Test should be able to be run using a browser, and going to http://localhost:18080

To run all containers that comprise this solution using minikube:

```kubectl
minikube start
kubectl delete -f multiservice.k8s-deployment.yaml
kubectl delete -f multiservice.k8s-service.yaml
```

...and cleanup

```kubectl
kubectl delete -f multiservice.k8s-service.yaml
kubectl delete -f multiservice.k8s-deployment.yaml
minikube stop
```

Test should be able to be run using a browser, and going to http://localhost:30500