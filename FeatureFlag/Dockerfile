FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /app

COPY ./FeatureFlag/*.csproj ./FeatureFlag/

COPY *.sln .

RUN dotnet restore ./FeatureFlag/*.csproj

COPY . .

RUN dotnet publish -c release ./FeatureFlag/*.csproj -o /publish/


FROM base AS final

WORKDIR /app

COPY --from=build /publish .


ENTRYPOINT [ "dotnet","FeatureFlag.dll" ]