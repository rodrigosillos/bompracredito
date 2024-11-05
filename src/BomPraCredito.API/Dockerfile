# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app
COPY . .
RUN dotnet restore "src/BomPraCredito.API/BomPraCredito.API.csproj"
RUN dotnet publish "src/BomPraCredito.API/BomPraCredito.API.csproj" -c Release -o /out

# Etapa para o ambiente de execução
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /out .
ENTRYPOINT ["dotnet", "BomPraCredito.API.dll"]
