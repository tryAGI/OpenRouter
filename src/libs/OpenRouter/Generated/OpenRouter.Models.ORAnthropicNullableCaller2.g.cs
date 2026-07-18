#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ORAnthropicNullableCaller2 : global::System.IEquatable<ORAnthropicNullableCaller2>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OrAnthropicNullableCaller? OrAnthropicNullableCaller { get; init; }
#else
        public global::OpenRouter.OrAnthropicNullableCaller? OrAnthropicNullableCaller { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrAnthropicNullableCaller))]
#endif
        public bool IsOrAnthropicNullableCaller => OrAnthropicNullableCaller != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOrAnthropicNullableCaller(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OrAnthropicNullableCaller? value)
        {
            value = OrAnthropicNullableCaller;
            return IsOrAnthropicNullableCaller;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OrAnthropicNullableCaller PickOrAnthropicNullableCaller() => IsOrAnthropicNullableCaller
            ? OrAnthropicNullableCaller!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrAnthropicNullableCaller' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? CallerVariant2 { get; init; }
#else
        public object? CallerVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CallerVariant2))]
#endif
        public bool IsCallerVariant2 => CallerVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCallerVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = CallerVariant2;
            return IsCallerVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickCallerVariant2() => IsCallerVariant2
            ? CallerVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CallerVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicNullableCaller2(global::OpenRouter.OrAnthropicNullableCaller value) => new ORAnthropicNullableCaller2((global::OpenRouter.OrAnthropicNullableCaller?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OrAnthropicNullableCaller?(ORAnthropicNullableCaller2 @this) => @this.OrAnthropicNullableCaller;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicNullableCaller2(global::OpenRouter.OrAnthropicNullableCaller? value)
        {
            OrAnthropicNullableCaller = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ORAnthropicNullableCaller2 FromOrAnthropicNullableCaller(global::OpenRouter.OrAnthropicNullableCaller? value) => new ORAnthropicNullableCaller2(value);

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicNullableCaller2(
            global::OpenRouter.OrAnthropicNullableCaller? orAnthropicNullableCaller,
            object? callerVariant2
            )
        {
            OrAnthropicNullableCaller = orAnthropicNullableCaller;
            CallerVariant2 = callerVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CallerVariant2 as object ??
            OrAnthropicNullableCaller as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OrAnthropicNullableCaller?.ToString() ??
            CallerVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOrAnthropicNullableCaller && !IsCallerVariant2 || !IsOrAnthropicNullableCaller && IsCallerVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OrAnthropicNullableCaller?, TResult>? orAnthropicNullableCaller = null,
            global::System.Func<object, TResult>? callerVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrAnthropicNullableCaller && orAnthropicNullableCaller != null)
            {
                return orAnthropicNullableCaller(OrAnthropicNullableCaller!);
            }
            else if (IsCallerVariant2 && callerVariant2 != null)
            {
                return callerVariant2(CallerVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OrAnthropicNullableCaller?>? orAnthropicNullableCaller = null,

            global::System.Action<object>? callerVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrAnthropicNullableCaller)
            {
                orAnthropicNullableCaller?.Invoke(OrAnthropicNullableCaller!);
            }
            else if (IsCallerVariant2)
            {
                callerVariant2?.Invoke(CallerVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OrAnthropicNullableCaller?>? orAnthropicNullableCaller = null,
            global::System.Action<object>? callerVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrAnthropicNullableCaller)
            {
                orAnthropicNullableCaller?.Invoke(OrAnthropicNullableCaller!);
            }
            else if (IsCallerVariant2)
            {
                callerVariant2?.Invoke(CallerVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OrAnthropicNullableCaller,
                typeof(global::OpenRouter.OrAnthropicNullableCaller),
                CallerVariant2,
                typeof(object),
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
        public bool Equals(ORAnthropicNullableCaller2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OrAnthropicNullableCaller?>.Default.Equals(OrAnthropicNullableCaller, other.OrAnthropicNullableCaller) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(CallerVariant2, other.CallerVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ORAnthropicNullableCaller2 obj1, ORAnthropicNullableCaller2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ORAnthropicNullableCaller2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ORAnthropicNullableCaller2 obj1, ORAnthropicNullableCaller2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ORAnthropicNullableCaller2 o && Equals(o);
        }
    }
}
