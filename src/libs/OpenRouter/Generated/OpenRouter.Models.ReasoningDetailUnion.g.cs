#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reasoning detail union schema
    /// </summary>
    public readonly partial struct ReasoningDetailUnion : global::System.IEquatable<ReasoningDetailUnion>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnionDiscriminatorType? Type { get; }

        /// <summary>
        /// Reasoning detail encrypted schema
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ReasoningDetailUnionVariant1? ReasoningEncrypted { get; init; }
#else
        public global::OpenRouter.ReasoningDetailUnionVariant1? ReasoningEncrypted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningEncrypted))]
#endif
        public bool IsReasoningEncrypted => ReasoningEncrypted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReasoningEncrypted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ReasoningDetailUnionVariant1? value)
        {
            value = ReasoningEncrypted;
            return IsReasoningEncrypted;
        }

        /// <summary>
        /// Reasoning detail summary schema
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ReasoningDetailUnionVariant2? ReasoningSummary { get; init; }
#else
        public global::OpenRouter.ReasoningDetailUnionVariant2? ReasoningSummary { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningSummary))]
#endif
        public bool IsReasoningSummary => ReasoningSummary != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReasoningSummary(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ReasoningDetailUnionVariant2? value)
        {
            value = ReasoningSummary;
            return IsReasoningSummary;
        }

        /// <summary>
        /// Reasoning detail text schema
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ReasoningDetailUnionVariant3? ReasoningText { get; init; }
#else
        public global::OpenRouter.ReasoningDetailUnionVariant3? ReasoningText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningText))]
#endif
        public bool IsReasoningText => ReasoningText != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReasoningText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ReasoningDetailUnionVariant3? value)
        {
            value = ReasoningText;
            return IsReasoningText;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReasoningDetailUnion(global::OpenRouter.ReasoningDetailUnionVariant1 value) => new ReasoningDetailUnion((global::OpenRouter.ReasoningDetailUnionVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ReasoningDetailUnionVariant1?(ReasoningDetailUnion @this) => @this.ReasoningEncrypted;

        /// <summary>
        /// 
        /// </summary>
        public ReasoningDetailUnion(global::OpenRouter.ReasoningDetailUnionVariant1? value)
        {
            ReasoningEncrypted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReasoningDetailUnion(global::OpenRouter.ReasoningDetailUnionVariant2 value) => new ReasoningDetailUnion((global::OpenRouter.ReasoningDetailUnionVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ReasoningDetailUnionVariant2?(ReasoningDetailUnion @this) => @this.ReasoningSummary;

        /// <summary>
        /// 
        /// </summary>
        public ReasoningDetailUnion(global::OpenRouter.ReasoningDetailUnionVariant2? value)
        {
            ReasoningSummary = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReasoningDetailUnion(global::OpenRouter.ReasoningDetailUnionVariant3 value) => new ReasoningDetailUnion((global::OpenRouter.ReasoningDetailUnionVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ReasoningDetailUnionVariant3?(ReasoningDetailUnion @this) => @this.ReasoningText;

        /// <summary>
        /// 
        /// </summary>
        public ReasoningDetailUnion(global::OpenRouter.ReasoningDetailUnionVariant3? value)
        {
            ReasoningText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ReasoningDetailUnion(
            global::OpenRouter.ReasoningDetailUnionDiscriminatorType? type,
            global::OpenRouter.ReasoningDetailUnionVariant1? reasoningEncrypted,
            global::OpenRouter.ReasoningDetailUnionVariant2? reasoningSummary,
            global::OpenRouter.ReasoningDetailUnionVariant3? reasoningText
            )
        {
            Type = type;

            ReasoningEncrypted = reasoningEncrypted;
            ReasoningSummary = reasoningSummary;
            ReasoningText = reasoningText;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ReasoningText as object ??
            ReasoningSummary as object ??
            ReasoningEncrypted as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ReasoningEncrypted?.ToString() ??
            ReasoningSummary?.ToString() ??
            ReasoningText?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReasoningEncrypted && !IsReasoningSummary && !IsReasoningText || !IsReasoningEncrypted && IsReasoningSummary && !IsReasoningText || !IsReasoningEncrypted && !IsReasoningSummary && IsReasoningText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ReasoningDetailUnionVariant1, TResult>? reasoningEncrypted = null,
            global::System.Func<global::OpenRouter.ReasoningDetailUnionVariant2, TResult>? reasoningSummary = null,
            global::System.Func<global::OpenRouter.ReasoningDetailUnionVariant3, TResult>? reasoningText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningEncrypted && reasoningEncrypted != null)
            {
                return reasoningEncrypted(ReasoningEncrypted!);
            }
            else if (IsReasoningSummary && reasoningSummary != null)
            {
                return reasoningSummary(ReasoningSummary!);
            }
            else if (IsReasoningText && reasoningText != null)
            {
                return reasoningText(ReasoningText!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ReasoningDetailUnionVariant1>? reasoningEncrypted = null,

            global::System.Action<global::OpenRouter.ReasoningDetailUnionVariant2>? reasoningSummary = null,

            global::System.Action<global::OpenRouter.ReasoningDetailUnionVariant3>? reasoningText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningEncrypted)
            {
                reasoningEncrypted?.Invoke(ReasoningEncrypted!);
            }
            else if (IsReasoningSummary)
            {
                reasoningSummary?.Invoke(ReasoningSummary!);
            }
            else if (IsReasoningText)
            {
                reasoningText?.Invoke(ReasoningText!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ReasoningDetailUnionVariant1>? reasoningEncrypted = null,
            global::System.Action<global::OpenRouter.ReasoningDetailUnionVariant2>? reasoningSummary = null,
            global::System.Action<global::OpenRouter.ReasoningDetailUnionVariant3>? reasoningText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningEncrypted)
            {
                reasoningEncrypted?.Invoke(ReasoningEncrypted!);
            }
            else if (IsReasoningSummary)
            {
                reasoningSummary?.Invoke(ReasoningSummary!);
            }
            else if (IsReasoningText)
            {
                reasoningText?.Invoke(ReasoningText!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ReasoningEncrypted,
                typeof(global::OpenRouter.ReasoningDetailUnionVariant1),
                ReasoningSummary,
                typeof(global::OpenRouter.ReasoningDetailUnionVariant2),
                ReasoningText,
                typeof(global::OpenRouter.ReasoningDetailUnionVariant3),
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
        public bool Equals(ReasoningDetailUnion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ReasoningDetailUnionVariant1?>.Default.Equals(ReasoningEncrypted, other.ReasoningEncrypted) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ReasoningDetailUnionVariant2?>.Default.Equals(ReasoningSummary, other.ReasoningSummary) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ReasoningDetailUnionVariant3?>.Default.Equals(ReasoningText, other.ReasoningText) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ReasoningDetailUnion obj1, ReasoningDetailUnion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReasoningDetailUnion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ReasoningDetailUnion obj1, ReasoningDetailUnion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReasoningDetailUnion o && Equals(o);
        }
    }
}
