FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App


RUN apt-get update \
    && apt-get install -y --no-install-recommends \
    clang zlib1g-dev

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release --property:PublishDir=out

# Build runtime image
FROM mcr.microsoft.com/dotnet/runtime-deps:8.0-jammy-chiseled
WORKDIR /App
COPY --from=build-env /App/out .
ENTRYPOINT ["dotnet", "Timer.dll"]