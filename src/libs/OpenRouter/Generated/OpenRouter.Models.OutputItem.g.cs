#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OutputItem : global::System.IEquatable<OutputItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResultOutputItemDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"content":[{"text":"Hello! How can I help you today?","type":"output_text"}],"id":"msg-abc123","role":"assistant","status":"completed","type":"message"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputMessage? Message { get; init; }
#else
        public global::OpenRouter.OutputMessage? Message { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputMessage? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessage PickMessage() => Message is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"id":"reasoning-abc123","summary":[{"text":"Analyzed the problem using first principles","type":"summary_text"}],"type":"reasoning"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemReasoning? Reasoning { get; init; }
#else
        public global::OpenRouter.OutputItemReasoning? Reasoning { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Reasoning))]
#endif
        public bool IsReasoning => Reasoning != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReasoning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemReasoning? value)
        {
            value = Reasoning;
            return IsReasoning;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemReasoning PickReasoning() => Reasoning is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Reasoning' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"arguments":"{\u0022location\u0022:\u0022San Francisco\u0022,\u0022unit\u0022:\u0022celsius\u0022}","call_id":"call-abc123","id":"call-abc123","name":"get_weather","type":"function_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemFunctionCall? FunctionCall { get; init; }
#else
        public global::OpenRouter.OutputItemFunctionCall? FunctionCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCall))]
#endif
        public bool IsFunctionCall => FunctionCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemFunctionCall? value)
        {
            value = FunctionCall;
            return IsFunctionCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFunctionCall PickFunctionCall() => FunctionCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCall' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"call_id":"call-abc123","id":"ctc-abc123","input":"*** Begin Patch\n*** End Patch","name":"apply_patch","status":"completed","type":"custom_tool_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemCustomToolCall? CustomToolCall { get; init; }
#else
        public global::OpenRouter.OutputItemCustomToolCall? CustomToolCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCall))]
#endif
        public bool IsCustomToolCall => CustomToolCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustomToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemCustomToolCall? value)
        {
            value = CustomToolCall;
            return IsCustomToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCustomToolCall PickCustomToolCall() => CustomToolCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCall' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"action":{"query":"OpenAI API","type":"search"},"id":"search-abc123","status":"completed","type":"web_search_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemWebSearchCall? WebSearchCall { get; init; }
#else
        public global::OpenRouter.OutputItemWebSearchCall? WebSearchCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchCall))]
#endif
        public bool IsWebSearchCall => WebSearchCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearchCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemWebSearchCall? value)
        {
            value = WebSearchCall;
            return IsWebSearchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCall PickWebSearchCall() => WebSearchCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchCall' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"id":"filesearch-abc123","queries":["machine learning algorithms","neural networks"],"status":"completed","type":"file_search_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemFileSearchCall? FileSearchCall { get; init; }
#else
        public global::OpenRouter.OutputItemFileSearchCall? FileSearchCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchCall))]
#endif
        public bool IsFileSearchCall => FileSearchCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFileSearchCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemFileSearchCall? value)
        {
            value = FileSearchCall;
            return IsFileSearchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFileSearchCall PickFileSearchCall() => FileSearchCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileSearchCall' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"id":"imagegen-abc123","result":"iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mNk\u002BM9QDwADhgGAWjR9awAAAABJRU5ErkJggg==","status":"completed","type":"image_generation_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemImageGenerationCall? ImageGenerationCall { get; init; }
#else
        public global::OpenRouter.OutputItemImageGenerationCall? ImageGenerationCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenerationCall))]
#endif
        public bool IsImageGenerationCall => ImageGenerationCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImageGenerationCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemImageGenerationCall? value)
        {
            value = ImageGenerationCall;
            return IsImageGenerationCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemImageGenerationCall PickImageGenerationCall() => ImageGenerationCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGenerationCall' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"call_id":"call_abc123","id":"apc_abc123","operation":{"diff":"@@ function main() {\n\u002B  console.log(\u0022hi\u0022);\n }","path":"/src/main.ts","type":"update_file"},"status":"completed","type":"apply_patch_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemApplyPatchCall? ApplyPatchCall { get; init; }
#else
        public global::OpenRouter.OutputItemApplyPatchCall? ApplyPatchCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCall))]
#endif
        public bool IsApplyPatchCall => ApplyPatchCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickApplyPatchCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemApplyPatchCall? value)
        {
            value = ApplyPatchCall;
            return IsApplyPatchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemApplyPatchCall PickApplyPatchCall() => ApplyPatchCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCall' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"code":"print(\u0022hello\u0022)","id":"ci_abc123","outputs":[{"logs":"hello\n","type":"logs"}],"status":"completed","type":"code_interpreter_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemCodeInterpreterCall? CodeInterpreterCall { get; init; }
#else
        public global::OpenRouter.OutputItemCodeInterpreterCall? CodeInterpreterCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCall))]
#endif
        public bool IsCodeInterpreterCall => CodeInterpreterCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeInterpreterCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemCodeInterpreterCall? value)
        {
            value = CodeInterpreterCall;
            return IsCodeInterpreterCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCodeInterpreterCall PickCodeInterpreterCall() => CodeInterpreterCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeInterpreterCall' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItem(global::OpenRouter.OutputMessage value) => new OutputItem((global::OpenRouter.OutputMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputMessage?(OutputItem @this) => @this.Message;

        /// <summary>
        ///
        /// </summary>
        public OutputItem(global::OpenRouter.OutputMessage? value)
        {
            Message = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItem FromMessage(global::OpenRouter.OutputMessage? value) => new OutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItem(global::OpenRouter.OutputItemReasoning value) => new OutputItem((global::OpenRouter.OutputItemReasoning?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemReasoning?(OutputItem @this) => @this.Reasoning;

        /// <summary>
        ///
        /// </summary>
        public OutputItem(global::OpenRouter.OutputItemReasoning? value)
        {
            Reasoning = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItem FromReasoning(global::OpenRouter.OutputItemReasoning? value) => new OutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItem(global::OpenRouter.OutputItemFunctionCall value) => new OutputItem((global::OpenRouter.OutputItemFunctionCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemFunctionCall?(OutputItem @this) => @this.FunctionCall;

        /// <summary>
        ///
        /// </summary>
        public OutputItem(global::OpenRouter.OutputItemFunctionCall? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItem FromFunctionCall(global::OpenRouter.OutputItemFunctionCall? value) => new OutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItem(global::OpenRouter.OutputItemCustomToolCall value) => new OutputItem((global::OpenRouter.OutputItemCustomToolCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemCustomToolCall?(OutputItem @this) => @this.CustomToolCall;

        /// <summary>
        ///
        /// </summary>
        public OutputItem(global::OpenRouter.OutputItemCustomToolCall? value)
        {
            CustomToolCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItem FromCustomToolCall(global::OpenRouter.OutputItemCustomToolCall? value) => new OutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItem(global::OpenRouter.OutputItemWebSearchCall value) => new OutputItem((global::OpenRouter.OutputItemWebSearchCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemWebSearchCall?(OutputItem @this) => @this.WebSearchCall;

        /// <summary>
        ///
        /// </summary>
        public OutputItem(global::OpenRouter.OutputItemWebSearchCall? value)
        {
            WebSearchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItem FromWebSearchCall(global::OpenRouter.OutputItemWebSearchCall? value) => new OutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItem(global::OpenRouter.OutputItemFileSearchCall value) => new OutputItem((global::OpenRouter.OutputItemFileSearchCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemFileSearchCall?(OutputItem @this) => @this.FileSearchCall;

        /// <summary>
        ///
        /// </summary>
        public OutputItem(global::OpenRouter.OutputItemFileSearchCall? value)
        {
            FileSearchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItem FromFileSearchCall(global::OpenRouter.OutputItemFileSearchCall? value) => new OutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItem(global::OpenRouter.OutputItemImageGenerationCall value) => new OutputItem((global::OpenRouter.OutputItemImageGenerationCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemImageGenerationCall?(OutputItem @this) => @this.ImageGenerationCall;

        /// <summary>
        ///
        /// </summary>
        public OutputItem(global::OpenRouter.OutputItemImageGenerationCall? value)
        {
            ImageGenerationCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItem FromImageGenerationCall(global::OpenRouter.OutputItemImageGenerationCall? value) => new OutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItem(global::OpenRouter.OutputItemApplyPatchCall value) => new OutputItem((global::OpenRouter.OutputItemApplyPatchCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemApplyPatchCall?(OutputItem @this) => @this.ApplyPatchCall;

        /// <summary>
        ///
        /// </summary>
        public OutputItem(global::OpenRouter.OutputItemApplyPatchCall? value)
        {
            ApplyPatchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItem FromApplyPatchCall(global::OpenRouter.OutputItemApplyPatchCall? value) => new OutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItem(global::OpenRouter.OutputItemCodeInterpreterCall value) => new OutputItem((global::OpenRouter.OutputItemCodeInterpreterCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemCodeInterpreterCall?(OutputItem @this) => @this.CodeInterpreterCall;

        /// <summary>
        ///
        /// </summary>
        public OutputItem(global::OpenRouter.OutputItemCodeInterpreterCall? value)
        {
            CodeInterpreterCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItem FromCodeInterpreterCall(global::OpenRouter.OutputItemCodeInterpreterCall? value) => new OutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public OutputItem(
            global::OpenRouter.BaseResponsesResultOutputItemDiscriminatorType? type,
            global::OpenRouter.OutputMessage? message,
            global::OpenRouter.OutputItemReasoning? reasoning,
            global::OpenRouter.OutputItemFunctionCall? functionCall,
            global::OpenRouter.OutputItemCustomToolCall? customToolCall,
            global::OpenRouter.OutputItemWebSearchCall? webSearchCall,
            global::OpenRouter.OutputItemFileSearchCall? fileSearchCall,
            global::OpenRouter.OutputItemImageGenerationCall? imageGenerationCall,
            global::OpenRouter.OutputItemApplyPatchCall? applyPatchCall,
            global::OpenRouter.OutputItemCodeInterpreterCall? codeInterpreterCall
            )
        {
            Type = type;

            Message = message;
            Reasoning = reasoning;
            FunctionCall = functionCall;
            CustomToolCall = customToolCall;
            WebSearchCall = webSearchCall;
            FileSearchCall = fileSearchCall;
            ImageGenerationCall = imageGenerationCall;
            ApplyPatchCall = applyPatchCall;
            CodeInterpreterCall = codeInterpreterCall;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CodeInterpreterCall as object ??
            ApplyPatchCall as object ??
            ImageGenerationCall as object ??
            FileSearchCall as object ??
            WebSearchCall as object ??
            CustomToolCall as object ??
            FunctionCall as object ??
            Reasoning as object ??
            Message as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            Reasoning?.ToString() ??
            FunctionCall?.ToString() ??
            CustomToolCall?.ToString() ??
            WebSearchCall?.ToString() ??
            FileSearchCall?.ToString() ??
            ImageGenerationCall?.ToString() ??
            ApplyPatchCall?.ToString() ??
            CodeInterpreterCall?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMessage && !IsReasoning && !IsFunctionCall && !IsCustomToolCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsApplyPatchCall && !IsCodeInterpreterCall || !IsMessage && IsReasoning && !IsFunctionCall && !IsCustomToolCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsApplyPatchCall && !IsCodeInterpreterCall || !IsMessage && !IsReasoning && IsFunctionCall && !IsCustomToolCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsApplyPatchCall && !IsCodeInterpreterCall || !IsMessage && !IsReasoning && !IsFunctionCall && IsCustomToolCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsApplyPatchCall && !IsCodeInterpreterCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsCustomToolCall && IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsApplyPatchCall && !IsCodeInterpreterCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsCustomToolCall && !IsWebSearchCall && IsFileSearchCall && !IsImageGenerationCall && !IsApplyPatchCall && !IsCodeInterpreterCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsCustomToolCall && !IsWebSearchCall && !IsFileSearchCall && IsImageGenerationCall && !IsApplyPatchCall && !IsCodeInterpreterCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsCustomToolCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && IsApplyPatchCall && !IsCodeInterpreterCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsCustomToolCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsApplyPatchCall && IsCodeInterpreterCall;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputMessage, TResult>? message = null,
            global::System.Func<global::OpenRouter.OutputItemReasoning, TResult>? reasoning = null,
            global::System.Func<global::OpenRouter.OutputItemFunctionCall, TResult>? functionCall = null,
            global::System.Func<global::OpenRouter.OutputItemCustomToolCall, TResult>? customToolCall = null,
            global::System.Func<global::OpenRouter.OutputItemWebSearchCall, TResult>? webSearchCall = null,
            global::System.Func<global::OpenRouter.OutputItemFileSearchCall, TResult>? fileSearchCall = null,
            global::System.Func<global::OpenRouter.OutputItemImageGenerationCall, TResult>? imageGenerationCall = null,
            global::System.Func<global::OpenRouter.OutputItemApplyPatchCall, TResult>? applyPatchCall = null,
            global::System.Func<global::OpenRouter.OutputItemCodeInterpreterCall, TResult>? codeInterpreterCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Message is { } __value0 && message != null)
            {
                return message(__value0);
            }
            else if (Reasoning is { } __value1 && reasoning != null)
            {
                return reasoning(__value1);
            }
            else if (FunctionCall is { } __value2 && functionCall != null)
            {
                return functionCall(__value2);
            }
            else if (CustomToolCall is { } __value3 && customToolCall != null)
            {
                return customToolCall(__value3);
            }
            else if (WebSearchCall is { } __value4 && webSearchCall != null)
            {
                return webSearchCall(__value4);
            }
            else if (FileSearchCall is { } __value5 && fileSearchCall != null)
            {
                return fileSearchCall(__value5);
            }
            else if (ImageGenerationCall is { } __value6 && imageGenerationCall != null)
            {
                return imageGenerationCall(__value6);
            }
            else if (ApplyPatchCall is { } __value7 && applyPatchCall != null)
            {
                return applyPatchCall(__value7);
            }
            else if (CodeInterpreterCall is { } __value8 && codeInterpreterCall != null)
            {
                return codeInterpreterCall(__value8);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputMessage>? message = null,

            global::System.Action<global::OpenRouter.OutputItemReasoning>? reasoning = null,

            global::System.Action<global::OpenRouter.OutputItemFunctionCall>? functionCall = null,

            global::System.Action<global::OpenRouter.OutputItemCustomToolCall>? customToolCall = null,

            global::System.Action<global::OpenRouter.OutputItemWebSearchCall>? webSearchCall = null,

            global::System.Action<global::OpenRouter.OutputItemFileSearchCall>? fileSearchCall = null,

            global::System.Action<global::OpenRouter.OutputItemImageGenerationCall>? imageGenerationCall = null,

            global::System.Action<global::OpenRouter.OutputItemApplyPatchCall>? applyPatchCall = null,

            global::System.Action<global::OpenRouter.OutputItemCodeInterpreterCall>? codeInterpreterCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Message is { } __value0)
            {
                message?.Invoke(__value0);
            }
            else if (Reasoning is { } __value1)
            {
                reasoning?.Invoke(__value1);
            }
            else if (FunctionCall is { } __value2)
            {
                functionCall?.Invoke(__value2);
            }
            else if (CustomToolCall is { } __value3)
            {
                customToolCall?.Invoke(__value3);
            }
            else if (WebSearchCall is { } __value4)
            {
                webSearchCall?.Invoke(__value4);
            }
            else if (FileSearchCall is { } __value5)
            {
                fileSearchCall?.Invoke(__value5);
            }
            else if (ImageGenerationCall is { } __value6)
            {
                imageGenerationCall?.Invoke(__value6);
            }
            else if (ApplyPatchCall is { } __value7)
            {
                applyPatchCall?.Invoke(__value7);
            }
            else if (CodeInterpreterCall is { } __value8)
            {
                codeInterpreterCall?.Invoke(__value8);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputMessage>? message = null,
            global::System.Action<global::OpenRouter.OutputItemReasoning>? reasoning = null,
            global::System.Action<global::OpenRouter.OutputItemFunctionCall>? functionCall = null,
            global::System.Action<global::OpenRouter.OutputItemCustomToolCall>? customToolCall = null,
            global::System.Action<global::OpenRouter.OutputItemWebSearchCall>? webSearchCall = null,
            global::System.Action<global::OpenRouter.OutputItemFileSearchCall>? fileSearchCall = null,
            global::System.Action<global::OpenRouter.OutputItemImageGenerationCall>? imageGenerationCall = null,
            global::System.Action<global::OpenRouter.OutputItemApplyPatchCall>? applyPatchCall = null,
            global::System.Action<global::OpenRouter.OutputItemCodeInterpreterCall>? codeInterpreterCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Message is { } __value0)
            {
                message?.Invoke(__value0);
            }
            else if (Reasoning is { } __value1)
            {
                reasoning?.Invoke(__value1);
            }
            else if (FunctionCall is { } __value2)
            {
                functionCall?.Invoke(__value2);
            }
            else if (CustomToolCall is { } __value3)
            {
                customToolCall?.Invoke(__value3);
            }
            else if (WebSearchCall is { } __value4)
            {
                webSearchCall?.Invoke(__value4);
            }
            else if (FileSearchCall is { } __value5)
            {
                fileSearchCall?.Invoke(__value5);
            }
            else if (ImageGenerationCall is { } __value6)
            {
                imageGenerationCall?.Invoke(__value6);
            }
            else if (ApplyPatchCall is { } __value7)
            {
                applyPatchCall?.Invoke(__value7);
            }
            else if (CodeInterpreterCall is { } __value8)
            {
                codeInterpreterCall?.Invoke(__value8);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Message,
                typeof(global::OpenRouter.OutputMessage),
                Reasoning,
                typeof(global::OpenRouter.OutputItemReasoning),
                FunctionCall,
                typeof(global::OpenRouter.OutputItemFunctionCall),
                CustomToolCall,
                typeof(global::OpenRouter.OutputItemCustomToolCall),
                WebSearchCall,
                typeof(global::OpenRouter.OutputItemWebSearchCall),
                FileSearchCall,
                typeof(global::OpenRouter.OutputItemFileSearchCall),
                ImageGenerationCall,
                typeof(global::OpenRouter.OutputItemImageGenerationCall),
                ApplyPatchCall,
                typeof(global::OpenRouter.OutputItemApplyPatchCall),
                CodeInterpreterCall,
                typeof(global::OpenRouter.OutputItemCodeInterpreterCall),
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
        public bool Equals(OutputItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputMessage?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemReasoning?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemFunctionCall?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemCustomToolCall?>.Default.Equals(CustomToolCall, other.CustomToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemWebSearchCall?>.Default.Equals(WebSearchCall, other.WebSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemFileSearchCall?>.Default.Equals(FileSearchCall, other.FileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemImageGenerationCall?>.Default.Equals(ImageGenerationCall, other.ImageGenerationCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemApplyPatchCall?>.Default.Equals(ApplyPatchCall, other.ApplyPatchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemCodeInterpreterCall?>.Default.Equals(CodeInterpreterCall, other.CodeInterpreterCall)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OutputItem obj1, OutputItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputItem obj1, OutputItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputItem o && Equals(o);
        }
    }
}
