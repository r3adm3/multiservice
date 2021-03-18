 # Sample contents of Dockerfile
 # Stage 1
 FROM mcr.microsoft.com/dotnet/sdk:5.0 AS builder
 WORKDIR /source

 # caches restore result by copying csproj file separately
 COPY *.csproj .
 RUN dotnet restore

 # copies the rest of your code
 COPY . .
 RUN find -type d -name bin -prune -exec rm -rf {} \; && find -type d -name obj -prune -exec rm -rf {} \;
 RUN dotnet publish --output /app/ --configuration Release

 # Stage 2
 FROM mcr.microsoft.com/dotnet/aspnet:5.0
 RUN apt-get update
 RUN apt-get install iputils-ping curl iproute2 dnsutils lsof net-tools -y

# Create a group and user so we are not running our container and application as root and thus user 0 which is a security issue.
RUN addgroup --system --gid 1000 customgroup \
    && adduser --system --uid 1000 --ingroup customgroup --shell /bin/sh customuser
  
# Serve on port 8080, we cannot serve on port 80 with a custom user that is not root.
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
  
# Tell docker that all future commands should run as the appuser user, must use the user number
USER 1000


 WORKDIR /app
 COPY --from=builder /app .
 ENTRYPOINT ["dotnet", "multiplyService.dll"]