#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Tool choice configuration<br/>
    /// Example: auto
    /// </summary>
    public readonly partial struct ChatToolChoice : global::System.IEquatable<ChatToolChoice>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatToolChoiceVariant1? ChatToolChoiceVariant1 { get; init; }
#else
        public global::OpenRouter.ChatToolChoiceVariant1? ChatToolChoiceVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatToolChoiceVariant1))]
#endif
        public bool IsChatToolChoiceVariant1 => ChatToolChoiceVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChatToolChoiceVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatToolChoiceVariant1? value)
        {
            value = ChatToolChoiceVariant1;
            return IsChatToolChoiceVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolChoiceVariant1 PickChatToolChoiceVariant1() => ChatToolChoiceVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatToolChoiceVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatToolChoiceVariant2? ChatToolChoiceVariant2 { get; init; }
#else
        public global::OpenRouter.ChatToolChoiceVariant2? ChatToolChoiceVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatToolChoiceVariant2))]
#endif
        public bool IsChatToolChoiceVariant2 => ChatToolChoiceVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChatToolChoiceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatToolChoiceVariant2? value)
        {
            value = ChatToolChoiceVariant2;
            return IsChatToolChoiceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolChoiceVariant2 PickChatToolChoiceVariant2() => ChatToolChoiceVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatToolChoiceVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatToolChoiceVariant3? ChatToolChoiceVariant3 { get; init; }
#else
        public global::OpenRouter.ChatToolChoiceVariant3? ChatToolChoiceVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatToolChoiceVariant3))]
#endif
        public bool IsChatToolChoiceVariant3 => ChatToolChoiceVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChatToolChoiceVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatToolChoiceVariant3? value)
        {
            value = ChatToolChoiceVariant3;
            return IsChatToolChoiceVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolChoiceVariant3 PickChatToolChoiceVariant3() => ChatToolChoiceVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatToolChoiceVariant3' but the value was {ToString()}.");

        /// <summary>
        /// Named tool choice for specific function<br/>
        /// Example: {"function":{"name":"get_weather"},"type":"function"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatNamedToolChoice? Named { get; init; }
#else
        public global::OpenRouter.ChatNamedToolChoice? Named { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Named))]
#endif
        public bool IsNamed => Named != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNamed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatNamedToolChoice? value)
        {
            value = Named;
            return IsNamed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatNamedToolChoice PickNamed() => Named is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Named' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter extension: force a specific server tool by naming it directly in `tool_choice.type` instead of wrapping it in `{ type: "function", function: { name } }`.<br/>
        /// Example: {"type":"openrouter:web_search"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatServerToolChoice? Server { get; init; }
#else
        public global::OpenRouter.ChatServerToolChoice? Server { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Server))]
#endif
        public bool IsServer => Server != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickServer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatServerToolChoice? value)
        {
            value = Server;
            return IsServer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatServerToolChoice PickServer() => Server is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Server' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatToolChoice(global::OpenRouter.ChatToolChoiceVariant1 value) => new ChatToolChoice((global::OpenRouter.ChatToolChoiceVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatToolChoiceVariant1?(ChatToolChoice @this) => @this.ChatToolChoiceVariant1;

        /// <summary>
        ///
        /// </summary>
        public ChatToolChoice(global::OpenRouter.ChatToolChoiceVariant1? value)
        {
            ChatToolChoiceVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatToolChoice FromChatToolChoiceVariant1(global::OpenRouter.ChatToolChoiceVariant1? value) => new ChatToolChoice(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatToolChoice(global::OpenRouter.ChatToolChoiceVariant2 value) => new ChatToolChoice((global::OpenRouter.ChatToolChoiceVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatToolChoiceVariant2?(ChatToolChoice @this) => @this.ChatToolChoiceVariant2;

        /// <summary>
        ///
        /// </summary>
        public ChatToolChoice(global::OpenRouter.ChatToolChoiceVariant2? value)
        {
            ChatToolChoiceVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatToolChoice FromChatToolChoiceVariant2(global::OpenRouter.ChatToolChoiceVariant2? value) => new ChatToolChoice(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatToolChoice(global::OpenRouter.ChatToolChoiceVariant3 value) => new ChatToolChoice((global::OpenRouter.ChatToolChoiceVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatToolChoiceVariant3?(ChatToolChoice @this) => @this.ChatToolChoiceVariant3;

        /// <summary>
        ///
        /// </summary>
        public ChatToolChoice(global::OpenRouter.ChatToolChoiceVariant3? value)
        {
            ChatToolChoiceVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatToolChoice FromChatToolChoiceVariant3(global::OpenRouter.ChatToolChoiceVariant3? value) => new ChatToolChoice(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatToolChoice(global::OpenRouter.ChatNamedToolChoice value) => new ChatToolChoice((global::OpenRouter.ChatNamedToolChoice?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatNamedToolChoice?(ChatToolChoice @this) => @this.Named;

        /// <summary>
        ///
        /// </summary>
        public ChatToolChoice(global::OpenRouter.ChatNamedToolChoice? value)
        {
            Named = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatToolChoice FromNamed(global::OpenRouter.ChatNamedToolChoice? value) => new ChatToolChoice(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatToolChoice(global::OpenRouter.ChatServerToolChoice value) => new ChatToolChoice((global::OpenRouter.ChatServerToolChoice?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatServerToolChoice?(ChatToolChoice @this) => @this.Server;

        /// <summary>
        ///
        /// </summary>
        public ChatToolChoice(global::OpenRouter.ChatServerToolChoice? value)
        {
            Server = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatToolChoice FromServer(global::OpenRouter.ChatServerToolChoice? value) => new ChatToolChoice(value);

        /// <summary>
        ///
        /// </summary>
        public ChatToolChoice(
            global::OpenRouter.ChatToolChoiceVariant1? chatToolChoiceVariant1,
            global::OpenRouter.ChatToolChoiceVariant2? chatToolChoiceVariant2,
            global::OpenRouter.ChatToolChoiceVariant3? chatToolChoiceVariant3,
            global::OpenRouter.ChatNamedToolChoice? named,
            global::OpenRouter.ChatServerToolChoice? server
            )
        {
            ChatToolChoiceVariant1 = chatToolChoiceVariant1;
            ChatToolChoiceVariant2 = chatToolChoiceVariant2;
            ChatToolChoiceVariant3 = chatToolChoiceVariant3;
            Named = named;
            Server = server;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Server as object ??
            Named as object ??
            ChatToolChoiceVariant3 as object ??
            ChatToolChoiceVariant2 as object ??
            ChatToolChoiceVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ChatToolChoiceVariant1?.ToValueString() ??
            ChatToolChoiceVariant2?.ToValueString() ??
            ChatToolChoiceVariant3?.ToValueString() ??
            Named?.ToString() ??
            Server?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsChatToolChoiceVariant1 || IsChatToolChoiceVariant2 || IsChatToolChoiceVariant3 || IsNamed || IsServer;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ChatToolChoiceVariant1?, TResult>? chatToolChoiceVariant1 = null,
            global::System.Func<global::OpenRouter.ChatToolChoiceVariant2?, TResult>? chatToolChoiceVariant2 = null,
            global::System.Func<global::OpenRouter.ChatToolChoiceVariant3?, TResult>? chatToolChoiceVariant3 = null,
            global::System.Func<global::OpenRouter.ChatNamedToolChoice, TResult>? named = null,
            global::System.Func<global::OpenRouter.ChatServerToolChoice, TResult>? server = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ChatToolChoiceVariant1 is { } __value0 && chatToolChoiceVariant1 != null)
            {
                return chatToolChoiceVariant1(__value0);
            }
            else if (ChatToolChoiceVariant2 is { } __value1 && chatToolChoiceVariant2 != null)
            {
                return chatToolChoiceVariant2(__value1);
            }
            else if (ChatToolChoiceVariant3 is { } __value2 && chatToolChoiceVariant3 != null)
            {
                return chatToolChoiceVariant3(__value2);
            }
            else if (Named is { } __value3 && named != null)
            {
                return named(__value3);
            }
            else if (Server is { } __value4 && server != null)
            {
                return server(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ChatToolChoiceVariant1?>? chatToolChoiceVariant1 = null,

            global::System.Action<global::OpenRouter.ChatToolChoiceVariant2?>? chatToolChoiceVariant2 = null,

            global::System.Action<global::OpenRouter.ChatToolChoiceVariant3?>? chatToolChoiceVariant3 = null,

            global::System.Action<global::OpenRouter.ChatNamedToolChoice>? named = null,

            global::System.Action<global::OpenRouter.ChatServerToolChoice>? server = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ChatToolChoiceVariant1 is { } __value0)
            {
                chatToolChoiceVariant1?.Invoke(__value0);
            }
            else if (ChatToolChoiceVariant2 is { } __value1)
            {
                chatToolChoiceVariant2?.Invoke(__value1);
            }
            else if (ChatToolChoiceVariant3 is { } __value2)
            {
                chatToolChoiceVariant3?.Invoke(__value2);
            }
            else if (Named is { } __value3)
            {
                named?.Invoke(__value3);
            }
            else if (Server is { } __value4)
            {
                server?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ChatToolChoiceVariant1?>? chatToolChoiceVariant1 = null,
            global::System.Action<global::OpenRouter.ChatToolChoiceVariant2?>? chatToolChoiceVariant2 = null,
            global::System.Action<global::OpenRouter.ChatToolChoiceVariant3?>? chatToolChoiceVariant3 = null,
            global::System.Action<global::OpenRouter.ChatNamedToolChoice>? named = null,
            global::System.Action<global::OpenRouter.ChatServerToolChoice>? server = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ChatToolChoiceVariant1 is { } __value0)
            {
                chatToolChoiceVariant1?.Invoke(__value0);
            }
            else if (ChatToolChoiceVariant2 is { } __value1)
            {
                chatToolChoiceVariant2?.Invoke(__value1);
            }
            else if (ChatToolChoiceVariant3 is { } __value2)
            {
                chatToolChoiceVariant3?.Invoke(__value2);
            }
            else if (Named is { } __value3)
            {
                named?.Invoke(__value3);
            }
            else if (Server is { } __value4)
            {
                server?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatToolChoiceVariant1,
                typeof(global::OpenRouter.ChatToolChoiceVariant1),
                ChatToolChoiceVariant2,
                typeof(global::OpenRouter.ChatToolChoiceVariant2),
                ChatToolChoiceVariant3,
                typeof(global::OpenRouter.ChatToolChoiceVariant3),
                Named,
                typeof(global::OpenRouter.ChatNamedToolChoice),
                Server,
                typeof(global::OpenRouter.ChatServerToolChoice),
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
        public bool Equals(ChatToolChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatToolChoiceVariant1?>.Default.Equals(ChatToolChoiceVariant1, other.ChatToolChoiceVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatToolChoiceVariant2?>.Default.Equals(ChatToolChoiceVariant2, other.ChatToolChoiceVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatToolChoiceVariant3?>.Default.Equals(ChatToolChoiceVariant3, other.ChatToolChoiceVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatNamedToolChoice?>.Default.Equals(Named, other.Named) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatServerToolChoice?>.Default.Equals(Server, other.Server)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ChatToolChoice obj1, ChatToolChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatToolChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChatToolChoice obj1, ChatToolChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatToolChoice o && Equals(o);
        }
    }
}
