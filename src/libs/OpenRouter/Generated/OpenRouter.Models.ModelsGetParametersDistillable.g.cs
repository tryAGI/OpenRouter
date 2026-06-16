
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Filter by distillation capability. "true" returns only distillable models, "false" excludes them.
    /// </summary>
    public enum ModelsGetParametersDistillable
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelsGetParametersDistillableExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsGetParametersDistillable value)
        {
            return value switch
            {
                ModelsGetParametersDistillable.False => "false",
                ModelsGetParametersDistillable.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsGetParametersDistillable? ToEnum(string value)
        {
            return value switch
            {
                "false" => ModelsGetParametersDistillable.False,
                "true" => ModelsGetParametersDistillable.True,
                _ => null,
            };
        }
    }
}