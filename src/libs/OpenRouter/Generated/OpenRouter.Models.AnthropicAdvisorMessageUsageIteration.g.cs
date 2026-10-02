#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"cache_creation":null,"cache_creation_input_tokens":0,"cache_read_input_tokens":0,"input_tokens":823,"model":"claude-opus-4-6","output_tokens":1612,"type":"advisor_message"}
    /// </summary>
    public readonly partial struct AnthropicAdvisorMessageUsageIteration : global::System.IEquatable<AnthropicAdvisorMessageUsageIteration>
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
        public global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2? AnthropicAdvisorMessageUsageIterationVariant2 { get; init; }
#else
        public global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2? AnthropicAdvisorMessageUsageIterationVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicAdvisorMessageUsageIterationVariant2))]
#endif
        public bool IsAnthropicAdvisorMessageUsageIterationVariant2 => AnthropicAdvisorMessageUsageIterationVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAnthropicAdvisorMessageUsageIterationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2? value)
        {
            value = AnthropicAdvisorMessageUsageIterationVariant2;
            return IsAnthropicAdvisorMessageUsageIterationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2 PickAnthropicAdvisorMessageUsageIterationVariant2() => AnthropicAdvisorMessageUsageIterationVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicAdvisorMessageUsageIterationVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicAdvisorMessageUsageIteration(global::OpenRouter.AnthropicBaseUsageIteration value) => new AnthropicAdvisorMessageUsageIteration((global::OpenRouter.AnthropicBaseUsageIteration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicBaseUsageIteration?(AnthropicAdvisorMessageUsageIteration @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public AnthropicAdvisorMessageUsageIteration(global::OpenRouter.AnthropicBaseUsageIteration? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicAdvisorMessageUsageIteration FromBase(global::OpenRouter.AnthropicBaseUsageIteration? value) => new AnthropicAdvisorMessageUsageIteration(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicAdvisorMessageUsageIteration(global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2 value) => new AnthropicAdvisorMessageUsageIteration((global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2?(AnthropicAdvisorMessageUsageIteration @this) => @this.AnthropicAdvisorMessageUsageIterationVariant2;

        /// <summary>
        ///
        /// </summary>
        public AnthropicAdvisorMessageUsageIteration(global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2? value)
        {
            AnthropicAdvisorMessageUsageIterationVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicAdvisorMessageUsageIteration FromAnthropicAdvisorMessageUsageIterationVariant2(global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2? value) => new AnthropicAdvisorMessageUsageIteration(value);

        /// <summary>
        ///
        /// </summary>
        public AnthropicAdvisorMessageUsageIteration(
            global::OpenRouter.AnthropicBaseUsageIteration? @base,
            global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2? anthropicAdvisorMessageUsageIterationVariant2
            )
        {
            Base = @base;
            AnthropicAdvisorMessageUsageIterationVariant2 = anthropicAdvisorMessageUsageIterationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AnthropicAdvisorMessageUsageIterationVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            AnthropicAdvisorMessageUsageIterationVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsAnthropicAdvisorMessageUsageIterationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicBaseUsageIteration, TResult>? @base = null,
            global::System.Func<global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2, TResult>? anthropicAdvisorMessageUsageIterationVariant2 = null,
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
            else if (AnthropicAdvisorMessageUsageIterationVariant2 is { } __value1 && anthropicAdvisorMessageUsageIterationVariant2 != null)
            {
                return anthropicAdvisorMessageUsageIterationVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicBaseUsageIteration>? @base = null,

            global::System.Action<global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2>? anthropicAdvisorMessageUsageIterationVariant2 = null,
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
            else if (AnthropicAdvisorMessageUsageIterationVariant2 is { } __value1)
            {
                anthropicAdvisorMessageUsageIterationVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicBaseUsageIteration>? @base = null,
            global::System.Action<global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2>? anthropicAdvisorMessageUsageIterationVariant2 = null,
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
            else if (AnthropicAdvisorMessageUsageIterationVariant2 is { } __value1)
            {
                anthropicAdvisorMessageUsageIterationVariant2?.Invoke(__value1);
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
                AnthropicAdvisorMessageUsageIterationVariant2,
                typeof(global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2),
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
        public bool Equals(AnthropicAdvisorMessageUsageIteration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicBaseUsageIteration?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2?>.Default.Equals(AnthropicAdvisorMessageUsageIterationVariant2, other.AnthropicAdvisorMessageUsageIterationVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AnthropicAdvisorMessageUsageIteration obj1, AnthropicAdvisorMessageUsageIteration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicAdvisorMessageUsageIteration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicAdvisorMessageUsageIteration obj1, AnthropicAdvisorMessageUsageIteration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicAdvisorMessageUsageIteration o && Equals(o);
        }
    }
}
