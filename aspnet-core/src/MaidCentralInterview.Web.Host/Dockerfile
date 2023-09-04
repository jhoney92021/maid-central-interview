FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/MaidCentralInterview.Web.Host/MaidCentralInterview.Web.Host.csproj", "src/MaidCentralInterview.Web.Host/"]
COPY ["src/MaidCentralInterview.Web.Core/MaidCentralInterview.Web.Core.csproj", "src/MaidCentralInterview.Web.Core/"]
COPY ["src/MaidCentralInterview.Application/MaidCentralInterview.Application.csproj", "src/MaidCentralInterview.Application/"]
COPY ["src/MaidCentralInterview.Core/MaidCentralInterview.Core.csproj", "src/MaidCentralInterview.Core/"]
COPY ["src/MaidCentralInterview.EntityFrameworkCore/MaidCentralInterview.EntityFrameworkCore.csproj", "src/MaidCentralInterview.EntityFrameworkCore/"]
WORKDIR "/src/src/MaidCentralInterview.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/MaidCentralInterview.Web.Host", "src/MaidCentralInterview.Web.Host"]
COPY ["src/MaidCentralInterview.Web.Core", "src/MaidCentralInterview.Web.Core"]
COPY ["src/MaidCentralInterview.Application", "src/MaidCentralInterview.Application"]
COPY ["src/MaidCentralInterview.Core", "src/MaidCentralInterview.Core"]
COPY ["src/MaidCentralInterview.EntityFrameworkCore", "src/MaidCentralInterview.EntityFrameworkCore"]
WORKDIR "/src/src/MaidCentralInterview.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "MaidCentralInterview.Web.Host.dll"]
