FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["PortfolioAspNetCore/PortfolioAspNetCore.csproj", "PortfolioAspNetCore/"]
RUN dotnet restore "PortfolioAspNetCore/PortfolioAspNetCore.csproj"
COPY . .
WORKDIR "/src/PortfolioAspNetCore"
RUN dotnet build "PortfolioAspNetCore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PortfolioAspNetCore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PortfolioAspNetCore.dll"]