#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Tool definition for function calling (regular function or OpenRouter built-in server tool)<br/>
    /// Example: {"function":{"description":"Get the current weather for a location","name":"get_weather","parameters":{"properties":{"location":{"description":"City name","type":"string"},"unit":{"enum":["celsius","fahrenheit"],"type":"string","x-speakeasy-unknown-values":"allow"}},"required":["location"],"type":"object"}},"type":"function"}
    /// </summary>
    public readonly partial struct ChatFunctionTool : global::System.IEquatable<ChatFunctionTool>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatFunctionToolVariant1? ChatFunctionToolVariant1 { get; init; }
#else
        public global::OpenRouter.ChatFunctionToolVariant1? ChatFunctionToolVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatFunctionToolVariant1))]
#endif
        public bool IsChatFunctionToolVariant1 => ChatFunctionToolVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChatFunctionToolVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatFunctionToolVariant1? value)
        {
            value = ChatFunctionToolVariant1;
            return IsChatFunctionToolVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFunctionToolVariant1 PickChatFunctionToolVariant1() => ChatFunctionToolVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatFunctionToolVariant1' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: consults a higher-intelligence advisor model (any OpenRouter model) for guidance mid-generation and returns its response. Include multiple entries to offer several named advisors; at most one entry may omit `name` to act as the default advisor.<br/>
        /// Example: {"parameters":{"model":"~anthropic/claude-opus-latest","name":"reviewer"},"type":"openrouter:advisor"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AdvisorServerToolOpenRouter? AdvisorServerOpenRouter { get; init; }
#else
        public global::OpenRouter.AdvisorServerToolOpenRouter? AdvisorServerOpenRouter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AdvisorServerOpenRouter))]
#endif
        public bool IsAdvisorServerOpenRouter => AdvisorServerOpenRouter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAdvisorServerOpenRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AdvisorServerToolOpenRouter? value)
        {
            value = AdvisorServerOpenRouter;
            return IsAdvisorServerOpenRouter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdvisorServerToolOpenRouter PickAdvisorServerOpenRouter() => AdvisorServerOpenRouter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AdvisorServerOpenRouter' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: runs shell commands server-side in a sandboxed container<br/>
        /// Example: {"parameters":{"environment":{"type":"container_auto"}},"type":"openrouter:bash"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BashServerTool? BashServer { get; init; }
#else
        public global::OpenRouter.BashServerTool? BashServer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BashServer))]
#endif
        public bool IsBashServer => BashServer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBashServer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.BashServerTool? value)
        {
            value = BashServer;
            return IsBashServer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerTool PickBashServer() => BashServer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BashServer' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: returns the current date and time<br/>
        /// Example: {"parameters":{"timezone":"America/New_York"},"type":"openrouter:datetime"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.DatetimeServerTool? DatetimeServer { get; init; }
#else
        public global::OpenRouter.DatetimeServerTool? DatetimeServer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DatetimeServer))]
#endif
        public bool IsDatetimeServer => DatetimeServer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDatetimeServer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.DatetimeServerTool? value)
        {
            value = DatetimeServer;
            return IsDatetimeServer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatetimeServerTool PickDatetimeServer() => DatetimeServer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DatetimeServer' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: read, write, edit, and list workspace files via the Files API. Requires an authenticated request; files come from the API key's workspace (or the default workspace for keys without one).<br/>
        /// Example: {"parameters":{},"type":"openrouter:files"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FilesServerTool? FilesServer { get; init; }
#else
        public global::OpenRouter.FilesServerTool? FilesServer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilesServer))]
#endif
        public bool IsFilesServer => FilesServer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFilesServer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FilesServerTool? value)
        {
            value = FilesServer;
            return IsFilesServer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilesServerTool PickFilesServer() => FilesServer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FilesServer' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: fans out the user prompt to a panel of analysis models, then asks an analyst model to summarize their collective output as structured JSON the outer model can synthesize from.<br/>
        /// Example: {"parameters":{"analysis_models":["~anthropic/claude-opus-latest","~openai/gpt-sol-latest"]},"type":"openrouter:fusion"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FusionServerToolOpenRouter? FusionServerOpenRouter { get; init; }
#else
        public global::OpenRouter.FusionServerToolOpenRouter? FusionServerOpenRouter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FusionServerOpenRouter))]
#endif
        public bool IsFusionServerOpenRouter => FusionServerOpenRouter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFusionServerOpenRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FusionServerToolOpenRouter? value)
        {
            value = FusionServerOpenRouter;
            return IsFusionServerOpenRouter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolOpenRouter PickFusionServerOpenRouter() => FusionServerOpenRouter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FusionServerOpenRouter' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: generates images from text prompts using an image generation model<br/>
        /// Example: {"parameters":{"model":"openai/gpt-5-image","quality":"high","size":"1024x1024"},"type":"openrouter:image_generation"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ImageGenerationServerToolOpenRouter? ImageGenerationServerOpenRouter { get; init; }
#else
        public global::OpenRouter.ImageGenerationServerToolOpenRouter? ImageGenerationServerOpenRouter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenerationServerOpenRouter))]
#endif
        public bool IsImageGenerationServerOpenRouter => ImageGenerationServerOpenRouter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImageGenerationServerOpenRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ImageGenerationServerToolOpenRouter? value)
        {
            value = ImageGenerationServerOpenRouter;
            return IsImageGenerationServerOpenRouter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolOpenRouter PickImageGenerationServerOpenRouter() => ImageGenerationServerOpenRouter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGenerationServerOpenRouter' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: searches and filters AI models available on OpenRouter<br/>
        /// Example: {"parameters":{"max_results":5},"type":"openrouter:experimental__search_models"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatSearchModelsServerTool? SearchModelsServer { get; init; }
#else
        public global::OpenRouter.ChatSearchModelsServerTool? SearchModelsServer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchModelsServer))]
#endif
        public bool IsSearchModelsServer => SearchModelsServer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSearchModelsServer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatSearchModelsServerTool? value)
        {
            value = SearchModelsServer;
            return IsSearchModelsServer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatSearchModelsServerTool PickSearchModelsServer() => SearchModelsServer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchModelsServer' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: delegates self-contained tasks to a smaller, cheaper, faster worker model (any OpenRouter model) mid-generation and returns its outcome. The worker may run as a sub-agent with its own tools.<br/>
        /// Example: {"parameters":{"model":"~anthropic/claude-haiku-latest"},"type":"openrouter:subagent"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.SubagentServerToolOpenRouter? SubagentServerOpenRouter { get; init; }
#else
        public global::OpenRouter.SubagentServerToolOpenRouter? SubagentServerOpenRouter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubagentServerOpenRouter))]
#endif
        public bool IsSubagentServerOpenRouter => SubagentServerOpenRouter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubagentServerOpenRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.SubagentServerToolOpenRouter? value)
        {
            value = SubagentServerOpenRouter;
            return IsSubagentServerOpenRouter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentServerToolOpenRouter PickSubagentServerOpenRouter() => SubagentServerOpenRouter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubagentServerOpenRouter' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: fetches full content from a URL (web page or PDF)<br/>
        /// Example: {"parameters":{"max_uses":10},"type":"openrouter:web_fetch"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.WebFetchServerTool? WebFetchServer { get; init; }
#else
        public global::OpenRouter.WebFetchServerTool? WebFetchServer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebFetchServer))]
#endif
        public bool IsWebFetchServer => WebFetchServer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebFetchServer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.WebFetchServerTool? value)
        {
            value = WebFetchServer;
            return IsWebFetchServer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchServerTool PickWebFetchServer() => WebFetchServer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebFetchServer' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: searches the web for current information<br/>
        /// Example: {"parameters":{"max_results":5},"type":"openrouter:web_search"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenRouterWebSearchServerTool? OpenRouterWebSearchServer { get; init; }
#else
        public global::OpenRouter.OpenRouterWebSearchServerTool? OpenRouterWebSearchServer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenRouterWebSearchServer))]
#endif
        public bool IsOpenRouterWebSearchServer => OpenRouterWebSearchServer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenRouterWebSearchServer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenRouterWebSearchServerTool? value)
        {
            value = OpenRouterWebSearchServer;
            return IsOpenRouterWebSearchServer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterWebSearchServerTool PickOpenRouterWebSearchServer() => OpenRouterWebSearchServer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenRouterWebSearchServer' but the value was {ToString()}.");

        /// <summary>
        /// Web search tool using OpenAI Responses API syntax. Automatically converted to openrouter:web_search.<br/>
        /// Example: {"type":"web_search_preview"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatWebSearchShorthand? WebSearchShorthand { get; init; }
#else
        public global::OpenRouter.ChatWebSearchShorthand? WebSearchShorthand { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchShorthand))]
#endif
        public bool IsWebSearchShorthand => WebSearchShorthand != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearchShorthand(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatWebSearchShorthand? value)
        {
            value = WebSearchShorthand;
            return IsWebSearchShorthand;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatWebSearchShorthand PickWebSearchShorthand() => WebSearchShorthand is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchShorthand' but the value was {ToString()}.");

        /// <summary>
        /// Generic OpenRouter server-tool envelope. `type` names a registered server tool (canonical `openrouter:*` form or a registered shorthand); `parameters` carries tool-specific configuration validated against the tool definition.<br/>
        /// Example: {"parameters":{},"type":"openrouter:datetime_v2"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatDynamicServerTool? DynamicServer { get; init; }
#else
        public global::OpenRouter.ChatDynamicServerTool? DynamicServer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicServer))]
#endif
        public bool IsDynamicServer => DynamicServer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDynamicServer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatDynamicServerTool? value)
        {
            value = DynamicServer;
            return IsDynamicServer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatDynamicServerTool PickDynamicServer() => DynamicServer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DynamicServer' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.ChatFunctionToolVariant1 value) => new ChatFunctionTool((global::OpenRouter.ChatFunctionToolVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatFunctionToolVariant1?(ChatFunctionTool @this) => @this.ChatFunctionToolVariant1;

        /// <summary>
        ///
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.ChatFunctionToolVariant1? value)
        {
            ChatFunctionToolVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatFunctionTool FromChatFunctionToolVariant1(global::OpenRouter.ChatFunctionToolVariant1? value) => new ChatFunctionTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.AdvisorServerToolOpenRouter value) => new ChatFunctionTool((global::OpenRouter.AdvisorServerToolOpenRouter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AdvisorServerToolOpenRouter?(ChatFunctionTool @this) => @this.AdvisorServerOpenRouter;

        /// <summary>
        ///
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.AdvisorServerToolOpenRouter? value)
        {
            AdvisorServerOpenRouter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatFunctionTool FromAdvisorServerOpenRouter(global::OpenRouter.AdvisorServerToolOpenRouter? value) => new ChatFunctionTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.BashServerTool value) => new ChatFunctionTool((global::OpenRouter.BashServerTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BashServerTool?(ChatFunctionTool @this) => @this.BashServer;

        /// <summary>
        ///
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.BashServerTool? value)
        {
            BashServer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatFunctionTool FromBashServer(global::OpenRouter.BashServerTool? value) => new ChatFunctionTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.DatetimeServerTool value) => new ChatFunctionTool((global::OpenRouter.DatetimeServerTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.DatetimeServerTool?(ChatFunctionTool @this) => @this.DatetimeServer;

        /// <summary>
        ///
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.DatetimeServerTool? value)
        {
            DatetimeServer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatFunctionTool FromDatetimeServer(global::OpenRouter.DatetimeServerTool? value) => new ChatFunctionTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.FilesServerTool value) => new ChatFunctionTool((global::OpenRouter.FilesServerTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FilesServerTool?(ChatFunctionTool @this) => @this.FilesServer;

        /// <summary>
        ///
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.FilesServerTool? value)
        {
            FilesServer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatFunctionTool FromFilesServer(global::OpenRouter.FilesServerTool? value) => new ChatFunctionTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.FusionServerToolOpenRouter value) => new ChatFunctionTool((global::OpenRouter.FusionServerToolOpenRouter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FusionServerToolOpenRouter?(ChatFunctionTool @this) => @this.FusionServerOpenRouter;

        /// <summary>
        ///
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.FusionServerToolOpenRouter? value)
        {
            FusionServerOpenRouter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatFunctionTool FromFusionServerOpenRouter(global::OpenRouter.FusionServerToolOpenRouter? value) => new ChatFunctionTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.ImageGenerationServerToolOpenRouter value) => new ChatFunctionTool((global::OpenRouter.ImageGenerationServerToolOpenRouter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ImageGenerationServerToolOpenRouter?(ChatFunctionTool @this) => @this.ImageGenerationServerOpenRouter;

        /// <summary>
        ///
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.ImageGenerationServerToolOpenRouter? value)
        {
            ImageGenerationServerOpenRouter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatFunctionTool FromImageGenerationServerOpenRouter(global::OpenRouter.ImageGenerationServerToolOpenRouter? value) => new ChatFunctionTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.ChatSearchModelsServerTool value) => new ChatFunctionTool((global::OpenRouter.ChatSearchModelsServerTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatSearchModelsServerTool?(ChatFunctionTool @this) => @this.SearchModelsServer;

        /// <summary>
        ///
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.ChatSearchModelsServerTool? value)
        {
            SearchModelsServer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatFunctionTool FromSearchModelsServer(global::OpenRouter.ChatSearchModelsServerTool? value) => new ChatFunctionTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.SubagentServerToolOpenRouter value) => new ChatFunctionTool((global::OpenRouter.SubagentServerToolOpenRouter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.SubagentServerToolOpenRouter?(ChatFunctionTool @this) => @this.SubagentServerOpenRouter;

        /// <summary>
        ///
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.SubagentServerToolOpenRouter? value)
        {
            SubagentServerOpenRouter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatFunctionTool FromSubagentServerOpenRouter(global::OpenRouter.SubagentServerToolOpenRouter? value) => new ChatFunctionTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.WebFetchServerTool value) => new ChatFunctionTool((global::OpenRouter.WebFetchServerTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.WebFetchServerTool?(ChatFunctionTool @this) => @this.WebFetchServer;

        /// <summary>
        ///
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.WebFetchServerTool? value)
        {
            WebFetchServer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatFunctionTool FromWebFetchServer(global::OpenRouter.WebFetchServerTool? value) => new ChatFunctionTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.OpenRouterWebSearchServerTool value) => new ChatFunctionTool((global::OpenRouter.OpenRouterWebSearchServerTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenRouterWebSearchServerTool?(ChatFunctionTool @this) => @this.OpenRouterWebSearchServer;

        /// <summary>
        ///
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.OpenRouterWebSearchServerTool? value)
        {
            OpenRouterWebSearchServer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatFunctionTool FromOpenRouterWebSearchServer(global::OpenRouter.OpenRouterWebSearchServerTool? value) => new ChatFunctionTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.ChatWebSearchShorthand value) => new ChatFunctionTool((global::OpenRouter.ChatWebSearchShorthand?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatWebSearchShorthand?(ChatFunctionTool @this) => @this.WebSearchShorthand;

        /// <summary>
        ///
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.ChatWebSearchShorthand? value)
        {
            WebSearchShorthand = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatFunctionTool FromWebSearchShorthand(global::OpenRouter.ChatWebSearchShorthand? value) => new ChatFunctionTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.ChatDynamicServerTool value) => new ChatFunctionTool((global::OpenRouter.ChatDynamicServerTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatDynamicServerTool?(ChatFunctionTool @this) => @this.DynamicServer;

        /// <summary>
        ///
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.ChatDynamicServerTool? value)
        {
            DynamicServer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatFunctionTool FromDynamicServer(global::OpenRouter.ChatDynamicServerTool? value) => new ChatFunctionTool(value);

        /// <summary>
        ///
        /// </summary>
        public ChatFunctionTool(
            global::OpenRouter.ChatFunctionToolVariant1? chatFunctionToolVariant1,
            global::OpenRouter.AdvisorServerToolOpenRouter? advisorServerOpenRouter,
            global::OpenRouter.BashServerTool? bashServer,
            global::OpenRouter.DatetimeServerTool? datetimeServer,
            global::OpenRouter.FilesServerTool? filesServer,
            global::OpenRouter.FusionServerToolOpenRouter? fusionServerOpenRouter,
            global::OpenRouter.ImageGenerationServerToolOpenRouter? imageGenerationServerOpenRouter,
            global::OpenRouter.ChatSearchModelsServerTool? searchModelsServer,
            global::OpenRouter.SubagentServerToolOpenRouter? subagentServerOpenRouter,
            global::OpenRouter.WebFetchServerTool? webFetchServer,
            global::OpenRouter.OpenRouterWebSearchServerTool? openRouterWebSearchServer,
            global::OpenRouter.ChatWebSearchShorthand? webSearchShorthand,
            global::OpenRouter.ChatDynamicServerTool? dynamicServer
            )
        {
            ChatFunctionToolVariant1 = chatFunctionToolVariant1;
            AdvisorServerOpenRouter = advisorServerOpenRouter;
            BashServer = bashServer;
            DatetimeServer = datetimeServer;
            FilesServer = filesServer;
            FusionServerOpenRouter = fusionServerOpenRouter;
            ImageGenerationServerOpenRouter = imageGenerationServerOpenRouter;
            SearchModelsServer = searchModelsServer;
            SubagentServerOpenRouter = subagentServerOpenRouter;
            WebFetchServer = webFetchServer;
            OpenRouterWebSearchServer = openRouterWebSearchServer;
            WebSearchShorthand = webSearchShorthand;
            DynamicServer = dynamicServer;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            DynamicServer as object ??
            WebSearchShorthand as object ??
            OpenRouterWebSearchServer as object ??
            WebFetchServer as object ??
            SubagentServerOpenRouter as object ??
            SearchModelsServer as object ??
            ImageGenerationServerOpenRouter as object ??
            FusionServerOpenRouter as object ??
            FilesServer as object ??
            DatetimeServer as object ??
            BashServer as object ??
            AdvisorServerOpenRouter as object ??
            ChatFunctionToolVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ChatFunctionToolVariant1?.ToString() ??
            AdvisorServerOpenRouter?.ToString() ??
            BashServer?.ToString() ??
            DatetimeServer?.ToString() ??
            FilesServer?.ToString() ??
            FusionServerOpenRouter?.ToString() ??
            ImageGenerationServerOpenRouter?.ToString() ??
            SearchModelsServer?.ToString() ??
            SubagentServerOpenRouter?.ToString() ??
            WebFetchServer?.ToString() ??
            OpenRouterWebSearchServer?.ToString() ??
            WebSearchShorthand?.ToString() ??
            DynamicServer?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsChatFunctionToolVariant1 || IsAdvisorServerOpenRouter || IsBashServer || IsDatetimeServer || IsFilesServer || IsFusionServerOpenRouter || IsImageGenerationServerOpenRouter || IsSearchModelsServer || IsSubagentServerOpenRouter || IsWebFetchServer || IsOpenRouterWebSearchServer || IsWebSearchShorthand || IsDynamicServer;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ChatFunctionToolVariant1, TResult>? chatFunctionToolVariant1 = null,
            global::System.Func<global::OpenRouter.AdvisorServerToolOpenRouter, TResult>? advisorServerOpenRouter = null,
            global::System.Func<global::OpenRouter.BashServerTool, TResult>? bashServer = null,
            global::System.Func<global::OpenRouter.DatetimeServerTool, TResult>? datetimeServer = null,
            global::System.Func<global::OpenRouter.FilesServerTool, TResult>? filesServer = null,
            global::System.Func<global::OpenRouter.FusionServerToolOpenRouter, TResult>? fusionServerOpenRouter = null,
            global::System.Func<global::OpenRouter.ImageGenerationServerToolOpenRouter, TResult>? imageGenerationServerOpenRouter = null,
            global::System.Func<global::OpenRouter.ChatSearchModelsServerTool, TResult>? searchModelsServer = null,
            global::System.Func<global::OpenRouter.SubagentServerToolOpenRouter, TResult>? subagentServerOpenRouter = null,
            global::System.Func<global::OpenRouter.WebFetchServerTool, TResult>? webFetchServer = null,
            global::System.Func<global::OpenRouter.OpenRouterWebSearchServerTool, TResult>? openRouterWebSearchServer = null,
            global::System.Func<global::OpenRouter.ChatWebSearchShorthand, TResult>? webSearchShorthand = null,
            global::System.Func<global::OpenRouter.ChatDynamicServerTool, TResult>? dynamicServer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ChatFunctionToolVariant1 is { } __value0 && chatFunctionToolVariant1 != null)
            {
                return chatFunctionToolVariant1(__value0);
            }
            else if (AdvisorServerOpenRouter is { } __value1 && advisorServerOpenRouter != null)
            {
                return advisorServerOpenRouter(__value1);
            }
            else if (BashServer is { } __value2 && bashServer != null)
            {
                return bashServer(__value2);
            }
            else if (DatetimeServer is { } __value3 && datetimeServer != null)
            {
                return datetimeServer(__value3);
            }
            else if (FilesServer is { } __value4 && filesServer != null)
            {
                return filesServer(__value4);
            }
            else if (FusionServerOpenRouter is { } __value5 && fusionServerOpenRouter != null)
            {
                return fusionServerOpenRouter(__value5);
            }
            else if (ImageGenerationServerOpenRouter is { } __value6 && imageGenerationServerOpenRouter != null)
            {
                return imageGenerationServerOpenRouter(__value6);
            }
            else if (SearchModelsServer is { } __value7 && searchModelsServer != null)
            {
                return searchModelsServer(__value7);
            }
            else if (SubagentServerOpenRouter is { } __value8 && subagentServerOpenRouter != null)
            {
                return subagentServerOpenRouter(__value8);
            }
            else if (WebFetchServer is { } __value9 && webFetchServer != null)
            {
                return webFetchServer(__value9);
            }
            else if (OpenRouterWebSearchServer is { } __value10 && openRouterWebSearchServer != null)
            {
                return openRouterWebSearchServer(__value10);
            }
            else if (WebSearchShorthand is { } __value11 && webSearchShorthand != null)
            {
                return webSearchShorthand(__value11);
            }
            else if (DynamicServer is { } __value12 && dynamicServer != null)
            {
                return dynamicServer(__value12);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ChatFunctionToolVariant1>? chatFunctionToolVariant1 = null,

            global::System.Action<global::OpenRouter.AdvisorServerToolOpenRouter>? advisorServerOpenRouter = null,

            global::System.Action<global::OpenRouter.BashServerTool>? bashServer = null,

            global::System.Action<global::OpenRouter.DatetimeServerTool>? datetimeServer = null,

            global::System.Action<global::OpenRouter.FilesServerTool>? filesServer = null,

            global::System.Action<global::OpenRouter.FusionServerToolOpenRouter>? fusionServerOpenRouter = null,

            global::System.Action<global::OpenRouter.ImageGenerationServerToolOpenRouter>? imageGenerationServerOpenRouter = null,

            global::System.Action<global::OpenRouter.ChatSearchModelsServerTool>? searchModelsServer = null,

            global::System.Action<global::OpenRouter.SubagentServerToolOpenRouter>? subagentServerOpenRouter = null,

            global::System.Action<global::OpenRouter.WebFetchServerTool>? webFetchServer = null,

            global::System.Action<global::OpenRouter.OpenRouterWebSearchServerTool>? openRouterWebSearchServer = null,

            global::System.Action<global::OpenRouter.ChatWebSearchShorthand>? webSearchShorthand = null,

            global::System.Action<global::OpenRouter.ChatDynamicServerTool>? dynamicServer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ChatFunctionToolVariant1 is { } __value0)
            {
                chatFunctionToolVariant1?.Invoke(__value0);
            }
            else if (AdvisorServerOpenRouter is { } __value1)
            {
                advisorServerOpenRouter?.Invoke(__value1);
            }
            else if (BashServer is { } __value2)
            {
                bashServer?.Invoke(__value2);
            }
            else if (DatetimeServer is { } __value3)
            {
                datetimeServer?.Invoke(__value3);
            }
            else if (FilesServer is { } __value4)
            {
                filesServer?.Invoke(__value4);
            }
            else if (FusionServerOpenRouter is { } __value5)
            {
                fusionServerOpenRouter?.Invoke(__value5);
            }
            else if (ImageGenerationServerOpenRouter is { } __value6)
            {
                imageGenerationServerOpenRouter?.Invoke(__value6);
            }
            else if (SearchModelsServer is { } __value7)
            {
                searchModelsServer?.Invoke(__value7);
            }
            else if (SubagentServerOpenRouter is { } __value8)
            {
                subagentServerOpenRouter?.Invoke(__value8);
            }
            else if (WebFetchServer is { } __value9)
            {
                webFetchServer?.Invoke(__value9);
            }
            else if (OpenRouterWebSearchServer is { } __value10)
            {
                openRouterWebSearchServer?.Invoke(__value10);
            }
            else if (WebSearchShorthand is { } __value11)
            {
                webSearchShorthand?.Invoke(__value11);
            }
            else if (DynamicServer is { } __value12)
            {
                dynamicServer?.Invoke(__value12);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ChatFunctionToolVariant1>? chatFunctionToolVariant1 = null,
            global::System.Action<global::OpenRouter.AdvisorServerToolOpenRouter>? advisorServerOpenRouter = null,
            global::System.Action<global::OpenRouter.BashServerTool>? bashServer = null,
            global::System.Action<global::OpenRouter.DatetimeServerTool>? datetimeServer = null,
            global::System.Action<global::OpenRouter.FilesServerTool>? filesServer = null,
            global::System.Action<global::OpenRouter.FusionServerToolOpenRouter>? fusionServerOpenRouter = null,
            global::System.Action<global::OpenRouter.ImageGenerationServerToolOpenRouter>? imageGenerationServerOpenRouter = null,
            global::System.Action<global::OpenRouter.ChatSearchModelsServerTool>? searchModelsServer = null,
            global::System.Action<global::OpenRouter.SubagentServerToolOpenRouter>? subagentServerOpenRouter = null,
            global::System.Action<global::OpenRouter.WebFetchServerTool>? webFetchServer = null,
            global::System.Action<global::OpenRouter.OpenRouterWebSearchServerTool>? openRouterWebSearchServer = null,
            global::System.Action<global::OpenRouter.ChatWebSearchShorthand>? webSearchShorthand = null,
            global::System.Action<global::OpenRouter.ChatDynamicServerTool>? dynamicServer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ChatFunctionToolVariant1 is { } __value0)
            {
                chatFunctionToolVariant1?.Invoke(__value0);
            }
            else if (AdvisorServerOpenRouter is { } __value1)
            {
                advisorServerOpenRouter?.Invoke(__value1);
            }
            else if (BashServer is { } __value2)
            {
                bashServer?.Invoke(__value2);
            }
            else if (DatetimeServer is { } __value3)
            {
                datetimeServer?.Invoke(__value3);
            }
            else if (FilesServer is { } __value4)
            {
                filesServer?.Invoke(__value4);
            }
            else if (FusionServerOpenRouter is { } __value5)
            {
                fusionServerOpenRouter?.Invoke(__value5);
            }
            else if (ImageGenerationServerOpenRouter is { } __value6)
            {
                imageGenerationServerOpenRouter?.Invoke(__value6);
            }
            else if (SearchModelsServer is { } __value7)
            {
                searchModelsServer?.Invoke(__value7);
            }
            else if (SubagentServerOpenRouter is { } __value8)
            {
                subagentServerOpenRouter?.Invoke(__value8);
            }
            else if (WebFetchServer is { } __value9)
            {
                webFetchServer?.Invoke(__value9);
            }
            else if (OpenRouterWebSearchServer is { } __value10)
            {
                openRouterWebSearchServer?.Invoke(__value10);
            }
            else if (WebSearchShorthand is { } __value11)
            {
                webSearchShorthand?.Invoke(__value11);
            }
            else if (DynamicServer is { } __value12)
            {
                dynamicServer?.Invoke(__value12);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatFunctionToolVariant1,
                typeof(global::OpenRouter.ChatFunctionToolVariant1),
                AdvisorServerOpenRouter,
                typeof(global::OpenRouter.AdvisorServerToolOpenRouter),
                BashServer,
                typeof(global::OpenRouter.BashServerTool),
                DatetimeServer,
                typeof(global::OpenRouter.DatetimeServerTool),
                FilesServer,
                typeof(global::OpenRouter.FilesServerTool),
                FusionServerOpenRouter,
                typeof(global::OpenRouter.FusionServerToolOpenRouter),
                ImageGenerationServerOpenRouter,
                typeof(global::OpenRouter.ImageGenerationServerToolOpenRouter),
                SearchModelsServer,
                typeof(global::OpenRouter.ChatSearchModelsServerTool),
                SubagentServerOpenRouter,
                typeof(global::OpenRouter.SubagentServerToolOpenRouter),
                WebFetchServer,
                typeof(global::OpenRouter.WebFetchServerTool),
                OpenRouterWebSearchServer,
                typeof(global::OpenRouter.OpenRouterWebSearchServerTool),
                WebSearchShorthand,
                typeof(global::OpenRouter.ChatWebSearchShorthand),
                DynamicServer,
                typeof(global::OpenRouter.ChatDynamicServerTool),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ChatFunctionTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatFunctionToolVariant1?>.Default.Equals(ChatFunctionToolVariant1, other.ChatFunctionToolVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AdvisorServerToolOpenRouter?>.Default.Equals(AdvisorServerOpenRouter, other.AdvisorServerOpenRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BashServerTool?>.Default.Equals(BashServer, other.BashServer) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.DatetimeServerTool?>.Default.Equals(DatetimeServer, other.DatetimeServer) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FilesServerTool?>.Default.Equals(FilesServer, other.FilesServer) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FusionServerToolOpenRouter?>.Default.Equals(FusionServerOpenRouter, other.FusionServerOpenRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ImageGenerationServerToolOpenRouter?>.Default.Equals(ImageGenerationServerOpenRouter, other.ImageGenerationServerOpenRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatSearchModelsServerTool?>.Default.Equals(SearchModelsServer, other.SearchModelsServer) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.SubagentServerToolOpenRouter?>.Default.Equals(SubagentServerOpenRouter, other.SubagentServerOpenRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.WebFetchServerTool?>.Default.Equals(WebFetchServer, other.WebFetchServer) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenRouterWebSearchServerTool?>.Default.Equals(OpenRouterWebSearchServer, other.OpenRouterWebSearchServer) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatWebSearchShorthand?>.Default.Equals(WebSearchShorthand, other.WebSearchShorthand) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatDynamicServerTool?>.Default.Equals(DynamicServer, other.DynamicServer)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ChatFunctionTool obj1, ChatFunctionTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatFunctionTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChatFunctionTool obj1, ChatFunctionTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatFunctionTool o && Equals(o);
        }
    }
}
