
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateEmbeddingsResponseObject
    {
        /// <summary>
        ///
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEmbeddingsResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEmbeddingsResponseObject value)
        {
            return value switch
            {
                CreateEmbeddingsResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEmbeddingsResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => CreateEmbeddingsResponseObject.List,
                _ => null,
            };
        }
    }
}