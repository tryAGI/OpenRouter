#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnthropicDocumentBlockSource : global::System.IEquatable<AnthropicDocumentBlockSource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicBase64PDFSource2? AnthropicBase64PDFSource { get; init; }
#else
        public global::OpenRouter.AnthropicBase64PDFSource2? AnthropicBase64PDFSource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicBase64PDFSource))]
#endif
        public bool IsAnthropicBase64PDFSource => AnthropicBase64PDFSource != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicPlainTextSourceResponse? AnthropicPlainTextSourceResponse { get; init; }
#else
        public global::OpenRouter.AnthropicPlainTextSourceResponse? AnthropicPlainTextSourceResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicPlainTextSourceResponse))]
#endif
        public bool IsAnthropicPlainTextSourceResponse => AnthropicPlainTextSourceResponse != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicDocumentBlockSource(global::OpenRouter.AnthropicBase64PDFSource2 value) => new AnthropicDocumentBlockSource((global::OpenRouter.AnthropicBase64PDFSource2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicBase64PDFSource2?(AnthropicDocumentBlockSource @this) => @this.AnthropicBase64PDFSource;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicDocumentBlockSource(global::OpenRouter.AnthropicBase64PDFSource2? value)
        {
            AnthropicBase64PDFSource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicDocumentBlockSource(global::OpenRouter.AnthropicPlainTextSourceResponse value) => new AnthropicDocumentBlockSource((global::OpenRouter.AnthropicPlainTextSourceResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicPlainTextSourceResponse?(AnthropicDocumentBlockSource @this) => @this.AnthropicPlainTextSourceResponse;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicDocumentBlockSource(global::OpenRouter.AnthropicPlainTextSourceResponse? value)
        {
            AnthropicPlainTextSourceResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicDocumentBlockSource(
            global::OpenRouter.AnthropicBase64PDFSource2? anthropicBase64PDFSource,
            global::OpenRouter.AnthropicPlainTextSourceResponse? anthropicPlainTextSourceResponse
            )
        {
            AnthropicBase64PDFSource = anthropicBase64PDFSource;
            AnthropicPlainTextSourceResponse = anthropicPlainTextSourceResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicPlainTextSourceResponse as object ??
            AnthropicBase64PDFSource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicBase64PDFSource?.ToString() ??
            AnthropicPlainTextSourceResponse?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicBase64PDFSource && !IsAnthropicPlainTextSourceResponse || !IsAnthropicBase64PDFSource && IsAnthropicPlainTextSourceResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicBase64PDFSource2?, TResult>? anthropicBase64PDFSource = null,
            global::System.Func<global::OpenRouter.AnthropicPlainTextSourceResponse?, TResult>? anthropicPlainTextSourceResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicBase64PDFSource && anthropicBase64PDFSource != null)
            {
                return anthropicBase64PDFSource(AnthropicBase64PDFSource!);
            }
            else if (IsAnthropicPlainTextSourceResponse && anthropicPlainTextSourceResponse != null)
            {
                return anthropicPlainTextSourceResponse(AnthropicPlainTextSourceResponse!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicBase64PDFSource2?>? anthropicBase64PDFSource = null,
            global::System.Action<global::OpenRouter.AnthropicPlainTextSourceResponse?>? anthropicPlainTextSourceResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicBase64PDFSource)
            {
                anthropicBase64PDFSource?.Invoke(AnthropicBase64PDFSource!);
            }
            else if (IsAnthropicPlainTextSourceResponse)
            {
                anthropicPlainTextSourceResponse?.Invoke(AnthropicPlainTextSourceResponse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicBase64PDFSource,
                typeof(global::OpenRouter.AnthropicBase64PDFSource2),
                AnthropicPlainTextSourceResponse,
                typeof(global::OpenRouter.AnthropicPlainTextSourceResponse),
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
        public bool Equals(AnthropicDocumentBlockSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicBase64PDFSource2?>.Default.Equals(AnthropicBase64PDFSource, other.AnthropicBase64PDFSource) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicPlainTextSourceResponse?>.Default.Equals(AnthropicPlainTextSourceResponse, other.AnthropicPlainTextSourceResponse) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicDocumentBlockSource obj1, AnthropicDocumentBlockSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicDocumentBlockSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicDocumentBlockSource obj1, AnthropicDocumentBlockSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicDocumentBlockSource o && Equals(o);
        }
    }
}
