
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputTextEditorServerToolItemCommand
    {
        /// <summary>
        /// 
        /// </summary>
        Create,
        /// <summary>
        /// 
        /// </summary>
        Insert,
        /// <summary>
        /// 
        /// </summary>
        StrReplace,
        /// <summary>
        /// 
        /// </summary>
        View,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputTextEditorServerToolItemCommandExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputTextEditorServerToolItemCommand value)
        {
            return value switch
            {
                OutputTextEditorServerToolItemCommand.Create => "create",
                OutputTextEditorServerToolItemCommand.Insert => "insert",
                OutputTextEditorServerToolItemCommand.StrReplace => "str_replace",
                OutputTextEditorServerToolItemCommand.View => "view",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputTextEditorServerToolItemCommand? ToEnum(string value)
        {
            return value switch
            {
                "create" => OutputTextEditorServerToolItemCommand.Create,
                "insert" => OutputTextEditorServerToolItemCommand.Insert,
                "str_replace" => OutputTextEditorServerToolItemCommand.StrReplace,
                "view" => OutputTextEditorServerToolItemCommand.View,
                _ => null,
            };
        }
    }
}