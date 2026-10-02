
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct McpServerToolConnectorId : global::System.IEquatable<McpServerToolConnectorId>
    {
        /// <summary>
        ///
        /// </summary>
        public McpServerToolConnectorId(string value)
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
        public static McpServerToolConnectorId ConnectorDropbox { get; } = new("connector_dropbox");

        /// <summary>
        ///
        /// </summary>
        public static McpServerToolConnectorId ConnectorGmail { get; } = new("connector_gmail");

        /// <summary>
        ///
        /// </summary>
        public static McpServerToolConnectorId ConnectorGooglecalendar { get; } = new("connector_googlecalendar");

        /// <summary>
        ///
        /// </summary>
        public static McpServerToolConnectorId ConnectorGoogledrive { get; } = new("connector_googledrive");

        /// <summary>
        ///
        /// </summary>
        public static McpServerToolConnectorId ConnectorMicrosoftteams { get; } = new("connector_microsoftteams");

        /// <summary>
        ///
        /// </summary>
        public static McpServerToolConnectorId ConnectorOutlookcalendar { get; } = new("connector_outlookcalendar");

        /// <summary>
        ///
        /// </summary>
        public static McpServerToolConnectorId ConnectorOutlookemail { get; } = new("connector_outlookemail");

        /// <summary>
        ///
        /// </summary>
        public static McpServerToolConnectorId ConnectorSharepoint { get; } = new("connector_sharepoint");
        /// <summary>
        ///
        /// </summary>
        public static McpServerToolConnectorId FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "connector_dropbox" => ConnectorDropbox,
                "connector_gmail" => ConnectorGmail,
                "connector_googlecalendar" => ConnectorGooglecalendar,
                "connector_googledrive" => ConnectorGoogledrive,
                "connector_microsoftteams" => ConnectorMicrosoftteams,
                "connector_outlookcalendar" => ConnectorOutlookcalendar,
                "connector_outlookemail" => ConnectorOutlookemail,
                "connector_sharepoint" => ConnectorSharepoint,
                _ => new McpServerToolConnectorId(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "connector_dropbox" => true,
            "connector_gmail" => true,
            "connector_googlecalendar" => true,
            "connector_googledrive" => true,
            "connector_microsoftteams" => true,
            "connector_outlookcalendar" => true,
            "connector_outlookemail" => true,
            "connector_sharepoint" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(McpServerToolConnectorId other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is McpServerToolConnectorId other && Equals(other);
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
        public static bool operator ==(McpServerToolConnectorId left, McpServerToolConnectorId right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(McpServerToolConnectorId left, McpServerToolConnectorId right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpServerToolConnectorIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServerToolConnectorId value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServerToolConnectorId? ToEnum(string value)
        {
            return McpServerToolConnectorId.FromValue(value);
        }
    }
}