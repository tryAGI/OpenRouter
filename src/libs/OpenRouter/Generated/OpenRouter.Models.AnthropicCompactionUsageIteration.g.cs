#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"cache_creation":null,"cache_creation_input_tokens":0,"cache_read_input_tokens":0,"input_tokens":50,"output_tokens":25,"type":"compaction"}
    /// </summary>
    public readonly partial struct AnthropicCompactionUsageIteration : global::System.IEquatable<AnthropicCompactionUsageIteration>
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
        public global::OpenRouter.AnthropicCompactionUsageIterationVariant2? AnthropicCompactionUsageIterationVariant2 { get; init; }
#else
        public global::OpenRouter.AnthropicCompactionUsageIterationVariant2? AnthropicCompactionUsageIterationVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicCompactionUsageIterationVariant2))]
#endif
        public bool IsAnthropicCompactionUsageIterationVariant2 => AnthropicCompactionUsageIterationVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAnthropicCompactionUsageIterationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicCompactionUsageIterationVariant2? value)
        {
            value = AnthropicCompactionUsageIterationVariant2;
            return IsAnthropicCompactionUsageIterationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionUsageIterationVariant2 PickAnthropicCompactionUsageIterationVariant2() => AnthropicCompactionUsageIterationVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicCompactionUsageIterationVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicCompactionUsageIteration(global::OpenRouter.AnthropicBaseUsageIteration value) => new AnthropicCompactionUsageIteration((global::OpenRouter.AnthropicBaseUsageIteration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicBaseUsageIteration?(AnthropicCompactionUsageIteration @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public AnthropicCompactionUsageIteration(global::OpenRouter.AnthropicBaseUsageIteration? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicCompactionUsageIteration FromBase(global::OpenRouter.AnthropicBaseUsageIteration? value) => new AnthropicCompactionUsageIteration(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicCompactionUsageIteration(global::OpenRouter.AnthropicCompactionUsageIterationVariant2 value) => new AnthropicCompactionUsageIteration((global::OpenRouter.AnthropicCompactionUsageIterationVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCompactionUsageIterationVariant2?(AnthropicCompactionUsageIteration @this) => @this.AnthropicCompactionUsageIterationVariant2;

        /// <summary>
        ///
        /// </summary>
        public AnthropicCompactionUsageIteration(global::OpenRouter.AnthropicCompactionUsageIterationVariant2? value)
        {
            AnthropicCompactionUsageIterationVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicCompactionUsageIteration FromAnthropicCompactionUsageIterationVariant2(global::OpenRouter.AnthropicCompactionUsageIterationVariant2? value) => new AnthropicCompactionUsageIteration(value);

        /// <summary>
        ///
        /// </summary>
        public AnthropicCompactionUsageIteration(
            global::OpenRouter.AnthropicBaseUsageIteration? @base,
            global::OpenRouter.AnthropicCompactionUsageIterationVariant2? anthropicCompactionUsageIterationVariant2
            )
        {
            Base = @base;
            AnthropicCompactionUsageIterationVariant2 = anthropicCompactionUsageIterationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AnthropicCompactionUsageIterationVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            AnthropicCompactionUsageIterationVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsAnthropicCompactionUsageIterationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicBaseUsageIteration, TResult>? @base = null,
            global::System.Func<global::OpenRouter.AnthropicCompactionUsageIterationVariant2, TResult>? anthropicCompactionUsageIterationVariant2 = null,
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
            else if (AnthropicCompactionUsageIterationVariant2 is { } __value1 && anthropicCompactionUsageIterationVariant2 != null)
            {
                return anthropicCompactionUsageIterationVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicBaseUsageIteration>? @base = null,

            global::System.Action<global::OpenRouter.AnthropicCompactionUsageIterationVariant2>? anthropicCompactionUsageIterationVariant2 = null,
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
            else if (AnthropicCompactionUsageIterationVariant2 is { } __value1)
            {
                anthropicCompactionUsageIterationVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicBaseUsageIteration>? @base = null,
            global::System.Action<global::OpenRouter.AnthropicCompactionUsageIterationVariant2>? anthropicCompactionUsageIterationVariant2 = null,
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
            else if (AnthropicCompactionUsageIterationVariant2 is { } __value1)
            {
                anthropicCompactionUsageIterationVariant2?.Invoke(__value1);
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
                AnthropicCompactionUsageIterationVariant2,
                typeof(global::OpenRouter.AnthropicCompactionUsageIterationVariant2),
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
        public bool Equals(AnthropicCompactionUsageIteration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicBaseUsageIteration?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCompactionUsageIterationVariant2?>.Default.Equals(AnthropicCompactionUsageIterationVariant2, other.AnthropicCompactionUsageIterationVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AnthropicCompactionUsageIteration obj1, AnthropicCompactionUsageIteration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicCompactionUsageIteration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicCompactionUsageIteration obj1, AnthropicCompactionUsageIteration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicCompactionUsageIteration o && Equals(o);
        }
    }
}
