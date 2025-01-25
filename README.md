This repository uses the new Deepseek-r1 model
Run the docker compose
After the first deployment, you need to pull the model

```
 docker exec -it ollama ollama run deepseek-r1:7b
```
Select the model you wish, the 7 billion token model and above is advised

On localhost:3000 you can use the gui to chat with Deepseek directly.
To configure automated jobs, go to localhost:5678.
To use the OpenAi compatible Api in other services of choice, use http://localhost:11434/v1 and the api key "ollama".

This repository is not intended for public deployment and should only be used for private use.