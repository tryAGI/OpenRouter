#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class Answers2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.Answers2>
    {
        /// <inheritdoc />
        public override global::OpenRouter.Answers2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionsResponseAnswersDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionsResponseAnswersDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionsResponseAnswersDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.ExtractionTextAnswer? text = default;
            if (discriminator?.Type == global::OpenRouter.ExtractionsResponseAnswersDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionTextAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionTextAnswer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionTextAnswer)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ExtractionNumberAnswer? number = default;
            if (discriminator?.Type == global::OpenRouter.ExtractionsResponseAnswersDiscriminatorType.Number)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionNumberAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionNumberAnswer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionNumberAnswer)}");
                number = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ExtractionDateAnswer? date = default;
            if (discriminator?.Type == global::OpenRouter.ExtractionsResponseAnswersDiscriminatorType.Date)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionDateAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionDateAnswer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionDateAnswer)}");
                date = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ExtractionTimeAnswer? time = default;
            if (discriminator?.Type == global::OpenRouter.ExtractionsResponseAnswersDiscriminatorType.Time)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionTimeAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionTimeAnswer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionTimeAnswer)}");
                time = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ExtractionDatetimeAnswer? datetime = default;
            if (discriminator?.Type == global::OpenRouter.ExtractionsResponseAnswersDiscriminatorType.Datetime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionDatetimeAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionDatetimeAnswer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionDatetimeAnswer)}");
                datetime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ExtractionDurationAnswer? duration = default;
            if (discriminator?.Type == global::OpenRouter.ExtractionsResponseAnswersDiscriminatorType.Duration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionDurationAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionDurationAnswer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionDurationAnswer)}");
                duration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ExtractionListAnswer? list = default;
            if (discriminator?.Type == global::OpenRouter.ExtractionsResponseAnswersDiscriminatorType.List)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionListAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionListAnswer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionListAnswer)}");
                list = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ExtractionEstimateAnswer? estimate = default;
            if (discriminator?.Type == global::OpenRouter.ExtractionsResponseAnswersDiscriminatorType.Estimate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionEstimateAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionEstimateAnswer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionEstimateAnswer)}");
                estimate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ExtractionForecastAnswer? forecast = default;
            if (discriminator?.Type == global::OpenRouter.ExtractionsResponseAnswersDiscriminatorType.Forecast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionForecastAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionForecastAnswer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionForecastAnswer)}");
                forecast = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.Answers2(
                discriminator?.Type,
                text,

                number,

                date,

                time,

                datetime,

                duration,

                list,

                estimate,

                forecast
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.Answers2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionTextAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionTextAnswer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ExtractionTextAnswer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickText(), typeInfo);
            }
            else if (value.IsNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionNumberAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionNumberAnswer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ExtractionNumberAnswer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNumber(), typeInfo);
            }
            else if (value.IsDate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionDateAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionDateAnswer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ExtractionDateAnswer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDate(), typeInfo);
            }
            else if (value.IsTime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionTimeAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionTimeAnswer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ExtractionTimeAnswer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTime(), typeInfo);
            }
            else if (value.IsDatetime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionDatetimeAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionDatetimeAnswer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ExtractionDatetimeAnswer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDatetime(), typeInfo);
            }
            else if (value.IsDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionDurationAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionDurationAnswer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ExtractionDurationAnswer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDuration(), typeInfo);
            }
            else if (value.IsList)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionListAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionListAnswer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ExtractionListAnswer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickList(), typeInfo);
            }
            else if (value.IsEstimate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionEstimateAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionEstimateAnswer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ExtractionEstimateAnswer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickEstimate(), typeInfo);
            }
            else if (value.IsForecast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionForecastAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionForecastAnswer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ExtractionForecastAnswer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickForecast(), typeInfo);
            }
        }
    }
}