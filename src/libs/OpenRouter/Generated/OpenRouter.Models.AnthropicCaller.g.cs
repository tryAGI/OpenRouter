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
        public global::OpenRouter.AnthropicCallerDiscriminatorType? Type { get; }

        /// <summary>
        /// code_execution_20250825 variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCallerVariant1? CodeExecution20250825 { get; init; }
#else
        public global::OpenRouter.AnthropicCallerVariant1? CodeExecution20250825 { get; }
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
            out global::OpenRouter.AnthropicCallerVariant1? value)
        {
            value = CodeExecution20250825;
            return IsCodeExecution20250825;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.AnthropicCallerVariant1 PickCodeExecution20250825() => IsCodeExecution20250825
            ? CodeExecution20250825!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecution20250825' but the value was {ToString()}.");

        /// <summary>
        /// code_execution_20260120 variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCallerVariant2? CodeExecution20260120 { get; init; }
#else
        public global::OpenRouter.AnthropicCallerVariant2? CodeExecution20260120 { get; }
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
            out global::OpenRouter.AnthropicCallerVariant2? value)
        {
            value = CodeExecution20260120;
            return IsCodeExecution20260120;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.AnthropicCallerVariant2 PickCodeExecution20260120() => IsCodeExecution20260120
            ? CodeExecution20260120!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecution20260120' but the value was {ToString()}.");

        /// <summary>
        /// direct variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCallerVariant3? Direct { get; init; }
#else
        public global::OpenRouter.AnthropicCallerVariant3? Direct { get; }
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
            out global::OpenRouter.AnthropicCallerVariant3? value)
        {
            value = Direct;
            return IsDirect;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.AnthropicCallerVariant3 PickDirect() => IsDirect
            ? Direct!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Direct' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicCaller(global::OpenRouter.AnthropicCallerVariant1 value) => new AnthropicCaller((global::OpenRouter.AnthropicCallerVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCallerVariant1?(AnthropicCaller @this) => @this.CodeExecution20250825;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicCaller(global::OpenRouter.AnthropicCallerVariant1? value)
        {
            CodeExecution20250825 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnthropicCaller FromCodeExecution20250825(global::OpenRouter.AnthropicCallerVariant1? value) => new AnthropicCaller(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicCaller(global::OpenRouter.AnthropicCallerVariant2 value) => new AnthropicCaller((global::OpenRouter.AnthropicCallerVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCallerVariant2?(AnthropicCaller @this) => @this.CodeExecution20260120;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicCaller(global::OpenRouter.AnthropicCallerVariant2? value)
        {
            CodeExecution20260120 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnthropicCaller FromCodeExecution20260120(global::OpenRouter.AnthropicCallerVariant2? value) => new AnthropicCaller(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicCaller(global::OpenRouter.AnthropicCallerVariant3 value) => new AnthropicCaller((global::OpenRouter.AnthropicCallerVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCallerVariant3?(AnthropicCaller @this) => @this.Direct;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicCaller(global::OpenRouter.AnthropicCallerVariant3? value)
        {
            Direct = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnthropicCaller FromDirect(global::OpenRouter.AnthropicCallerVariant3? value) => new AnthropicCaller(value);

        /// <summary>
        /// 
        /// </summary>
        public AnthropicCaller(
            global::OpenRouter.AnthropicCallerDiscriminatorType? type,
            global::OpenRouter.AnthropicCallerVariant1? codeExecution20250825,
            global::OpenRouter.AnthropicCallerVariant2? codeExecution20260120,
            global::OpenRouter.AnthropicCallerVariant3? direct
            )
        {
            Type = type;

            CodeExecution20250825 = codeExecution20250825;
            CodeExecution20260120 = codeExecution20260120;
            Direct = direct;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Direct as object ??
            CodeExecution20260120 as object ??
            CodeExecution20250825 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CodeExecution20250825?.ToString() ??
            CodeExecution20260120?.ToString() ??
            Direct?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCodeExecution20250825 && !IsCodeExecution20260120 && !IsDirect || !IsCodeExecution20250825 && IsCodeExecution20260120 && !IsDirect || !IsCodeExecution20250825 && !IsCodeExecution20260120 && IsDirect;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicCallerVariant1, TResult>? codeExecution20250825 = null,
            global::System.Func<global::OpenRouter.AnthropicCallerVariant2, TResult>? codeExecution20260120 = null,
            global::System.Func<global::OpenRouter.AnthropicCallerVariant3, TResult>? direct = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeExecution20250825 && codeExecution20250825 != null)
            {
                return codeExecution20250825(CodeExecution20250825!);
            }
            else if (IsCodeExecution20260120 && codeExecution20260120 != null)
            {
                return codeExecution20260120(CodeExecution20260120!);
            }
            else if (IsDirect && direct != null)
            {
                return direct(Direct!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicCallerVariant1>? codeExecution20250825 = null,

            global::System.Action<global::OpenRouter.AnthropicCallerVariant2>? codeExecution20260120 = null,

            global::System.Action<global::OpenRouter.AnthropicCallerVariant3>? direct = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeExecution20250825)
            {
                codeExecution20250825?.Invoke(CodeExecution20250825!);
            }
            else if (IsCodeExecution20260120)
            {
                codeExecution20260120?.Invoke(CodeExecution20260120!);
            }
            else if (IsDirect)
            {
                direct?.Invoke(Direct!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicCallerVariant1>? codeExecution20250825 = null,
            global::System.Action<global::OpenRouter.AnthropicCallerVariant2>? codeExecution20260120 = null,
            global::System.Action<global::OpenRouter.AnthropicCallerVariant3>? direct = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeExecution20250825)
            {
                codeExecution20250825?.Invoke(CodeExecution20250825!);
            }
            else if (IsCodeExecution20260120)
            {
                codeExecution20260120?.Invoke(CodeExecution20260120!);
            }
            else if (IsDirect)
            {
                direct?.Invoke(Direct!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CodeExecution20250825,
                typeof(global::OpenRouter.AnthropicCallerVariant1),
                CodeExecution20260120,
                typeof(global::OpenRouter.AnthropicCallerVariant2),
                Direct,
                typeof(global::OpenRouter.AnthropicCallerVariant3),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCallerVariant1?>.Default.Equals(CodeExecution20250825, other.CodeExecution20250825) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCallerVariant2?>.Default.Equals(CodeExecution20260120, other.CodeExecution20260120) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCallerVariant3?>.Default.Equals(Direct, other.Direct) 
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
