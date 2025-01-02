 # Sample contents of Dockerfile
 # Stage 1
 FROM mcr.microsoft.com/dotnet/nightly/sdk:9.0 AS builder
 WORKDIR /source

 # caches restore result by copying csproj file separately
 COPY *.csproj .
 RUN dotnet restore

 # copies the rest of your code
 COPY . .
 RUN find -type d -name bin -prune -exec rm -rf {} \; && find -type d -name obj -prune -exec rm -rf {} \;
 RUN dotnet publish --output /app/ --configuration Release

 # Stage 2
 FROM mcr.microsoft.com/dotnet/nightly/aspnet:9.0
 RUN apt-get update
 
# Create a group and user so we are not running our container and application as root and thus user 0 which is a security issue.
RUN adduser non-root-user
  
# Serve on port 8080, we cannot serve on port 80 with a custom user that is not root.
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
  
# Tell docker that all future commands should run as the appuser user
USER non-root-user

WORKDIR /app
COPY --from=builder /app .
ENTRYPOINT ["dotnet", "frontEnd2.dll"]