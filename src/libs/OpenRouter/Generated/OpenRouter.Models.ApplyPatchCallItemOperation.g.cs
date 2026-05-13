#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ApplyPatchCallItemOperation : global::System.IEquatable<ApplyPatchCallItemOperation>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchCallItemOperation0? ApplyPatchCallItemOperation0 { get; init; }
#else
        public global::OpenRouter.ApplyPatchCallItemOperation0? ApplyPatchCallItemOperation0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCallItemOperation0))]
#endif
        public bool IsApplyPatchCallItemOperation0 => ApplyPatchCallItemOperation0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApplyPatchCallItemOperation0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchCallItemOperation0? value)
        {
            value = ApplyPatchCallItemOperation0;
            return IsApplyPatchCallItemOperation0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ApplyPatchCallItemOperation0 PickApplyPatchCallItemOperation0() => IsApplyPatchCallItemOperation0
            ? ApplyPatchCallItemOperation0!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCallItemOperation0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchCallItemOperation1? ApplyPatchCallItemOperation1 { get; init; }
#else
        public global::OpenRouter.ApplyPatchCallItemOperation1? ApplyPatchCallItemOperation1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCallItemOperation1))]
#endif
        public bool IsApplyPatchCallItemOperation1 => ApplyPatchCallItemOperation1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApplyPatchCallItemOperation1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchCallItemOperation1? value)
        {
            value = ApplyPatchCallItemOperation1;
            return IsApplyPatchCallItemOperation1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ApplyPatchCallItemOperation1 PickApplyPatchCallItemOperation1() => IsApplyPatchCallItemOperation1
            ? ApplyPatchCallItemOperation1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCallItemOperation1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchCallItemOperation2? ApplyPatchCallItemOperation2 { get; init; }
#else
        public global::OpenRouter.ApplyPatchCallItemOperation2? ApplyPatchCallItemOperation2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCallItemOperation2))]
#endif
        public bool IsApplyPatchCallItemOperation2 => ApplyPatchCallItemOperation2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApplyPatchCallItemOperation2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchCallItemOperation2? value)
        {
            value = ApplyPatchCallItemOperation2;
            return IsApplyPatchCallItemOperation2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ApplyPatchCallItemOperation2 PickApplyPatchCallItemOperation2() => IsApplyPatchCallItemOperation2
            ? ApplyPatchCallItemOperation2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCallItemOperation2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplyPatchCallItemOperation(global::OpenRouter.ApplyPatchCallItemOperation0 value) => new ApplyPatchCallItemOperation((global::OpenRouter.ApplyPatchCallItemOperation0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchCallItemOperation0?(ApplyPatchCallItemOperation @this) => @this.ApplyPatchCallItemOperation0;

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchCallItemOperation(global::OpenRouter.ApplyPatchCallItemOperation0? value)
        {
            ApplyPatchCallItemOperation0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ApplyPatchCallItemOperation FromApplyPatchCallItemOperation0(global::OpenRouter.ApplyPatchCallItemOperation0? value) => new ApplyPatchCallItemOperation(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplyPatchCallItemOperation(global::OpenRouter.ApplyPatchCallItemOperation1 value) => new ApplyPatchCallItemOperation((global::OpenRouter.ApplyPatchCallItemOperation1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchCallItemOperation1?(ApplyPatchCallItemOperation @this) => @this.ApplyPatchCallItemOperation1;

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchCallItemOperation(global::OpenRouter.ApplyPatchCallItemOperation1? value)
        {
            ApplyPatchCallItemOperation1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ApplyPatchCallItemOperation FromApplyPatchCallItemOperation1(global::OpenRouter.ApplyPatchCallItemOperation1? value) => new ApplyPatchCallItemOperation(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplyPatchCallItemOperation(global::OpenRouter.ApplyPatchCallItemOperation2 value) => new ApplyPatchCallItemOperation((global::OpenRouter.ApplyPatchCallItemOperation2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchCallItemOperation2?(ApplyPatchCallItemOperation @this) => @this.ApplyPatchCallItemOperation2;

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchCallItemOperation(global::OpenRouter.ApplyPatchCallItemOperation2? value)
        {
            ApplyPatchCallItemOperation2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ApplyPatchCallItemOperation FromApplyPatchCallItemOperation2(global::OpenRouter.ApplyPatchCallItemOperation2? value) => new ApplyPatchCallItemOperation(value);

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchCallItemOperation(
            global::OpenRouter.ApplyPatchCallItemOperation0? applyPatchCallItemOperation0,
            global::OpenRouter.ApplyPatchCallItemOperation1? applyPatchCallItemOperation1,
            global::OpenRouter.ApplyPatchCallItemOperation2? applyPatchCallItemOperation2
            )
        {
            ApplyPatchCallItemOperation0 = applyPatchCallItemOperation0;
            ApplyPatchCallItemOperation1 = applyPatchCallItemOperation1;
            ApplyPatchCallItemOperation2 = applyPatchCallItemOperation2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ApplyPatchCallItemOperation2 as object ??
            ApplyPatchCallItemOperation1 as object ??
            ApplyPatchCallItemOperation0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ApplyPatchCallItemOperation0?.ToString() ??
            ApplyPatchCallItemOperation1?.ToString() ??
            ApplyPatchCallItemOperation2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApplyPatchCallItemOperation0 && !IsApplyPatchCallItemOperation1 && !IsApplyPatchCallItemOperation2 || !IsApplyPatchCallItemOperation0 && IsApplyPatchCallItemOperation1 && !IsApplyPatchCallItemOperation2 || !IsApplyPatchCallItemOperation0 && !IsApplyPatchCallItemOperation1 && IsApplyPatchCallItemOperation2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ApplyPatchCallItemOperation0, TResult>? applyPatchCallItemOperation0 = null,
            global::System.Func<global::OpenRouter.ApplyPatchCallItemOperation1, TResult>? applyPatchCallItemOperation1 = null,
            global::System.Func<global::OpenRouter.ApplyPatchCallItemOperation2, TResult>? applyPatchCallItemOperation2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApplyPatchCallItemOperation0 && applyPatchCallItemOperation0 != null)
            {
                return applyPatchCallItemOperation0(ApplyPatchCallItemOperation0!);
            }
            else if (IsApplyPatchCallItemOperation1 && applyPatchCallItemOperation1 != null)
            {
                return applyPatchCallItemOperation1(ApplyPatchCallItemOperation1!);
            }
            else if (IsApplyPatchCallItemOperation2 && applyPatchCallItemOperation2 != null)
            {
                return applyPatchCallItemOperation2(ApplyPatchCallItemOperation2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ApplyPatchCallItemOperation0>? applyPatchCallItemOperation0 = null,

            global::System.Action<global::OpenRouter.ApplyPatchCallItemOperation1>? applyPatchCallItemOperation1 = null,

            global::System.Action<global::OpenRouter.ApplyPatchCallItemOperation2>? applyPatchCallItemOperation2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApplyPatchCallItemOperation0)
            {
                applyPatchCallItemOperation0?.Invoke(ApplyPatchCallItemOperation0!);
            }
            else if (IsApplyPatchCallItemOperation1)
            {
                applyPatchCallItemOperation1?.Invoke(ApplyPatchCallItemOperation1!);
            }
            else if (IsApplyPatchCallItemOperation2)
            {
                applyPatchCallItemOperation2?.Invoke(ApplyPatchCallItemOperation2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ApplyPatchCallItemOperation0>? applyPatchCallItemOperation0 = null,
            global::System.Action<global::OpenRouter.ApplyPatchCallItemOperation1>? applyPatchCallItemOperation1 = null,
            global::System.Action<global::OpenRouter.ApplyPatchCallItemOperation2>? applyPatchCallItemOperation2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApplyPatchCallItemOperation0)
            {
                applyPatchCallItemOperation0?.Invoke(ApplyPatchCallItemOperation0!);
            }
            else if (IsApplyPatchCallItemOperation1)
            {
                applyPatchCallItemOperation1?.Invoke(ApplyPatchCallItemOperation1!);
            }
            else if (IsApplyPatchCallItemOperation2)
            {
                applyPatchCallItemOperation2?.Invoke(ApplyPatchCallItemOperation2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ApplyPatchCallItemOperation0,
                typeof(global::OpenRouter.ApplyPatchCallItemOperation0),
                ApplyPatchCallItemOperation1,
                typeof(global::OpenRouter.ApplyPatchCallItemOperation1),
                ApplyPatchCallItemOperation2,
                typeof(global::OpenRouter.ApplyPatchCallItemOperation2),
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
        public bool Equals(ApplyPatchCallItemOperation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCallItemOperation0?>.Default.Equals(ApplyPatchCallItemOperation0, other.ApplyPatchCallItemOperation0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCallItemOperation1?>.Default.Equals(ApplyPatchCallItemOperation1, other.ApplyPatchCallItemOperation1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCallItemOperation2?>.Default.Equals(ApplyPatchCallItemOperation2, other.ApplyPatchCallItemOperation2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ApplyPatchCallItemOperation obj1, ApplyPatchCallItemOperation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ApplyPatchCallItemOperation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ApplyPatchCallItemOperation obj1, ApplyPatchCallItemOperation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ApplyPatchCallItemOperation o && Equals(o);
        }
    }
}
