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
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCitationCharLocationParam? AnthropicCitationCharLocationParam { get; init; }
#else
        public global::OpenRouter.AnthropicCitationCharLocationParam? AnthropicCitationCharLocationParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicCitationCharLocationParam))]
#endif
        public bool IsAnthropicCitationCharLocationParam => AnthropicCitationCharLocationParam != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCitationPageLocationParam? AnthropicCitationPageLocationParam { get; init; }
#else
        public global::OpenRouter.AnthropicCitationPageLocationParam? AnthropicCitationPageLocationParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicCitationPageLocationParam))]
#endif
        public bool IsAnthropicCitationPageLocationParam => AnthropicCitationPageLocationParam != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCitationContentBlockLocationParam? AnthropicCitationContentBlockLocationParam { get; init; }
#else
        public global::OpenRouter.AnthropicCitationContentBlockLocationParam? AnthropicCitationContentBlockLocationParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicCitationContentBlockLocationParam))]
#endif
        public bool IsAnthropicCitationContentBlockLocationParam => AnthropicCitationContentBlockLocationParam != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCitationWebSearchResultLocation? AnthropicCitationWebSearchResultLocation { get; init; }
#else
        public global::OpenRouter.AnthropicCitationWebSearchResultLocation? AnthropicCitationWebSearchResultLocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicCitationWebSearchResultLocation))]
#endif
        public bool IsAnthropicCitationWebSearchResultLocation => AnthropicCitationWebSearchResultLocation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCitationSearchResultLocation? AnthropicCitationSearchResultLocation { get; init; }
#else
        public global::OpenRouter.AnthropicCitationSearchResultLocation? AnthropicCitationSearchResultLocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicCitationSearchResultLocation))]
#endif
        public bool IsAnthropicCitationSearchResultLocation => AnthropicCitationSearchResultLocation != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicCitationCharLocationParam value) => new AnthropicTextBlockParamCitationsItems((global::OpenRouter.AnthropicCitationCharLocationParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationCharLocationParam?(AnthropicTextBlockParamCitationsItems @this) => @this.AnthropicCitationCharLocationParam;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicCitationCharLocationParam? value)
        {
            AnthropicCitationCharLocationParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicCitationPageLocationParam value) => new AnthropicTextBlockParamCitationsItems((global::OpenRouter.AnthropicCitationPageLocationParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationPageLocationParam?(AnthropicTextBlockParamCitationsItems @this) => @this.AnthropicCitationPageLocationParam;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicCitationPageLocationParam? value)
        {
            AnthropicCitationPageLocationParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicCitationContentBlockLocationParam value) => new AnthropicTextBlockParamCitationsItems((global::OpenRouter.AnthropicCitationContentBlockLocationParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationContentBlockLocationParam?(AnthropicTextBlockParamCitationsItems @this) => @this.AnthropicCitationContentBlockLocationParam;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicCitationContentBlockLocationParam? value)
        {
            AnthropicCitationContentBlockLocationParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicCitationWebSearchResultLocation value) => new AnthropicTextBlockParamCitationsItems((global::OpenRouter.AnthropicCitationWebSearchResultLocation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationWebSearchResultLocation?(AnthropicTextBlockParamCitationsItems @this) => @this.AnthropicCitationWebSearchResultLocation;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicCitationWebSearchResultLocation? value)
        {
            AnthropicCitationWebSearchResultLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicCitationSearchResultLocation value) => new AnthropicTextBlockParamCitationsItems((global::OpenRouter.AnthropicCitationSearchResultLocation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationSearchResultLocation?(AnthropicTextBlockParamCitationsItems @this) => @this.AnthropicCitationSearchResultLocation;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicCitationSearchResultLocation? value)
        {
            AnthropicCitationSearchResultLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextBlockParamCitationsItems(
            global::OpenRouter.AnthropicCitationCharLocationParam? anthropicCitationCharLocationParam,
            global::OpenRouter.AnthropicCitationPageLocationParam? anthropicCitationPageLocationParam,
            global::OpenRouter.AnthropicCitationContentBlockLocationParam? anthropicCitationContentBlockLocationParam,
            global::OpenRouter.AnthropicCitationWebSearchResultLocation? anthropicCitationWebSearchResultLocation,
            global::OpenRouter.AnthropicCitationSearchResultLocation? anthropicCitationSearchResultLocation
            )
        {
            AnthropicCitationCharLocationParam = anthropicCitationCharLocationParam;
            AnthropicCitationPageLocationParam = anthropicCitationPageLocationParam;
            AnthropicCitationContentBlockLocationParam = anthropicCitationContentBlockLocationParam;
            AnthropicCitationWebSearchResultLocation = anthropicCitationWebSearchResultLocation;
            AnthropicCitationSearchResultLocation = anthropicCitationSearchResultLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicCitationSearchResultLocation as object ??
            AnthropicCitationWebSearchResultLocation as object ??
            AnthropicCitationContentBlockLocationParam as object ??
            AnthropicCitationPageLocationParam as object ??
            AnthropicCitationCharLocationParam as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicCitationCharLocationParam?.ToString() ??
            AnthropicCitationPageLocationParam?.ToString() ??
            AnthropicCitationContentBlockLocationParam?.ToString() ??
            AnthropicCitationWebSearchResultLocation?.ToString() ??
            AnthropicCitationSearchResultLocation?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicCitationCharLocationParam && !IsAnthropicCitationPageLocationParam && !IsAnthropicCitationContentBlockLocationParam && !IsAnthropicCitationWebSearchResultLocation && !IsAnthropicCitationSearchResultLocation || !IsAnthropicCitationCharLocationParam && IsAnthropicCitationPageLocationParam && !IsAnthropicCitationContentBlockLocationParam && !IsAnthropicCitationWebSearchResultLocation && !IsAnthropicCitationSearchResultLocation || !IsAnthropicCitationCharLocationParam && !IsAnthropicCitationPageLocationParam && IsAnthropicCitationContentBlockLocationParam && !IsAnthropicCitationWebSearchResultLocation && !IsAnthropicCitationSearchResultLocation || !IsAnthropicCitationCharLocationParam && !IsAnthropicCitationPageLocationParam && !IsAnthropicCitationContentBlockLocationParam && IsAnthropicCitationWebSearchResultLocation && !IsAnthropicCitationSearchResultLocation || !IsAnthropicCitationCharLocationParam && !IsAnthropicCitationPageLocationParam && !IsAnthropicCitationContentBlockLocationParam && !IsAnthropicCitationWebSearchResultLocation && IsAnthropicCitationSearchResultLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicCitationCharLocationParam?, TResult>? anthropicCitationCharLocationParam = null,
            global::System.Func<global::OpenRouter.AnthropicCitationPageLocationParam?, TResult>? anthropicCitationPageLocationParam = null,
            global::System.Func<global::OpenRouter.AnthropicCitationContentBlockLocationParam?, TResult>? anthropicCitationContentBlockLocationParam = null,
            global::System.Func<global::OpenRouter.AnthropicCitationWebSearchResultLocation?, TResult>? anthropicCitationWebSearchResultLocation = null,
            global::System.Func<global::OpenRouter.AnthropicCitationSearchResultLocation?, TResult>? anthropicCitationSearchResultLocation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicCitationCharLocationParam && anthropicCitationCharLocationParam != null)
            {
                return anthropicCitationCharLocationParam(AnthropicCitationCharLocationParam!);
            }
            else if (IsAnthropicCitationPageLocationParam && anthropicCitationPageLocationParam != null)
            {
                return anthropicCitationPageLocationParam(AnthropicCitationPageLocationParam!);
            }
            else if (IsAnthropicCitationContentBlockLocationParam && anthropicCitationContentBlockLocationParam != null)
            {
                return anthropicCitationContentBlockLocationParam(AnthropicCitationContentBlockLocationParam!);
            }
            else if (IsAnthropicCitationWebSearchResultLocation && anthropicCitationWebSearchResultLocation != null)
            {
                return anthropicCitationWebSearchResultLocation(AnthropicCitationWebSearchResultLocation!);
            }
            else if (IsAnthropicCitationSearchResultLocation && anthropicCitationSearchResultLocation != null)
            {
                return anthropicCitationSearchResultLocation(AnthropicCitationSearchResultLocation!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicCitationCharLocationParam?>? anthropicCitationCharLocationParam = null,
            global::System.Action<global::OpenRouter.AnthropicCitationPageLocationParam?>? anthropicCitationPageLocationParam = null,
            global::System.Action<global::OpenRouter.AnthropicCitationContentBlockLocationParam?>? anthropicCitationContentBlockLocationParam = null,
            global::System.Action<global::OpenRouter.AnthropicCitationWebSearchResultLocation?>? anthropicCitationWebSearchResultLocation = null,
            global::System.Action<global::OpenRouter.AnthropicCitationSearchResultLocation?>? anthropicCitationSearchResultLocation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicCitationCharLocationParam)
            {
                anthropicCitationCharLocationParam?.Invoke(AnthropicCitationCharLocationParam!);
            }
            else if (IsAnthropicCitationPageLocationParam)
            {
                anthropicCitationPageLocationParam?.Invoke(AnthropicCitationPageLocationParam!);
            }
            else if (IsAnthropicCitationContentBlockLocationParam)
            {
                anthropicCitationContentBlockLocationParam?.Invoke(AnthropicCitationContentBlockLocationParam!);
            }
            else if (IsAnthropicCitationWebSearchResultLocation)
            {
                anthropicCitationWebSearchResultLocation?.Invoke(AnthropicCitationWebSearchResultLocation!);
            }
            else if (IsAnthropicCitationSearchResultLocation)
            {
                anthropicCitationSearchResultLocation?.Invoke(AnthropicCitationSearchResultLocation!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicCitationCharLocationParam,
                typeof(global::OpenRouter.AnthropicCitationCharLocationParam),
                AnthropicCitationPageLocationParam,
                typeof(global::OpenRouter.AnthropicCitationPageLocationParam),
                AnthropicCitationContentBlockLocationParam,
                typeof(global::OpenRouter.AnthropicCitationContentBlockLocationParam),
                AnthropicCitationWebSearchResultLocation,
                typeof(global::OpenRouter.AnthropicCitationWebSearchResultLocation),
                AnthropicCitationSearchResultLocation,
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
        public bool Equals(AnthropicTextBlockParamCitationsItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationCharLocationParam?>.Default.Equals(AnthropicCitationCharLocationParam, other.AnthropicCitationCharLocationParam) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationPageLocationParam?>.Default.Equals(AnthropicCitationPageLocationParam, other.AnthropicCitationPageLocationParam) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationContentBlockLocationParam?>.Default.Equals(AnthropicCitationContentBlockLocationParam, other.AnthropicCitationContentBlockLocationParam) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationWebSearchResultLocation?>.Default.Equals(AnthropicCitationWebSearchResultLocation, other.AnthropicCitationWebSearchResultLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationSearchResultLocation?>.Default.Equals(AnthropicCitationSearchResultLocation, other.AnthropicCitationSearchResultLocation) 
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
