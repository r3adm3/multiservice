#!/bin/bash
app="daed.duckdns.org:50000/addanddblservice:halloumi-dev"
docker run -p 56733:80 \
  --name=daedtest \
  -v $PWD:/app ${app}