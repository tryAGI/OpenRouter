#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesRequestContextManagementEditsItems : global::System.IEquatable<MessagesRequestContextManagementEditsItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesRequestContextManagementEditsItems0? MessagesRequestContextManagementEditsItems0 { get; init; }
#else
        public global::OpenRouter.MessagesRequestContextManagementEditsItems0? MessagesRequestContextManagementEditsItems0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestContextManagementEditsItems0))]
#endif
        public bool IsMessagesRequestContextManagementEditsItems0 => MessagesRequestContextManagementEditsItems0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesRequestContextManagementEditsItems1? MessagesRequestContextManagementEditsItems1 { get; init; }
#else
        public global::OpenRouter.MessagesRequestContextManagementEditsItems1? MessagesRequestContextManagementEditsItems1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestContextManagementEditsItems1))]
#endif
        public bool IsMessagesRequestContextManagementEditsItems1 => MessagesRequestContextManagementEditsItems1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesRequestContextManagementEditsItems2? MessagesRequestContextManagementEditsItems2 { get; init; }
#else
        public global::OpenRouter.MessagesRequestContextManagementEditsItems2? MessagesRequestContextManagementEditsItems2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestContextManagementEditsItems2))]
#endif
        public bool IsMessagesRequestContextManagementEditsItems2 => MessagesRequestContextManagementEditsItems2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestContextManagementEditsItems(global::OpenRouter.MessagesRequestContextManagementEditsItems0 value) => new MessagesRequestContextManagementEditsItems((global::OpenRouter.MessagesRequestContextManagementEditsItems0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesRequestContextManagementEditsItems0?(MessagesRequestContextManagementEditsItems @this) => @this.MessagesRequestContextManagementEditsItems0;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItems(global::OpenRouter.MessagesRequestContextManagementEditsItems0? value)
        {
            MessagesRequestContextManagementEditsItems0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestContextManagementEditsItems(global::OpenRouter.MessagesRequestContextManagementEditsItems1 value) => new MessagesRequestContextManagementEditsItems((global::OpenRouter.MessagesRequestContextManagementEditsItems1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesRequestContextManagementEditsItems1?(MessagesRequestContextManagementEditsItems @this) => @this.MessagesRequestContextManagementEditsItems1;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItems(global::OpenRouter.MessagesRequestContextManagementEditsItems1? value)
        {
            MessagesRequestContextManagementEditsItems1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestContextManagementEditsItems(global::OpenRouter.MessagesRequestContextManagementEditsItems2 value) => new MessagesRequestContextManagementEditsItems((global::OpenRouter.MessagesRequestContextManagementEditsItems2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesRequestContextManagementEditsItems2?(MessagesRequestContextManagementEditsItems @this) => @this.MessagesRequestContextManagementEditsItems2;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItems(global::OpenRouter.MessagesRequestContextManagementEditsItems2? value)
        {
            MessagesRequestContextManagementEditsItems2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItems(
            global::OpenRouter.MessagesRequestContextManagementEditsItems0? messagesRequestContextManagementEditsItems0,
            global::OpenRouter.MessagesRequestContextManagementEditsItems1? messagesRequestContextManagementEditsItems1,
            global::OpenRouter.MessagesRequestContextManagementEditsItems2? messagesRequestContextManagementEditsItems2
            )
        {
            MessagesRequestContextManagementEditsItems0 = messagesRequestContextManagementEditsItems0;
            MessagesRequestContextManagementEditsItems1 = messagesRequestContextManagementEditsItems1;
            MessagesRequestContextManagementEditsItems2 = messagesRequestContextManagementEditsItems2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesRequestContextManagementEditsItems2 as object ??
            MessagesRequestContextManagementEditsItems1 as object ??
            MessagesRequestContextManagementEditsItems0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessagesRequestContextManagementEditsItems0?.ToString() ??
            MessagesRequestContextManagementEditsItems1?.ToString() ??
            MessagesRequestContextManagementEditsItems2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessagesRequestContextManagementEditsItems0 && !IsMessagesRequestContextManagementEditsItems1 && !IsMessagesRequestContextManagementEditsItems2 || !IsMessagesRequestContextManagementEditsItems0 && IsMessagesRequestContextManagementEditsItems1 && !IsMessagesRequestContextManagementEditsItems2 || !IsMessagesRequestContextManagementEditsItems0 && !IsMessagesRequestContextManagementEditsItems1 && IsMessagesRequestContextManagementEditsItems2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.MessagesRequestContextManagementEditsItems0?, TResult>? messagesRequestContextManagementEditsItems0 = null,
            global::System.Func<global::OpenRouter.MessagesRequestContextManagementEditsItems1?, TResult>? messagesRequestContextManagementEditsItems1 = null,
            global::System.Func<global::OpenRouter.MessagesRequestContextManagementEditsItems2?, TResult>? messagesRequestContextManagementEditsItems2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesRequestContextManagementEditsItems0 && messagesRequestContextManagementEditsItems0 != null)
            {
                return messagesRequestContextManagementEditsItems0(MessagesRequestContextManagementEditsItems0!);
            }
            else if (IsMessagesRequestContextManagementEditsItems1 && messagesRequestContextManagementEditsItems1 != null)
            {
                return messagesRequestContextManagementEditsItems1(MessagesRequestContextManagementEditsItems1!);
            }
            else if (IsMessagesRequestContextManagementEditsItems2 && messagesRequestContextManagementEditsItems2 != null)
            {
                return messagesRequestContextManagementEditsItems2(MessagesRequestContextManagementEditsItems2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.MessagesRequestContextManagementEditsItems0?>? messagesRequestContextManagementEditsItems0 = null,
            global::System.Action<global::OpenRouter.MessagesRequestContextManagementEditsItems1?>? messagesRequestContextManagementEditsItems1 = null,
            global::System.Action<global::OpenRouter.MessagesRequestContextManagementEditsItems2?>? messagesRequestContextManagementEditsItems2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesRequestContextManagementEditsItems0)
            {
                messagesRequestContextManagementEditsItems0?.Invoke(MessagesRequestContextManagementEditsItems0!);
            }
            else if (IsMessagesRequestContextManagementEditsItems1)
            {
                messagesRequestContextManagementEditsItems1?.Invoke(MessagesRequestContextManagementEditsItems1!);
            }
            else if (IsMessagesRequestContextManagementEditsItems2)
            {
                messagesRequestContextManagementEditsItems2?.Invoke(MessagesRequestContextManagementEditsItems2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessagesRequestContextManagementEditsItems0,
                typeof(global::OpenRouter.MessagesRequestContextManagementEditsItems0),
                MessagesRequestContextManagementEditsItems1,
                typeof(global::OpenRouter.MessagesRequestContextManagementEditsItems1),
                MessagesRequestContextManagementEditsItems2,
                typeof(global::OpenRouter.MessagesRequestContextManagementEditsItems2),
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
        public bool Equals(MessagesRequestContextManagementEditsItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesRequestContextManagementEditsItems0?>.Default.Equals(MessagesRequestContextManagementEditsItems0, other.MessagesRequestContextManagementEditsItems0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesRequestContextManagementEditsItems1?>.Default.Equals(MessagesRequestContextManagementEditsItems1, other.MessagesRequestContextManagementEditsItems1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesRequestContextManagementEditsItems2?>.Default.Equals(MessagesRequestContextManagementEditsItems2, other.MessagesRequestContextManagementEditsItems2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesRequestContextManagementEditsItems obj1, MessagesRequestContextManagementEditsItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesRequestContextManagementEditsItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesRequestContextManagementEditsItems obj1, MessagesRequestContextManagementEditsItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesRequestContextManagementEditsItems o && Equals(o);
        }
    }
}
