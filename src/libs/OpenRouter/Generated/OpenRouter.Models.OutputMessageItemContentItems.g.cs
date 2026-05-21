#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputMessageItemContentItems : global::System.IEquatable<OutputMessageItemContentItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ResponseOutputText? ResponseOutputText { get; init; }
#else
        public global::OpenRouter.ResponseOutputText? ResponseOutputText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputText))]
#endif
        public bool IsResponseOutputText => ResponseOutputText != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseOutputText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ResponseOutputText? value)
        {
            value = ResponseOutputText;
            return IsResponseOutputText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ResponseOutputText PickResponseOutputText() => IsResponseOutputText
            ? ResponseOutputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputText' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesRefusalContent? OpenAIResponsesRefusalContent { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesRefusalContent? OpenAIResponsesRefusalContent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIResponsesRefusalContent))]
#endif
        public bool IsOpenAIResponsesRefusalContent => OpenAIResponsesRefusalContent != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenAIResponsesRefusalContent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenAIResponsesRefusalContent? value)
        {
            value = OpenAIResponsesRefusalContent;
            return IsOpenAIResponsesRefusalContent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OpenAIResponsesRefusalContent PickOpenAIResponsesRefusalContent() => IsOpenAIResponsesRefusalContent
            ? OpenAIResponsesRefusalContent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponsesRefusalContent' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputMessageItemContentItems(global::OpenRouter.ResponseOutputText value) => new OutputMessageItemContentItems((global::OpenRouter.ResponseOutputText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ResponseOutputText?(OutputMessageItemContentItems @this) => @this.ResponseOutputText;

        /// <summary>
        /// 
        /// </summary>
        public OutputMessageItemContentItems(global::OpenRouter.ResponseOutputText? value)
        {
            ResponseOutputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputMessageItemContentItems FromResponseOutputText(global::OpenRouter.ResponseOutputText? value) => new OutputMessageItemContentItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputMessageItemContentItems(global::OpenRouter.OpenAIResponsesRefusalContent value) => new OutputMessageItemContentItems((global::OpenRouter.OpenAIResponsesRefusalContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesRefusalContent?(OutputMessageItemContentItems @this) => @this.OpenAIResponsesRefusalContent;

        /// <summary>
        /// 
        /// </summary>
        public OutputMessageItemContentItems(global::OpenRouter.OpenAIResponsesRefusalContent? value)
        {
            OpenAIResponsesRefusalContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputMessageItemContentItems FromOpenAIResponsesRefusalContent(global::OpenRouter.OpenAIResponsesRefusalContent? value) => new OutputMessageItemContentItems(value);

        /// <summary>
        /// 
        /// </summary>
        public OutputMessageItemContentItems(
            global::OpenRouter.ResponseOutputText? responseOutputText,
            global::OpenRouter.OpenAIResponsesRefusalContent? openAIResponsesRefusalContent
            )
        {
            ResponseOutputText = responseOutputText;
            OpenAIResponsesRefusalContent = openAIResponsesRefusalContent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OpenAIResponsesRefusalContent as object ??
            ResponseOutputText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResponseOutputText?.ToString() ??
            OpenAIResponsesRefusalContent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponseOutputText && !IsOpenAIResponsesRefusalContent || !IsResponseOutputText && IsOpenAIResponsesRefusalContent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ResponseOutputText, TResult>? responseOutputText = null,
            global::System.Func<global::OpenRouter.OpenAIResponsesRefusalContent, TResult>? openAIResponsesRefusalContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseOutputText && responseOutputText != null)
            {
                return responseOutputText(ResponseOutputText!);
            }
            else if (IsOpenAIResponsesRefusalContent && openAIResponsesRefusalContent != null)
            {
                return openAIResponsesRefusalContent(OpenAIResponsesRefusalContent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ResponseOutputText>? responseOutputText = null,

            global::System.Action<global::OpenRouter.OpenAIResponsesRefusalContent>? openAIResponsesRefusalContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseOutputText)
            {
                responseOutputText?.Invoke(ResponseOutputText!);
            }
            else if (IsOpenAIResponsesRefusalContent)
            {
                openAIResponsesRefusalContent?.Invoke(OpenAIResponsesRefusalContent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ResponseOutputText>? responseOutputText = null,
            global::System.Action<global::OpenRouter.OpenAIResponsesRefusalContent>? openAIResponsesRefusalContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseOutputText)
            {
                responseOutputText?.Invoke(ResponseOutputText!);
            }
            else if (IsOpenAIResponsesRefusalContent)
            {
                openAIResponsesRefusalContent?.Invoke(OpenAIResponsesRefusalContent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponseOutputText,
                typeof(global::OpenRouter.ResponseOutputText),
                OpenAIResponsesRefusalContent,
                typeof(global::OpenRouter.OpenAIResponsesRefusalContent),
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
        public bool Equals(OutputMessageItemContentItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ResponseOutputText?>.Default.Equals(ResponseOutputText, other.ResponseOutputText) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesRefusalContent?>.Default.Equals(OpenAIResponsesRefusalContent, other.OpenAIResponsesRefusalContent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputMessageItemContentItems obj1, OutputMessageItemContentItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputMessageItemContentItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputMessageItemContentItems obj1, OutputMessageItemContentItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputMessageItemContentItems o && Equals(o);
        }
    }
}
