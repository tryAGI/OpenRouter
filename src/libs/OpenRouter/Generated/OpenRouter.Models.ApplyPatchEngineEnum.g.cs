
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Which apply_patch engine to use. "auto" (default) uses native passthrough when the endpoint advertises native apply_patch support, otherwise falls back to OpenRouter's HITL validator. "native" forces native passthrough — when the endpoint does not support native, the request falls back to HITL. "openrouter" always runs the HITL validator. Native passthrough streams the diff incrementally via `apply_patch_call_operation_diff.delta` events; HITL buffers the diff for atomic delivery as a single delta.<br/>
    /// Example: auto
    /// </summary>
    public readonly partial struct ApplyPatchEngineEnum : global::System.IEquatable<ApplyPatchEngineEnum>
    {
        /// <summary>
        ///
        /// </summary>
        public ApplyPatchEngineEnum(string value)
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
        public static ApplyPatchEngineEnum Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static ApplyPatchEngineEnum Native { get; } = new("native");

        /// <summary>
        ///
        /// </summary>
        public static ApplyPatchEngineEnum Openrouter { get; } = new("openrouter");
        /// <summary>
        ///
        /// </summary>
        public static ApplyPatchEngineEnum FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "auto" => Auto,
                "native" => Native,
                "openrouter" => Openrouter,
                _ => new ApplyPatchEngineEnum(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "auto" => true,
            "native" => true,
            "openrouter" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ApplyPatchEngineEnum other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ApplyPatchEngineEnum other && Equals(other);
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
        public static bool operator ==(ApplyPatchEngineEnum left, ApplyPatchEngineEnum right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ApplyPatchEngineEnum left, ApplyPatchEngineEnum right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchEngineEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchEngineEnum value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchEngineEnum? ToEnum(string value)
        {
            return ApplyPatchEngineEnum.FromValue(value);
        }
    }
}