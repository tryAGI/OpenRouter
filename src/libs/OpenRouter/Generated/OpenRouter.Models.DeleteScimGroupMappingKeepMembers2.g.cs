
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct DeleteScimGroupMappingKeepMembers2 : global::System.IEquatable<DeleteScimGroupMappingKeepMembers2>
    {
        /// <summary>
        ///
        /// </summary>
        public DeleteScimGroupMappingKeepMembers2(string value)
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
        public static DeleteScimGroupMappingKeepMembers2 False { get; } = new("false");

        /// <summary>
        ///
        /// </summary>
        public static DeleteScimGroupMappingKeepMembers2 True { get; } = new("true");
        /// <summary>
        ///
        /// </summary>
        public static DeleteScimGroupMappingKeepMembers2 FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "false" => False,
                "true" => True,
                _ => new DeleteScimGroupMappingKeepMembers2(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "false" => true,
            "true" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(DeleteScimGroupMappingKeepMembers2 other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DeleteScimGroupMappingKeepMembers2 other && Equals(other);
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
        public static bool operator ==(DeleteScimGroupMappingKeepMembers2 left, DeleteScimGroupMappingKeepMembers2 right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DeleteScimGroupMappingKeepMembers2 left, DeleteScimGroupMappingKeepMembers2 right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteScimGroupMappingKeepMembers2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteScimGroupMappingKeepMembers2 value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteScimGroupMappingKeepMembers2? ToEnum(string value)
        {
            return DeleteScimGroupMappingKeepMembers2.FromValue(value);
        }
    }
}