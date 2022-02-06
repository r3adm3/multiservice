#!/bin/bash
app="daed.duckdns.org:50000/multiservice_addanddblsvc:halloumi-dev"
docker build -t ${app} --no-cache .
#docker push ${app}
#docker run -p 56733:80 \
#  --name=daedtest \
 # -v $PWD:/app ${app}