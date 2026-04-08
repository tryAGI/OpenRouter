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
        public global::OpenRouter.AnthropicBase64PdfSource? AnthropicBase64PdfSource { get; init; }
#else
        public global::OpenRouter.AnthropicBase64PdfSource? AnthropicBase64PdfSource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicBase64PdfSource))]
#endif
        public bool IsAnthropicBase64PdfSource => AnthropicBase64PdfSource != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicPlainTextSource? AnthropicPlainTextSource { get; init; }
#else
        public global::OpenRouter.AnthropicPlainTextSource? AnthropicPlainTextSource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicPlainTextSource))]
#endif
        public bool IsAnthropicPlainTextSource => AnthropicPlainTextSource != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicDocumentBlockSource(global::OpenRouter.AnthropicBase64PdfSource value) => new AnthropicDocumentBlockSource((global::OpenRouter.AnthropicBase64PdfSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicBase64PdfSource?(AnthropicDocumentBlockSource @this) => @this.AnthropicBase64PdfSource;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicDocumentBlockSource(global::OpenRouter.AnthropicBase64PdfSource? value)
        {
            AnthropicBase64PdfSource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicDocumentBlockSource(global::OpenRouter.AnthropicPlainTextSource value) => new AnthropicDocumentBlockSource((global::OpenRouter.AnthropicPlainTextSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicPlainTextSource?(AnthropicDocumentBlockSource @this) => @this.AnthropicPlainTextSource;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicDocumentBlockSource(global::OpenRouter.AnthropicPlainTextSource? value)
        {
            AnthropicPlainTextSource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicDocumentBlockSource(
            global::OpenRouter.AnthropicBase64PdfSource? anthropicBase64PdfSource,
            global::OpenRouter.AnthropicPlainTextSource? anthropicPlainTextSource
            )
        {
            AnthropicBase64PdfSource = anthropicBase64PdfSource;
            AnthropicPlainTextSource = anthropicPlainTextSource;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicPlainTextSource as object ??
            AnthropicBase64PdfSource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicBase64PdfSource?.ToString() ??
            AnthropicPlainTextSource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicBase64PdfSource && !IsAnthropicPlainTextSource || !IsAnthropicBase64PdfSource && IsAnthropicPlainTextSource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicBase64PdfSource?, TResult>? anthropicBase64PdfSource = null,
            global::System.Func<global::OpenRouter.AnthropicPlainTextSource?, TResult>? anthropicPlainTextSource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicBase64PdfSource && anthropicBase64PdfSource != null)
            {
                return anthropicBase64PdfSource(AnthropicBase64PdfSource!);
            }
            else if (IsAnthropicPlainTextSource && anthropicPlainTextSource != null)
            {
                return anthropicPlainTextSource(AnthropicPlainTextSource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicBase64PdfSource?>? anthropicBase64PdfSource = null,
            global::System.Action<global::OpenRouter.AnthropicPlainTextSource?>? anthropicPlainTextSource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicBase64PdfSource)
            {
                anthropicBase64PdfSource?.Invoke(AnthropicBase64PdfSource!);
            }
            else if (IsAnthropicPlainTextSource)
            {
                anthropicPlainTextSource?.Invoke(AnthropicPlainTextSource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicBase64PdfSource,
                typeof(global::OpenRouter.AnthropicBase64PdfSource),
                AnthropicPlainTextSource,
                typeof(global::OpenRouter.AnthropicPlainTextSource),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicBase64PdfSource?>.Default.Equals(AnthropicBase64PdfSource, other.AnthropicBase64PdfSource) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicPlainTextSource?>.Default.Equals(AnthropicPlainTextSource, other.AnthropicPlainTextSource) 
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
