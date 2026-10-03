#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OutputCapacityEntryV2 : global::System.IEquatable<OutputCapacityEntryV2>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputCapacityEntryV2Variant1? OutputCapacityEntryV2Variant1 { get; init; }
#else
        public global::OpenRouter.OutputCapacityEntryV2Variant1? OutputCapacityEntryV2Variant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputCapacityEntryV2Variant1))]
#endif
        public bool IsOutputCapacityEntryV2Variant1 => OutputCapacityEntryV2Variant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputCapacityEntryV2Variant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputCapacityEntryV2Variant1? value)
        {
            value = OutputCapacityEntryV2Variant1;
            return IsOutputCapacityEntryV2Variant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCapacityEntryV2Variant1 PickOutputCapacityEntryV2Variant1() => OutputCapacityEntryV2Variant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputCapacityEntryV2Variant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputCapacityEntryV2Variant2? OutputCapacityEntryV2Variant2 { get; init; }
#else
        public global::OpenRouter.OutputCapacityEntryV2Variant2? OutputCapacityEntryV2Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputCapacityEntryV2Variant2))]
#endif
        public bool IsOutputCapacityEntryV2Variant2 => OutputCapacityEntryV2Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputCapacityEntryV2Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputCapacityEntryV2Variant2? value)
        {
            value = OutputCapacityEntryV2Variant2;
            return IsOutputCapacityEntryV2Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCapacityEntryV2Variant2 PickOutputCapacityEntryV2Variant2() => OutputCapacityEntryV2Variant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputCapacityEntryV2Variant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputCapacityEntryV2(global::OpenRouter.OutputCapacityEntryV2Variant1 value) => new OutputCapacityEntryV2((global::OpenRouter.OutputCapacityEntryV2Variant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputCapacityEntryV2Variant1?(OutputCapacityEntryV2 @this) => @this.OutputCapacityEntryV2Variant1;

        /// <summary>
        ///
        /// </summary>
        public OutputCapacityEntryV2(global::OpenRouter.OutputCapacityEntryV2Variant1? value)
        {
            OutputCapacityEntryV2Variant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputCapacityEntryV2 FromOutputCapacityEntryV2Variant1(global::OpenRouter.OutputCapacityEntryV2Variant1? value) => new OutputCapacityEntryV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputCapacityEntryV2(global::OpenRouter.OutputCapacityEntryV2Variant2 value) => new OutputCapacityEntryV2((global::OpenRouter.OutputCapacityEntryV2Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputCapacityEntryV2Variant2?(OutputCapacityEntryV2 @this) => @this.OutputCapacityEntryV2Variant2;

        /// <summary>
        ///
        /// </summary>
        public OutputCapacityEntryV2(global::OpenRouter.OutputCapacityEntryV2Variant2? value)
        {
            OutputCapacityEntryV2Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputCapacityEntryV2 FromOutputCapacityEntryV2Variant2(global::OpenRouter.OutputCapacityEntryV2Variant2? value) => new OutputCapacityEntryV2(value);

        /// <summary>
        ///
        /// </summary>
        public OutputCapacityEntryV2(
            global::OpenRouter.OutputCapacityEntryV2Variant1? outputCapacityEntryV2Variant1,
            global::OpenRouter.OutputCapacityEntryV2Variant2? outputCapacityEntryV2Variant2
            )
        {
            OutputCapacityEntryV2Variant1 = outputCapacityEntryV2Variant1;
            OutputCapacityEntryV2Variant2 = outputCapacityEntryV2Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OutputCapacityEntryV2Variant2 as object ??
            OutputCapacityEntryV2Variant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OutputCapacityEntryV2Variant1?.ToString() ??
            OutputCapacityEntryV2Variant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOutputCapacityEntryV2Variant1 || IsOutputCapacityEntryV2Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputCapacityEntryV2Variant1, TResult>? outputCapacityEntryV2Variant1 = null,
            global::System.Func<global::OpenRouter.OutputCapacityEntryV2Variant2, TResult>? outputCapacityEntryV2Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputCapacityEntryV2Variant1 is { } __value0 && outputCapacityEntryV2Variant1 != null)
            {
                return outputCapacityEntryV2Variant1(__value0);
            }
            else if (OutputCapacityEntryV2Variant2 is { } __value1 && outputCapacityEntryV2Variant2 != null)
            {
                return outputCapacityEntryV2Variant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputCapacityEntryV2Variant1>? outputCapacityEntryV2Variant1 = null,

            global::System.Action<global::OpenRouter.OutputCapacityEntryV2Variant2>? outputCapacityEntryV2Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputCapacityEntryV2Variant1 is { } __value0)
            {
                outputCapacityEntryV2Variant1?.Invoke(__value0);
            }
            else if (OutputCapacityEntryV2Variant2 is { } __value1)
            {
                outputCapacityEntryV2Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputCapacityEntryV2Variant1>? outputCapacityEntryV2Variant1 = null,
            global::System.Action<global::OpenRouter.OutputCapacityEntryV2Variant2>? outputCapacityEntryV2Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputCapacityEntryV2Variant1 is { } __value0)
            {
                outputCapacityEntryV2Variant1?.Invoke(__value0);
            }
            else if (OutputCapacityEntryV2Variant2 is { } __value1)
            {
                outputCapacityEntryV2Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputCapacityEntryV2Variant1,
                typeof(global::OpenRouter.OutputCapacityEntryV2Variant1),
                OutputCapacityEntryV2Variant2,
                typeof(global::OpenRouter.OutputCapacityEntryV2Variant2),
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
        public bool Equals(OutputCapacityEntryV2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputCapacityEntryV2Variant1?>.Default.Equals(OutputCapacityEntryV2Variant1, other.OutputCapacityEntryV2Variant1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputCapacityEntryV2Variant2?>.Default.Equals(OutputCapacityEntryV2Variant2, other.OutputCapacityEntryV2Variant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OutputCapacityEntryV2 obj1, OutputCapacityEntryV2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputCapacityEntryV2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputCapacityEntryV2 obj1, OutputCapacityEntryV2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputCapacityEntryV2 o && Equals(o);
        }
    }
}
