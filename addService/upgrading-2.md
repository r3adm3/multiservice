# Upgrading part 2

1. change csproj to .net 6.0

```
dotnet run
```

2. update dependency versions to latest 

```
dotnet run
```

3. Change dockerfile for new 

```
docker image build -t local/addservice:infossato-dev .
```

4. run the dockerfile 

```
docker container run --name test_addservice -p 8080:8080 local/addservice:infossato-dev
```

5. test the docker container returns expected

```
curl http://localhost:8080/api/add\?a=1\&b=2 

result:
{"mathresult":3,"dotnetver":".NET   6.0.1","hostname":"20e05fc386b3"}
```
6. (make localImagesUpdateAndRun) /docker-compose.yml to point to local addservice

docker-compose up

7. check it

http://localhost:18080

8. Clean up

docker-compose down
make cleanup