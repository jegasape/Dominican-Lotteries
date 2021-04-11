# Dominican Lotteries

STEPS: 

docker build -t lottery:latest .

docker run -d -p 5000:80 --name lottery lottery:latest

google-chrome --incognito http://localhost:5000

