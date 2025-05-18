# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY . .

# Entrar al proyecto del microservicio
WORKDIR /src/Module.Orders.Server

# Restaurar dependencias
RUN dotnet restore

RUN dotnet build "Module.Orders.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Module.Orders.Server.csproj" -c Release -o /app/publish /p:UseAppHost=false

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Module.Orders.Server.dll"]