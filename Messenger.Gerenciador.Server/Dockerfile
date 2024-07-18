FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Messenger.Gerenciador.Server/Messenger.Gerenciador.Server.csproj", "Messenger.Gerenciador.Server/"]
RUN dotnet restore "Messenger.Gerenciador.Server/Messenger.Gerenciador.Server.csproj"
COPY . .
WORKDIR "/src/Messenger.Gerenciador.Server"
RUN dotnet build "Messenger.Gerenciador.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Messenger.Gerenciador.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Messenger.Gerenciador.Server.dll"]
