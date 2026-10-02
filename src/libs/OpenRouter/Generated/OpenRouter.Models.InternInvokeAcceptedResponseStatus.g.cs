
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// `started` when a new run began. `steered` when the session already had a run going and the prompt was delivered into it instead.<br/>
    /// Example: started
    /// </summary>
    public readonly partial struct InternInvokeAcceptedResponseStatus : global::System.IEquatable<InternInvokeAcceptedResponseStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public InternInvokeAcceptedResponseStatus(string value)
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
        public static InternInvokeAcceptedResponseStatus Started { get; } = new("started");

        /// <summary>
        ///
        /// </summary>
        public static InternInvokeAcceptedResponseStatus Steered { get; } = new("steered");
        /// <summary>
        ///
        /// </summary>
        public static InternInvokeAcceptedResponseStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "started" => Started,
                "steered" => Steered,
                _ => new InternInvokeAcceptedResponseStatus(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "started" => true,
            "steered" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(InternInvokeAcceptedResponseStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InternInvokeAcceptedResponseStatus other && Equals(other);
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
        public static bool operator ==(InternInvokeAcceptedResponseStatus left, InternInvokeAcceptedResponseStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InternInvokeAcceptedResponseStatus left, InternInvokeAcceptedResponseStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InternInvokeAcceptedResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternInvokeAcceptedResponseStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternInvokeAcceptedResponseStatus? ToEnum(string value)
        {
            return InternInvokeAcceptedResponseStatus.FromValue(value);
        }
    }
}