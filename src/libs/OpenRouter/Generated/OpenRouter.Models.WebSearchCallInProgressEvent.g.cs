#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Web search call in progress<br/>
    /// Example: {"item_id":"ws-123","output_index":0,"sequence_number":1,"type":"response.web_search_call.in_progress"}
    /// </summary>
    public readonly partial struct WebSearchCallInProgressEvent : global::System.IEquatable<WebSearchCallInProgressEvent>
    {
        /// <summary>
        /// Example: {"item_id":"ws_abc123","output_index":0,"sequence_number":1,"type":"response.web_search_call.in_progress"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesWebSearchCallInProgress? OpenAIResponses { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesWebSearchCallInProgress? OpenAIResponses { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIResponses))]
#endif
        public bool IsOpenAIResponses => OpenAIResponses != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenAIResponses(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenAIResponsesWebSearchCallInProgress? value)
        {
            value = OpenAIResponses;
            return IsOpenAIResponses;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesWebSearchCallInProgress PickOpenAIResponses() => OpenAIResponses is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponses' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? WebSearchCallInProgressEventVariant2 { get; init; }
#else
        public object? WebSearchCallInProgressEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchCallInProgressEventVariant2))]
#endif
        public bool IsWebSearchCallInProgressEventVariant2 => WebSearchCallInProgressEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearchCallInProgressEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = WebSearchCallInProgressEventVariant2;
            return IsWebSearchCallInProgressEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickWebSearchCallInProgressEventVariant2() => WebSearchCallInProgressEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchCallInProgressEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebSearchCallInProgressEvent(global::OpenRouter.OpenAIResponsesWebSearchCallInProgress value) => new WebSearchCallInProgressEvent((global::OpenRouter.OpenAIResponsesWebSearchCallInProgress?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesWebSearchCallInProgress?(WebSearchCallInProgressEvent @this) => @this.OpenAIResponses;

        /// <summary>
        ///
        /// </summary>
        public WebSearchCallInProgressEvent(global::OpenRouter.OpenAIResponsesWebSearchCallInProgress? value)
        {
            OpenAIResponses = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebSearchCallInProgressEvent FromOpenAIResponses(global::OpenRouter.OpenAIResponsesWebSearchCallInProgress? value) => new WebSearchCallInProgressEvent(value);

        /// <summary>
        ///
        /// </summary>
        public WebSearchCallInProgressEvent(
            global::OpenRouter.OpenAIResponsesWebSearchCallInProgress? openAIResponses,
            object? webSearchCallInProgressEventVariant2
            )
        {
            OpenAIResponses = openAIResponses;
            WebSearchCallInProgressEventVariant2 = webSearchCallInProgressEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebSearchCallInProgressEventVariant2 as object ??
            OpenAIResponses as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OpenAIResponses?.ToString() ??
            WebSearchCallInProgressEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIResponses && IsWebSearchCallInProgressEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenAIResponsesWebSearchCallInProgress, TResult>? openAIResponses = null,
            global::System.Func<object, TResult>? webSearchCallInProgressEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenAIResponses is { } __value0 && openAIResponses != null)
            {
                return openAIResponses(__value0);
            }
            else if (WebSearchCallInProgressEventVariant2 is { } __value1 && webSearchCallInProgressEventVariant2 != null)
            {
                return webSearchCallInProgressEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenAIResponsesWebSearchCallInProgress>? openAIResponses = null,

            global::System.Action<object>? webSearchCallInProgressEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenAIResponses is { } __value0)
            {
                openAIResponses?.Invoke(__value0);
            }
            else if (WebSearchCallInProgressEventVariant2 is { } __value1)
            {
                webSearchCallInProgressEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenAIResponsesWebSearchCallInProgress>? openAIResponses = null,
            global::System.Action<object>? webSearchCallInProgressEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenAIResponses is { } __value0)
            {
                openAIResponses?.Invoke(__value0);
            }
            else if (WebSearchCallInProgressEventVariant2 is { } __value1)
            {
                webSearchCallInProgressEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAIResponses,
                typeof(global::OpenRouter.OpenAIResponsesWebSearchCallInProgress),
                WebSearchCallInProgressEventVariant2,
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
        public bool Equals(WebSearchCallInProgressEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesWebSearchCallInProgress?>.Default.Equals(OpenAIResponses, other.OpenAIResponses) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(WebSearchCallInProgressEventVariant2, other.WebSearchCallInProgressEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WebSearchCallInProgressEvent obj1, WebSearchCallInProgressEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebSearchCallInProgressEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebSearchCallInProgressEvent obj1, WebSearchCallInProgressEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebSearchCallInProgressEvent o && Equals(o);
        }
    }
}
