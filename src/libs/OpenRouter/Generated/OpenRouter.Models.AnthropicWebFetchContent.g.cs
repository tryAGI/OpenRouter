#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"content":{"citations":null,"source":{"data":"","media_type":"text/plain","type":"text"},"title":null,"type":"document"},"retrieved_at":null,"type":"web_fetch_result","url":"https://example.com"}
    /// </summary>
    public readonly partial struct AnthropicWebFetchContent : global::System.IEquatable<AnthropicWebFetchContent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchContentDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"error_code":"unavailable","type":"web_fetch_tool_result_error"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicWebFetchToolResultError? WebFetchToolResultError { get; init; }
#else
        public global::OpenRouter.AnthropicWebFetchToolResultError? WebFetchToolResultError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebFetchToolResultError))]
#endif
        public bool IsWebFetchToolResultError => WebFetchToolResultError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebFetchToolResultError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicWebFetchToolResultError? value)
        {
            value = WebFetchToolResultError;
            return IsWebFetchToolResultError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchToolResultError PickWebFetchToolResultError() => WebFetchToolResultError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebFetchToolResultError' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"content":{"citations":null,"source":{"data":"","media_type":"text/plain","type":"text"},"title":null,"type":"document"},"retrieved_at":null,"type":"web_fetch_result","url":"https://example.com"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicWebFetchBlock? WebFetchResult { get; init; }
#else
        public global::OpenRouter.AnthropicWebFetchBlock? WebFetchResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebFetchResult))]
#endif
        public bool IsWebFetchResult => WebFetchResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebFetchResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicWebFetchBlock? value)
        {
            value = WebFetchResult;
            return IsWebFetchResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchBlock PickWebFetchResult() => WebFetchResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebFetchResult' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicWebFetchContent(global::OpenRouter.AnthropicWebFetchToolResultError value) => new AnthropicWebFetchContent((global::OpenRouter.AnthropicWebFetchToolResultError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicWebFetchToolResultError?(AnthropicWebFetchContent @this) => @this.WebFetchToolResultError;

        /// <summary>
        ///
        /// </summary>
        public AnthropicWebFetchContent(global::OpenRouter.AnthropicWebFetchToolResultError? value)
        {
            WebFetchToolResultError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicWebFetchContent FromWebFetchToolResultError(global::OpenRouter.AnthropicWebFetchToolResultError? value) => new AnthropicWebFetchContent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicWebFetchContent(global::OpenRouter.AnthropicWebFetchBlock value) => new AnthropicWebFetchContent((global::OpenRouter.AnthropicWebFetchBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicWebFetchBlock?(AnthropicWebFetchContent @this) => @this.WebFetchResult;

        /// <summary>
        ///
        /// </summary>
        public AnthropicWebFetchContent(global::OpenRouter.AnthropicWebFetchBlock? value)
        {
            WebFetchResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicWebFetchContent FromWebFetchResult(global::OpenRouter.AnthropicWebFetchBlock? value) => new AnthropicWebFetchContent(value);

        /// <summary>
        ///
        /// </summary>
        public AnthropicWebFetchContent(
            global::OpenRouter.AnthropicWebFetchContentDiscriminatorType? type,
            global::OpenRouter.AnthropicWebFetchToolResultError? webFetchToolResultError,
            global::OpenRouter.AnthropicWebFetchBlock? webFetchResult
            )
        {
            Type = type;

            WebFetchToolResultError = webFetchToolResultError;
            WebFetchResult = webFetchResult;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebFetchResult as object ??
            WebFetchToolResultError as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            WebFetchToolResultError?.ToString() ??
            WebFetchResult?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsWebFetchToolResultError && !IsWebFetchResult || !IsWebFetchToolResultError && IsWebFetchResult;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicWebFetchToolResultError, TResult>? webFetchToolResultError = null,
            global::System.Func<global::OpenRouter.AnthropicWebFetchBlock, TResult>? webFetchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (WebFetchToolResultError is { } __value0 && webFetchToolResultError != null)
            {
                return webFetchToolResultError(__value0);
            }
            else if (WebFetchResult is { } __value1 && webFetchResult != null)
            {
                return webFetchResult(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicWebFetchToolResultError>? webFetchToolResultError = null,

            global::System.Action<global::OpenRouter.AnthropicWebFetchBlock>? webFetchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (WebFetchToolResultError is { } __value0)
            {
                webFetchToolResultError?.Invoke(__value0);
            }
            else if (WebFetchResult is { } __value1)
            {
                webFetchResult?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicWebFetchToolResultError>? webFetchToolResultError = null,
            global::System.Action<global::OpenRouter.AnthropicWebFetchBlock>? webFetchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (WebFetchToolResultError is { } __value0)
            {
                webFetchToolResultError?.Invoke(__value0);
            }
            else if (WebFetchResult is { } __value1)
            {
                webFetchResult?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WebFetchToolResultError,
                typeof(global::OpenRouter.AnthropicWebFetchToolResultError),
                WebFetchResult,
                typeof(global::OpenRouter.AnthropicWebFetchBlock),
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
        public bool Equals(AnthropicWebFetchContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicWebFetchToolResultError?>.Default.Equals(WebFetchToolResultError, other.WebFetchToolResultError) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicWebFetchBlock?>.Default.Equals(WebFetchResult, other.WebFetchResult)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AnthropicWebFetchContent obj1, AnthropicWebFetchContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicWebFetchContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicWebFetchContent obj1, AnthropicWebFetchContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicWebFetchContent o && Equals(o);
        }
    }
}
