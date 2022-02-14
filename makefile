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

	echo tagging $$imageVer

	docker-compose -f docker-compose-dev.yml build

	docker image tag local/multiservice_addsvc:$$imageVer daed.duckdns.org:50000/multiservice_addsvc:$$imageVer
	docker image tag local/multiservice_minussvc:$$imageVer daed.duckdns.org:50000/multiservice_minussvc:$$imageVer 		
	docker image tag local/multiservice_multiplysvc:$$imageVer daed.duckdns.org:50000/multiservice_multiplysvc:$$imageVer 
	docker image tag local/multiservice_frontend:$$imageVer daed.duckdns.org:50000/multiservice_frontend:$$imageVer
	docker image tag local/multiservice_addanddblsvc:$$imageVer daed.duckdns.org:50000/multiservice_addanddblsvc:$$imageVer

	docker push daed.duckdns.org:50000/multiservice_addsvc:$$imageVer
	docker push daed.duckdns.org:50000/multiservice_minussvc:$$imageVer
	docker push daed.duckdns.org:50000/multiservice_multiplysvc:$$imageVer
	docker push daed.duckdns.org:50000/multiservice_frontend:$$imageVer
	docker push daed.duckdns.org:50000/multiservice_addanddblsvc:$$imageVer
