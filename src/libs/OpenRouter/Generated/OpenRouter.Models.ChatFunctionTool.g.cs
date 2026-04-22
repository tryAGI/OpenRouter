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
        public ChatFunctionTool(
            global::OpenRouter.ChatFunctionTool0? chatFunctionTool0,
            global::OpenRouter.DatetimeServerTool? datetimeServerTool,
            global::OpenRouter.ImageGenerationServerToolOpenRouter? imageGenerationServerToolOpenRouter,
            global::OpenRouter.ChatSearchModelsServerTool? chatSearchModelsServerTool,
            global::OpenRouter.WebFetchServerTool? webFetchServerTool,
            global::OpenRouter.OpenRouterWebSearchServerTool? openRouterWebSearchServerTool,
            global::OpenRouter.ChatWebSearchShorthand? chatWebSearchShorthand
            )
        {
            ChatFunctionTool0 = chatFunctionTool0;
            DatetimeServerTool = datetimeServerTool;
            ImageGenerationServerToolOpenRouter = imageGenerationServerToolOpenRouter;
            ChatSearchModelsServerTool = chatSearchModelsServerTool;
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
            ChatSearchModelsServerTool as object ??
            ImageGenerationServerToolOpenRouter as object ??
            DatetimeServerTool as object ??
            ChatFunctionTool0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatFunctionTool0?.ToString() ??
            DatetimeServerTool?.ToString() ??
            ImageGenerationServerToolOpenRouter?.ToString() ??
            ChatSearchModelsServerTool?.ToString() ??
            WebFetchServerTool?.ToString() ??
            OpenRouterWebSearchServerTool?.ToString() ??
            ChatWebSearchShorthand?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatFunctionTool0 && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsOpenRouterWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsOpenRouterWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && !IsDatetimeServerTool && IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsOpenRouterWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsOpenRouterWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && IsWebFetchServerTool && !IsOpenRouterWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && IsOpenRouterWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsOpenRouterWebSearchServerTool && IsChatWebSearchShorthand;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ChatFunctionTool0?, TResult>? chatFunctionTool0 = null,
            global::System.Func<global::OpenRouter.DatetimeServerTool?, TResult>? datetimeServerTool = null,
            global::System.Func<global::OpenRouter.ImageGenerationServerToolOpenRouter?, TResult>? imageGenerationServerToolOpenRouter = null,
            global::System.Func<global::OpenRouter.ChatSearchModelsServerTool?, TResult>? chatSearchModelsServerTool = null,
            global::System.Func<global::OpenRouter.WebFetchServerTool?, TResult>? webFetchServerTool = null,
            global::System.Func<global::OpenRouter.OpenRouterWebSearchServerTool?, TResult>? openRouterWebSearchServerTool = null,
            global::System.Func<global::OpenRouter.ChatWebSearchShorthand?, TResult>? chatWebSearchShorthand = null,
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
            else if (IsDatetimeServerTool && datetimeServerTool != null)
            {
                return datetimeServerTool(DatetimeServerTool!);
            }
            else if (IsImageGenerationServerToolOpenRouter && imageGenerationServerToolOpenRouter != null)
            {
                return imageGenerationServerToolOpenRouter(ImageGenerationServerToolOpenRouter!);
            }
            else if (IsChatSearchModelsServerTool && chatSearchModelsServerTool != null)
            {
                return chatSearchModelsServerTool(ChatSearchModelsServerTool!);
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
            global::System.Action<global::OpenRouter.ChatFunctionTool0?>? chatFunctionTool0 = null,
            global::System.Action<global::OpenRouter.DatetimeServerTool?>? datetimeServerTool = null,
            global::System.Action<global::OpenRouter.ImageGenerationServerToolOpenRouter?>? imageGenerationServerToolOpenRouter = null,
            global::System.Action<global::OpenRouter.ChatSearchModelsServerTool?>? chatSearchModelsServerTool = null,
            global::System.Action<global::OpenRouter.WebFetchServerTool?>? webFetchServerTool = null,
            global::System.Action<global::OpenRouter.OpenRouterWebSearchServerTool?>? openRouterWebSearchServerTool = null,
            global::System.Action<global::OpenRouter.ChatWebSearchShorthand?>? chatWebSearchShorthand = null,
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
            else if (IsDatetimeServerTool)
            {
                datetimeServerTool?.Invoke(DatetimeServerTool!);
            }
            else if (IsImageGenerationServerToolOpenRouter)
            {
                imageGenerationServerToolOpenRouter?.Invoke(ImageGenerationServerToolOpenRouter!);
            }
            else if (IsChatSearchModelsServerTool)
            {
                chatSearchModelsServerTool?.Invoke(ChatSearchModelsServerTool!);
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
                DatetimeServerTool,
                typeof(global::OpenRouter.DatetimeServerTool),
                ImageGenerationServerToolOpenRouter,
                typeof(global::OpenRouter.ImageGenerationServerToolOpenRouter),
                ChatSearchModelsServerTool,
                typeof(global::OpenRouter.ChatSearchModelsServerTool),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.DatetimeServerTool?>.Default.Equals(DatetimeServerTool, other.DatetimeServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ImageGenerationServerToolOpenRouter?>.Default.Equals(ImageGenerationServerToolOpenRouter, other.ImageGenerationServerToolOpenRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatSearchModelsServerTool?>.Default.Equals(ChatSearchModelsServerTool, other.ChatSearchModelsServerTool) &&
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
