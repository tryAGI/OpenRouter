
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseInputsVariant2ItemRoleVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseInputsVariant2ItemRoleVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseInputsVariant2ItemRoleVariant3 value)
        {
            return value switch
            {
                BaseInputsVariant2ItemRoleVariant3.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseInputsVariant2ItemRoleVariant3? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => BaseInputsVariant2ItemRoleVariant3.Assistant,
                _ => null,
            };
        }
    }
}