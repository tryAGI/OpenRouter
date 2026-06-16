
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The status of a preset.
    /// </summary>
    public enum PresetStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Archived,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PresetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PresetStatus value)
        {
            return value switch
            {
                PresetStatus.Active => "active",
                PresetStatus.Archived => "archived",
                PresetStatus.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PresetStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => PresetStatus.Active,
                "archived" => PresetStatus.Archived,
                "disabled" => PresetStatus.Disabled,
                _ => null,
            };
        }
    }
}