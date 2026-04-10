
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputTextEditorServerToolItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_textEditor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputTextEditorServerToolItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputTextEditorServerToolItemType value)
        {
            return value switch
            {
                OutputTextEditorServerToolItemType.Openrouter_textEditor => "openrouter:text_editor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputTextEditorServerToolItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:text_editor" => OutputTextEditorServerToolItemType.Openrouter_textEditor,
                _ => null,
            };
        }
    }
}