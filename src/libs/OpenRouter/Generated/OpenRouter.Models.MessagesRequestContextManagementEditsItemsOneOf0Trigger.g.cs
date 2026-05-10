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
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType? Type { get; }

        /// <summary>
        /// input_tokens variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1? InputTokens { get; init; }
#else
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1? InputTokens { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputTokens))]
#endif
        public bool IsInputTokens => InputTokens != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputTokens(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1? value)
        {
            value = InputTokens;
            return IsInputTokens;
        }

        /// <summary>
        /// tool_uses variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2? ToolUses { get; init; }
#else
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2? ToolUses { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolUses))]
#endif
        public bool IsToolUses => ToolUses != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickToolUses(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2? value)
        {
            value = ToolUses;
            return IsToolUses;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestContextManagementEditsItemsOneOf0Trigger(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1 value) => new MessagesRequestContextManagementEditsItemsOneOf0Trigger((global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1?(MessagesRequestContextManagementEditsItemsOneOf0Trigger @this) => @this.InputTokens;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf0Trigger(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1? value)
        {
            InputTokens = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestContextManagementEditsItemsOneOf0Trigger(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2 value) => new MessagesRequestContextManagementEditsItemsOneOf0Trigger((global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2?(MessagesRequestContextManagementEditsItemsOneOf0Trigger @this) => @this.ToolUses;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf0Trigger(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2? value)
        {
            ToolUses = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf0Trigger(
            global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType? type,
            global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1? inputTokens,
            global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2? toolUses
            )
        {
            Type = type;

            InputTokens = inputTokens;
            ToolUses = toolUses;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolUses as object ??
            InputTokens as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputTokens?.ToString() ??
            ToolUses?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputTokens && !IsToolUses || !IsInputTokens && IsToolUses;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1, TResult>? inputTokens = null,
            global::System.Func<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2, TResult>? toolUses = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputTokens && inputTokens != null)
            {
                return inputTokens(InputTokens!);
            }
            else if (IsToolUses && toolUses != null)
            {
                return toolUses(ToolUses!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1>? inputTokens = null,

            global::System.Action<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2>? toolUses = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputTokens)
            {
                inputTokens?.Invoke(InputTokens!);
            }
            else if (IsToolUses)
            {
                toolUses?.Invoke(ToolUses!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1>? inputTokens = null,
            global::System.Action<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2>? toolUses = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputTokens)
            {
                inputTokens?.Invoke(InputTokens!);
            }
            else if (IsToolUses)
            {
                toolUses?.Invoke(ToolUses!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputTokens,
                typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1),
                ToolUses,
                typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1?>.Default.Equals(InputTokens, other.InputTokens) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2?>.Default.Equals(ToolUses, other.ToolUses) 
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
