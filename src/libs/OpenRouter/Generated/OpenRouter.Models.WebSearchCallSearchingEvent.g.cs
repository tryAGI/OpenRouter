#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Web search call is searching<br/>
    /// Example: {"item_id":"ws-123","output_index":0,"sequence_number":2,"type":"response.web_search_call.searching"}
    /// </summary>
    public readonly partial struct WebSearchCallSearchingEvent : global::System.IEquatable<WebSearchCallSearchingEvent>
    {
        /// <summary>
        /// Example: {"item_id":"ws_abc123","output_index":0,"sequence_number":2,"type":"response.web_search_call.searching"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesWebSearchCallSearching? OpenAIResponses { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesWebSearchCallSearching? OpenAIResponses { get; }
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
            out global::OpenRouter.OpenAIResponsesWebSearchCallSearching? value)
        {
            value = OpenAIResponses;
            return IsOpenAIResponses;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesWebSearchCallSearching PickOpenAIResponses() => OpenAIResponses is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponses' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? WebSearchCallSearchingEventVariant2 { get; init; }
#else
        public object? WebSearchCallSearchingEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchCallSearchingEventVariant2))]
#endif
        public bool IsWebSearchCallSearchingEventVariant2 => WebSearchCallSearchingEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearchCallSearchingEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = WebSearchCallSearchingEventVariant2;
            return IsWebSearchCallSearchingEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickWebSearchCallSearchingEventVariant2() => WebSearchCallSearchingEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchCallSearchingEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebSearchCallSearchingEvent(global::OpenRouter.OpenAIResponsesWebSearchCallSearching value) => new WebSearchCallSearchingEvent((global::OpenRouter.OpenAIResponsesWebSearchCallSearching?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesWebSearchCallSearching?(WebSearchCallSearchingEvent @this) => @this.OpenAIResponses;

        /// <summary>
        ///
        /// </summary>
        public WebSearchCallSearchingEvent(global::OpenRouter.OpenAIResponsesWebSearchCallSearching? value)
        {
            OpenAIResponses = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebSearchCallSearchingEvent FromOpenAIResponses(global::OpenRouter.OpenAIResponsesWebSearchCallSearching? value) => new WebSearchCallSearchingEvent(value);

        /// <summary>
        ///
        /// </summary>
        public WebSearchCallSearchingEvent(
            global::OpenRouter.OpenAIResponsesWebSearchCallSearching? openAIResponses,
            object? webSearchCallSearchingEventVariant2
            )
        {
            OpenAIResponses = openAIResponses;
            WebSearchCallSearchingEventVariant2 = webSearchCallSearchingEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebSearchCallSearchingEventVariant2 as object ??
            OpenAIResponses as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OpenAIResponses?.ToString() ??
            WebSearchCallSearchingEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIResponses && IsWebSearchCallSearchingEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenAIResponsesWebSearchCallSearching, TResult>? openAIResponses = null,
            global::System.Func<object, TResult>? webSearchCallSearchingEventVariant2 = null,
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
            else if (WebSearchCallSearchingEventVariant2 is { } __value1 && webSearchCallSearchingEventVariant2 != null)
            {
                return webSearchCallSearchingEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenAIResponsesWebSearchCallSearching>? openAIResponses = null,

            global::System.Action<object>? webSearchCallSearchingEventVariant2 = null,
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
            else if (WebSearchCallSearchingEventVariant2 is { } __value1)
            {
                webSearchCallSearchingEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenAIResponsesWebSearchCallSearching>? openAIResponses = null,
            global::System.Action<object>? webSearchCallSearchingEventVariant2 = null,
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
            else if (WebSearchCallSearchingEventVariant2 is { } __value1)
            {
                webSearchCallSearchingEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.OpenAIResponsesWebSearchCallSearching),
                WebSearchCallSearchingEventVariant2,
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
        public bool Equals(WebSearchCallSearchingEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesWebSearchCallSearching?>.Default.Equals(OpenAIResponses, other.OpenAIResponses) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(WebSearchCallSearchingEventVariant2, other.WebSearchCallSearchingEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WebSearchCallSearchingEvent obj1, WebSearchCallSearchingEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebSearchCallSearchingEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebSearchCallSearchingEvent obj1, WebSearchCallSearchingEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebSearchCallSearchingEvent o && Equals(o);
        }
    }
}
