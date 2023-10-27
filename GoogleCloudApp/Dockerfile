FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GoogleCloudApp/GoogleCloudApp.csproj", "GoogleCloudApp/"]
RUN dotnet restore "GoogleCloudApp/GoogleCloudApp.csproj"
COPY . .
WORKDIR "/src/GoogleCloudApp"
RUN dotnet build "GoogleCloudApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GoogleCloudApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GoogleCloudApp.dll"]
