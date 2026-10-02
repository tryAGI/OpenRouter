#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OutputVariant2Item4 : global::System.IEquatable<OutputVariant2Item4>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallOutputOutputVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// Text input content item<br/>
        /// Example: {"text":"Hello, how can I help you?","type":"input_text"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputText? InputText { get; init; }
#else
        public global::OpenRouter.InputText? InputText { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputText))]
#endif
        public bool IsInputText => InputText != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.InputText? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputText PickInputText() => InputText is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");

        /// <summary>
        /// Image input content item. Provide either an image_url (a URL or a base64 data URL) or the file_id of an uploaded image.<br/>
        /// Example: {"detail":"auto","image_url":"https://example.com/image.jpg","type":"input_image"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputImage? InputImage { get; init; }
#else
        public global::OpenRouter.InputImage? InputImage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputImage))]
#endif
        public bool IsInputImage => InputImage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.InputImage? value)
        {
            value = InputImage;
            return IsInputImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputImage PickInputImage() => InputImage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputImage' but the value was {ToString()}.");

        /// <summary>
        /// File input content item<br/>
        /// Example: {"file_id":"file-abc123","filename":"document.pdf","type":"input_file"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputFile? InputFile { get; init; }
#else
        public global::OpenRouter.InputFile? InputFile { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFile))]
#endif
        public bool IsInputFile => InputFile != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.InputFile? value)
        {
            value = InputFile;
            return IsInputFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputFile PickInputFile() => InputFile is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFile' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputVariant2Item4(global::OpenRouter.InputText value) => new OutputVariant2Item4((global::OpenRouter.InputText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.InputText?(OutputVariant2Item4 @this) => @this.InputText;

        /// <summary>
        ///
        /// </summary>
        public OutputVariant2Item4(global::OpenRouter.InputText? value)
        {
            InputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputVariant2Item4 FromInputText(global::OpenRouter.InputText? value) => new OutputVariant2Item4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputVariant2Item4(global::OpenRouter.InputImage value) => new OutputVariant2Item4((global::OpenRouter.InputImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.InputImage?(OutputVariant2Item4 @this) => @this.InputImage;

        /// <summary>
        ///
        /// </summary>
        public OutputVariant2Item4(global::OpenRouter.InputImage? value)
        {
            InputImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputVariant2Item4 FromInputImage(global::OpenRouter.InputImage? value) => new OutputVariant2Item4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputVariant2Item4(global::OpenRouter.InputFile value) => new OutputVariant2Item4((global::OpenRouter.InputFile?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.InputFile?(OutputVariant2Item4 @this) => @this.InputFile;

        /// <summary>
        ///
        /// </summary>
        public OutputVariant2Item4(global::OpenRouter.InputFile? value)
        {
            InputFile = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputVariant2Item4 FromInputFile(global::OpenRouter.InputFile? value) => new OutputVariant2Item4(value);

        /// <summary>
        ///
        /// </summary>
        public OutputVariant2Item4(
            global::OpenRouter.OpenAIResponseFunctionToolCallOutputOutputVariant2ItemDiscriminatorType? type,
            global::OpenRouter.InputText? inputText,
            global::OpenRouter.InputImage? inputImage,
            global::OpenRouter.InputFile? inputFile
            )
        {
            Type = type;

            InputText = inputText;
            InputImage = inputImage;
            InputFile = inputFile;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            InputFile as object ??
            InputImage as object ??
            InputText as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() ??
            InputImage?.ToString() ??
            InputFile?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInputText && !IsInputImage && !IsInputFile || !IsInputText && IsInputImage && !IsInputFile || !IsInputText && !IsInputImage && IsInputFile;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.InputText, TResult>? inputText = null,
            global::System.Func<global::OpenRouter.InputImage, TResult>? inputImage = null,
            global::System.Func<global::OpenRouter.InputFile, TResult>? inputFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputText is { } __value0 && inputText != null)
            {
                return inputText(__value0);
            }
            else if (InputImage is { } __value1 && inputImage != null)
            {
                return inputImage(__value1);
            }
            else if (InputFile is { } __value2 && inputFile != null)
            {
                return inputFile(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.InputText>? inputText = null,

            global::System.Action<global::OpenRouter.InputImage>? inputImage = null,

            global::System.Action<global::OpenRouter.InputFile>? inputFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputText is { } __value0)
            {
                inputText?.Invoke(__value0);
            }
            else if (InputImage is { } __value1)
            {
                inputImage?.Invoke(__value1);
            }
            else if (InputFile is { } __value2)
            {
                inputFile?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.InputText>? inputText = null,
            global::System.Action<global::OpenRouter.InputImage>? inputImage = null,
            global::System.Action<global::OpenRouter.InputFile>? inputFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputText is { } __value0)
            {
                inputText?.Invoke(__value0);
            }
            else if (InputImage is { } __value1)
            {
                inputImage?.Invoke(__value1);
            }
            else if (InputFile is { } __value2)
            {
                inputFile?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputText,
                typeof(global::OpenRouter.InputText),
                InputImage,
                typeof(global::OpenRouter.InputImage),
                InputFile,
                typeof(global::OpenRouter.InputFile),
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
        public bool Equals(OutputVariant2Item4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputText?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputImage?>.Default.Equals(InputImage, other.InputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputFile?>.Default.Equals(InputFile, other.InputFile)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OutputVariant2Item4 obj1, OutputVariant2Item4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputVariant2Item4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputVariant2Item4 obj1, OutputVariant2Item4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputVariant2Item4 o && Equals(o);
        }
    }
}
