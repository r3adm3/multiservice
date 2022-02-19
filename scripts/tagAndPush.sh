echo tagging ::$imageVer::

echo "Enter to continue (ctrl-c to exit)? "
read answer

docker image tag local/multiservice_addsvc:$imageVer daed.duckdns.org:50000/multiservice_addsvc:$imageVer
docker image tag local/multiservice_minussvc:$imageVer daed.duckdns.org:50000/multiservice_minussvc:$imageVer 		
docker image tag local/multiservice_multiplysvc:$imageVer daed.duckdns.org:50000/multiservice_multiplysvc:$imageVer 
docker image tag local/multiservice_frontend:$imageVer daed.duckdns.org:50000/multiservice_frontend:$imageVer
docker image tag local/multiservice_addanddblsvc:$imageVer daed.duckdns.org:50000/multiservice_addanddblsvc:$imageVer

docker push daed.duckdns.org:50000/multiservice_addsvc:$imageVer
docker push daed.duckdns.org:50000/multiservice_minussvc:$imageVer
docker push daed.duckdns.org:50000/multiservice_multiplysvc:$imageVer
docker push daed.duckdns.org:50000/multiservice_frontend:$imageVer
docker push daed.duckdns.org:50000/multiservice_addanddblsvc:$imageVer

echo Finished.