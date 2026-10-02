#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The engine to use for parsing PDF files. "pdf-text" is deprecated and automatically redirected to "cloudflare-ai".<br/>
    /// Example: cloudflare-ai
    /// </summary>
    public readonly partial struct PDFParserEngine : global::System.IEquatable<PDFParserEngine>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.PDFParserEngineVariant1? PDFParserEngineVariant1 { get; init; }
#else
        public global::OpenRouter.PDFParserEngineVariant1? PDFParserEngineVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PDFParserEngineVariant1))]
#endif
        public bool IsPDFParserEngineVariant1 => PDFParserEngineVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPDFParserEngineVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.PDFParserEngineVariant1? value)
        {
            value = PDFParserEngineVariant1;
            return IsPDFParserEngineVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PDFParserEngineVariant1 PickPDFParserEngineVariant1() => PDFParserEngineVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PDFParserEngineVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.PDFParserEngineVariant2? PDFParserEngineVariant2 { get; init; }
#else
        public global::OpenRouter.PDFParserEngineVariant2? PDFParserEngineVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PDFParserEngineVariant2))]
#endif
        public bool IsPDFParserEngineVariant2 => PDFParserEngineVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPDFParserEngineVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.PDFParserEngineVariant2? value)
        {
            value = PDFParserEngineVariant2;
            return IsPDFParserEngineVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PDFParserEngineVariant2 PickPDFParserEngineVariant2() => PDFParserEngineVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PDFParserEngineVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PDFParserEngine(global::OpenRouter.PDFParserEngineVariant1 value) => new PDFParserEngine((global::OpenRouter.PDFParserEngineVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.PDFParserEngineVariant1?(PDFParserEngine @this) => @this.PDFParserEngineVariant1;

        /// <summary>
        ///
        /// </summary>
        public PDFParserEngine(global::OpenRouter.PDFParserEngineVariant1? value)
        {
            PDFParserEngineVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PDFParserEngine FromPDFParserEngineVariant1(global::OpenRouter.PDFParserEngineVariant1? value) => new PDFParserEngine(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PDFParserEngine(global::OpenRouter.PDFParserEngineVariant2 value) => new PDFParserEngine((global::OpenRouter.PDFParserEngineVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.PDFParserEngineVariant2?(PDFParserEngine @this) => @this.PDFParserEngineVariant2;

        /// <summary>
        ///
        /// </summary>
        public PDFParserEngine(global::OpenRouter.PDFParserEngineVariant2? value)
        {
            PDFParserEngineVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PDFParserEngine FromPDFParserEngineVariant2(global::OpenRouter.PDFParserEngineVariant2? value) => new PDFParserEngine(value);

        /// <summary>
        ///
        /// </summary>
        public PDFParserEngine(
            global::OpenRouter.PDFParserEngineVariant1? pDFParserEngineVariant1,
            global::OpenRouter.PDFParserEngineVariant2? pDFParserEngineVariant2
            )
        {
            PDFParserEngineVariant1 = pDFParserEngineVariant1;
            PDFParserEngineVariant2 = pDFParserEngineVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PDFParserEngineVariant2 as object ??
            PDFParserEngineVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PDFParserEngineVariant1?.ToValueString() ??
            PDFParserEngineVariant2?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPDFParserEngineVariant1 || IsPDFParserEngineVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.PDFParserEngineVariant1?, TResult>? pDFParserEngineVariant1 = null,
            global::System.Func<global::OpenRouter.PDFParserEngineVariant2?, TResult>? pDFParserEngineVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PDFParserEngineVariant1 is { } __value0 && pDFParserEngineVariant1 != null)
            {
                return pDFParserEngineVariant1(__value0);
            }
            else if (PDFParserEngineVariant2 is { } __value1 && pDFParserEngineVariant2 != null)
            {
                return pDFParserEngineVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.PDFParserEngineVariant1?>? pDFParserEngineVariant1 = null,

            global::System.Action<global::OpenRouter.PDFParserEngineVariant2?>? pDFParserEngineVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PDFParserEngineVariant1 is { } __value0)
            {
                pDFParserEngineVariant1?.Invoke(__value0);
            }
            else if (PDFParserEngineVariant2 is { } __value1)
            {
                pDFParserEngineVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.PDFParserEngineVariant1?>? pDFParserEngineVariant1 = null,
            global::System.Action<global::OpenRouter.PDFParserEngineVariant2?>? pDFParserEngineVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PDFParserEngineVariant1 is { } __value0)
            {
                pDFParserEngineVariant1?.Invoke(__value0);
            }
            else if (PDFParserEngineVariant2 is { } __value1)
            {
                pDFParserEngineVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PDFParserEngineVariant1,
                typeof(global::OpenRouter.PDFParserEngineVariant1),
                PDFParserEngineVariant2,
                typeof(global::OpenRouter.PDFParserEngineVariant2),
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
        public bool Equals(PDFParserEngine other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.PDFParserEngineVariant1?>.Default.Equals(PDFParserEngineVariant1, other.PDFParserEngineVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.PDFParserEngineVariant2?>.Default.Equals(PDFParserEngineVariant2, other.PDFParserEngineVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PDFParserEngine obj1, PDFParserEngine obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PDFParserEngine>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PDFParserEngine obj1, PDFParserEngine obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PDFParserEngine o && Equals(o);
        }
    }
}
