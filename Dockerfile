FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS build-env
WORKDIR /App

COPY ./Src/ ./
RUN dotnet restore

RUN dotnet publish -c Release -o Built

FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine

WORKDIR /App
COPY --from=build-env /App/Built .

ENTRYPOINT ["dotnet", "YaRemoteTv.Api.dll", "--no-launch-profile"]
