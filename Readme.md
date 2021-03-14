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
Dotnet SDK 3.1 and 5.0

Any of the component microservices can be tested and run individually with a simple by cd'ing into its directory. Check the Readme.md for details on runtime, compile and docker build instructions

To build and run all containers that comprise this solution using docker-compose:

```docker
docker-compose up --build
```

or (rather than build each container locally, use the docker container version of each container)

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

| environment | env | tested | Date
| ----------- | ----------- | ----------- | ----------- |
| kubectl apply -f multiservice.k8s-deployment.yaml | docker desktop / k8s | success | 2021-03-14
| docker-compose -f docker-compose-from-lib.yml | docker desktop / k8s | success | 2021-03-14
