#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnthropicUsageIteration : global::System.IEquatable<AnthropicUsageIteration>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCompactionUsageIteration? AnthropicCompactionUsageIteration { get; init; }
#else
        public global::OpenRouter.AnthropicCompactionUsageIteration? AnthropicCompactionUsageIteration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicCompactionUsageIteration))]
#endif
        public bool IsAnthropicCompactionUsageIteration => AnthropicCompactionUsageIteration != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicMessageUsageIteration? AnthropicMessageUsageIteration { get; init; }
#else
        public global::OpenRouter.AnthropicMessageUsageIteration? AnthropicMessageUsageIteration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicMessageUsageIteration))]
#endif
        public bool IsAnthropicMessageUsageIteration => AnthropicMessageUsageIteration != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicUnknownUsageIteration? AnthropicUnknownUsageIteration { get; init; }
#else
        public global::OpenRouter.AnthropicUnknownUsageIteration? AnthropicUnknownUsageIteration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicUnknownUsageIteration))]
#endif
        public bool IsAnthropicUnknownUsageIteration => AnthropicUnknownUsageIteration != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicUsageIteration(global::OpenRouter.AnthropicCompactionUsageIteration value) => new AnthropicUsageIteration((global::OpenRouter.AnthropicCompactionUsageIteration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCompactionUsageIteration?(AnthropicUsageIteration @this) => @this.AnthropicCompactionUsageIteration;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicUsageIteration(global::OpenRouter.AnthropicCompactionUsageIteration? value)
        {
            AnthropicCompactionUsageIteration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicUsageIteration(global::OpenRouter.AnthropicMessageUsageIteration value) => new AnthropicUsageIteration((global::OpenRouter.AnthropicMessageUsageIteration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicMessageUsageIteration?(AnthropicUsageIteration @this) => @this.AnthropicMessageUsageIteration;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicUsageIteration(global::OpenRouter.AnthropicMessageUsageIteration? value)
        {
            AnthropicMessageUsageIteration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicUsageIteration(global::OpenRouter.AnthropicUnknownUsageIteration value) => new AnthropicUsageIteration((global::OpenRouter.AnthropicUnknownUsageIteration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicUnknownUsageIteration?(AnthropicUsageIteration @this) => @this.AnthropicUnknownUsageIteration;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicUsageIteration(global::OpenRouter.AnthropicUnknownUsageIteration? value)
        {
            AnthropicUnknownUsageIteration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicUsageIteration(
            global::OpenRouter.AnthropicCompactionUsageIteration? anthropicCompactionUsageIteration,
            global::OpenRouter.AnthropicMessageUsageIteration? anthropicMessageUsageIteration,
            global::OpenRouter.AnthropicUnknownUsageIteration? anthropicUnknownUsageIteration
            )
        {
            AnthropicCompactionUsageIteration = anthropicCompactionUsageIteration;
            AnthropicMessageUsageIteration = anthropicMessageUsageIteration;
            AnthropicUnknownUsageIteration = anthropicUnknownUsageIteration;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicUnknownUsageIteration as object ??
            AnthropicMessageUsageIteration as object ??
            AnthropicCompactionUsageIteration as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicCompactionUsageIteration?.ToString() ??
            AnthropicMessageUsageIteration?.ToString() ??
            AnthropicUnknownUsageIteration?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicCompactionUsageIteration && !IsAnthropicMessageUsageIteration && !IsAnthropicUnknownUsageIteration || !IsAnthropicCompactionUsageIteration && IsAnthropicMessageUsageIteration && !IsAnthropicUnknownUsageIteration || !IsAnthropicCompactionUsageIteration && !IsAnthropicMessageUsageIteration && IsAnthropicUnknownUsageIteration;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicCompactionUsageIteration?, TResult>? anthropicCompactionUsageIteration = null,
            global::System.Func<global::OpenRouter.AnthropicMessageUsageIteration?, TResult>? anthropicMessageUsageIteration = null,
            global::System.Func<global::OpenRouter.AnthropicUnknownUsageIteration?, TResult>? anthropicUnknownUsageIteration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicCompactionUsageIteration && anthropicCompactionUsageIteration != null)
            {
                return anthropicCompactionUsageIteration(AnthropicCompactionUsageIteration!);
            }
            else if (IsAnthropicMessageUsageIteration && anthropicMessageUsageIteration != null)
            {
                return anthropicMessageUsageIteration(AnthropicMessageUsageIteration!);
            }
            else if (IsAnthropicUnknownUsageIteration && anthropicUnknownUsageIteration != null)
            {
                return anthropicUnknownUsageIteration(AnthropicUnknownUsageIteration!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicCompactionUsageIteration?>? anthropicCompactionUsageIteration = null,
            global::System.Action<global::OpenRouter.AnthropicMessageUsageIteration?>? anthropicMessageUsageIteration = null,
            global::System.Action<global::OpenRouter.AnthropicUnknownUsageIteration?>? anthropicUnknownUsageIteration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicCompactionUsageIteration)
            {
                anthropicCompactionUsageIteration?.Invoke(AnthropicCompactionUsageIteration!);
            }
            else if (IsAnthropicMessageUsageIteration)
            {
                anthropicMessageUsageIteration?.Invoke(AnthropicMessageUsageIteration!);
            }
            else if (IsAnthropicUnknownUsageIteration)
            {
                anthropicUnknownUsageIteration?.Invoke(AnthropicUnknownUsageIteration!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicCompactionUsageIteration,
                typeof(global::OpenRouter.AnthropicCompactionUsageIteration),
                AnthropicMessageUsageIteration,
                typeof(global::OpenRouter.AnthropicMessageUsageIteration),
                AnthropicUnknownUsageIteration,
                typeof(global::OpenRouter.AnthropicUnknownUsageIteration),
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
        public bool Equals(AnthropicUsageIteration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCompactionUsageIteration?>.Default.Equals(AnthropicCompactionUsageIteration, other.AnthropicCompactionUsageIteration) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicMessageUsageIteration?>.Default.Equals(AnthropicMessageUsageIteration, other.AnthropicMessageUsageIteration) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicUnknownUsageIteration?>.Default.Equals(AnthropicUnknownUsageIteration, other.AnthropicUnknownUsageIteration) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicUsageIteration obj1, AnthropicUsageIteration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicUsageIteration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicUsageIteration obj1, AnthropicUsageIteration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicUsageIteration o && Equals(o);
        }
    }
}
