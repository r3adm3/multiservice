# MultiService (docker service example)

This service is a demonstration of moving from a monolithic code base to a more microservices based architecture.

This is paired up with the repo: <http://github.com/r3adm3/monolithsvc>

## Compiling in Development

Should work on Windows and Macs (possibly Linux, not tried it yet)
Clone the repo.

Dependencies:-
Docker CE | 4.23.0 (120376) 
VirtualBox | 6.1.32 r149290 *
Minikube | 1.25.1 * 
Dotnet SDK 9.0 | 9.0.101
Python 3 | 3.12.0
Helm | 3.7.1 * 

Any of the component microservices can be tested and run individually with a simple by cd'ing into its directory. Check the Readme.md for details on runtime, compile and docker build instructions

To build and run all containers that comprise this solution using docker-compose:

```docker
docker compose up --no-deps --build
```

Test should be able to be run using a browser, and going to <http://localhost:18080>  

...and cleanup

```docker
docker compose rm -f  
```

To run all containers that comprise this solution using minikube:

```kubectl
minikube start
helm install multiservice ./helmCharts -f ./helmCharts/Dev.yaml
```

Test should be able to be run using a browser, and going to <http://192.168.99.100:30500>  
...and cleanup

```kubectl
helm uninstall multiservice
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
| kashkaval-dev | docker-compose -f docker-compose-dev-from-lib.yml up | docker desktop - mac |  | 
| kashkaval-dev | docker-compose -f docker-compose-dev.yml up --build | docker desktop - mac |  | 
| kashkaval-dev | docker-compose -f docker-compose-dev-from-lib.yml up | docker toolbox - win |  | 
| kashkaval-dev | docker-compose -f docker-compose-dev.yml up --build | docker toolbox - win |  | 
| kashkaval-dev | helm install multiservice ./helmCharts -f ./helmCharts/Dev.yaml | docker desktop / k8s - mac |  | 
| kashkaval-dev | helm install multiservice ./helmCharts -f ./helmCharts/Dev-OnPrem.yaml | docker desktop / k8s - mac |  | 
| kashkaval-dev | helm install multiservice ./helmCharts -f ./helmCharts/Dev-OnPrem.yaml | minikube - mac |  | 
| kashkaval-dev | helm install multiservice ./helmCharts -f ./helmCharts/Dev-OnPrem.yaml | kmaster - mac |  | 
| kashkaval-dev | helm install multiservice ./helmCharts -f ./helmCharts/Dev-OnPrem.yaml | virtualbox / minikube - win |  | 
| kashkaval-dev | helm install multiservice ./helmCharts -f ./helmCharts/Dev-OnPrem.yaml | virtualbox / kmaster - win |  | 
| kashkaval-dev | helm install multiservice ./helmCharts -f ./helmCharts/Prod-Cloud.yaml | k8s - AKS |  | 
| kashkaval-dev | helm install multiservice ./helmCharts -f ./helmCharts/Prod-Cloud.yaml  | k8s - GKE |  | 
  
&ast; whilst running under windows, the microservices run. Put in port forwards to the docker virtualbox for TCP 127.0.0.1:18080 - 18084 (or 30500 for kmaster), and then it'll work.

Previous release:-
| infossato | docker-compose -f docker-compose-dev-from-lib.yml up | docker desktop - mac | success | 2022-02-19
| infossato | docker-compose -f docker-compose-dev.yml up --build | docker desktop - mac | success | 2022-02-19
| infossato | docker-compose -f docker-compose-dev-from-lib.yml up | docker toolbox - win | success | 2022-02-21
| infossato | docker-compose -f docker-compose-dev.yml up --build | docker toolbox - win | success | 2022-02-21
| infossato | helm install multiservice ./helmCharts -f ./helmCharts/Dev.yaml | docker desktop / k8s - mac | success | 2022-02-19
| infossato | helm install multiservice ./helmCharts -f ./helmCharts/Dev-OnPrem.yaml | docker desktop / k8s - mac | success | 2022-02-19
| infossato | helm install multiservice ./helmCharts -f ./helmCharts/Dev-OnPrem.yaml | minikube - mac | success | 2022-02-19
| infossato | helm install multiservice ./helmCharts -f ./helmCharts/Dev-OnPrem.yaml | kmaster - mac | success | 2022-02-19
| infossato | helm install multiservice ./helmCharts -f ./helmCharts/Dev-OnPrem.yaml | virtualbox / minikube - win | success | 2022-02-21 
| infossato | helm install multiservice ./helmCharts -f ./helmCharts/Dev-OnPrem.yaml | virtualbox / kmaster - win | success | 2022-02-19
| infossato | helm install multiservice ./helmCharts -f ./helmCharts/Prod-Cloud.yaml | k8s - AKS | success | 2022-02-21
| infossato | helm install multiservice ./helmCharts -f ./helmCharts/Prod-Cloud.yaml  | k8s - GKE | success | 2022-02-21 

 *ver: kashkaval-dev*