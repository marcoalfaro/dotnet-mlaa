
FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "dotnet.dll"]


# old autogenerated dockerfile

##See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
#
#FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
#WORKDIR /src
#COPY ["dotnet.csproj", "dotnet/"]
##COPY ["dotnet/dotnet.csproj", "dotnet/"]
##COPY *.csproj ./
#RUN dotnet restore "dotnet/dotnet.csproj"
##RUN dotnet restore "dotnet.csproj"
#COPY . .
#WORKDIR "/src/dotnet"
#RUN dotnet build "dotnet.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "dotnet.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "dotnet.dll"]