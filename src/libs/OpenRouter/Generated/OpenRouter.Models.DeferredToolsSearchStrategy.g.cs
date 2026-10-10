#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Router-local regex/BM25 or caller-owned custom search.<br/>
    /// Example: {"max_results":5,"type":"bm25"}
    /// </summary>
    public readonly partial struct DeferredToolsSearchStrategy : global::System.IEquatable<DeferredToolsSearchStrategy>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsSearchStrategyDiscriminatorType? Type { get; }

        /// <summary>
        /// Versioned safe-regex retrieval over supplied tool definitions.<br/>
        /// Example: {"max_results":5,"type":"regex"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.DeferredRegexSearch? Regex { get; init; }
#else
        public global::OpenRouter.DeferredRegexSearch? Regex { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Regex))]
#endif
        public bool IsRegex => Regex != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRegex(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.DeferredRegexSearch? value)
        {
            value = Regex;
            return IsRegex;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredRegexSearch PickRegex() => Regex is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Regex' but the value was {ToString()}.");

        /// <summary>
        /// Deterministic BM25 retrieval over supplied tool definitions.<br/>
        /// Example: {"max_results":5,"type":"bm25"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.DeferredBm25Search? Bm25 { get; init; }
#else
        public global::OpenRouter.DeferredBm25Search? Bm25 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bm25))]
#endif
        public bool IsBm25 => Bm25 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBm25(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.DeferredBm25Search? value)
        {
            value = Bm25;
            return IsBm25;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredBm25Search PickBm25() => Bm25 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Bm25' but the value was {ToString()}.");

        /// <summary>
        /// Caller-executed search returning existing tool identities under result_key.<br/>
        /// Example: {"max_results":5,"result_key":"tool_names","tool_id":"search_catalog","type":"custom"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.DeferredCustomSearch? Custom { get; init; }
#else
        public global::OpenRouter.DeferredCustomSearch? Custom { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustom(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.DeferredCustomSearch? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredCustomSearch PickCustom() => Custom is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DeferredToolsSearchStrategy(global::OpenRouter.DeferredRegexSearch value) => new DeferredToolsSearchStrategy((global::OpenRouter.DeferredRegexSearch?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.DeferredRegexSearch?(DeferredToolsSearchStrategy @this) => @this.Regex;

        /// <summary>
        ///
        /// </summary>
        public DeferredToolsSearchStrategy(global::OpenRouter.DeferredRegexSearch? value)
        {
            Regex = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DeferredToolsSearchStrategy FromRegex(global::OpenRouter.DeferredRegexSearch? value) => new DeferredToolsSearchStrategy(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DeferredToolsSearchStrategy(global::OpenRouter.DeferredBm25Search value) => new DeferredToolsSearchStrategy((global::OpenRouter.DeferredBm25Search?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.DeferredBm25Search?(DeferredToolsSearchStrategy @this) => @this.Bm25;

        /// <summary>
        ///
        /// </summary>
        public DeferredToolsSearchStrategy(global::OpenRouter.DeferredBm25Search? value)
        {
            Bm25 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DeferredToolsSearchStrategy FromBm25(global::OpenRouter.DeferredBm25Search? value) => new DeferredToolsSearchStrategy(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DeferredToolsSearchStrategy(global::OpenRouter.DeferredCustomSearch value) => new DeferredToolsSearchStrategy((global::OpenRouter.DeferredCustomSearch?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.DeferredCustomSearch?(DeferredToolsSearchStrategy @this) => @this.Custom;

        /// <summary>
        ///
        /// </summary>
        public DeferredToolsSearchStrategy(global::OpenRouter.DeferredCustomSearch? value)
        {
            Custom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DeferredToolsSearchStrategy FromCustom(global::OpenRouter.DeferredCustomSearch? value) => new DeferredToolsSearchStrategy(value);

        /// <summary>
        ///
        /// </summary>
        public DeferredToolsSearchStrategy(
            global::OpenRouter.DeferredToolsSearchStrategyDiscriminatorType? type,
            global::OpenRouter.DeferredRegexSearch? regex,
            global::OpenRouter.DeferredBm25Search? bm25,
            global::OpenRouter.DeferredCustomSearch? custom
            )
        {
            Type = type;

            Regex = regex;
            Bm25 = bm25;
            Custom = custom;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Custom as object ??
            Bm25 as object ??
            Regex as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Regex?.ToString() ??
            Bm25?.ToString() ??
            Custom?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRegex && !IsBm25 && !IsCustom || !IsRegex && IsBm25 && !IsCustom || !IsRegex && !IsBm25 && IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.DeferredRegexSearch, TResult>? regex = null,
            global::System.Func<global::OpenRouter.DeferredBm25Search, TResult>? bm25 = null,
            global::System.Func<global::OpenRouter.DeferredCustomSearch, TResult>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Regex is { } __value0 && regex != null)
            {
                return regex(__value0);
            }
            else if (Bm25 is { } __value1 && bm25 != null)
            {
                return bm25(__value1);
            }
            else if (Custom is { } __value2 && custom != null)
            {
                return custom(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.DeferredRegexSearch>? regex = null,

            global::System.Action<global::OpenRouter.DeferredBm25Search>? bm25 = null,

            global::System.Action<global::OpenRouter.DeferredCustomSearch>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Regex is { } __value0)
            {
                regex?.Invoke(__value0);
            }
            else if (Bm25 is { } __value1)
            {
                bm25?.Invoke(__value1);
            }
            else if (Custom is { } __value2)
            {
                custom?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.DeferredRegexSearch>? regex = null,
            global::System.Action<global::OpenRouter.DeferredBm25Search>? bm25 = null,
            global::System.Action<global::OpenRouter.DeferredCustomSearch>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Regex is { } __value0)
            {
                regex?.Invoke(__value0);
            }
            else if (Bm25 is { } __value1)
            {
                bm25?.Invoke(__value1);
            }
            else if (Custom is { } __value2)
            {
                custom?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Regex,
                typeof(global::OpenRouter.DeferredRegexSearch),
                Bm25,
                typeof(global::OpenRouter.DeferredBm25Search),
                Custom,
                typeof(global::OpenRouter.DeferredCustomSearch),
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
        public bool Equals(DeferredToolsSearchStrategy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.DeferredRegexSearch?>.Default.Equals(Regex, other.Regex) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.DeferredBm25Search?>.Default.Equals(Bm25, other.Bm25) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.DeferredCustomSearch?>.Default.Equals(Custom, other.Custom)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DeferredToolsSearchStrategy obj1, DeferredToolsSearchStrategy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DeferredToolsSearchStrategy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DeferredToolsSearchStrategy obj1, DeferredToolsSearchStrategy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DeferredToolsSearchStrategy o && Equals(o);
        }
    }
}
