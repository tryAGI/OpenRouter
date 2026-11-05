
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Role of the member in the workspace. `viewer` and `restricted_viewer` are read-only: `viewer` can view the whole workspace, and `restricted_viewer` can view only their own activity.<br/>
    /// Example: member
    /// </summary>
    public readonly partial struct WorkspaceMemberRole : global::System.IEquatable<WorkspaceMemberRole>
    {
        /// <summary>
        ///
        /// </summary>
        public WorkspaceMemberRole(string value)
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
        public static WorkspaceMemberRole Admin { get; } = new("admin");

        /// <summary>
        /// `viewer` can view the whole workspace, and `restricted_viewer` can view only their own activity.
        /// </summary>
        public static WorkspaceMemberRole Member { get; } = new("member");

        /// <summary>
        /// `viewer` can view the whole workspace, and `restricted_viewer` can view only their own activity.
        /// </summary>
        public static WorkspaceMemberRole RestrictedViewer { get; } = new("restricted_viewer");

        /// <summary>
        /// `viewer` can view the whole workspace, and `restricted_viewer` can view only their own activity.
        /// </summary>
        public static WorkspaceMemberRole Viewer { get; } = new("viewer");
        /// <summary>
        ///
        /// </summary>
        public static WorkspaceMemberRole FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "admin" => Admin,
                "member" => Member,
                "restricted_viewer" => RestrictedViewer,
                "viewer" => Viewer,
                _ => new WorkspaceMemberRole(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "admin" => true,
            "member" => true,
            "restricted_viewer" => true,
            "viewer" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(WorkspaceMemberRole other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WorkspaceMemberRole other && Equals(other);
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
        public static bool operator ==(WorkspaceMemberRole left, WorkspaceMemberRole right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WorkspaceMemberRole left, WorkspaceMemberRole right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceMemberRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceMemberRole value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceMemberRole? ToEnum(string value)
        {
            return WorkspaceMemberRole.FromValue(value);
        }
    }
}