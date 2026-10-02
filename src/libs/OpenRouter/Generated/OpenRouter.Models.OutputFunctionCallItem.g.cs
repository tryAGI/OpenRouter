#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"arguments":"{\u0022location\u0022:\u0022San Francisco\u0022}","call_id":"call-abc123","id":"fc-abc123","name":"get_weather","status":"completed","type":"function_call"}
    /// </summary>
    public readonly partial struct OutputFunctionCallItem : global::System.IEquatable<OutputFunctionCallItem>
    {
        /// <summary>
        /// Example: {"arguments":"{\u0022location\u0022:\u0022San Francisco\u0022,\u0022unit\u0022:\u0022celsius\u0022}","call_id":"call-abc123","id":"call-abc123","name":"get_weather","type":"function_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemFunctionCall? OutputItemFunctionCall { get; init; }
#else
        public global::OpenRouter.OutputItemFunctionCall? OutputItemFunctionCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemFunctionCall))]
#endif
        public bool IsOutputItemFunctionCall => OutputItemFunctionCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputItemFunctionCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemFunctionCall? value)
        {
            value = OutputItemFunctionCall;
            return IsOutputItemFunctionCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFunctionCall PickOutputItemFunctionCall() => OutputItemFunctionCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputItemFunctionCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputFunctionCallItemVariant2? OutputFunctionCallItemVariant2 { get; init; }
#else
        public global::OpenRouter.OutputFunctionCallItemVariant2? OutputFunctionCallItemVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputFunctionCallItemVariant2))]
#endif
        public bool IsOutputFunctionCallItemVariant2 => OutputFunctionCallItemVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputFunctionCallItemVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputFunctionCallItemVariant2? value)
        {
            value = OutputFunctionCallItemVariant2;
            return IsOutputFunctionCallItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFunctionCallItemVariant2 PickOutputFunctionCallItemVariant2() => OutputFunctionCallItemVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputFunctionCallItemVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputFunctionCallItem(global::OpenRouter.OutputItemFunctionCall value) => new OutputFunctionCallItem((global::OpenRouter.OutputItemFunctionCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemFunctionCall?(OutputFunctionCallItem @this) => @this.OutputItemFunctionCall;

        /// <summary>
        ///
        /// </summary>
        public OutputFunctionCallItem(global::OpenRouter.OutputItemFunctionCall? value)
        {
            OutputItemFunctionCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputFunctionCallItem FromOutputItemFunctionCall(global::OpenRouter.OutputItemFunctionCall? value) => new OutputFunctionCallItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputFunctionCallItem(global::OpenRouter.OutputFunctionCallItemVariant2 value) => new OutputFunctionCallItem((global::OpenRouter.OutputFunctionCallItemVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputFunctionCallItemVariant2?(OutputFunctionCallItem @this) => @this.OutputFunctionCallItemVariant2;

        /// <summary>
        ///
        /// </summary>
        public OutputFunctionCallItem(global::OpenRouter.OutputFunctionCallItemVariant2? value)
        {
            OutputFunctionCallItemVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputFunctionCallItem FromOutputFunctionCallItemVariant2(global::OpenRouter.OutputFunctionCallItemVariant2? value) => new OutputFunctionCallItem(value);

        /// <summary>
        ///
        /// </summary>
        public OutputFunctionCallItem(
            global::OpenRouter.OutputItemFunctionCall? outputItemFunctionCall,
            global::OpenRouter.OutputFunctionCallItemVariant2? outputFunctionCallItemVariant2
            )
        {
            OutputItemFunctionCall = outputItemFunctionCall;
            OutputFunctionCallItemVariant2 = outputFunctionCallItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OutputFunctionCallItemVariant2 as object ??
            OutputItemFunctionCall as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OutputItemFunctionCall?.ToString() ??
            OutputFunctionCallItemVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOutputItemFunctionCall && IsOutputFunctionCallItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputItemFunctionCall, TResult>? outputItemFunctionCall = null,
            global::System.Func<global::OpenRouter.OutputFunctionCallItemVariant2, TResult>? outputFunctionCallItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputItemFunctionCall is { } __value0 && outputItemFunctionCall != null)
            {
                return outputItemFunctionCall(__value0);
            }
            else if (OutputFunctionCallItemVariant2 is { } __value1 && outputFunctionCallItemVariant2 != null)
            {
                return outputFunctionCallItemVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputItemFunctionCall>? outputItemFunctionCall = null,

            global::System.Action<global::OpenRouter.OutputFunctionCallItemVariant2>? outputFunctionCallItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputItemFunctionCall is { } __value0)
            {
                outputItemFunctionCall?.Invoke(__value0);
            }
            else if (OutputFunctionCallItemVariant2 is { } __value1)
            {
                outputFunctionCallItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputItemFunctionCall>? outputItemFunctionCall = null,
            global::System.Action<global::OpenRouter.OutputFunctionCallItemVariant2>? outputFunctionCallItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputItemFunctionCall is { } __value0)
            {
                outputItemFunctionCall?.Invoke(__value0);
            }
            else if (OutputFunctionCallItemVariant2 is { } __value1)
            {
                outputFunctionCallItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputItemFunctionCall,
                typeof(global::OpenRouter.OutputItemFunctionCall),
                OutputFunctionCallItemVariant2,
                typeof(global::OpenRouter.OutputFunctionCallItemVariant2),
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
        public bool Equals(OutputFunctionCallItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemFunctionCall?>.Default.Equals(OutputItemFunctionCall, other.OutputItemFunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputFunctionCallItemVariant2?>.Default.Equals(OutputFunctionCallItemVariant2, other.OutputFunctionCallItemVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OutputFunctionCallItem obj1, OutputFunctionCallItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputFunctionCallItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputFunctionCallItem obj1, OutputFunctionCallItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputFunctionCallItem o && Equals(o);
        }
    }
}
