#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesResultUsageIterationsItems : global::System.IEquatable<MessagesResultUsageIterationsItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesResultUsageIterationsItems0? MessagesResultUsageIterationsItems0 { get; init; }
#else
        public global::OpenRouter.MessagesResultUsageIterationsItems0? MessagesResultUsageIterationsItems0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesResultUsageIterationsItems0))]
#endif
        public bool IsMessagesResultUsageIterationsItems0 => MessagesResultUsageIterationsItems0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesResultUsageIterationsItems1? MessagesResultUsageIterationsItems1 { get; init; }
#else
        public global::OpenRouter.MessagesResultUsageIterationsItems1? MessagesResultUsageIterationsItems1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesResultUsageIterationsItems1))]
#endif
        public bool IsMessagesResultUsageIterationsItems1 => MessagesResultUsageIterationsItems1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesResultUsageIterationsItems2? MessagesResultUsageIterationsItems2 { get; init; }
#else
        public global::OpenRouter.MessagesResultUsageIterationsItems2? MessagesResultUsageIterationsItems2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesResultUsageIterationsItems2))]
#endif
        public bool IsMessagesResultUsageIterationsItems2 => MessagesResultUsageIterationsItems2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesResultUsageIterationsItems(global::OpenRouter.MessagesResultUsageIterationsItems0 value) => new MessagesResultUsageIterationsItems((global::OpenRouter.MessagesResultUsageIterationsItems0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesResultUsageIterationsItems0?(MessagesResultUsageIterationsItems @this) => @this.MessagesResultUsageIterationsItems0;

        /// <summary>
        /// 
        /// </summary>
        public MessagesResultUsageIterationsItems(global::OpenRouter.MessagesResultUsageIterationsItems0? value)
        {
            MessagesResultUsageIterationsItems0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesResultUsageIterationsItems(global::OpenRouter.MessagesResultUsageIterationsItems1 value) => new MessagesResultUsageIterationsItems((global::OpenRouter.MessagesResultUsageIterationsItems1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesResultUsageIterationsItems1?(MessagesResultUsageIterationsItems @this) => @this.MessagesResultUsageIterationsItems1;

        /// <summary>
        /// 
        /// </summary>
        public MessagesResultUsageIterationsItems(global::OpenRouter.MessagesResultUsageIterationsItems1? value)
        {
            MessagesResultUsageIterationsItems1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesResultUsageIterationsItems(global::OpenRouter.MessagesResultUsageIterationsItems2 value) => new MessagesResultUsageIterationsItems((global::OpenRouter.MessagesResultUsageIterationsItems2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesResultUsageIterationsItems2?(MessagesResultUsageIterationsItems @this) => @this.MessagesResultUsageIterationsItems2;

        /// <summary>
        /// 
        /// </summary>
        public MessagesResultUsageIterationsItems(global::OpenRouter.MessagesResultUsageIterationsItems2? value)
        {
            MessagesResultUsageIterationsItems2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesResultUsageIterationsItems(
            global::OpenRouter.MessagesResultUsageIterationsItems0? messagesResultUsageIterationsItems0,
            global::OpenRouter.MessagesResultUsageIterationsItems1? messagesResultUsageIterationsItems1,
            global::OpenRouter.MessagesResultUsageIterationsItems2? messagesResultUsageIterationsItems2
            )
        {
            MessagesResultUsageIterationsItems0 = messagesResultUsageIterationsItems0;
            MessagesResultUsageIterationsItems1 = messagesResultUsageIterationsItems1;
            MessagesResultUsageIterationsItems2 = messagesResultUsageIterationsItems2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesResultUsageIterationsItems2 as object ??
            MessagesResultUsageIterationsItems1 as object ??
            MessagesResultUsageIterationsItems0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessagesResultUsageIterationsItems0?.ToString() ??
            MessagesResultUsageIterationsItems1?.ToString() ??
            MessagesResultUsageIterationsItems2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessagesResultUsageIterationsItems0 && !IsMessagesResultUsageIterationsItems1 && !IsMessagesResultUsageIterationsItems2 || !IsMessagesResultUsageIterationsItems0 && IsMessagesResultUsageIterationsItems1 && !IsMessagesResultUsageIterationsItems2 || !IsMessagesResultUsageIterationsItems0 && !IsMessagesResultUsageIterationsItems1 && IsMessagesResultUsageIterationsItems2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.MessagesResultUsageIterationsItems0?, TResult>? messagesResultUsageIterationsItems0 = null,
            global::System.Func<global::OpenRouter.MessagesResultUsageIterationsItems1?, TResult>? messagesResultUsageIterationsItems1 = null,
            global::System.Func<global::OpenRouter.MessagesResultUsageIterationsItems2?, TResult>? messagesResultUsageIterationsItems2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesResultUsageIterationsItems0 && messagesResultUsageIterationsItems0 != null)
            {
                return messagesResultUsageIterationsItems0(MessagesResultUsageIterationsItems0!);
            }
            else if (IsMessagesResultUsageIterationsItems1 && messagesResultUsageIterationsItems1 != null)
            {
                return messagesResultUsageIterationsItems1(MessagesResultUsageIterationsItems1!);
            }
            else if (IsMessagesResultUsageIterationsItems2 && messagesResultUsageIterationsItems2 != null)
            {
                return messagesResultUsageIterationsItems2(MessagesResultUsageIterationsItems2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.MessagesResultUsageIterationsItems0?>? messagesResultUsageIterationsItems0 = null,
            global::System.Action<global::OpenRouter.MessagesResultUsageIterationsItems1?>? messagesResultUsageIterationsItems1 = null,
            global::System.Action<global::OpenRouter.MessagesResultUsageIterationsItems2?>? messagesResultUsageIterationsItems2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesResultUsageIterationsItems0)
            {
                messagesResultUsageIterationsItems0?.Invoke(MessagesResultUsageIterationsItems0!);
            }
            else if (IsMessagesResultUsageIterationsItems1)
            {
                messagesResultUsageIterationsItems1?.Invoke(MessagesResultUsageIterationsItems1!);
            }
            else if (IsMessagesResultUsageIterationsItems2)
            {
                messagesResultUsageIterationsItems2?.Invoke(MessagesResultUsageIterationsItems2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessagesResultUsageIterationsItems0,
                typeof(global::OpenRouter.MessagesResultUsageIterationsItems0),
                MessagesResultUsageIterationsItems1,
                typeof(global::OpenRouter.MessagesResultUsageIterationsItems1),
                MessagesResultUsageIterationsItems2,
                typeof(global::OpenRouter.MessagesResultUsageIterationsItems2),
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
        public bool Equals(MessagesResultUsageIterationsItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesResultUsageIterationsItems0?>.Default.Equals(MessagesResultUsageIterationsItems0, other.MessagesResultUsageIterationsItems0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesResultUsageIterationsItems1?>.Default.Equals(MessagesResultUsageIterationsItems1, other.MessagesResultUsageIterationsItems1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesResultUsageIterationsItems2?>.Default.Equals(MessagesResultUsageIterationsItems2, other.MessagesResultUsageIterationsItems2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesResultUsageIterationsItems obj1, MessagesResultUsageIterationsItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesResultUsageIterationsItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesResultUsageIterationsItems obj1, MessagesResultUsageIterationsItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesResultUsageIterationsItems o && Equals(o);
        }
    }
}
