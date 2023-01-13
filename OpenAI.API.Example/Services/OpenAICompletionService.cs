using OpenAI.GPT3.Interfaces;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels.ResponseModels;

namespace OpenAI.API.Example.Services
{
    public class OpenAICompletionService : BackgroundService
    {
        readonly IOpenAIService _openAIService;

        public OpenAICompletionService(IOpenAIService openAIService)
        {
            _openAIService = openAIService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (true)
            {
                Console.Write("::");
                CompletionCreateResponse result = await _openAIService.Completions.CreateCompletion(new CompletionCreateRequest()
                {
                    Prompt = Console.ReadLine(),
                    MaxTokens = 500
                }, Models.TextDavinciV3);

                Console.WriteLine(result.Choices[0].Text);
            }
        }
    }
}
