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
#WORKDIR /bin/bash as start
## Kullanıcı oluştur
#RUN useradd -ms /bin/bash myuser
## Kullanıcının parolasını ayarla (isteğe bağlı)
#RUN echo 'myuser:mypassword' | chpasswd
## Kullanıcının çalışma dizinini belirle (isteğe bağlı)
#WORKDIR /home/myuser
## Base image
#FROM start AS base
#WORKDIR /app
#EXPOSE 5151
#
#ENV ASPNETCORE_URLS=http://+:5151
#
## Build image
##FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
#FROM mcr.microsoft.com/dotnet/sdk:8.0-nanoserver-1809 AS build
#RUN addgroup my-group && adduser -D my-user -G my-group
#ADD https://dotnet.microsoft.com/download/dotnet/scripts/v1/dotnet-install.sh .
#ARG configuration=Release
#WORKDIR /source
#COPY ["src/projects/testApi3/webAPI/webAPI.csproj", "src/projects/testApi3/webAPI/"]
#RUN dotnet restore "src/projects/testApi3/webAPI/webAPI.csproj"
#COPY . .
#WORKDIR "/source/src/projects/testApi3/webAPI"
#RUN dotnet build "./webAPI.csproj" -c $configuration -o /app/build
## Globalization desteğini eklemek için gerekli komutlar
#ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
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

## Base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5151

ENV ASPNETCORE_URLS=http://+:5151

# Build image
FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
ARG configuration=Release
WORKDIR /src
COPY ["src/projects/testApi3/webAPI/webAPI.csproj", "src/projects/testApi3/webAPI/"]
RUN dotnet restore "src/projects/testApi3/webAPI/webAPI.csproj"
COPY . .
WORKDIR "/src/src/projects/testApi3/webAPI"
RUN dotnet build "webAPI.csproj" -c $configuration -o /app/build

# Globalization desteğini eklemek için gerekli komutlar
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

# Publish image
FROM build AS publish
RUN dotnet publish "webAPI.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

# Final image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "webAPI.dll"]



#çalışan başka bir dockerfile örneği
#FROM mcr.microsoft.com/dotnet/aspnet:8.0-nanoserver-1809 AS base
#WORKDIR /app
#EXPOSE 8080
#EXPOSE 8081
#
#FROM mcr.microsoft.com/dotnet/sdk:8.0-nanoserver-1809 AS build
#ARG BUILD_CONFIGURATION=Release
#WORKDIR /src
#COPY ["src/projects/testApi3/webAPI/webAPI.csproj", "src/projects/testApi3/webAPI/"]
#RUN dotnet restore "src/projects/testApi3/webAPI/webAPI.csproj"
#COPY . .
#WORKDIR "/source/src/projects/testApi3/webAPI"
#RUN dotnet build "./webAPI.csproj" -c $configuration -o /app/build
#
#FROM build AS publish
#ARG BUILD_CONFIGURATION=Release
#RUN dotnet publish "./webAPI.csproj" -c %BUILD_CONFIGURATION% -o /app/publish /p:UseAppHost=false
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "webAPI.dll"]


## Base image
#FROM mcr.microsoft.com/dotnet/sdk:8.0-nanoserver-1809 AS base
#WORKDIR /app
#EXPOSE 5151
#
#ENV ASPNETCORE_URLS=http://+:5151
#
## Kullanıcı oluştur
#RUN addgroup my-group && adduser -D my-user -G my-group
#
## Build image
#ARG configuration=Release
#WORKDIR /source
#COPY ["src/projects/testApi3/webAPI/webAPI.csproj", "src/projects/testApi3/webAPI/"]
#RUN dotnet restore "src/projects/testApi3/webAPI/webAPI.csproj"
#COPY . .
#WORKDIR "/source/src/projects/testApi3/webAPI"
#RUN dotnet build "./webAPI.csproj" -c $configuration -o /app/build
#
## Globalization desteğini eklemek için gerekli komutlar
#ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
#
## Publish image
#FROM base AS publish
#RUN dotnet publish "webAPI.csproj" -c $configuration -o /app/publish /p:UseAppHost=false
#
## Final image
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "webAPI.dll"]
#