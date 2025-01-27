using OpenAI.Chat;
using OpenAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace NeuralNexus.Data.Services
{
    public class AIService
    {
        public AIService(IConfiguration config) 
        {
            Endpoint = config["LLM:ConnectionString"] ?? throw new Exception("No LLM connection given");
            Model = config["LLM:Model"] ?? throw new Exception("No LLM Model given");
        }

        string Endpoint;
        string Model;
        public async Task<string> CreateMessage(string message)
        {
            var client = new OpenAIClient(new("ollama"), new() { Endpoint = new($"{Endpoint}/v1") })
                .GetChatClient(Model);

            ChatCompletion completion = await client.CompleteChatAsync(message);

            return completion.Content[0].Text;
        }
    }
}
