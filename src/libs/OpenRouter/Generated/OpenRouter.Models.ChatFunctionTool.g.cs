#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Tool definition for function calling (regular function or OpenRouter built-in server tool)
    /// </summary>
    public readonly partial struct ChatFunctionTool : global::System.IEquatable<ChatFunctionTool>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatFunctionTool0? ChatFunctionTool0 { get; init; }
#else
        public global::OpenRouter.ChatFunctionTool0? ChatFunctionTool0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatFunctionTool0))]
#endif
        public bool IsChatFunctionTool0 => ChatFunctionTool0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatFunctionTool0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatFunctionTool0? value)
        {
            value = ChatFunctionTool0;
            return IsChatFunctionTool0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatFunctionTool0 PickChatFunctionTool0() => IsChatFunctionTool0
            ? ChatFunctionTool0!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatFunctionTool0' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: consults a higher-intelligence advisor model (any OpenRouter model) for guidance mid-generation and returns its response. The advisor may run as a sub-agent with its own tools. Include multiple entries to offer several named advisors; at most one entry may omit `name` to act as the default advisor.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AdvisorServerToolOpenRouter? AdvisorServerToolOpenRouter { get; init; }
#else
        public global::OpenRouter.AdvisorServerToolOpenRouter? AdvisorServerToolOpenRouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AdvisorServerToolOpenRouter))]
#endif
        public bool IsAdvisorServerToolOpenRouter => AdvisorServerToolOpenRouter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAdvisorServerToolOpenRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AdvisorServerToolOpenRouter? value)
        {
            value = AdvisorServerToolOpenRouter;
            return IsAdvisorServerToolOpenRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.AdvisorServerToolOpenRouter PickAdvisorServerToolOpenRouter() => IsAdvisorServerToolOpenRouter
            ? AdvisorServerToolOpenRouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AdvisorServerToolOpenRouter' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: runs shell commands server-side in a sandboxed container
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BashServerTool? BashServerTool { get; init; }
#else
        public global::OpenRouter.BashServerTool? BashServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BashServerTool))]
#endif
        public bool IsBashServerTool => BashServerTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBashServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.BashServerTool? value)
        {
            value = BashServerTool;
            return IsBashServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.BashServerTool PickBashServerTool() => IsBashServerTool
            ? BashServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BashServerTool' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: returns the current date and time
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.DatetimeServerTool? DatetimeServerTool { get; init; }
#else
        public global::OpenRouter.DatetimeServerTool? DatetimeServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DatetimeServerTool))]
#endif
        public bool IsDatetimeServerTool => DatetimeServerTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDatetimeServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.DatetimeServerTool? value)
        {
            value = DatetimeServerTool;
            return IsDatetimeServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.DatetimeServerTool PickDatetimeServerTool() => IsDatetimeServerTool
            ? DatetimeServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DatetimeServerTool' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: read, write, edit, and list workspace files via the Files API. Requires the `x-openrouter-file-ids: openrouter` request header.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FilesServerTool? FilesServerTool { get; init; }
#else
        public global::OpenRouter.FilesServerTool? FilesServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilesServerTool))]
#endif
        public bool IsFilesServerTool => FilesServerTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFilesServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FilesServerTool? value)
        {
            value = FilesServerTool;
            return IsFilesServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.FilesServerTool PickFilesServerTool() => IsFilesServerTool
            ? FilesServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FilesServerTool' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: fans out the user prompt to a panel of analysis models, then asks a judge model to summarize their collective output as structured JSON the outer model can synthesize from.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FusionServerToolOpenRouter? FusionServerToolOpenRouter { get; init; }
#else
        public global::OpenRouter.FusionServerToolOpenRouter? FusionServerToolOpenRouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FusionServerToolOpenRouter))]
#endif
        public bool IsFusionServerToolOpenRouter => FusionServerToolOpenRouter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFusionServerToolOpenRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FusionServerToolOpenRouter? value)
        {
            value = FusionServerToolOpenRouter;
            return IsFusionServerToolOpenRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.FusionServerToolOpenRouter PickFusionServerToolOpenRouter() => IsFusionServerToolOpenRouter
            ? FusionServerToolOpenRouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FusionServerToolOpenRouter' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: generates images from text prompts using an image generation model
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ImageGenerationServerToolOpenRouter? ImageGenerationServerToolOpenRouter { get; init; }
#else
        public global::OpenRouter.ImageGenerationServerToolOpenRouter? ImageGenerationServerToolOpenRouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenerationServerToolOpenRouter))]
#endif
        public bool IsImageGenerationServerToolOpenRouter => ImageGenerationServerToolOpenRouter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageGenerationServerToolOpenRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ImageGenerationServerToolOpenRouter? value)
        {
            value = ImageGenerationServerToolOpenRouter;
            return IsImageGenerationServerToolOpenRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolOpenRouter PickImageGenerationServerToolOpenRouter() => IsImageGenerationServerToolOpenRouter
            ? ImageGenerationServerToolOpenRouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGenerationServerToolOpenRouter' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: searches and filters AI models available on OpenRouter
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatSearchModelsServerTool? ChatSearchModelsServerTool { get; init; }
#else
        public global::OpenRouter.ChatSearchModelsServerTool? ChatSearchModelsServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatSearchModelsServerTool))]
#endif
        public bool IsChatSearchModelsServerTool => ChatSearchModelsServerTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatSearchModelsServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatSearchModelsServerTool? value)
        {
            value = ChatSearchModelsServerTool;
            return IsChatSearchModelsServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatSearchModelsServerTool PickChatSearchModelsServerTool() => IsChatSearchModelsServerTool
            ? ChatSearchModelsServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatSearchModelsServerTool' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: delegates self-contained tasks to a smaller, cheaper, faster worker model (any OpenRouter model) mid-generation and returns its outcome. The worker may run as a sub-agent with its own tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.SubagentServerToolOpenRouter? SubagentServerToolOpenRouter { get; init; }
#else
        public global::OpenRouter.SubagentServerToolOpenRouter? SubagentServerToolOpenRouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubagentServerToolOpenRouter))]
#endif
        public bool IsSubagentServerToolOpenRouter => SubagentServerToolOpenRouter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSubagentServerToolOpenRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.SubagentServerToolOpenRouter? value)
        {
            value = SubagentServerToolOpenRouter;
            return IsSubagentServerToolOpenRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.SubagentServerToolOpenRouter PickSubagentServerToolOpenRouter() => IsSubagentServerToolOpenRouter
            ? SubagentServerToolOpenRouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubagentServerToolOpenRouter' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: fetches full content from a URL (web page or PDF)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.WebFetchServerTool? WebFetchServerTool { get; init; }
#else
        public global::OpenRouter.WebFetchServerTool? WebFetchServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebFetchServerTool))]
#endif
        public bool IsWebFetchServerTool => WebFetchServerTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebFetchServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.WebFetchServerTool? value)
        {
            value = WebFetchServerTool;
            return IsWebFetchServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.WebFetchServerTool PickWebFetchServerTool() => IsWebFetchServerTool
            ? WebFetchServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebFetchServerTool' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: searches the web for current information
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenRouterWebSearchServerTool? OpenRouterWebSearchServerTool { get; init; }
#else
        public global::OpenRouter.OpenRouterWebSearchServerTool? OpenRouterWebSearchServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenRouterWebSearchServerTool))]
#endif
        public bool IsOpenRouterWebSearchServerTool => OpenRouterWebSearchServerTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenRouterWebSearchServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenRouterWebSearchServerTool? value)
        {
            value = OpenRouterWebSearchServerTool;
            return IsOpenRouterWebSearchServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OpenRouterWebSearchServerTool PickOpenRouterWebSearchServerTool() => IsOpenRouterWebSearchServerTool
            ? OpenRouterWebSearchServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenRouterWebSearchServerTool' but the value was {ToString()}.");

        /// <summary>
        /// Web search tool using OpenAI Responses API syntax. Automatically converted to openrouter:web_search.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatWebSearchShorthand? ChatWebSearchShorthand { get; init; }
#else
        public global::OpenRouter.ChatWebSearchShorthand? ChatWebSearchShorthand { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatWebSearchShorthand))]
#endif
        public bool IsChatWebSearchShorthand => ChatWebSearchShorthand != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatWebSearchShorthand(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatWebSearchShorthand? value)
        {
            value = ChatWebSearchShorthand;
            return IsChatWebSearchShorthand;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatWebSearchShorthand PickChatWebSearchShorthand() => IsChatWebSearchShorthand
            ? ChatWebSearchShorthand!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatWebSearchShorthand' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.ChatFunctionTool0 value) => new ChatFunctionTool((global::OpenRouter.ChatFunctionTool0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatFunctionTool0?(ChatFunctionTool @this) => @this.ChatFunctionTool0;

        /// <summary>
        /// 
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.ChatFunctionTool0? value)
        {
            ChatFunctionTool0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatFunctionTool FromChatFunctionTool0(global::OpenRouter.ChatFunctionTool0? value) => new ChatFunctionTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.AdvisorServerToolOpenRouter value) => new ChatFunctionTool((global::OpenRouter.AdvisorServerToolOpenRouter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AdvisorServerToolOpenRouter?(ChatFunctionTool @this) => @this.AdvisorServerToolOpenRouter;

        /// <summary>
        /// 
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.AdvisorServerToolOpenRouter? value)
        {
            AdvisorServerToolOpenRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatFunctionTool FromAdvisorServerToolOpenRouter(global::OpenRouter.AdvisorServerToolOpenRouter? value) => new ChatFunctionTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.BashServerTool value) => new ChatFunctionTool((global::OpenRouter.BashServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.BashServerTool?(ChatFunctionTool @this) => @this.BashServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.BashServerTool? value)
        {
            BashServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatFunctionTool FromBashServerTool(global::OpenRouter.BashServerTool? value) => new ChatFunctionTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.DatetimeServerTool value) => new ChatFunctionTool((global::OpenRouter.DatetimeServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.DatetimeServerTool?(ChatFunctionTool @this) => @this.DatetimeServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.DatetimeServerTool? value)
        {
            DatetimeServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatFunctionTool FromDatetimeServerTool(global::OpenRouter.DatetimeServerTool? value) => new ChatFunctionTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.FilesServerTool value) => new ChatFunctionTool((global::OpenRouter.FilesServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.FilesServerTool?(ChatFunctionTool @this) => @this.FilesServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.FilesServerTool? value)
        {
            FilesServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatFunctionTool FromFilesServerTool(global::OpenRouter.FilesServerTool? value) => new ChatFunctionTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.FusionServerToolOpenRouter value) => new ChatFunctionTool((global::OpenRouter.FusionServerToolOpenRouter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.FusionServerToolOpenRouter?(ChatFunctionTool @this) => @this.FusionServerToolOpenRouter;

        /// <summary>
        /// 
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.FusionServerToolOpenRouter? value)
        {
            FusionServerToolOpenRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatFunctionTool FromFusionServerToolOpenRouter(global::OpenRouter.FusionServerToolOpenRouter? value) => new ChatFunctionTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.ImageGenerationServerToolOpenRouter value) => new ChatFunctionTool((global::OpenRouter.ImageGenerationServerToolOpenRouter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ImageGenerationServerToolOpenRouter?(ChatFunctionTool @this) => @this.ImageGenerationServerToolOpenRouter;

        /// <summary>
        /// 
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.ImageGenerationServerToolOpenRouter? value)
        {
            ImageGenerationServerToolOpenRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatFunctionTool FromImageGenerationServerToolOpenRouter(global::OpenRouter.ImageGenerationServerToolOpenRouter? value) => new ChatFunctionTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.ChatSearchModelsServerTool value) => new ChatFunctionTool((global::OpenRouter.ChatSearchModelsServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatSearchModelsServerTool?(ChatFunctionTool @this) => @this.ChatSearchModelsServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.ChatSearchModelsServerTool? value)
        {
            ChatSearchModelsServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatFunctionTool FromChatSearchModelsServerTool(global::OpenRouter.ChatSearchModelsServerTool? value) => new ChatFunctionTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.SubagentServerToolOpenRouter value) => new ChatFunctionTool((global::OpenRouter.SubagentServerToolOpenRouter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.SubagentServerToolOpenRouter?(ChatFunctionTool @this) => @this.SubagentServerToolOpenRouter;

        /// <summary>
        /// 
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.SubagentServerToolOpenRouter? value)
        {
            SubagentServerToolOpenRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatFunctionTool FromSubagentServerToolOpenRouter(global::OpenRouter.SubagentServerToolOpenRouter? value) => new ChatFunctionTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.WebFetchServerTool value) => new ChatFunctionTool((global::OpenRouter.WebFetchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.WebFetchServerTool?(ChatFunctionTool @this) => @this.WebFetchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.WebFetchServerTool? value)
        {
            WebFetchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatFunctionTool FromWebFetchServerTool(global::OpenRouter.WebFetchServerTool? value) => new ChatFunctionTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.OpenRouterWebSearchServerTool value) => new ChatFunctionTool((global::OpenRouter.OpenRouterWebSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OpenRouterWebSearchServerTool?(ChatFunctionTool @this) => @this.OpenRouterWebSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.OpenRouterWebSearchServerTool? value)
        {
            OpenRouterWebSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatFunctionTool FromOpenRouterWebSearchServerTool(global::OpenRouter.OpenRouterWebSearchServerTool? value) => new ChatFunctionTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatFunctionTool(global::OpenRouter.ChatWebSearchShorthand value) => new ChatFunctionTool((global::OpenRouter.ChatWebSearchShorthand?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatWebSearchShorthand?(ChatFunctionTool @this) => @this.ChatWebSearchShorthand;

        /// <summary>
        /// 
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.ChatWebSearchShorthand? value)
        {
            ChatWebSearchShorthand = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatFunctionTool FromChatWebSearchShorthand(global::OpenRouter.ChatWebSearchShorthand? value) => new ChatFunctionTool(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatFunctionTool(
            global::OpenRouter.ChatFunctionTool0? chatFunctionTool0,
            global::OpenRouter.AdvisorServerToolOpenRouter? advisorServerToolOpenRouter,
            global::OpenRouter.BashServerTool? bashServerTool,
            global::OpenRouter.DatetimeServerTool? datetimeServerTool,
            global::OpenRouter.FilesServerTool? filesServerTool,
            global::OpenRouter.FusionServerToolOpenRouter? fusionServerToolOpenRouter,
            global::OpenRouter.ImageGenerationServerToolOpenRouter? imageGenerationServerToolOpenRouter,
            global::OpenRouter.ChatSearchModelsServerTool? chatSearchModelsServerTool,
            global::OpenRouter.SubagentServerToolOpenRouter? subagentServerToolOpenRouter,
            global::OpenRouter.WebFetchServerTool? webFetchServerTool,
            global::OpenRouter.OpenRouterWebSearchServerTool? openRouterWebSearchServerTool,
            global::OpenRouter.ChatWebSearchShorthand? chatWebSearchShorthand
            )
        {
            ChatFunctionTool0 = chatFunctionTool0;
            AdvisorServerToolOpenRouter = advisorServerToolOpenRouter;
            BashServerTool = bashServerTool;
            DatetimeServerTool = datetimeServerTool;
            FilesServerTool = filesServerTool;
            FusionServerToolOpenRouter = fusionServerToolOpenRouter;
            ImageGenerationServerToolOpenRouter = imageGenerationServerToolOpenRouter;
            ChatSearchModelsServerTool = chatSearchModelsServerTool;
            SubagentServerToolOpenRouter = subagentServerToolOpenRouter;
            WebFetchServerTool = webFetchServerTool;
            OpenRouterWebSearchServerTool = openRouterWebSearchServerTool;
            ChatWebSearchShorthand = chatWebSearchShorthand;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatWebSearchShorthand as object ??
            OpenRouterWebSearchServerTool as object ??
            WebFetchServerTool as object ??
            SubagentServerToolOpenRouter as object ??
            ChatSearchModelsServerTool as object ??
            ImageGenerationServerToolOpenRouter as object ??
            FusionServerToolOpenRouter as object ??
            FilesServerTool as object ??
            DatetimeServerTool as object ??
            BashServerTool as object ??
            AdvisorServerToolOpenRouter as object ??
            ChatFunctionTool0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatFunctionTool0?.ToString() ??
            AdvisorServerToolOpenRouter?.ToString() ??
            BashServerTool?.ToString() ??
            DatetimeServerTool?.ToString() ??
            FilesServerTool?.ToString() ??
            FusionServerToolOpenRouter?.ToString() ??
            ImageGenerationServerToolOpenRouter?.ToString() ??
            ChatSearchModelsServerTool?.ToString() ??
            SubagentServerToolOpenRouter?.ToString() ??
            WebFetchServerTool?.ToString() ??
            OpenRouterWebSearchServerTool?.ToString() ??
            ChatWebSearchShorthand?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatFunctionTool0 && !IsAdvisorServerToolOpenRouter && !IsBashServerTool && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsSubagentServerToolOpenRouter && !IsWebFetchServerTool && !IsOpenRouterWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && IsAdvisorServerToolOpenRouter && !IsBashServerTool && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsSubagentServerToolOpenRouter && !IsWebFetchServerTool && !IsOpenRouterWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && !IsAdvisorServerToolOpenRouter && IsBashServerTool && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsSubagentServerToolOpenRouter && !IsWebFetchServerTool && !IsOpenRouterWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && !IsAdvisorServerToolOpenRouter && !IsBashServerTool && IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsSubagentServerToolOpenRouter && !IsWebFetchServerTool && !IsOpenRouterWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && !IsAdvisorServerToolOpenRouter && !IsBashServerTool && !IsDatetimeServerTool && IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsSubagentServerToolOpenRouter && !IsWebFetchServerTool && !IsOpenRouterWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && !IsAdvisorServerToolOpenRouter && !IsBashServerTool && !IsDatetimeServerTool && !IsFilesServerTool && IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsSubagentServerToolOpenRouter && !IsWebFetchServerTool && !IsOpenRouterWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && !IsAdvisorServerToolOpenRouter && !IsBashServerTool && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsSubagentServerToolOpenRouter && !IsWebFetchServerTool && !IsOpenRouterWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && !IsAdvisorServerToolOpenRouter && !IsBashServerTool && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && IsChatSearchModelsServerTool && !IsSubagentServerToolOpenRouter && !IsWebFetchServerTool && !IsOpenRouterWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && !IsAdvisorServerToolOpenRouter && !IsBashServerTool && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && IsSubagentServerToolOpenRouter && !IsWebFetchServerTool && !IsOpenRouterWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && !IsAdvisorServerToolOpenRouter && !IsBashServerTool && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsSubagentServerToolOpenRouter && IsWebFetchServerTool && !IsOpenRouterWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && !IsAdvisorServerToolOpenRouter && !IsBashServerTool && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsSubagentServerToolOpenRouter && !IsWebFetchServerTool && IsOpenRouterWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && !IsAdvisorServerToolOpenRouter && !IsBashServerTool && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsSubagentServerToolOpenRouter && !IsWebFetchServerTool && !IsOpenRouterWebSearchServerTool && IsChatWebSearchShorthand;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ChatFunctionTool0, TResult>? chatFunctionTool0 = null,
            global::System.Func<global::OpenRouter.AdvisorServerToolOpenRouter, TResult>? advisorServerToolOpenRouter = null,
            global::System.Func<global::OpenRouter.BashServerTool, TResult>? bashServerTool = null,
            global::System.Func<global::OpenRouter.DatetimeServerTool, TResult>? datetimeServerTool = null,
            global::System.Func<global::OpenRouter.FilesServerTool, TResult>? filesServerTool = null,
            global::System.Func<global::OpenRouter.FusionServerToolOpenRouter, TResult>? fusionServerToolOpenRouter = null,
            global::System.Func<global::OpenRouter.ImageGenerationServerToolOpenRouter, TResult>? imageGenerationServerToolOpenRouter = null,
            global::System.Func<global::OpenRouter.ChatSearchModelsServerTool, TResult>? chatSearchModelsServerTool = null,
            global::System.Func<global::OpenRouter.SubagentServerToolOpenRouter, TResult>? subagentServerToolOpenRouter = null,
            global::System.Func<global::OpenRouter.WebFetchServerTool, TResult>? webFetchServerTool = null,
            global::System.Func<global::OpenRouter.OpenRouterWebSearchServerTool, TResult>? openRouterWebSearchServerTool = null,
            global::System.Func<global::OpenRouter.ChatWebSearchShorthand, TResult>? chatWebSearchShorthand = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatFunctionTool0 && chatFunctionTool0 != null)
            {
                return chatFunctionTool0(ChatFunctionTool0!);
            }
            else if (IsAdvisorServerToolOpenRouter && advisorServerToolOpenRouter != null)
            {
                return advisorServerToolOpenRouter(AdvisorServerToolOpenRouter!);
            }
            else if (IsBashServerTool && bashServerTool != null)
            {
                return bashServerTool(BashServerTool!);
            }
            else if (IsDatetimeServerTool && datetimeServerTool != null)
            {
                return datetimeServerTool(DatetimeServerTool!);
            }
            else if (IsFilesServerTool && filesServerTool != null)
            {
                return filesServerTool(FilesServerTool!);
            }
            else if (IsFusionServerToolOpenRouter && fusionServerToolOpenRouter != null)
            {
                return fusionServerToolOpenRouter(FusionServerToolOpenRouter!);
            }
            else if (IsImageGenerationServerToolOpenRouter && imageGenerationServerToolOpenRouter != null)
            {
                return imageGenerationServerToolOpenRouter(ImageGenerationServerToolOpenRouter!);
            }
            else if (IsChatSearchModelsServerTool && chatSearchModelsServerTool != null)
            {
                return chatSearchModelsServerTool(ChatSearchModelsServerTool!);
            }
            else if (IsSubagentServerToolOpenRouter && subagentServerToolOpenRouter != null)
            {
                return subagentServerToolOpenRouter(SubagentServerToolOpenRouter!);
            }
            else if (IsWebFetchServerTool && webFetchServerTool != null)
            {
                return webFetchServerTool(WebFetchServerTool!);
            }
            else if (IsOpenRouterWebSearchServerTool && openRouterWebSearchServerTool != null)
            {
                return openRouterWebSearchServerTool(OpenRouterWebSearchServerTool!);
            }
            else if (IsChatWebSearchShorthand && chatWebSearchShorthand != null)
            {
                return chatWebSearchShorthand(ChatWebSearchShorthand!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ChatFunctionTool0>? chatFunctionTool0 = null,

            global::System.Action<global::OpenRouter.AdvisorServerToolOpenRouter>? advisorServerToolOpenRouter = null,

            global::System.Action<global::OpenRouter.BashServerTool>? bashServerTool = null,

            global::System.Action<global::OpenRouter.DatetimeServerTool>? datetimeServerTool = null,

            global::System.Action<global::OpenRouter.FilesServerTool>? filesServerTool = null,

            global::System.Action<global::OpenRouter.FusionServerToolOpenRouter>? fusionServerToolOpenRouter = null,

            global::System.Action<global::OpenRouter.ImageGenerationServerToolOpenRouter>? imageGenerationServerToolOpenRouter = null,

            global::System.Action<global::OpenRouter.ChatSearchModelsServerTool>? chatSearchModelsServerTool = null,

            global::System.Action<global::OpenRouter.SubagentServerToolOpenRouter>? subagentServerToolOpenRouter = null,

            global::System.Action<global::OpenRouter.WebFetchServerTool>? webFetchServerTool = null,

            global::System.Action<global::OpenRouter.OpenRouterWebSearchServerTool>? openRouterWebSearchServerTool = null,

            global::System.Action<global::OpenRouter.ChatWebSearchShorthand>? chatWebSearchShorthand = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatFunctionTool0)
            {
                chatFunctionTool0?.Invoke(ChatFunctionTool0!);
            }
            else if (IsAdvisorServerToolOpenRouter)
            {
                advisorServerToolOpenRouter?.Invoke(AdvisorServerToolOpenRouter!);
            }
            else if (IsBashServerTool)
            {
                bashServerTool?.Invoke(BashServerTool!);
            }
            else if (IsDatetimeServerTool)
            {
                datetimeServerTool?.Invoke(DatetimeServerTool!);
            }
            else if (IsFilesServerTool)
            {
                filesServerTool?.Invoke(FilesServerTool!);
            }
            else if (IsFusionServerToolOpenRouter)
            {
                fusionServerToolOpenRouter?.Invoke(FusionServerToolOpenRouter!);
            }
            else if (IsImageGenerationServerToolOpenRouter)
            {
                imageGenerationServerToolOpenRouter?.Invoke(ImageGenerationServerToolOpenRouter!);
            }
            else if (IsChatSearchModelsServerTool)
            {
                chatSearchModelsServerTool?.Invoke(ChatSearchModelsServerTool!);
            }
            else if (IsSubagentServerToolOpenRouter)
            {
                subagentServerToolOpenRouter?.Invoke(SubagentServerToolOpenRouter!);
            }
            else if (IsWebFetchServerTool)
            {
                webFetchServerTool?.Invoke(WebFetchServerTool!);
            }
            else if (IsOpenRouterWebSearchServerTool)
            {
                openRouterWebSearchServerTool?.Invoke(OpenRouterWebSearchServerTool!);
            }
            else if (IsChatWebSearchShorthand)
            {
                chatWebSearchShorthand?.Invoke(ChatWebSearchShorthand!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ChatFunctionTool0>? chatFunctionTool0 = null,
            global::System.Action<global::OpenRouter.AdvisorServerToolOpenRouter>? advisorServerToolOpenRouter = null,
            global::System.Action<global::OpenRouter.BashServerTool>? bashServerTool = null,
            global::System.Action<global::OpenRouter.DatetimeServerTool>? datetimeServerTool = null,
            global::System.Action<global::OpenRouter.FilesServerTool>? filesServerTool = null,
            global::System.Action<global::OpenRouter.FusionServerToolOpenRouter>? fusionServerToolOpenRouter = null,
            global::System.Action<global::OpenRouter.ImageGenerationServerToolOpenRouter>? imageGenerationServerToolOpenRouter = null,
            global::System.Action<global::OpenRouter.ChatSearchModelsServerTool>? chatSearchModelsServerTool = null,
            global::System.Action<global::OpenRouter.SubagentServerToolOpenRouter>? subagentServerToolOpenRouter = null,
            global::System.Action<global::OpenRouter.WebFetchServerTool>? webFetchServerTool = null,
            global::System.Action<global::OpenRouter.OpenRouterWebSearchServerTool>? openRouterWebSearchServerTool = null,
            global::System.Action<global::OpenRouter.ChatWebSearchShorthand>? chatWebSearchShorthand = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatFunctionTool0)
            {
                chatFunctionTool0?.Invoke(ChatFunctionTool0!);
            }
            else if (IsAdvisorServerToolOpenRouter)
            {
                advisorServerToolOpenRouter?.Invoke(AdvisorServerToolOpenRouter!);
            }
            else if (IsBashServerTool)
            {
                bashServerTool?.Invoke(BashServerTool!);
            }
            else if (IsDatetimeServerTool)
            {
                datetimeServerTool?.Invoke(DatetimeServerTool!);
            }
            else if (IsFilesServerTool)
            {
                filesServerTool?.Invoke(FilesServerTool!);
            }
            else if (IsFusionServerToolOpenRouter)
            {
                fusionServerToolOpenRouter?.Invoke(FusionServerToolOpenRouter!);
            }
            else if (IsImageGenerationServerToolOpenRouter)
            {
                imageGenerationServerToolOpenRouter?.Invoke(ImageGenerationServerToolOpenRouter!);
            }
            else if (IsChatSearchModelsServerTool)
            {
                chatSearchModelsServerTool?.Invoke(ChatSearchModelsServerTool!);
            }
            else if (IsSubagentServerToolOpenRouter)
            {
                subagentServerToolOpenRouter?.Invoke(SubagentServerToolOpenRouter!);
            }
            else if (IsWebFetchServerTool)
            {
                webFetchServerTool?.Invoke(WebFetchServerTool!);
            }
            else if (IsOpenRouterWebSearchServerTool)
            {
                openRouterWebSearchServerTool?.Invoke(OpenRouterWebSearchServerTool!);
            }
            else if (IsChatWebSearchShorthand)
            {
                chatWebSearchShorthand?.Invoke(ChatWebSearchShorthand!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatFunctionTool0,
                typeof(global::OpenRouter.ChatFunctionTool0),
                AdvisorServerToolOpenRouter,
                typeof(global::OpenRouter.AdvisorServerToolOpenRouter),
                BashServerTool,
                typeof(global::OpenRouter.BashServerTool),
                DatetimeServerTool,
                typeof(global::OpenRouter.DatetimeServerTool),
                FilesServerTool,
                typeof(global::OpenRouter.FilesServerTool),
                FusionServerToolOpenRouter,
                typeof(global::OpenRouter.FusionServerToolOpenRouter),
                ImageGenerationServerToolOpenRouter,
                typeof(global::OpenRouter.ImageGenerationServerToolOpenRouter),
                ChatSearchModelsServerTool,
                typeof(global::OpenRouter.ChatSearchModelsServerTool),
                SubagentServerToolOpenRouter,
                typeof(global::OpenRouter.SubagentServerToolOpenRouter),
                WebFetchServerTool,
                typeof(global::OpenRouter.WebFetchServerTool),
                OpenRouterWebSearchServerTool,
                typeof(global::OpenRouter.OpenRouterWebSearchServerTool),
                ChatWebSearchShorthand,
                typeof(global::OpenRouter.ChatWebSearchShorthand),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatFunctionTool0?>.Default.Equals(ChatFunctionTool0, other.ChatFunctionTool0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AdvisorServerToolOpenRouter?>.Default.Equals(AdvisorServerToolOpenRouter, other.AdvisorServerToolOpenRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BashServerTool?>.Default.Equals(BashServerTool, other.BashServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.DatetimeServerTool?>.Default.Equals(DatetimeServerTool, other.DatetimeServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FilesServerTool?>.Default.Equals(FilesServerTool, other.FilesServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FusionServerToolOpenRouter?>.Default.Equals(FusionServerToolOpenRouter, other.FusionServerToolOpenRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ImageGenerationServerToolOpenRouter?>.Default.Equals(ImageGenerationServerToolOpenRouter, other.ImageGenerationServerToolOpenRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatSearchModelsServerTool?>.Default.Equals(ChatSearchModelsServerTool, other.ChatSearchModelsServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.SubagentServerToolOpenRouter?>.Default.Equals(SubagentServerToolOpenRouter, other.SubagentServerToolOpenRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.WebFetchServerTool?>.Default.Equals(WebFetchServerTool, other.WebFetchServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenRouterWebSearchServerTool?>.Default.Equals(OpenRouterWebSearchServerTool, other.OpenRouterWebSearchServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatWebSearchShorthand?>.Default.Equals(ChatWebSearchShorthand, other.ChatWebSearchShorthand) 
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
