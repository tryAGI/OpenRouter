
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Role of the member in the workspace
    /// </summary>
    public enum WorkspaceMemberRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Member,
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
            return value switch
            {
                WorkspaceMemberRole.Admin => "admin",
                WorkspaceMemberRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceMemberRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => WorkspaceMemberRole.Admin,
                "member" => WorkspaceMemberRole.Member,
                _ => null,
            };
        }
    }
}