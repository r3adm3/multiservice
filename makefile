cleanup: ## cleanup local images
	docker-compose down
	docker rmi $$(docker images | grep local | tr -s ' ' | cut -d ' ' -f 3)

localImagesUpdateAndRun: ## Updates the localImages and executes
	docker-compose rm -f
	docker-compose -f docker-compose-dev.yml up 

cleanupPrePush: ## cleanup local images
	docker-compose down
	docker rmi $$(docker images | grep info | tr -s ' ' | cut -d ' ' -f 3)

tagDevImagesandPush: ## tag up images 

	docker-compose -f docker-compose-dev.yml build --no-cache

	./scripts/tagAndPush.sh

testOnDockerK8sRemoteImages: ##Local Docker Kubernetes, from dockerpi library, Mac

	./scripts/localDockerK8sremoteImages.sh

testOnDockerK8sLocalImages: ##Local Docker Kubernetes, from local library, Mac

	./scripts/localDockerK8slocalImages.sh

testOnMinikubeK8sRemoteImages: ##Local Minikube Kubernetes, from dockerpi library, Mac

	./scripts/localMinikubeK8sremoteImages.sh

testOnKmasterMacK8sRemoteImages: ##Local Docker Kubernetes, from dockerpi library, Mac

	./scripts/localKmasterMacK8sRemoteImages.sh