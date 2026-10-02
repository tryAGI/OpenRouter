#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class AnswersJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.Answers>
    {
        /// <inheritdoc />
        public override global::OpenRouter.Answers Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DecisionsResponseAnswersDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DecisionsResponseAnswersDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.DecisionsResponseAnswersDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.DecisionsNoulAnswer? noul = default;
            if (discriminator?.Type == global::OpenRouter.DecisionsResponseAnswersDiscriminatorType.Noul)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DecisionsNoulAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DecisionsNoulAnswer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.DecisionsNoulAnswer)}");
                noul = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.DecisionsChoiceAnswer? choice = default;
            if (discriminator?.Type == global::OpenRouter.DecisionsResponseAnswersDiscriminatorType.Choice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DecisionsChoiceAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DecisionsChoiceAnswer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.DecisionsChoiceAnswer)}");
                choice = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.DecisionsScoreAnswer? score = default;
            if (discriminator?.Type == global::OpenRouter.DecisionsResponseAnswersDiscriminatorType.Score)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DecisionsScoreAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DecisionsScoreAnswer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.DecisionsScoreAnswer)}");
                score = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.Answers(
                discriminator?.Type,
                noul,

                choice,

                score
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.Answers value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNoul)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DecisionsNoulAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DecisionsNoulAnswer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.DecisionsNoulAnswer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNoul(), typeInfo);
            }
            else if (value.IsChoice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DecisionsChoiceAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DecisionsChoiceAnswer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.DecisionsChoiceAnswer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickChoice(), typeInfo);
            }
            else if (value.IsScore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DecisionsScoreAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DecisionsScoreAnswer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.DecisionsScoreAnswer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickScore(), typeInfo);
            }
        }
    }
}