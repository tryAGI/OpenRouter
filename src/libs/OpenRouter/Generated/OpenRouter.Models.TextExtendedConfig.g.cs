#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Text output configuration including format and verbosity<br/>
    /// Example: {"format":{"type":"text"}}
    /// </summary>
    public readonly partial struct TextExtendedConfig : global::System.IEquatable<TextExtendedConfig>
    {
        /// <summary>
        /// Text output configuration including format and verbosity<br/>
        /// Example: {"format":{"type":"text"},"verbosity":"medium"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.TextConfig? TextConfig { get; init; }
#else
        public global::OpenRouter.TextConfig? TextConfig { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextConfig))]
#endif
        public bool IsTextConfig => TextConfig != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.TextConfig? value)
        {
            value = TextConfig;
            return IsTextConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextConfig PickTextConfig() => TextConfig is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextConfig' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.TextExtendedConfigVariant2? TextExtendedConfigVariant2 { get; init; }
#else
        public global::OpenRouter.TextExtendedConfigVariant2? TextExtendedConfigVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextExtendedConfigVariant2))]
#endif
        public bool IsTextExtendedConfigVariant2 => TextExtendedConfigVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextExtendedConfigVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.TextExtendedConfigVariant2? value)
        {
            value = TextExtendedConfigVariant2;
            return IsTextExtendedConfigVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextExtendedConfigVariant2 PickTextExtendedConfigVariant2() => TextExtendedConfigVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextExtendedConfigVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextExtendedConfig(global::OpenRouter.TextConfig value) => new TextExtendedConfig((global::OpenRouter.TextConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.TextConfig?(TextExtendedConfig @this) => @this.TextConfig;

        /// <summary>
        ///
        /// </summary>
        public TextExtendedConfig(global::OpenRouter.TextConfig? value)
        {
            TextConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextExtendedConfig FromTextConfig(global::OpenRouter.TextConfig? value) => new TextExtendedConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextExtendedConfig(global::OpenRouter.TextExtendedConfigVariant2 value) => new TextExtendedConfig((global::OpenRouter.TextExtendedConfigVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.TextExtendedConfigVariant2?(TextExtendedConfig @this) => @this.TextExtendedConfigVariant2;

        /// <summary>
        ///
        /// </summary>
        public TextExtendedConfig(global::OpenRouter.TextExtendedConfigVariant2? value)
        {
            TextExtendedConfigVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextExtendedConfig FromTextExtendedConfigVariant2(global::OpenRouter.TextExtendedConfigVariant2? value) => new TextExtendedConfig(value);

        /// <summary>
        ///
        /// </summary>
        public TextExtendedConfig(
            global::OpenRouter.TextConfig? textConfig,
            global::OpenRouter.TextExtendedConfigVariant2? textExtendedConfigVariant2
            )
        {
            TextConfig = textConfig;
            TextExtendedConfigVariant2 = textExtendedConfigVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TextExtendedConfigVariant2 as object ??
            TextConfig as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TextConfig?.ToString() ??
            TextExtendedConfigVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTextConfig && IsTextExtendedConfigVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.TextConfig, TResult>? textConfig = null,
            global::System.Func<global::OpenRouter.TextExtendedConfigVariant2, TResult>? textExtendedConfigVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextConfig is { } __value0 && textConfig != null)
            {
                return textConfig(__value0);
            }
            else if (TextExtendedConfigVariant2 is { } __value1 && textExtendedConfigVariant2 != null)
            {
                return textExtendedConfigVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.TextConfig>? textConfig = null,

            global::System.Action<global::OpenRouter.TextExtendedConfigVariant2>? textExtendedConfigVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextConfig is { } __value0)
            {
                textConfig?.Invoke(__value0);
            }
            else if (TextExtendedConfigVariant2 is { } __value1)
            {
                textExtendedConfigVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.TextConfig>? textConfig = null,
            global::System.Action<global::OpenRouter.TextExtendedConfigVariant2>? textExtendedConfigVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextConfig is { } __value0)
            {
                textConfig?.Invoke(__value0);
            }
            else if (TextExtendedConfigVariant2 is { } __value1)
            {
                textExtendedConfigVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextConfig,
                typeof(global::OpenRouter.TextConfig),
                TextExtendedConfigVariant2,
                typeof(global::OpenRouter.TextExtendedConfigVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(TextExtendedConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.TextConfig?>.Default.Equals(TextConfig, other.TextConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.TextExtendedConfigVariant2?>.Default.Equals(TextExtendedConfigVariant2, other.TextExtendedConfigVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TextExtendedConfig obj1, TextExtendedConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextExtendedConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TextExtendedConfig obj1, TextExtendedConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextExtendedConfig o && Equals(o);
        }
    }
}
