
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenAI-compatible API with additional OpenRouter features<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IOpenRouterClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }


        /// <summary>
        /// The server options available for this client.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::OpenRouter.AutoSDKServer> AvailableServers { get; }

        /// <summary>
        /// The currently selected server for this client, if any.
        /// </summary>
        public global::OpenRouter.AutoSDKServer? SelectedServer { get; set; }

        /// <summary>
        /// Selects one of the generated server options by id.
        /// </summary>
        public bool TrySelectServer(string serverId);

        /// <summary>
        /// Clears the currently selected server.
        /// </summary>
        public void ClearSelectedServer();

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::OpenRouter.AutoSDKClientOptions Options { get; }

        /// <summary>
        /// Creates idempotency keys for generated idempotent requests when the caller does not provide one.
        /// </summary>
        public global::System.Func<string> CreateIdempotencyKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Alpha feature endpoints for Decisions requests.
        /// </summary>
        public AlphaDecisionsClient AlphaDecisions { get; }

        /// <summary>
        /// Analytics and usage endpoints.
        /// </summary>
        public AnalyticsClient Analytics { get; }

        /// <summary>
        /// API key management endpoints.
        /// </summary>
        public ApiKeysClient ApiKeys { get; }

        /// <summary>
        /// Submit, list, poll, and delete asynchronous batches of inference requests. See https://openrouter.ai/docs/batch-quickstart.
        /// </summary>
        public BatchClient Batch { get; }

        /// <summary>
        /// Benchmarks endpoints.
        /// </summary>
        public BenchmarksClient Benchmarks { get; }

        /// <summary>
        /// BYOK endpoints.
        /// </summary>
        public ByokClient Byok { get; }

        /// <summary>
        ///
        /// </summary>
        public ChatClient Chat { get; }

        /// <summary>
        /// Task classification market-share endpoints.
        /// </summary>
        public ClassificationsClient Classifications { get; }

        /// <summary>
        /// Containers endpoints.
        /// </summary>
        public ContainersClient Containers { get; }

        /// <summary>
        /// Credit management endpoints.
        /// </summary>
        public CreditsClient Credits { get; }

        /// <summary>
        /// Public OpenRouter usage datasets. Data returned by these endpoints is licensed under CC BY 4.0 (https://creativecommons.org/licenses/by/4.0/): reuse and republish it, including commercially, with attribution to OpenRouter.
        /// </summary>
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// Text embedding endpoints.
        /// </summary>
        public EmbeddingsClient Embeddings { get; }

        /// <summary>
        /// End Users endpoints.
        /// </summary>
        public EndUsersClient EndUsers { get; }

        /// <summary>
        /// Endpoint information.
        /// </summary>
        public EndpointsClient Endpoints { get; }

        /// <summary>
        /// Files endpoints.
        /// </summary>
        public FilesClient Files { get; }

        /// <summary>
        /// Generation history endpoints.
        /// </summary>
        public GenerationsClient Generations { get; }

        /// <summary>
        /// Guardrails endpoints.
        /// </summary>
        public GuardrailsClient Guardrails { get; }

        /// <summary>
        /// Images endpoints.
        /// </summary>
        public ImagesClient Images { get; }

        /// <summary>
        /// Create, inspect, update, provision, suspend and delete OpenRouter interns through an API key, and talk to them: the chat route streams OpenAI-compatible completions from one intern, pausing as an `openrouter.provide_input` tool call when the intern needs your permission or an answer. Available to interns programme members; other callers receive 404. See https://openrouter.ai/docs/guides/ori/intern-chat.
        /// </summary>
        public InternsClient Interns { get; }

        /// <summary>
        ///
        /// </summary>
        public Interns2Client Interns2 { get; }

        /// <summary>
        /// Model information endpoints.
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// OAuth authentication endpoints.
        /// </summary>
        public OAuthClient OAuth { get; }

        /// <summary>
        /// Observability endpoints.
        /// </summary>
        public ObservabilityClient Observability { get; }

        /// <summary>
        /// Organization endpoints.
        /// </summary>
        public OrganizationClient Organization { get; }

        /// <summary>
        /// Presets endpoints.
        /// </summary>
        public PresetsClient Presets { get; }

        /// <summary>
        /// Private Endpoints endpoints.
        /// </summary>
        public PrivateEndpointsClient PrivateEndpoints { get; }

        /// <summary>
        /// Provider information endpoints.
        /// </summary>
        public ProvidersClient Providers { get; }

        /// <summary>
        /// Rerank endpoints.
        /// </summary>
        public RerankClient Rerank { get; }

        /// <summary>
        /// OpenAI-compatible Responses API endpoints.
        /// </summary>
        public ResponsesClient Responses { get; }

        /// <summary>
        /// Management endpoints for SCIM group-to-workspace mappings, authenticated with a management key. These are not the SCIM 2.0 connector endpoints for your identity provider. In your identity provider, enter the SCIM endpoint URL shown when you enable provisioning under Settings &gt; Members &gt; SCIM Mappings. See https://openrouter.ai/docs/guides/features/scim-mappings#set-up-provisioning.
        /// </summary>
        public ScimClient Scim { get; }

        /// <summary>
        /// Transcriptions. Speech-to-text endpoints.
        /// </summary>
        public SttClient Stt { get; }

        /// <summary>
        /// System One. System One endpoints for models such as Jev, compatible with the TypeSafe SDKs. See https://openrouter.ai/docs/guides/community/typesafe-sdk.
        /// </summary>
        public SystemOneClient SystemOne { get; }

        /// <summary>
        /// The catalog of server tools OpenRouter runs on behalf of a model: accepted `tools[].type` spellings per API format, engines and pricing, and which endpoints run each tool natively. See https://openrouter.ai/docs/guides/features/server-tools.
        /// </summary>
        public ToolsClient Tools { get; }

        /// <summary>
        /// Speech. Text-to-speech endpoints.
        /// </summary>
        public TtsClient Tts { get; }

        /// <summary>
        /// Store host-bound secrets for a workspace or for one intern. Scope is selected by the API key. Responses return metadata only, never secret values. See https://openrouter.ai/docs/guides/ori/vault.
        /// </summary>
        public VaultClient Vault { get; }

        /// <summary>
        /// Video Generation endpoints.
        /// </summary>
        public VideoGenerationClient VideoGeneration { get; }

        /// <summary>
        /// Workspaces endpoints.
        /// </summary>
        public WorkspacesClient Workspaces { get; }

    }
}