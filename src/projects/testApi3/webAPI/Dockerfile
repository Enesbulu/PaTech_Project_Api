FROM mcr.microsoft.com/dotnet/aspnet:8.0-nanoserver-1809 AS base
WORKDIR /app
EXPOSE 5151

ENV ASPNETCORE_URLS=http://+:5151

FROM mcr.microsoft.com/dotnet/sdk:8.0-nanoserver-1809 AS build
ARG configuration=Release
WORKDIR /src
COPY ["src/projects/testApi3/webAPI/webAPI.csproj", "src/"]
# RUN dotnet restore "src\projects\testApi3\webAPI\webAPI.csproj"
# COPY . .
# WORKDIR "/src/src/projects/testApi3/webAPI"
# Burada container içerisine kopyalanacak proje yapılarının yolu belirtilir
# COPY ["src/corePackages", "src/projects/testApi3/webAPI/"]
RUN dotnet restore "src/projects/testApi3/webAPI/webAPI.csproj"
COPY . .
WORKDIR "/src/src/projects/testApi3/webAPI"
RUN dotnet build "webAPI.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "webAPI.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "webAPI.dll"] 
