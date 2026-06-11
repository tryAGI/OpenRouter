
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Marketplace subcategory to filter by (e.g. `cli-agent`). Takes precedence over `category` for the actual filter; when `category` is also supplied the pair must be consistent.
    /// </summary>
    public enum DatasetsAppRankingsGetParametersSubcategory
    {
        /// <summary>
        /// 
        /// </summary>
        AudioGen,
        /// <summary>
        /// 
        /// </summary>
        CliAgent,
        /// <summary>
        /// 
        /// </summary>
        CloudAgent,
        /// <summary>
        /// 
        /// </summary>
        CreativeWriting,
        /// <summary>
        /// 
        /// </summary>
        Game,
        /// <summary>
        /// 
        /// </summary>
        GeneralChat,
        /// <summary>
        /// 
        /// </summary>
        IdeExtension,
        /// <summary>
        /// 
        /// </summary>
        ImageGen,
        /// <summary>
        /// 
        /// </summary>
        Legal,
        /// <summary>
        /// 
        /// </summary>
        NativeAppBuilder,
        /// <summary>
        /// 
        /// </summary>
        PersonalAgent,
        /// <summary>
        /// 
        /// </summary>
        ProgrammingApp,
        /// <summary>
        /// 
        /// </summary>
        Roleplay,
        /// <summary>
        /// 
        /// </summary>
        VideoGen,
        /// <summary>
        /// 
        /// </summary>
        WritingAssistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetsAppRankingsGetParametersSubcategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetsAppRankingsGetParametersSubcategory value)
        {
            return value switch
            {
                DatasetsAppRankingsGetParametersSubcategory.AudioGen => "audio-gen",
                DatasetsAppRankingsGetParametersSubcategory.CliAgent => "cli-agent",
                DatasetsAppRankingsGetParametersSubcategory.CloudAgent => "cloud-agent",
                DatasetsAppRankingsGetParametersSubcategory.CreativeWriting => "creative-writing",
                DatasetsAppRankingsGetParametersSubcategory.Game => "game",
                DatasetsAppRankingsGetParametersSubcategory.GeneralChat => "general-chat",
                DatasetsAppRankingsGetParametersSubcategory.IdeExtension => "ide-extension",
                DatasetsAppRankingsGetParametersSubcategory.ImageGen => "image-gen",
                DatasetsAppRankingsGetParametersSubcategory.Legal => "legal",
                DatasetsAppRankingsGetParametersSubcategory.NativeAppBuilder => "native-app-builder",
                DatasetsAppRankingsGetParametersSubcategory.PersonalAgent => "personal-agent",
                DatasetsAppRankingsGetParametersSubcategory.ProgrammingApp => "programming-app",
                DatasetsAppRankingsGetParametersSubcategory.Roleplay => "roleplay",
                DatasetsAppRankingsGetParametersSubcategory.VideoGen => "video-gen",
                DatasetsAppRankingsGetParametersSubcategory.WritingAssistant => "writing-assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetsAppRankingsGetParametersSubcategory? ToEnum(string value)
        {
            return value switch
            {
                "audio-gen" => DatasetsAppRankingsGetParametersSubcategory.AudioGen,
                "cli-agent" => DatasetsAppRankingsGetParametersSubcategory.CliAgent,
                "cloud-agent" => DatasetsAppRankingsGetParametersSubcategory.CloudAgent,
                "creative-writing" => DatasetsAppRankingsGetParametersSubcategory.CreativeWriting,
                "game" => DatasetsAppRankingsGetParametersSubcategory.Game,
                "general-chat" => DatasetsAppRankingsGetParametersSubcategory.GeneralChat,
                "ide-extension" => DatasetsAppRankingsGetParametersSubcategory.IdeExtension,
                "image-gen" => DatasetsAppRankingsGetParametersSubcategory.ImageGen,
                "legal" => DatasetsAppRankingsGetParametersSubcategory.Legal,
                "native-app-builder" => DatasetsAppRankingsGetParametersSubcategory.NativeAppBuilder,
                "personal-agent" => DatasetsAppRankingsGetParametersSubcategory.PersonalAgent,
                "programming-app" => DatasetsAppRankingsGetParametersSubcategory.ProgrammingApp,
                "roleplay" => DatasetsAppRankingsGetParametersSubcategory.Roleplay,
                "video-gen" => DatasetsAppRankingsGetParametersSubcategory.VideoGen,
                "writing-assistant" => DatasetsAppRankingsGetParametersSubcategory.WritingAssistant,
                _ => null,
            };
        }
    }
}