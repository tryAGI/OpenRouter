#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class FieldsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.Fields>
    {
        /// <inheritdoc />
        public override global::OpenRouter.Fields Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionsRequestFieldsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionsRequestFieldsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionsRequestFieldsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.ExtractionTextField? text = default;
            if (discriminator?.Type == global::OpenRouter.ExtractionsRequestFieldsDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionTextField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionTextField> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionTextField)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ExtractionNumberField? number = default;
            if (discriminator?.Type == global::OpenRouter.ExtractionsRequestFieldsDiscriminatorType.Number)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionNumberField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionNumberField> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionNumberField)}");
                number = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ExtractionDateField? date = default;
            if (discriminator?.Type == global::OpenRouter.ExtractionsRequestFieldsDiscriminatorType.Date)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionDateField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionDateField> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionDateField)}");
                date = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ExtractionTimeField? time = default;
            if (discriminator?.Type == global::OpenRouter.ExtractionsRequestFieldsDiscriminatorType.Time)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionTimeField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionTimeField> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionTimeField)}");
                time = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ExtractionDatetimeField? datetime = default;
            if (discriminator?.Type == global::OpenRouter.ExtractionsRequestFieldsDiscriminatorType.Datetime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionDatetimeField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionDatetimeField> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionDatetimeField)}");
                datetime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ExtractionDurationField? duration = default;
            if (discriminator?.Type == global::OpenRouter.ExtractionsRequestFieldsDiscriminatorType.Duration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionDurationField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionDurationField> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionDurationField)}");
                duration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ExtractionListField? list = default;
            if (discriminator?.Type == global::OpenRouter.ExtractionsRequestFieldsDiscriminatorType.List)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionListField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionListField> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionListField)}");
                list = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ExtractionEstimateField? estimate = default;
            if (discriminator?.Type == global::OpenRouter.ExtractionsRequestFieldsDiscriminatorType.Estimate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionEstimateField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionEstimateField> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionEstimateField)}");
                estimate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ExtractionForecastField? forecast = default;
            if (discriminator?.Type == global::OpenRouter.ExtractionsRequestFieldsDiscriminatorType.Forecast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionForecastField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionForecastField> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ExtractionForecastField)}");
                forecast = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.Fields(
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
            global::OpenRouter.Fields value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionTextField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionTextField?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ExtractionTextField).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickText(), typeInfo);
            }
            else if (value.IsNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionNumberField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionNumberField?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ExtractionNumberField).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNumber(), typeInfo);
            }
            else if (value.IsDate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionDateField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionDateField?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ExtractionDateField).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDate(), typeInfo);
            }
            else if (value.IsTime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionTimeField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionTimeField?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ExtractionTimeField).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTime(), typeInfo);
            }
            else if (value.IsDatetime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionDatetimeField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionDatetimeField?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ExtractionDatetimeField).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDatetime(), typeInfo);
            }
            else if (value.IsDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionDurationField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionDurationField?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ExtractionDurationField).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDuration(), typeInfo);
            }
            else if (value.IsList)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionListField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionListField?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ExtractionListField).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickList(), typeInfo);
            }
            else if (value.IsEstimate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionEstimateField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionEstimateField?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ExtractionEstimateField).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickEstimate(), typeInfo);
            }
            else if (value.IsForecast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ExtractionForecastField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ExtractionForecastField?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ExtractionForecastField).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickForecast(), typeInfo);
            }
        }
    }
}