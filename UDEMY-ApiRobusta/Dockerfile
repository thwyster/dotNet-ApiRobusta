FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["UDEMY-ApiRobusta/UDEMY-ApiRobusta.csproj", "UDEMY-ApiRobusta/"]
RUN dotnet restore "UDEMY-ApiRobusta/UDEMY-ApiRobusta.csproj"
COPY . .
WORKDIR "/src/UDEMY-ApiRobusta"
RUN dotnet build "UDEMY-ApiRobusta.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "UDEMY-ApiRobusta.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "UDEMY-ApiRobusta.dll"]