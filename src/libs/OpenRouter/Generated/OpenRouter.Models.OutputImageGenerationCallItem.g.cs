#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"id":"img-abc123","result":null,"status":"completed","type":"image_generation_call"}
    /// </summary>
    public readonly partial struct OutputImageGenerationCallItem : global::System.IEquatable<OutputImageGenerationCallItem>
    {
        /// <summary>
        /// Example: {"id":"imagegen-abc123","result":"iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mNk\u002BM9QDwADhgGAWjR9awAAAABJRU5ErkJggg==","status":"completed","type":"image_generation_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemImageGenerationCall? OutputItemImageGenerationCall { get; init; }
#else
        public global::OpenRouter.OutputItemImageGenerationCall? OutputItemImageGenerationCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemImageGenerationCall))]
#endif
        public bool IsOutputItemImageGenerationCall => OutputItemImageGenerationCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputItemImageGenerationCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemImageGenerationCall? value)
        {
            value = OutputItemImageGenerationCall;
            return IsOutputItemImageGenerationCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemImageGenerationCall PickOutputItemImageGenerationCall() => OutputItemImageGenerationCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputItemImageGenerationCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputImageGenerationCallItemVariant2? OutputImageGenerationCallItemVariant2 { get; init; }
#else
        public global::OpenRouter.OutputImageGenerationCallItemVariant2? OutputImageGenerationCallItemVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputImageGenerationCallItemVariant2))]
#endif
        public bool IsOutputImageGenerationCallItemVariant2 => OutputImageGenerationCallItemVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputImageGenerationCallItemVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputImageGenerationCallItemVariant2? value)
        {
            value = OutputImageGenerationCallItemVariant2;
            return IsOutputImageGenerationCallItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationCallItemVariant2 PickOutputImageGenerationCallItemVariant2() => OutputImageGenerationCallItemVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputImageGenerationCallItemVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputImageGenerationCallItem(global::OpenRouter.OutputItemImageGenerationCall value) => new OutputImageGenerationCallItem((global::OpenRouter.OutputItemImageGenerationCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemImageGenerationCall?(OutputImageGenerationCallItem @this) => @this.OutputItemImageGenerationCall;

        /// <summary>
        ///
        /// </summary>
        public OutputImageGenerationCallItem(global::OpenRouter.OutputItemImageGenerationCall? value)
        {
            OutputItemImageGenerationCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputImageGenerationCallItem FromOutputItemImageGenerationCall(global::OpenRouter.OutputItemImageGenerationCall? value) => new OutputImageGenerationCallItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputImageGenerationCallItem(global::OpenRouter.OutputImageGenerationCallItemVariant2 value) => new OutputImageGenerationCallItem((global::OpenRouter.OutputImageGenerationCallItemVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputImageGenerationCallItemVariant2?(OutputImageGenerationCallItem @this) => @this.OutputImageGenerationCallItemVariant2;

        /// <summary>
        ///
        /// </summary>
        public OutputImageGenerationCallItem(global::OpenRouter.OutputImageGenerationCallItemVariant2? value)
        {
            OutputImageGenerationCallItemVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputImageGenerationCallItem FromOutputImageGenerationCallItemVariant2(global::OpenRouter.OutputImageGenerationCallItemVariant2? value) => new OutputImageGenerationCallItem(value);

        /// <summary>
        ///
        /// </summary>
        public OutputImageGenerationCallItem(
            global::OpenRouter.OutputItemImageGenerationCall? outputItemImageGenerationCall,
            global::OpenRouter.OutputImageGenerationCallItemVariant2? outputImageGenerationCallItemVariant2
            )
        {
            OutputItemImageGenerationCall = outputItemImageGenerationCall;
            OutputImageGenerationCallItemVariant2 = outputImageGenerationCallItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OutputImageGenerationCallItemVariant2 as object ??
            OutputItemImageGenerationCall as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OutputItemImageGenerationCall?.ToString() ??
            OutputImageGenerationCallItemVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOutputItemImageGenerationCall && IsOutputImageGenerationCallItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputItemImageGenerationCall, TResult>? outputItemImageGenerationCall = null,
            global::System.Func<global::OpenRouter.OutputImageGenerationCallItemVariant2, TResult>? outputImageGenerationCallItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputItemImageGenerationCall is { } __value0 && outputItemImageGenerationCall != null)
            {
                return outputItemImageGenerationCall(__value0);
            }
            else if (OutputImageGenerationCallItemVariant2 is { } __value1 && outputImageGenerationCallItemVariant2 != null)
            {
                return outputImageGenerationCallItemVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputItemImageGenerationCall>? outputItemImageGenerationCall = null,

            global::System.Action<global::OpenRouter.OutputImageGenerationCallItemVariant2>? outputImageGenerationCallItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputItemImageGenerationCall is { } __value0)
            {
                outputItemImageGenerationCall?.Invoke(__value0);
            }
            else if (OutputImageGenerationCallItemVariant2 is { } __value1)
            {
                outputImageGenerationCallItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputItemImageGenerationCall>? outputItemImageGenerationCall = null,
            global::System.Action<global::OpenRouter.OutputImageGenerationCallItemVariant2>? outputImageGenerationCallItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputItemImageGenerationCall is { } __value0)
            {
                outputItemImageGenerationCall?.Invoke(__value0);
            }
            else if (OutputImageGenerationCallItemVariant2 is { } __value1)
            {
                outputImageGenerationCallItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputItemImageGenerationCall,
                typeof(global::OpenRouter.OutputItemImageGenerationCall),
                OutputImageGenerationCallItemVariant2,
                typeof(global::OpenRouter.OutputImageGenerationCallItemVariant2),
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
        public bool Equals(OutputImageGenerationCallItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemImageGenerationCall?>.Default.Equals(OutputItemImageGenerationCall, other.OutputItemImageGenerationCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputImageGenerationCallItemVariant2?>.Default.Equals(OutputImageGenerationCallItemVariant2, other.OutputImageGenerationCallItemVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OutputImageGenerationCallItem obj1, OutputImageGenerationCallItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputImageGenerationCallItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputImageGenerationCallItem obj1, OutputImageGenerationCallItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputImageGenerationCallItem o && Equals(o);
        }
    }
}
