using System.Net;
using System.Text;

namespace OpenRouter.IntegrationTests;

[TestClass]
public class RoutingTests
{
    [TestMethod]
    [DataRow(false, false)]
    [DataRow(true, false)]
    [DataRow(false, true)]
    public async Task InheritedServerRouting(bool overrideInConstructor, bool overrideOnHttpClient)
    {
        var proxy = new Uri("https://proxy.example/sdk/");
        var useProxy = overrideInConstructor || overrideOnHttpClient;
        var expectedUrl = (useProxy ? "https://proxy.example/sdk" : "https://openrouter.ai/api/v1") + "/credits";
        using var handler = new RecordingHandler();
        using var http = new HttpClient(handler);
        if (overrideOnHttpClient)
        {
            http.BaseAddress = proxy;
        }
        using var client = new OpenRouterClient("test-key", httpClient: http,
            baseUri: overrideInConstructor ? proxy : null);
        Func<Task> call = () => client.Credits.GetCreditsAsync();

        // Reuse the root and tag clients; resolving defaults must not mutate shared state.
        await call.Should().ThrowAsync<ApiException>();
        await call.Should().ThrowAsync<ApiException>();
        handler.Paths.Should().Equal(expectedUrl, expectedUrl);
        http.BaseAddress.Should().Be(useProxy ? proxy : null);
    }

    private sealed class RecordingHandler : HttpMessageHandler
    {
        public List<string> Paths { get; } = [];

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Paths.Add(request.RequestUri!.GetLeftPart(UriPartial.Path));
            // An unmodelled status exercises the common error path without a provider call.
            return Task.FromResult(new HttpResponseMessage((HttpStatusCode)599)
            {
                Content = new StringContent("{}", Encoding.UTF8, "application/json"),
            });
        }
    }
}
