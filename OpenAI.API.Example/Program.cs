using OpenAI.API.Example;
using OpenAI.API.Example.Services;
using OpenAI.GPT3.Extensions;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddOpenAIService(settings => settings.ApiKey = "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");
        //services.AddHostedService<OpenAICompletionService>();
        services.AddHostedService<OpenAIImageService>();
    })
    .Build();

host.Run();
