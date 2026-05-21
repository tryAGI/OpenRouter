#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CustomToolCallOutputItemOutput : global::System.IEquatable<CustomToolCallOutputItemOutput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? CustomToolCallOutputItemOutputVariant1 { get; init; }
#else
        public string? CustomToolCallOutputItemOutputVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCallOutputItemOutputVariant1))]
#endif
        public bool IsCustomToolCallOutputItemOutputVariant1 => CustomToolCallOutputItemOutputVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCustomToolCallOutputItemOutputVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = CustomToolCallOutputItemOutputVariant1;
            return IsCustomToolCallOutputItemOutputVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickCustomToolCallOutputItemOutputVariant1() => IsCustomToolCallOutputItemOutputVariant1
            ? CustomToolCallOutputItemOutputVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCallOutputItemOutputVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items>? CustomToolCallOutputItemOutput1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items>? CustomToolCallOutputItemOutput1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCallOutputItemOutput1))]
#endif
        public bool IsCustomToolCallOutputItemOutput1 => CustomToolCallOutputItemOutput1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCustomToolCallOutputItemOutput1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items>? value)
        {
            value = CustomToolCallOutputItemOutput1;
            return IsCustomToolCallOutputItemOutput1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items> PickCustomToolCallOutputItemOutput1() => IsCustomToolCallOutputItemOutput1
            ? CustomToolCallOutputItemOutput1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCallOutputItemOutput1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomToolCallOutputItemOutput(string value) => new CustomToolCallOutputItemOutput((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(CustomToolCallOutputItemOutput @this) => @this.CustomToolCallOutputItemOutputVariant1;

        /// <summary>
        /// 
        /// </summary>
        public CustomToolCallOutputItemOutput(string? value)
        {
            CustomToolCallOutputItemOutputVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CustomToolCallOutputItemOutput FromCustomToolCallOutputItemOutputVariant1(string? value) => new CustomToolCallOutputItemOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public CustomToolCallOutputItemOutput(
            string? customToolCallOutputItemOutputVariant1,
            global::System.Collections.Generic.IList<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items>? customToolCallOutputItemOutput1
            )
        {
            CustomToolCallOutputItemOutputVariant1 = customToolCallOutputItemOutputVariant1;
            CustomToolCallOutputItemOutput1 = customToolCallOutputItemOutput1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomToolCallOutputItemOutput1 as object ??
            CustomToolCallOutputItemOutputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CustomToolCallOutputItemOutputVariant1?.ToString() ??
            CustomToolCallOutputItemOutput1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustomToolCallOutputItemOutputVariant1 && !IsCustomToolCallOutputItemOutput1 || !IsCustomToolCallOutputItemOutputVariant1 && IsCustomToolCallOutputItemOutput1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? customToolCallOutputItemOutputVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items>, TResult>? customToolCallOutputItemOutput1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomToolCallOutputItemOutputVariant1 && customToolCallOutputItemOutputVariant1 != null)
            {
                return customToolCallOutputItemOutputVariant1(CustomToolCallOutputItemOutputVariant1!);
            }
            else if (IsCustomToolCallOutputItemOutput1 && customToolCallOutputItemOutput1 != null)
            {
                return customToolCallOutputItemOutput1(CustomToolCallOutputItemOutput1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? customToolCallOutputItemOutputVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items>>? customToolCallOutputItemOutput1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomToolCallOutputItemOutputVariant1)
            {
                customToolCallOutputItemOutputVariant1?.Invoke(CustomToolCallOutputItemOutputVariant1!);
            }
            else if (IsCustomToolCallOutputItemOutput1)
            {
                customToolCallOutputItemOutput1?.Invoke(CustomToolCallOutputItemOutput1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? customToolCallOutputItemOutputVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items>>? customToolCallOutputItemOutput1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomToolCallOutputItemOutputVariant1)
            {
                customToolCallOutputItemOutputVariant1?.Invoke(CustomToolCallOutputItemOutputVariant1!);
            }
            else if (IsCustomToolCallOutputItemOutput1)
            {
                customToolCallOutputItemOutput1?.Invoke(CustomToolCallOutputItemOutput1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CustomToolCallOutputItemOutputVariant1,
                typeof(string),
                CustomToolCallOutputItemOutput1,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items>),
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
        public bool Equals(CustomToolCallOutputItemOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(CustomToolCallOutputItemOutputVariant1, other.CustomToolCallOutputItemOutputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items>?>.Default.Equals(CustomToolCallOutputItemOutput1, other.CustomToolCallOutputItemOutput1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CustomToolCallOutputItemOutput obj1, CustomToolCallOutputItemOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CustomToolCallOutputItemOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CustomToolCallOutputItemOutput obj1, CustomToolCallOutputItemOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomToolCallOutputItemOutput o && Equals(o);
        }
    }
}
