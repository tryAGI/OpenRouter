
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An image sent once and referenced by its key in the `assets` map. `data_base64` is the PNG or JPEG file in standard base64 with no `data:` prefix. The multipart `part` field of TypeSafe's API is not accepted.
    /// </summary>
    public sealed partial class DecisionsImageAsset
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_base64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataBase64 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DecisionsImageAssetFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.DecisionsImageAssetFormat Format { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DecisionsImageAssetTypeJsonConverter))]
        public global::OpenRouter.DecisionsImageAssetType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsImageAsset" /> class.
        /// </summary>
        /// <param name="dataBase64"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionsImageAsset(
            string dataBase64,
            global::OpenRouter.DecisionsImageAssetFormat format,
            global::OpenRouter.DecisionsImageAssetType? type)
        {
            this.DataBase64 = dataBase64 ?? throw new global::System.ArgumentNullException(nameof(dataBase64));
            this.Format = format;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsImageAsset" /> class.
        /// </summary>
        public DecisionsImageAsset()
        {
        }

    }
}