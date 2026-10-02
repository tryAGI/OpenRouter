
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenAI-compatible API with additional OpenRouter features<br/>
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
        public System.Uri? BaseUri => ResolveDisplayedBaseUri();

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::OpenRouter.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::OpenRouter.AutoSDKClientOptions Options { get; }


        /// <inheritdoc/>
        public global::System.Func<string> CreateIdempotencyKey { get; set; } = () => global::System.Guid.NewGuid().ToString("D");


        internal global::OpenRouter.AutoSDKServerConfiguration AutoSDKServerConfiguration { get; set; } = new global::OpenRouter.AutoSDKServerConfiguration();

        internal global::System.Lazy<global::System.Text.Json.Serialization.JsonSerializerContext> JsonSerializerContextProvider { get; set; } = new(() => global::OpenRouter.SourceGenerationContext.Default);

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext
        {
            get => JsonSerializerContextProvider.Value;
            set => JsonSerializerContextProvider = new(() => value);
        }


        /// <summary>
        /// Alpha feature endpoints for Decisions requests.
        /// </summary>
        public AlphaDecisionsClient AlphaDecisions => new AlphaDecisionsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Analytics and usage endpoints.
        /// </summary>
        public AnalyticsClient Analytics => new AnalyticsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// API key management endpoints.
        /// </summary>
        public ApiKeysClient ApiKeys => new ApiKeysClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Submit, list, poll, and delete asynchronous batches of inference requests. See https://openrouter.ai/docs/batch-quickstart.
        /// </summary>
        public BatchClient Batch => new BatchClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Benchmarks endpoints.
        /// </summary>
        public BenchmarksClient Benchmarks => new BenchmarksClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// BYOK endpoints.
        /// </summary>
        public ByokClient Byok => new ByokClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public ChatClient Chat => new ChatClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Task classification market-share endpoints.
        /// </summary>
        public ClassificationsClient Classifications => new ClassificationsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Containers endpoints.
        /// </summary>
        public ContainersClient Containers => new ContainersClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Credit management endpoints.
        /// </summary>
        public CreditsClient Credits => new CreditsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Public OpenRouter usage datasets. Data returned by these endpoints is licensed under CC BY 4.0 (https://creativecommons.org/licenses/by/4.0/): reuse and republish it, including commercially, with attribution to OpenRouter.
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Text embedding endpoints.
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// End Users endpoints.
        /// </summary>
        public EndUsersClient EndUsers => new EndUsersClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Endpoint information.
        /// </summary>
        public EndpointsClient Endpoints => new EndpointsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Files endpoints.
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Generation history endpoints.
        /// </summary>
        public GenerationsClient Generations => new GenerationsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Guardrails endpoints.
        /// </summary>
        public GuardrailsClient Guardrails => new GuardrailsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Images endpoints.
        /// </summary>
        public ImagesClient Images => new ImagesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Create, inspect, update, provision, suspend and delete OpenRouter interns through an API key, and talk to them: the chat route streams OpenAI-compatible completions from one intern, pausing as an `openrouter.provide_input` tool call when the intern needs your permission or an answer. Available to interns programme members; other callers receive 404. See https://openrouter.ai/docs/guides/ori/intern-chat.
        /// </summary>
        public InternsClient Interns => new InternsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public Interns2Client Interns2 => new Interns2Client(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Model information endpoints.
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// OAuth authentication endpoints.
        /// </summary>
        public OAuthClient OAuth => new OAuthClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Observability endpoints.
        /// </summary>
        public ObservabilityClient Observability => new ObservabilityClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Organization endpoints.
        /// </summary>
        public OrganizationClient Organization => new OrganizationClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Presets endpoints.
        /// </summary>
        public PresetsClient Presets => new PresetsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Private Endpoints endpoints.
        /// </summary>
        public PrivateEndpointsClient PrivateEndpoints => new PrivateEndpointsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Provider information endpoints.
        /// </summary>
        public ProvidersClient Providers => new ProvidersClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Rerank endpoints.
        /// </summary>
        public RerankClient Rerank => new RerankClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// OpenAI-compatible Responses API endpoints.
        /// </summary>
        public ResponsesClient Responses => new ResponsesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Management endpoints for SCIM group-to-workspace mappings, authenticated with a management key. These are not the SCIM 2.0 connector endpoints for your identity provider. In your identity provider, enter the SCIM endpoint URL shown when you enable provisioning under Settings &gt; Members &gt; SCIM Mappings. See https://openrouter.ai/docs/guides/features/scim-mappings#set-up-provisioning.
        /// </summary>
        public ScimClient Scim => new ScimClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Transcriptions. Speech-to-text endpoints.
        /// </summary>
        public SttClient Stt => new SttClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// System One. System One endpoints for models such as Jev, compatible with the TypeSafe SDKs. See https://openrouter.ai/docs/guides/community/typesafe-sdk.
        /// </summary>
        public SystemOneClient SystemOne => new SystemOneClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// The catalog of server tools OpenRouter runs on behalf of a model: accepted `tools[].type` spellings per API format, engines and pricing, and which endpoints run each tool natively. See https://openrouter.ai/docs/guides/features/server-tools.
        /// </summary>
        public ToolsClient Tools => new ToolsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Speech. Text-to-speech endpoints.
        /// </summary>
        public TtsClient Tts => new TtsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Store host-bound secrets for a workspace or for one intern. Scope is selected by the API key. Responses return metadata only, never secret values. See https://openrouter.ai/docs/guides/ori/vault.
        /// </summary>
        public VaultClient Vault => new VaultClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Video Generation endpoints.
        /// </summary>
        public VideoGenerationClient VideoGeneration => new VideoGenerationClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Workspaces endpoints.
        /// </summary>
        public WorkspacesClient Workspaces => new WorkspacesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };


        private static readonly global::OpenRouter.AutoSDKServer[] s_availableServers = new global::OpenRouter.AutoSDKServer[]
        {            new global::OpenRouter.AutoSDKServer(
                id: "https-openrouter-ai-api-v1",
                name: "Production server",
                url: "https://openrouter.ai/api/v1",
                description: "Production server"),
            new global::OpenRouter.AutoSDKServer(
                id: "https-openrouter-ai",
                name: "openrouter.ai",
                url: "https://openrouter.ai/",
                description: ""),
        };

        /// <summary>
        /// The server options available for this client.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::OpenRouter.AutoSDKServer> AvailableServers => s_availableServers;

        /// <summary>
        /// The currently selected server for this client, if any.
        /// </summary>
        public global::OpenRouter.AutoSDKServer? SelectedServer
        {
            get => ResolveSelectedServer();
            set => SelectServer(value);
        }

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
            if (baseUri is not null)
            {
                HttpClient.BaseAddress ??= baseUri;
            }
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::OpenRouter.EndPointAuthorization>();
            Options = options ?? new global::OpenRouter.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            AutoSDKServerConfiguration.ExplicitBaseUri = baseUri ?? httpClient?.BaseAddress;

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


        /// <summary>
        /// Selects one of the generated server options by id.
        /// </summary>
        public bool TrySelectServer(string serverId)
        {
            if (string.IsNullOrWhiteSpace(serverId))
            {
                return false;
            }

            foreach (var server in s_availableServers)
            {
                if (string.Equals(server.Id, serverId, global::System.StringComparison.OrdinalIgnoreCase))
                {
                    AutoSDKServerConfiguration.SelectedServer = server;
                    AutoSDKServerConfiguration.ExplicitBaseUri = null;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Clears the currently selected server.
        /// </summary>
        public void ClearSelectedServer()
        {
            AutoSDKServerConfiguration.SelectedServer = null;
        }

        private global::OpenRouter.AutoSDKServer? ResolveSelectedServer()
        {
            var selectedServer = AutoSDKServerConfiguration.SelectedServer;
            if (selectedServer is null)
            {
                return null;
            }

            foreach (var server in s_availableServers)
            {
                if (string.Equals(server.Id, selectedServer.Id, global::System.StringComparison.Ordinal))
                {
                    return server;
                }
            }

            return null;
        }

        private void SelectServer(global::OpenRouter.AutoSDKServer? server)
        {
            if (server is null)
            {
                AutoSDKServerConfiguration.SelectedServer = null;
                return;
            }

            foreach (var candidate in s_availableServers)
            {
                if (string.Equals(candidate.Id, server.Id, global::System.StringComparison.Ordinal))
                {
                    AutoSDKServerConfiguration.SelectedServer = candidate;
                    AutoSDKServerConfiguration.ExplicitBaseUri = null;
                    return;
                }
            }

            throw new global::System.ArgumentException("The provided server is not available for this client.", nameof(server));
        }

        private global::System.Uri? ResolveDisplayedBaseUri()
        {
            if (AutoSDKServerConfiguration.ExplicitBaseUri is global::System.Uri explicitBaseUri)
            {
                return explicitBaseUri;
            }

            return ResolveSelectedServer()?.Uri ?? (s_availableServers.Length > 0 ? s_availableServers[0].Uri : HttpClient.BaseAddress);
        }

        private global::System.Uri? ResolveBaseUri(
            global::OpenRouter.AutoSDKServer[] servers,
            string defaultBaseUrl)
        {
            if (AutoSDKServerConfiguration.ExplicitBaseUri is global::System.Uri explicitBaseUri)
            {
                return explicitBaseUri;
            }

            if (AutoSDKServerConfiguration.SelectedServer is global::OpenRouter.AutoSDKServer selectedServer)
            {
                foreach (var server in servers)
                {
                    if (string.Equals(server.Id, selectedServer.Id, global::System.StringComparison.Ordinal))
                    {
                        return server.Uri;
                    }
                }
            }

            if (servers.Length > 0)
            {
                return servers[0].Uri;
            }

            return string.IsNullOrWhiteSpace(defaultBaseUrl)
                ? HttpClient.BaseAddress
                : new global::System.Uri(defaultBaseUrl, global::System.UriKind.RelativeOrAbsolute);
        }
    }
}