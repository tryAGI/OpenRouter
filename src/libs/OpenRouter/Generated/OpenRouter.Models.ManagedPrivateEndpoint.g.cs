#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ManagedPrivateEndpoint : global::System.IEquatable<ManagedPrivateEndpoint>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.PrivateEndpointSummary? Summary { get; init; }
#else
        public global::OpenRouter.PrivateEndpointSummary? Summary { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Summary))]
#endif
        public bool IsSummary => Summary != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSummary(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.PrivateEndpointSummary? value)
        {
            value = Summary;
            return IsSummary;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSummary PickSummary() => Summary is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Summary' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ManagedPrivateEndpointVariant2? ManagedPrivateEndpointVariant2 { get; init; }
#else
        public global::OpenRouter.ManagedPrivateEndpointVariant2? ManagedPrivateEndpointVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ManagedPrivateEndpointVariant2))]
#endif
        public bool IsManagedPrivateEndpointVariant2 => ManagedPrivateEndpointVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickManagedPrivateEndpointVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ManagedPrivateEndpointVariant2? value)
        {
            value = ManagedPrivateEndpointVariant2;
            return IsManagedPrivateEndpointVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ManagedPrivateEndpointVariant2 PickManagedPrivateEndpointVariant2() => ManagedPrivateEndpointVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ManagedPrivateEndpointVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ManagedPrivateEndpoint(global::OpenRouter.PrivateEndpointSummary value) => new ManagedPrivateEndpoint((global::OpenRouter.PrivateEndpointSummary?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.PrivateEndpointSummary?(ManagedPrivateEndpoint @this) => @this.Summary;

        /// <summary>
        ///
        /// </summary>
        public ManagedPrivateEndpoint(global::OpenRouter.PrivateEndpointSummary? value)
        {
            Summary = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ManagedPrivateEndpoint FromSummary(global::OpenRouter.PrivateEndpointSummary? value) => new ManagedPrivateEndpoint(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ManagedPrivateEndpoint(global::OpenRouter.ManagedPrivateEndpointVariant2 value) => new ManagedPrivateEndpoint((global::OpenRouter.ManagedPrivateEndpointVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ManagedPrivateEndpointVariant2?(ManagedPrivateEndpoint @this) => @this.ManagedPrivateEndpointVariant2;

        /// <summary>
        ///
        /// </summary>
        public ManagedPrivateEndpoint(global::OpenRouter.ManagedPrivateEndpointVariant2? value)
        {
            ManagedPrivateEndpointVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ManagedPrivateEndpoint FromManagedPrivateEndpointVariant2(global::OpenRouter.ManagedPrivateEndpointVariant2? value) => new ManagedPrivateEndpoint(value);

        /// <summary>
        ///
        /// </summary>
        public ManagedPrivateEndpoint(
            global::OpenRouter.PrivateEndpointSummary? summary,
            global::OpenRouter.ManagedPrivateEndpointVariant2? managedPrivateEndpointVariant2
            )
        {
            Summary = summary;
            ManagedPrivateEndpointVariant2 = managedPrivateEndpointVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ManagedPrivateEndpointVariant2 as object ??
            Summary as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Summary?.ToString() ??
            ManagedPrivateEndpointVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSummary && IsManagedPrivateEndpointVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.PrivateEndpointSummary, TResult>? summary = null,
            global::System.Func<global::OpenRouter.ManagedPrivateEndpointVariant2, TResult>? managedPrivateEndpointVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Summary is { } __value0 && summary != null)
            {
                return summary(__value0);
            }
            else if (ManagedPrivateEndpointVariant2 is { } __value1 && managedPrivateEndpointVariant2 != null)
            {
                return managedPrivateEndpointVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.PrivateEndpointSummary>? summary = null,

            global::System.Action<global::OpenRouter.ManagedPrivateEndpointVariant2>? managedPrivateEndpointVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Summary is { } __value0)
            {
                summary?.Invoke(__value0);
            }
            else if (ManagedPrivateEndpointVariant2 is { } __value1)
            {
                managedPrivateEndpointVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.PrivateEndpointSummary>? summary = null,
            global::System.Action<global::OpenRouter.ManagedPrivateEndpointVariant2>? managedPrivateEndpointVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Summary is { } __value0)
            {
                summary?.Invoke(__value0);
            }
            else if (ManagedPrivateEndpointVariant2 is { } __value1)
            {
                managedPrivateEndpointVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Summary,
                typeof(global::OpenRouter.PrivateEndpointSummary),
                ManagedPrivateEndpointVariant2,
                typeof(global::OpenRouter.ManagedPrivateEndpointVariant2),
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
        public bool Equals(ManagedPrivateEndpoint other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.PrivateEndpointSummary?>.Default.Equals(Summary, other.Summary) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ManagedPrivateEndpointVariant2?>.Default.Equals(ManagedPrivateEndpointVariant2, other.ManagedPrivateEndpointVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ManagedPrivateEndpoint obj1, ManagedPrivateEndpoint obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ManagedPrivateEndpoint>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ManagedPrivateEndpoint obj1, ManagedPrivateEndpoint obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ManagedPrivateEndpoint o && Equals(o);
        }
    }
}
