
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum InternChatDeveloperMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InternChatDeveloperMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternChatDeveloperMessageRole value)
        {
            return value switch
            {
                InternChatDeveloperMessageRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternChatDeveloperMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "developer" => InternChatDeveloperMessageRole.Developer,
                _ => null,
            };
        }
    }
}