
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatRequestResponseFormatDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Grammar,
        /// <summary>
        /// 
        /// </summary>
        JsonObject,
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
        /// <summary>
        /// 
        /// </summary>
        Python,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestResponseFormatDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestResponseFormatDiscriminatorType value)
        {
            return value switch
            {
                ChatRequestResponseFormatDiscriminatorType.Grammar => "grammar",
                ChatRequestResponseFormatDiscriminatorType.JsonObject => "json_object",
                ChatRequestResponseFormatDiscriminatorType.JsonSchema => "json_schema",
                ChatRequestResponseFormatDiscriminatorType.Python => "python",
                ChatRequestResponseFormatDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestResponseFormatDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "grammar" => ChatRequestResponseFormatDiscriminatorType.Grammar,
                "json_object" => ChatRequestResponseFormatDiscriminatorType.JsonObject,
                "json_schema" => ChatRequestResponseFormatDiscriminatorType.JsonSchema,
                "python" => ChatRequestResponseFormatDiscriminatorType.Python,
                "text" => ChatRequestResponseFormatDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}