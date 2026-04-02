#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class OutputMessageContentItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.OutputMessageContentItems>
    {
        /// <inheritdoc />
        public override global::OpenRouter.OutputMessageContentItems Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("annotations")) __score0++;
            if (__jsonProps.Contains("logprobs")) __score0++;
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("refusal")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::OpenRouter.ResponseOutputText? responseOutputText = default;
            global::OpenRouter.OpenAIResponsesRefusalContent? openAIResponsesRefusalContent = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        responseOutputText = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ResponseOutputText>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        openAIResponsesRefusalContent = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.OpenAIResponsesRefusalContent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (responseOutputText == null && openAIResponsesRefusalContent == null)
            {
                try
                {
                    responseOutputText = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ResponseOutputText>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    openAIResponsesRefusalContent = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.OpenAIResponsesRefusalContent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.OutputMessageContentItems(
                responseOutputText,

                openAIResponsesRefusalContent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.OutputMessageContentItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsResponseOutputText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputText, typeof(global::OpenRouter.ResponseOutputText), options);
            }
            else if (value.IsOpenAIResponsesRefusalContent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAIResponsesRefusalContent, typeof(global::OpenRouter.OpenAIResponsesRefusalContent), options);
            }
        }
    }
}