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
        /// OpenRouter built-in server tool: searches the web for current information
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatWebSearchServerTool? ChatWebSearchServerTool { get; init; }
#else
        public global::OpenRouter.ChatWebSearchServerTool? ChatWebSearchServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatWebSearchServerTool))]
#endif
        public bool IsChatWebSearchServerTool => ChatWebSearchServerTool != null;

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
        public static implicit operator ChatFunctionTool(global::OpenRouter.ChatWebSearchServerTool value) => new ChatFunctionTool((global::OpenRouter.ChatWebSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatWebSearchServerTool?(ChatFunctionTool @this) => @this.ChatWebSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ChatFunctionTool(global::OpenRouter.ChatWebSearchServerTool? value)
        {
            ChatWebSearchServerTool = value;
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
            global::OpenRouter.ChatWebSearchServerTool? chatWebSearchServerTool,
            global::OpenRouter.ChatWebSearchShorthand? chatWebSearchShorthand
            )
        {
            ChatFunctionTool0 = chatFunctionTool0;
            DatetimeServerTool = datetimeServerTool;
            ChatWebSearchServerTool = chatWebSearchServerTool;
            ChatWebSearchShorthand = chatWebSearchShorthand;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatWebSearchShorthand as object ??
            ChatWebSearchServerTool as object ??
            DatetimeServerTool as object ??
            ChatFunctionTool0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatFunctionTool0?.ToString() ??
            DatetimeServerTool?.ToString() ??
            ChatWebSearchServerTool?.ToString() ??
            ChatWebSearchShorthand?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatFunctionTool0 && !IsDatetimeServerTool && !IsChatWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && IsDatetimeServerTool && !IsChatWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && !IsDatetimeServerTool && IsChatWebSearchServerTool && !IsChatWebSearchShorthand || !IsChatFunctionTool0 && !IsDatetimeServerTool && !IsChatWebSearchServerTool && IsChatWebSearchShorthand;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ChatFunctionTool0?, TResult>? chatFunctionTool0 = null,
            global::System.Func<global::OpenRouter.DatetimeServerTool?, TResult>? datetimeServerTool = null,
            global::System.Func<global::OpenRouter.ChatWebSearchServerTool?, TResult>? chatWebSearchServerTool = null,
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
            else if (IsChatWebSearchServerTool && chatWebSearchServerTool != null)
            {
                return chatWebSearchServerTool(ChatWebSearchServerTool!);
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
            global::System.Action<global::OpenRouter.ChatWebSearchServerTool?>? chatWebSearchServerTool = null,
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
            else if (IsChatWebSearchServerTool)
            {
                chatWebSearchServerTool?.Invoke(ChatWebSearchServerTool!);
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
                ChatWebSearchServerTool,
                typeof(global::OpenRouter.ChatWebSearchServerTool),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatWebSearchServerTool?>.Default.Equals(ChatWebSearchServerTool, other.ChatWebSearchServerTool) &&
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
