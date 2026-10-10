
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Where tool-call arguments are checked against the original schema. Only `runtime` (in OpenRouter) is available in this release.
    /// </summary>
    public enum DeferredToolsControlValidation
    {
        /// <summary>
        ///
        /// </summary>
        Runtime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeferredToolsControlValidationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeferredToolsControlValidation value)
        {
            return value switch
            {
                DeferredToolsControlValidation.Runtime => "runtime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeferredToolsControlValidation? ToEnum(string value)
        {
            return value switch
            {
                "runtime" => DeferredToolsControlValidation.Runtime,
                _ => null,
            };
        }
    }
}