
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class OpenRouterClient : global::OpenRouter.IOpenRouterClient, global::System.IDisposable
    {
        /// <summary>
        /// Production server
        /// </summary>
        public const string DefaultBaseUrl = "https://openrouter.ai/api/v1";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::OpenRouter.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::OpenRouter.AutoSDKClientOptions Options { get; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::OpenRouter.SourceGenerationContext.Default;


        /// <summary>
        /// 
        /// </summary>
        public AnalyticsClient Analytics => new AnalyticsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnthropicMessagesClient AnthropicMessages => new AnthropicMessagesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ApiKeysClient ApiKeys => new ApiKeysClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public BenchmarksClient Benchmarks => new BenchmarksClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public BetaAnalyticsClient BetaAnalytics => new BetaAnalyticsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public BetaResponsesClient BetaResponses => new BetaResponsesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ByokClient Byok => new ByokClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat => new ChatClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ClassificationsClient Classifications => new ClassificationsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public CreditsClient Credits => new CreditsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public EndpointsClient Endpoints => new EndpointsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public GenerationsClient Generations => new GenerationsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public GuardrailsClient Guardrails => new GuardrailsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ImagesClient Images => new ImagesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public OAuthClient OAuth => new OAuthClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityClient Observability => new ObservabilityClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public OrganizationClient Organization => new OrganizationClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public PresetsClient Presets => new PresetsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProvidersClient Providers => new ProvidersClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public RerankClient Rerank => new RerankClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public SttClient Stt => new SttClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public TtsClient Tts => new TtsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public VideoGenerationClient VideoGeneration => new VideoGenerationClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public WorkspacesClient Workspaces => new WorkspacesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Creates a new instance of the OpenRouterClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public OpenRouterClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::OpenRouter.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the OpenRouterClient with explicit options but no base URL override.
        /// Skips passing <c>baseUri</c> so the default base URL from the OpenAPI spec applies.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public OpenRouterClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Collections.Generic.List<global::OpenRouter.EndPointAuthorization>? authorizations,
            global::OpenRouter.AutoSDKClientOptions? options,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri: null,
                authorizations,
                options,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the OpenRouterClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public OpenRouterClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Uri? baseUri,
            global::System.Collections.Generic.List<global::OpenRouter.EndPointAuthorization>? authorizations,
            global::OpenRouter.AutoSDKClientOptions? options,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::OpenRouter.EndPointAuthorization>();
            Options = options ?? new global::OpenRouter.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}