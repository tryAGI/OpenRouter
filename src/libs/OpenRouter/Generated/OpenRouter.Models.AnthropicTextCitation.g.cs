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
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCitationCharLocation? AnthropicCitationCharLocation { get; init; }
#else
        public global::OpenRouter.AnthropicCitationCharLocation? AnthropicCitationCharLocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicCitationCharLocation))]
#endif
        public bool IsAnthropicCitationCharLocation => AnthropicCitationCharLocation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCitationPageLocation? AnthropicCitationPageLocation { get; init; }
#else
        public global::OpenRouter.AnthropicCitationPageLocation? AnthropicCitationPageLocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicCitationPageLocation))]
#endif
        public bool IsAnthropicCitationPageLocation => AnthropicCitationPageLocation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCitationContentBlockLocation? AnthropicCitationContentBlockLocation { get; init; }
#else
        public global::OpenRouter.AnthropicCitationContentBlockLocation? AnthropicCitationContentBlockLocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicCitationContentBlockLocation))]
#endif
        public bool IsAnthropicCitationContentBlockLocation => AnthropicCitationContentBlockLocation != null;

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
        public static implicit operator AnthropicTextCitation(global::OpenRouter.AnthropicCitationCharLocation value) => new AnthropicTextCitation((global::OpenRouter.AnthropicCitationCharLocation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationCharLocation?(AnthropicTextCitation @this) => @this.AnthropicCitationCharLocation;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextCitation(global::OpenRouter.AnthropicCitationCharLocation? value)
        {
            AnthropicCitationCharLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextCitation(global::OpenRouter.AnthropicCitationPageLocation value) => new AnthropicTextCitation((global::OpenRouter.AnthropicCitationPageLocation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationPageLocation?(AnthropicTextCitation @this) => @this.AnthropicCitationPageLocation;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextCitation(global::OpenRouter.AnthropicCitationPageLocation? value)
        {
            AnthropicCitationPageLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextCitation(global::OpenRouter.AnthropicCitationContentBlockLocation value) => new AnthropicTextCitation((global::OpenRouter.AnthropicCitationContentBlockLocation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationContentBlockLocation?(AnthropicTextCitation @this) => @this.AnthropicCitationContentBlockLocation;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextCitation(global::OpenRouter.AnthropicCitationContentBlockLocation? value)
        {
            AnthropicCitationContentBlockLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextCitation(global::OpenRouter.AnthropicCitationWebSearchResultLocation value) => new AnthropicTextCitation((global::OpenRouter.AnthropicCitationWebSearchResultLocation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationWebSearchResultLocation?(AnthropicTextCitation @this) => @this.AnthropicCitationWebSearchResultLocation;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextCitation(global::OpenRouter.AnthropicCitationWebSearchResultLocation? value)
        {
            AnthropicCitationWebSearchResultLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextCitation(global::OpenRouter.AnthropicCitationSearchResultLocation value) => new AnthropicTextCitation((global::OpenRouter.AnthropicCitationSearchResultLocation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationSearchResultLocation?(AnthropicTextCitation @this) => @this.AnthropicCitationSearchResultLocation;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextCitation(global::OpenRouter.AnthropicCitationSearchResultLocation? value)
        {
            AnthropicCitationSearchResultLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextCitation(
            global::OpenRouter.AnthropicCitationCharLocation? anthropicCitationCharLocation,
            global::OpenRouter.AnthropicCitationPageLocation? anthropicCitationPageLocation,
            global::OpenRouter.AnthropicCitationContentBlockLocation? anthropicCitationContentBlockLocation,
            global::OpenRouter.AnthropicCitationWebSearchResultLocation? anthropicCitationWebSearchResultLocation,
            global::OpenRouter.AnthropicCitationSearchResultLocation? anthropicCitationSearchResultLocation
            )
        {
            AnthropicCitationCharLocation = anthropicCitationCharLocation;
            AnthropicCitationPageLocation = anthropicCitationPageLocation;
            AnthropicCitationContentBlockLocation = anthropicCitationContentBlockLocation;
            AnthropicCitationWebSearchResultLocation = anthropicCitationWebSearchResultLocation;
            AnthropicCitationSearchResultLocation = anthropicCitationSearchResultLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicCitationSearchResultLocation as object ??
            AnthropicCitationWebSearchResultLocation as object ??
            AnthropicCitationContentBlockLocation as object ??
            AnthropicCitationPageLocation as object ??
            AnthropicCitationCharLocation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicCitationCharLocation?.ToString() ??
            AnthropicCitationPageLocation?.ToString() ??
            AnthropicCitationContentBlockLocation?.ToString() ??
            AnthropicCitationWebSearchResultLocation?.ToString() ??
            AnthropicCitationSearchResultLocation?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicCitationCharLocation && !IsAnthropicCitationPageLocation && !IsAnthropicCitationContentBlockLocation && !IsAnthropicCitationWebSearchResultLocation && !IsAnthropicCitationSearchResultLocation || !IsAnthropicCitationCharLocation && IsAnthropicCitationPageLocation && !IsAnthropicCitationContentBlockLocation && !IsAnthropicCitationWebSearchResultLocation && !IsAnthropicCitationSearchResultLocation || !IsAnthropicCitationCharLocation && !IsAnthropicCitationPageLocation && IsAnthropicCitationContentBlockLocation && !IsAnthropicCitationWebSearchResultLocation && !IsAnthropicCitationSearchResultLocation || !IsAnthropicCitationCharLocation && !IsAnthropicCitationPageLocation && !IsAnthropicCitationContentBlockLocation && IsAnthropicCitationWebSearchResultLocation && !IsAnthropicCitationSearchResultLocation || !IsAnthropicCitationCharLocation && !IsAnthropicCitationPageLocation && !IsAnthropicCitationContentBlockLocation && !IsAnthropicCitationWebSearchResultLocation && IsAnthropicCitationSearchResultLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicCitationCharLocation?, TResult>? anthropicCitationCharLocation = null,
            global::System.Func<global::OpenRouter.AnthropicCitationPageLocation?, TResult>? anthropicCitationPageLocation = null,
            global::System.Func<global::OpenRouter.AnthropicCitationContentBlockLocation?, TResult>? anthropicCitationContentBlockLocation = null,
            global::System.Func<global::OpenRouter.AnthropicCitationWebSearchResultLocation?, TResult>? anthropicCitationWebSearchResultLocation = null,
            global::System.Func<global::OpenRouter.AnthropicCitationSearchResultLocation?, TResult>? anthropicCitationSearchResultLocation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicCitationCharLocation && anthropicCitationCharLocation != null)
            {
                return anthropicCitationCharLocation(AnthropicCitationCharLocation!);
            }
            else if (IsAnthropicCitationPageLocation && anthropicCitationPageLocation != null)
            {
                return anthropicCitationPageLocation(AnthropicCitationPageLocation!);
            }
            else if (IsAnthropicCitationContentBlockLocation && anthropicCitationContentBlockLocation != null)
            {
                return anthropicCitationContentBlockLocation(AnthropicCitationContentBlockLocation!);
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
            global::System.Action<global::OpenRouter.AnthropicCitationCharLocation?>? anthropicCitationCharLocation = null,
            global::System.Action<global::OpenRouter.AnthropicCitationPageLocation?>? anthropicCitationPageLocation = null,
            global::System.Action<global::OpenRouter.AnthropicCitationContentBlockLocation?>? anthropicCitationContentBlockLocation = null,
            global::System.Action<global::OpenRouter.AnthropicCitationWebSearchResultLocation?>? anthropicCitationWebSearchResultLocation = null,
            global::System.Action<global::OpenRouter.AnthropicCitationSearchResultLocation?>? anthropicCitationSearchResultLocation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicCitationCharLocation)
            {
                anthropicCitationCharLocation?.Invoke(AnthropicCitationCharLocation!);
            }
            else if (IsAnthropicCitationPageLocation)
            {
                anthropicCitationPageLocation?.Invoke(AnthropicCitationPageLocation!);
            }
            else if (IsAnthropicCitationContentBlockLocation)
            {
                anthropicCitationContentBlockLocation?.Invoke(AnthropicCitationContentBlockLocation!);
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
                AnthropicCitationCharLocation,
                typeof(global::OpenRouter.AnthropicCitationCharLocation),
                AnthropicCitationPageLocation,
                typeof(global::OpenRouter.AnthropicCitationPageLocation),
                AnthropicCitationContentBlockLocation,
                typeof(global::OpenRouter.AnthropicCitationContentBlockLocation),
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
        public bool Equals(AnthropicTextCitation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationCharLocation?>.Default.Equals(AnthropicCitationCharLocation, other.AnthropicCitationCharLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationPageLocation?>.Default.Equals(AnthropicCitationPageLocation, other.AnthropicCitationPageLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationContentBlockLocation?>.Default.Equals(AnthropicCitationContentBlockLocation, other.AnthropicCitationContentBlockLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationWebSearchResultLocation?>.Default.Equals(AnthropicCitationWebSearchResultLocation, other.AnthropicCitationWebSearchResultLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationSearchResultLocation?>.Default.Equals(AnthropicCitationSearchResultLocation, other.AnthropicCitationSearchResultLocation) 
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
