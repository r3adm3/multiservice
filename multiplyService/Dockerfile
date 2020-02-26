 # Sample contents of Dockerfile
 # Stage 1
 FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS builder
 WORKDIR /source

 # caches restore result by copying csproj file separately
 COPY *.csproj .
 RUN dotnet restore

 # copies the rest of your code
 COPY . .
 RUN dotnet publish --output /app/ --configuration Release

 # Stage 2
 FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
 RUN apt-get update
 RUN apt-get install iputils-ping curl iproute2 dnsutils lsof net-tools -y
 WORKDIR /app
 COPY --from=builder /app .
 ENTRYPOINT ["dotnet", "multiplyService.dll"]