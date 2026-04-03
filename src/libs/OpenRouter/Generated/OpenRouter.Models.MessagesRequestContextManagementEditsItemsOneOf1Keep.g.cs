#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesRequestContextManagementEditsItemsOneOf1Keep : global::System.IEquatable<MessagesRequestContextManagementEditsItemsOneOf1Keep>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicThinkingTurns? AnthropicThinkingTurns { get; init; }
#else
        public global::OpenRouter.AnthropicThinkingTurns? AnthropicThinkingTurns { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicThinkingTurns))]
#endif
        public bool IsAnthropicThinkingTurns => AnthropicThinkingTurns != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep1? MessagesRequestContextManagementEditsItemsOneOf1Keep1 { get; init; }
#else
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep1? MessagesRequestContextManagementEditsItemsOneOf1Keep1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestContextManagementEditsItemsOneOf1Keep1))]
#endif
        public bool IsMessagesRequestContextManagementEditsItemsOneOf1Keep1 => MessagesRequestContextManagementEditsItemsOneOf1Keep1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep2? MessagesRequestContextManagementEditsItemsOneOf1Keep2 { get; init; }
#else
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep2? MessagesRequestContextManagementEditsItemsOneOf1Keep2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestContextManagementEditsItemsOneOf1Keep2))]
#endif
        public bool IsMessagesRequestContextManagementEditsItemsOneOf1Keep2 => MessagesRequestContextManagementEditsItemsOneOf1Keep2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestContextManagementEditsItemsOneOf1Keep(global::OpenRouter.AnthropicThinkingTurns value) => new MessagesRequestContextManagementEditsItemsOneOf1Keep((global::OpenRouter.AnthropicThinkingTurns?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicThinkingTurns?(MessagesRequestContextManagementEditsItemsOneOf1Keep @this) => @this.AnthropicThinkingTurns;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf1Keep(global::OpenRouter.AnthropicThinkingTurns? value)
        {
            AnthropicThinkingTurns = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestContextManagementEditsItemsOneOf1Keep(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep1 value) => new MessagesRequestContextManagementEditsItemsOneOf1Keep((global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep1?(MessagesRequestContextManagementEditsItemsOneOf1Keep @this) => @this.MessagesRequestContextManagementEditsItemsOneOf1Keep1;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf1Keep(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep1? value)
        {
            MessagesRequestContextManagementEditsItemsOneOf1Keep1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestContextManagementEditsItemsOneOf1Keep(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep2 value) => new MessagesRequestContextManagementEditsItemsOneOf1Keep((global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep2?(MessagesRequestContextManagementEditsItemsOneOf1Keep @this) => @this.MessagesRequestContextManagementEditsItemsOneOf1Keep2;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf1Keep(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep2? value)
        {
            MessagesRequestContextManagementEditsItemsOneOf1Keep2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf1Keep(
            global::OpenRouter.AnthropicThinkingTurns? anthropicThinkingTurns,
            global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep1? messagesRequestContextManagementEditsItemsOneOf1Keep1,
            global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep2? messagesRequestContextManagementEditsItemsOneOf1Keep2
            )
        {
            AnthropicThinkingTurns = anthropicThinkingTurns;
            MessagesRequestContextManagementEditsItemsOneOf1Keep1 = messagesRequestContextManagementEditsItemsOneOf1Keep1;
            MessagesRequestContextManagementEditsItemsOneOf1Keep2 = messagesRequestContextManagementEditsItemsOneOf1Keep2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesRequestContextManagementEditsItemsOneOf1Keep2 as object ??
            MessagesRequestContextManagementEditsItemsOneOf1Keep1 as object ??
            AnthropicThinkingTurns as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicThinkingTurns?.ToString() ??
            MessagesRequestContextManagementEditsItemsOneOf1Keep1?.ToString() ??
            MessagesRequestContextManagementEditsItemsOneOf1Keep2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicThinkingTurns && !IsMessagesRequestContextManagementEditsItemsOneOf1Keep1 && !IsMessagesRequestContextManagementEditsItemsOneOf1Keep2 || !IsAnthropicThinkingTurns && IsMessagesRequestContextManagementEditsItemsOneOf1Keep1 && !IsMessagesRequestContextManagementEditsItemsOneOf1Keep2 || !IsAnthropicThinkingTurns && !IsMessagesRequestContextManagementEditsItemsOneOf1Keep1 && IsMessagesRequestContextManagementEditsItemsOneOf1Keep2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicThinkingTurns?, TResult>? anthropicThinkingTurns = null,
            global::System.Func<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep1?, TResult>? messagesRequestContextManagementEditsItemsOneOf1Keep1 = null,
            global::System.Func<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep2?, TResult>? messagesRequestContextManagementEditsItemsOneOf1Keep2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicThinkingTurns && anthropicThinkingTurns != null)
            {
                return anthropicThinkingTurns(AnthropicThinkingTurns!);
            }
            else if (IsMessagesRequestContextManagementEditsItemsOneOf1Keep1 && messagesRequestContextManagementEditsItemsOneOf1Keep1 != null)
            {
                return messagesRequestContextManagementEditsItemsOneOf1Keep1(MessagesRequestContextManagementEditsItemsOneOf1Keep1!);
            }
            else if (IsMessagesRequestContextManagementEditsItemsOneOf1Keep2 && messagesRequestContextManagementEditsItemsOneOf1Keep2 != null)
            {
                return messagesRequestContextManagementEditsItemsOneOf1Keep2(MessagesRequestContextManagementEditsItemsOneOf1Keep2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicThinkingTurns?>? anthropicThinkingTurns = null,
            global::System.Action<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep1?>? messagesRequestContextManagementEditsItemsOneOf1Keep1 = null,
            global::System.Action<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep2?>? messagesRequestContextManagementEditsItemsOneOf1Keep2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicThinkingTurns)
            {
                anthropicThinkingTurns?.Invoke(AnthropicThinkingTurns!);
            }
            else if (IsMessagesRequestContextManagementEditsItemsOneOf1Keep1)
            {
                messagesRequestContextManagementEditsItemsOneOf1Keep1?.Invoke(MessagesRequestContextManagementEditsItemsOneOf1Keep1!);
            }
            else if (IsMessagesRequestContextManagementEditsItemsOneOf1Keep2)
            {
                messagesRequestContextManagementEditsItemsOneOf1Keep2?.Invoke(MessagesRequestContextManagementEditsItemsOneOf1Keep2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicThinkingTurns,
                typeof(global::OpenRouter.AnthropicThinkingTurns),
                MessagesRequestContextManagementEditsItemsOneOf1Keep1,
                typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep1),
                MessagesRequestContextManagementEditsItemsOneOf1Keep2,
                typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep2),
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
        public bool Equals(MessagesRequestContextManagementEditsItemsOneOf1Keep other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicThinkingTurns?>.Default.Equals(AnthropicThinkingTurns, other.AnthropicThinkingTurns) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep1?>.Default.Equals(MessagesRequestContextManagementEditsItemsOneOf1Keep1, other.MessagesRequestContextManagementEditsItemsOneOf1Keep1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep2?>.Default.Equals(MessagesRequestContextManagementEditsItemsOneOf1Keep2, other.MessagesRequestContextManagementEditsItemsOneOf1Keep2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesRequestContextManagementEditsItemsOneOf1Keep obj1, MessagesRequestContextManagementEditsItemsOneOf1Keep obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesRequestContextManagementEditsItemsOneOf1Keep>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesRequestContextManagementEditsItemsOneOf1Keep obj1, MessagesRequestContextManagementEditsItemsOneOf1Keep obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesRequestContextManagementEditsItemsOneOf1Keep o && Equals(o);
        }
    }
}
