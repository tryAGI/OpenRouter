
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesContentBlockDeltaEventDeltaVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        SignatureDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesContentBlockDeltaEventDeltaVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesContentBlockDeltaEventDeltaVariant4Type value)
        {
            return value switch
            {
                MessagesContentBlockDeltaEventDeltaVariant4Type.SignatureDelta => "signature_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesContentBlockDeltaEventDeltaVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "signature_delta" => MessagesContentBlockDeltaEventDeltaVariant4Type.SignatureDelta,
                _ => null,
            };
        }
    }
}