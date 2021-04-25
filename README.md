# Dominican Lotteries

STEPS :

- USING DOCKER

```sh
docker build -t lottery:latest .
docker system prune -f
docker run -dp 5000:80 --name lottery lotery:latest
google-chrome --incognito http://localhost:5000
```

- USING DOTNET CLI

```sh
dotnet clean
dotnet restore
dotnet build
dotnet run
```
