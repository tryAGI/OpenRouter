#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reasoning output item with signature and format extensions<br/>
    /// Example: {"id":"reasoning-abc123","summary":[{"text":"Step by step analysis","type":"summary_text"}],"type":"reasoning"}
    /// </summary>
    public readonly partial struct ReasoningItem : global::System.IEquatable<ReasoningItem>
    {
        /// <summary>
        /// Example: {"id":"reasoning-abc123","summary":[{"text":"Analyzed the problem using first principles","type":"summary_text"}],"type":"reasoning"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemReasoning? Output { get; init; }
#else
        public global::OpenRouter.OutputItemReasoning? Output { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Output))]
#endif
        public bool IsOutput => Output != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemReasoning? value)
        {
            value = Output;
            return IsOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemReasoning PickOutput() => Output is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Output' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ReasoningItemVariant2? ReasoningItemVariant2 { get; init; }
#else
        public global::OpenRouter.ReasoningItemVariant2? ReasoningItemVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningItemVariant2))]
#endif
        public bool IsReasoningItemVariant2 => ReasoningItemVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReasoningItemVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ReasoningItemVariant2? value)
        {
            value = ReasoningItemVariant2;
            return IsReasoningItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningItemVariant2 PickReasoningItemVariant2() => ReasoningItemVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningItemVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ReasoningItem(global::OpenRouter.OutputItemReasoning value) => new ReasoningItem((global::OpenRouter.OutputItemReasoning?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemReasoning?(ReasoningItem @this) => @this.Output;

        /// <summary>
        ///
        /// </summary>
        public ReasoningItem(global::OpenRouter.OutputItemReasoning? value)
        {
            Output = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ReasoningItem FromOutput(global::OpenRouter.OutputItemReasoning? value) => new ReasoningItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ReasoningItem(global::OpenRouter.ReasoningItemVariant2 value) => new ReasoningItem((global::OpenRouter.ReasoningItemVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ReasoningItemVariant2?(ReasoningItem @this) => @this.ReasoningItemVariant2;

        /// <summary>
        ///
        /// </summary>
        public ReasoningItem(global::OpenRouter.ReasoningItemVariant2? value)
        {
            ReasoningItemVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ReasoningItem FromReasoningItemVariant2(global::OpenRouter.ReasoningItemVariant2? value) => new ReasoningItem(value);

        /// <summary>
        ///
        /// </summary>
        public ReasoningItem(
            global::OpenRouter.OutputItemReasoning? output,
            global::OpenRouter.ReasoningItemVariant2? reasoningItemVariant2
            )
        {
            Output = output;
            ReasoningItemVariant2 = reasoningItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ReasoningItemVariant2 as object ??
            Output as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Output?.ToString() ??
            ReasoningItemVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOutput && IsReasoningItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputItemReasoning, TResult>? output = null,
            global::System.Func<global::OpenRouter.ReasoningItemVariant2, TResult>? reasoningItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Output is { } __value0 && output != null)
            {
                return output(__value0);
            }
            else if (ReasoningItemVariant2 is { } __value1 && reasoningItemVariant2 != null)
            {
                return reasoningItemVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputItemReasoning>? output = null,

            global::System.Action<global::OpenRouter.ReasoningItemVariant2>? reasoningItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Output is { } __value0)
            {
                output?.Invoke(__value0);
            }
            else if (ReasoningItemVariant2 is { } __value1)
            {
                reasoningItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputItemReasoning>? output = null,
            global::System.Action<global::OpenRouter.ReasoningItemVariant2>? reasoningItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Output is { } __value0)
            {
                output?.Invoke(__value0);
            }
            else if (ReasoningItemVariant2 is { } __value1)
            {
                reasoningItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Output,
                typeof(global::OpenRouter.OutputItemReasoning),
                ReasoningItemVariant2,
                typeof(global::OpenRouter.ReasoningItemVariant2),
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
        public bool Equals(ReasoningItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemReasoning?>.Default.Equals(Output, other.Output) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ReasoningItemVariant2?>.Default.Equals(ReasoningItemVariant2, other.ReasoningItemVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ReasoningItem obj1, ReasoningItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReasoningItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ReasoningItem obj1, ReasoningItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReasoningItem o && Equals(o);
        }
    }
}
