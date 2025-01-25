using OpenAI;
using OpenAI.Chat;
using System.Net;

var client = new OpenAIClient(new("ollama"), new() { Endpoint = new("http://localhost:11434/v1") })
    .GetChatClient("deepseek-r1:7b");

ChatCompletion completion = client.CompleteChat("How do i cook spaghetti?");

Console.WriteLine($"[ASSISTANT]: {completion.Content[0].Text}");