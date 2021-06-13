FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS base
WORKDIR /src
COPY *.sln .
COPY PeoplesBank/*.csproj PeoplesBank/
RUN dotnet restore PeoplesBank/*.csproj
COPY . .

#Publishing
FROM base AS publish
WORKDIR /src/PeoplesBank
RUN dotnet publish -c Release -o /src/publish

#Get the runtime into a folder called app
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=publish /src/publish .
ENTRYPOINT ["dotnet", "PeoplesBank.dll"]
