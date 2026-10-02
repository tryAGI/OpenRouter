
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OpenAIFilePurpose : global::System.IEquatable<OpenAIFilePurpose>
    {
        /// <summary>
        ///
        /// </summary>
        public OpenAIFilePurpose(string value)
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
        public static OpenAIFilePurpose Assistants { get; } = new("assistants");

        /// <summary>
        ///
        /// </summary>
        public static OpenAIFilePurpose AssistantsOutput { get; } = new("assistants_output");

        /// <summary>
        ///
        /// </summary>
        public static OpenAIFilePurpose Batch { get; } = new("batch");

        /// <summary>
        ///
        /// </summary>
        public static OpenAIFilePurpose BatchOutput { get; } = new("batch_output");

        /// <summary>
        ///
        /// </summary>
        public static OpenAIFilePurpose Evals { get; } = new("evals");

        /// <summary>
        ///
        /// </summary>
        public static OpenAIFilePurpose FineTune { get; } = new("fine-tune");

        /// <summary>
        ///
        /// </summary>
        public static OpenAIFilePurpose FineTuneResults { get; } = new("fine-tune-results");

        /// <summary>
        ///
        /// </summary>
        public static OpenAIFilePurpose UserData { get; } = new("user_data");

        /// <summary>
        ///
        /// </summary>
        public static OpenAIFilePurpose Vision { get; } = new("vision");
        /// <summary>
        ///
        /// </summary>
        public static OpenAIFilePurpose FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "assistants" => Assistants,
                "assistants_output" => AssistantsOutput,
                "batch" => Batch,
                "batch_output" => BatchOutput,
                "evals" => Evals,
                "fine-tune" => FineTune,
                "fine-tune-results" => FineTuneResults,
                "user_data" => UserData,
                "vision" => Vision,
                _ => new OpenAIFilePurpose(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "assistants" => true,
            "assistants_output" => true,
            "batch" => true,
            "batch_output" => true,
            "evals" => true,
            "fine-tune" => true,
            "fine-tune-results" => true,
            "user_data" => true,
            "vision" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(OpenAIFilePurpose other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OpenAIFilePurpose other && Equals(other);
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
        public static bool operator ==(OpenAIFilePurpose left, OpenAIFilePurpose right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OpenAIFilePurpose left, OpenAIFilePurpose right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIFilePurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIFilePurpose value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIFilePurpose? ToEnum(string value)
        {
            return OpenAIFilePurpose.FromValue(value);
        }
    }
}