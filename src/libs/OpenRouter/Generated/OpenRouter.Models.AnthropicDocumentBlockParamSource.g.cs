#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnthropicDocumentBlockParamSource : global::System.IEquatable<AnthropicDocumentBlockParamSource>
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
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicDocumentBlockParamSource2? AnthropicDocumentBlockParamSource2 { get; init; }
#else
        public global::OpenRouter.AnthropicDocumentBlockParamSource2? AnthropicDocumentBlockParamSource2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicDocumentBlockParamSource2))]
#endif
        public bool IsAnthropicDocumentBlockParamSource2 => AnthropicDocumentBlockParamSource2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicUrlPdfSource? AnthropicUrlPdfSource { get; init; }
#else
        public global::OpenRouter.AnthropicUrlPdfSource? AnthropicUrlPdfSource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicUrlPdfSource))]
#endif
        public bool IsAnthropicUrlPdfSource => AnthropicUrlPdfSource != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicDocumentBlockParamSource(global::OpenRouter.AnthropicBase64PdfSource value) => new AnthropicDocumentBlockParamSource((global::OpenRouter.AnthropicBase64PdfSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicBase64PdfSource?(AnthropicDocumentBlockParamSource @this) => @this.AnthropicBase64PdfSource;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicDocumentBlockParamSource(global::OpenRouter.AnthropicBase64PdfSource? value)
        {
            AnthropicBase64PdfSource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicDocumentBlockParamSource(global::OpenRouter.AnthropicPlainTextSource value) => new AnthropicDocumentBlockParamSource((global::OpenRouter.AnthropicPlainTextSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicPlainTextSource?(AnthropicDocumentBlockParamSource @this) => @this.AnthropicPlainTextSource;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicDocumentBlockParamSource(global::OpenRouter.AnthropicPlainTextSource? value)
        {
            AnthropicPlainTextSource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicDocumentBlockParamSource(global::OpenRouter.AnthropicDocumentBlockParamSource2 value) => new AnthropicDocumentBlockParamSource((global::OpenRouter.AnthropicDocumentBlockParamSource2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicDocumentBlockParamSource2?(AnthropicDocumentBlockParamSource @this) => @this.AnthropicDocumentBlockParamSource2;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicDocumentBlockParamSource(global::OpenRouter.AnthropicDocumentBlockParamSource2? value)
        {
            AnthropicDocumentBlockParamSource2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicDocumentBlockParamSource(global::OpenRouter.AnthropicUrlPdfSource value) => new AnthropicDocumentBlockParamSource((global::OpenRouter.AnthropicUrlPdfSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicUrlPdfSource?(AnthropicDocumentBlockParamSource @this) => @this.AnthropicUrlPdfSource;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicDocumentBlockParamSource(global::OpenRouter.AnthropicUrlPdfSource? value)
        {
            AnthropicUrlPdfSource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicDocumentBlockParamSource(
            global::OpenRouter.AnthropicBase64PdfSource? anthropicBase64PdfSource,
            global::OpenRouter.AnthropicPlainTextSource? anthropicPlainTextSource,
            global::OpenRouter.AnthropicDocumentBlockParamSource2? anthropicDocumentBlockParamSource2,
            global::OpenRouter.AnthropicUrlPdfSource? anthropicUrlPdfSource
            )
        {
            AnthropicBase64PdfSource = anthropicBase64PdfSource;
            AnthropicPlainTextSource = anthropicPlainTextSource;
            AnthropicDocumentBlockParamSource2 = anthropicDocumentBlockParamSource2;
            AnthropicUrlPdfSource = anthropicUrlPdfSource;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicUrlPdfSource as object ??
            AnthropicDocumentBlockParamSource2 as object ??
            AnthropicPlainTextSource as object ??
            AnthropicBase64PdfSource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicBase64PdfSource?.ToString() ??
            AnthropicPlainTextSource?.ToString() ??
            AnthropicDocumentBlockParamSource2?.ToString() ??
            AnthropicUrlPdfSource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicBase64PdfSource && !IsAnthropicPlainTextSource && !IsAnthropicDocumentBlockParamSource2 && !IsAnthropicUrlPdfSource || !IsAnthropicBase64PdfSource && IsAnthropicPlainTextSource && !IsAnthropicDocumentBlockParamSource2 && !IsAnthropicUrlPdfSource || !IsAnthropicBase64PdfSource && !IsAnthropicPlainTextSource && IsAnthropicDocumentBlockParamSource2 && !IsAnthropicUrlPdfSource || !IsAnthropicBase64PdfSource && !IsAnthropicPlainTextSource && !IsAnthropicDocumentBlockParamSource2 && IsAnthropicUrlPdfSource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicBase64PdfSource?, TResult>? anthropicBase64PdfSource = null,
            global::System.Func<global::OpenRouter.AnthropicPlainTextSource?, TResult>? anthropicPlainTextSource = null,
            global::System.Func<global::OpenRouter.AnthropicDocumentBlockParamSource2?, TResult>? anthropicDocumentBlockParamSource2 = null,
            global::System.Func<global::OpenRouter.AnthropicUrlPdfSource?, TResult>? anthropicUrlPdfSource = null,
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
            else if (IsAnthropicDocumentBlockParamSource2 && anthropicDocumentBlockParamSource2 != null)
            {
                return anthropicDocumentBlockParamSource2(AnthropicDocumentBlockParamSource2!);
            }
            else if (IsAnthropicUrlPdfSource && anthropicUrlPdfSource != null)
            {
                return anthropicUrlPdfSource(AnthropicUrlPdfSource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicBase64PdfSource?>? anthropicBase64PdfSource = null,
            global::System.Action<global::OpenRouter.AnthropicPlainTextSource?>? anthropicPlainTextSource = null,
            global::System.Action<global::OpenRouter.AnthropicDocumentBlockParamSource2?>? anthropicDocumentBlockParamSource2 = null,
            global::System.Action<global::OpenRouter.AnthropicUrlPdfSource?>? anthropicUrlPdfSource = null,
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
            else if (IsAnthropicDocumentBlockParamSource2)
            {
                anthropicDocumentBlockParamSource2?.Invoke(AnthropicDocumentBlockParamSource2!);
            }
            else if (IsAnthropicUrlPdfSource)
            {
                anthropicUrlPdfSource?.Invoke(AnthropicUrlPdfSource!);
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
                AnthropicDocumentBlockParamSource2,
                typeof(global::OpenRouter.AnthropicDocumentBlockParamSource2),
                AnthropicUrlPdfSource,
                typeof(global::OpenRouter.AnthropicUrlPdfSource),
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
        public bool Equals(AnthropicDocumentBlockParamSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicBase64PdfSource?>.Default.Equals(AnthropicBase64PdfSource, other.AnthropicBase64PdfSource) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicPlainTextSource?>.Default.Equals(AnthropicPlainTextSource, other.AnthropicPlainTextSource) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicDocumentBlockParamSource2?>.Default.Equals(AnthropicDocumentBlockParamSource2, other.AnthropicDocumentBlockParamSource2) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicUrlPdfSource?>.Default.Equals(AnthropicUrlPdfSource, other.AnthropicUrlPdfSource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicDocumentBlockParamSource obj1, AnthropicDocumentBlockParamSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicDocumentBlockParamSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicDocumentBlockParamSource obj1, AnthropicDocumentBlockParamSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicDocumentBlockParamSource o && Equals(o);
        }
    }
}
