#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A typed descriptor for one supported request parameter.<br/>
    /// Example: {"type":"enum","values":["1K","2K","4K"]}
    /// </summary>
    public readonly partial struct CapabilityDescriptor : global::System.IEquatable<CapabilityDescriptor>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CapabilityDescriptorDiscriminatorType? Type { get; }

        /// <summary>
        /// A parameter that accepts one of a discrete set of string values.<br/>
        /// Example: {"type":"enum","values":["1K","2K","4K"]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.EnumCapability? Enum { get; init; }
#else
        public global::OpenRouter.EnumCapability? Enum { get; }
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
            out global::OpenRouter.EnumCapability? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EnumCapability PickEnum() => Enum is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum' but the value was {ToString()}.");

        /// <summary>
        /// A parameter that accepts any value within an inclusive numeric range.<br/>
        /// Example: {"max":100,"min":0,"type":"range"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.RangeCapability? Range { get; init; }
#else
        public global::OpenRouter.RangeCapability? Range { get; }
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
            out global::OpenRouter.RangeCapability? value)
        {
            value = Range;
            return IsRange;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RangeCapability PickRange() => Range is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Range' but the value was {ToString()}.");

        /// <summary>
        /// A supported-or-not flag. Present means the parameter is accepted.<br/>
        /// Example: {"type":"boolean"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BooleanCapability? Boolean { get; init; }
#else
        public global::OpenRouter.BooleanCapability? Boolean { get; }
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
            out global::OpenRouter.BooleanCapability? value)
        {
            value = Boolean;
            return IsBoolean;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BooleanCapability PickBoolean() => Boolean is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Boolean' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CapabilityDescriptor(global::OpenRouter.EnumCapability value) => new CapabilityDescriptor((global::OpenRouter.EnumCapability?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.EnumCapability?(CapabilityDescriptor @this) => @this.Enum;

        /// <summary>
        ///
        /// </summary>
        public CapabilityDescriptor(global::OpenRouter.EnumCapability? value)
        {
            Enum = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CapabilityDescriptor FromEnum(global::OpenRouter.EnumCapability? value) => new CapabilityDescriptor(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CapabilityDescriptor(global::OpenRouter.RangeCapability value) => new CapabilityDescriptor((global::OpenRouter.RangeCapability?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.RangeCapability?(CapabilityDescriptor @this) => @this.Range;

        /// <summary>
        ///
        /// </summary>
        public CapabilityDescriptor(global::OpenRouter.RangeCapability? value)
        {
            Range = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CapabilityDescriptor FromRange(global::OpenRouter.RangeCapability? value) => new CapabilityDescriptor(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CapabilityDescriptor(global::OpenRouter.BooleanCapability value) => new CapabilityDescriptor((global::OpenRouter.BooleanCapability?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BooleanCapability?(CapabilityDescriptor @this) => @this.Boolean;

        /// <summary>
        ///
        /// </summary>
        public CapabilityDescriptor(global::OpenRouter.BooleanCapability? value)
        {
            Boolean = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CapabilityDescriptor FromBoolean(global::OpenRouter.BooleanCapability? value) => new CapabilityDescriptor(value);

        /// <summary>
        ///
        /// </summary>
        public CapabilityDescriptor(
            global::OpenRouter.CapabilityDescriptorDiscriminatorType? type,
            global::OpenRouter.EnumCapability? @enum,
            global::OpenRouter.RangeCapability? range,
            global::OpenRouter.BooleanCapability? boolean
            )
        {
            Type = type;

            Enum = @enum;
            Range = range;
            Boolean = boolean;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Boolean as object ??
            Range as object ??
            Enum as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Enum?.ToString() ??
            Range?.ToString() ??
            Boolean?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEnum && !IsRange && !IsBoolean || !IsEnum && IsRange && !IsBoolean || !IsEnum && !IsRange && IsBoolean;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.EnumCapability, TResult>? @enum = null,
            global::System.Func<global::OpenRouter.RangeCapability, TResult>? range = null,
            global::System.Func<global::OpenRouter.BooleanCapability, TResult>? boolean = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Enum is { } __value0 && @enum != null)
            {
                return @enum(__value0);
            }
            else if (Range is { } __value1 && range != null)
            {
                return range(__value1);
            }
            else if (Boolean is { } __value2 && boolean != null)
            {
                return boolean(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.EnumCapability>? @enum = null,

            global::System.Action<global::OpenRouter.RangeCapability>? range = null,

            global::System.Action<global::OpenRouter.BooleanCapability>? boolean = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Enum is { } __value0)
            {
                @enum?.Invoke(__value0);
            }
            else if (Range is { } __value1)
            {
                range?.Invoke(__value1);
            }
            else if (Boolean is { } __value2)
            {
                boolean?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.EnumCapability>? @enum = null,
            global::System.Action<global::OpenRouter.RangeCapability>? range = null,
            global::System.Action<global::OpenRouter.BooleanCapability>? boolean = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Enum is { } __value0)
            {
                @enum?.Invoke(__value0);
            }
            else if (Range is { } __value1)
            {
                range?.Invoke(__value1);
            }
            else if (Boolean is { } __value2)
            {
                boolean?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Enum,
                typeof(global::OpenRouter.EnumCapability),
                Range,
                typeof(global::OpenRouter.RangeCapability),
                Boolean,
                typeof(global::OpenRouter.BooleanCapability),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.EnumCapability?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.RangeCapability?>.Default.Equals(Range, other.Range) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BooleanCapability?>.Default.Equals(Boolean, other.Boolean)
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
