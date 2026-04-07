#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OpenAiResponseFunctionToolCallOutputOutput : global::System.IEquatable<OpenAiResponseFunctionToolCallOutputOutput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? OpenAiResponseFunctionToolCallOutputOutputVariant1 { get; init; }
#else
        public string? OpenAiResponseFunctionToolCallOutputOutputVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAiResponseFunctionToolCallOutputOutputVariant1))]
#endif
        public bool IsOpenAiResponseFunctionToolCallOutputOutputVariant1 => OpenAiResponseFunctionToolCallOutputOutputVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1Items>? OpenAiResponseFunctionToolCallOutputOutput1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1Items>? OpenAiResponseFunctionToolCallOutputOutput1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAiResponseFunctionToolCallOutputOutput1))]
#endif
        public bool IsOpenAiResponseFunctionToolCallOutputOutput1 => OpenAiResponseFunctionToolCallOutputOutput1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenAiResponseFunctionToolCallOutputOutput(string value) => new OpenAiResponseFunctionToolCallOutputOutput((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(OpenAiResponseFunctionToolCallOutputOutput @this) => @this.OpenAiResponseFunctionToolCallOutputOutputVariant1;

        /// <summary>
        /// 
        /// </summary>
        public OpenAiResponseFunctionToolCallOutputOutput(string? value)
        {
            OpenAiResponseFunctionToolCallOutputOutputVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OpenAiResponseFunctionToolCallOutputOutput(
            string? openAiResponseFunctionToolCallOutputOutputVariant1,
            global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1Items>? openAiResponseFunctionToolCallOutputOutput1
            )
        {
            OpenAiResponseFunctionToolCallOutputOutputVariant1 = openAiResponseFunctionToolCallOutputOutputVariant1;
            OpenAiResponseFunctionToolCallOutputOutput1 = openAiResponseFunctionToolCallOutputOutput1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OpenAiResponseFunctionToolCallOutputOutput1 as object ??
            OpenAiResponseFunctionToolCallOutputOutputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenAiResponseFunctionToolCallOutputOutputVariant1?.ToString() ??
            OpenAiResponseFunctionToolCallOutputOutput1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenAiResponseFunctionToolCallOutputOutputVariant1 && !IsOpenAiResponseFunctionToolCallOutputOutput1 || !IsOpenAiResponseFunctionToolCallOutputOutputVariant1 && IsOpenAiResponseFunctionToolCallOutputOutput1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? openAiResponseFunctionToolCallOutputOutputVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1Items>?, TResult>? openAiResponseFunctionToolCallOutputOutput1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAiResponseFunctionToolCallOutputOutputVariant1 && openAiResponseFunctionToolCallOutputOutputVariant1 != null)
            {
                return openAiResponseFunctionToolCallOutputOutputVariant1(OpenAiResponseFunctionToolCallOutputOutputVariant1!);
            }
            else if (IsOpenAiResponseFunctionToolCallOutputOutput1 && openAiResponseFunctionToolCallOutputOutput1 != null)
            {
                return openAiResponseFunctionToolCallOutputOutput1(OpenAiResponseFunctionToolCallOutputOutput1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? openAiResponseFunctionToolCallOutputOutputVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1Items>?>? openAiResponseFunctionToolCallOutputOutput1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAiResponseFunctionToolCallOutputOutputVariant1)
            {
                openAiResponseFunctionToolCallOutputOutputVariant1?.Invoke(OpenAiResponseFunctionToolCallOutputOutputVariant1!);
            }
            else if (IsOpenAiResponseFunctionToolCallOutputOutput1)
            {
                openAiResponseFunctionToolCallOutputOutput1?.Invoke(OpenAiResponseFunctionToolCallOutputOutput1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAiResponseFunctionToolCallOutputOutputVariant1,
                typeof(string),
                OpenAiResponseFunctionToolCallOutputOutput1,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1Items>),
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
        public bool Equals(OpenAiResponseFunctionToolCallOutputOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(OpenAiResponseFunctionToolCallOutputOutputVariant1, other.OpenAiResponseFunctionToolCallOutputOutputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1Items>?>.Default.Equals(OpenAiResponseFunctionToolCallOutputOutput1, other.OpenAiResponseFunctionToolCallOutputOutput1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OpenAiResponseFunctionToolCallOutputOutput obj1, OpenAiResponseFunctionToolCallOutputOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OpenAiResponseFunctionToolCallOutputOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OpenAiResponseFunctionToolCallOutputOutput obj1, OpenAiResponseFunctionToolCallOutputOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OpenAiResponseFunctionToolCallOutputOutput o && Equals(o);
        }
    }
}
