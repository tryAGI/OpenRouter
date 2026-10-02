
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Set to 'workspace' to split each row per workspace and include `workspace_id` on every item. Omitted by default, in which case rows are aggregated across workspaces (by date, model, and endpoint) and `workspace_id` is not returned — preserving the historical response shape.<br/>
    /// Example: workspace
    /// </summary>
    public enum GetUserActivityGroupBy
    {
        /// <summary>
        ///
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUserActivityGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserActivityGroupBy value)
        {
            return value switch
            {
                GetUserActivityGroupBy.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserActivityGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "workspace" => GetUserActivityGroupBy.Workspace,
                _ => null,
            };
        }
    }
}