
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ModelInputV2Variant5ParamsFormatsValue : global::System.IEquatable<ModelInputV2Variant5ParamsFormatsValue>
    {
        /// <summary>
        ///
        /// </summary>
        public ModelInputV2Variant5ParamsFormatsValue(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2Variant5ParamsFormatsValue ApplicationJson { get; } = new("application/json");

        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2Variant5ParamsFormatsValue ApplicationPdf { get; } = new("application/pdf");

        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2Variant5ParamsFormatsValue TextCsv { get; } = new("text/csv");

        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2Variant5ParamsFormatsValue TextHtml { get; } = new("text/html");

        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2Variant5ParamsFormatsValue TextMarkdown { get; } = new("text/markdown");

        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2Variant5ParamsFormatsValue TextPlain { get; } = new("text/plain");
        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2Variant5ParamsFormatsValue FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "application/json" => ApplicationJson,
                "application/pdf" => ApplicationPdf,
                "text/csv" => TextCsv,
                "text/html" => TextHtml,
                "text/markdown" => TextMarkdown,
                "text/plain" => TextPlain,
                _ => new ModelInputV2Variant5ParamsFormatsValue(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "application/json" => true,
            "application/pdf" => true,
            "text/csv" => true,
            "text/html" => true,
            "text/markdown" => true,
            "text/plain" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ModelInputV2Variant5ParamsFormatsValue other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelInputV2Variant5ParamsFormatsValue other && Equals(other);
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ModelInputV2Variant5ParamsFormatsValue left, ModelInputV2Variant5ParamsFormatsValue right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ModelInputV2Variant5ParamsFormatsValue left, ModelInputV2Variant5ParamsFormatsValue right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelInputV2Variant5ParamsFormatsValueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelInputV2Variant5ParamsFormatsValue value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelInputV2Variant5ParamsFormatsValue? ToEnum(string value)
        {
            return ModelInputV2Variant5ParamsFormatsValue.FromValue(value);
        }
    }
}