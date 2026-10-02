#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Alternative token with its log probability<br/>
    /// Example: {"bytes":[72,101,108,108,111],"logprob":-0.5,"token":"Hello"}
    /// </summary>
    public readonly partial struct StreamLogprobTopLogprob : global::System.IEquatable<StreamLogprobTopLogprob>
    {
        /// <summary>
        /// Alternative token with its log probability<br/>
        /// Example: {"logprob":-0.5,"token":"hello"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenResponsesTopLogprobs? OpenResponsesLogprobs { get; init; }
#else
        public global::OpenRouter.OpenResponsesTopLogprobs? OpenResponsesLogprobs { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenResponsesLogprobs))]
#endif
        public bool IsOpenResponsesLogprobs => OpenResponsesLogprobs != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenResponsesLogprobs(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenResponsesTopLogprobs? value)
        {
            value = OpenResponsesLogprobs;
            return IsOpenResponsesLogprobs;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesTopLogprobs PickOpenResponsesLogprobs() => OpenResponsesLogprobs is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenResponsesLogprobs' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? StreamLogprobTopLogprobVariant2 { get; init; }
#else
        public object? StreamLogprobTopLogprobVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamLogprobTopLogprobVariant2))]
#endif
        public bool IsStreamLogprobTopLogprobVariant2 => StreamLogprobTopLogprobVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStreamLogprobTopLogprobVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = StreamLogprobTopLogprobVariant2;
            return IsStreamLogprobTopLogprobVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickStreamLogprobTopLogprobVariant2() => StreamLogprobTopLogprobVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamLogprobTopLogprobVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamLogprobTopLogprob(global::OpenRouter.OpenResponsesTopLogprobs value) => new StreamLogprobTopLogprob((global::OpenRouter.OpenResponsesTopLogprobs?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenResponsesTopLogprobs?(StreamLogprobTopLogprob @this) => @this.OpenResponsesLogprobs;

        /// <summary>
        ///
        /// </summary>
        public StreamLogprobTopLogprob(global::OpenRouter.OpenResponsesTopLogprobs? value)
        {
            OpenResponsesLogprobs = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamLogprobTopLogprob FromOpenResponsesLogprobs(global::OpenRouter.OpenResponsesTopLogprobs? value) => new StreamLogprobTopLogprob(value);

        /// <summary>
        ///
        /// </summary>
        public StreamLogprobTopLogprob(
            global::OpenRouter.OpenResponsesTopLogprobs? openResponsesLogprobs,
            object? streamLogprobTopLogprobVariant2
            )
        {
            OpenResponsesLogprobs = openResponsesLogprobs;
            StreamLogprobTopLogprobVariant2 = streamLogprobTopLogprobVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StreamLogprobTopLogprobVariant2 as object ??
            OpenResponsesLogprobs as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OpenResponsesLogprobs?.ToString() ??
            StreamLogprobTopLogprobVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpenResponsesLogprobs && IsStreamLogprobTopLogprobVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenResponsesTopLogprobs, TResult>? openResponsesLogprobs = null,
            global::System.Func<object, TResult>? streamLogprobTopLogprobVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenResponsesLogprobs is { } __value0 && openResponsesLogprobs != null)
            {
                return openResponsesLogprobs(__value0);
            }
            else if (StreamLogprobTopLogprobVariant2 is { } __value1 && streamLogprobTopLogprobVariant2 != null)
            {
                return streamLogprobTopLogprobVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenResponsesTopLogprobs>? openResponsesLogprobs = null,

            global::System.Action<object>? streamLogprobTopLogprobVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenResponsesLogprobs is { } __value0)
            {
                openResponsesLogprobs?.Invoke(__value0);
            }
            else if (StreamLogprobTopLogprobVariant2 is { } __value1)
            {
                streamLogprobTopLogprobVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenResponsesTopLogprobs>? openResponsesLogprobs = null,
            global::System.Action<object>? streamLogprobTopLogprobVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenResponsesLogprobs is { } __value0)
            {
                openResponsesLogprobs?.Invoke(__value0);
            }
            else if (StreamLogprobTopLogprobVariant2 is { } __value1)
            {
                streamLogprobTopLogprobVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenResponsesLogprobs,
                typeof(global::OpenRouter.OpenResponsesTopLogprobs),
                StreamLogprobTopLogprobVariant2,
                typeof(object),
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
        public bool Equals(StreamLogprobTopLogprob other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenResponsesTopLogprobs?>.Default.Equals(OpenResponsesLogprobs, other.OpenResponsesLogprobs) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(StreamLogprobTopLogprobVariant2, other.StreamLogprobTopLogprobVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StreamLogprobTopLogprob obj1, StreamLogprobTopLogprob obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamLogprobTopLogprob>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StreamLogprobTopLogprob obj1, StreamLogprobTopLogprob obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamLogprobTopLogprob o && Equals(o);
        }
    }
}
