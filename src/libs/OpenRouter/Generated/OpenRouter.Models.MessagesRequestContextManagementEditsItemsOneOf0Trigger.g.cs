#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesRequestContextManagementEditsItemsOneOf0Trigger : global::System.IEquatable<MessagesRequestContextManagementEditsItemsOneOf0Trigger>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicInputTokensTrigger? AnthropicInputTokensTrigger { get; init; }
#else
        public global::OpenRouter.AnthropicInputTokensTrigger? AnthropicInputTokensTrigger { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicInputTokensTrigger))]
#endif
        public bool IsAnthropicInputTokensTrigger => AnthropicInputTokensTrigger != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicToolUsesKeep? AnthropicToolUsesKeep { get; init; }
#else
        public global::OpenRouter.AnthropicToolUsesKeep? AnthropicToolUsesKeep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicToolUsesKeep))]
#endif
        public bool IsAnthropicToolUsesKeep => AnthropicToolUsesKeep != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestContextManagementEditsItemsOneOf0Trigger(global::OpenRouter.AnthropicInputTokensTrigger value) => new MessagesRequestContextManagementEditsItemsOneOf0Trigger((global::OpenRouter.AnthropicInputTokensTrigger?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicInputTokensTrigger?(MessagesRequestContextManagementEditsItemsOneOf0Trigger @this) => @this.AnthropicInputTokensTrigger;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf0Trigger(global::OpenRouter.AnthropicInputTokensTrigger? value)
        {
            AnthropicInputTokensTrigger = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestContextManagementEditsItemsOneOf0Trigger(global::OpenRouter.AnthropicToolUsesKeep value) => new MessagesRequestContextManagementEditsItemsOneOf0Trigger((global::OpenRouter.AnthropicToolUsesKeep?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicToolUsesKeep?(MessagesRequestContextManagementEditsItemsOneOf0Trigger @this) => @this.AnthropicToolUsesKeep;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf0Trigger(global::OpenRouter.AnthropicToolUsesKeep? value)
        {
            AnthropicToolUsesKeep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf0Trigger(
            global::OpenRouter.AnthropicInputTokensTrigger? anthropicInputTokensTrigger,
            global::OpenRouter.AnthropicToolUsesKeep? anthropicToolUsesKeep
            )
        {
            AnthropicInputTokensTrigger = anthropicInputTokensTrigger;
            AnthropicToolUsesKeep = anthropicToolUsesKeep;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicToolUsesKeep as object ??
            AnthropicInputTokensTrigger as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicInputTokensTrigger?.ToString() ??
            AnthropicToolUsesKeep?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicInputTokensTrigger && !IsAnthropicToolUsesKeep || !IsAnthropicInputTokensTrigger && IsAnthropicToolUsesKeep;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicInputTokensTrigger?, TResult>? anthropicInputTokensTrigger = null,
            global::System.Func<global::OpenRouter.AnthropicToolUsesKeep?, TResult>? anthropicToolUsesKeep = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicInputTokensTrigger && anthropicInputTokensTrigger != null)
            {
                return anthropicInputTokensTrigger(AnthropicInputTokensTrigger!);
            }
            else if (IsAnthropicToolUsesKeep && anthropicToolUsesKeep != null)
            {
                return anthropicToolUsesKeep(AnthropicToolUsesKeep!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicInputTokensTrigger?>? anthropicInputTokensTrigger = null,
            global::System.Action<global::OpenRouter.AnthropicToolUsesKeep?>? anthropicToolUsesKeep = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicInputTokensTrigger)
            {
                anthropicInputTokensTrigger?.Invoke(AnthropicInputTokensTrigger!);
            }
            else if (IsAnthropicToolUsesKeep)
            {
                anthropicToolUsesKeep?.Invoke(AnthropicToolUsesKeep!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicInputTokensTrigger,
                typeof(global::OpenRouter.AnthropicInputTokensTrigger),
                AnthropicToolUsesKeep,
                typeof(global::OpenRouter.AnthropicToolUsesKeep),
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
        public bool Equals(MessagesRequestContextManagementEditsItemsOneOf0Trigger other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicInputTokensTrigger?>.Default.Equals(AnthropicInputTokensTrigger, other.AnthropicInputTokensTrigger) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicToolUsesKeep?>.Default.Equals(AnthropicToolUsesKeep, other.AnthropicToolUsesKeep) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesRequestContextManagementEditsItemsOneOf0Trigger obj1, MessagesRequestContextManagementEditsItemsOneOf0Trigger obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesRequestContextManagementEditsItemsOneOf0Trigger>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesRequestContextManagementEditsItemsOneOf0Trigger obj1, MessagesRequestContextManagementEditsItemsOneOf0Trigger obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesRequestContextManagementEditsItemsOneOf0Trigger o && Equals(o);
        }
    }
}
