
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// When `true`, only delete the endpoint if it is still a draft (409 otherwise).
    /// </summary>
    public readonly partial struct DeletePrivateEndpointDraftOnly : global::System.IEquatable<DeletePrivateEndpointDraftOnly>
    {
        /// <summary>
        ///
        /// </summary>
        public DeletePrivateEndpointDraftOnly(string value)
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
        public static DeletePrivateEndpointDraftOnly False { get; } = new("false");

        /// <summary>
        ///
        /// </summary>
        public static DeletePrivateEndpointDraftOnly True { get; } = new("true");
        /// <summary>
        ///
        /// </summary>
        public static DeletePrivateEndpointDraftOnly FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "false" => False,
                "true" => True,
                _ => new DeletePrivateEndpointDraftOnly(value),
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
        public bool Equals(DeletePrivateEndpointDraftOnly other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DeletePrivateEndpointDraftOnly other && Equals(other);
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
        public static bool operator ==(DeletePrivateEndpointDraftOnly left, DeletePrivateEndpointDraftOnly right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DeletePrivateEndpointDraftOnly left, DeletePrivateEndpointDraftOnly right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeletePrivateEndpointDraftOnlyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeletePrivateEndpointDraftOnly value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeletePrivateEndpointDraftOnly? ToEnum(string value)
        {
            return DeletePrivateEndpointDraftOnly.FromValue(value);
        }
    }
}