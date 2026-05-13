
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum LocalShellCallItemActionType
    {
        /// <summary>
        /// 
        /// </summary>
        Exec,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalShellCallItemActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalShellCallItemActionType value)
        {
            return value switch
            {
                LocalShellCallItemActionType.Exec => "exec",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalShellCallItemActionType? ToEnum(string value)
        {
            return value switch
            {
                "exec" => LocalShellCallItemActionType.Exec,
                _ => null,
            };
        }
    }
}