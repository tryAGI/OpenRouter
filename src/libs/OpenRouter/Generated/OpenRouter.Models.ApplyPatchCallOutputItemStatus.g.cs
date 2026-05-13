#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ApplyPatchCallOutputItemStatus : global::System.IEquatable<ApplyPatchCallOutputItemStatus>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchCallOutputItemStatus0? ApplyPatchCallOutputItemStatus0 { get; init; }
#else
        public global::OpenRouter.ApplyPatchCallOutputItemStatus0? ApplyPatchCallOutputItemStatus0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCallOutputItemStatus0))]
#endif
        public bool IsApplyPatchCallOutputItemStatus0 => ApplyPatchCallOutputItemStatus0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApplyPatchCallOutputItemStatus0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchCallOutputItemStatus0? value)
        {
            value = ApplyPatchCallOutputItemStatus0;
            return IsApplyPatchCallOutputItemStatus0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOutputItemStatus0 PickApplyPatchCallOutputItemStatus0() => IsApplyPatchCallOutputItemStatus0
            ? ApplyPatchCallOutputItemStatus0!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCallOutputItemStatus0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchCallOutputItemStatus1? ApplyPatchCallOutputItemStatus1 { get; init; }
#else
        public global::OpenRouter.ApplyPatchCallOutputItemStatus1? ApplyPatchCallOutputItemStatus1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCallOutputItemStatus1))]
#endif
        public bool IsApplyPatchCallOutputItemStatus1 => ApplyPatchCallOutputItemStatus1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApplyPatchCallOutputItemStatus1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchCallOutputItemStatus1? value)
        {
            value = ApplyPatchCallOutputItemStatus1;
            return IsApplyPatchCallOutputItemStatus1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOutputItemStatus1 PickApplyPatchCallOutputItemStatus1() => IsApplyPatchCallOutputItemStatus1
            ? ApplyPatchCallOutputItemStatus1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCallOutputItemStatus1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplyPatchCallOutputItemStatus(global::OpenRouter.ApplyPatchCallOutputItemStatus0 value) => new ApplyPatchCallOutputItemStatus((global::OpenRouter.ApplyPatchCallOutputItemStatus0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchCallOutputItemStatus0?(ApplyPatchCallOutputItemStatus @this) => @this.ApplyPatchCallOutputItemStatus0;

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchCallOutputItemStatus(global::OpenRouter.ApplyPatchCallOutputItemStatus0? value)
        {
            ApplyPatchCallOutputItemStatus0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ApplyPatchCallOutputItemStatus FromApplyPatchCallOutputItemStatus0(global::OpenRouter.ApplyPatchCallOutputItemStatus0? value) => new ApplyPatchCallOutputItemStatus(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplyPatchCallOutputItemStatus(global::OpenRouter.ApplyPatchCallOutputItemStatus1 value) => new ApplyPatchCallOutputItemStatus((global::OpenRouter.ApplyPatchCallOutputItemStatus1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchCallOutputItemStatus1?(ApplyPatchCallOutputItemStatus @this) => @this.ApplyPatchCallOutputItemStatus1;

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchCallOutputItemStatus(global::OpenRouter.ApplyPatchCallOutputItemStatus1? value)
        {
            ApplyPatchCallOutputItemStatus1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ApplyPatchCallOutputItemStatus FromApplyPatchCallOutputItemStatus1(global::OpenRouter.ApplyPatchCallOutputItemStatus1? value) => new ApplyPatchCallOutputItemStatus(value);

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchCallOutputItemStatus(
            global::OpenRouter.ApplyPatchCallOutputItemStatus0? applyPatchCallOutputItemStatus0,
            global::OpenRouter.ApplyPatchCallOutputItemStatus1? applyPatchCallOutputItemStatus1
            )
        {
            ApplyPatchCallOutputItemStatus0 = applyPatchCallOutputItemStatus0;
            ApplyPatchCallOutputItemStatus1 = applyPatchCallOutputItemStatus1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ApplyPatchCallOutputItemStatus1 as object ??
            ApplyPatchCallOutputItemStatus0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ApplyPatchCallOutputItemStatus0?.ToValueString() ??
            ApplyPatchCallOutputItemStatus1?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApplyPatchCallOutputItemStatus0 && !IsApplyPatchCallOutputItemStatus1 || !IsApplyPatchCallOutputItemStatus0 && IsApplyPatchCallOutputItemStatus1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ApplyPatchCallOutputItemStatus0?, TResult>? applyPatchCallOutputItemStatus0 = null,
            global::System.Func<global::OpenRouter.ApplyPatchCallOutputItemStatus1?, TResult>? applyPatchCallOutputItemStatus1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApplyPatchCallOutputItemStatus0 && applyPatchCallOutputItemStatus0 != null)
            {
                return applyPatchCallOutputItemStatus0(ApplyPatchCallOutputItemStatus0!);
            }
            else if (IsApplyPatchCallOutputItemStatus1 && applyPatchCallOutputItemStatus1 != null)
            {
                return applyPatchCallOutputItemStatus1(ApplyPatchCallOutputItemStatus1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ApplyPatchCallOutputItemStatus0?>? applyPatchCallOutputItemStatus0 = null,

            global::System.Action<global::OpenRouter.ApplyPatchCallOutputItemStatus1?>? applyPatchCallOutputItemStatus1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApplyPatchCallOutputItemStatus0)
            {
                applyPatchCallOutputItemStatus0?.Invoke(ApplyPatchCallOutputItemStatus0!);
            }
            else if (IsApplyPatchCallOutputItemStatus1)
            {
                applyPatchCallOutputItemStatus1?.Invoke(ApplyPatchCallOutputItemStatus1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ApplyPatchCallOutputItemStatus0?>? applyPatchCallOutputItemStatus0 = null,
            global::System.Action<global::OpenRouter.ApplyPatchCallOutputItemStatus1?>? applyPatchCallOutputItemStatus1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApplyPatchCallOutputItemStatus0)
            {
                applyPatchCallOutputItemStatus0?.Invoke(ApplyPatchCallOutputItemStatus0!);
            }
            else if (IsApplyPatchCallOutputItemStatus1)
            {
                applyPatchCallOutputItemStatus1?.Invoke(ApplyPatchCallOutputItemStatus1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ApplyPatchCallOutputItemStatus0,
                typeof(global::OpenRouter.ApplyPatchCallOutputItemStatus0),
                ApplyPatchCallOutputItemStatus1,
                typeof(global::OpenRouter.ApplyPatchCallOutputItemStatus1),
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
        public bool Equals(ApplyPatchCallOutputItemStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCallOutputItemStatus0?>.Default.Equals(ApplyPatchCallOutputItemStatus0, other.ApplyPatchCallOutputItemStatus0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCallOutputItemStatus1?>.Default.Equals(ApplyPatchCallOutputItemStatus1, other.ApplyPatchCallOutputItemStatus1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ApplyPatchCallOutputItemStatus obj1, ApplyPatchCallOutputItemStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ApplyPatchCallOutputItemStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ApplyPatchCallOutputItemStatus obj1, ApplyPatchCallOutputItemStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ApplyPatchCallOutputItemStatus o && Equals(o);
        }
    }
}
