#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Log probability information for a token<br/>
    /// Example: {"bytes":[72,101,108,108,111],"logprob":-0.5,"token":"Hello","top_logprobs":[]}
    /// </summary>
    public readonly partial struct StreamLogprob : global::System.IEquatable<StreamLogprob>
    {
        /// <summary>
        /// Log probability information for a token<br/>
        /// Example: {"logprob":-0.1,"token":"world","top_logprobs":[{"logprob":-0.5,"token":"hello"}]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenResponsesLogProbs? OpenResponsesLogProbs { get; init; }
#else
        public global::OpenRouter.OpenResponsesLogProbs? OpenResponsesLogProbs { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenResponsesLogProbs))]
#endif
        public bool IsOpenResponsesLogProbs => OpenResponsesLogProbs != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenResponsesLogProbs(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenResponsesLogProbs? value)
        {
            value = OpenResponsesLogProbs;
            return IsOpenResponsesLogProbs;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesLogProbs PickOpenResponsesLogProbs() => OpenResponsesLogProbs is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenResponsesLogProbs' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StreamLogprobVariant2? StreamLogprobVariant2 { get; init; }
#else
        public global::OpenRouter.StreamLogprobVariant2? StreamLogprobVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamLogprobVariant2))]
#endif
        public bool IsStreamLogprobVariant2 => StreamLogprobVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStreamLogprobVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.StreamLogprobVariant2? value)
        {
            value = StreamLogprobVariant2;
            return IsStreamLogprobVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamLogprobVariant2 PickStreamLogprobVariant2() => StreamLogprobVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamLogprobVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamLogprob(global::OpenRouter.OpenResponsesLogProbs value) => new StreamLogprob((global::OpenRouter.OpenResponsesLogProbs?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenResponsesLogProbs?(StreamLogprob @this) => @this.OpenResponsesLogProbs;

        /// <summary>
        ///
        /// </summary>
        public StreamLogprob(global::OpenRouter.OpenResponsesLogProbs? value)
        {
            OpenResponsesLogProbs = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamLogprob FromOpenResponsesLogProbs(global::OpenRouter.OpenResponsesLogProbs? value) => new StreamLogprob(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamLogprob(global::OpenRouter.StreamLogprobVariant2 value) => new StreamLogprob((global::OpenRouter.StreamLogprobVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StreamLogprobVariant2?(StreamLogprob @this) => @this.StreamLogprobVariant2;

        /// <summary>
        ///
        /// </summary>
        public StreamLogprob(global::OpenRouter.StreamLogprobVariant2? value)
        {
            StreamLogprobVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamLogprob FromStreamLogprobVariant2(global::OpenRouter.StreamLogprobVariant2? value) => new StreamLogprob(value);

        /// <summary>
        ///
        /// </summary>
        public StreamLogprob(
            global::OpenRouter.OpenResponsesLogProbs? openResponsesLogProbs,
            global::OpenRouter.StreamLogprobVariant2? streamLogprobVariant2
            )
        {
            OpenResponsesLogProbs = openResponsesLogProbs;
            StreamLogprobVariant2 = streamLogprobVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StreamLogprobVariant2 as object ??
            OpenResponsesLogProbs as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OpenResponsesLogProbs?.ToString() ??
            StreamLogprobVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpenResponsesLogProbs && IsStreamLogprobVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenResponsesLogProbs, TResult>? openResponsesLogProbs = null,
            global::System.Func<global::OpenRouter.StreamLogprobVariant2, TResult>? streamLogprobVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenResponsesLogProbs is { } __value0 && openResponsesLogProbs != null)
            {
                return openResponsesLogProbs(__value0);
            }
            else if (StreamLogprobVariant2 is { } __value1 && streamLogprobVariant2 != null)
            {
                return streamLogprobVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenResponsesLogProbs>? openResponsesLogProbs = null,

            global::System.Action<global::OpenRouter.StreamLogprobVariant2>? streamLogprobVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenResponsesLogProbs is { } __value0)
            {
                openResponsesLogProbs?.Invoke(__value0);
            }
            else if (StreamLogprobVariant2 is { } __value1)
            {
                streamLogprobVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenResponsesLogProbs>? openResponsesLogProbs = null,
            global::System.Action<global::OpenRouter.StreamLogprobVariant2>? streamLogprobVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenResponsesLogProbs is { } __value0)
            {
                openResponsesLogProbs?.Invoke(__value0);
            }
            else if (StreamLogprobVariant2 is { } __value1)
            {
                streamLogprobVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenResponsesLogProbs,
                typeof(global::OpenRouter.OpenResponsesLogProbs),
                StreamLogprobVariant2,
                typeof(global::OpenRouter.StreamLogprobVariant2),
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
        public bool Equals(StreamLogprob other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenResponsesLogProbs?>.Default.Equals(OpenResponsesLogProbs, other.OpenResponsesLogProbs) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StreamLogprobVariant2?>.Default.Equals(StreamLogprobVariant2, other.StreamLogprobVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StreamLogprob obj1, StreamLogprob obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamLogprob>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StreamLogprob obj1, StreamLogprob obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamLogprob o && Equals(o);
        }
    }
}
