
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Only return endpoints in the given data region ("eu" or "us"); models left without an endpoint are omitted.<br/>
    /// Example: eu
    /// </summary>
    public readonly partial struct ListModelsV2Region : global::System.IEquatable<ListModelsV2Region>
    {
        /// <summary>
        ///
        /// </summary>
        public ListModelsV2Region(string value)
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
        public static ListModelsV2Region Eu { get; } = new("eu");

        /// <summary>
        ///
        /// </summary>
        public static ListModelsV2Region Us { get; } = new("us");
        /// <summary>
        ///
        /// </summary>
        public static ListModelsV2Region FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "eu" => Eu,
                "us" => Us,
                _ => new ListModelsV2Region(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "eu" => true,
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
        public bool Equals(ListModelsV2Region other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListModelsV2Region other && Equals(other);
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
        public static bool operator ==(ListModelsV2Region left, ListModelsV2Region right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ListModelsV2Region left, ListModelsV2Region right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListModelsV2RegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListModelsV2Region value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListModelsV2Region? ToEnum(string value)
        {
            return ListModelsV2Region.FromValue(value);
        }
    }
}