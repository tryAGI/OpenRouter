#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Response format configuration
    /// </summary>
    public readonly partial struct ChatRequestResponseFormat : global::System.IEquatable<ChatRequestResponseFormat>
    {
        /// <summary>
        /// Default text response format
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatFormatTextConfig? ChatFormatTextConfig { get; init; }
#else
        public global::OpenRouter.ChatFormatTextConfig? ChatFormatTextConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatFormatTextConfig))]
#endif
        public bool IsChatFormatTextConfig => ChatFormatTextConfig != null;

        /// <summary>
        /// JSON object response format
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FormatJsonObjectConfig? FormatJsonObjectConfig { get; init; }
#else
        public global::OpenRouter.FormatJsonObjectConfig? FormatJsonObjectConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FormatJsonObjectConfig))]
#endif
        public bool IsFormatJsonObjectConfig => FormatJsonObjectConfig != null;

        /// <summary>
        /// JSON Schema response format for structured outputs
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatFormatJsonSchemaConfig? ChatFormatJsonSchemaConfig { get; init; }
#else
        public global::OpenRouter.ChatFormatJsonSchemaConfig? ChatFormatJsonSchemaConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatFormatJsonSchemaConfig))]
#endif
        public bool IsChatFormatJsonSchemaConfig => ChatFormatJsonSchemaConfig != null;

        /// <summary>
        /// Custom grammar response format
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatFormatGrammarConfig? ChatFormatGrammarConfig { get; init; }
#else
        public global::OpenRouter.ChatFormatGrammarConfig? ChatFormatGrammarConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatFormatGrammarConfig))]
#endif
        public bool IsChatFormatGrammarConfig => ChatFormatGrammarConfig != null;

        /// <summary>
        /// Python code response format
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatFormatPythonConfig? ChatFormatPythonConfig { get; init; }
#else
        public global::OpenRouter.ChatFormatPythonConfig? ChatFormatPythonConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatFormatPythonConfig))]
#endif
        public bool IsChatFormatPythonConfig => ChatFormatPythonConfig != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestResponseFormat(global::OpenRouter.ChatFormatTextConfig value) => new ChatRequestResponseFormat((global::OpenRouter.ChatFormatTextConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatFormatTextConfig?(ChatRequestResponseFormat @this) => @this.ChatFormatTextConfig;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestResponseFormat(global::OpenRouter.ChatFormatTextConfig? value)
        {
            ChatFormatTextConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestResponseFormat(global::OpenRouter.FormatJsonObjectConfig value) => new ChatRequestResponseFormat((global::OpenRouter.FormatJsonObjectConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.FormatJsonObjectConfig?(ChatRequestResponseFormat @this) => @this.FormatJsonObjectConfig;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestResponseFormat(global::OpenRouter.FormatJsonObjectConfig? value)
        {
            FormatJsonObjectConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestResponseFormat(global::OpenRouter.ChatFormatJsonSchemaConfig value) => new ChatRequestResponseFormat((global::OpenRouter.ChatFormatJsonSchemaConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatFormatJsonSchemaConfig?(ChatRequestResponseFormat @this) => @this.ChatFormatJsonSchemaConfig;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestResponseFormat(global::OpenRouter.ChatFormatJsonSchemaConfig? value)
        {
            ChatFormatJsonSchemaConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestResponseFormat(global::OpenRouter.ChatFormatGrammarConfig value) => new ChatRequestResponseFormat((global::OpenRouter.ChatFormatGrammarConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatFormatGrammarConfig?(ChatRequestResponseFormat @this) => @this.ChatFormatGrammarConfig;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestResponseFormat(global::OpenRouter.ChatFormatGrammarConfig? value)
        {
            ChatFormatGrammarConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestResponseFormat(global::OpenRouter.ChatFormatPythonConfig value) => new ChatRequestResponseFormat((global::OpenRouter.ChatFormatPythonConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatFormatPythonConfig?(ChatRequestResponseFormat @this) => @this.ChatFormatPythonConfig;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestResponseFormat(global::OpenRouter.ChatFormatPythonConfig? value)
        {
            ChatFormatPythonConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestResponseFormat(
            global::OpenRouter.ChatFormatTextConfig? chatFormatTextConfig,
            global::OpenRouter.FormatJsonObjectConfig? formatJsonObjectConfig,
            global::OpenRouter.ChatFormatJsonSchemaConfig? chatFormatJsonSchemaConfig,
            global::OpenRouter.ChatFormatGrammarConfig? chatFormatGrammarConfig,
            global::OpenRouter.ChatFormatPythonConfig? chatFormatPythonConfig
            )
        {
            ChatFormatTextConfig = chatFormatTextConfig;
            FormatJsonObjectConfig = formatJsonObjectConfig;
            ChatFormatJsonSchemaConfig = chatFormatJsonSchemaConfig;
            ChatFormatGrammarConfig = chatFormatGrammarConfig;
            ChatFormatPythonConfig = chatFormatPythonConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatFormatPythonConfig as object ??
            ChatFormatGrammarConfig as object ??
            ChatFormatJsonSchemaConfig as object ??
            FormatJsonObjectConfig as object ??
            ChatFormatTextConfig as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatFormatTextConfig?.ToString() ??
            FormatJsonObjectConfig?.ToString() ??
            ChatFormatJsonSchemaConfig?.ToString() ??
            ChatFormatGrammarConfig?.ToString() ??
            ChatFormatPythonConfig?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatFormatTextConfig && !IsFormatJsonObjectConfig && !IsChatFormatJsonSchemaConfig && !IsChatFormatGrammarConfig && !IsChatFormatPythonConfig || !IsChatFormatTextConfig && IsFormatJsonObjectConfig && !IsChatFormatJsonSchemaConfig && !IsChatFormatGrammarConfig && !IsChatFormatPythonConfig || !IsChatFormatTextConfig && !IsFormatJsonObjectConfig && IsChatFormatJsonSchemaConfig && !IsChatFormatGrammarConfig && !IsChatFormatPythonConfig || !IsChatFormatTextConfig && !IsFormatJsonObjectConfig && !IsChatFormatJsonSchemaConfig && IsChatFormatGrammarConfig && !IsChatFormatPythonConfig || !IsChatFormatTextConfig && !IsFormatJsonObjectConfig && !IsChatFormatJsonSchemaConfig && !IsChatFormatGrammarConfig && IsChatFormatPythonConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ChatFormatTextConfig?, TResult>? chatFormatTextConfig = null,
            global::System.Func<global::OpenRouter.FormatJsonObjectConfig?, TResult>? formatJsonObjectConfig = null,
            global::System.Func<global::OpenRouter.ChatFormatJsonSchemaConfig?, TResult>? chatFormatJsonSchemaConfig = null,
            global::System.Func<global::OpenRouter.ChatFormatGrammarConfig?, TResult>? chatFormatGrammarConfig = null,
            global::System.Func<global::OpenRouter.ChatFormatPythonConfig?, TResult>? chatFormatPythonConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatFormatTextConfig && chatFormatTextConfig != null)
            {
                return chatFormatTextConfig(ChatFormatTextConfig!);
            }
            else if (IsFormatJsonObjectConfig && formatJsonObjectConfig != null)
            {
                return formatJsonObjectConfig(FormatJsonObjectConfig!);
            }
            else if (IsChatFormatJsonSchemaConfig && chatFormatJsonSchemaConfig != null)
            {
                return chatFormatJsonSchemaConfig(ChatFormatJsonSchemaConfig!);
            }
            else if (IsChatFormatGrammarConfig && chatFormatGrammarConfig != null)
            {
                return chatFormatGrammarConfig(ChatFormatGrammarConfig!);
            }
            else if (IsChatFormatPythonConfig && chatFormatPythonConfig != null)
            {
                return chatFormatPythonConfig(ChatFormatPythonConfig!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ChatFormatTextConfig?>? chatFormatTextConfig = null,
            global::System.Action<global::OpenRouter.FormatJsonObjectConfig?>? formatJsonObjectConfig = null,
            global::System.Action<global::OpenRouter.ChatFormatJsonSchemaConfig?>? chatFormatJsonSchemaConfig = null,
            global::System.Action<global::OpenRouter.ChatFormatGrammarConfig?>? chatFormatGrammarConfig = null,
            global::System.Action<global::OpenRouter.ChatFormatPythonConfig?>? chatFormatPythonConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatFormatTextConfig)
            {
                chatFormatTextConfig?.Invoke(ChatFormatTextConfig!);
            }
            else if (IsFormatJsonObjectConfig)
            {
                formatJsonObjectConfig?.Invoke(FormatJsonObjectConfig!);
            }
            else if (IsChatFormatJsonSchemaConfig)
            {
                chatFormatJsonSchemaConfig?.Invoke(ChatFormatJsonSchemaConfig!);
            }
            else if (IsChatFormatGrammarConfig)
            {
                chatFormatGrammarConfig?.Invoke(ChatFormatGrammarConfig!);
            }
            else if (IsChatFormatPythonConfig)
            {
                chatFormatPythonConfig?.Invoke(ChatFormatPythonConfig!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatFormatTextConfig,
                typeof(global::OpenRouter.ChatFormatTextConfig),
                FormatJsonObjectConfig,
                typeof(global::OpenRouter.FormatJsonObjectConfig),
                ChatFormatJsonSchemaConfig,
                typeof(global::OpenRouter.ChatFormatJsonSchemaConfig),
                ChatFormatGrammarConfig,
                typeof(global::OpenRouter.ChatFormatGrammarConfig),
                ChatFormatPythonConfig,
                typeof(global::OpenRouter.ChatFormatPythonConfig),
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
        public bool Equals(ChatRequestResponseFormat other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatFormatTextConfig?>.Default.Equals(ChatFormatTextConfig, other.ChatFormatTextConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FormatJsonObjectConfig?>.Default.Equals(FormatJsonObjectConfig, other.FormatJsonObjectConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatFormatJsonSchemaConfig?>.Default.Equals(ChatFormatJsonSchemaConfig, other.ChatFormatJsonSchemaConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatFormatGrammarConfig?>.Default.Equals(ChatFormatGrammarConfig, other.ChatFormatGrammarConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatFormatPythonConfig?>.Default.Equals(ChatFormatPythonConfig, other.ChatFormatPythonConfig) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatRequestResponseFormat obj1, ChatRequestResponseFormat obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatRequestResponseFormat>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatRequestResponseFormat obj1, ChatRequestResponseFormat obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatRequestResponseFormat o && Equals(o);
        }
    }
}
