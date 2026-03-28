namespace OpenRouter.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static OpenRouterClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("OPENROUTER_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("OPENROUTER_API_KEY environment variable is not found.");

        var client = new OpenRouterClient(apiKey);
        
        return client;
    }
}
