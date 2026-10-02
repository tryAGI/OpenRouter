#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An output item containing reasoning<br/>
    /// Example: {"content":[{"text":"First, we analyze the problem...","type":"reasoning_text"}],"format":"anthropic-claude-v1","id":"reasoning-123","signature":"EvcBCkgIChABGAIqQKkSDbRuVEQUk9qN1odC098l9SEj...","status":"completed","summary":[{"text":"Analyzed the problem and found the optimal solution.","type":"summary_text"}],"type":"reasoning"}
    /// </summary>
    public readonly partial struct OutputReasoningItem : global::System.IEquatable<OutputReasoningItem>
    {
        /// <summary>
        /// Example: {"id":"reasoning-abc123","summary":[{"text":"Analyzed the problem using first principles","type":"summary_text"}],"type":"reasoning"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemReasoning? OutputItemReasoning { get; init; }
#else
        public global::OpenRouter.OutputItemReasoning? OutputItemReasoning { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemReasoning))]
#endif
        public bool IsOutputItemReasoning => OutputItemReasoning != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputItemReasoning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemReasoning? value)
        {
            value = OutputItemReasoning;
            return IsOutputItemReasoning;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemReasoning PickOutputItemReasoning() => OutputItemReasoning is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputItemReasoning' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputReasoningItemVariant2? OutputReasoningItemVariant2 { get; init; }
#else
        public global::OpenRouter.OutputReasoningItemVariant2? OutputReasoningItemVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputReasoningItemVariant2))]
#endif
        public bool IsOutputReasoningItemVariant2 => OutputReasoningItemVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputReasoningItemVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputReasoningItemVariant2? value)
        {
            value = OutputReasoningItemVariant2;
            return IsOutputReasoningItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputReasoningItemVariant2 PickOutputReasoningItemVariant2() => OutputReasoningItemVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputReasoningItemVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputReasoningItem(global::OpenRouter.OutputItemReasoning value) => new OutputReasoningItem((global::OpenRouter.OutputItemReasoning?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemReasoning?(OutputReasoningItem @this) => @this.OutputItemReasoning;

        /// <summary>
        ///
        /// </summary>
        public OutputReasoningItem(global::OpenRouter.OutputItemReasoning? value)
        {
            OutputItemReasoning = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputReasoningItem FromOutputItemReasoning(global::OpenRouter.OutputItemReasoning? value) => new OutputReasoningItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputReasoningItem(global::OpenRouter.OutputReasoningItemVariant2 value) => new OutputReasoningItem((global::OpenRouter.OutputReasoningItemVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputReasoningItemVariant2?(OutputReasoningItem @this) => @this.OutputReasoningItemVariant2;

        /// <summary>
        ///
        /// </summary>
        public OutputReasoningItem(global::OpenRouter.OutputReasoningItemVariant2? value)
        {
            OutputReasoningItemVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputReasoningItem FromOutputReasoningItemVariant2(global::OpenRouter.OutputReasoningItemVariant2? value) => new OutputReasoningItem(value);

        /// <summary>
        ///
        /// </summary>
        public OutputReasoningItem(
            global::OpenRouter.OutputItemReasoning? outputItemReasoning,
            global::OpenRouter.OutputReasoningItemVariant2? outputReasoningItemVariant2
            )
        {
            OutputItemReasoning = outputItemReasoning;
            OutputReasoningItemVariant2 = outputReasoningItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OutputReasoningItemVariant2 as object ??
            OutputItemReasoning as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OutputItemReasoning?.ToString() ??
            OutputReasoningItemVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOutputItemReasoning && IsOutputReasoningItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputItemReasoning, TResult>? outputItemReasoning = null,
            global::System.Func<global::OpenRouter.OutputReasoningItemVariant2, TResult>? outputReasoningItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputItemReasoning is { } __value0 && outputItemReasoning != null)
            {
                return outputItemReasoning(__value0);
            }
            else if (OutputReasoningItemVariant2 is { } __value1 && outputReasoningItemVariant2 != null)
            {
                return outputReasoningItemVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputItemReasoning>? outputItemReasoning = null,

            global::System.Action<global::OpenRouter.OutputReasoningItemVariant2>? outputReasoningItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputItemReasoning is { } __value0)
            {
                outputItemReasoning?.Invoke(__value0);
            }
            else if (OutputReasoningItemVariant2 is { } __value1)
            {
                outputReasoningItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputItemReasoning>? outputItemReasoning = null,
            global::System.Action<global::OpenRouter.OutputReasoningItemVariant2>? outputReasoningItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputItemReasoning is { } __value0)
            {
                outputItemReasoning?.Invoke(__value0);
            }
            else if (OutputReasoningItemVariant2 is { } __value1)
            {
                outputReasoningItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputItemReasoning,
                typeof(global::OpenRouter.OutputItemReasoning),
                OutputReasoningItemVariant2,
                typeof(global::OpenRouter.OutputReasoningItemVariant2),
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
        public bool Equals(OutputReasoningItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemReasoning?>.Default.Equals(OutputItemReasoning, other.OutputItemReasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputReasoningItemVariant2?>.Default.Equals(OutputReasoningItemVariant2, other.OutputReasoningItemVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OutputReasoningItem obj1, OutputReasoningItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputReasoningItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputReasoningItem obj1, OutputReasoningItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputReasoningItem o && Equals(o);
        }
    }
}
