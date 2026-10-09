
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputToolSearchCallItemExecution
    {
        /// <summary>
        ///
        /// </summary>
        Client,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputToolSearchCallItemExecutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputToolSearchCallItemExecution value)
        {
            return value switch
            {
                OutputToolSearchCallItemExecution.Client => "client",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputToolSearchCallItemExecution? ToEnum(string value)
        {
            return value switch
            {
                "client" => OutputToolSearchCallItemExecution.Client,
                _ => null,
            };
        }
    }
}