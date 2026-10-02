#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"cache_creation":null,"cache_creation_input_tokens":0,"cache_read_input_tokens":0,"input_tokens":100,"output_tokens":50,"type":"message"}
    /// </summary>
    public readonly partial struct AnthropicMessageUsageIteration : global::System.IEquatable<AnthropicMessageUsageIteration>
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
        public global::OpenRouter.AnthropicMessageUsageIterationVariant2? AnthropicMessageUsageIterationVariant2 { get; init; }
#else
        public global::OpenRouter.AnthropicMessageUsageIterationVariant2? AnthropicMessageUsageIterationVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicMessageUsageIterationVariant2))]
#endif
        public bool IsAnthropicMessageUsageIterationVariant2 => AnthropicMessageUsageIterationVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAnthropicMessageUsageIterationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicMessageUsageIterationVariant2? value)
        {
            value = AnthropicMessageUsageIterationVariant2;
            return IsAnthropicMessageUsageIterationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessageUsageIterationVariant2 PickAnthropicMessageUsageIterationVariant2() => AnthropicMessageUsageIterationVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicMessageUsageIterationVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicMessageUsageIteration(global::OpenRouter.AnthropicBaseUsageIteration value) => new AnthropicMessageUsageIteration((global::OpenRouter.AnthropicBaseUsageIteration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicBaseUsageIteration?(AnthropicMessageUsageIteration @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public AnthropicMessageUsageIteration(global::OpenRouter.AnthropicBaseUsageIteration? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicMessageUsageIteration FromBase(global::OpenRouter.AnthropicBaseUsageIteration? value) => new AnthropicMessageUsageIteration(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicMessageUsageIteration(global::OpenRouter.AnthropicMessageUsageIterationVariant2 value) => new AnthropicMessageUsageIteration((global::OpenRouter.AnthropicMessageUsageIterationVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicMessageUsageIterationVariant2?(AnthropicMessageUsageIteration @this) => @this.AnthropicMessageUsageIterationVariant2;

        /// <summary>
        ///
        /// </summary>
        public AnthropicMessageUsageIteration(global::OpenRouter.AnthropicMessageUsageIterationVariant2? value)
        {
            AnthropicMessageUsageIterationVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicMessageUsageIteration FromAnthropicMessageUsageIterationVariant2(global::OpenRouter.AnthropicMessageUsageIterationVariant2? value) => new AnthropicMessageUsageIteration(value);

        /// <summary>
        ///
        /// </summary>
        public AnthropicMessageUsageIteration(
            global::OpenRouter.AnthropicBaseUsageIteration? @base,
            global::OpenRouter.AnthropicMessageUsageIterationVariant2? anthropicMessageUsageIterationVariant2
            )
        {
            Base = @base;
            AnthropicMessageUsageIterationVariant2 = anthropicMessageUsageIterationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AnthropicMessageUsageIterationVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            AnthropicMessageUsageIterationVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsAnthropicMessageUsageIterationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicBaseUsageIteration, TResult>? @base = null,
            global::System.Func<global::OpenRouter.AnthropicMessageUsageIterationVariant2, TResult>? anthropicMessageUsageIterationVariant2 = null,
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
            else if (AnthropicMessageUsageIterationVariant2 is { } __value1 && anthropicMessageUsageIterationVariant2 != null)
            {
                return anthropicMessageUsageIterationVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicBaseUsageIteration>? @base = null,

            global::System.Action<global::OpenRouter.AnthropicMessageUsageIterationVariant2>? anthropicMessageUsageIterationVariant2 = null,
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
            else if (AnthropicMessageUsageIterationVariant2 is { } __value1)
            {
                anthropicMessageUsageIterationVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicBaseUsageIteration>? @base = null,
            global::System.Action<global::OpenRouter.AnthropicMessageUsageIterationVariant2>? anthropicMessageUsageIterationVariant2 = null,
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
            else if (AnthropicMessageUsageIterationVariant2 is { } __value1)
            {
                anthropicMessageUsageIterationVariant2?.Invoke(__value1);
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
                AnthropicMessageUsageIterationVariant2,
                typeof(global::OpenRouter.AnthropicMessageUsageIterationVariant2),
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
        public bool Equals(AnthropicMessageUsageIteration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicBaseUsageIteration?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicMessageUsageIterationVariant2?>.Default.Equals(AnthropicMessageUsageIterationVariant2, other.AnthropicMessageUsageIterationVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AnthropicMessageUsageIteration obj1, AnthropicMessageUsageIteration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicMessageUsageIteration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicMessageUsageIteration obj1, AnthropicMessageUsageIteration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicMessageUsageIteration o && Equals(o);
        }
    }
}
