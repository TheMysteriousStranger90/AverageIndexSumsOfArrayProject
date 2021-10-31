FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["AverageIndexSumsOfArrayProject/AverageIndexSumsOfArrayProject.csproj", "AverageIndexSumsOfArrayProject/"]
RUN dotnet restore "AverageIndexSumsOfArrayProject/AverageIndexSumsOfArrayProject.csproj"
COPY . .
WORKDIR "/src/AverageIndexSumsOfArrayProject"
RUN dotnet build "AverageIndexSumsOfArrayProject.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AverageIndexSumsOfArrayProject.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AverageIndexSumsOfArrayProject.dll"]
