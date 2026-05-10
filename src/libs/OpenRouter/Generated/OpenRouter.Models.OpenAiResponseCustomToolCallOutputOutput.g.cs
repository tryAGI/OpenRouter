#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OpenAiResponseCustomToolCallOutputOutput : global::System.IEquatable<OpenAiResponseCustomToolCallOutputOutput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? OpenAiResponseCustomToolCallOutputOutputVariant1 { get; init; }
#else
        public string? OpenAiResponseCustomToolCallOutputOutputVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAiResponseCustomToolCallOutputOutputVariant1))]
#endif
        public bool IsOpenAiResponseCustomToolCallOutputOutputVariant1 => OpenAiResponseCustomToolCallOutputOutputVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenAiResponseCustomToolCallOutputOutputVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = OpenAiResponseCustomToolCallOutputOutputVariant1;
            return IsOpenAiResponseCustomToolCallOutputOutputVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickOpenAiResponseCustomToolCallOutputOutputVariant1() => IsOpenAiResponseCustomToolCallOutputOutputVariant1
            ? OpenAiResponseCustomToolCallOutputOutputVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAiResponseCustomToolCallOutputOutputVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1Items>? OpenAiResponseCustomToolCallOutputOutput1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1Items>? OpenAiResponseCustomToolCallOutputOutput1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAiResponseCustomToolCallOutputOutput1))]
#endif
        public bool IsOpenAiResponseCustomToolCallOutputOutput1 => OpenAiResponseCustomToolCallOutputOutput1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenAiResponseCustomToolCallOutputOutput1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1Items>? value)
        {
            value = OpenAiResponseCustomToolCallOutputOutput1;
            return IsOpenAiResponseCustomToolCallOutputOutput1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1Items> PickOpenAiResponseCustomToolCallOutputOutput1() => IsOpenAiResponseCustomToolCallOutputOutput1
            ? OpenAiResponseCustomToolCallOutputOutput1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAiResponseCustomToolCallOutputOutput1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenAiResponseCustomToolCallOutputOutput(string value) => new OpenAiResponseCustomToolCallOutputOutput((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(OpenAiResponseCustomToolCallOutputOutput @this) => @this.OpenAiResponseCustomToolCallOutputOutputVariant1;

        /// <summary>
        /// 
        /// </summary>
        public OpenAiResponseCustomToolCallOutputOutput(string? value)
        {
            OpenAiResponseCustomToolCallOutputOutputVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OpenAiResponseCustomToolCallOutputOutput FromOpenAiResponseCustomToolCallOutputOutputVariant1(string? value) => new OpenAiResponseCustomToolCallOutputOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public OpenAiResponseCustomToolCallOutputOutput(
            string? openAiResponseCustomToolCallOutputOutputVariant1,
            global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1Items>? openAiResponseCustomToolCallOutputOutput1
            )
        {
            OpenAiResponseCustomToolCallOutputOutputVariant1 = openAiResponseCustomToolCallOutputOutputVariant1;
            OpenAiResponseCustomToolCallOutputOutput1 = openAiResponseCustomToolCallOutputOutput1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OpenAiResponseCustomToolCallOutputOutput1 as object ??
            OpenAiResponseCustomToolCallOutputOutputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenAiResponseCustomToolCallOutputOutputVariant1?.ToString() ??
            OpenAiResponseCustomToolCallOutputOutput1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenAiResponseCustomToolCallOutputOutputVariant1 && !IsOpenAiResponseCustomToolCallOutputOutput1 || !IsOpenAiResponseCustomToolCallOutputOutputVariant1 && IsOpenAiResponseCustomToolCallOutputOutput1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? openAiResponseCustomToolCallOutputOutputVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1Items>, TResult>? openAiResponseCustomToolCallOutputOutput1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAiResponseCustomToolCallOutputOutputVariant1 && openAiResponseCustomToolCallOutputOutputVariant1 != null)
            {
                return openAiResponseCustomToolCallOutputOutputVariant1(OpenAiResponseCustomToolCallOutputOutputVariant1!);
            }
            else if (IsOpenAiResponseCustomToolCallOutputOutput1 && openAiResponseCustomToolCallOutputOutput1 != null)
            {
                return openAiResponseCustomToolCallOutputOutput1(OpenAiResponseCustomToolCallOutputOutput1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? openAiResponseCustomToolCallOutputOutputVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1Items>>? openAiResponseCustomToolCallOutputOutput1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAiResponseCustomToolCallOutputOutputVariant1)
            {
                openAiResponseCustomToolCallOutputOutputVariant1?.Invoke(OpenAiResponseCustomToolCallOutputOutputVariant1!);
            }
            else if (IsOpenAiResponseCustomToolCallOutputOutput1)
            {
                openAiResponseCustomToolCallOutputOutput1?.Invoke(OpenAiResponseCustomToolCallOutputOutput1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? openAiResponseCustomToolCallOutputOutputVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1Items>>? openAiResponseCustomToolCallOutputOutput1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAiResponseCustomToolCallOutputOutputVariant1)
            {
                openAiResponseCustomToolCallOutputOutputVariant1?.Invoke(OpenAiResponseCustomToolCallOutputOutputVariant1!);
            }
            else if (IsOpenAiResponseCustomToolCallOutputOutput1)
            {
                openAiResponseCustomToolCallOutputOutput1?.Invoke(OpenAiResponseCustomToolCallOutputOutput1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAiResponseCustomToolCallOutputOutputVariant1,
                typeof(string),
                OpenAiResponseCustomToolCallOutputOutput1,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1Items>),
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
        public bool Equals(OpenAiResponseCustomToolCallOutputOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(OpenAiResponseCustomToolCallOutputOutputVariant1, other.OpenAiResponseCustomToolCallOutputOutputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1Items>?>.Default.Equals(OpenAiResponseCustomToolCallOutputOutput1, other.OpenAiResponseCustomToolCallOutputOutput1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OpenAiResponseCustomToolCallOutputOutput obj1, OpenAiResponseCustomToolCallOutputOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OpenAiResponseCustomToolCallOutputOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OpenAiResponseCustomToolCallOutputOutput obj1, OpenAiResponseCustomToolCallOutputOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OpenAiResponseCustomToolCallOutputOutput o && Equals(o);
        }
    }
}
