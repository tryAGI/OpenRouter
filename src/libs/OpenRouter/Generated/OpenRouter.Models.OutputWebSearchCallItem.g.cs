#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"id":"ws-abc123","status":"completed","type":"web_search_call"}
    /// </summary>
    public readonly partial struct OutputWebSearchCallItem : global::System.IEquatable<OutputWebSearchCallItem>
    {
        /// <summary>
        /// Example: {"action":{"query":"OpenAI API","type":"search"},"id":"search-abc123","status":"completed","type":"web_search_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemWebSearchCall? OutputItemWebSearchCall { get; init; }
#else
        public global::OpenRouter.OutputItemWebSearchCall? OutputItemWebSearchCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemWebSearchCall))]
#endif
        public bool IsOutputItemWebSearchCall => OutputItemWebSearchCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputItemWebSearchCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemWebSearchCall? value)
        {
            value = OutputItemWebSearchCall;
            return IsOutputItemWebSearchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCall PickOutputItemWebSearchCall() => OutputItemWebSearchCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputItemWebSearchCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? OutputWebSearchCallItemVariant2 { get; init; }
#else
        public object? OutputWebSearchCallItemVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputWebSearchCallItemVariant2))]
#endif
        public bool IsOutputWebSearchCallItemVariant2 => OutputWebSearchCallItemVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputWebSearchCallItemVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = OutputWebSearchCallItemVariant2;
            return IsOutputWebSearchCallItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickOutputWebSearchCallItemVariant2() => OutputWebSearchCallItemVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputWebSearchCallItemVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputWebSearchCallItem(global::OpenRouter.OutputItemWebSearchCall value) => new OutputWebSearchCallItem((global::OpenRouter.OutputItemWebSearchCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemWebSearchCall?(OutputWebSearchCallItem @this) => @this.OutputItemWebSearchCall;

        /// <summary>
        ///
        /// </summary>
        public OutputWebSearchCallItem(global::OpenRouter.OutputItemWebSearchCall? value)
        {
            OutputItemWebSearchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputWebSearchCallItem FromOutputItemWebSearchCall(global::OpenRouter.OutputItemWebSearchCall? value) => new OutputWebSearchCallItem(value);

        /// <summary>
        ///
        /// </summary>
        public OutputWebSearchCallItem(
            global::OpenRouter.OutputItemWebSearchCall? outputItemWebSearchCall,
            object? outputWebSearchCallItemVariant2
            )
        {
            OutputItemWebSearchCall = outputItemWebSearchCall;
            OutputWebSearchCallItemVariant2 = outputWebSearchCallItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OutputWebSearchCallItemVariant2 as object ??
            OutputItemWebSearchCall as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OutputItemWebSearchCall?.ToString() ??
            OutputWebSearchCallItemVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOutputItemWebSearchCall && IsOutputWebSearchCallItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputItemWebSearchCall, TResult>? outputItemWebSearchCall = null,
            global::System.Func<object, TResult>? outputWebSearchCallItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputItemWebSearchCall is { } __value0 && outputItemWebSearchCall != null)
            {
                return outputItemWebSearchCall(__value0);
            }
            else if (OutputWebSearchCallItemVariant2 is { } __value1 && outputWebSearchCallItemVariant2 != null)
            {
                return outputWebSearchCallItemVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputItemWebSearchCall>? outputItemWebSearchCall = null,

            global::System.Action<object>? outputWebSearchCallItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputItemWebSearchCall is { } __value0)
            {
                outputItemWebSearchCall?.Invoke(__value0);
            }
            else if (OutputWebSearchCallItemVariant2 is { } __value1)
            {
                outputWebSearchCallItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputItemWebSearchCall>? outputItemWebSearchCall = null,
            global::System.Action<object>? outputWebSearchCallItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputItemWebSearchCall is { } __value0)
            {
                outputItemWebSearchCall?.Invoke(__value0);
            }
            else if (OutputWebSearchCallItemVariant2 is { } __value1)
            {
                outputWebSearchCallItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputItemWebSearchCall,
                typeof(global::OpenRouter.OutputItemWebSearchCall),
                OutputWebSearchCallItemVariant2,
                typeof(object),
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
        public bool Equals(OutputWebSearchCallItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemWebSearchCall?>.Default.Equals(OutputItemWebSearchCall, other.OutputItemWebSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(OutputWebSearchCallItemVariant2, other.OutputWebSearchCallItemVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OutputWebSearchCallItem obj1, OutputWebSearchCallItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputWebSearchCallItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputWebSearchCallItem obj1, OutputWebSearchCallItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputWebSearchCallItem o && Equals(o);
        }
    }
}
