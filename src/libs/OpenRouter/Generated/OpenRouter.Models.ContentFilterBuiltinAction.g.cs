
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Action taken when the builtin filter triggers
    /// </summary>
    public enum ContentFilterBuiltinAction
    {
        /// <summary>
        /// 
        /// </summary>
        Block,
        /// <summary>
        /// 
        /// </summary>
        Flag,
        /// <summary>
        /// 
        /// </summary>
        Redact,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentFilterBuiltinActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentFilterBuiltinAction value)
        {
            return value switch
            {
                ContentFilterBuiltinAction.Block => "block",
                ContentFilterBuiltinAction.Flag => "flag",
                ContentFilterBuiltinAction.Redact => "redact",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentFilterBuiltinAction? ToEnum(string value)
        {
            return value switch
            {
                "block" => ContentFilterBuiltinAction.Block,
                "flag" => ContentFilterBuiltinAction.Flag,
                "redact" => ContentFilterBuiltinAction.Redact,
                _ => null,
            };
        }
    }
}