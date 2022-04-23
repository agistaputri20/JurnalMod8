#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["modul8_NIM/modul8_NIM.csproj", "modul8_NIM/"]
RUN dotnet restore "modul8_NIM/modul8_NIM.csproj"
COPY . .
WORKDIR "/src/modul8_NIM"
RUN dotnet build "modul8_NIM.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "modul8_NIM.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "modul8_NIM.dll"]