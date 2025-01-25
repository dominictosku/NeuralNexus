using NeuralNexus.Data.Services;

var aiService = new AIService();
var message = await aiService.CreateMessage("How do i cook spaghetti?");
Console.WriteLine($"[ASSISTANT]: {message}");