# MultiService (docker service example)

This service is a demonstration of moving from a monolithic code base to a more microservices based architecture.

This is paired up with the repo: <http://github.com/r3adm3/monolithsvc>

## Compiling in Development

Should work on Windows and Macs (possibly Linux, not tried it yet)
Clone the repo.

Dependencies:-
Docker CE  
VirtualBox  
Minikube  
Dotnet SDK 2.2  
Dotnet SDK 3.0  

Any of the component microservices can be tested with a simple by cd'ing into its directory

```dotnetcore
dotnet run
```

Test should be able to be run using a browser, and going to <http://localhost:5000/api/addservice?a=1&b=2>
(replace add with add, minus or multiply). Front end service is hosted on <http://localhost:5000> when run individually.

## Making a docker image

Included in the project is a docker-compose.yml file which will create a docker image artifacts of each of the subcomponent webapi services, change into the source code directory and type:

```docker
docker-compose build
```

To build and run all containers that comprise this solution using docker-compose:

```docker
docker-compose up
```

or (rather than build each container locally, use the docker library version of each container)

```docker
docker-compose -f docker-compose-from-lib.yml up
```

Test should be able to be run using a browser, and going to <http://localhost:18080>  
...and cleanup

```docker
docker-compose down
```

To run all containers that comprise this solution using minikube:

```kubectl
minikube start
kubectl create -f multiservice.k8s-deployment.yaml
```

or as part of the Cheddar release you can now test using Skaffold

```kubectl
skaffold dev
```

Test should be able to be run using a browser, and going to <http://192.168.99.100:30500>  
...and cleanup

```kubectl
kubectl delete -f multiservice.k8s-deployment.yaml
minikube stop
```

Test Edit. Ignore. 