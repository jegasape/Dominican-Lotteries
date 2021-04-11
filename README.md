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

- **CORE** : cd /home/$(whoami)/Dominican-Lotteries/LotteryDR/Core.cs

RESULT :

![alt text](https://user-images.githubusercontent.com/44595343/114319378-41f6a600-9adf-11eb-9914-3951f7ad4e1c.png)
