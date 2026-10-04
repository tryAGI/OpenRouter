#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"type":"direct"}
    /// </summary>
    public readonly partial struct ORAnthropicNullableCaller : global::System.IEquatable<ORAnthropicNullableCaller>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicNullableCallerDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"type":"direct"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicDirectCaller? Direct { get; init; }
#else
        public global::OpenRouter.AnthropicDirectCaller? Direct { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Direct))]
#endif
        public bool IsDirect => Direct != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDirect(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicDirectCaller? value)
        {
            value = Direct;
            return IsDirect;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDirectCaller PickDirect() => Direct is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Direct' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"tool_id":"toolu_01abc","type":"code_execution_20250825"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCodeExecution20250825Caller? CodeExecution20250825 { get; init; }
#else
        public global::OpenRouter.AnthropicCodeExecution20250825Caller? CodeExecution20250825 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecution20250825))]
#endif
        public bool IsCodeExecution20250825 => CodeExecution20250825 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeExecution20250825(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicCodeExecution20250825Caller? value)
        {
            value = CodeExecution20250825;
            return IsCodeExecution20250825;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecution20250825Caller PickCodeExecution20250825() => CodeExecution20250825 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecution20250825' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"tool_id":"toolu_01abc","type":"code_execution_20260120"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCodeExecution20260120Caller? CodeExecution20260120 { get; init; }
#else
        public global::OpenRouter.AnthropicCodeExecution20260120Caller? CodeExecution20260120 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecution20260120))]
#endif
        public bool IsCodeExecution20260120 => CodeExecution20260120 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeExecution20260120(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicCodeExecution20260120Caller? value)
        {
            value = CodeExecution20260120;
            return IsCodeExecution20260120;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecution20260120Caller PickCodeExecution20260120() => CodeExecution20260120 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecution20260120' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicNullableCaller(global::OpenRouter.AnthropicDirectCaller value) => new ORAnthropicNullableCaller((global::OpenRouter.AnthropicDirectCaller?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicDirectCaller?(ORAnthropicNullableCaller @this) => @this.Direct;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicNullableCaller(global::OpenRouter.AnthropicDirectCaller? value)
        {
            Direct = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicNullableCaller FromDirect(global::OpenRouter.AnthropicDirectCaller? value) => new ORAnthropicNullableCaller(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicNullableCaller(global::OpenRouter.AnthropicCodeExecution20250825Caller value) => new ORAnthropicNullableCaller((global::OpenRouter.AnthropicCodeExecution20250825Caller?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCodeExecution20250825Caller?(ORAnthropicNullableCaller @this) => @this.CodeExecution20250825;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicNullableCaller(global::OpenRouter.AnthropicCodeExecution20250825Caller? value)
        {
            CodeExecution20250825 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicNullableCaller FromCodeExecution20250825(global::OpenRouter.AnthropicCodeExecution20250825Caller? value) => new ORAnthropicNullableCaller(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicNullableCaller(global::OpenRouter.AnthropicCodeExecution20260120Caller value) => new ORAnthropicNullableCaller((global::OpenRouter.AnthropicCodeExecution20260120Caller?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCodeExecution20260120Caller?(ORAnthropicNullableCaller @this) => @this.CodeExecution20260120;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicNullableCaller(global::OpenRouter.AnthropicCodeExecution20260120Caller? value)
        {
            CodeExecution20260120 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicNullableCaller FromCodeExecution20260120(global::OpenRouter.AnthropicCodeExecution20260120Caller? value) => new ORAnthropicNullableCaller(value);

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicNullableCaller(
            global::OpenRouter.ORAnthropicNullableCallerDiscriminatorType? type,
            global::OpenRouter.AnthropicDirectCaller? direct,
            global::OpenRouter.AnthropicCodeExecution20250825Caller? codeExecution20250825,
            global::OpenRouter.AnthropicCodeExecution20260120Caller? codeExecution20260120
            )
        {
            Type = type;

            Direct = direct;
            CodeExecution20250825 = codeExecution20250825;
            CodeExecution20260120 = codeExecution20260120;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CodeExecution20260120 as object ??
            CodeExecution20250825 as object ??
            Direct as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Direct?.ToString() ??
            CodeExecution20250825?.ToString() ??
            CodeExecution20260120?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDirect && !IsCodeExecution20250825 && !IsCodeExecution20260120 || !IsDirect && IsCodeExecution20250825 && !IsCodeExecution20260120 || !IsDirect && !IsCodeExecution20250825 && IsCodeExecution20260120;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicDirectCaller, TResult>? direct = null,
            global::System.Func<global::OpenRouter.AnthropicCodeExecution20250825Caller, TResult>? codeExecution20250825 = null,
            global::System.Func<global::OpenRouter.AnthropicCodeExecution20260120Caller, TResult>? codeExecution20260120 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Direct is { } __value0 && direct != null)
            {
                return direct(__value0);
            }
            else if (CodeExecution20250825 is { } __value1 && codeExecution20250825 != null)
            {
                return codeExecution20250825(__value1);
            }
            else if (CodeExecution20260120 is { } __value2 && codeExecution20260120 != null)
            {
                return codeExecution20260120(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicDirectCaller>? direct = null,

            global::System.Action<global::OpenRouter.AnthropicCodeExecution20250825Caller>? codeExecution20250825 = null,

            global::System.Action<global::OpenRouter.AnthropicCodeExecution20260120Caller>? codeExecution20260120 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Direct is { } __value0)
            {
                direct?.Invoke(__value0);
            }
            else if (CodeExecution20250825 is { } __value1)
            {
                codeExecution20250825?.Invoke(__value1);
            }
            else if (CodeExecution20260120 is { } __value2)
            {
                codeExecution20260120?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicDirectCaller>? direct = null,
            global::System.Action<global::OpenRouter.AnthropicCodeExecution20250825Caller>? codeExecution20250825 = null,
            global::System.Action<global::OpenRouter.AnthropicCodeExecution20260120Caller>? codeExecution20260120 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Direct is { } __value0)
            {
                direct?.Invoke(__value0);
            }
            else if (CodeExecution20250825 is { } __value1)
            {
                codeExecution20250825?.Invoke(__value1);
            }
            else if (CodeExecution20260120 is { } __value2)
            {
                codeExecution20260120?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Direct,
                typeof(global::OpenRouter.AnthropicDirectCaller),
                CodeExecution20250825,
                typeof(global::OpenRouter.AnthropicCodeExecution20250825Caller),
                CodeExecution20260120,
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
        public bool Equals(ORAnthropicNullableCaller other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicDirectCaller?>.Default.Equals(Direct, other.Direct) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCodeExecution20250825Caller?>.Default.Equals(CodeExecution20250825, other.CodeExecution20250825) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCodeExecution20260120Caller?>.Default.Equals(CodeExecution20260120, other.CodeExecution20260120)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ORAnthropicNullableCaller obj1, ORAnthropicNullableCaller obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ORAnthropicNullableCaller>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ORAnthropicNullableCaller obj1, ORAnthropicNullableCaller obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ORAnthropicNullableCaller o && Equals(o);
        }
    }
}
