
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Your declaration of the data region in which the upstream provider account behind this credential processes requests, used for routing eligibility on OpenRouter's regional hosts. `null` means undeclared and `global` is behaviorally identical: the credential follows the region OpenRouter records for the endpoint. `europe` or `us` lets requests to `eu.openrouter.ai` or `us.openrouter.ai` use this credential for that provider (private endpoints, endpoints pinned to another cloud region, cross-region inference profiles and video models are excluded). Self-declared and not verified by OpenRouter. For OpenAI and Fireworks the region comes from the key material (a `{"api_key": ..., "region": ...}` key), so the value must match the key's region. Among other providers, only Azure accepts `europe` or `us`. Defaults to the key's region for OpenAI and Fireworks, otherwise `null`.<br/>
    /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public readonly partial struct CreateBYOKKeyRequestDeclaredRegion : global::System.IEquatable<CreateBYOKKeyRequestDeclaredRegion>
    {
        /// <summary>
        ///
        /// </summary>
        public CreateBYOKKeyRequestDeclaredRegion(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// the credential follows the region OpenRouter records for the endpoint. `europe` or `us` lets requests to `eu.openrouter.ai` or `us.openrouter.ai` use this credential for that provider (private endpoints, endpoints pinned to another cloud region, cross-region inference profiles and video models are excluded). Self-declared and not verified by OpenRouter. For OpenAI and Fireworks the region comes from the key material (a `{"api_key": ..., "region": ...}` key), so the value must match the key's region. Among other providers, only Azure accepts `europe` or `us`. Defaults to the key's region for OpenAI and Fireworks, otherwise `null`.
        /// </summary>
        public static CreateBYOKKeyRequestDeclaredRegion Europe { get; } = new("europe");

        /// <summary>
        /// the credential follows the region OpenRouter records for the endpoint. `europe` or `us` lets requests to `eu.openrouter.ai` or `us.openrouter.ai` use this credential for that provider (private endpoints, endpoints pinned to another cloud region, cross-region inference profiles and video models are excluded). Self-declared and not verified by OpenRouter. For OpenAI and Fireworks the region comes from the key material (a `{"api_key": ..., "region": ...}` key), so the value must match the key's region. Among other providers, only Azure accepts `europe` or `us`. Defaults to the key's region for OpenAI and Fireworks, otherwise `null`.
        /// </summary>
        public static CreateBYOKKeyRequestDeclaredRegion Global { get; } = new("global");

        /// <summary>
        /// the credential follows the region OpenRouter records for the endpoint. `europe` or `us` lets requests to `eu.openrouter.ai` or `us.openrouter.ai` use this credential for that provider (private endpoints, endpoints pinned to another cloud region, cross-region inference profiles and video models are excluded). Self-declared and not verified by OpenRouter. For OpenAI and Fireworks the region comes from the key material (a `{"api_key": ..., "region": ...}` key), so the value must match the key's region. Among other providers, only Azure accepts `europe` or `us`. Defaults to the key's region for OpenAI and Fireworks, otherwise `null`.
        /// </summary>
        public static CreateBYOKKeyRequestDeclaredRegion Us { get; } = new("us");
        /// <summary>
        ///
        /// </summary>
        public static CreateBYOKKeyRequestDeclaredRegion FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "europe" => Europe,
                "global" => Global,
                "us" => Us,
                _ => new CreateBYOKKeyRequestDeclaredRegion(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "europe" => true,
            "global" => true,
            "us" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(CreateBYOKKeyRequestDeclaredRegion other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateBYOKKeyRequestDeclaredRegion other && Equals(other);
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
        public static bool operator ==(CreateBYOKKeyRequestDeclaredRegion left, CreateBYOKKeyRequestDeclaredRegion right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateBYOKKeyRequestDeclaredRegion left, CreateBYOKKeyRequestDeclaredRegion right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBYOKKeyRequestDeclaredRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBYOKKeyRequestDeclaredRegion value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBYOKKeyRequestDeclaredRegion? ToEnum(string value)
        {
            return CreateBYOKKeyRequestDeclaredRegion.FromValue(value);
        }
    }
}