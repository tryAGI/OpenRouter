#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"cache_creation":null,"cache_creation_input_tokens":0,"cache_read_input_tokens":0,"input_tokens":100,"output_tokens":50,"type":"unknown"}
    /// </summary>
    public readonly partial struct AnthropicUnknownUsageIteration : global::System.IEquatable<AnthropicUnknownUsageIteration>
    {
        /// <summary>
        /// Example: {"cache_creation":null,"cache_creation_input_tokens":0,"cache_read_input_tokens":0,"input_tokens":100,"output_tokens":50}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicBaseUsageIteration? Base { get; init; }
#else
        public global::OpenRouter.AnthropicBaseUsageIteration? Base { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicBaseUsageIteration? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBaseUsageIteration PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicUnknownUsageIterationVariant2? AnthropicUnknownUsageIterationVariant2 { get; init; }
#else
        public global::OpenRouter.AnthropicUnknownUsageIterationVariant2? AnthropicUnknownUsageIterationVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicUnknownUsageIterationVariant2))]
#endif
        public bool IsAnthropicUnknownUsageIterationVariant2 => AnthropicUnknownUsageIterationVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAnthropicUnknownUsageIterationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicUnknownUsageIterationVariant2? value)
        {
            value = AnthropicUnknownUsageIterationVariant2;
            return IsAnthropicUnknownUsageIterationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUnknownUsageIterationVariant2 PickAnthropicUnknownUsageIterationVariant2() => AnthropicUnknownUsageIterationVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicUnknownUsageIterationVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicUnknownUsageIteration(global::OpenRouter.AnthropicBaseUsageIteration value) => new AnthropicUnknownUsageIteration((global::OpenRouter.AnthropicBaseUsageIteration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicBaseUsageIteration?(AnthropicUnknownUsageIteration @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public AnthropicUnknownUsageIteration(global::OpenRouter.AnthropicBaseUsageIteration? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicUnknownUsageIteration FromBase(global::OpenRouter.AnthropicBaseUsageIteration? value) => new AnthropicUnknownUsageIteration(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicUnknownUsageIteration(global::OpenRouter.AnthropicUnknownUsageIterationVariant2 value) => new AnthropicUnknownUsageIteration((global::OpenRouter.AnthropicUnknownUsageIterationVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicUnknownUsageIterationVariant2?(AnthropicUnknownUsageIteration @this) => @this.AnthropicUnknownUsageIterationVariant2;

        /// <summary>
        ///
        /// </summary>
        public AnthropicUnknownUsageIteration(global::OpenRouter.AnthropicUnknownUsageIterationVariant2? value)
        {
            AnthropicUnknownUsageIterationVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicUnknownUsageIteration FromAnthropicUnknownUsageIterationVariant2(global::OpenRouter.AnthropicUnknownUsageIterationVariant2? value) => new AnthropicUnknownUsageIteration(value);

        /// <summary>
        ///
        /// </summary>
        public AnthropicUnknownUsageIteration(
            global::OpenRouter.AnthropicBaseUsageIteration? @base,
            global::OpenRouter.AnthropicUnknownUsageIterationVariant2? anthropicUnknownUsageIterationVariant2
            )
        {
            Base = @base;
            AnthropicUnknownUsageIterationVariant2 = anthropicUnknownUsageIterationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AnthropicUnknownUsageIterationVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            AnthropicUnknownUsageIterationVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsAnthropicUnknownUsageIterationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicBaseUsageIteration, TResult>? @base = null,
            global::System.Func<global::OpenRouter.AnthropicUnknownUsageIterationVariant2, TResult>? anthropicUnknownUsageIterationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0 && @base != null)
            {
                return @base(__value0);
            }
            else if (AnthropicUnknownUsageIterationVariant2 is { } __value1 && anthropicUnknownUsageIterationVariant2 != null)
            {
                return anthropicUnknownUsageIterationVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicBaseUsageIteration>? @base = null,

            global::System.Action<global::OpenRouter.AnthropicUnknownUsageIterationVariant2>? anthropicUnknownUsageIterationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (AnthropicUnknownUsageIterationVariant2 is { } __value1)
            {
                anthropicUnknownUsageIterationVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicBaseUsageIteration>? @base = null,
            global::System.Action<global::OpenRouter.AnthropicUnknownUsageIterationVariant2>? anthropicUnknownUsageIterationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (AnthropicUnknownUsageIterationVariant2 is { } __value1)
            {
                anthropicUnknownUsageIterationVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::OpenRouter.AnthropicBaseUsageIteration),
                AnthropicUnknownUsageIterationVariant2,
                typeof(global::OpenRouter.AnthropicUnknownUsageIterationVariant2),
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
        public bool Equals(AnthropicUnknownUsageIteration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicBaseUsageIteration?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicUnknownUsageIterationVariant2?>.Default.Equals(AnthropicUnknownUsageIterationVariant2, other.AnthropicUnknownUsageIterationVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AnthropicUnknownUsageIteration obj1, AnthropicUnknownUsageIteration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicUnknownUsageIteration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicUnknownUsageIteration obj1, AnthropicUnknownUsageIteration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicUnknownUsageIteration o && Equals(o);
        }
    }
}
