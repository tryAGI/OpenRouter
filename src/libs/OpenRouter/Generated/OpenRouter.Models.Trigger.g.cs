#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Trigger : global::System.IEquatable<Trigger>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant1TriggerDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"type":"input_tokens","value":100000}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicInputTokensTrigger? InputTokens { get; init; }
#else
        public global::OpenRouter.AnthropicInputTokensTrigger? InputTokens { get; }
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
            out global::OpenRouter.AnthropicInputTokensTrigger? value)
        {
            value = InputTokens;
            return IsInputTokens;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicInputTokensTrigger PickInputTokens() => InputTokens is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputTokens' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"type":"tool_uses","value":10}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicToolUsesTrigger? ToolUses { get; init; }
#else
        public global::OpenRouter.AnthropicToolUsesTrigger? ToolUses { get; }
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
            out global::OpenRouter.AnthropicToolUsesTrigger? value)
        {
            value = ToolUses;
            return IsToolUses;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUsesTrigger PickToolUses() => ToolUses is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolUses' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Trigger(global::OpenRouter.AnthropicInputTokensTrigger value) => new Trigger((global::OpenRouter.AnthropicInputTokensTrigger?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicInputTokensTrigger?(Trigger @this) => @this.InputTokens;

        /// <summary>
        ///
        /// </summary>
        public Trigger(global::OpenRouter.AnthropicInputTokensTrigger? value)
        {
            InputTokens = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Trigger FromInputTokens(global::OpenRouter.AnthropicInputTokensTrigger? value) => new Trigger(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Trigger(global::OpenRouter.AnthropicToolUsesTrigger value) => new Trigger((global::OpenRouter.AnthropicToolUsesTrigger?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicToolUsesTrigger?(Trigger @this) => @this.ToolUses;

        /// <summary>
        ///
        /// </summary>
        public Trigger(global::OpenRouter.AnthropicToolUsesTrigger? value)
        {
            ToolUses = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Trigger FromToolUses(global::OpenRouter.AnthropicToolUsesTrigger? value) => new Trigger(value);

        /// <summary>
        ///
        /// </summary>
        public Trigger(
            global::OpenRouter.MessagesRequestContextManagementEditVariant1TriggerDiscriminatorType? type,
            global::OpenRouter.AnthropicInputTokensTrigger? inputTokens,
            global::OpenRouter.AnthropicToolUsesTrigger? toolUses
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
            global::System.Func<global::OpenRouter.AnthropicInputTokensTrigger, TResult>? inputTokens = null,
            global::System.Func<global::OpenRouter.AnthropicToolUsesTrigger, TResult>? toolUses = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputTokens is { } __value0 && inputTokens != null)
            {
                return inputTokens(__value0);
            }
            else if (ToolUses is { } __value1 && toolUses != null)
            {
                return toolUses(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicInputTokensTrigger>? inputTokens = null,

            global::System.Action<global::OpenRouter.AnthropicToolUsesTrigger>? toolUses = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputTokens is { } __value0)
            {
                inputTokens?.Invoke(__value0);
            }
            else if (ToolUses is { } __value1)
            {
                toolUses?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicInputTokensTrigger>? inputTokens = null,
            global::System.Action<global::OpenRouter.AnthropicToolUsesTrigger>? toolUses = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputTokens is { } __value0)
            {
                inputTokens?.Invoke(__value0);
            }
            else if (ToolUses is { } __value1)
            {
                toolUses?.Invoke(__value1);
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
                typeof(global::OpenRouter.AnthropicInputTokensTrigger),
                ToolUses,
                typeof(global::OpenRouter.AnthropicToolUsesTrigger),
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
        public bool Equals(Trigger other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicInputTokensTrigger?>.Default.Equals(InputTokens, other.InputTokens) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicToolUsesTrigger?>.Default.Equals(ToolUses, other.ToolUses)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Trigger obj1, Trigger obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Trigger>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Trigger obj1, Trigger obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Trigger o && Equals(o);
        }
    }
}
