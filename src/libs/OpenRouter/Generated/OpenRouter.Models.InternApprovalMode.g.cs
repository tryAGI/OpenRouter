
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// How the run started by this prompt handles tool approvals. `self-drive` (the default when omitted) consents on your behalf and runs the shell unsandboxed. `manual` asks you before an approval-bearing tool runs, as an `openrouter.provide_input` permission request, and keeps the shell sandboxed until an escalation is allowed. The mode applies to the run this prompt starts and is not remembered by the session. Repeat it on each new prompt that should use it. A `tool` reply continues the run under the mode it started with.<br/>
    /// Example: manual
    /// </summary>
    public readonly partial struct InternApprovalMode : global::System.IEquatable<InternApprovalMode>
    {
        /// <summary>
        ///
        /// </summary>
        public InternApprovalMode(string value)
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
        public static InternApprovalMode Manual { get; } = new("manual");

        /// <summary>
        ///
        /// </summary>
        public static InternApprovalMode SelfDrive { get; } = new("self-drive");
        /// <summary>
        ///
        /// </summary>
        public static InternApprovalMode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "manual" => Manual,
                "self-drive" => SelfDrive,
                _ => new InternApprovalMode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "manual" => true,
            "self-drive" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(InternApprovalMode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InternApprovalMode other && Equals(other);
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
        public static bool operator ==(InternApprovalMode left, InternApprovalMode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InternApprovalMode left, InternApprovalMode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InternApprovalModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternApprovalMode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternApprovalMode? ToEnum(string value)
        {
            return InternApprovalMode.FromValue(value);
        }
    }
}