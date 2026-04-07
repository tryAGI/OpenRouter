#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnthropicCaller : global::System.IEquatable<AnthropicCaller>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicDirectCaller? AnthropicDirectCaller { get; init; }
#else
        public global::OpenRouter.AnthropicDirectCaller? AnthropicDirectCaller { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicDirectCaller))]
#endif
        public bool IsAnthropicDirectCaller => AnthropicDirectCaller != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCodeExecution20250825Caller? AnthropicCodeExecution20250825Caller { get; init; }
#else
        public global::OpenRouter.AnthropicCodeExecution20250825Caller? AnthropicCodeExecution20250825Caller { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicCodeExecution20250825Caller))]
#endif
        public bool IsAnthropicCodeExecution20250825Caller => AnthropicCodeExecution20250825Caller != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCodeExecution20260120Caller? AnthropicCodeExecution20260120Caller { get; init; }
#else
        public global::OpenRouter.AnthropicCodeExecution20260120Caller? AnthropicCodeExecution20260120Caller { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicCodeExecution20260120Caller))]
#endif
        public bool IsAnthropicCodeExecution20260120Caller => AnthropicCodeExecution20260120Caller != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicCaller(global::OpenRouter.AnthropicDirectCaller value) => new AnthropicCaller((global::OpenRouter.AnthropicDirectCaller?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicDirectCaller?(AnthropicCaller @this) => @this.AnthropicDirectCaller;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicCaller(global::OpenRouter.AnthropicDirectCaller? value)
        {
            AnthropicDirectCaller = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicCaller(global::OpenRouter.AnthropicCodeExecution20250825Caller value) => new AnthropicCaller((global::OpenRouter.AnthropicCodeExecution20250825Caller?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCodeExecution20250825Caller?(AnthropicCaller @this) => @this.AnthropicCodeExecution20250825Caller;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicCaller(global::OpenRouter.AnthropicCodeExecution20250825Caller? value)
        {
            AnthropicCodeExecution20250825Caller = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicCaller(global::OpenRouter.AnthropicCodeExecution20260120Caller value) => new AnthropicCaller((global::OpenRouter.AnthropicCodeExecution20260120Caller?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCodeExecution20260120Caller?(AnthropicCaller @this) => @this.AnthropicCodeExecution20260120Caller;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicCaller(global::OpenRouter.AnthropicCodeExecution20260120Caller? value)
        {
            AnthropicCodeExecution20260120Caller = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicCaller(
            global::OpenRouter.AnthropicDirectCaller? anthropicDirectCaller,
            global::OpenRouter.AnthropicCodeExecution20250825Caller? anthropicCodeExecution20250825Caller,
            global::OpenRouter.AnthropicCodeExecution20260120Caller? anthropicCodeExecution20260120Caller
            )
        {
            AnthropicDirectCaller = anthropicDirectCaller;
            AnthropicCodeExecution20250825Caller = anthropicCodeExecution20250825Caller;
            AnthropicCodeExecution20260120Caller = anthropicCodeExecution20260120Caller;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicCodeExecution20260120Caller as object ??
            AnthropicCodeExecution20250825Caller as object ??
            AnthropicDirectCaller as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicDirectCaller?.ToString() ??
            AnthropicCodeExecution20250825Caller?.ToString() ??
            AnthropicCodeExecution20260120Caller?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicDirectCaller && !IsAnthropicCodeExecution20250825Caller && !IsAnthropicCodeExecution20260120Caller || !IsAnthropicDirectCaller && IsAnthropicCodeExecution20250825Caller && !IsAnthropicCodeExecution20260120Caller || !IsAnthropicDirectCaller && !IsAnthropicCodeExecution20250825Caller && IsAnthropicCodeExecution20260120Caller;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicDirectCaller?, TResult>? anthropicDirectCaller = null,
            global::System.Func<global::OpenRouter.AnthropicCodeExecution20250825Caller?, TResult>? anthropicCodeExecution20250825Caller = null,
            global::System.Func<global::OpenRouter.AnthropicCodeExecution20260120Caller?, TResult>? anthropicCodeExecution20260120Caller = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicDirectCaller && anthropicDirectCaller != null)
            {
                return anthropicDirectCaller(AnthropicDirectCaller!);
            }
            else if (IsAnthropicCodeExecution20250825Caller && anthropicCodeExecution20250825Caller != null)
            {
                return anthropicCodeExecution20250825Caller(AnthropicCodeExecution20250825Caller!);
            }
            else if (IsAnthropicCodeExecution20260120Caller && anthropicCodeExecution20260120Caller != null)
            {
                return anthropicCodeExecution20260120Caller(AnthropicCodeExecution20260120Caller!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicDirectCaller?>? anthropicDirectCaller = null,
            global::System.Action<global::OpenRouter.AnthropicCodeExecution20250825Caller?>? anthropicCodeExecution20250825Caller = null,
            global::System.Action<global::OpenRouter.AnthropicCodeExecution20260120Caller?>? anthropicCodeExecution20260120Caller = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicDirectCaller)
            {
                anthropicDirectCaller?.Invoke(AnthropicDirectCaller!);
            }
            else if (IsAnthropicCodeExecution20250825Caller)
            {
                anthropicCodeExecution20250825Caller?.Invoke(AnthropicCodeExecution20250825Caller!);
            }
            else if (IsAnthropicCodeExecution20260120Caller)
            {
                anthropicCodeExecution20260120Caller?.Invoke(AnthropicCodeExecution20260120Caller!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicDirectCaller,
                typeof(global::OpenRouter.AnthropicDirectCaller),
                AnthropicCodeExecution20250825Caller,
                typeof(global::OpenRouter.AnthropicCodeExecution20250825Caller),
                AnthropicCodeExecution20260120Caller,
                typeof(global::OpenRouter.AnthropicCodeExecution20260120Caller),
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
        public bool Equals(AnthropicCaller other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicDirectCaller?>.Default.Equals(AnthropicDirectCaller, other.AnthropicDirectCaller) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCodeExecution20250825Caller?>.Default.Equals(AnthropicCodeExecution20250825Caller, other.AnthropicCodeExecution20250825Caller) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCodeExecution20260120Caller?>.Default.Equals(AnthropicCodeExecution20260120Caller, other.AnthropicCodeExecution20260120Caller) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicCaller obj1, AnthropicCaller obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicCaller>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicCaller obj1, AnthropicCaller obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicCaller o && Equals(o);
        }
    }
}
