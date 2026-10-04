#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Message text as a string or a list of text parts. Assistant history may carry null. Only the last message is read; earlier messages are accepted so ordinary clients can resend history.<br/>
    /// Example: Summarize the open pull requests.
    /// </summary>
    public readonly partial struct InternChatMessageContent : global::System.IEquatable<InternChatMessageContent>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? InternChatMessageContentVariant1 { get; init; }
#else
        public string? InternChatMessageContentVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InternChatMessageContentVariant1))]
#endif
        public bool IsInternChatMessageContentVariant1 => InternChatMessageContentVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInternChatMessageContentVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = InternChatMessageContentVariant1;
            return IsInternChatMessageContentVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickInternChatMessageContentVariant1() => InternChatMessageContentVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InternChatMessageContentVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.InternChatTextPart>? InternChatMessageContentVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.InternChatTextPart>? InternChatMessageContentVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InternChatMessageContentVariant2))]
#endif
        public bool IsInternChatMessageContentVariant2 => InternChatMessageContentVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInternChatMessageContentVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::OpenRouter.InternChatTextPart>? value)
        {
            value = InternChatMessageContentVariant2;
            return IsInternChatMessageContentVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.InternChatTextPart> PickInternChatMessageContentVariant2() => InternChatMessageContentVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InternChatMessageContentVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator InternChatMessageContent(string value) => new InternChatMessageContent((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(InternChatMessageContent @this) => @this.InternChatMessageContentVariant1;

        /// <summary>
        ///
        /// </summary>
        public InternChatMessageContent(string? value)
        {
            InternChatMessageContentVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InternChatMessageContent FromInternChatMessageContentVariant1(string? value) => new InternChatMessageContent(value);

        /// <summary>
        ///
        /// </summary>
        public InternChatMessageContent(
            string? internChatMessageContentVariant1,
            global::System.Collections.Generic.IList<global::OpenRouter.InternChatTextPart>? internChatMessageContentVariant2
            )
        {
            InternChatMessageContentVariant1 = internChatMessageContentVariant1;
            InternChatMessageContentVariant2 = internChatMessageContentVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            InternChatMessageContentVariant2 as object ??
            InternChatMessageContentVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InternChatMessageContentVariant1?.ToString() ??
            InternChatMessageContentVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInternChatMessageContentVariant1 || IsInternChatMessageContentVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? internChatMessageContentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.InternChatTextPart>, TResult>? internChatMessageContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InternChatMessageContentVariant1 is { } __value0 && internChatMessageContentVariant1 != null)
            {
                return internChatMessageContentVariant1(__value0);
            }
            else if (InternChatMessageContentVariant2 is { } __value1 && internChatMessageContentVariant2 != null)
            {
                return internChatMessageContentVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? internChatMessageContentVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.InternChatTextPart>>? internChatMessageContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InternChatMessageContentVariant1 is { } __value0)
            {
                internChatMessageContentVariant1?.Invoke(__value0);
            }
            else if (InternChatMessageContentVariant2 is { } __value1)
            {
                internChatMessageContentVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? internChatMessageContentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.InternChatTextPart>>? internChatMessageContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InternChatMessageContentVariant1 is { } __value0)
            {
                internChatMessageContentVariant1?.Invoke(__value0);
            }
            else if (InternChatMessageContentVariant2 is { } __value1)
            {
                internChatMessageContentVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InternChatMessageContentVariant1,
                typeof(string),
                InternChatMessageContentVariant2,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.InternChatTextPart>),
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
        public bool Equals(InternChatMessageContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(InternChatMessageContentVariant1, other.InternChatMessageContentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.InternChatTextPart>?>.Default.Equals(InternChatMessageContentVariant2, other.InternChatMessageContentVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(InternChatMessageContent obj1, InternChatMessageContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InternChatMessageContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InternChatMessageContent obj1, InternChatMessageContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InternChatMessageContent o && Equals(o);
        }
    }
}
