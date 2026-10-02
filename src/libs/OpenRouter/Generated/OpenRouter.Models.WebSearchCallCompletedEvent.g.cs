#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Web search call completed<br/>
    /// Example: {"item_id":"ws-123","output_index":0,"sequence_number":3,"type":"response.web_search_call.completed"}
    /// </summary>
    public readonly partial struct WebSearchCallCompletedEvent : global::System.IEquatable<WebSearchCallCompletedEvent>
    {
        /// <summary>
        /// Example: {"item_id":"ws_abc123","output_index":0,"sequence_number":5,"type":"response.web_search_call.completed"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesSearchCompleted? OpenAIResponses { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesSearchCompleted? OpenAIResponses { get; }
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
            out global::OpenRouter.OpenAIResponsesSearchCompleted? value)
        {
            value = OpenAIResponses;
            return IsOpenAIResponses;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesSearchCompleted PickOpenAIResponses() => OpenAIResponses is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponses' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? WebSearchCallCompletedEventVariant2 { get; init; }
#else
        public object? WebSearchCallCompletedEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchCallCompletedEventVariant2))]
#endif
        public bool IsWebSearchCallCompletedEventVariant2 => WebSearchCallCompletedEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearchCallCompletedEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = WebSearchCallCompletedEventVariant2;
            return IsWebSearchCallCompletedEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickWebSearchCallCompletedEventVariant2() => WebSearchCallCompletedEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchCallCompletedEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebSearchCallCompletedEvent(global::OpenRouter.OpenAIResponsesSearchCompleted value) => new WebSearchCallCompletedEvent((global::OpenRouter.OpenAIResponsesSearchCompleted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesSearchCompleted?(WebSearchCallCompletedEvent @this) => @this.OpenAIResponses;

        /// <summary>
        ///
        /// </summary>
        public WebSearchCallCompletedEvent(global::OpenRouter.OpenAIResponsesSearchCompleted? value)
        {
            OpenAIResponses = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebSearchCallCompletedEvent FromOpenAIResponses(global::OpenRouter.OpenAIResponsesSearchCompleted? value) => new WebSearchCallCompletedEvent(value);

        /// <summary>
        ///
        /// </summary>
        public WebSearchCallCompletedEvent(
            global::OpenRouter.OpenAIResponsesSearchCompleted? openAIResponses,
            object? webSearchCallCompletedEventVariant2
            )
        {
            OpenAIResponses = openAIResponses;
            WebSearchCallCompletedEventVariant2 = webSearchCallCompletedEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebSearchCallCompletedEventVariant2 as object ??
            OpenAIResponses as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OpenAIResponses?.ToString() ??
            WebSearchCallCompletedEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIResponses && IsWebSearchCallCompletedEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenAIResponsesSearchCompleted, TResult>? openAIResponses = null,
            global::System.Func<object, TResult>? webSearchCallCompletedEventVariant2 = null,
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
            else if (WebSearchCallCompletedEventVariant2 is { } __value1 && webSearchCallCompletedEventVariant2 != null)
            {
                return webSearchCallCompletedEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenAIResponsesSearchCompleted>? openAIResponses = null,

            global::System.Action<object>? webSearchCallCompletedEventVariant2 = null,
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
            else if (WebSearchCallCompletedEventVariant2 is { } __value1)
            {
                webSearchCallCompletedEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenAIResponsesSearchCompleted>? openAIResponses = null,
            global::System.Action<object>? webSearchCallCompletedEventVariant2 = null,
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
            else if (WebSearchCallCompletedEventVariant2 is { } __value1)
            {
                webSearchCallCompletedEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.OpenAIResponsesSearchCompleted),
                WebSearchCallCompletedEventVariant2,
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
        public bool Equals(WebSearchCallCompletedEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesSearchCompleted?>.Default.Equals(OpenAIResponses, other.OpenAIResponses) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(WebSearchCallCompletedEventVariant2, other.WebSearchCallCompletedEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WebSearchCallCompletedEvent obj1, WebSearchCallCompletedEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebSearchCallCompletedEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebSearchCallCompletedEvent obj1, WebSearchCallCompletedEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebSearchCallCompletedEvent o && Equals(o);
        }
    }
}
