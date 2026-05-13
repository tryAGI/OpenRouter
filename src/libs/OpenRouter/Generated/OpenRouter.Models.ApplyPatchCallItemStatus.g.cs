#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ApplyPatchCallItemStatus : global::System.IEquatable<ApplyPatchCallItemStatus>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchCallItemStatus0? ApplyPatchCallItemStatus0 { get; init; }
#else
        public global::OpenRouter.ApplyPatchCallItemStatus0? ApplyPatchCallItemStatus0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCallItemStatus0))]
#endif
        public bool IsApplyPatchCallItemStatus0 => ApplyPatchCallItemStatus0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApplyPatchCallItemStatus0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchCallItemStatus0? value)
        {
            value = ApplyPatchCallItemStatus0;
            return IsApplyPatchCallItemStatus0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ApplyPatchCallItemStatus0 PickApplyPatchCallItemStatus0() => IsApplyPatchCallItemStatus0
            ? ApplyPatchCallItemStatus0!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCallItemStatus0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchCallItemStatus1? ApplyPatchCallItemStatus1 { get; init; }
#else
        public global::OpenRouter.ApplyPatchCallItemStatus1? ApplyPatchCallItemStatus1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCallItemStatus1))]
#endif
        public bool IsApplyPatchCallItemStatus1 => ApplyPatchCallItemStatus1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApplyPatchCallItemStatus1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchCallItemStatus1? value)
        {
            value = ApplyPatchCallItemStatus1;
            return IsApplyPatchCallItemStatus1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ApplyPatchCallItemStatus1 PickApplyPatchCallItemStatus1() => IsApplyPatchCallItemStatus1
            ? ApplyPatchCallItemStatus1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCallItemStatus1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplyPatchCallItemStatus(global::OpenRouter.ApplyPatchCallItemStatus0 value) => new ApplyPatchCallItemStatus((global::OpenRouter.ApplyPatchCallItemStatus0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchCallItemStatus0?(ApplyPatchCallItemStatus @this) => @this.ApplyPatchCallItemStatus0;

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchCallItemStatus(global::OpenRouter.ApplyPatchCallItemStatus0? value)
        {
            ApplyPatchCallItemStatus0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ApplyPatchCallItemStatus FromApplyPatchCallItemStatus0(global::OpenRouter.ApplyPatchCallItemStatus0? value) => new ApplyPatchCallItemStatus(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplyPatchCallItemStatus(global::OpenRouter.ApplyPatchCallItemStatus1 value) => new ApplyPatchCallItemStatus((global::OpenRouter.ApplyPatchCallItemStatus1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchCallItemStatus1?(ApplyPatchCallItemStatus @this) => @this.ApplyPatchCallItemStatus1;

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchCallItemStatus(global::OpenRouter.ApplyPatchCallItemStatus1? value)
        {
            ApplyPatchCallItemStatus1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ApplyPatchCallItemStatus FromApplyPatchCallItemStatus1(global::OpenRouter.ApplyPatchCallItemStatus1? value) => new ApplyPatchCallItemStatus(value);

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchCallItemStatus(
            global::OpenRouter.ApplyPatchCallItemStatus0? applyPatchCallItemStatus0,
            global::OpenRouter.ApplyPatchCallItemStatus1? applyPatchCallItemStatus1
            )
        {
            ApplyPatchCallItemStatus0 = applyPatchCallItemStatus0;
            ApplyPatchCallItemStatus1 = applyPatchCallItemStatus1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ApplyPatchCallItemStatus1 as object ??
            ApplyPatchCallItemStatus0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ApplyPatchCallItemStatus0?.ToValueString() ??
            ApplyPatchCallItemStatus1?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApplyPatchCallItemStatus0 && !IsApplyPatchCallItemStatus1 || !IsApplyPatchCallItemStatus0 && IsApplyPatchCallItemStatus1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ApplyPatchCallItemStatus0?, TResult>? applyPatchCallItemStatus0 = null,
            global::System.Func<global::OpenRouter.ApplyPatchCallItemStatus1?, TResult>? applyPatchCallItemStatus1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApplyPatchCallItemStatus0 && applyPatchCallItemStatus0 != null)
            {
                return applyPatchCallItemStatus0(ApplyPatchCallItemStatus0!);
            }
            else if (IsApplyPatchCallItemStatus1 && applyPatchCallItemStatus1 != null)
            {
                return applyPatchCallItemStatus1(ApplyPatchCallItemStatus1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ApplyPatchCallItemStatus0?>? applyPatchCallItemStatus0 = null,

            global::System.Action<global::OpenRouter.ApplyPatchCallItemStatus1?>? applyPatchCallItemStatus1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApplyPatchCallItemStatus0)
            {
                applyPatchCallItemStatus0?.Invoke(ApplyPatchCallItemStatus0!);
            }
            else if (IsApplyPatchCallItemStatus1)
            {
                applyPatchCallItemStatus1?.Invoke(ApplyPatchCallItemStatus1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ApplyPatchCallItemStatus0?>? applyPatchCallItemStatus0 = null,
            global::System.Action<global::OpenRouter.ApplyPatchCallItemStatus1?>? applyPatchCallItemStatus1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApplyPatchCallItemStatus0)
            {
                applyPatchCallItemStatus0?.Invoke(ApplyPatchCallItemStatus0!);
            }
            else if (IsApplyPatchCallItemStatus1)
            {
                applyPatchCallItemStatus1?.Invoke(ApplyPatchCallItemStatus1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ApplyPatchCallItemStatus0,
                typeof(global::OpenRouter.ApplyPatchCallItemStatus0),
                ApplyPatchCallItemStatus1,
                typeof(global::OpenRouter.ApplyPatchCallItemStatus1),
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
        public bool Equals(ApplyPatchCallItemStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCallItemStatus0?>.Default.Equals(ApplyPatchCallItemStatus0, other.ApplyPatchCallItemStatus0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCallItemStatus1?>.Default.Equals(ApplyPatchCallItemStatus1, other.ApplyPatchCallItemStatus1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ApplyPatchCallItemStatus obj1, ApplyPatchCallItemStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ApplyPatchCallItemStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ApplyPatchCallItemStatus obj1, ApplyPatchCallItemStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ApplyPatchCallItemStatus o && Equals(o);
        }
    }
}
