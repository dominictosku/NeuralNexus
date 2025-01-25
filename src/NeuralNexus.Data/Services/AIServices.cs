using OpenAI.Chat;
using OpenAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNexus.Data.Services
{
    public class AIService
    {
        public async Task<string> CreateMessage(string message)
        {
            var client = new OpenAIClient(new("ollama"), new() { Endpoint = new("http://localhost:11434/v1") })
                .GetChatClient("deepseek-r1:7b");

            ChatCompletion completion = await client.CompleteChatAsync(message);

            return completion.Content[0].Text;
        }
    }
}
