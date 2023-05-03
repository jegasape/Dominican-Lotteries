# Dominican Lotteries

```sh
docker build -t lottery:latest .
docker run -dp 5000:80 --name lottery lottery:latest
google-chrome --incognito http://localhost:5000
```
