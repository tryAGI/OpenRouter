#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Network egress policy for the container. "disabled" blocks all outbound internet; "allowlist" permits only hosts matching the listed hostnames or * glob patterns (ports 80/443, DNS via Cloudflare resolvers). The policy is fixed when a container starts: sending a different policy to a warm container fails the request with a 409. Omitted: defaults to "disabled" (no outbound internet). For unrestricted egress, use an allowlist of ["*"].<br/>
    /// Example: {"allowed_domains":["pypi.org","files.pythonhosted.org"],"type":"allowlist"}
    /// </summary>
    public readonly partial struct ContainerNetworkPolicy : global::System.IEquatable<ContainerNetworkPolicy>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContainerNetworkPolicyVariant1? ContainerNetworkPolicyVariant1 { get; init; }
#else
        public global::OpenRouter.ContainerNetworkPolicyVariant1? ContainerNetworkPolicyVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContainerNetworkPolicyVariant1))]
#endif
        public bool IsContainerNetworkPolicyVariant1 => ContainerNetworkPolicyVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContainerNetworkPolicyVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ContainerNetworkPolicyVariant1? value)
        {
            value = ContainerNetworkPolicyVariant1;
            return IsContainerNetworkPolicyVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerNetworkPolicyVariant1 PickContainerNetworkPolicyVariant1() => ContainerNetworkPolicyVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContainerNetworkPolicyVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContainerNetworkPolicyVariant2? ContainerNetworkPolicyVariant2 { get; init; }
#else
        public global::OpenRouter.ContainerNetworkPolicyVariant2? ContainerNetworkPolicyVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContainerNetworkPolicyVariant2))]
#endif
        public bool IsContainerNetworkPolicyVariant2 => ContainerNetworkPolicyVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContainerNetworkPolicyVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ContainerNetworkPolicyVariant2? value)
        {
            value = ContainerNetworkPolicyVariant2;
            return IsContainerNetworkPolicyVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerNetworkPolicyVariant2 PickContainerNetworkPolicyVariant2() => ContainerNetworkPolicyVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContainerNetworkPolicyVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContainerNetworkPolicy(global::OpenRouter.ContainerNetworkPolicyVariant1 value) => new ContainerNetworkPolicy((global::OpenRouter.ContainerNetworkPolicyVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ContainerNetworkPolicyVariant1?(ContainerNetworkPolicy @this) => @this.ContainerNetworkPolicyVariant1;

        /// <summary>
        ///
        /// </summary>
        public ContainerNetworkPolicy(global::OpenRouter.ContainerNetworkPolicyVariant1? value)
        {
            ContainerNetworkPolicyVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContainerNetworkPolicy FromContainerNetworkPolicyVariant1(global::OpenRouter.ContainerNetworkPolicyVariant1? value) => new ContainerNetworkPolicy(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContainerNetworkPolicy(global::OpenRouter.ContainerNetworkPolicyVariant2 value) => new ContainerNetworkPolicy((global::OpenRouter.ContainerNetworkPolicyVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ContainerNetworkPolicyVariant2?(ContainerNetworkPolicy @this) => @this.ContainerNetworkPolicyVariant2;

        /// <summary>
        ///
        /// </summary>
        public ContainerNetworkPolicy(global::OpenRouter.ContainerNetworkPolicyVariant2? value)
        {
            ContainerNetworkPolicyVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContainerNetworkPolicy FromContainerNetworkPolicyVariant2(global::OpenRouter.ContainerNetworkPolicyVariant2? value) => new ContainerNetworkPolicy(value);

        /// <summary>
        ///
        /// </summary>
        public ContainerNetworkPolicy(
            global::OpenRouter.ContainerNetworkPolicyVariant1? containerNetworkPolicyVariant1,
            global::OpenRouter.ContainerNetworkPolicyVariant2? containerNetworkPolicyVariant2
            )
        {
            ContainerNetworkPolicyVariant1 = containerNetworkPolicyVariant1;
            ContainerNetworkPolicyVariant2 = containerNetworkPolicyVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ContainerNetworkPolicyVariant2 as object ??
            ContainerNetworkPolicyVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ContainerNetworkPolicyVariant1?.ToString() ??
            ContainerNetworkPolicyVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsContainerNetworkPolicyVariant1 || IsContainerNetworkPolicyVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ContainerNetworkPolicyVariant1, TResult>? containerNetworkPolicyVariant1 = null,
            global::System.Func<global::OpenRouter.ContainerNetworkPolicyVariant2, TResult>? containerNetworkPolicyVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ContainerNetworkPolicyVariant1 is { } __value0 && containerNetworkPolicyVariant1 != null)
            {
                return containerNetworkPolicyVariant1(__value0);
            }
            else if (ContainerNetworkPolicyVariant2 is { } __value1 && containerNetworkPolicyVariant2 != null)
            {
                return containerNetworkPolicyVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ContainerNetworkPolicyVariant1>? containerNetworkPolicyVariant1 = null,

            global::System.Action<global::OpenRouter.ContainerNetworkPolicyVariant2>? containerNetworkPolicyVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ContainerNetworkPolicyVariant1 is { } __value0)
            {
                containerNetworkPolicyVariant1?.Invoke(__value0);
            }
            else if (ContainerNetworkPolicyVariant2 is { } __value1)
            {
                containerNetworkPolicyVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ContainerNetworkPolicyVariant1>? containerNetworkPolicyVariant1 = null,
            global::System.Action<global::OpenRouter.ContainerNetworkPolicyVariant2>? containerNetworkPolicyVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ContainerNetworkPolicyVariant1 is { } __value0)
            {
                containerNetworkPolicyVariant1?.Invoke(__value0);
            }
            else if (ContainerNetworkPolicyVariant2 is { } __value1)
            {
                containerNetworkPolicyVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ContainerNetworkPolicyVariant1,
                typeof(global::OpenRouter.ContainerNetworkPolicyVariant1),
                ContainerNetworkPolicyVariant2,
                typeof(global::OpenRouter.ContainerNetworkPolicyVariant2),
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
        public bool Equals(ContainerNetworkPolicy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContainerNetworkPolicyVariant1?>.Default.Equals(ContainerNetworkPolicyVariant1, other.ContainerNetworkPolicyVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContainerNetworkPolicyVariant2?>.Default.Equals(ContainerNetworkPolicyVariant2, other.ContainerNetworkPolicyVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContainerNetworkPolicy obj1, ContainerNetworkPolicy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContainerNetworkPolicy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContainerNetworkPolicy obj1, ContainerNetworkPolicy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContainerNetworkPolicy o && Equals(o);
        }
    }
}
