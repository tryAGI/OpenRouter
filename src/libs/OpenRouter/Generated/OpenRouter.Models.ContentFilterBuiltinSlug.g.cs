
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The builtin filter identifier
    /// </summary>
    public enum ContentFilterBuiltinSlug
    {
        /// <summary>
        /// 
        /// </summary>
        Address,
        /// <summary>
        /// 
        /// </summary>
        CreditCard,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        IpAddress,
        /// <summary>
        /// 
        /// </summary>
        PersonName,
        /// <summary>
        /// 
        /// </summary>
        Phone,
        /// <summary>
        /// 
        /// </summary>
        RegexPromptInjection,
        /// <summary>
        /// 
        /// </summary>
        Ssn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentFilterBuiltinSlugExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentFilterBuiltinSlug value)
        {
            return value switch
            {
                ContentFilterBuiltinSlug.Address => "address",
                ContentFilterBuiltinSlug.CreditCard => "credit-card",
                ContentFilterBuiltinSlug.Email => "email",
                ContentFilterBuiltinSlug.IpAddress => "ip-address",
                ContentFilterBuiltinSlug.PersonName => "person-name",
                ContentFilterBuiltinSlug.Phone => "phone",
                ContentFilterBuiltinSlug.RegexPromptInjection => "regex-prompt-injection",
                ContentFilterBuiltinSlug.Ssn => "ssn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentFilterBuiltinSlug? ToEnum(string value)
        {
            return value switch
            {
                "address" => ContentFilterBuiltinSlug.Address,
                "credit-card" => ContentFilterBuiltinSlug.CreditCard,
                "email" => ContentFilterBuiltinSlug.Email,
                "ip-address" => ContentFilterBuiltinSlug.IpAddress,
                "person-name" => ContentFilterBuiltinSlug.PersonName,
                "phone" => ContentFilterBuiltinSlug.Phone,
                "regex-prompt-injection" => ContentFilterBuiltinSlug.RegexPromptInjection,
                "ssn" => ContentFilterBuiltinSlug.Ssn,
                _ => null,
            };
        }
    }
}