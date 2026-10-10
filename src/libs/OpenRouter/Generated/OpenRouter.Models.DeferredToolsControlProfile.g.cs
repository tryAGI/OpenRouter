
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Loading profile. Only `portable` is available in this release: OpenRouter serves deferral with router-built search and call wrappers on any model.
    /// </summary>
    public enum DeferredToolsControlProfile
    {
        /// <summary>
        /// OpenRouter serves deferral with router-built search and call wrappers on any model.
        /// </summary>
        Portable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeferredToolsControlProfileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeferredToolsControlProfile value)
        {
            return value switch
            {
                DeferredToolsControlProfile.Portable => "portable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeferredToolsControlProfile? ToEnum(string value)
        {
            return value switch
            {
                "portable" => DeferredToolsControlProfile.Portable,
                _ => null,
            };
        }
    }
}