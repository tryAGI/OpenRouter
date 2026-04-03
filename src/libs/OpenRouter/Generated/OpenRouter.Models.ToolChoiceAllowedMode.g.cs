#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolChoiceAllowedMode : global::System.IEquatable<ToolChoiceAllowedMode>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ToolChoiceAllowedMode0? ToolChoiceAllowedMode0 { get; init; }
#else
        public global::OpenRouter.ToolChoiceAllowedMode0? ToolChoiceAllowedMode0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolChoiceAllowedMode0))]
#endif
        public bool IsToolChoiceAllowedMode0 => ToolChoiceAllowedMode0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ToolChoiceAllowedMode1? ToolChoiceAllowedMode1 { get; init; }
#else
        public global::OpenRouter.ToolChoiceAllowedMode1? ToolChoiceAllowedMode1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolChoiceAllowedMode1))]
#endif
        public bool IsToolChoiceAllowedMode1 => ToolChoiceAllowedMode1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoiceAllowedMode(global::OpenRouter.ToolChoiceAllowedMode0 value) => new ToolChoiceAllowedMode((global::OpenRouter.ToolChoiceAllowedMode0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ToolChoiceAllowedMode0?(ToolChoiceAllowedMode @this) => @this.ToolChoiceAllowedMode0;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoiceAllowedMode(global::OpenRouter.ToolChoiceAllowedMode0? value)
        {
            ToolChoiceAllowedMode0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoiceAllowedMode(global::OpenRouter.ToolChoiceAllowedMode1 value) => new ToolChoiceAllowedMode((global::OpenRouter.ToolChoiceAllowedMode1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ToolChoiceAllowedMode1?(ToolChoiceAllowedMode @this) => @this.ToolChoiceAllowedMode1;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoiceAllowedMode(global::OpenRouter.ToolChoiceAllowedMode1? value)
        {
            ToolChoiceAllowedMode1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolChoiceAllowedMode(
            global::OpenRouter.ToolChoiceAllowedMode0? toolChoiceAllowedMode0,
            global::OpenRouter.ToolChoiceAllowedMode1? toolChoiceAllowedMode1
            )
        {
            ToolChoiceAllowedMode0 = toolChoiceAllowedMode0;
            ToolChoiceAllowedMode1 = toolChoiceAllowedMode1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolChoiceAllowedMode1 as object ??
            ToolChoiceAllowedMode0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ToolChoiceAllowedMode0?.ToValueString() ??
            ToolChoiceAllowedMode1?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsToolChoiceAllowedMode0 && !IsToolChoiceAllowedMode1 || !IsToolChoiceAllowedMode0 && IsToolChoiceAllowedMode1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ToolChoiceAllowedMode0?, TResult>? toolChoiceAllowedMode0 = null,
            global::System.Func<global::OpenRouter.ToolChoiceAllowedMode1?, TResult>? toolChoiceAllowedMode1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolChoiceAllowedMode0 && toolChoiceAllowedMode0 != null)
            {
                return toolChoiceAllowedMode0(ToolChoiceAllowedMode0!);
            }
            else if (IsToolChoiceAllowedMode1 && toolChoiceAllowedMode1 != null)
            {
                return toolChoiceAllowedMode1(ToolChoiceAllowedMode1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ToolChoiceAllowedMode0?>? toolChoiceAllowedMode0 = null,
            global::System.Action<global::OpenRouter.ToolChoiceAllowedMode1?>? toolChoiceAllowedMode1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolChoiceAllowedMode0)
            {
                toolChoiceAllowedMode0?.Invoke(ToolChoiceAllowedMode0!);
            }
            else if (IsToolChoiceAllowedMode1)
            {
                toolChoiceAllowedMode1?.Invoke(ToolChoiceAllowedMode1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ToolChoiceAllowedMode0,
                typeof(global::OpenRouter.ToolChoiceAllowedMode0),
                ToolChoiceAllowedMode1,
                typeof(global::OpenRouter.ToolChoiceAllowedMode1),
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
        public bool Equals(ToolChoiceAllowedMode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ToolChoiceAllowedMode0?>.Default.Equals(ToolChoiceAllowedMode0, other.ToolChoiceAllowedMode0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ToolChoiceAllowedMode1?>.Default.Equals(ToolChoiceAllowedMode1, other.ToolChoiceAllowedMode1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolChoiceAllowedMode obj1, ToolChoiceAllowedMode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolChoiceAllowedMode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolChoiceAllowedMode obj1, ToolChoiceAllowedMode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolChoiceAllowedMode o && Equals(o);
        }
    }
}
