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
        public global::OpenRouter.AnthropicCitationWebSearchResultLocationParam? AnthropicCitationWebSearchResultLocationParam { get; init; }
#else
        public global::OpenRouter.AnthropicCitationWebSearchResultLocationParam? AnthropicCitationWebSearchResultLocationParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicCitationWebSearchResultLocationParam))]
#endif
        public bool IsAnthropicCitationWebSearchResultLocationParam => AnthropicCitationWebSearchResultLocationParam != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCitationSearchResultLocationParam? AnthropicCitationSearchResultLocationParam { get; init; }
#else
        public global::OpenRouter.AnthropicCitationSearchResultLocationParam? AnthropicCitationSearchResultLocationParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicCitationSearchResultLocationParam))]
#endif
        public bool IsAnthropicCitationSearchResultLocationParam => AnthropicCitationSearchResultLocationParam != null;
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
        public static implicit operator AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicCitationWebSearchResultLocationParam value) => new AnthropicTextBlockParamCitationsItems((global::OpenRouter.AnthropicCitationWebSearchResultLocationParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationWebSearchResultLocationParam?(AnthropicTextBlockParamCitationsItems @this) => @this.AnthropicCitationWebSearchResultLocationParam;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicCitationWebSearchResultLocationParam? value)
        {
            AnthropicCitationWebSearchResultLocationParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicCitationSearchResultLocationParam value) => new AnthropicTextBlockParamCitationsItems((global::OpenRouter.AnthropicCitationSearchResultLocationParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCitationSearchResultLocationParam?(AnthropicTextBlockParamCitationsItems @this) => @this.AnthropicCitationSearchResultLocationParam;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextBlockParamCitationsItems(global::OpenRouter.AnthropicCitationSearchResultLocationParam? value)
        {
            AnthropicCitationSearchResultLocationParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextBlockParamCitationsItems(
            global::OpenRouter.AnthropicCitationCharLocationParam? anthropicCitationCharLocationParam,
            global::OpenRouter.AnthropicCitationPageLocationParam? anthropicCitationPageLocationParam,
            global::OpenRouter.AnthropicCitationContentBlockLocationParam? anthropicCitationContentBlockLocationParam,
            global::OpenRouter.AnthropicCitationWebSearchResultLocationParam? anthropicCitationWebSearchResultLocationParam,
            global::OpenRouter.AnthropicCitationSearchResultLocationParam? anthropicCitationSearchResultLocationParam
            )
        {
            AnthropicCitationCharLocationParam = anthropicCitationCharLocationParam;
            AnthropicCitationPageLocationParam = anthropicCitationPageLocationParam;
            AnthropicCitationContentBlockLocationParam = anthropicCitationContentBlockLocationParam;
            AnthropicCitationWebSearchResultLocationParam = anthropicCitationWebSearchResultLocationParam;
            AnthropicCitationSearchResultLocationParam = anthropicCitationSearchResultLocationParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicCitationSearchResultLocationParam as object ??
            AnthropicCitationWebSearchResultLocationParam as object ??
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
            AnthropicCitationWebSearchResultLocationParam?.ToString() ??
            AnthropicCitationSearchResultLocationParam?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicCitationCharLocationParam && !IsAnthropicCitationPageLocationParam && !IsAnthropicCitationContentBlockLocationParam && !IsAnthropicCitationWebSearchResultLocationParam && !IsAnthropicCitationSearchResultLocationParam || !IsAnthropicCitationCharLocationParam && IsAnthropicCitationPageLocationParam && !IsAnthropicCitationContentBlockLocationParam && !IsAnthropicCitationWebSearchResultLocationParam && !IsAnthropicCitationSearchResultLocationParam || !IsAnthropicCitationCharLocationParam && !IsAnthropicCitationPageLocationParam && IsAnthropicCitationContentBlockLocationParam && !IsAnthropicCitationWebSearchResultLocationParam && !IsAnthropicCitationSearchResultLocationParam || !IsAnthropicCitationCharLocationParam && !IsAnthropicCitationPageLocationParam && !IsAnthropicCitationContentBlockLocationParam && IsAnthropicCitationWebSearchResultLocationParam && !IsAnthropicCitationSearchResultLocationParam || !IsAnthropicCitationCharLocationParam && !IsAnthropicCitationPageLocationParam && !IsAnthropicCitationContentBlockLocationParam && !IsAnthropicCitationWebSearchResultLocationParam && IsAnthropicCitationSearchResultLocationParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicCitationCharLocationParam?, TResult>? anthropicCitationCharLocationParam = null,
            global::System.Func<global::OpenRouter.AnthropicCitationPageLocationParam?, TResult>? anthropicCitationPageLocationParam = null,
            global::System.Func<global::OpenRouter.AnthropicCitationContentBlockLocationParam?, TResult>? anthropicCitationContentBlockLocationParam = null,
            global::System.Func<global::OpenRouter.AnthropicCitationWebSearchResultLocationParam?, TResult>? anthropicCitationWebSearchResultLocationParam = null,
            global::System.Func<global::OpenRouter.AnthropicCitationSearchResultLocationParam?, TResult>? anthropicCitationSearchResultLocationParam = null,
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
            else if (IsAnthropicCitationWebSearchResultLocationParam && anthropicCitationWebSearchResultLocationParam != null)
            {
                return anthropicCitationWebSearchResultLocationParam(AnthropicCitationWebSearchResultLocationParam!);
            }
            else if (IsAnthropicCitationSearchResultLocationParam && anthropicCitationSearchResultLocationParam != null)
            {
                return anthropicCitationSearchResultLocationParam(AnthropicCitationSearchResultLocationParam!);
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
            global::System.Action<global::OpenRouter.AnthropicCitationWebSearchResultLocationParam?>? anthropicCitationWebSearchResultLocationParam = null,
            global::System.Action<global::OpenRouter.AnthropicCitationSearchResultLocationParam?>? anthropicCitationSearchResultLocationParam = null,
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
            else if (IsAnthropicCitationWebSearchResultLocationParam)
            {
                anthropicCitationWebSearchResultLocationParam?.Invoke(AnthropicCitationWebSearchResultLocationParam!);
            }
            else if (IsAnthropicCitationSearchResultLocationParam)
            {
                anthropicCitationSearchResultLocationParam?.Invoke(AnthropicCitationSearchResultLocationParam!);
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
                AnthropicCitationWebSearchResultLocationParam,
                typeof(global::OpenRouter.AnthropicCitationWebSearchResultLocationParam),
                AnthropicCitationSearchResultLocationParam,
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
        public bool Equals(AnthropicTextBlockParamCitationsItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationCharLocationParam?>.Default.Equals(AnthropicCitationCharLocationParam, other.AnthropicCitationCharLocationParam) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationPageLocationParam?>.Default.Equals(AnthropicCitationPageLocationParam, other.AnthropicCitationPageLocationParam) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationContentBlockLocationParam?>.Default.Equals(AnthropicCitationContentBlockLocationParam, other.AnthropicCitationContentBlockLocationParam) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationWebSearchResultLocationParam?>.Default.Equals(AnthropicCitationWebSearchResultLocationParam, other.AnthropicCitationWebSearchResultLocationParam) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCitationSearchResultLocationParam?>.Default.Equals(AnthropicCitationSearchResultLocationParam, other.AnthropicCitationSearchResultLocationParam) 
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
