
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Dataset version.
    /// </summary>
    public enum SessionCostMetaVersion
    {
        /// <summary>
        ///
        /// </summary>
        V1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionCostMetaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionCostMetaVersion value)
        {
            return value switch
            {
                SessionCostMetaVersion.V1 => "v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionCostMetaVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1" => SessionCostMetaVersion.V1,
                _ => null,
            };
        }
    }
}