#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"cited_text":"Example text","document_index":0,"document_title":null,"end_char_index":10,"file_id":null,"start_char_index":0,"type":"char_location"}
    /// </summary>
    public readonly partial struct AnthropicTextCitation : global::System.IEquatable<AnthropicTextCitation>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"cited_text":"Example cited text","document_index":0,"document_title":null,"end_char_index":18,"file_id":null,"start_char_index":0,"type":"char_location"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCitationCharLocation? CharLocation { get; init; }
#else
        public global::OpenRouter.AnthropicCitationCharLocation? CharLocation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CharLocation))]
#endif
        public bool IsCharLocation => CharLocation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCharLocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicCitationCharLocation? value)
        {
            value = CharLocation;
            return IsCharLocation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationCharLocation PickCharLocation() => CharLocation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CharLocation' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"cited_text":"Example cited text","document_index":0,"document_title":null,"end_page_number":2,"file_id":null,"start_page_number":1,"type":"page_location"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCitationPageLocation? PageLocation { get; init; }
#else
        public global::OpenRouter.AnthropicCitationPageLocation? PageLocation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PageLocation))]
#endif
        public bool IsPageLocation => PageLocation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPageLocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicCitationPageLocation? value)
        {
            value = PageLocation;
            return IsPageLocation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationPageLocation PickPageLocation() => PageLocation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PageLocation' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"cited_text":"Example cited text","document_index":0,"document_title":null,"end_block_index":1,"file_id":null,"start_block_index":0,"type":"content_block_location"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCitationContentBlockLocation? ContentBlockLocation { get; init; }
#else
        public global::OpenRouter.AnthropicCitationContentBlockLocation? ContentBlockLocation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentBlockLocation))]
#endif
        public bool IsContentBlockLocation => ContentBlockLocation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContentBlockLocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicCitationContentBlockLocation? value)
        {
            value = ContentBlockLocation;
            return IsContentBlockLocation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationContentBlockLocation PickContentBlockLocation() => ContentBlockLocation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentBlockLocation' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"cited_text":"Example cited text","encrypted_index":"enc_idx_0","title":"Example Page","type":"web_search_result_location","url":"https://example.com"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCitationWebSearchResultLocation? WebSearchResultLocation { get; init; }
#else
        public global::OpenRouter.AnthropicCitationWebSearchResultLocation? WebSearchResultLocation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchResultLocation))]
#endif
        public bool IsWebSearchResultLocation => WebSearchResultLocation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearchResultLocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicCitationWebSearchResultLocation? value)
        {
            value = WebSearchResultLocation;
            return IsWebSearchResultLocation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationWebSearchResultLocation PickWebSearchResultLocation() => WebSearchResultLocation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchResultLocation' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"cited_text":"Example cited text","end_block_index":1,"search_result_index":0,"source":"example_source","start_block_index":0,"title":"Example Result","type":"search_result_location"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCitationSearchResultLocation? SearchResultLocation { get; init; }
#else
        public global::OpenRouter.AnthropicCitationSearchResultLocation? SearchResultLocation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchResultLocation))]
#endif
        public bool IsSearchResultLocation => SearchResultLocation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSearchResultLocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicCitationSearchResultLocation? value)
        {
            value = SearchResultLocation;
            return IsSearchResultLocation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationSearchResultLocation PickSearchResultLocation() => SearchResultLocation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchResultLocation' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicTextCitation(global::OpenRouter.AnthropicCitationCharLocation value) => new AnthropicTextCitation((global::OpenRouter.AnthropicCitationCharLocation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationCharLocation?(AnthropicTextCitation @this) => @this.CharLocation;

        /// <summary>
        ///
        /// </summary>
        public AnthropicTextCitation(global::OpenRouter.AnthropicCitationCharLocation? value)
        {
            CharLocation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicTextCitation FromCharLocation(global::OpenRouter.AnthropicCitationCharLocation? value) => new AnthropicTextCitation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicTextCitation(global::OpenRouter.AnthropicCitationPageLocation value) => new AnthropicTextCitation((global::OpenRouter.AnthropicCitationPageLocation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationPageLocation?(AnthropicTextCitation @this) => @this.PageLocation;

        /// <summary>
        ///
        /// </summary>
        public AnthropicTextCitation(global::OpenRouter.AnthropicCitationPageLocation? value)
        {
            PageLocation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicTextCitation FromPageLocation(global::OpenRouter.AnthropicCitationPageLocation? value) => new AnthropicTextCitation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicTextCitation(global::OpenRouter.AnthropicCitationContentBlockLocation value) => new AnthropicTextCitation((global::OpenRouter.AnthropicCitationContentBlockLocation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationContentBlockLocation?(AnthropicTextCitation @this) => @this.ContentBlockLocation;

        /// <summary>
        ///
        /// </summary>
        public AnthropicTextCitation(global::OpenRouter.AnthropicCitationContentBlockLocation? value)
        {
            ContentBlockLocation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicTextCitation FromContentBlockLocation(global::OpenRouter.AnthropicCitationContentBlockLocation? value) => new AnthropicTextCitation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicTextCitation(global::OpenRouter.AnthropicCitationWebSearchResultLocation value) => new AnthropicTextCitation((global::OpenRouter.AnthropicCitationWebSearchResultLocation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationWebSearchResultLocation?(AnthropicTextCitation @this) => @this.WebSearchResultLocation;

        /// <summary>
        ///
        /// </summary>
        public AnthropicTextCitation(global::OpenRouter.AnthropicCitationWebSearchResultLocation? value)
        {
            WebSearchResultLocation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicTextCitation FromWebSearchResultLocation(global::OpenRouter.AnthropicCitationWebSearchResultLocation? value) => new AnthropicTextCitation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicTextCitation(global::OpenRouter.AnthropicCitationSearchResultLocation value) => new AnthropicTextCitation((global::OpenRouter.AnthropicCitationSearchResultLocation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationSearchResultLocation?(AnthropicTextCitation @this) => @this.SearchResultLocation;

        /// <summary>
        ///
        /// </summary>
        public AnthropicTextCitation(global::OpenRouter.AnthropicCitationSearchResultLocation? value)
        {
            SearchResultLocation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicTextCitation FromSearchResultLocation(global::OpenRouter.AnthropicCitationSearchResultLocation? value) => new AnthropicTextCitation(value);

        /// <summary>
        ///
        /// </summary>
        public AnthropicTextCitation(
            global::OpenRouter.AnthropicTextCitationDiscriminatorType? type,
            global::OpenRouter.AnthropicCitationCharLocation? charLocation,
            global::OpenRouter.AnthropicCitationPageLocation? pageLocation,
            global::OpenRouter.AnthropicCitationContentBlockLocation? contentBlockLocation,
            global::OpenRouter.AnthropicCitationWebSearchResultLocation? webSearchResultLocation,
            global::OpenRouter.AnthropicCitationSearchResultLocation? searchResultLocation
            )
        {
            Type = type;

            CharLocation = charLocation;
            PageLocation = pageLocation;
            ContentBlockLocation = contentBlockLocation;
            WebSearchResultLocation = webSearchResultLocation;
            SearchResultLocation = searchResultLocation;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SearchResultLocation as object ??
            WebSearchResultLocation as object ??
            ContentBlockLocation as object ??
            PageLocation as object ??
            CharLocation as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CharLocation?.ToString() ??
            PageLocation?.ToString() ??
            ContentBlockLocation?.ToString() ??
            WebSearchResultLocation?.ToString() ??
            SearchResultLocation?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCharLocation && !IsPageLocation && !IsContentBlockLocation && !IsWebSearchResultLocation && !IsSearchResultLocation || !IsCharLocation && IsPageLocation && !IsContentBlockLocation && !IsWebSearchResultLocation && !IsSearchResultLocation || !IsCharLocation && !IsPageLocation && IsContentBlockLocation && !IsWebSearchResultLocation && !IsSearchResultLocation || !IsCharLocation && !IsPageLocation && !IsContentBlockLocation && IsWebSearchResultLocation && !IsSearchResultLocation || !IsCharLocation && !IsPageLocation && !IsContentBlockLocation && !IsWebSearchResultLocation && IsSearchResultLocation;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicCitationCharLocation, TResult>? charLocation = null,
            global::System.Func<global::OpenRouter.AnthropicCitationPageLocation, TResult>? pageLocation = null,
            global::System.Func<global::OpenRouter.AnthropicCitationContentBlockLocation, TResult>? contentBlockLocation = null,
            global::System.Func<global::OpenRouter.AnthropicCitationWebSearchResultLocation, TResult>? webSearchResultLocation = null,
            global::System.Func<global::OpenRouter.AnthropicCitationSearchResultLocation, TResult>? searchResultLocation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CharLocation is { } __value0 && charLocation != null)
            {
                return charLocation(__value0);
            }
            else if (PageLocation is { } __value1 && pageLocation != null)
            {
                return pageLocation(__value1);
            }
            else if (ContentBlockLocation is { } __value2 && contentBlockLocation != null)
            {
                return contentBlockLocation(__value2);
            }
            else if (WebSearchResultLocation is { } __value3 && webSearchResultLocation != null)
            {
                return webSearchResultLocation(__value3);
            }
            else if (SearchResultLocation is { } __value4 && searchResultLocation != null)
            {
                return searchResultLocation(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicCitationCharLocation>? charLocation = null,

            global::System.Action<global::OpenRouter.AnthropicCitationPageLocation>? pageLocation = null,

            global::System.Action<global::OpenRouter.AnthropicCitationContentBlockLocation>? contentBlockLocation = null,

            global::System.Action<global::OpenRouter.AnthropicCitationWebSearchResultLocation>? webSearchResultLocation = null,

            global::System.Action<global::OpenRouter.AnthropicCitationSearchResultLocation>? searchResultLocation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CharLocation is { } __value0)
            {
                charLocation?.Invoke(__value0);
            }
            else if (PageLocation is { } __value1)
            {
                pageLocation?.Invoke(__value1);
            }
            else if (ContentBlockLocation is { } __value2)
            {
                contentBlockLocation?.Invoke(__value2);
            }
            else if (WebSearchResultLocation is { } __value3)
            {
                webSearchResultLocation?.Invoke(__value3);
            }
            else if (SearchResultLocation is { } __value4)
            {
                searchResultLocation?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicCitationCharLocation>? charLocation = null,
            global::System.Action<global::OpenRouter.AnthropicCitationPageLocation>? pageLocation = null,
            global::System.Action<global::OpenRouter.AnthropicCitationContentBlockLocation>? contentBlockLocation = null,
            global::System.Action<global::OpenRouter.AnthropicCitationWebSearchResultLocation>? webSearchResultLocation = null,
            global::System.Action<global::OpenRouter.AnthropicCitationSearchResultLocation>? searchResultLocation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CharLocation is { } __value0)
            {
                charLocation?.Invoke(__value0);
            }
            else if (PageLocation is { } __value1)
            {
                pageLocation?.Invoke(__value1);
            }
            else if (ContentBlockLocation is { } __value2)
            {
                contentBlockLocation?.Invoke(__value2);
            }
            else if (WebSearchResultLocation is { } __value3)
            {
                webSearchResultLocation?.Invoke(__value3);
            }
            else if (SearchResultLocation is { } __value4)
            {
                searchResultLocation?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CharLocation,
                typeof(global::OpenRouter.AnthropicCitationCharLocation),
                PageLocation,
                typeof(global::OpenRouter.AnthropicCitationPageLocation),
                ContentBlockLocation,
                typeof(global::OpenRouter.AnthropicCitationContentBlockLocation),
                WebSearchResultLocation,
                typeof(global::OpenRouter.AnthropicCitationWebSearchResultLocation),
                SearchResultLocation,
                typeof(global::OpenRouter.AnthropicCitationSearchResultLocation),
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
        public bool Equals(AnthropicTextCitation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationCharLocation?>.Default.Equals(CharLocation, other.CharLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationPageLocation?>.Default.Equals(PageLocation, other.PageLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationContentBlockLocation?>.Default.Equals(ContentBlockLocation, other.ContentBlockLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationWebSearchResultLocation?>.Default.Equals(WebSearchResultLocation, other.WebSearchResultLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationSearchResultLocation?>.Default.Equals(SearchResultLocation, other.SearchResultLocation)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AnthropicTextCitation obj1, AnthropicTextCitation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicTextCitation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicTextCitation obj1, AnthropicTextCitation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicTextCitation o && Equals(o);
        }
    }
}
