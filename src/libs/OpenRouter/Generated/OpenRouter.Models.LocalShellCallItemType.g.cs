
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum LocalShellCallItemType
    {
        /// <summary>
        /// 
        /// </summary>
        LocalShellCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalShellCallItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalShellCallItemType value)
        {
            return value switch
            {
                LocalShellCallItemType.LocalShellCall => "local_shell_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalShellCallItemType? ToEnum(string value)
        {
            return value switch
            {
                "local_shell_call" => LocalShellCallItemType.LocalShellCall,
                _ => null,
            };
        }
    }
}