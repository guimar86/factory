FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 8484
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Factory.csproj", "./"]
RUN dotnet restore "Factory.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Factory.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Factory.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Factory.dll"]
