
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ListInternsStatu : global::System.IEquatable<ListInternsStatu>
    {
        /// <summary>
        ///
        /// </summary>
        public ListInternsStatu(string value)
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
        public static ListInternsStatu AwaitingSlackInstall { get; } = new("awaiting_slack_install");

        /// <summary>
        ///
        /// </summary>
        public static ListInternsStatu DestroyFailed { get; } = new("destroy_failed");

        /// <summary>
        ///
        /// </summary>
        public static ListInternsStatu Destroying { get; } = new("destroying");

        /// <summary>
        ///
        /// </summary>
        public static ListInternsStatu Failed { get; } = new("failed");

        /// <summary>
        ///
        /// </summary>
        public static ListInternsStatu Provisioning { get; } = new("provisioning");

        /// <summary>
        ///
        /// </summary>
        public static ListInternsStatu Queued { get; } = new("queued");

        /// <summary>
        ///
        /// </summary>
        public static ListInternsStatu Running { get; } = new("running");

        /// <summary>
        ///
        /// </summary>
        public static ListInternsStatu Stopped { get; } = new("stopped");
        /// <summary>
        ///
        /// </summary>
        public static ListInternsStatu FromValue(string value)
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
                _ => new ListInternsStatu(value),
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
        public bool Equals(ListInternsStatu other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListInternsStatu other && Equals(other);
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
        public static bool operator ==(ListInternsStatu left, ListInternsStatu right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ListInternsStatu left, ListInternsStatu right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListInternsStatuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListInternsStatu value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListInternsStatu? ToEnum(string value)
        {
            return ListInternsStatu.FromValue(value);
        }
    }
}