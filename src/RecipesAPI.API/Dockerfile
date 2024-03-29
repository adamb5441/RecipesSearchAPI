#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 5000
EXPOSE 3000

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["src/RecipesAPI.API/RecipesAPI.API.csproj", "src/RecipesAPI.API/"]
COPY ["src/RecipesAPI.Application/RecipesAPI.Application.csproj", "src/RecipesAPI.Application/"]
COPY ["src/RecipesAPI.Domain/RecipesAPI.Domain.csproj", "src/RecipesAPI.Domain/"]
COPY ["src/RecipesAPI.Infrastructure/RecipesAPI.Infrastructure.csproj", "src/RecipesAPI.Infrastructure/"]
COPY ["src/RecipesAPI.Test/RecipesAPI.Test.csproj", "src/RecipesAPI.Test/"]
RUN dotnet restore "src/RecipesAPI.API/RecipesAPI.API.csproj"
COPY . .
WORKDIR "/src/src/RecipesAPI.API"
RUN dotnet build "RecipesAPI.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RecipesAPI.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RecipesAPI.API.dll"]