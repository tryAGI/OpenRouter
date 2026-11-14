
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Data collection setting. If no available model provider meets the requirement, your request will return an error.<br/>
    /// - allow: (default) allow providers that may train on user data<br/>
    /// - deny: use only providers that do not train on user data. Providers may still retain prompts; set `zdr: true` to exclude retention.<br/>
    /// Example: allow
    /// </summary>
    public readonly partial struct VideoGenerationRequestProviderDataCollection : global::System.IEquatable<VideoGenerationRequestProviderDataCollection>
    {
        /// <summary>
        ///
        /// </summary>
        public VideoGenerationRequestProviderDataCollection(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// (default) allow providers that may train on user data
        /// </summary>
        public static VideoGenerationRequestProviderDataCollection Allow { get; } = new("allow");

        /// <summary>
        /// use only providers that do not train on user data. Providers may still retain prompts; set `zdr: true` to exclude retention.
        /// </summary>
        public static VideoGenerationRequestProviderDataCollection Deny { get; } = new("deny");
        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationRequestProviderDataCollection FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "allow" => Allow,
                "deny" => Deny,
                _ => new VideoGenerationRequestProviderDataCollection(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "allow" => true,
            "deny" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(VideoGenerationRequestProviderDataCollection other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VideoGenerationRequestProviderDataCollection other && Equals(other);
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
        public static bool operator ==(VideoGenerationRequestProviderDataCollection left, VideoGenerationRequestProviderDataCollection right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VideoGenerationRequestProviderDataCollection left, VideoGenerationRequestProviderDataCollection right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoGenerationRequestProviderDataCollectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoGenerationRequestProviderDataCollection value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoGenerationRequestProviderDataCollection? ToEnum(string value)
        {
            return VideoGenerationRequestProviderDataCollection.FromValue(value);
        }
    }
}