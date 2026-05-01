
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Data collection setting. If no available model provider meets the requirement, your request will return an error.<br/>
    /// - allow: (default) allow providers which store user data non-transiently and may train on it<br/>
    /// - deny: use only providers which do not collect user data.
    /// </summary>
    public enum EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection
    {
        /// <summary>
        /// (default) allow providers which store user data non-transiently and may train on it
        /// </summary>
        Allow,
        /// <summary>
        /// use only providers which do not collect user data.
        /// </summary>
        Deny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection value)
        {
            return value switch
            {
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection.Allow => "allow",
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection? ToEnum(string value)
        {
            return value switch
            {
                "allow" => EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection.Allow,
                "deny" => EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection.Deny,
                _ => null,
            };
        }
    }
}