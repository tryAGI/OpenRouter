
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseInputsVariant2ItemRoleVariant4
    {
        /// <summary>
        ///
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseInputsVariant2ItemRoleVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseInputsVariant2ItemRoleVariant4 value)
        {
            return value switch
            {
                BaseInputsVariant2ItemRoleVariant4.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseInputsVariant2ItemRoleVariant4? ToEnum(string value)
        {
            return value switch
            {
                "developer" => BaseInputsVariant2ItemRoleVariant4.Developer,
                _ => null,
            };
        }
    }
}