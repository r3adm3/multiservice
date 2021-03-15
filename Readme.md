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

## Status

| service | CI tested | Docker Reg Upload |
| ----------- | ----------- | ----------- |
| frontend |[![Build status](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_apis/build/status/multiservice/frontend/compile%20%26%20test%20(frontend%20only))](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_build/latest?definitionId=22)| [![Build status](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_apis/build/status/multiservice/frontend/docker%20build%20(frontEnd%20only))](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_build/latest?definitionId=19) | [![Build status](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_apis/build/status/multiservice/frontend/docker%20build%20(frontEnd%20only))](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_build/latest?definitionId=19)
| addservice |[![Build status](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_apis/build/status/multiservice/addservice/compile%20%26%20test%20(add%20only))](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_build/latest?definitionId=15)| [![Build status](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_apis/build/status/multiservice/addservice/docker%20build%20(add%20only))](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_build/latest?definitionId=16)
| minusservice |[![Build status](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_apis/build/status/multiservice/minusservice/compile%20%26%20test%20(minus%20only))](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_build/latest?definitionId=20)| [![Build status](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_apis/build/status/multiservice/minusservice/docker%20build%20(minus%20only))](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_build/latest?definitionId=17)
| multiplyservice |[![Build status](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_apis/build/status/multiservice/multiplyservice/compile%20%26%20test%20(multiply%20only))](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_build/latest?definitionId=21) | [![Build status](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_apis/build/status/multiservice/multiplyservice/docker%20build%20(multiply%20only))](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_build/latest?definitionId=18) |  

---  

| release | environment | env | tested | Date
| ----------- | ----------- | ----------- | ----------- | ----------- |
| Fontal | docker-compose -f docker-compose-from-lib.yml up | docker desktop - mac | success | 2021-03-14
| Fontal | docker-compose -f docker-compose.yml up | docker desktop - mac | success | 2021-03-14
| Fontal | docker-compose -f docker-compose-from-lib.yml up | docker toolbox - win | success * | 2021-03-15
| Fontal | docker-compose -f docker-compose.yml up | docker toolbox - win | success * | 2021-03-15
| Fontal | kubectl apply -f multiservice.k8s-deployment.yaml | docker desktop / k8s - mac | success | 2021-03-14
| Fontal | kubectl apply -f multiservice.k8s-deployment.yaml | minikube - mac | success | 2021-03-14
| Fontal | kubectl apply -f multiservice.k8s-deployment.yaml | kmaster - mac | success | 2021-03-15
| Fontal | kubectl apply -f multiservice.k8s-deployment.yaml | virtualbox / minikube - win | success | 2021-03-14
| Fontal | kubectl apply -f multiservice.k8s-deployment.yaml | virtualbox / kmaster - win | success * | 2021-03-15
| Fontal | kubectl apply -f multiservice.k8s-deployment.prod.yaml | k8s - AKS | success | 2021-03-15
| Fontal | kubectl apply -f multiservice.k8s-deployment.prod.yaml | k8s - GKE | success | 2021-03-15 |  
  
&ast; whilst running under windows, the microservices run. Put in port forwards to the docker virtualbox for TCP 127.0.0.1:18080 - 18083 (or 30500 for kmaster), and then it'll work.
