#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseMessagesResultUsageIterationsItems : global::System.IEquatable<BaseMessagesResultUsageIterationsItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseMessagesResultUsageIterationsItems0? BaseMessagesResultUsageIterationsItems0 { get; init; }
#else
        public global::OpenRouter.BaseMessagesResultUsageIterationsItems0? BaseMessagesResultUsageIterationsItems0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultUsageIterationsItems0))]
#endif
        public bool IsBaseMessagesResultUsageIterationsItems0 => BaseMessagesResultUsageIterationsItems0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseMessagesResultUsageIterationsItems1? BaseMessagesResultUsageIterationsItems1 { get; init; }
#else
        public global::OpenRouter.BaseMessagesResultUsageIterationsItems1? BaseMessagesResultUsageIterationsItems1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultUsageIterationsItems1))]
#endif
        public bool IsBaseMessagesResultUsageIterationsItems1 => BaseMessagesResultUsageIterationsItems1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseMessagesResultUsageIterationsItems2? BaseMessagesResultUsageIterationsItems2 { get; init; }
#else
        public global::OpenRouter.BaseMessagesResultUsageIterationsItems2? BaseMessagesResultUsageIterationsItems2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultUsageIterationsItems2))]
#endif
        public bool IsBaseMessagesResultUsageIterationsItems2 => BaseMessagesResultUsageIterationsItems2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultUsageIterationsItems(global::OpenRouter.BaseMessagesResultUsageIterationsItems0 value) => new BaseMessagesResultUsageIterationsItems((global::OpenRouter.BaseMessagesResultUsageIterationsItems0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.BaseMessagesResultUsageIterationsItems0?(BaseMessagesResultUsageIterationsItems @this) => @this.BaseMessagesResultUsageIterationsItems0;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultUsageIterationsItems(global::OpenRouter.BaseMessagesResultUsageIterationsItems0? value)
        {
            BaseMessagesResultUsageIterationsItems0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultUsageIterationsItems(global::OpenRouter.BaseMessagesResultUsageIterationsItems1 value) => new BaseMessagesResultUsageIterationsItems((global::OpenRouter.BaseMessagesResultUsageIterationsItems1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.BaseMessagesResultUsageIterationsItems1?(BaseMessagesResultUsageIterationsItems @this) => @this.BaseMessagesResultUsageIterationsItems1;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultUsageIterationsItems(global::OpenRouter.BaseMessagesResultUsageIterationsItems1? value)
        {
            BaseMessagesResultUsageIterationsItems1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultUsageIterationsItems(global::OpenRouter.BaseMessagesResultUsageIterationsItems2 value) => new BaseMessagesResultUsageIterationsItems((global::OpenRouter.BaseMessagesResultUsageIterationsItems2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.BaseMessagesResultUsageIterationsItems2?(BaseMessagesResultUsageIterationsItems @this) => @this.BaseMessagesResultUsageIterationsItems2;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultUsageIterationsItems(global::OpenRouter.BaseMessagesResultUsageIterationsItems2? value)
        {
            BaseMessagesResultUsageIterationsItems2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultUsageIterationsItems(
            global::OpenRouter.BaseMessagesResultUsageIterationsItems0? baseMessagesResultUsageIterationsItems0,
            global::OpenRouter.BaseMessagesResultUsageIterationsItems1? baseMessagesResultUsageIterationsItems1,
            global::OpenRouter.BaseMessagesResultUsageIterationsItems2? baseMessagesResultUsageIterationsItems2
            )
        {
            BaseMessagesResultUsageIterationsItems0 = baseMessagesResultUsageIterationsItems0;
            BaseMessagesResultUsageIterationsItems1 = baseMessagesResultUsageIterationsItems1;
            BaseMessagesResultUsageIterationsItems2 = baseMessagesResultUsageIterationsItems2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BaseMessagesResultUsageIterationsItems2 as object ??
            BaseMessagesResultUsageIterationsItems1 as object ??
            BaseMessagesResultUsageIterationsItems0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseMessagesResultUsageIterationsItems0?.ToString() ??
            BaseMessagesResultUsageIterationsItems1?.ToString() ??
            BaseMessagesResultUsageIterationsItems2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseMessagesResultUsageIterationsItems0 && !IsBaseMessagesResultUsageIterationsItems1 && !IsBaseMessagesResultUsageIterationsItems2 || !IsBaseMessagesResultUsageIterationsItems0 && IsBaseMessagesResultUsageIterationsItems1 && !IsBaseMessagesResultUsageIterationsItems2 || !IsBaseMessagesResultUsageIterationsItems0 && !IsBaseMessagesResultUsageIterationsItems1 && IsBaseMessagesResultUsageIterationsItems2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseMessagesResultUsageIterationsItems0?, TResult>? baseMessagesResultUsageIterationsItems0 = null,
            global::System.Func<global::OpenRouter.BaseMessagesResultUsageIterationsItems1?, TResult>? baseMessagesResultUsageIterationsItems1 = null,
            global::System.Func<global::OpenRouter.BaseMessagesResultUsageIterationsItems2?, TResult>? baseMessagesResultUsageIterationsItems2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultUsageIterationsItems0 && baseMessagesResultUsageIterationsItems0 != null)
            {
                return baseMessagesResultUsageIterationsItems0(BaseMessagesResultUsageIterationsItems0!);
            }
            else if (IsBaseMessagesResultUsageIterationsItems1 && baseMessagesResultUsageIterationsItems1 != null)
            {
                return baseMessagesResultUsageIterationsItems1(BaseMessagesResultUsageIterationsItems1!);
            }
            else if (IsBaseMessagesResultUsageIterationsItems2 && baseMessagesResultUsageIterationsItems2 != null)
            {
                return baseMessagesResultUsageIterationsItems2(BaseMessagesResultUsageIterationsItems2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseMessagesResultUsageIterationsItems0?>? baseMessagesResultUsageIterationsItems0 = null,
            global::System.Action<global::OpenRouter.BaseMessagesResultUsageIterationsItems1?>? baseMessagesResultUsageIterationsItems1 = null,
            global::System.Action<global::OpenRouter.BaseMessagesResultUsageIterationsItems2?>? baseMessagesResultUsageIterationsItems2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultUsageIterationsItems0)
            {
                baseMessagesResultUsageIterationsItems0?.Invoke(BaseMessagesResultUsageIterationsItems0!);
            }
            else if (IsBaseMessagesResultUsageIterationsItems1)
            {
                baseMessagesResultUsageIterationsItems1?.Invoke(BaseMessagesResultUsageIterationsItems1!);
            }
            else if (IsBaseMessagesResultUsageIterationsItems2)
            {
                baseMessagesResultUsageIterationsItems2?.Invoke(BaseMessagesResultUsageIterationsItems2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseMessagesResultUsageIterationsItems0,
                typeof(global::OpenRouter.BaseMessagesResultUsageIterationsItems0),
                BaseMessagesResultUsageIterationsItems1,
                typeof(global::OpenRouter.BaseMessagesResultUsageIterationsItems1),
                BaseMessagesResultUsageIterationsItems2,
                typeof(global::OpenRouter.BaseMessagesResultUsageIterationsItems2),
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
        public bool Equals(BaseMessagesResultUsageIterationsItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseMessagesResultUsageIterationsItems0?>.Default.Equals(BaseMessagesResultUsageIterationsItems0, other.BaseMessagesResultUsageIterationsItems0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseMessagesResultUsageIterationsItems1?>.Default.Equals(BaseMessagesResultUsageIterationsItems1, other.BaseMessagesResultUsageIterationsItems1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseMessagesResultUsageIterationsItems2?>.Default.Equals(BaseMessagesResultUsageIterationsItems2, other.BaseMessagesResultUsageIterationsItems2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseMessagesResultUsageIterationsItems obj1, BaseMessagesResultUsageIterationsItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseMessagesResultUsageIterationsItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseMessagesResultUsageIterationsItems obj1, BaseMessagesResultUsageIterationsItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseMessagesResultUsageIterationsItems o && Equals(o);
        }
    }
}
