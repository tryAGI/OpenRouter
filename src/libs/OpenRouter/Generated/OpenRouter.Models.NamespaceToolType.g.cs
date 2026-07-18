
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum NamespaceToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Namespace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NamespaceToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NamespaceToolType value)
        {
            return value switch
            {
                NamespaceToolType.Namespace => "namespace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NamespaceToolType? ToEnum(string value)
        {
            return value switch
            {
                "namespace" => NamespaceToolType.Namespace,
                _ => null,
            };
        }
    }
}