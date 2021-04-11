FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /LotteryDR

COPY ./LotteryDR/LotteryDR.csproj ./
RUN dotnet clean && dotnet restore

COPY . ./
RUN dotnet publish Lottery.sln -c Release -o Output

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /LotteryDR
COPY --from=build-env /LotteryDR/Output .
ENTRYPOINT ["dotnet", "LotteryDR.dll"]
