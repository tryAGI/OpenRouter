
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreditPurchaseStatus : global::System.IEquatable<CreditPurchaseStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public CreditPurchaseStatus(string value)
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
        public static CreditPurchaseStatus AwaitingPayment { get; } = new("awaiting_payment");

        /// <summary>
        ///
        /// </summary>
        public static CreditPurchaseStatus Credited { get; } = new("credited");

        /// <summary>
        ///
        /// </summary>
        public static CreditPurchaseStatus Failed { get; } = new("failed");

        /// <summary>
        ///
        /// </summary>
        public static CreditPurchaseStatus Processing { get; } = new("processing");
        /// <summary>
        ///
        /// </summary>
        public static CreditPurchaseStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "awaiting_payment" => AwaitingPayment,
                "credited" => Credited,
                "failed" => Failed,
                "processing" => Processing,
                _ => new CreditPurchaseStatus(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "awaiting_payment" => true,
            "credited" => true,
            "failed" => true,
            "processing" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(CreditPurchaseStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreditPurchaseStatus other && Equals(other);
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
        public static bool operator ==(CreditPurchaseStatus left, CreditPurchaseStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreditPurchaseStatus left, CreditPurchaseStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreditPurchaseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreditPurchaseStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreditPurchaseStatus? ToEnum(string value)
        {
            return CreditPurchaseStatus.FromValue(value);
        }
    }
}