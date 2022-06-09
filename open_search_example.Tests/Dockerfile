FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

ARG LBHPACKAGESTOKEN
ENV LBHPACKAGESTOKEN=$LBHPACKAGESTOKEN

WORKDIR /app

# Copy csproj and nuget config and restore as distinct layers
COPY ./open_search_example.sln ./
COPY ./open_search_example/open_search_example.csproj ./open_search_example/
COPY ./open_search_example.Tests/open_search_example.Tests.csproj ./open_search_example.Tests/
COPY /NuGet.Config /root/.nuget/NuGet/NuGet.Config

RUN dotnet restore ./open_search_example/open_search_example.csproj
RUN dotnet restore ./open_search_example.Tests/open_search_example.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out open_search_example.Tests/open_search_example.Tests.csproj

CMD dotnet test
