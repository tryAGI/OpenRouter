#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnthropicTextBlockParamCitationsItems : global::System.IEquatable<AnthropicTextBlockParamCitationsItems>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsDiscriminatorType? Type { get; }

        /// <summary>
        /// char_location variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1? CharLocation { get; init; }
#else
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1? CharLocation { get; }
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
            out global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1? value)
        {
            value = CharLocation;
            return IsCharLocation;
        }

        /// <summary>
        /// content_block_location variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2? ContentBlockLocation { get; init; }
#else
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2? ContentBlockLocation { get; }
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
            out global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2? value)
        {
            value = ContentBlockLocation;
            return IsContentBlockLocation;
        }

        /// <summary>
        /// page_location variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3? PageLocation { get; init; }
#else
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3? PageLocation { get; }
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
            out global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3? value)
        {
            value = PageLocation;
            return IsPageLocation;
        }

        /// <summary>
        /// search_result_location variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4? SearchResultLocation { get; init; }
#else
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4? SearchResultLocation { get; }
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
            out global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4? value)
        {
            value = SearchResultLocation;
            return IsSearchResultLocation;
        }

        /// <summary>
        /// web_search_result_location variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5? WebSearchResultLocation { get; init; }
#else
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5? WebSearchResultLocation { get; }
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
            out global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5? value)
        {
            value = WebSearchResultLocation;
            return IsWebSearchResultLocation;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1 value) => new AnthropicTextBlockParamCitationsItems((global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1?(AnthropicTextBlockParamCitationsItems @this) => @this.CharLocation;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1? value)
        {
            CharLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2 value) => new AnthropicTextBlockParamCitationsItems((global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2?(AnthropicTextBlockParamCitationsItems @this) => @this.ContentBlockLocation;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2? value)
        {
            ContentBlockLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3 value) => new AnthropicTextBlockParamCitationsItems((global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3?(AnthropicTextBlockParamCitationsItems @this) => @this.PageLocation;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3? value)
        {
            PageLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4 value) => new AnthropicTextBlockParamCitationsItems((global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4?(AnthropicTextBlockParamCitationsItems @this) => @this.SearchResultLocation;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4? value)
        {
            SearchResultLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5 value) => new AnthropicTextBlockParamCitationsItems((global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5?(AnthropicTextBlockParamCitationsItems @this) => @this.WebSearchResultLocation;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5? value)
        {
            WebSearchResultLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextBlockParamCitationsItems(
            global::OpenRouter.AnthropicTextBlockParamCitationsItemsDiscriminatorType? type,
            global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1? charLocation,
            global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2? contentBlockLocation,
            global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3? pageLocation,
            global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4? searchResultLocation,
            global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5? webSearchResultLocation
            )
        {
            Type = type;

            CharLocation = charLocation;
            ContentBlockLocation = contentBlockLocation;
            PageLocation = pageLocation;
            SearchResultLocation = searchResultLocation;
            WebSearchResultLocation = webSearchResultLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebSearchResultLocation as object ??
            SearchResultLocation as object ??
            PageLocation as object ??
            ContentBlockLocation as object ??
            CharLocation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CharLocation?.ToString() ??
            ContentBlockLocation?.ToString() ??
            PageLocation?.ToString() ??
            SearchResultLocation?.ToString() ??
            WebSearchResultLocation?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCharLocation && !IsContentBlockLocation && !IsPageLocation && !IsSearchResultLocation && !IsWebSearchResultLocation || !IsCharLocation && IsContentBlockLocation && !IsPageLocation && !IsSearchResultLocation && !IsWebSearchResultLocation || !IsCharLocation && !IsContentBlockLocation && IsPageLocation && !IsSearchResultLocation && !IsWebSearchResultLocation || !IsCharLocation && !IsContentBlockLocation && !IsPageLocation && IsSearchResultLocation && !IsWebSearchResultLocation || !IsCharLocation && !IsContentBlockLocation && !IsPageLocation && !IsSearchResultLocation && IsWebSearchResultLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1, TResult>? charLocation = null,
            global::System.Func<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2, TResult>? contentBlockLocation = null,
            global::System.Func<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3, TResult>? pageLocation = null,
            global::System.Func<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4, TResult>? searchResultLocation = null,
            global::System.Func<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5, TResult>? webSearchResultLocation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCharLocation && charLocation != null)
            {
                return charLocation(CharLocation!);
            }
            else if (IsContentBlockLocation && contentBlockLocation != null)
            {
                return contentBlockLocation(ContentBlockLocation!);
            }
            else if (IsPageLocation && pageLocation != null)
            {
                return pageLocation(PageLocation!);
            }
            else if (IsSearchResultLocation && searchResultLocation != null)
            {
                return searchResultLocation(SearchResultLocation!);
            }
            else if (IsWebSearchResultLocation && webSearchResultLocation != null)
            {
                return webSearchResultLocation(WebSearchResultLocation!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1>? charLocation = null,

            global::System.Action<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2>? contentBlockLocation = null,

            global::System.Action<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3>? pageLocation = null,

            global::System.Action<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4>? searchResultLocation = null,

            global::System.Action<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5>? webSearchResultLocation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCharLocation)
            {
                charLocation?.Invoke(CharLocation!);
            }
            else if (IsContentBlockLocation)
            {
                contentBlockLocation?.Invoke(ContentBlockLocation!);
            }
            else if (IsPageLocation)
            {
                pageLocation?.Invoke(PageLocation!);
            }
            else if (IsSearchResultLocation)
            {
                searchResultLocation?.Invoke(SearchResultLocation!);
            }
            else if (IsWebSearchResultLocation)
            {
                webSearchResultLocation?.Invoke(WebSearchResultLocation!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1>? charLocation = null,
            global::System.Action<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2>? contentBlockLocation = null,
            global::System.Action<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3>? pageLocation = null,
            global::System.Action<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4>? searchResultLocation = null,
            global::System.Action<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5>? webSearchResultLocation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCharLocation)
            {
                charLocation?.Invoke(CharLocation!);
            }
            else if (IsContentBlockLocation)
            {
                contentBlockLocation?.Invoke(ContentBlockLocation!);
            }
            else if (IsPageLocation)
            {
                pageLocation?.Invoke(PageLocation!);
            }
            else if (IsSearchResultLocation)
            {
                searchResultLocation?.Invoke(SearchResultLocation!);
            }
            else if (IsWebSearchResultLocation)
            {
                webSearchResultLocation?.Invoke(WebSearchResultLocation!);
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
                typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1),
                ContentBlockLocation,
                typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2),
                PageLocation,
                typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3),
                SearchResultLocation,
                typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4),
                WebSearchResultLocation,
                typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5),
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
        public bool Equals(AnthropicTextBlockParamCitationsItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1?>.Default.Equals(CharLocation, other.CharLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2?>.Default.Equals(ContentBlockLocation, other.ContentBlockLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3?>.Default.Equals(PageLocation, other.PageLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4?>.Default.Equals(SearchResultLocation, other.SearchResultLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5?>.Default.Equals(WebSearchResultLocation, other.WebSearchResultLocation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicTextBlockParamCitationsItems obj1, AnthropicTextBlockParamCitationsItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicTextBlockParamCitationsItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicTextBlockParamCitationsItems obj1, AnthropicTextBlockParamCitationsItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicTextBlockParamCitationsItems o && Equals(o);
        }
    }
}
