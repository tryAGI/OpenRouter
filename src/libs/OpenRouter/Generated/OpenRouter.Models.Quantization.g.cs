
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: fp16
    /// </summary>
    public readonly partial struct Quantization : global::System.IEquatable<Quantization>
    {
        /// <summary>
        ///
        /// </summary>
        public Quantization(string value)
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
        public static Quantization Bf16 { get; } = new("bf16");

        /// <summary>
        ///
        /// </summary>
        public static Quantization Fp16 { get; } = new("fp16");

        /// <summary>
        ///
        /// </summary>
        public static Quantization Fp32 { get; } = new("fp32");

        /// <summary>
        ///
        /// </summary>
        public static Quantization Fp4 { get; } = new("fp4");

        /// <summary>
        ///
        /// </summary>
        public static Quantization Fp6 { get; } = new("fp6");

        /// <summary>
        ///
        /// </summary>
        public static Quantization Fp8 { get; } = new("fp8");

        /// <summary>
        ///
        /// </summary>
        public static Quantization Int4 { get; } = new("int4");

        /// <summary>
        ///
        /// </summary>
        public static Quantization Int8 { get; } = new("int8");

        /// <summary>
        ///
        /// </summary>
        public static Quantization Mxfp4 { get; } = new("mxfp4");

        /// <summary>
        ///
        /// </summary>
        public static Quantization Mxfp8 { get; } = new("mxfp8");

        /// <summary>
        ///
        /// </summary>
        public static Quantization Nvfp4 { get; } = new("nvfp4");

        /// <summary>
        ///
        /// </summary>
        public static Quantization Unknown { get; } = new("unknown");
        /// <summary>
        ///
        /// </summary>
        public static Quantization FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "bf16" => Bf16,
                "fp16" => Fp16,
                "fp32" => Fp32,
                "fp4" => Fp4,
                "fp6" => Fp6,
                "fp8" => Fp8,
                "int4" => Int4,
                "int8" => Int8,
                "mxfp4" => Mxfp4,
                "mxfp8" => Mxfp8,
                "nvfp4" => Nvfp4,
                "unknown" => Unknown,
                _ => new Quantization(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "bf16" => true,
            "fp16" => true,
            "fp32" => true,
            "fp4" => true,
            "fp6" => true,
            "fp8" => true,
            "int4" => true,
            "int8" => true,
            "mxfp4" => true,
            "mxfp8" => true,
            "nvfp4" => true,
            "unknown" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(Quantization other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Quantization other && Equals(other);
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
        public static bool operator ==(Quantization left, Quantization right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Quantization left, Quantization right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QuantizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Quantization value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Quantization? ToEnum(string value)
        {
            return Quantization.FromValue(value);
        }
    }
}