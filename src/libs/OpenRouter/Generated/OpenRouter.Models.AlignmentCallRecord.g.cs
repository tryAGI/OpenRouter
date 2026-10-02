#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AlignmentCallRecord : global::System.IEquatable<AlignmentCallRecord>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentCallRecordDiscriminatorOutcome? Outcome { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AlignmentAllowedCallRecord? Allowed { get; init; }
#else
        public global::OpenRouter.AlignmentAllowedCallRecord? Allowed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Allowed))]
#endif
        public bool IsAllowed => Allowed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAllowed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AlignmentAllowedCallRecord? value)
        {
            value = Allowed;
            return IsAllowed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentAllowedCallRecord PickAllowed() => Allowed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Allowed' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AlignmentBlockedCallRecord? Blocked { get; init; }
#else
        public global::OpenRouter.AlignmentBlockedCallRecord? Blocked { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Blocked))]
#endif
        public bool IsBlocked => Blocked != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBlocked(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AlignmentBlockedCallRecord? value)
        {
            value = Blocked;
            return IsBlocked;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentBlockedCallRecord PickBlocked() => Blocked is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Blocked' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AlignmentUnavailableCallRecord? Unavailable { get; init; }
#else
        public global::OpenRouter.AlignmentUnavailableCallRecord? Unavailable { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unavailable))]
#endif
        public bool IsUnavailable => Unavailable != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnavailable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AlignmentUnavailableCallRecord? value)
        {
            value = Unavailable;
            return IsUnavailable;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentUnavailableCallRecord PickUnavailable() => Unavailable is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Unavailable' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AlignmentCallRecord(global::OpenRouter.AlignmentAllowedCallRecord value) => new AlignmentCallRecord((global::OpenRouter.AlignmentAllowedCallRecord?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AlignmentAllowedCallRecord?(AlignmentCallRecord @this) => @this.Allowed;

        /// <summary>
        ///
        /// </summary>
        public AlignmentCallRecord(global::OpenRouter.AlignmentAllowedCallRecord? value)
        {
            Allowed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AlignmentCallRecord FromAllowed(global::OpenRouter.AlignmentAllowedCallRecord? value) => new AlignmentCallRecord(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AlignmentCallRecord(global::OpenRouter.AlignmentBlockedCallRecord value) => new AlignmentCallRecord((global::OpenRouter.AlignmentBlockedCallRecord?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AlignmentBlockedCallRecord?(AlignmentCallRecord @this) => @this.Blocked;

        /// <summary>
        ///
        /// </summary>
        public AlignmentCallRecord(global::OpenRouter.AlignmentBlockedCallRecord? value)
        {
            Blocked = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AlignmentCallRecord FromBlocked(global::OpenRouter.AlignmentBlockedCallRecord? value) => new AlignmentCallRecord(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AlignmentCallRecord(global::OpenRouter.AlignmentUnavailableCallRecord value) => new AlignmentCallRecord((global::OpenRouter.AlignmentUnavailableCallRecord?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AlignmentUnavailableCallRecord?(AlignmentCallRecord @this) => @this.Unavailable;

        /// <summary>
        ///
        /// </summary>
        public AlignmentCallRecord(global::OpenRouter.AlignmentUnavailableCallRecord? value)
        {
            Unavailable = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AlignmentCallRecord FromUnavailable(global::OpenRouter.AlignmentUnavailableCallRecord? value) => new AlignmentCallRecord(value);

        /// <summary>
        ///
        /// </summary>
        public AlignmentCallRecord(
            global::OpenRouter.AlignmentCallRecordDiscriminatorOutcome? outcome,
            global::OpenRouter.AlignmentAllowedCallRecord? allowed,
            global::OpenRouter.AlignmentBlockedCallRecord? blocked,
            global::OpenRouter.AlignmentUnavailableCallRecord? unavailable
            )
        {
            Outcome = outcome;

            Allowed = allowed;
            Blocked = blocked;
            Unavailable = unavailable;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Unavailable as object ??
            Blocked as object ??
            Allowed as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Allowed?.ToString() ??
            Blocked?.ToString() ??
            Unavailable?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAllowed && !IsBlocked && !IsUnavailable || !IsAllowed && IsBlocked && !IsUnavailable || !IsAllowed && !IsBlocked && IsUnavailable;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AlignmentAllowedCallRecord, TResult>? allowed = null,
            global::System.Func<global::OpenRouter.AlignmentBlockedCallRecord, TResult>? blocked = null,
            global::System.Func<global::OpenRouter.AlignmentUnavailableCallRecord, TResult>? unavailable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Allowed is { } __value0 && allowed != null)
            {
                return allowed(__value0);
            }
            else if (Blocked is { } __value1 && blocked != null)
            {
                return blocked(__value1);
            }
            else if (Unavailable is { } __value2 && unavailable != null)
            {
                return unavailable(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AlignmentAllowedCallRecord>? allowed = null,

            global::System.Action<global::OpenRouter.AlignmentBlockedCallRecord>? blocked = null,

            global::System.Action<global::OpenRouter.AlignmentUnavailableCallRecord>? unavailable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Allowed is { } __value0)
            {
                allowed?.Invoke(__value0);
            }
            else if (Blocked is { } __value1)
            {
                blocked?.Invoke(__value1);
            }
            else if (Unavailable is { } __value2)
            {
                unavailable?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AlignmentAllowedCallRecord>? allowed = null,
            global::System.Action<global::OpenRouter.AlignmentBlockedCallRecord>? blocked = null,
            global::System.Action<global::OpenRouter.AlignmentUnavailableCallRecord>? unavailable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Allowed is { } __value0)
            {
                allowed?.Invoke(__value0);
            }
            else if (Blocked is { } __value1)
            {
                blocked?.Invoke(__value1);
            }
            else if (Unavailable is { } __value2)
            {
                unavailable?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Allowed,
                typeof(global::OpenRouter.AlignmentAllowedCallRecord),
                Blocked,
                typeof(global::OpenRouter.AlignmentBlockedCallRecord),
                Unavailable,
                typeof(global::OpenRouter.AlignmentUnavailableCallRecord),
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
        public bool Equals(AlignmentCallRecord other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AlignmentAllowedCallRecord?>.Default.Equals(Allowed, other.Allowed) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AlignmentBlockedCallRecord?>.Default.Equals(Blocked, other.Blocked) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AlignmentUnavailableCallRecord?>.Default.Equals(Unavailable, other.Unavailable)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AlignmentCallRecord obj1, AlignmentCallRecord obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AlignmentCallRecord>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AlignmentCallRecord obj1, AlignmentCallRecord obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AlignmentCallRecord o && Equals(o);
        }
    }
}
