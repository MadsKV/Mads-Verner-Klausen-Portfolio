#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Discard/Discard.csproj", "Discard/"]
RUN dotnet restore "Discard/Discard.csproj"
COPY . .
WORKDIR "/src/Discard"
RUN dotnet build "Discard.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Discard.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Discard.dll", "http://localhost:8080"]