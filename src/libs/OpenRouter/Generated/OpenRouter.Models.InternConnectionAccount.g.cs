
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InternConnectionAccount
    {
        /// <summary>
        /// Whose account it acts as, when known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acts_as")]
        public string? ActsAs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_your_account_linked")]
        public bool? IsYourAccountLinked { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// `workspace` for a shared connection, `yours` for the key user's personal account, `shared` for a teammate's.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InternConnectionAccountScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InternConnectionAccountScope Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternConnectionAccount" /> class.
        /// </summary>
        /// <param name="scope">
        /// `workspace` for a shared connection, `yours` for the key user's personal account, `shared` for a teammate's.
        /// </param>
        /// <param name="actsAs">
        /// Whose account it acts as, when known.
        /// </param>
        /// <param name="isYourAccountLinked"></param>
        /// <param name="note"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternConnectionAccount(
            global::OpenRouter.InternConnectionAccountScope scope,
            string? actsAs,
            bool? isYourAccountLinked,
            string? note)
        {
            this.ActsAs = actsAs;
            this.IsYourAccountLinked = isYourAccountLinked;
            this.Note = note;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternConnectionAccount" /> class.
        /// </summary>
        public InternConnectionAccount()
        {
        }

    }
}