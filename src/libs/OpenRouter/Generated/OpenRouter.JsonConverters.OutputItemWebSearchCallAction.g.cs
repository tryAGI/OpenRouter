#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class OutputItemWebSearchCallActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.OutputItemWebSearchCallAction>
    {
        /// <inheritdoc />
        public override global::OpenRouter.OutputItemWebSearchCallAction Read(
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
            if (__jsonProps.Contains("queries")) __score0++;
            if (__jsonProps.Contains("query")) __score0++;
            if (__jsonProps.Contains("sources")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("url")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("pattern")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("url")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::OpenRouter.OutputItemWebSearchCallAction0? outputItemWebSearchCallAction0 = default;
            global::OpenRouter.OutputItemWebSearchCallAction1? outputItemWebSearchCallAction1 = default;
            global::OpenRouter.OutputItemWebSearchCallAction2? outputItemWebSearchCallAction2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        outputItemWebSearchCallAction0 = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.OutputItemWebSearchCallAction0>(__rawJson, options);
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
                        outputItemWebSearchCallAction1 = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.OutputItemWebSearchCallAction1>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        outputItemWebSearchCallAction2 = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.OutputItemWebSearchCallAction2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (outputItemWebSearchCallAction0 == null && outputItemWebSearchCallAction1 == null && outputItemWebSearchCallAction2 == null)
            {
                try
                {
                    outputItemWebSearchCallAction0 = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.OutputItemWebSearchCallAction0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputItemWebSearchCallAction1 = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.OutputItemWebSearchCallAction1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputItemWebSearchCallAction2 = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.OutputItemWebSearchCallAction2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.OutputItemWebSearchCallAction(
                outputItemWebSearchCallAction0,

                outputItemWebSearchCallAction1,

                outputItemWebSearchCallAction2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.OutputItemWebSearchCallAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsOutputItemWebSearchCallAction0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemWebSearchCallAction0, typeof(global::OpenRouter.OutputItemWebSearchCallAction0), options);
            }
            else if (value.IsOutputItemWebSearchCallAction1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemWebSearchCallAction1, typeof(global::OpenRouter.OutputItemWebSearchCallAction1), options);
            }
            else if (value.IsOutputItemWebSearchCallAction2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemWebSearchCallAction2, typeof(global::OpenRouter.OutputItemWebSearchCallAction2), options);
            }
        }
    }
}