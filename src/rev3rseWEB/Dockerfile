#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["rev3rseWEB/rev3rseWEB.csproj", "rev3rseWEB/"]
RUN dotnet restore "rev3rseWEB/rev3rseWEB.csproj"
COPY . .
WORKDIR "/src/rev3rseWEB"
RUN dotnet build "rev3rseWEB.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "rev3rseWEB.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "rev3rseWEB.dll"]