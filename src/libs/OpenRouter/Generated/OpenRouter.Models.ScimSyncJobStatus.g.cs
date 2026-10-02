
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Current status of the sync job: queued, running, succeeded, or failed.
    /// </summary>
    public readonly partial struct ScimSyncJobStatus : global::System.IEquatable<ScimSyncJobStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public ScimSyncJobStatus(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// queued, running, succeeded, or failed.
        /// </summary>
        public static ScimSyncJobStatus Failed { get; } = new("failed");

        /// <summary>
        /// queued, running, succeeded, or failed.
        /// </summary>
        public static ScimSyncJobStatus Queued { get; } = new("queued");

        /// <summary>
        /// queued, running, succeeded, or failed.
        /// </summary>
        public static ScimSyncJobStatus Running { get; } = new("running");

        /// <summary>
        /// queued, running, succeeded, or failed.
        /// </summary>
        public static ScimSyncJobStatus Succeeded { get; } = new("succeeded");
        /// <summary>
        ///
        /// </summary>
        public static ScimSyncJobStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "failed" => Failed,
                "queued" => Queued,
                "running" => Running,
                "succeeded" => Succeeded,
                _ => new ScimSyncJobStatus(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "failed" => true,
            "queued" => true,
            "running" => true,
            "succeeded" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ScimSyncJobStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScimSyncJobStatus other && Equals(other);
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
        public static bool operator ==(ScimSyncJobStatus left, ScimSyncJobStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ScimSyncJobStatus left, ScimSyncJobStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScimSyncJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScimSyncJobStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScimSyncJobStatus? ToEnum(string value)
        {
            return ScimSyncJobStatus.FromValue(value);
        }
    }
}