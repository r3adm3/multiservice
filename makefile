localImagesUpdateAndRun: ## Updates the localImages and executes
	docker-compose rm -f
	docker-compose -f docker-compose-dev.yml up 