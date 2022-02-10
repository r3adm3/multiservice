#!/bin/bash
app="daed.duckdns.org:50000/multiservice_addanddblsvc:halloumi-dev"
docker run -p 18085:80 \
  --name=daeddev \
  -v $PWD:/app ${app}