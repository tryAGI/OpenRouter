
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ScimGroupMappingRole : global::System.IEquatable<ScimGroupMappingRole>
    {
        /// <summary>
        ///
        /// </summary>
        public ScimGroupMappingRole(string value)
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
        public static ScimGroupMappingRole Admin { get; } = new("admin");

        /// <summary>
        ///
        /// </summary>
        public static ScimGroupMappingRole Member { get; } = new("member");
        /// <summary>
        ///
        /// </summary>
        public static ScimGroupMappingRole FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "admin" => Admin,
                "member" => Member,
                _ => new ScimGroupMappingRole(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "admin" => true,
            "member" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ScimGroupMappingRole other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScimGroupMappingRole other && Equals(other);
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
        public static bool operator ==(ScimGroupMappingRole left, ScimGroupMappingRole right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ScimGroupMappingRole left, ScimGroupMappingRole right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScimGroupMappingRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScimGroupMappingRole value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScimGroupMappingRole? ToEnum(string value)
        {
            return ScimGroupMappingRole.FromValue(value);
        }
    }
}