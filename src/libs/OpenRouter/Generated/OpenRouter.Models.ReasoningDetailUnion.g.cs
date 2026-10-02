#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reasoning detail union schema<br/>
    /// Example: {"summary":"The model analyzed the problem by first identifying key constraints, then evaluating possible solutions...","type":"reasoning.summary"}
    /// </summary>
    public readonly partial struct ReasoningDetailUnion : global::System.IEquatable<ReasoningDetailUnion>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnionDiscriminatorType? Type { get; }

        /// <summary>
        /// Reasoning detail summary schema<br/>
        /// Example: {"summary":"The model analyzed the problem by first identifying key constraints, then evaluating possible solutions...","type":"reasoning.summary"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ReasoningDetailSummary? ReasoningSummary { get; init; }
#else
        public global::OpenRouter.ReasoningDetailSummary? ReasoningSummary { get; }
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
            out global::OpenRouter.ReasoningDetailSummary? value)
        {
            value = ReasoningSummary;
            return IsReasoningSummary;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailSummary PickReasoningSummary() => ReasoningSummary is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningSummary' but the value was {ToString()}.");

        /// <summary>
        /// Reasoning detail encrypted schema<br/>
        /// Example: {"data":"encrypted data","type":"reasoning.encrypted"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ReasoningDetailEncrypted? ReasoningEncrypted { get; init; }
#else
        public global::OpenRouter.ReasoningDetailEncrypted? ReasoningEncrypted { get; }
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
            out global::OpenRouter.ReasoningDetailEncrypted? value)
        {
            value = ReasoningEncrypted;
            return IsReasoningEncrypted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailEncrypted PickReasoningEncrypted() => ReasoningEncrypted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningEncrypted' but the value was {ToString()}.");

        /// <summary>
        /// Reasoning detail text schema<br/>
        /// Example: {"signature":"signature","text":"The model analyzed the problem by first identifying key constraints, then evaluating possible solutions...","type":"reasoning.text"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ReasoningDetailText? ReasoningText { get; init; }
#else
        public global::OpenRouter.ReasoningDetailText? ReasoningText { get; }
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
            out global::OpenRouter.ReasoningDetailText? value)
        {
            value = ReasoningText;
            return IsReasoningText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailText PickReasoningText() => ReasoningText is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningText' but the value was {ToString()}.");

        /// <summary>
        /// Record of an OpenRouter server-tool invocation (e.g. openrouter:fusion), carried in reasoning_details so a prior tool call can be rehydrated into a later turn of the same conversation.<br/>
        /// Example: {"arguments":"{\u0022prompt\u0022:\u0022Compare carbon tax proposals\u0022}","result":"{\u0022status\u0022:\u0022ok\u0022,\u0022models\u0022:[\u0022openai/gpt-4o\u0022]}","tool_call_id":"call_abc123","tool_name":"openrouter:fusion","type":"reasoning.server_tool_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ReasoningDetailServerToolCall? ReasoningServerToolCall { get; init; }
#else
        public global::OpenRouter.ReasoningDetailServerToolCall? ReasoningServerToolCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningServerToolCall))]
#endif
        public bool IsReasoningServerToolCall => ReasoningServerToolCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReasoningServerToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ReasoningDetailServerToolCall? value)
        {
            value = ReasoningServerToolCall;
            return IsReasoningServerToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailServerToolCall PickReasoningServerToolCall() => ReasoningServerToolCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningServerToolCall' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ReasoningDetailUnion(global::OpenRouter.ReasoningDetailSummary value) => new ReasoningDetailUnion((global::OpenRouter.ReasoningDetailSummary?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ReasoningDetailSummary?(ReasoningDetailUnion @this) => @this.ReasoningSummary;

        /// <summary>
        ///
        /// </summary>
        public ReasoningDetailUnion(global::OpenRouter.ReasoningDetailSummary? value)
        {
            ReasoningSummary = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ReasoningDetailUnion FromReasoningSummary(global::OpenRouter.ReasoningDetailSummary? value) => new ReasoningDetailUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ReasoningDetailUnion(global::OpenRouter.ReasoningDetailEncrypted value) => new ReasoningDetailUnion((global::OpenRouter.ReasoningDetailEncrypted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ReasoningDetailEncrypted?(ReasoningDetailUnion @this) => @this.ReasoningEncrypted;

        /// <summary>
        ///
        /// </summary>
        public ReasoningDetailUnion(global::OpenRouter.ReasoningDetailEncrypted? value)
        {
            ReasoningEncrypted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ReasoningDetailUnion FromReasoningEncrypted(global::OpenRouter.ReasoningDetailEncrypted? value) => new ReasoningDetailUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ReasoningDetailUnion(global::OpenRouter.ReasoningDetailText value) => new ReasoningDetailUnion((global::OpenRouter.ReasoningDetailText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ReasoningDetailText?(ReasoningDetailUnion @this) => @this.ReasoningText;

        /// <summary>
        ///
        /// </summary>
        public ReasoningDetailUnion(global::OpenRouter.ReasoningDetailText? value)
        {
            ReasoningText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ReasoningDetailUnion FromReasoningText(global::OpenRouter.ReasoningDetailText? value) => new ReasoningDetailUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ReasoningDetailUnion(global::OpenRouter.ReasoningDetailServerToolCall value) => new ReasoningDetailUnion((global::OpenRouter.ReasoningDetailServerToolCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ReasoningDetailServerToolCall?(ReasoningDetailUnion @this) => @this.ReasoningServerToolCall;

        /// <summary>
        ///
        /// </summary>
        public ReasoningDetailUnion(global::OpenRouter.ReasoningDetailServerToolCall? value)
        {
            ReasoningServerToolCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ReasoningDetailUnion FromReasoningServerToolCall(global::OpenRouter.ReasoningDetailServerToolCall? value) => new ReasoningDetailUnion(value);

        /// <summary>
        ///
        /// </summary>
        public ReasoningDetailUnion(
            global::OpenRouter.ReasoningDetailUnionDiscriminatorType? type,
            global::OpenRouter.ReasoningDetailSummary? reasoningSummary,
            global::OpenRouter.ReasoningDetailEncrypted? reasoningEncrypted,
            global::OpenRouter.ReasoningDetailText? reasoningText,
            global::OpenRouter.ReasoningDetailServerToolCall? reasoningServerToolCall
            )
        {
            Type = type;

            ReasoningSummary = reasoningSummary;
            ReasoningEncrypted = reasoningEncrypted;
            ReasoningText = reasoningText;
            ReasoningServerToolCall = reasoningServerToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ReasoningServerToolCall as object ??
            ReasoningText as object ??
            ReasoningEncrypted as object ??
            ReasoningSummary as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ReasoningSummary?.ToString() ??
            ReasoningEncrypted?.ToString() ??
            ReasoningText?.ToString() ??
            ReasoningServerToolCall?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsReasoningSummary && !IsReasoningEncrypted && !IsReasoningText && !IsReasoningServerToolCall || !IsReasoningSummary && IsReasoningEncrypted && !IsReasoningText && !IsReasoningServerToolCall || !IsReasoningSummary && !IsReasoningEncrypted && IsReasoningText && !IsReasoningServerToolCall || !IsReasoningSummary && !IsReasoningEncrypted && !IsReasoningText && IsReasoningServerToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ReasoningDetailSummary, TResult>? reasoningSummary = null,
            global::System.Func<global::OpenRouter.ReasoningDetailEncrypted, TResult>? reasoningEncrypted = null,
            global::System.Func<global::OpenRouter.ReasoningDetailText, TResult>? reasoningText = null,
            global::System.Func<global::OpenRouter.ReasoningDetailServerToolCall, TResult>? reasoningServerToolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ReasoningSummary is { } __value0 && reasoningSummary != null)
            {
                return reasoningSummary(__value0);
            }
            else if (ReasoningEncrypted is { } __value1 && reasoningEncrypted != null)
            {
                return reasoningEncrypted(__value1);
            }
            else if (ReasoningText is { } __value2 && reasoningText != null)
            {
                return reasoningText(__value2);
            }
            else if (ReasoningServerToolCall is { } __value3 && reasoningServerToolCall != null)
            {
                return reasoningServerToolCall(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ReasoningDetailSummary>? reasoningSummary = null,

            global::System.Action<global::OpenRouter.ReasoningDetailEncrypted>? reasoningEncrypted = null,

            global::System.Action<global::OpenRouter.ReasoningDetailText>? reasoningText = null,

            global::System.Action<global::OpenRouter.ReasoningDetailServerToolCall>? reasoningServerToolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ReasoningSummary is { } __value0)
            {
                reasoningSummary?.Invoke(__value0);
            }
            else if (ReasoningEncrypted is { } __value1)
            {
                reasoningEncrypted?.Invoke(__value1);
            }
            else if (ReasoningText is { } __value2)
            {
                reasoningText?.Invoke(__value2);
            }
            else if (ReasoningServerToolCall is { } __value3)
            {
                reasoningServerToolCall?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ReasoningDetailSummary>? reasoningSummary = null,
            global::System.Action<global::OpenRouter.ReasoningDetailEncrypted>? reasoningEncrypted = null,
            global::System.Action<global::OpenRouter.ReasoningDetailText>? reasoningText = null,
            global::System.Action<global::OpenRouter.ReasoningDetailServerToolCall>? reasoningServerToolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ReasoningSummary is { } __value0)
            {
                reasoningSummary?.Invoke(__value0);
            }
            else if (ReasoningEncrypted is { } __value1)
            {
                reasoningEncrypted?.Invoke(__value1);
            }
            else if (ReasoningText is { } __value2)
            {
                reasoningText?.Invoke(__value2);
            }
            else if (ReasoningServerToolCall is { } __value3)
            {
                reasoningServerToolCall?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ReasoningSummary,
                typeof(global::OpenRouter.ReasoningDetailSummary),
                ReasoningEncrypted,
                typeof(global::OpenRouter.ReasoningDetailEncrypted),
                ReasoningText,
                typeof(global::OpenRouter.ReasoningDetailText),
                ReasoningServerToolCall,
                typeof(global::OpenRouter.ReasoningDetailServerToolCall),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ReasoningDetailSummary?>.Default.Equals(ReasoningSummary, other.ReasoningSummary) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ReasoningDetailEncrypted?>.Default.Equals(ReasoningEncrypted, other.ReasoningEncrypted) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ReasoningDetailText?>.Default.Equals(ReasoningText, other.ReasoningText) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ReasoningDetailServerToolCall?>.Default.Equals(ReasoningServerToolCall, other.ReasoningServerToolCall)
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
