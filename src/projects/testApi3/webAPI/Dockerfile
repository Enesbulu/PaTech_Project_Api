#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
#WORKDIR /app
#EXPOSE 5151
#
#ENV ASPNETCORE_URLS=http://+:5151
#
## FROM mcr.microsoft.com/dotnet/sdk:8.0-nanoserver-1809 AS build
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
#
#ARG configuration=Release
#WORKDIR /src
#COPY ["src/projects/testApi3/webAPI/webAPI.csproj", "src/projects/testApi3/webAPI/"]
#RUN dotnet restore "src/projects/testApi3/webAPI/webAPI.csproj"
#COPY . .
#WORKDIR "/src/src/projects/testApi3/webAPI"
#RUN dotnet build "webAPI.csproj" -c $configuration -o /app/build
#
#
#FROM build AS publish
#ARG configuration=Release
#RUN useradd --user-group --system --no-log-init --create-home myuser 
#RUN dotnet publish "webAPI.csproj" -c $configuration -o /app/publish /p:UseAppHost=false
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
## Kullanıcı oluştur ve çalışma ortamını ayarla
#RUN adduser --disabled-password --gecos '' appuser && chown -R myuser /app
#USER myuser
#
#ENTRYPOINT ["dotnet", "webAPI.dll"] 


## Base image
#FROM mcr.microsoft.com/dotnet/aspnet:8.0-nanoserver-1809 AS base
#WORKDIR /app
#EXPOSE 5151
#
#ENV ASPNETCORE_URLS=http://+:5151
#
## Build image
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
#
#ARG configuration=Release
#WORKDIR /src
#COPY ["src/projects/testApi3/webAPI/webAPI.csproj", "src/projects/testApi3/webAPI/"]
#RUN dotnet restore "src/projects/testApi3/webAPI/webAPI.csproj"
#COPY . .
#WORKDIR "/src/src/projects/testApi3/webAPI"
#RUN dotnet build "webAPI.csproj" -c $configuration -o /app/build
#
## Publish image
#FROM build AS publish
#ARG configuration=Release
#RUN dotnet publish "webAPI.csproj" -c $configuration -o /app/publish /p:UseAppHost=false
#
## Final image
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "webAPI.dll"]

### hata--sdk hatası
# Base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5151

ENV ASPNETCORE_URLS=http://+:5151

# Build image
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ADD https://dotnet.microsoft.com/download/dotnet/scripts/v1/dotnet-install.sh .
ARG configuration=Release
WORKDIR /source
COPY ["src/projects/testApi3/webAPI/webAPI.csproj", "src/projects/testApi3/webAPI/"]
RUN dotnet restore "src/projects/testApi3/webAPI/webAPI.csproj"
COPY . .
WORKDIR "/source/src/projects/testApi3/webAPI"
RUN dotnet build "webAPI.csproj" -c $configuration -o /app/build
# Globalization desteğini eklemek için gerekli komutlar
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

# Publish image
FROM build AS publish
ARG configuration=Release
RUN dotnet publish "webAPI.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

# Final image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "webAPI.dll"]

## Base image
#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
#WORKDIR /app
#EXPOSE 5151
#
#ENV ASPNETCORE_URLS=http://+:5151
#
## Build image
#FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
#ARG configuration=Release
#WORKDIR /src
#COPY ["src/projects/testApi3/webAPI/webAPI.csproj", "src/projects/testApi3/webAPI/"]
#RUN dotnet restore "src/projects/testApi3/webAPI/webAPI.csproj"
#COPY . .
#WORKDIR "/src/src/projects/testApi3/webAPI"
#RUN dotnet build "webAPI.csproj" -c $configuration -o /app/build
#
## Globalization desteğini eklemek için gerekli komutlar
#ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
#
## Publish image
#FROM build AS publish
#RUN dotnet publish "webAPI.csproj" -c $configuration -o /app/publish /p:UseAppHost=false
#
## Final image
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "webAPI.dll"]
