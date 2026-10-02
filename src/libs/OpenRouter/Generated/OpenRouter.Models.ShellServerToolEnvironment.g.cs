#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Server-side execution environment for the shell tool. Only container-backed environments are supported; "local" shells are not.<br/>
    /// Example: {"type":"container_auto"}
    /// </summary>
    public readonly partial struct ShellServerToolEnvironment : global::System.IEquatable<ShellServerToolEnvironment>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironmentDiscriminatorType? Type { get; }

        /// <summary>
        /// An OpenRouter-managed, auto-provisioned ephemeral container.<br/>
        /// Example: {"type":"container_auto"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContainerAutoEnvironment? ContainerAuto { get; init; }
#else
        public global::OpenRouter.ContainerAutoEnvironment? ContainerAuto { get; }
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
            out global::OpenRouter.ContainerAutoEnvironment? value)
        {
            value = ContainerAuto;
            return IsContainerAuto;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerAutoEnvironment PickContainerAuto() => ContainerAuto is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContainerAuto' but the value was {ToString()}.");

        /// <summary>
        /// Reference to a container by its canonical id — a previously returned container_id or a fresh name to create a persistent container.<br/>
        /// Example: {"container_id":"sess_abc123","type":"container_reference"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContainerReferenceEnvironment? ContainerReference { get; init; }
#else
        public global::OpenRouter.ContainerReferenceEnvironment? ContainerReference { get; }
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
            out global::OpenRouter.ContainerReferenceEnvironment? value)
        {
            value = ContainerReference;
            return IsContainerReference;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerReferenceEnvironment PickContainerReference() => ContainerReference is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContainerReference' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ShellServerToolEnvironment(global::OpenRouter.ContainerAutoEnvironment value) => new ShellServerToolEnvironment((global::OpenRouter.ContainerAutoEnvironment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ContainerAutoEnvironment?(ShellServerToolEnvironment @this) => @this.ContainerAuto;

        /// <summary>
        ///
        /// </summary>
        public ShellServerToolEnvironment(global::OpenRouter.ContainerAutoEnvironment? value)
        {
            ContainerAuto = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ShellServerToolEnvironment FromContainerAuto(global::OpenRouter.ContainerAutoEnvironment? value) => new ShellServerToolEnvironment(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ShellServerToolEnvironment(global::OpenRouter.ContainerReferenceEnvironment value) => new ShellServerToolEnvironment((global::OpenRouter.ContainerReferenceEnvironment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ContainerReferenceEnvironment?(ShellServerToolEnvironment @this) => @this.ContainerReference;

        /// <summary>
        ///
        /// </summary>
        public ShellServerToolEnvironment(global::OpenRouter.ContainerReferenceEnvironment? value)
        {
            ContainerReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ShellServerToolEnvironment FromContainerReference(global::OpenRouter.ContainerReferenceEnvironment? value) => new ShellServerToolEnvironment(value);

        /// <summary>
        ///
        /// </summary>
        public ShellServerToolEnvironment(
            global::OpenRouter.ShellServerToolEnvironmentDiscriminatorType? type,
            global::OpenRouter.ContainerAutoEnvironment? containerAuto,
            global::OpenRouter.ContainerReferenceEnvironment? containerReference
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
            global::System.Func<global::OpenRouter.ContainerAutoEnvironment, TResult>? containerAuto = null,
            global::System.Func<global::OpenRouter.ContainerReferenceEnvironment, TResult>? containerReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ContainerAuto is { } __value0 && containerAuto != null)
            {
                return containerAuto(__value0);
            }
            else if (ContainerReference is { } __value1 && containerReference != null)
            {
                return containerReference(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ContainerAutoEnvironment>? containerAuto = null,

            global::System.Action<global::OpenRouter.ContainerReferenceEnvironment>? containerReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ContainerAuto is { } __value0)
            {
                containerAuto?.Invoke(__value0);
            }
            else if (ContainerReference is { } __value1)
            {
                containerReference?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ContainerAutoEnvironment>? containerAuto = null,
            global::System.Action<global::OpenRouter.ContainerReferenceEnvironment>? containerReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ContainerAuto is { } __value0)
            {
                containerAuto?.Invoke(__value0);
            }
            else if (ContainerReference is { } __value1)
            {
                containerReference?.Invoke(__value1);
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
                typeof(global::OpenRouter.ContainerAutoEnvironment),
                ContainerReference,
                typeof(global::OpenRouter.ContainerReferenceEnvironment),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContainerAutoEnvironment?>.Default.Equals(ContainerAuto, other.ContainerAuto) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContainerReferenceEnvironment?>.Default.Equals(ContainerReference, other.ContainerReference)
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
