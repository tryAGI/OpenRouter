#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The patch operation requested by an `apply_patch_call`. `create_file` and `update_file` carry a V4A diff; `delete_file` omits it.
    /// </summary>
    public readonly partial struct ApplyPatchCallOperation : global::System.IEquatable<ApplyPatchCallOperation>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchCallOperation0? ApplyPatchCallOperation0 { get; init; }
#else
        public global::OpenRouter.ApplyPatchCallOperation0? ApplyPatchCallOperation0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCallOperation0))]
#endif
        public bool IsApplyPatchCallOperation0 => ApplyPatchCallOperation0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApplyPatchCallOperation0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchCallOperation0? value)
        {
            value = ApplyPatchCallOperation0;
            return IsApplyPatchCallOperation0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperation0 PickApplyPatchCallOperation0() => IsApplyPatchCallOperation0
            ? ApplyPatchCallOperation0!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCallOperation0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchCallOperation1? ApplyPatchCallOperation1 { get; init; }
#else
        public global::OpenRouter.ApplyPatchCallOperation1? ApplyPatchCallOperation1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCallOperation1))]
#endif
        public bool IsApplyPatchCallOperation1 => ApplyPatchCallOperation1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApplyPatchCallOperation1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchCallOperation1? value)
        {
            value = ApplyPatchCallOperation1;
            return IsApplyPatchCallOperation1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperation1 PickApplyPatchCallOperation1() => IsApplyPatchCallOperation1
            ? ApplyPatchCallOperation1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCallOperation1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchCallOperation2? ApplyPatchCallOperation2 { get; init; }
#else
        public global::OpenRouter.ApplyPatchCallOperation2? ApplyPatchCallOperation2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCallOperation2))]
#endif
        public bool IsApplyPatchCallOperation2 => ApplyPatchCallOperation2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApplyPatchCallOperation2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchCallOperation2? value)
        {
            value = ApplyPatchCallOperation2;
            return IsApplyPatchCallOperation2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperation2 PickApplyPatchCallOperation2() => IsApplyPatchCallOperation2
            ? ApplyPatchCallOperation2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCallOperation2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplyPatchCallOperation(global::OpenRouter.ApplyPatchCallOperation0 value) => new ApplyPatchCallOperation((global::OpenRouter.ApplyPatchCallOperation0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchCallOperation0?(ApplyPatchCallOperation @this) => @this.ApplyPatchCallOperation0;

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchCallOperation(global::OpenRouter.ApplyPatchCallOperation0? value)
        {
            ApplyPatchCallOperation0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ApplyPatchCallOperation FromApplyPatchCallOperation0(global::OpenRouter.ApplyPatchCallOperation0? value) => new ApplyPatchCallOperation(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplyPatchCallOperation(global::OpenRouter.ApplyPatchCallOperation1 value) => new ApplyPatchCallOperation((global::OpenRouter.ApplyPatchCallOperation1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchCallOperation1?(ApplyPatchCallOperation @this) => @this.ApplyPatchCallOperation1;

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchCallOperation(global::OpenRouter.ApplyPatchCallOperation1? value)
        {
            ApplyPatchCallOperation1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ApplyPatchCallOperation FromApplyPatchCallOperation1(global::OpenRouter.ApplyPatchCallOperation1? value) => new ApplyPatchCallOperation(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplyPatchCallOperation(global::OpenRouter.ApplyPatchCallOperation2 value) => new ApplyPatchCallOperation((global::OpenRouter.ApplyPatchCallOperation2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchCallOperation2?(ApplyPatchCallOperation @this) => @this.ApplyPatchCallOperation2;

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchCallOperation(global::OpenRouter.ApplyPatchCallOperation2? value)
        {
            ApplyPatchCallOperation2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ApplyPatchCallOperation FromApplyPatchCallOperation2(global::OpenRouter.ApplyPatchCallOperation2? value) => new ApplyPatchCallOperation(value);

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchCallOperation(
            global::OpenRouter.ApplyPatchCallOperation0? applyPatchCallOperation0,
            global::OpenRouter.ApplyPatchCallOperation1? applyPatchCallOperation1,
            global::OpenRouter.ApplyPatchCallOperation2? applyPatchCallOperation2
            )
        {
            ApplyPatchCallOperation0 = applyPatchCallOperation0;
            ApplyPatchCallOperation1 = applyPatchCallOperation1;
            ApplyPatchCallOperation2 = applyPatchCallOperation2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ApplyPatchCallOperation2 as object ??
            ApplyPatchCallOperation1 as object ??
            ApplyPatchCallOperation0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ApplyPatchCallOperation0?.ToString() ??
            ApplyPatchCallOperation1?.ToString() ??
            ApplyPatchCallOperation2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApplyPatchCallOperation0 && !IsApplyPatchCallOperation1 && !IsApplyPatchCallOperation2 || !IsApplyPatchCallOperation0 && IsApplyPatchCallOperation1 && !IsApplyPatchCallOperation2 || !IsApplyPatchCallOperation0 && !IsApplyPatchCallOperation1 && IsApplyPatchCallOperation2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ApplyPatchCallOperation0, TResult>? applyPatchCallOperation0 = null,
            global::System.Func<global::OpenRouter.ApplyPatchCallOperation1, TResult>? applyPatchCallOperation1 = null,
            global::System.Func<global::OpenRouter.ApplyPatchCallOperation2, TResult>? applyPatchCallOperation2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApplyPatchCallOperation0 && applyPatchCallOperation0 != null)
            {
                return applyPatchCallOperation0(ApplyPatchCallOperation0!);
            }
            else if (IsApplyPatchCallOperation1 && applyPatchCallOperation1 != null)
            {
                return applyPatchCallOperation1(ApplyPatchCallOperation1!);
            }
            else if (IsApplyPatchCallOperation2 && applyPatchCallOperation2 != null)
            {
                return applyPatchCallOperation2(ApplyPatchCallOperation2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ApplyPatchCallOperation0>? applyPatchCallOperation0 = null,

            global::System.Action<global::OpenRouter.ApplyPatchCallOperation1>? applyPatchCallOperation1 = null,

            global::System.Action<global::OpenRouter.ApplyPatchCallOperation2>? applyPatchCallOperation2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApplyPatchCallOperation0)
            {
                applyPatchCallOperation0?.Invoke(ApplyPatchCallOperation0!);
            }
            else if (IsApplyPatchCallOperation1)
            {
                applyPatchCallOperation1?.Invoke(ApplyPatchCallOperation1!);
            }
            else if (IsApplyPatchCallOperation2)
            {
                applyPatchCallOperation2?.Invoke(ApplyPatchCallOperation2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ApplyPatchCallOperation0>? applyPatchCallOperation0 = null,
            global::System.Action<global::OpenRouter.ApplyPatchCallOperation1>? applyPatchCallOperation1 = null,
            global::System.Action<global::OpenRouter.ApplyPatchCallOperation2>? applyPatchCallOperation2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApplyPatchCallOperation0)
            {
                applyPatchCallOperation0?.Invoke(ApplyPatchCallOperation0!);
            }
            else if (IsApplyPatchCallOperation1)
            {
                applyPatchCallOperation1?.Invoke(ApplyPatchCallOperation1!);
            }
            else if (IsApplyPatchCallOperation2)
            {
                applyPatchCallOperation2?.Invoke(ApplyPatchCallOperation2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ApplyPatchCallOperation0,
                typeof(global::OpenRouter.ApplyPatchCallOperation0),
                ApplyPatchCallOperation1,
                typeof(global::OpenRouter.ApplyPatchCallOperation1),
                ApplyPatchCallOperation2,
                typeof(global::OpenRouter.ApplyPatchCallOperation2),
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
        public bool Equals(ApplyPatchCallOperation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCallOperation0?>.Default.Equals(ApplyPatchCallOperation0, other.ApplyPatchCallOperation0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCallOperation1?>.Default.Equals(ApplyPatchCallOperation1, other.ApplyPatchCallOperation1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCallOperation2?>.Default.Equals(ApplyPatchCallOperation2, other.ApplyPatchCallOperation2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ApplyPatchCallOperation obj1, ApplyPatchCallOperation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ApplyPatchCallOperation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ApplyPatchCallOperation obj1, ApplyPatchCallOperation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ApplyPatchCallOperation o && Equals(o);
        }
    }
}
