#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OutputsItem : global::System.IEquatable<OutputsItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCodeInterpreterCallOutputDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"logs":"hello\n","type":"logs"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CodeInterpreterLogsOutput? Logs { get; init; }
#else
        public global::OpenRouter.CodeInterpreterLogsOutput? Logs { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Logs))]
#endif
        public bool IsLogs => Logs != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLogs(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CodeInterpreterLogsOutput? value)
        {
            value = Logs;
            return IsLogs;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterLogsOutput PickLogs() => Logs is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Logs' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"type":"image","url":"https://example.com/plot.png"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CodeInterpreterImageOutput? Image { get; init; }
#else
        public global::OpenRouter.CodeInterpreterImageOutput? Image { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CodeInterpreterImageOutput? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterImageOutput PickImage() => Image is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"download_url":"https://example.com/download/file_abc123","filename":"summary.txt","id":"file_abc123","type":"file"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CodeInterpreterFileOutput? File { get; init; }
#else
        public global::OpenRouter.CodeInterpreterFileOutput? File { get; }
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
            out global::OpenRouter.CodeInterpreterFileOutput? value)
        {
            value = File;
            return IsFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterFileOutput PickFile() => File is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'File' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputsItem(global::OpenRouter.CodeInterpreterLogsOutput value) => new OutputsItem((global::OpenRouter.CodeInterpreterLogsOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.CodeInterpreterLogsOutput?(OutputsItem @this) => @this.Logs;

        /// <summary>
        ///
        /// </summary>
        public OutputsItem(global::OpenRouter.CodeInterpreterLogsOutput? value)
        {
            Logs = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputsItem FromLogs(global::OpenRouter.CodeInterpreterLogsOutput? value) => new OutputsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputsItem(global::OpenRouter.CodeInterpreterImageOutput value) => new OutputsItem((global::OpenRouter.CodeInterpreterImageOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.CodeInterpreterImageOutput?(OutputsItem @this) => @this.Image;

        /// <summary>
        ///
        /// </summary>
        public OutputsItem(global::OpenRouter.CodeInterpreterImageOutput? value)
        {
            Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputsItem FromImage(global::OpenRouter.CodeInterpreterImageOutput? value) => new OutputsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputsItem(global::OpenRouter.CodeInterpreterFileOutput value) => new OutputsItem((global::OpenRouter.CodeInterpreterFileOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.CodeInterpreterFileOutput?(OutputsItem @this) => @this.File;

        /// <summary>
        ///
        /// </summary>
        public OutputsItem(global::OpenRouter.CodeInterpreterFileOutput? value)
        {
            File = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputsItem FromFile(global::OpenRouter.CodeInterpreterFileOutput? value) => new OutputsItem(value);

        /// <summary>
        ///
        /// </summary>
        public OutputsItem(
            global::OpenRouter.OutputItemCodeInterpreterCallOutputDiscriminatorType? type,
            global::OpenRouter.CodeInterpreterLogsOutput? logs,
            global::OpenRouter.CodeInterpreterImageOutput? image,
            global::OpenRouter.CodeInterpreterFileOutput? file
            )
        {
            Type = type;

            Logs = logs;
            Image = image;
            File = file;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            File as object ??
            Image as object ??
            Logs as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Logs?.ToString() ??
            Image?.ToString() ??
            File?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsLogs && !IsImage && !IsFile || !IsLogs && IsImage && !IsFile || !IsLogs && !IsImage && IsFile;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.CodeInterpreterLogsOutput, TResult>? logs = null,
            global::System.Func<global::OpenRouter.CodeInterpreterImageOutput, TResult>? image = null,
            global::System.Func<global::OpenRouter.CodeInterpreterFileOutput, TResult>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Logs is { } __value0 && logs != null)
            {
                return logs(__value0);
            }
            else if (Image is { } __value1 && image != null)
            {
                return image(__value1);
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
            global::System.Action<global::OpenRouter.CodeInterpreterLogsOutput>? logs = null,

            global::System.Action<global::OpenRouter.CodeInterpreterImageOutput>? image = null,

            global::System.Action<global::OpenRouter.CodeInterpreterFileOutput>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Logs is { } __value0)
            {
                logs?.Invoke(__value0);
            }
            else if (Image is { } __value1)
            {
                image?.Invoke(__value1);
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
            global::System.Action<global::OpenRouter.CodeInterpreterLogsOutput>? logs = null,
            global::System.Action<global::OpenRouter.CodeInterpreterImageOutput>? image = null,
            global::System.Action<global::OpenRouter.CodeInterpreterFileOutput>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Logs is { } __value0)
            {
                logs?.Invoke(__value0);
            }
            else if (Image is { } __value1)
            {
                image?.Invoke(__value1);
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
                Logs,
                typeof(global::OpenRouter.CodeInterpreterLogsOutput),
                Image,
                typeof(global::OpenRouter.CodeInterpreterImageOutput),
                File,
                typeof(global::OpenRouter.CodeInterpreterFileOutput),
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
        public bool Equals(OutputsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CodeInterpreterLogsOutput?>.Default.Equals(Logs, other.Logs) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CodeInterpreterImageOutput?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CodeInterpreterFileOutput?>.Default.Equals(File, other.File)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OutputsItem obj1, OutputsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputsItem obj1, OutputsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputsItem o && Equals(o);
        }
    }
}
