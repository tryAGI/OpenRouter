
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: file_search_call.results
    /// </summary>
    public readonly partial struct ResponseIncludesEnum : global::System.IEquatable<ResponseIncludesEnum>
    {
        /// <summary>
        ///
        /// </summary>
        public ResponseIncludesEnum(string value)
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
        public static ResponseIncludesEnum CodeInterpreterCallOutputs { get; } = new("code_interpreter_call.outputs");

        /// <summary>
        ///
        /// </summary>
        public static ResponseIncludesEnum ComputerCallOutputOutputImageUrl { get; } = new("computer_call_output.output.image_url");

        /// <summary>
        ///
        /// </summary>
        public static ResponseIncludesEnum FileSearchCallResults { get; } = new("file_search_call.results");

        /// <summary>
        ///
        /// </summary>
        public static ResponseIncludesEnum MessageInputImageImageUrl { get; } = new("message.input_image.image_url");

        /// <summary>
        ///
        /// </summary>
        public static ResponseIncludesEnum ReasoningEncryptedContent { get; } = new("reasoning.encrypted_content");
        /// <summary>
        ///
        /// </summary>
        public static ResponseIncludesEnum FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "code_interpreter_call.outputs" => CodeInterpreterCallOutputs,
                "computer_call_output.output.image_url" => ComputerCallOutputOutputImageUrl,
                "file_search_call.results" => FileSearchCallResults,
                "message.input_image.image_url" => MessageInputImageImageUrl,
                "reasoning.encrypted_content" => ReasoningEncryptedContent,
                _ => new ResponseIncludesEnum(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "code_interpreter_call.outputs" => true,
            "computer_call_output.output.image_url" => true,
            "file_search_call.results" => true,
            "message.input_image.image_url" => true,
            "reasoning.encrypted_content" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ResponseIncludesEnum other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseIncludesEnum other && Equals(other);
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
        public static bool operator ==(ResponseIncludesEnum left, ResponseIncludesEnum right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponseIncludesEnum left, ResponseIncludesEnum right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseIncludesEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseIncludesEnum value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseIncludesEnum? ToEnum(string value)
        {
            return ResponseIncludesEnum.FromValue(value);
        }
    }
}