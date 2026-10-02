
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Routing algorithm for this request. "capability" calls a small judge model to rate how demanding the task is, then picks the efficient or capable candidate. "stage" reads the tool-result history (errors, repeated failures, edits landing) and calls the judge only when those signals are undecided. "auto" is "stage" without the judge call. "random" picks one candidate at random. "composite" keeps the tier chosen on the last human turn and re-evaluates tool turns with the stage signals. "passthrough" serves the eligible candidates in the order OpenRouter already ranked them, with no routing decision and no judge call. Omit this field to use the platform default, stage.
    /// </summary>
    public readonly partial struct SwitchyardRouterPluginAlgorithm : global::System.IEquatable<SwitchyardRouterPluginAlgorithm>
    {
        /// <summary>
        ///
        /// </summary>
        public SwitchyardRouterPluginAlgorithm(string value)
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
        public static SwitchyardRouterPluginAlgorithm Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static SwitchyardRouterPluginAlgorithm Capability { get; } = new("capability");

        /// <summary>
        ///
        /// </summary>
        public static SwitchyardRouterPluginAlgorithm Composite { get; } = new("composite");

        /// <summary>
        ///
        /// </summary>
        public static SwitchyardRouterPluginAlgorithm Passthrough { get; } = new("passthrough");

        /// <summary>
        ///
        /// </summary>
        public static SwitchyardRouterPluginAlgorithm Random { get; } = new("random");

        /// <summary>
        ///
        /// </summary>
        public static SwitchyardRouterPluginAlgorithm Stage { get; } = new("stage");
        /// <summary>
        ///
        /// </summary>
        public static SwitchyardRouterPluginAlgorithm FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "auto" => Auto,
                "capability" => Capability,
                "composite" => Composite,
                "passthrough" => Passthrough,
                "random" => Random,
                "stage" => Stage,
                _ => new SwitchyardRouterPluginAlgorithm(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "auto" => true,
            "capability" => true,
            "composite" => true,
            "passthrough" => true,
            "random" => true,
            "stage" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(SwitchyardRouterPluginAlgorithm other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SwitchyardRouterPluginAlgorithm other && Equals(other);
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
        public static bool operator ==(SwitchyardRouterPluginAlgorithm left, SwitchyardRouterPluginAlgorithm right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SwitchyardRouterPluginAlgorithm left, SwitchyardRouterPluginAlgorithm right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwitchyardRouterPluginAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwitchyardRouterPluginAlgorithm value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwitchyardRouterPluginAlgorithm? ToEnum(string value)
        {
            return SwitchyardRouterPluginAlgorithm.FromValue(value);
        }
    }
}