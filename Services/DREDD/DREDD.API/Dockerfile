FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src

COPY "DREDD.APP.sln" "DREDD.APP.sln"

COPY "BuildingBlocks/EventBus/EventBus.csproj" "BuildingBlocks/EventBus/EventBus.csproj"
COPY "BuildingBlocks/EventBusRabbitMQ/EventBusRabbitMQ.csproj" "BuildingBlocks/EventBusRabbitMQ/EventBusRabbitMQ.csproj"
COPY "BuildingBlocks/IntegrationEventLogEF/IntegrationEventLogEF.csproj" "BuildingBlocks/IntegrationEventLogEF/IntegrationEventLogEF.csproj"
COPY "Services/DREDD/DREDD.API/DREDD.API.csproj" "Services/DREDD/DREDD.API/DREDD.API.csproj"
COPY "Services/DREDD/DREDD.FunctionalTests/DREDD.FunctionalTests.csproj" "Services/DREDD/DREDD.FunctionalTests/DREDD.FunctionalTests.csproj"
COPY "Services/DREDD/DREDD.UnitTests/DREDD.UnitTests.csproj" "Services/DREDD/DREDD.UnitTests/DREDD.UnitTests.csproj"

COPY "docker-compose.dcproj" "docker-compose.dcproj"

COPY "NuGet.config" "NuGet.config"

RUN dotnet restore "DREDD.APP.sln"

COPY . .
WORKDIR /src/Services/DREDD/DREDD.API
RUN dotnet publish --no-restore -c Release -o /app

FROM build as unittest
WORKDIR /src/Services/DREDD/DREDD.UnitTests

FROM build as functionaltest
WORKDIR /src/Services/DREDD/DREDD.FunctionalTests

FROM build AS publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DREDD.API.dll"]