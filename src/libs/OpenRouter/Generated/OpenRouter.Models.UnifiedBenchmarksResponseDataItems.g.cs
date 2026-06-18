#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UnifiedBenchmarksResponseDataItems : global::System.IEquatable<UnifiedBenchmarksResponseDataItems>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminatorSource? Source { get; }

        /// <summary>
        /// artificial-analysis variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1? ArtificialAnalysis { get; init; }
#else
        public global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1? ArtificialAnalysis { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtificialAnalysis))]
#endif
        public bool IsArtificialAnalysis => ArtificialAnalysis != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickArtificialAnalysis(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1? value)
        {
            value = ArtificialAnalysis;
            return IsArtificialAnalysis;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1 PickArtificialAnalysis() => IsArtificialAnalysis
            ? ArtificialAnalysis!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ArtificialAnalysis' but the value was {ToString()}.");

        /// <summary>
        /// design-arena variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2? DesignArena { get; init; }
#else
        public global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2? DesignArena { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DesignArena))]
#endif
        public bool IsDesignArena => DesignArena != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDesignArena(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2? value)
        {
            value = DesignArena;
            return IsDesignArena;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2 PickDesignArena() => IsDesignArena
            ? DesignArena!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DesignArena' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnifiedBenchmarksResponseDataItems(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1 value) => new UnifiedBenchmarksResponseDataItems((global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1?(UnifiedBenchmarksResponseDataItems @this) => @this.ArtificialAnalysis;

        /// <summary>
        /// 
        /// </summary>
        public UnifiedBenchmarksResponseDataItems(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1? value)
        {
            ArtificialAnalysis = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UnifiedBenchmarksResponseDataItems FromArtificialAnalysis(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1? value) => new UnifiedBenchmarksResponseDataItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnifiedBenchmarksResponseDataItems(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2 value) => new UnifiedBenchmarksResponseDataItems((global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2?(UnifiedBenchmarksResponseDataItems @this) => @this.DesignArena;

        /// <summary>
        /// 
        /// </summary>
        public UnifiedBenchmarksResponseDataItems(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2? value)
        {
            DesignArena = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UnifiedBenchmarksResponseDataItems FromDesignArena(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2? value) => new UnifiedBenchmarksResponseDataItems(value);

        /// <summary>
        /// 
        /// </summary>
        public UnifiedBenchmarksResponseDataItems(
            global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminatorSource? source,
            global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1? artificialAnalysis,
            global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2? designArena
            )
        {
            Source = source;

            ArtificialAnalysis = artificialAnalysis;
            DesignArena = designArena;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DesignArena as object ??
            ArtificialAnalysis as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ArtificialAnalysis?.ToString() ??
            DesignArena?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsArtificialAnalysis && !IsDesignArena || !IsArtificialAnalysis && IsDesignArena;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1, TResult>? artificialAnalysis = null,
            global::System.Func<global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2, TResult>? designArena = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsArtificialAnalysis && artificialAnalysis != null)
            {
                return artificialAnalysis(ArtificialAnalysis!);
            }
            else if (IsDesignArena && designArena != null)
            {
                return designArena(DesignArena!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1>? artificialAnalysis = null,

            global::System.Action<global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2>? designArena = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsArtificialAnalysis)
            {
                artificialAnalysis?.Invoke(ArtificialAnalysis!);
            }
            else if (IsDesignArena)
            {
                designArena?.Invoke(DesignArena!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1>? artificialAnalysis = null,
            global::System.Action<global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2>? designArena = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsArtificialAnalysis)
            {
                artificialAnalysis?.Invoke(ArtificialAnalysis!);
            }
            else if (IsDesignArena)
            {
                designArena?.Invoke(DesignArena!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ArtificialAnalysis,
                typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1),
                DesignArena,
                typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2),
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
        public bool Equals(UnifiedBenchmarksResponseDataItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1?>.Default.Equals(ArtificialAnalysis, other.ArtificialAnalysis) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2?>.Default.Equals(DesignArena, other.DesignArena) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UnifiedBenchmarksResponseDataItems obj1, UnifiedBenchmarksResponseDataItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UnifiedBenchmarksResponseDataItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UnifiedBenchmarksResponseDataItems obj1, UnifiedBenchmarksResponseDataItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnifiedBenchmarksResponseDataItems o && Equals(o);
        }
    }
}
