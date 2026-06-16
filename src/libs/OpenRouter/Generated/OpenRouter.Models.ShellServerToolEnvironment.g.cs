#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Server-side execution environment for the shell tool. Only container-backed environments are supported; "local" shells are not.
    /// </summary>
    public readonly partial struct ShellServerToolEnvironment : global::System.IEquatable<ShellServerToolEnvironment>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironmentDiscriminatorType? Type { get; }

        /// <summary>
        /// An OpenRouter-managed, auto-provisioned ephemeral container.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ShellServerToolEnvironmentVariant1? ContainerAuto { get; init; }
#else
        public global::OpenRouter.ShellServerToolEnvironmentVariant1? ContainerAuto { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContainerAuto))]
#endif
        public bool IsContainerAuto => ContainerAuto != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickContainerAuto(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ShellServerToolEnvironmentVariant1? value)
        {
            value = ContainerAuto;
            return IsContainerAuto;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironmentVariant1 PickContainerAuto() => IsContainerAuto
            ? ContainerAuto!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContainerAuto' but the value was {ToString()}.");

        /// <summary>
        /// Reference to a previously created container to reuse.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ShellServerToolEnvironmentVariant2? ContainerReference { get; init; }
#else
        public global::OpenRouter.ShellServerToolEnvironmentVariant2? ContainerReference { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContainerReference))]
#endif
        public bool IsContainerReference => ContainerReference != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickContainerReference(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ShellServerToolEnvironmentVariant2? value)
        {
            value = ContainerReference;
            return IsContainerReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironmentVariant2 PickContainerReference() => IsContainerReference
            ? ContainerReference!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContainerReference' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ShellServerToolEnvironment(global::OpenRouter.ShellServerToolEnvironmentVariant1 value) => new ShellServerToolEnvironment((global::OpenRouter.ShellServerToolEnvironmentVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ShellServerToolEnvironmentVariant1?(ShellServerToolEnvironment @this) => @this.ContainerAuto;

        /// <summary>
        /// 
        /// </summary>
        public ShellServerToolEnvironment(global::OpenRouter.ShellServerToolEnvironmentVariant1? value)
        {
            ContainerAuto = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ShellServerToolEnvironment FromContainerAuto(global::OpenRouter.ShellServerToolEnvironmentVariant1? value) => new ShellServerToolEnvironment(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ShellServerToolEnvironment(global::OpenRouter.ShellServerToolEnvironmentVariant2 value) => new ShellServerToolEnvironment((global::OpenRouter.ShellServerToolEnvironmentVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ShellServerToolEnvironmentVariant2?(ShellServerToolEnvironment @this) => @this.ContainerReference;

        /// <summary>
        /// 
        /// </summary>
        public ShellServerToolEnvironment(global::OpenRouter.ShellServerToolEnvironmentVariant2? value)
        {
            ContainerReference = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ShellServerToolEnvironment FromContainerReference(global::OpenRouter.ShellServerToolEnvironmentVariant2? value) => new ShellServerToolEnvironment(value);

        /// <summary>
        /// 
        /// </summary>
        public ShellServerToolEnvironment(
            global::OpenRouter.ShellServerToolEnvironmentDiscriminatorType? type,
            global::OpenRouter.ShellServerToolEnvironmentVariant1? containerAuto,
            global::OpenRouter.ShellServerToolEnvironmentVariant2? containerReference
            )
        {
            Type = type;

            ContainerAuto = containerAuto;
            ContainerReference = containerReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ContainerReference as object ??
            ContainerAuto as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ContainerAuto?.ToString() ??
            ContainerReference?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsContainerAuto && !IsContainerReference || !IsContainerAuto && IsContainerReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ShellServerToolEnvironmentVariant1, TResult>? containerAuto = null,
            global::System.Func<global::OpenRouter.ShellServerToolEnvironmentVariant2, TResult>? containerReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsContainerAuto && containerAuto != null)
            {
                return containerAuto(ContainerAuto!);
            }
            else if (IsContainerReference && containerReference != null)
            {
                return containerReference(ContainerReference!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ShellServerToolEnvironmentVariant1>? containerAuto = null,

            global::System.Action<global::OpenRouter.ShellServerToolEnvironmentVariant2>? containerReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsContainerAuto)
            {
                containerAuto?.Invoke(ContainerAuto!);
            }
            else if (IsContainerReference)
            {
                containerReference?.Invoke(ContainerReference!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ShellServerToolEnvironmentVariant1>? containerAuto = null,
            global::System.Action<global::OpenRouter.ShellServerToolEnvironmentVariant2>? containerReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsContainerAuto)
            {
                containerAuto?.Invoke(ContainerAuto!);
            }
            else if (IsContainerReference)
            {
                containerReference?.Invoke(ContainerReference!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ContainerAuto,
                typeof(global::OpenRouter.ShellServerToolEnvironmentVariant1),
                ContainerReference,
                typeof(global::OpenRouter.ShellServerToolEnvironmentVariant2),
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
        public bool Equals(ShellServerToolEnvironment other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ShellServerToolEnvironmentVariant1?>.Default.Equals(ContainerAuto, other.ContainerAuto) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ShellServerToolEnvironmentVariant2?>.Default.Equals(ContainerReference, other.ContainerReference) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ShellServerToolEnvironment obj1, ShellServerToolEnvironment obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ShellServerToolEnvironment>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ShellServerToolEnvironment obj1, ShellServerToolEnvironment obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ShellServerToolEnvironment o && Equals(o);
        }
    }
}
