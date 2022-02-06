#!/bin/bash
app="daed.duckdns.org:50000/multiservice_addanddblsvc:halloumi-dev"
docker run -p 18084:80 \
  --name=daedtest \
  -v $PWD:/app ${app}