
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum EasyInputMessageRoleVariant4
    {
        /// <summary>
        ///
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EasyInputMessageRoleVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EasyInputMessageRoleVariant4 value)
        {
            return value switch
            {
                EasyInputMessageRoleVariant4.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EasyInputMessageRoleVariant4? ToEnum(string value)
        {
            return value switch
            {
                "developer" => EasyInputMessageRoleVariant4.Developer,
                _ => null,
            };
        }
    }
}