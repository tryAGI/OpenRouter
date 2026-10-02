
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Default Value: message
    /// </summary>
    public enum InputsVariant2ItemVariant8Type
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputsVariant2ItemVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputsVariant2ItemVariant8Type value)
        {
            return value switch
            {
                InputsVariant2ItemVariant8Type.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputsVariant2ItemVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "message" => InputsVariant2ItemVariant8Type.Message,
                _ => null,
            };
        }
    }
}