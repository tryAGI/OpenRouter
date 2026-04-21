#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatRequestPluginsItems : global::System.IEquatable<ChatRequestPluginsItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AutoRouterPlugin? AutoRouterPlugin { get; init; }
#else
        public global::OpenRouter.AutoRouterPlugin? AutoRouterPlugin { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoRouterPlugin))]
#endif
        public bool IsAutoRouterPlugin => AutoRouterPlugin != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModerationPlugin? ModerationPlugin { get; init; }
#else
        public global::OpenRouter.ModerationPlugin? ModerationPlugin { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModerationPlugin))]
#endif
        public bool IsModerationPlugin => ModerationPlugin != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.WebSearchPlugin? WebSearchPlugin { get; init; }
#else
        public global::OpenRouter.WebSearchPlugin? WebSearchPlugin { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchPlugin))]
#endif
        public bool IsWebSearchPlugin => WebSearchPlugin != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FileParserPlugin? FileParserPlugin { get; init; }
#else
        public global::OpenRouter.FileParserPlugin? FileParserPlugin { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileParserPlugin))]
#endif
        public bool IsFileParserPlugin => FileParserPlugin != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ResponseHealingPlugin? ResponseHealingPlugin { get; init; }
#else
        public global::OpenRouter.ResponseHealingPlugin? ResponseHealingPlugin { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseHealingPlugin))]
#endif
        public bool IsResponseHealingPlugin => ResponseHealingPlugin != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContextCompressionPlugin? ContextCompressionPlugin { get; init; }
#else
        public global::OpenRouter.ContextCompressionPlugin? ContextCompressionPlugin { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContextCompressionPlugin))]
#endif
        public bool IsContextCompressionPlugin => ContextCompressionPlugin != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ParetoRouterPlugin? ParetoRouterPlugin { get; init; }
#else
        public global::OpenRouter.ParetoRouterPlugin? ParetoRouterPlugin { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ParetoRouterPlugin))]
#endif
        public bool IsParetoRouterPlugin => ParetoRouterPlugin != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.AutoRouterPlugin value) => new ChatRequestPluginsItems((global::OpenRouter.AutoRouterPlugin?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AutoRouterPlugin?(ChatRequestPluginsItems @this) => @this.AutoRouterPlugin;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.AutoRouterPlugin? value)
        {
            AutoRouterPlugin = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ModerationPlugin value) => new ChatRequestPluginsItems((global::OpenRouter.ModerationPlugin?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ModerationPlugin?(ChatRequestPluginsItems @this) => @this.ModerationPlugin;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ModerationPlugin? value)
        {
            ModerationPlugin = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.WebSearchPlugin value) => new ChatRequestPluginsItems((global::OpenRouter.WebSearchPlugin?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.WebSearchPlugin?(ChatRequestPluginsItems @this) => @this.WebSearchPlugin;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.WebSearchPlugin? value)
        {
            WebSearchPlugin = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.FileParserPlugin value) => new ChatRequestPluginsItems((global::OpenRouter.FileParserPlugin?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.FileParserPlugin?(ChatRequestPluginsItems @this) => @this.FileParserPlugin;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.FileParserPlugin? value)
        {
            FileParserPlugin = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ResponseHealingPlugin value) => new ChatRequestPluginsItems((global::OpenRouter.ResponseHealingPlugin?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ResponseHealingPlugin?(ChatRequestPluginsItems @this) => @this.ResponseHealingPlugin;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ResponseHealingPlugin? value)
        {
            ResponseHealingPlugin = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ContextCompressionPlugin value) => new ChatRequestPluginsItems((global::OpenRouter.ContextCompressionPlugin?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ContextCompressionPlugin?(ChatRequestPluginsItems @this) => @this.ContextCompressionPlugin;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ContextCompressionPlugin? value)
        {
            ContextCompressionPlugin = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ParetoRouterPlugin value) => new ChatRequestPluginsItems((global::OpenRouter.ParetoRouterPlugin?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ParetoRouterPlugin?(ChatRequestPluginsItems @this) => @this.ParetoRouterPlugin;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ParetoRouterPlugin? value)
        {
            ParetoRouterPlugin = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(
            global::OpenRouter.AutoRouterPlugin? autoRouterPlugin,
            global::OpenRouter.ModerationPlugin? moderationPlugin,
            global::OpenRouter.WebSearchPlugin? webSearchPlugin,
            global::OpenRouter.FileParserPlugin? fileParserPlugin,
            global::OpenRouter.ResponseHealingPlugin? responseHealingPlugin,
            global::OpenRouter.ContextCompressionPlugin? contextCompressionPlugin,
            global::OpenRouter.ParetoRouterPlugin? paretoRouterPlugin
            )
        {
            AutoRouterPlugin = autoRouterPlugin;
            ModerationPlugin = moderationPlugin;
            WebSearchPlugin = webSearchPlugin;
            FileParserPlugin = fileParserPlugin;
            ResponseHealingPlugin = responseHealingPlugin;
            ContextCompressionPlugin = contextCompressionPlugin;
            ParetoRouterPlugin = paretoRouterPlugin;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ParetoRouterPlugin as object ??
            ContextCompressionPlugin as object ??
            ResponseHealingPlugin as object ??
            FileParserPlugin as object ??
            WebSearchPlugin as object ??
            ModerationPlugin as object ??
            AutoRouterPlugin as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AutoRouterPlugin?.ToString() ??
            ModerationPlugin?.ToString() ??
            WebSearchPlugin?.ToString() ??
            FileParserPlugin?.ToString() ??
            ResponseHealingPlugin?.ToString() ??
            ContextCompressionPlugin?.ToString() ??
            ParetoRouterPlugin?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAutoRouterPlugin && !IsModerationPlugin && !IsWebSearchPlugin && !IsFileParserPlugin && !IsResponseHealingPlugin && !IsContextCompressionPlugin && !IsParetoRouterPlugin || !IsAutoRouterPlugin && IsModerationPlugin && !IsWebSearchPlugin && !IsFileParserPlugin && !IsResponseHealingPlugin && !IsContextCompressionPlugin && !IsParetoRouterPlugin || !IsAutoRouterPlugin && !IsModerationPlugin && IsWebSearchPlugin && !IsFileParserPlugin && !IsResponseHealingPlugin && !IsContextCompressionPlugin && !IsParetoRouterPlugin || !IsAutoRouterPlugin && !IsModerationPlugin && !IsWebSearchPlugin && IsFileParserPlugin && !IsResponseHealingPlugin && !IsContextCompressionPlugin && !IsParetoRouterPlugin || !IsAutoRouterPlugin && !IsModerationPlugin && !IsWebSearchPlugin && !IsFileParserPlugin && IsResponseHealingPlugin && !IsContextCompressionPlugin && !IsParetoRouterPlugin || !IsAutoRouterPlugin && !IsModerationPlugin && !IsWebSearchPlugin && !IsFileParserPlugin && !IsResponseHealingPlugin && IsContextCompressionPlugin && !IsParetoRouterPlugin || !IsAutoRouterPlugin && !IsModerationPlugin && !IsWebSearchPlugin && !IsFileParserPlugin && !IsResponseHealingPlugin && !IsContextCompressionPlugin && IsParetoRouterPlugin;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AutoRouterPlugin?, TResult>? autoRouterPlugin = null,
            global::System.Func<global::OpenRouter.ModerationPlugin?, TResult>? moderationPlugin = null,
            global::System.Func<global::OpenRouter.WebSearchPlugin?, TResult>? webSearchPlugin = null,
            global::System.Func<global::OpenRouter.FileParserPlugin?, TResult>? fileParserPlugin = null,
            global::System.Func<global::OpenRouter.ResponseHealingPlugin?, TResult>? responseHealingPlugin = null,
            global::System.Func<global::OpenRouter.ContextCompressionPlugin?, TResult>? contextCompressionPlugin = null,
            global::System.Func<global::OpenRouter.ParetoRouterPlugin?, TResult>? paretoRouterPlugin = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoRouterPlugin && autoRouterPlugin != null)
            {
                return autoRouterPlugin(AutoRouterPlugin!);
            }
            else if (IsModerationPlugin && moderationPlugin != null)
            {
                return moderationPlugin(ModerationPlugin!);
            }
            else if (IsWebSearchPlugin && webSearchPlugin != null)
            {
                return webSearchPlugin(WebSearchPlugin!);
            }
            else if (IsFileParserPlugin && fileParserPlugin != null)
            {
                return fileParserPlugin(FileParserPlugin!);
            }
            else if (IsResponseHealingPlugin && responseHealingPlugin != null)
            {
                return responseHealingPlugin(ResponseHealingPlugin!);
            }
            else if (IsContextCompressionPlugin && contextCompressionPlugin != null)
            {
                return contextCompressionPlugin(ContextCompressionPlugin!);
            }
            else if (IsParetoRouterPlugin && paretoRouterPlugin != null)
            {
                return paretoRouterPlugin(ParetoRouterPlugin!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AutoRouterPlugin?>? autoRouterPlugin = null,
            global::System.Action<global::OpenRouter.ModerationPlugin?>? moderationPlugin = null,
            global::System.Action<global::OpenRouter.WebSearchPlugin?>? webSearchPlugin = null,
            global::System.Action<global::OpenRouter.FileParserPlugin?>? fileParserPlugin = null,
            global::System.Action<global::OpenRouter.ResponseHealingPlugin?>? responseHealingPlugin = null,
            global::System.Action<global::OpenRouter.ContextCompressionPlugin?>? contextCompressionPlugin = null,
            global::System.Action<global::OpenRouter.ParetoRouterPlugin?>? paretoRouterPlugin = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoRouterPlugin)
            {
                autoRouterPlugin?.Invoke(AutoRouterPlugin!);
            }
            else if (IsModerationPlugin)
            {
                moderationPlugin?.Invoke(ModerationPlugin!);
            }
            else if (IsWebSearchPlugin)
            {
                webSearchPlugin?.Invoke(WebSearchPlugin!);
            }
            else if (IsFileParserPlugin)
            {
                fileParserPlugin?.Invoke(FileParserPlugin!);
            }
            else if (IsResponseHealingPlugin)
            {
                responseHealingPlugin?.Invoke(ResponseHealingPlugin!);
            }
            else if (IsContextCompressionPlugin)
            {
                contextCompressionPlugin?.Invoke(ContextCompressionPlugin!);
            }
            else if (IsParetoRouterPlugin)
            {
                paretoRouterPlugin?.Invoke(ParetoRouterPlugin!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AutoRouterPlugin,
                typeof(global::OpenRouter.AutoRouterPlugin),
                ModerationPlugin,
                typeof(global::OpenRouter.ModerationPlugin),
                WebSearchPlugin,
                typeof(global::OpenRouter.WebSearchPlugin),
                FileParserPlugin,
                typeof(global::OpenRouter.FileParserPlugin),
                ResponseHealingPlugin,
                typeof(global::OpenRouter.ResponseHealingPlugin),
                ContextCompressionPlugin,
                typeof(global::OpenRouter.ContextCompressionPlugin),
                ParetoRouterPlugin,
                typeof(global::OpenRouter.ParetoRouterPlugin),
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
        public bool Equals(ChatRequestPluginsItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AutoRouterPlugin?>.Default.Equals(AutoRouterPlugin, other.AutoRouterPlugin) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModerationPlugin?>.Default.Equals(ModerationPlugin, other.ModerationPlugin) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.WebSearchPlugin?>.Default.Equals(WebSearchPlugin, other.WebSearchPlugin) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FileParserPlugin?>.Default.Equals(FileParserPlugin, other.FileParserPlugin) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ResponseHealingPlugin?>.Default.Equals(ResponseHealingPlugin, other.ResponseHealingPlugin) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContextCompressionPlugin?>.Default.Equals(ContextCompressionPlugin, other.ContextCompressionPlugin) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ParetoRouterPlugin?>.Default.Equals(ParetoRouterPlugin, other.ParetoRouterPlugin) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatRequestPluginsItems obj1, ChatRequestPluginsItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatRequestPluginsItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatRequestPluginsItems obj1, ChatRequestPluginsItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatRequestPluginsItems o && Equals(o);
        }
    }
}
