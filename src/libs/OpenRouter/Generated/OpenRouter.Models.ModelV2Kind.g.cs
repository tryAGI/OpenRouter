
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// What the record is: `model` for a served model variant, `router` for an OpenRouter router (`openrouter/auto`), `alias` for a `~author/family-latest` pointer. `kind.not=router` lists catalog models only<br/>
    /// Example: model
    /// </summary>
    public readonly partial struct ModelV2Kind : global::System.IEquatable<ModelV2Kind>
    {
        /// <summary>
        ///
        /// </summary>
        public ModelV2Kind(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// `model` for a served model variant, `router` for an OpenRouter router (`openrouter/auto`), `alias` for a `~author/family-latest` pointer. `kind.not=router` lists catalog models only
        /// </summary>
        public static ModelV2Kind Alias { get; } = new("alias");

        /// <summary>
        /// `model` for a served model variant, `router` for an OpenRouter router (`openrouter/auto`), `alias` for a `~author/family-latest` pointer. `kind.not=router` lists catalog models only
        /// </summary>
        public static ModelV2Kind Model { get; } = new("model");

        /// <summary>
        /// `model` for a served model variant, `router` for an OpenRouter router (`openrouter/auto`), `alias` for a `~author/family-latest` pointer. `kind.not=router` lists catalog models only
        /// </summary>
        public static ModelV2Kind Router { get; } = new("router");
        /// <summary>
        ///
        /// </summary>
        public static ModelV2Kind FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "alias" => Alias,
                "model" => Model,
                "router" => Router,
                _ => new ModelV2Kind(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "alias" => true,
            "model" => true,
            "router" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ModelV2Kind other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelV2Kind other && Equals(other);
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
        public static bool operator ==(ModelV2Kind left, ModelV2Kind right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ModelV2Kind left, ModelV2Kind right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelV2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelV2Kind value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelV2Kind? ToEnum(string value)
        {
            return ModelV2Kind.FromValue(value);
        }
    }
}