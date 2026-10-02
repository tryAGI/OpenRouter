
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Instruction format type<br/>
    /// Example: chatml
    /// </summary>
    public readonly partial struct InstructType : global::System.IEquatable<InstructType>
    {
        /// <summary>
        ///
        /// </summary>
        public InstructType(string value)
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
        public static InstructType Airoboros { get; } = new("airoboros");

        /// <summary>
        ///
        /// </summary>
        public static InstructType Alpaca { get; } = new("alpaca");

        /// <summary>
        ///
        /// </summary>
        public static InstructType AlpacaModif { get; } = new("alpaca-modif");

        /// <summary>
        ///
        /// </summary>
        public static InstructType Chatml { get; } = new("chatml");

        /// <summary>
        ///
        /// </summary>
        public static InstructType Claude { get; } = new("claude");

        /// <summary>
        ///
        /// </summary>
        public static InstructType CodeLlama { get; } = new("code-llama");

        /// <summary>
        ///
        /// </summary>
        public static InstructType DeepseekR1 { get; } = new("deepseek-r1");

        /// <summary>
        ///
        /// </summary>
        public static InstructType DeepseekV31 { get; } = new("deepseek-v3.1");

        /// <summary>
        ///
        /// </summary>
        public static InstructType Gemma { get; } = new("gemma");

        /// <summary>
        ///
        /// </summary>
        public static InstructType Llama2 { get; } = new("llama2");

        /// <summary>
        ///
        /// </summary>
        public static InstructType Llama3 { get; } = new("llama3");

        /// <summary>
        ///
        /// </summary>
        public static InstructType Mistral { get; } = new("mistral");

        /// <summary>
        ///
        /// </summary>
        public static InstructType Nemotron { get; } = new("nemotron");

        /// <summary>
        ///
        /// </summary>
        public static InstructType Neural { get; } = new("neural");

        /// <summary>
        ///
        /// </summary>
        public static InstructType None { get; } = new("none");

        /// <summary>
        ///
        /// </summary>
        public static InstructType Openchat { get; } = new("openchat");

        /// <summary>
        ///
        /// </summary>
        public static InstructType Phi3 { get; } = new("phi3");

        /// <summary>
        ///
        /// </summary>
        public static InstructType Qwen3 { get; } = new("qwen3");

        /// <summary>
        ///
        /// </summary>
        public static InstructType Qwq { get; } = new("qwq");

        /// <summary>
        ///
        /// </summary>
        public static InstructType Rwkv { get; } = new("rwkv");

        /// <summary>
        ///
        /// </summary>
        public static InstructType Vicuna { get; } = new("vicuna");

        /// <summary>
        ///
        /// </summary>
        public static InstructType Zephyr { get; } = new("zephyr");
        /// <summary>
        ///
        /// </summary>
        public static InstructType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "airoboros" => Airoboros,
                "alpaca" => Alpaca,
                "alpaca-modif" => AlpacaModif,
                "chatml" => Chatml,
                "claude" => Claude,
                "code-llama" => CodeLlama,
                "deepseek-r1" => DeepseekR1,
                "deepseek-v3.1" => DeepseekV31,
                "gemma" => Gemma,
                "llama2" => Llama2,
                "llama3" => Llama3,
                "mistral" => Mistral,
                "nemotron" => Nemotron,
                "neural" => Neural,
                "none" => None,
                "openchat" => Openchat,
                "phi3" => Phi3,
                "qwen3" => Qwen3,
                "qwq" => Qwq,
                "rwkv" => Rwkv,
                "vicuna" => Vicuna,
                "zephyr" => Zephyr,
                _ => new InstructType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "airoboros" => true,
            "alpaca" => true,
            "alpaca-modif" => true,
            "chatml" => true,
            "claude" => true,
            "code-llama" => true,
            "deepseek-r1" => true,
            "deepseek-v3.1" => true,
            "gemma" => true,
            "llama2" => true,
            "llama3" => true,
            "mistral" => true,
            "nemotron" => true,
            "neural" => true,
            "none" => true,
            "openchat" => true,
            "phi3" => true,
            "qwen3" => true,
            "qwq" => true,
            "rwkv" => true,
            "vicuna" => true,
            "zephyr" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(InstructType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InstructType other && Equals(other);
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
        public static bool operator ==(InstructType left, InstructType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InstructType left, InstructType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InstructTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InstructType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InstructType? ToEnum(string value)
        {
            return InstructType.FromValue(value);
        }
    }
}