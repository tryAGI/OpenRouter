#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class QuestionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.Questions>
    {
        /// <inheritdoc />
        public override global::OpenRouter.Questions Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DecisionsRequestQuestionsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DecisionsRequestQuestionsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.DecisionsRequestQuestionsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.DecisionsNoulQuestion? noul = default;
            if (discriminator?.Type == global::OpenRouter.DecisionsRequestQuestionsDiscriminatorType.Noul)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DecisionsNoulQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DecisionsNoulQuestion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.DecisionsNoulQuestion)}");
                noul = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.DecisionsChoiceQuestion? choice = default;
            if (discriminator?.Type == global::OpenRouter.DecisionsRequestQuestionsDiscriminatorType.Choice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DecisionsChoiceQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DecisionsChoiceQuestion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.DecisionsChoiceQuestion)}");
                choice = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.DecisionsScoreQuestion? score = default;
            if (discriminator?.Type == global::OpenRouter.DecisionsRequestQuestionsDiscriminatorType.Score)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DecisionsScoreQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DecisionsScoreQuestion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.DecisionsScoreQuestion)}");
                score = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.Questions(
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
            global::OpenRouter.Questions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNoul)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DecisionsNoulQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DecisionsNoulQuestion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.DecisionsNoulQuestion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNoul(), typeInfo);
            }
            else if (value.IsChoice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DecisionsChoiceQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DecisionsChoiceQuestion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.DecisionsChoiceQuestion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickChoice(), typeInfo);
            }
            else if (value.IsScore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DecisionsScoreQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DecisionsScoreQuestion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.DecisionsScoreQuestion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickScore(), typeInfo);
            }
        }
    }
}