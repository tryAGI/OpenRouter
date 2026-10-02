
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Marketplace subcategory to filter by (e.g. `cli-agent`). Takes precedence over `category` for the actual filter; when `category` is also supplied the pair must be consistent.<br/>
    /// Example: cli-agent
    /// </summary>
    public readonly partial struct GetAppRankingsSubcategory : global::System.IEquatable<GetAppRankingsSubcategory>
    {
        /// <summary>
        ///
        /// </summary>
        public GetAppRankingsSubcategory(string value)
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
        public static GetAppRankingsSubcategory AudioGen { get; } = new("audio-gen");

        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsSubcategory CliAgent { get; } = new("cli-agent");

        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsSubcategory CloudAgent { get; } = new("cloud-agent");

        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsSubcategory CreativeWriting { get; } = new("creative-writing");

        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsSubcategory Game { get; } = new("game");

        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsSubcategory GeneralChat { get; } = new("general-chat");

        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsSubcategory IdeExtension { get; } = new("ide-extension");

        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsSubcategory ImageGen { get; } = new("image-gen");

        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsSubcategory Legal { get; } = new("legal");

        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsSubcategory NativeAppBuilder { get; } = new("native-app-builder");

        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsSubcategory PersonalAgent { get; } = new("personal-agent");

        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsSubcategory ProgrammingApp { get; } = new("programming-app");

        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsSubcategory Roleplay { get; } = new("roleplay");

        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsSubcategory VideoGen { get; } = new("video-gen");

        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsSubcategory WritingAssistant { get; } = new("writing-assistant");
        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsSubcategory FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "audio-gen" => AudioGen,
                "cli-agent" => CliAgent,
                "cloud-agent" => CloudAgent,
                "creative-writing" => CreativeWriting,
                "game" => Game,
                "general-chat" => GeneralChat,
                "ide-extension" => IdeExtension,
                "image-gen" => ImageGen,
                "legal" => Legal,
                "native-app-builder" => NativeAppBuilder,
                "personal-agent" => PersonalAgent,
                "programming-app" => ProgrammingApp,
                "roleplay" => Roleplay,
                "video-gen" => VideoGen,
                "writing-assistant" => WritingAssistant,
                _ => new GetAppRankingsSubcategory(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "audio-gen" => true,
            "cli-agent" => true,
            "cloud-agent" => true,
            "creative-writing" => true,
            "game" => true,
            "general-chat" => true,
            "ide-extension" => true,
            "image-gen" => true,
            "legal" => true,
            "native-app-builder" => true,
            "personal-agent" => true,
            "programming-app" => true,
            "roleplay" => true,
            "video-gen" => true,
            "writing-assistant" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GetAppRankingsSubcategory other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetAppRankingsSubcategory other && Equals(other);
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
        public static bool operator ==(GetAppRankingsSubcategory left, GetAppRankingsSubcategory right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetAppRankingsSubcategory left, GetAppRankingsSubcategory right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAppRankingsSubcategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAppRankingsSubcategory value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAppRankingsSubcategory? ToEnum(string value)
        {
            return GetAppRankingsSubcategory.FromValue(value);
        }
    }
}