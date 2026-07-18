#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EasyInputMessageContent : global::System.IEquatable<EasyInputMessageContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.EasyInputMessageContentOneOf0Items>? EasyInputMessageContent0 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.EasyInputMessageContentOneOf0Items>? EasyInputMessageContent0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EasyInputMessageContent0))]
#endif
        public bool IsEasyInputMessageContent0 => EasyInputMessageContent0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEasyInputMessageContent0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::OpenRouter.EasyInputMessageContentOneOf0Items>? value)
        {
            value = EasyInputMessageContent0;
            return IsEasyInputMessageContent0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.EasyInputMessageContentOneOf0Items> PickEasyInputMessageContent0() => IsEasyInputMessageContent0
            ? EasyInputMessageContent0!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EasyInputMessageContent0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? EasyInputMessageContentVariant2 { get; init; }
#else
        public string? EasyInputMessageContentVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EasyInputMessageContentVariant2))]
#endif
        public bool IsEasyInputMessageContentVariant2 => EasyInputMessageContentVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEasyInputMessageContentVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = EasyInputMessageContentVariant2;
            return IsEasyInputMessageContentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickEasyInputMessageContentVariant2() => IsEasyInputMessageContentVariant2
            ? EasyInputMessageContentVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EasyInputMessageContentVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EasyInputMessageContent(string value) => new EasyInputMessageContent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(EasyInputMessageContent @this) => @this.EasyInputMessageContentVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EasyInputMessageContent(string? value)
        {
            EasyInputMessageContentVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EasyInputMessageContent FromEasyInputMessageContentVariant2(string? value) => new EasyInputMessageContent(value);

        /// <summary>
        /// 
        /// </summary>
        public EasyInputMessageContent(
            global::System.Collections.Generic.IList<global::OpenRouter.EasyInputMessageContentOneOf0Items>? easyInputMessageContent0,
            string? easyInputMessageContentVariant2
            )
        {
            EasyInputMessageContent0 = easyInputMessageContent0;
            EasyInputMessageContentVariant2 = easyInputMessageContentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EasyInputMessageContentVariant2 as object ??
            EasyInputMessageContent0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EasyInputMessageContent0?.ToString() ??
            EasyInputMessageContentVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEasyInputMessageContent0 && !IsEasyInputMessageContentVariant2 || !IsEasyInputMessageContent0 && IsEasyInputMessageContentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.EasyInputMessageContentOneOf0Items>, TResult>? easyInputMessageContent0 = null,
            global::System.Func<string, TResult>? easyInputMessageContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEasyInputMessageContent0 && easyInputMessageContent0 != null)
            {
                return easyInputMessageContent0(EasyInputMessageContent0!);
            }
            else if (IsEasyInputMessageContentVariant2 && easyInputMessageContentVariant2 != null)
            {
                return easyInputMessageContentVariant2(EasyInputMessageContentVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.EasyInputMessageContentOneOf0Items>>? easyInputMessageContent0 = null,

            global::System.Action<string>? easyInputMessageContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEasyInputMessageContent0)
            {
                easyInputMessageContent0?.Invoke(EasyInputMessageContent0!);
            }
            else if (IsEasyInputMessageContentVariant2)
            {
                easyInputMessageContentVariant2?.Invoke(EasyInputMessageContentVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.EasyInputMessageContentOneOf0Items>>? easyInputMessageContent0 = null,
            global::System.Action<string>? easyInputMessageContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEasyInputMessageContent0)
            {
                easyInputMessageContent0?.Invoke(EasyInputMessageContent0!);
            }
            else if (IsEasyInputMessageContentVariant2)
            {
                easyInputMessageContentVariant2?.Invoke(EasyInputMessageContentVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EasyInputMessageContent0,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.EasyInputMessageContentOneOf0Items>),
                EasyInputMessageContentVariant2,
                typeof(string),
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
        public bool Equals(EasyInputMessageContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.EasyInputMessageContentOneOf0Items>?>.Default.Equals(EasyInputMessageContent0, other.EasyInputMessageContent0) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(EasyInputMessageContentVariant2, other.EasyInputMessageContentVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EasyInputMessageContent obj1, EasyInputMessageContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EasyInputMessageContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EasyInputMessageContent obj1, EasyInputMessageContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EasyInputMessageContent o && Equals(o);
        }
    }
}
