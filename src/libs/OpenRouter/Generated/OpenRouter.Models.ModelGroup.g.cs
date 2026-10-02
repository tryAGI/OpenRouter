
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Tokenizer type used by the model<br/>
    /// Example: GPT
    /// </summary>
    public readonly partial struct ModelGroup : global::System.IEquatable<ModelGroup>
    {
        /// <summary>
        ///
        /// </summary>
        public ModelGroup(string value)
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
        public static ModelGroup Claude { get; } = new("Claude");

        /// <summary>
        ///
        /// </summary>
        public static ModelGroup Cohere { get; } = new("Cohere");

        /// <summary>
        ///
        /// </summary>
        public static ModelGroup DeepSeek { get; } = new("DeepSeek");

        /// <summary>
        ///
        /// </summary>
        public static ModelGroup Gpt { get; } = new("GPT");

        /// <summary>
        ///
        /// </summary>
        public static ModelGroup Gemini { get; } = new("Gemini");

        /// <summary>
        ///
        /// </summary>
        public static ModelGroup Gemma { get; } = new("Gemma");

        /// <summary>
        ///
        /// </summary>
        public static ModelGroup Grok { get; } = new("Grok");

        /// <summary>
        ///
        /// </summary>
        public static ModelGroup Llama2 { get; } = new("Llama2");

        /// <summary>
        ///
        /// </summary>
        public static ModelGroup Llama3 { get; } = new("Llama3");

        /// <summary>
        ///
        /// </summary>
        public static ModelGroup Llama4 { get; } = new("Llama4");

        /// <summary>
        ///
        /// </summary>
        public static ModelGroup Media { get; } = new("Media");

        /// <summary>
        ///
        /// </summary>
        public static ModelGroup Mistral { get; } = new("Mistral");

        /// <summary>
        ///
        /// </summary>
        public static ModelGroup Nova { get; } = new("Nova");

        /// <summary>
        ///
        /// </summary>
        public static ModelGroup Other { get; } = new("Other");

        /// <summary>
        ///
        /// </summary>
        public static ModelGroup PaLM { get; } = new("PaLM");

        /// <summary>
        ///
        /// </summary>
        public static ModelGroup Qwen { get; } = new("Qwen");

        /// <summary>
        ///
        /// </summary>
        public static ModelGroup Qwen3 { get; } = new("Qwen3");

        /// <summary>
        ///
        /// </summary>
        public static ModelGroup Rwkv { get; } = new("RWKV");

        /// <summary>
        ///
        /// </summary>
        public static ModelGroup Router { get; } = new("Router");

        /// <summary>
        ///
        /// </summary>
        public static ModelGroup Yi { get; } = new("Yi");
        /// <summary>
        ///
        /// </summary>
        public static ModelGroup FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "Claude" => Claude,
                "Cohere" => Cohere,
                "DeepSeek" => DeepSeek,
                "GPT" => Gpt,
                "Gemini" => Gemini,
                "Gemma" => Gemma,
                "Grok" => Grok,
                "Llama2" => Llama2,
                "Llama3" => Llama3,
                "Llama4" => Llama4,
                "Media" => Media,
                "Mistral" => Mistral,
                "Nova" => Nova,
                "Other" => Other,
                "PaLM" => PaLM,
                "Qwen" => Qwen,
                "Qwen3" => Qwen3,
                "RWKV" => Rwkv,
                "Router" => Router,
                "Yi" => Yi,
                _ => new ModelGroup(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "Claude" => true,
            "Cohere" => true,
            "DeepSeek" => true,
            "GPT" => true,
            "Gemini" => true,
            "Gemma" => true,
            "Grok" => true,
            "Llama2" => true,
            "Llama3" => true,
            "Llama4" => true,
            "Media" => true,
            "Mistral" => true,
            "Nova" => true,
            "Other" => true,
            "PaLM" => true,
            "Qwen" => true,
            "Qwen3" => true,
            "RWKV" => true,
            "Router" => true,
            "Yi" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ModelGroup other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelGroup other && Equals(other);
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
        public static bool operator ==(ModelGroup left, ModelGroup right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ModelGroup left, ModelGroup right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelGroup value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelGroup? ToEnum(string value)
        {
            return ModelGroup.FromValue(value);
        }
    }
}