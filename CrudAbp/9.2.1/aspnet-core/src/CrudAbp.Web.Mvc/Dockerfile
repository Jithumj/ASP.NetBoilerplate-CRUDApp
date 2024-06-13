FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/CrudAbp.Web.Mvc/CrudAbp.Web.Mvc.csproj", "src/CrudAbp.Web.Mvc/"]
COPY ["src/CrudAbp.Web.Core/CrudAbp.Web.Core.csproj", "src/CrudAbp.Web.Core/"]
COPY ["src/CrudAbp.Application/CrudAbp.Application.csproj", "src/CrudAbp.Application/"]
COPY ["src/CrudAbp.Core/CrudAbp.Core.csproj", "src/CrudAbp.Core/"]
COPY ["src/CrudAbp.EntityFrameworkCore/CrudAbp.EntityFrameworkCore.csproj", "src/CrudAbp.EntityFrameworkCore/"]
WORKDIR "/src/src/CrudAbp.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/CrudAbp.Web.Mvc", "src/CrudAbp.Web.Mvc"]
COPY ["src/CrudAbp.Web.Core", "src/CrudAbp.Web.Core"]
COPY ["src/CrudAbp.Application", "src/CrudAbp.Application"]
COPY ["src/CrudAbp.Core", "src/CrudAbp.Core"]
COPY ["src/CrudAbp.EntityFrameworkCore", "src/CrudAbp.EntityFrameworkCore"]
WORKDIR "/src/src/CrudAbp.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "CrudAbp.Web.Mvc.dll"]
