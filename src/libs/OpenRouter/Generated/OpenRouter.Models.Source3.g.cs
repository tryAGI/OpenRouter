#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Source3 : global::System.IEquatable<Source3>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParamSourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"data":"/9j/4AAQ...","media_type":"image/jpeg","type":"base64"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicBase64ImageSource? Base64 { get; init; }
#else
        public global::OpenRouter.AnthropicBase64ImageSource? Base64 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base64))]
#endif
        public bool IsBase64 => Base64 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBase64(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicBase64ImageSource? value)
        {
            value = Base64;
            return IsBase64;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBase64ImageSource PickBase64() => Base64 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base64' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"type":"url","url":"https://example.com/image.jpg"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicUrlImageSource? Url { get; init; }
#else
        public global::OpenRouter.AnthropicUrlImageSource? Url { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Url))]
#endif
        public bool IsUrl => Url != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUrl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicUrlImageSource? value)
        {
            value = Url;
            return IsUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUrlImageSource PickUrl() => Url is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Url' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"file_id":"or_file_011CNha8iCJcU1wXNR6q4V8w","type":"file"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicFileDocumentSource? File { get; init; }
#else
        public global::OpenRouter.AnthropicFileDocumentSource? File { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicFileDocumentSource? value)
        {
            value = File;
            return IsFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileDocumentSource PickFile() => File is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'File' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source3(global::OpenRouter.AnthropicBase64ImageSource value) => new Source3((global::OpenRouter.AnthropicBase64ImageSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicBase64ImageSource?(Source3 @this) => @this.Base64;

        /// <summary>
        ///
        /// </summary>
        public Source3(global::OpenRouter.AnthropicBase64ImageSource? value)
        {
            Base64 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source3 FromBase64(global::OpenRouter.AnthropicBase64ImageSource? value) => new Source3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source3(global::OpenRouter.AnthropicUrlImageSource value) => new Source3((global::OpenRouter.AnthropicUrlImageSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicUrlImageSource?(Source3 @this) => @this.Url;

        /// <summary>
        ///
        /// </summary>
        public Source3(global::OpenRouter.AnthropicUrlImageSource? value)
        {
            Url = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source3 FromUrl(global::OpenRouter.AnthropicUrlImageSource? value) => new Source3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source3(global::OpenRouter.AnthropicFileDocumentSource value) => new Source3((global::OpenRouter.AnthropicFileDocumentSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicFileDocumentSource?(Source3 @this) => @this.File;

        /// <summary>
        ///
        /// </summary>
        public Source3(global::OpenRouter.AnthropicFileDocumentSource? value)
        {
            File = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source3 FromFile(global::OpenRouter.AnthropicFileDocumentSource? value) => new Source3(value);

        /// <summary>
        ///
        /// </summary>
        public Source3(
            global::OpenRouter.AnthropicImageBlockParamSourceDiscriminatorType? type,
            global::OpenRouter.AnthropicBase64ImageSource? base64,
            global::OpenRouter.AnthropicUrlImageSource? url,
            global::OpenRouter.AnthropicFileDocumentSource? file
            )
        {
            Type = type;

            Base64 = base64;
            Url = url;
            File = file;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            File as object ??
            Url as object ??
            Base64 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base64?.ToString() ??
            Url?.ToString() ??
            File?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase64 && !IsUrl && !IsFile || !IsBase64 && IsUrl && !IsFile || !IsBase64 && !IsUrl && IsFile;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicBase64ImageSource, TResult>? base64 = null,
            global::System.Func<global::OpenRouter.AnthropicUrlImageSource, TResult>? url = null,
            global::System.Func<global::OpenRouter.AnthropicFileDocumentSource, TResult>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base64 is { } __value0 && base64 != null)
            {
                return base64(__value0);
            }
            else if (Url is { } __value1 && url != null)
            {
                return url(__value1);
            }
            else if (File is { } __value2 && file != null)
            {
                return file(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicBase64ImageSource>? base64 = null,

            global::System.Action<global::OpenRouter.AnthropicUrlImageSource>? url = null,

            global::System.Action<global::OpenRouter.AnthropicFileDocumentSource>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base64 is { } __value0)
            {
                base64?.Invoke(__value0);
            }
            else if (Url is { } __value1)
            {
                url?.Invoke(__value1);
            }
            else if (File is { } __value2)
            {
                file?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicBase64ImageSource>? base64 = null,
            global::System.Action<global::OpenRouter.AnthropicUrlImageSource>? url = null,
            global::System.Action<global::OpenRouter.AnthropicFileDocumentSource>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base64 is { } __value0)
            {
                base64?.Invoke(__value0);
            }
            else if (Url is { } __value1)
            {
                url?.Invoke(__value1);
            }
            else if (File is { } __value2)
            {
                file?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base64,
                typeof(global::OpenRouter.AnthropicBase64ImageSource),
                Url,
                typeof(global::OpenRouter.AnthropicUrlImageSource),
                File,
                typeof(global::OpenRouter.AnthropicFileDocumentSource),
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
        public bool Equals(Source3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicBase64ImageSource?>.Default.Equals(Base64, other.Base64) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicUrlImageSource?>.Default.Equals(Url, other.Url) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicFileDocumentSource?>.Default.Equals(File, other.File)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Source3 obj1, Source3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Source3 obj1, Source3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source3 o && Equals(o);
        }
    }
}
