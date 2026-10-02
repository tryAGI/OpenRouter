#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"id":"fs-abc123","queries":["search term"],"results":[],"status":"completed","type":"file_search_call"}
    /// </summary>
    public readonly partial struct OutputFileSearchCallItem : global::System.IEquatable<OutputFileSearchCallItem>
    {
        /// <summary>
        /// Example: {"id":"filesearch-abc123","queries":["machine learning algorithms","neural networks"],"status":"completed","type":"file_search_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemFileSearchCall? OutputItemFileSearchCall { get; init; }
#else
        public global::OpenRouter.OutputItemFileSearchCall? OutputItemFileSearchCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemFileSearchCall))]
#endif
        public bool IsOutputItemFileSearchCall => OutputItemFileSearchCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputItemFileSearchCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemFileSearchCall? value)
        {
            value = OutputItemFileSearchCall;
            return IsOutputItemFileSearchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFileSearchCall PickOutputItemFileSearchCall() => OutputItemFileSearchCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputItemFileSearchCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? OutputFileSearchCallItemVariant2 { get; init; }
#else
        public object? OutputFileSearchCallItemVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputFileSearchCallItemVariant2))]
#endif
        public bool IsOutputFileSearchCallItemVariant2 => OutputFileSearchCallItemVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputFileSearchCallItemVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = OutputFileSearchCallItemVariant2;
            return IsOutputFileSearchCallItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickOutputFileSearchCallItemVariant2() => OutputFileSearchCallItemVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputFileSearchCallItemVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputFileSearchCallItem(global::OpenRouter.OutputItemFileSearchCall value) => new OutputFileSearchCallItem((global::OpenRouter.OutputItemFileSearchCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemFileSearchCall?(OutputFileSearchCallItem @this) => @this.OutputItemFileSearchCall;

        /// <summary>
        ///
        /// </summary>
        public OutputFileSearchCallItem(global::OpenRouter.OutputItemFileSearchCall? value)
        {
            OutputItemFileSearchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputFileSearchCallItem FromOutputItemFileSearchCall(global::OpenRouter.OutputItemFileSearchCall? value) => new OutputFileSearchCallItem(value);

        /// <summary>
        ///
        /// </summary>
        public OutputFileSearchCallItem(
            global::OpenRouter.OutputItemFileSearchCall? outputItemFileSearchCall,
            object? outputFileSearchCallItemVariant2
            )
        {
            OutputItemFileSearchCall = outputItemFileSearchCall;
            OutputFileSearchCallItemVariant2 = outputFileSearchCallItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OutputFileSearchCallItemVariant2 as object ??
            OutputItemFileSearchCall as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OutputItemFileSearchCall?.ToString() ??
            OutputFileSearchCallItemVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOutputItemFileSearchCall && IsOutputFileSearchCallItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputItemFileSearchCall, TResult>? outputItemFileSearchCall = null,
            global::System.Func<object, TResult>? outputFileSearchCallItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputItemFileSearchCall is { } __value0 && outputItemFileSearchCall != null)
            {
                return outputItemFileSearchCall(__value0);
            }
            else if (OutputFileSearchCallItemVariant2 is { } __value1 && outputFileSearchCallItemVariant2 != null)
            {
                return outputFileSearchCallItemVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputItemFileSearchCall>? outputItemFileSearchCall = null,

            global::System.Action<object>? outputFileSearchCallItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputItemFileSearchCall is { } __value0)
            {
                outputItemFileSearchCall?.Invoke(__value0);
            }
            else if (OutputFileSearchCallItemVariant2 is { } __value1)
            {
                outputFileSearchCallItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputItemFileSearchCall>? outputItemFileSearchCall = null,
            global::System.Action<object>? outputFileSearchCallItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputItemFileSearchCall is { } __value0)
            {
                outputItemFileSearchCall?.Invoke(__value0);
            }
            else if (OutputFileSearchCallItemVariant2 is { } __value1)
            {
                outputFileSearchCallItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputItemFileSearchCall,
                typeof(global::OpenRouter.OutputItemFileSearchCall),
                OutputFileSearchCallItemVariant2,
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
        public bool Equals(OutputFileSearchCallItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemFileSearchCall?>.Default.Equals(OutputItemFileSearchCall, other.OutputItemFileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(OutputFileSearchCallItemVariant2, other.OutputFileSearchCallItemVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OutputFileSearchCallItem obj1, OutputFileSearchCallItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputFileSearchCallItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputFileSearchCallItem obj1, OutputFileSearchCallItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputFileSearchCallItem o && Equals(o);
        }
    }
}
