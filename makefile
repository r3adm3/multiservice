cleanup: ## cleanup local images
	docker-compose down
	docker rmi $$(docker images | grep local | tr -s ' ' | cut -d ' ' -f 3)

localImagesUpdateAndRun: ## Updates the localImages and executes
	docker-compose rm -f
	docker-compose -f docker-compose-dev.yml up 