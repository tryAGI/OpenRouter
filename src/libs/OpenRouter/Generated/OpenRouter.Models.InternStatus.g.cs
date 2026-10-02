
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Lifecycle status.
    /// </summary>
    public readonly partial struct InternStatus : global::System.IEquatable<InternStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public InternStatus(string value)
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
        public static InternStatus AwaitingSlackInstall { get; } = new("awaiting_slack_install");

        /// <summary>
        ///
        /// </summary>
        public static InternStatus DestroyFailed { get; } = new("destroy_failed");

        /// <summary>
        ///
        /// </summary>
        public static InternStatus Destroying { get; } = new("destroying");

        /// <summary>
        ///
        /// </summary>
        public static InternStatus Failed { get; } = new("failed");

        /// <summary>
        ///
        /// </summary>
        public static InternStatus Provisioning { get; } = new("provisioning");

        /// <summary>
        ///
        /// </summary>
        public static InternStatus Queued { get; } = new("queued");

        /// <summary>
        ///
        /// </summary>
        public static InternStatus Running { get; } = new("running");

        /// <summary>
        ///
        /// </summary>
        public static InternStatus Stopped { get; } = new("stopped");
        /// <summary>
        ///
        /// </summary>
        public static InternStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "awaiting_slack_install" => AwaitingSlackInstall,
                "destroy_failed" => DestroyFailed,
                "destroying" => Destroying,
                "failed" => Failed,
                "provisioning" => Provisioning,
                "queued" => Queued,
                "running" => Running,
                "stopped" => Stopped,
                _ => new InternStatus(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "awaiting_slack_install" => true,
            "destroy_failed" => true,
            "destroying" => true,
            "failed" => true,
            "provisioning" => true,
            "queued" => true,
            "running" => true,
            "stopped" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(InternStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InternStatus other && Equals(other);
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
        public static bool operator ==(InternStatus left, InternStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InternStatus left, InternStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InternStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternStatus? ToEnum(string value)
        {
            return InternStatus.FromValue(value);
        }
    }
}