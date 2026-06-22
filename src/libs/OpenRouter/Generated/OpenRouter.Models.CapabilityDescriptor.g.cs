#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A typed descriptor for one supported request parameter.
    /// </summary>
    public readonly partial struct CapabilityDescriptor : global::System.IEquatable<CapabilityDescriptor>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CapabilityDescriptorDiscriminatorType? Type { get; }

        /// <summary>
        /// A supported-or-not flag. Present means the parameter is accepted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CapabilityDescriptorVariant1? Boolean { get; init; }
#else
        public global::OpenRouter.CapabilityDescriptorVariant1? Boolean { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Boolean))]
#endif
        public bool IsBoolean => Boolean != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBoolean(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CapabilityDescriptorVariant1? value)
        {
            value = Boolean;
            return IsBoolean;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CapabilityDescriptorVariant1 PickBoolean() => IsBoolean
            ? Boolean!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Boolean' but the value was {ToString()}.");

        /// <summary>
        /// A parameter that accepts one of a discrete set of string values.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CapabilityDescriptorVariant2? Enum { get; init; }
#else
        public global::OpenRouter.CapabilityDescriptorVariant2? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnum(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CapabilityDescriptorVariant2? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CapabilityDescriptorVariant2 PickEnum() => IsEnum
            ? Enum!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum' but the value was {ToString()}.");

        /// <summary>
        /// A parameter that accepts any value within an inclusive numeric range.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CapabilityDescriptorVariant3? Range { get; init; }
#else
        public global::OpenRouter.CapabilityDescriptorVariant3? Range { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Range))]
#endif
        public bool IsRange => Range != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRange(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CapabilityDescriptorVariant3? value)
        {
            value = Range;
            return IsRange;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CapabilityDescriptorVariant3 PickRange() => IsRange
            ? Range!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Range' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CapabilityDescriptor(global::OpenRouter.CapabilityDescriptorVariant1 value) => new CapabilityDescriptor((global::OpenRouter.CapabilityDescriptorVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CapabilityDescriptorVariant1?(CapabilityDescriptor @this) => @this.Boolean;

        /// <summary>
        /// 
        /// </summary>
        public CapabilityDescriptor(global::OpenRouter.CapabilityDescriptorVariant1? value)
        {
            Boolean = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CapabilityDescriptor FromBoolean(global::OpenRouter.CapabilityDescriptorVariant1? value) => new CapabilityDescriptor(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CapabilityDescriptor(global::OpenRouter.CapabilityDescriptorVariant2 value) => new CapabilityDescriptor((global::OpenRouter.CapabilityDescriptorVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CapabilityDescriptorVariant2?(CapabilityDescriptor @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public CapabilityDescriptor(global::OpenRouter.CapabilityDescriptorVariant2? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CapabilityDescriptor FromEnum(global::OpenRouter.CapabilityDescriptorVariant2? value) => new CapabilityDescriptor(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CapabilityDescriptor(global::OpenRouter.CapabilityDescriptorVariant3 value) => new CapabilityDescriptor((global::OpenRouter.CapabilityDescriptorVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CapabilityDescriptorVariant3?(CapabilityDescriptor @this) => @this.Range;

        /// <summary>
        /// 
        /// </summary>
        public CapabilityDescriptor(global::OpenRouter.CapabilityDescriptorVariant3? value)
        {
            Range = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CapabilityDescriptor FromRange(global::OpenRouter.CapabilityDescriptorVariant3? value) => new CapabilityDescriptor(value);

        /// <summary>
        /// 
        /// </summary>
        public CapabilityDescriptor(
            global::OpenRouter.CapabilityDescriptorDiscriminatorType? type,
            global::OpenRouter.CapabilityDescriptorVariant1? boolean,
            global::OpenRouter.CapabilityDescriptorVariant2? @enum,
            global::OpenRouter.CapabilityDescriptorVariant3? range
            )
        {
            Type = type;

            Boolean = boolean;
            Enum = @enum;
            Range = range;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Range as object ??
            Enum as object ??
            Boolean as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Boolean?.ToString() ??
            Enum?.ToString() ??
            Range?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBoolean && !IsEnum && !IsRange || !IsBoolean && IsEnum && !IsRange || !IsBoolean && !IsEnum && IsRange;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.CapabilityDescriptorVariant1, TResult>? boolean = null,
            global::System.Func<global::OpenRouter.CapabilityDescriptorVariant2, TResult>? @enum = null,
            global::System.Func<global::OpenRouter.CapabilityDescriptorVariant3, TResult>? range = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBoolean && boolean != null)
            {
                return boolean(Boolean!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }
            else if (IsRange && range != null)
            {
                return range(Range!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.CapabilityDescriptorVariant1>? boolean = null,

            global::System.Action<global::OpenRouter.CapabilityDescriptorVariant2>? @enum = null,

            global::System.Action<global::OpenRouter.CapabilityDescriptorVariant3>? range = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBoolean)
            {
                boolean?.Invoke(Boolean!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsRange)
            {
                range?.Invoke(Range!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.CapabilityDescriptorVariant1>? boolean = null,
            global::System.Action<global::OpenRouter.CapabilityDescriptorVariant2>? @enum = null,
            global::System.Action<global::OpenRouter.CapabilityDescriptorVariant3>? range = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBoolean)
            {
                boolean?.Invoke(Boolean!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsRange)
            {
                range?.Invoke(Range!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Boolean,
                typeof(global::OpenRouter.CapabilityDescriptorVariant1),
                Enum,
                typeof(global::OpenRouter.CapabilityDescriptorVariant2),
                Range,
                typeof(global::OpenRouter.CapabilityDescriptorVariant3),
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
        public bool Equals(CapabilityDescriptor other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CapabilityDescriptorVariant1?>.Default.Equals(Boolean, other.Boolean) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CapabilityDescriptorVariant2?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CapabilityDescriptorVariant3?>.Default.Equals(Range, other.Range) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CapabilityDescriptor obj1, CapabilityDescriptor obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CapabilityDescriptor>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CapabilityDescriptor obj1, CapabilityDescriptor obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CapabilityDescriptor o && Equals(o);
        }
    }
}
