
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum PresetWithDesignatedVersionStatus
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
    public static class PresetWithDesignatedVersionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PresetWithDesignatedVersionStatus value)
        {
            return value switch
            {
                PresetWithDesignatedVersionStatus.Active => "active",
                PresetWithDesignatedVersionStatus.Archived => "archived",
                PresetWithDesignatedVersionStatus.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PresetWithDesignatedVersionStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => PresetWithDesignatedVersionStatus.Active,
                "archived" => PresetWithDesignatedVersionStatus.Archived,
                "disabled" => PresetWithDesignatedVersionStatus.Disabled,
                _ => null,
            };
        }
    }
}