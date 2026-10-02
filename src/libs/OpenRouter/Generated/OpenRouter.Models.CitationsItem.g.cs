#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CitationsItem : global::System.IEquatable<CitationsItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"cited_text":"Example cited text","document_index":0,"document_title":null,"end_char_index":18,"start_char_index":0,"type":"char_location"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCitationCharLocationParam? CharLocation { get; init; }
#else
        public global::OpenRouter.AnthropicCitationCharLocationParam? CharLocation { get; }
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
            out global::OpenRouter.AnthropicCitationCharLocationParam? value)
        {
            value = CharLocation;
            return IsCharLocation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationCharLocationParam PickCharLocation() => CharLocation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CharLocation' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"cited_text":"Example cited text","document_index":0,"document_title":null,"end_page_number":2,"start_page_number":1,"type":"page_location"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCitationPageLocationParam? PageLocation { get; init; }
#else
        public global::OpenRouter.AnthropicCitationPageLocationParam? PageLocation { get; }
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
            out global::OpenRouter.AnthropicCitationPageLocationParam? value)
        {
            value = PageLocation;
            return IsPageLocation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationPageLocationParam PickPageLocation() => PageLocation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PageLocation' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"cited_text":"Example cited text","document_index":0,"document_title":null,"end_block_index":1,"start_block_index":0,"type":"content_block_location"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCitationContentBlockLocationParam? ContentBlockLocation { get; init; }
#else
        public global::OpenRouter.AnthropicCitationContentBlockLocationParam? ContentBlockLocation { get; }
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
            out global::OpenRouter.AnthropicCitationContentBlockLocationParam? value)
        {
            value = ContentBlockLocation;
            return IsContentBlockLocation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationContentBlockLocationParam PickContentBlockLocation() => ContentBlockLocation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentBlockLocation' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"cited_text":"Example cited text","encrypted_index":"enc_idx_0","title":"Example Page","type":"web_search_result_location","url":"https://example.com"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCitationWebSearchResultLocationParam? WebSearchResultLocation { get; init; }
#else
        public global::OpenRouter.AnthropicCitationWebSearchResultLocationParam? WebSearchResultLocation { get; }
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
            out global::OpenRouter.AnthropicCitationWebSearchResultLocationParam? value)
        {
            value = WebSearchResultLocation;
            return IsWebSearchResultLocation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationWebSearchResultLocationParam PickWebSearchResultLocation() => WebSearchResultLocation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchResultLocation' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"cited_text":"Example cited text","end_block_index":1,"search_result_index":0,"source":"example_source","start_block_index":0,"title":"Example Result","type":"search_result_location"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCitationSearchResultLocationParam? SearchResultLocation { get; init; }
#else
        public global::OpenRouter.AnthropicCitationSearchResultLocationParam? SearchResultLocation { get; }
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
            out global::OpenRouter.AnthropicCitationSearchResultLocationParam? value)
        {
            value = SearchResultLocation;
            return IsSearchResultLocation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationSearchResultLocationParam PickSearchResultLocation() => SearchResultLocation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchResultLocation' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CitationsItem(global::OpenRouter.AnthropicCitationCharLocationParam value) => new CitationsItem((global::OpenRouter.AnthropicCitationCharLocationParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationCharLocationParam?(CitationsItem @this) => @this.CharLocation;

        /// <summary>
        ///
        /// </summary>
        public CitationsItem(global::OpenRouter.AnthropicCitationCharLocationParam? value)
        {
            CharLocation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CitationsItem FromCharLocation(global::OpenRouter.AnthropicCitationCharLocationParam? value) => new CitationsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CitationsItem(global::OpenRouter.AnthropicCitationPageLocationParam value) => new CitationsItem((global::OpenRouter.AnthropicCitationPageLocationParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationPageLocationParam?(CitationsItem @this) => @this.PageLocation;

        /// <summary>
        ///
        /// </summary>
        public CitationsItem(global::OpenRouter.AnthropicCitationPageLocationParam? value)
        {
            PageLocation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CitationsItem FromPageLocation(global::OpenRouter.AnthropicCitationPageLocationParam? value) => new CitationsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CitationsItem(global::OpenRouter.AnthropicCitationContentBlockLocationParam value) => new CitationsItem((global::OpenRouter.AnthropicCitationContentBlockLocationParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationContentBlockLocationParam?(CitationsItem @this) => @this.ContentBlockLocation;

        /// <summary>
        ///
        /// </summary>
        public CitationsItem(global::OpenRouter.AnthropicCitationContentBlockLocationParam? value)
        {
            ContentBlockLocation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CitationsItem FromContentBlockLocation(global::OpenRouter.AnthropicCitationContentBlockLocationParam? value) => new CitationsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CitationsItem(global::OpenRouter.AnthropicCitationWebSearchResultLocationParam value) => new CitationsItem((global::OpenRouter.AnthropicCitationWebSearchResultLocationParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationWebSearchResultLocationParam?(CitationsItem @this) => @this.WebSearchResultLocation;

        /// <summary>
        ///
        /// </summary>
        public CitationsItem(global::OpenRouter.AnthropicCitationWebSearchResultLocationParam? value)
        {
            WebSearchResultLocation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CitationsItem FromWebSearchResultLocation(global::OpenRouter.AnthropicCitationWebSearchResultLocationParam? value) => new CitationsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CitationsItem(global::OpenRouter.AnthropicCitationSearchResultLocationParam value) => new CitationsItem((global::OpenRouter.AnthropicCitationSearchResultLocationParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationSearchResultLocationParam?(CitationsItem @this) => @this.SearchResultLocation;

        /// <summary>
        ///
        /// </summary>
        public CitationsItem(global::OpenRouter.AnthropicCitationSearchResultLocationParam? value)
        {
            SearchResultLocation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CitationsItem FromSearchResultLocation(global::OpenRouter.AnthropicCitationSearchResultLocationParam? value) => new CitationsItem(value);

        /// <summary>
        ///
        /// </summary>
        public CitationsItem(
            global::OpenRouter.AnthropicTextBlockParamCitationDiscriminatorType? type,
            global::OpenRouter.AnthropicCitationCharLocationParam? charLocation,
            global::OpenRouter.AnthropicCitationPageLocationParam? pageLocation,
            global::OpenRouter.AnthropicCitationContentBlockLocationParam? contentBlockLocation,
            global::OpenRouter.AnthropicCitationWebSearchResultLocationParam? webSearchResultLocation,
            global::OpenRouter.AnthropicCitationSearchResultLocationParam? searchResultLocation
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
            global::System.Func<global::OpenRouter.AnthropicCitationCharLocationParam, TResult>? charLocation = null,
            global::System.Func<global::OpenRouter.AnthropicCitationPageLocationParam, TResult>? pageLocation = null,
            global::System.Func<global::OpenRouter.AnthropicCitationContentBlockLocationParam, TResult>? contentBlockLocation = null,
            global::System.Func<global::OpenRouter.AnthropicCitationWebSearchResultLocationParam, TResult>? webSearchResultLocation = null,
            global::System.Func<global::OpenRouter.AnthropicCitationSearchResultLocationParam, TResult>? searchResultLocation = null,
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
            global::System.Action<global::OpenRouter.AnthropicCitationCharLocationParam>? charLocation = null,

            global::System.Action<global::OpenRouter.AnthropicCitationPageLocationParam>? pageLocation = null,

            global::System.Action<global::OpenRouter.AnthropicCitationContentBlockLocationParam>? contentBlockLocation = null,

            global::System.Action<global::OpenRouter.AnthropicCitationWebSearchResultLocationParam>? webSearchResultLocation = null,

            global::System.Action<global::OpenRouter.AnthropicCitationSearchResultLocationParam>? searchResultLocation = null,
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
            global::System.Action<global::OpenRouter.AnthropicCitationCharLocationParam>? charLocation = null,
            global::System.Action<global::OpenRouter.AnthropicCitationPageLocationParam>? pageLocation = null,
            global::System.Action<global::OpenRouter.AnthropicCitationContentBlockLocationParam>? contentBlockLocation = null,
            global::System.Action<global::OpenRouter.AnthropicCitationWebSearchResultLocationParam>? webSearchResultLocation = null,
            global::System.Action<global::OpenRouter.AnthropicCitationSearchResultLocationParam>? searchResultLocation = null,
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
                typeof(global::OpenRouter.AnthropicCitationCharLocationParam),
                PageLocation,
                typeof(global::OpenRouter.AnthropicCitationPageLocationParam),
                ContentBlockLocation,
                typeof(global::OpenRouter.AnthropicCitationContentBlockLocationParam),
                WebSearchResultLocation,
                typeof(global::OpenRouter.AnthropicCitationWebSearchResultLocationParam),
                SearchResultLocation,
                typeof(global::OpenRouter.AnthropicCitationSearchResultLocationParam),
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
        public bool Equals(CitationsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationCharLocationParam?>.Default.Equals(CharLocation, other.CharLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationPageLocationParam?>.Default.Equals(PageLocation, other.PageLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationContentBlockLocationParam?>.Default.Equals(ContentBlockLocation, other.ContentBlockLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationWebSearchResultLocationParam?>.Default.Equals(WebSearchResultLocation, other.WebSearchResultLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationSearchResultLocationParam?>.Default.Equals(SearchResultLocation, other.SearchResultLocation)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CitationsItem obj1, CitationsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CitationsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CitationsItem obj1, CitationsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CitationsItem o && Equals(o);
        }
    }
}
