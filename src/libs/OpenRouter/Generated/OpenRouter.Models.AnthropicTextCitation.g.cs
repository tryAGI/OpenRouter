#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnthropicTextCitation : global::System.IEquatable<AnthropicTextCitation>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationDiscriminatorType? Type { get; }

        /// <summary>
        /// char_location variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextCitationVariant1? CharLocation { get; init; }
#else
        public global::OpenRouter.AnthropicTextCitationVariant1? CharLocation { get; }
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
            out global::OpenRouter.AnthropicTextCitationVariant1? value)
        {
            value = CharLocation;
            return IsCharLocation;
        }

        /// <summary>
        /// content_block_location variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextCitationVariant2? ContentBlockLocation { get; init; }
#else
        public global::OpenRouter.AnthropicTextCitationVariant2? ContentBlockLocation { get; }
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
            out global::OpenRouter.AnthropicTextCitationVariant2? value)
        {
            value = ContentBlockLocation;
            return IsContentBlockLocation;
        }

        /// <summary>
        /// page_location variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextCitationVariant3? PageLocation { get; init; }
#else
        public global::OpenRouter.AnthropicTextCitationVariant3? PageLocation { get; }
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
            out global::OpenRouter.AnthropicTextCitationVariant3? value)
        {
            value = PageLocation;
            return IsPageLocation;
        }

        /// <summary>
        /// search_result_location variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextCitationVariant4? SearchResultLocation { get; init; }
#else
        public global::OpenRouter.AnthropicTextCitationVariant4? SearchResultLocation { get; }
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
            out global::OpenRouter.AnthropicTextCitationVariant4? value)
        {
            value = SearchResultLocation;
            return IsSearchResultLocation;
        }

        /// <summary>
        /// web_search_result_location variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextCitationVariant5? WebSearchResultLocation { get; init; }
#else
        public global::OpenRouter.AnthropicTextCitationVariant5? WebSearchResultLocation { get; }
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
            out global::OpenRouter.AnthropicTextCitationVariant5? value)
        {
            value = WebSearchResultLocation;
            return IsWebSearchResultLocation;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextCitation(global::OpenRouter.AnthropicTextCitationVariant1 value) => new AnthropicTextCitation((global::OpenRouter.AnthropicTextCitationVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextCitationVariant1?(AnthropicTextCitation @this) => @this.CharLocation;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextCitation(global::OpenRouter.AnthropicTextCitationVariant1? value)
        {
            CharLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextCitation(global::OpenRouter.AnthropicTextCitationVariant2 value) => new AnthropicTextCitation((global::OpenRouter.AnthropicTextCitationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextCitationVariant2?(AnthropicTextCitation @this) => @this.ContentBlockLocation;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextCitation(global::OpenRouter.AnthropicTextCitationVariant2? value)
        {
            ContentBlockLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextCitation(global::OpenRouter.AnthropicTextCitationVariant3 value) => new AnthropicTextCitation((global::OpenRouter.AnthropicTextCitationVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextCitationVariant3?(AnthropicTextCitation @this) => @this.PageLocation;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextCitation(global::OpenRouter.AnthropicTextCitationVariant3? value)
        {
            PageLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextCitation(global::OpenRouter.AnthropicTextCitationVariant4 value) => new AnthropicTextCitation((global::OpenRouter.AnthropicTextCitationVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextCitationVariant4?(AnthropicTextCitation @this) => @this.SearchResultLocation;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextCitation(global::OpenRouter.AnthropicTextCitationVariant4? value)
        {
            SearchResultLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextCitation(global::OpenRouter.AnthropicTextCitationVariant5 value) => new AnthropicTextCitation((global::OpenRouter.AnthropicTextCitationVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextCitationVariant5?(AnthropicTextCitation @this) => @this.WebSearchResultLocation;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextCitation(global::OpenRouter.AnthropicTextCitationVariant5? value)
        {
            WebSearchResultLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextCitation(
            global::OpenRouter.AnthropicTextCitationDiscriminatorType? type,
            global::OpenRouter.AnthropicTextCitationVariant1? charLocation,
            global::OpenRouter.AnthropicTextCitationVariant2? contentBlockLocation,
            global::OpenRouter.AnthropicTextCitationVariant3? pageLocation,
            global::OpenRouter.AnthropicTextCitationVariant4? searchResultLocation,
            global::OpenRouter.AnthropicTextCitationVariant5? webSearchResultLocation
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
            global::System.Func<global::OpenRouter.AnthropicTextCitationVariant1, TResult>? charLocation = null,
            global::System.Func<global::OpenRouter.AnthropicTextCitationVariant2, TResult>? contentBlockLocation = null,
            global::System.Func<global::OpenRouter.AnthropicTextCitationVariant3, TResult>? pageLocation = null,
            global::System.Func<global::OpenRouter.AnthropicTextCitationVariant4, TResult>? searchResultLocation = null,
            global::System.Func<global::OpenRouter.AnthropicTextCitationVariant5, TResult>? webSearchResultLocation = null,
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
            global::System.Action<global::OpenRouter.AnthropicTextCitationVariant1>? charLocation = null,

            global::System.Action<global::OpenRouter.AnthropicTextCitationVariant2>? contentBlockLocation = null,

            global::System.Action<global::OpenRouter.AnthropicTextCitationVariant3>? pageLocation = null,

            global::System.Action<global::OpenRouter.AnthropicTextCitationVariant4>? searchResultLocation = null,

            global::System.Action<global::OpenRouter.AnthropicTextCitationVariant5>? webSearchResultLocation = null,
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
            global::System.Action<global::OpenRouter.AnthropicTextCitationVariant1>? charLocation = null,
            global::System.Action<global::OpenRouter.AnthropicTextCitationVariant2>? contentBlockLocation = null,
            global::System.Action<global::OpenRouter.AnthropicTextCitationVariant3>? pageLocation = null,
            global::System.Action<global::OpenRouter.AnthropicTextCitationVariant4>? searchResultLocation = null,
            global::System.Action<global::OpenRouter.AnthropicTextCitationVariant5>? webSearchResultLocation = null,
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
                typeof(global::OpenRouter.AnthropicTextCitationVariant1),
                ContentBlockLocation,
                typeof(global::OpenRouter.AnthropicTextCitationVariant2),
                PageLocation,
                typeof(global::OpenRouter.AnthropicTextCitationVariant3),
                SearchResultLocation,
                typeof(global::OpenRouter.AnthropicTextCitationVariant4),
                WebSearchResultLocation,
                typeof(global::OpenRouter.AnthropicTextCitationVariant5),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextCitationVariant1?>.Default.Equals(CharLocation, other.CharLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextCitationVariant2?>.Default.Equals(ContentBlockLocation, other.ContentBlockLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextCitationVariant3?>.Default.Equals(PageLocation, other.PageLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextCitationVariant4?>.Default.Equals(SearchResultLocation, other.SearchResultLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextCitationVariant5?>.Default.Equals(WebSearchResultLocation, other.WebSearchResultLocation) 
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
