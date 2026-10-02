
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreateWorkspaceRequestDisabledServerTool : global::System.IEquatable<CreateWorkspaceRequestDisabledServerTool>
    {
        /// <summary>
        ///
        /// </summary>
        public CreateWorkspaceRequestDisabledServerTool(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        ///
        /// </summary>
        public static CreateWorkspaceRequestDisabledServerTool Openrouter_advisor { get; } = new("openrouter:advisor");

        /// <summary>
        ///
        /// </summary>
        public static CreateWorkspaceRequestDisabledServerTool Openrouter_applyPatch { get; } = new("openrouter:apply_patch");

        /// <summary>
        ///
        /// </summary>
        public static CreateWorkspaceRequestDisabledServerTool Openrouter_bash { get; } = new("openrouter:bash");

        /// <summary>
        ///
        /// </summary>
        public static CreateWorkspaceRequestDisabledServerTool Openrouter_datetime { get; } = new("openrouter:datetime");

        /// <summary>
        ///
        /// </summary>
        public static CreateWorkspaceRequestDisabledServerTool Openrouter_experimentalSearchModels { get; } = new("openrouter:experimental__search_models");

        /// <summary>
        ///
        /// </summary>
        public static CreateWorkspaceRequestDisabledServerTool Openrouter_fusion { get; } = new("openrouter:fusion");

        /// <summary>
        ///
        /// </summary>
        public static CreateWorkspaceRequestDisabledServerTool Openrouter_imageGeneration { get; } = new("openrouter:image_generation");

        /// <summary>
        ///
        /// </summary>
        public static CreateWorkspaceRequestDisabledServerTool Openrouter_shell { get; } = new("openrouter:shell");

        /// <summary>
        ///
        /// </summary>
        public static CreateWorkspaceRequestDisabledServerTool Openrouter_subagent { get; } = new("openrouter:subagent");

        /// <summary>
        ///
        /// </summary>
        public static CreateWorkspaceRequestDisabledServerTool Openrouter_toolSearch { get; } = new("openrouter:tool_search");

        /// <summary>
        ///
        /// </summary>
        public static CreateWorkspaceRequestDisabledServerTool Openrouter_webFetch { get; } = new("openrouter:web_fetch");

        /// <summary>
        ///
        /// </summary>
        public static CreateWorkspaceRequestDisabledServerTool Openrouter_webSearch { get; } = new("openrouter:web_search");
        /// <summary>
        ///
        /// </summary>
        public static CreateWorkspaceRequestDisabledServerTool FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "openrouter:advisor" => Openrouter_advisor,
                "openrouter:apply_patch" => Openrouter_applyPatch,
                "openrouter:bash" => Openrouter_bash,
                "openrouter:datetime" => Openrouter_datetime,
                "openrouter:experimental__search_models" => Openrouter_experimentalSearchModels,
                "openrouter:fusion" => Openrouter_fusion,
                "openrouter:image_generation" => Openrouter_imageGeneration,
                "openrouter:shell" => Openrouter_shell,
                "openrouter:subagent" => Openrouter_subagent,
                "openrouter:tool_search" => Openrouter_toolSearch,
                "openrouter:web_fetch" => Openrouter_webFetch,
                "openrouter:web_search" => Openrouter_webSearch,
                _ => new CreateWorkspaceRequestDisabledServerTool(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "openrouter:advisor" => true,
            "openrouter:apply_patch" => true,
            "openrouter:bash" => true,
            "openrouter:datetime" => true,
            "openrouter:experimental__search_models" => true,
            "openrouter:fusion" => true,
            "openrouter:image_generation" => true,
            "openrouter:shell" => true,
            "openrouter:subagent" => true,
            "openrouter:tool_search" => true,
            "openrouter:web_fetch" => true,
            "openrouter:web_search" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(CreateWorkspaceRequestDisabledServerTool other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateWorkspaceRequestDisabledServerTool other && Equals(other);
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateWorkspaceRequestDisabledServerTool left, CreateWorkspaceRequestDisabledServerTool right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateWorkspaceRequestDisabledServerTool left, CreateWorkspaceRequestDisabledServerTool right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWorkspaceRequestDisabledServerToolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWorkspaceRequestDisabledServerTool value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWorkspaceRequestDisabledServerTool? ToEnum(string value)
        {
            return CreateWorkspaceRequestDisabledServerTool.FromValue(value);
        }
    }
}