#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when an error occurs during streaming<br/>
    /// Example: {"code":"rate_limit_exceeded","message":"Rate limit exceeded. Please try again later.","param":null,"sequence_number":2,"type":"error"}
    /// </summary>
    public readonly partial struct ErrorEvent : global::System.IEquatable<ErrorEvent>
    {
        /// <summary>
        /// Event emitted when an error occurs during streaming<br/>
        /// Example: {"code":"rate_limit_exceeded","message":"Rate limit exceeded. Please try again later.","param":null,"sequence_number":2,"type":"error"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseErrorEvent? Base { get; init; }
#else
        public global::OpenRouter.BaseErrorEvent? Base { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.BaseErrorEvent? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseErrorEvent PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ErrorEventVariant2 { get; init; }
#else
        public object? ErrorEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ErrorEventVariant2))]
#endif
        public bool IsErrorEventVariant2 => ErrorEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickErrorEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ErrorEventVariant2;
            return IsErrorEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickErrorEventVariant2() => ErrorEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ErrorEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ErrorEvent(global::OpenRouter.BaseErrorEvent value) => new ErrorEvent((global::OpenRouter.BaseErrorEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BaseErrorEvent?(ErrorEvent @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ErrorEvent(global::OpenRouter.BaseErrorEvent? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ErrorEvent FromBase(global::OpenRouter.BaseErrorEvent? value) => new ErrorEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ErrorEvent(
            global::OpenRouter.BaseErrorEvent? @base,
            object? errorEventVariant2
            )
        {
            Base = @base;
            ErrorEventVariant2 = errorEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ErrorEventVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ErrorEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsErrorEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseErrorEvent, TResult>? @base = null,
            global::System.Func<object, TResult>? errorEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0 && @base != null)
            {
                return @base(__value0);
            }
            else if (ErrorEventVariant2 is { } __value1 && errorEventVariant2 != null)
            {
                return errorEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseErrorEvent>? @base = null,

            global::System.Action<object>? errorEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (ErrorEventVariant2 is { } __value1)
            {
                errorEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BaseErrorEvent>? @base = null,
            global::System.Action<object>? errorEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (ErrorEventVariant2 is { } __value1)
            {
                errorEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::OpenRouter.BaseErrorEvent),
                ErrorEventVariant2,
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
        public bool Equals(ErrorEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseErrorEvent?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ErrorEventVariant2, other.ErrorEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ErrorEvent obj1, ErrorEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ErrorEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ErrorEvent obj1, ErrorEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ErrorEvent o && Equals(o);
        }
    }
}
