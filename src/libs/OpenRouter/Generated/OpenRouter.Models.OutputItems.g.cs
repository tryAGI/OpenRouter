#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An output item from the response
    /// </summary>
    public readonly partial struct OutputItems : global::System.IEquatable<OutputItems>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsDiscriminatorType? Type { get; }

        /// <summary>
        /// A native `apply_patch_call` output item matching OpenAI's Responses API shape. Emitted when the client requested the `apply_patch` shorthand.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant1? ApplyPatchCall { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant1? ApplyPatchCall { get; }
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
            out global::OpenRouter.OutputItemsVariant1? value)
        {
            value = ApplyPatchCall;
            return IsApplyPatchCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant1 PickApplyPatchCall() => IsApplyPatchCall
            ? ApplyPatchCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCall' but the value was {ToString()}.");

        /// <summary>
        /// A code interpreter execution call with outputs
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant2? CodeInterpreterCall { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant2? CodeInterpreterCall { get; }
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
            out global::OpenRouter.OutputItemsVariant2? value)
        {
            value = CodeInterpreterCall;
            return IsCodeInterpreterCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant2 PickCodeInterpreterCall() => IsCodeInterpreterCall
            ? CodeInterpreterCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeInterpreterCall' but the value was {ToString()}.");

        /// <summary>
        /// computer_call variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant3? ComputerCall { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant3? ComputerCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerCall))]
#endif
        public bool IsComputerCall => ComputerCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickComputerCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemsVariant3? value)
        {
            value = ComputerCall;
            return IsComputerCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant3 PickComputerCall() => IsComputerCall
            ? ComputerCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerCall' but the value was {ToString()}.");

        /// <summary>
        /// A call to a custom (freeform-grammar) tool created by the model — distinct from `function_call`. Used for tools like Codex CLI's `apply_patch` whose payload is opaque text rather than JSON arguments.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant4? CustomToolCall { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant4? CustomToolCall { get; }
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
            out global::OpenRouter.OutputItemsVariant4? value)
        {
            value = CustomToolCall;
            return IsCustomToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant4 PickCustomToolCall() => IsCustomToolCall
            ? CustomToolCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCall' but the value was {ToString()}.");

        /// <summary>
        /// file_search_call variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant5? FileSearchCall { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant5? FileSearchCall { get; }
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
            out global::OpenRouter.OutputItemsVariant5? value)
        {
            value = FileSearchCall;
            return IsFileSearchCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant5 PickFileSearchCall() => IsFileSearchCall
            ? FileSearchCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileSearchCall' but the value was {ToString()}.");

        /// <summary>
        /// function_call variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant6? FunctionCall { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant6? FunctionCall { get; }
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
            out global::OpenRouter.OutputItemsVariant6? value)
        {
            value = FunctionCall;
            return IsFunctionCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant6 PickFunctionCall() => IsFunctionCall
            ? FunctionCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCall' but the value was {ToString()}.");

        /// <summary>
        /// image_generation_call variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant7? ImageGenerationCall { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant7? ImageGenerationCall { get; }
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
            out global::OpenRouter.OutputItemsVariant7? value)
        {
            value = ImageGenerationCall;
            return IsImageGenerationCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant7 PickImageGenerationCall() => IsImageGenerationCall
            ? ImageGenerationCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGenerationCall' but the value was {ToString()}.");

        /// <summary>
        /// An output message item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant8? Message { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant8? Message { get; }
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
            out global::OpenRouter.OutputItemsVariant8? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant8 PickMessage() => IsMessage
            ? Message!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:advisor server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant9? OpenrouterAdvisor { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant9? OpenrouterAdvisor { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterAdvisor))]
#endif
        public bool IsOpenrouterAdvisor => OpenrouterAdvisor != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenrouterAdvisor(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemsVariant9? value)
        {
            value = OpenrouterAdvisor;
            return IsOpenrouterAdvisor;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant9 PickOpenrouterAdvisor() => IsOpenrouterAdvisor
            ? OpenrouterAdvisor!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterAdvisor' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:apply_patch server tool output item. The turn halts when validation succeeds so the client can apply the patch and echo an `apply_patch_call_output` on the next turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant10? OpenrouterApplyPatch { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant10? OpenrouterApplyPatch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterApplyPatch))]
#endif
        public bool IsOpenrouterApplyPatch => OpenrouterApplyPatch != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenrouterApplyPatch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemsVariant10? value)
        {
            value = OpenrouterApplyPatch;
            return IsOpenrouterApplyPatch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant10 PickOpenrouterApplyPatch() => IsOpenrouterApplyPatch
            ? OpenrouterApplyPatch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterApplyPatch' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:bash server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant11? OpenrouterBash { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant11? OpenrouterBash { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterBash))]
#endif
        public bool IsOpenrouterBash => OpenrouterBash != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenrouterBash(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemsVariant11? value)
        {
            value = OpenrouterBash;
            return IsOpenrouterBash;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant11 PickOpenrouterBash() => IsOpenrouterBash
            ? OpenrouterBash!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterBash' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:browser_use server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant12? OpenrouterBrowserUse { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant12? OpenrouterBrowserUse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterBrowserUse))]
#endif
        public bool IsOpenrouterBrowserUse => OpenrouterBrowserUse != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenrouterBrowserUse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemsVariant12? value)
        {
            value = OpenrouterBrowserUse;
            return IsOpenrouterBrowserUse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant12 PickOpenrouterBrowserUse() => IsOpenrouterBrowserUse
            ? OpenrouterBrowserUse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterBrowserUse' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:code_interpreter server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant13? OpenrouterCodeInterpreter { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant13? OpenrouterCodeInterpreter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterCodeInterpreter))]
#endif
        public bool IsOpenrouterCodeInterpreter => OpenrouterCodeInterpreter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenrouterCodeInterpreter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemsVariant13? value)
        {
            value = OpenrouterCodeInterpreter;
            return IsOpenrouterCodeInterpreter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant13 PickOpenrouterCodeInterpreter() => IsOpenrouterCodeInterpreter
            ? OpenrouterCodeInterpreter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterCodeInterpreter' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:datetime server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant14? OpenrouterDatetime { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant14? OpenrouterDatetime { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterDatetime))]
#endif
        public bool IsOpenrouterDatetime => OpenrouterDatetime != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenrouterDatetime(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemsVariant14? value)
        {
            value = OpenrouterDatetime;
            return IsOpenrouterDatetime;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant14 PickOpenrouterDatetime() => IsOpenrouterDatetime
            ? OpenrouterDatetime!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterDatetime' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:experimental__search_models server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant15? OpenrouterExperimentalSearchModels { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant15? OpenrouterExperimentalSearchModels { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterExperimentalSearchModels))]
#endif
        public bool IsOpenrouterExperimentalSearchModels => OpenrouterExperimentalSearchModels != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenrouterExperimentalSearchModels(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemsVariant15? value)
        {
            value = OpenrouterExperimentalSearchModels;
            return IsOpenrouterExperimentalSearchModels;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant15 PickOpenrouterExperimentalSearchModels() => IsOpenrouterExperimentalSearchModels
            ? OpenrouterExperimentalSearchModels!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterExperimentalSearchModels' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:file_search server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant16? OpenrouterFileSearch { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant16? OpenrouterFileSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterFileSearch))]
#endif
        public bool IsOpenrouterFileSearch => OpenrouterFileSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenrouterFileSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemsVariant16? value)
        {
            value = OpenrouterFileSearch;
            return IsOpenrouterFileSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant16 PickOpenrouterFileSearch() => IsOpenrouterFileSearch
            ? OpenrouterFileSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterFileSearch' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:fusion server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant17? OpenrouterFusion { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant17? OpenrouterFusion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterFusion))]
#endif
        public bool IsOpenrouterFusion => OpenrouterFusion != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenrouterFusion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemsVariant17? value)
        {
            value = OpenrouterFusion;
            return IsOpenrouterFusion;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant17 PickOpenrouterFusion() => IsOpenrouterFusion
            ? OpenrouterFusion!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterFusion' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:image_generation server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant18? OpenrouterImageGeneration { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant18? OpenrouterImageGeneration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterImageGeneration))]
#endif
        public bool IsOpenrouterImageGeneration => OpenrouterImageGeneration != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenrouterImageGeneration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemsVariant18? value)
        {
            value = OpenrouterImageGeneration;
            return IsOpenrouterImageGeneration;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant18 PickOpenrouterImageGeneration() => IsOpenrouterImageGeneration
            ? OpenrouterImageGeneration!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterImageGeneration' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:mcp server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant19? OpenrouterMcp { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant19? OpenrouterMcp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterMcp))]
#endif
        public bool IsOpenrouterMcp => OpenrouterMcp != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenrouterMcp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemsVariant19? value)
        {
            value = OpenrouterMcp;
            return IsOpenrouterMcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant19 PickOpenrouterMcp() => IsOpenrouterMcp
            ? OpenrouterMcp!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterMcp' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:memory server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant20? OpenrouterMemory { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant20? OpenrouterMemory { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterMemory))]
#endif
        public bool IsOpenrouterMemory => OpenrouterMemory != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenrouterMemory(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemsVariant20? value)
        {
            value = OpenrouterMemory;
            return IsOpenrouterMemory;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant20 PickOpenrouterMemory() => IsOpenrouterMemory
            ? OpenrouterMemory!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterMemory' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:text_editor server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant21? OpenrouterTextEditor { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant21? OpenrouterTextEditor { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterTextEditor))]
#endif
        public bool IsOpenrouterTextEditor => OpenrouterTextEditor != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenrouterTextEditor(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemsVariant21? value)
        {
            value = OpenrouterTextEditor;
            return IsOpenrouterTextEditor;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant21 PickOpenrouterTextEditor() => IsOpenrouterTextEditor
            ? OpenrouterTextEditor!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterTextEditor' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:tool_search server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant22? OpenrouterToolSearch { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant22? OpenrouterToolSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterToolSearch))]
#endif
        public bool IsOpenrouterToolSearch => OpenrouterToolSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenrouterToolSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemsVariant22? value)
        {
            value = OpenrouterToolSearch;
            return IsOpenrouterToolSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant22 PickOpenrouterToolSearch() => IsOpenrouterToolSearch
            ? OpenrouterToolSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterToolSearch' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:web_fetch server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant23? OpenrouterWebFetch { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant23? OpenrouterWebFetch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterWebFetch))]
#endif
        public bool IsOpenrouterWebFetch => OpenrouterWebFetch != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenrouterWebFetch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemsVariant23? value)
        {
            value = OpenrouterWebFetch;
            return IsOpenrouterWebFetch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant23 PickOpenrouterWebFetch() => IsOpenrouterWebFetch
            ? OpenrouterWebFetch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterWebFetch' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:web_search server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant24? OpenrouterWebSearch { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant24? OpenrouterWebSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterWebSearch))]
#endif
        public bool IsOpenrouterWebSearch => OpenrouterWebSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenrouterWebSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputItemsVariant24? value)
        {
            value = OpenrouterWebSearch;
            return IsOpenrouterWebSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant24 PickOpenrouterWebSearch() => IsOpenrouterWebSearch
            ? OpenrouterWebSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterWebSearch' but the value was {ToString()}.");

        /// <summary>
        /// An output item containing reasoning
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant25? Reasoning { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant25? Reasoning { get; }
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
            out global::OpenRouter.OutputItemsVariant25? value)
        {
            value = Reasoning;
            return IsReasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant25 PickReasoning() => IsReasoning
            ? Reasoning!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Reasoning' but the value was {ToString()}.");

        /// <summary>
        /// web_search_call variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant26? WebSearchCall { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant26? WebSearchCall { get; }
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
            out global::OpenRouter.OutputItemsVariant26? value)
        {
            value = WebSearchCall;
            return IsWebSearchCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputItemsVariant26 PickWebSearchCall() => IsWebSearchCall
            ? WebSearchCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchCall' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant1 value) => new OutputItems((global::OpenRouter.OutputItemsVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant1?(OutputItems @this) => @this.ApplyPatchCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant1? value)
        {
            ApplyPatchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromApplyPatchCall(global::OpenRouter.OutputItemsVariant1? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant2 value) => new OutputItems((global::OpenRouter.OutputItemsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant2?(OutputItems @this) => @this.CodeInterpreterCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant2? value)
        {
            CodeInterpreterCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromCodeInterpreterCall(global::OpenRouter.OutputItemsVariant2? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant3 value) => new OutputItems((global::OpenRouter.OutputItemsVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant3?(OutputItems @this) => @this.ComputerCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant3? value)
        {
            ComputerCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromComputerCall(global::OpenRouter.OutputItemsVariant3? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant4 value) => new OutputItems((global::OpenRouter.OutputItemsVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant4?(OutputItems @this) => @this.CustomToolCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant4? value)
        {
            CustomToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromCustomToolCall(global::OpenRouter.OutputItemsVariant4? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant5 value) => new OutputItems((global::OpenRouter.OutputItemsVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant5?(OutputItems @this) => @this.FileSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant5? value)
        {
            FileSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromFileSearchCall(global::OpenRouter.OutputItemsVariant5? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant6 value) => new OutputItems((global::OpenRouter.OutputItemsVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant6?(OutputItems @this) => @this.FunctionCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant6? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromFunctionCall(global::OpenRouter.OutputItemsVariant6? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant7 value) => new OutputItems((global::OpenRouter.OutputItemsVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant7?(OutputItems @this) => @this.ImageGenerationCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant7? value)
        {
            ImageGenerationCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromImageGenerationCall(global::OpenRouter.OutputItemsVariant7? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant8 value) => new OutputItems((global::OpenRouter.OutputItemsVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant8?(OutputItems @this) => @this.Message;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant8? value)
        {
            Message = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromMessage(global::OpenRouter.OutputItemsVariant8? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant9 value) => new OutputItems((global::OpenRouter.OutputItemsVariant9?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant9?(OutputItems @this) => @this.OpenrouterAdvisor;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant9? value)
        {
            OpenrouterAdvisor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromOpenrouterAdvisor(global::OpenRouter.OutputItemsVariant9? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant10 value) => new OutputItems((global::OpenRouter.OutputItemsVariant10?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant10?(OutputItems @this) => @this.OpenrouterApplyPatch;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant10? value)
        {
            OpenrouterApplyPatch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromOpenrouterApplyPatch(global::OpenRouter.OutputItemsVariant10? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant11 value) => new OutputItems((global::OpenRouter.OutputItemsVariant11?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant11?(OutputItems @this) => @this.OpenrouterBash;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant11? value)
        {
            OpenrouterBash = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromOpenrouterBash(global::OpenRouter.OutputItemsVariant11? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant12 value) => new OutputItems((global::OpenRouter.OutputItemsVariant12?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant12?(OutputItems @this) => @this.OpenrouterBrowserUse;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant12? value)
        {
            OpenrouterBrowserUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromOpenrouterBrowserUse(global::OpenRouter.OutputItemsVariant12? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant13 value) => new OutputItems((global::OpenRouter.OutputItemsVariant13?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant13?(OutputItems @this) => @this.OpenrouterCodeInterpreter;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant13? value)
        {
            OpenrouterCodeInterpreter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromOpenrouterCodeInterpreter(global::OpenRouter.OutputItemsVariant13? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant14 value) => new OutputItems((global::OpenRouter.OutputItemsVariant14?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant14?(OutputItems @this) => @this.OpenrouterDatetime;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant14? value)
        {
            OpenrouterDatetime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromOpenrouterDatetime(global::OpenRouter.OutputItemsVariant14? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant15 value) => new OutputItems((global::OpenRouter.OutputItemsVariant15?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant15?(OutputItems @this) => @this.OpenrouterExperimentalSearchModels;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant15? value)
        {
            OpenrouterExperimentalSearchModels = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromOpenrouterExperimentalSearchModels(global::OpenRouter.OutputItemsVariant15? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant16 value) => new OutputItems((global::OpenRouter.OutputItemsVariant16?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant16?(OutputItems @this) => @this.OpenrouterFileSearch;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant16? value)
        {
            OpenrouterFileSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromOpenrouterFileSearch(global::OpenRouter.OutputItemsVariant16? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant17 value) => new OutputItems((global::OpenRouter.OutputItemsVariant17?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant17?(OutputItems @this) => @this.OpenrouterFusion;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant17? value)
        {
            OpenrouterFusion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromOpenrouterFusion(global::OpenRouter.OutputItemsVariant17? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant18 value) => new OutputItems((global::OpenRouter.OutputItemsVariant18?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant18?(OutputItems @this) => @this.OpenrouterImageGeneration;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant18? value)
        {
            OpenrouterImageGeneration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromOpenrouterImageGeneration(global::OpenRouter.OutputItemsVariant18? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant19 value) => new OutputItems((global::OpenRouter.OutputItemsVariant19?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant19?(OutputItems @this) => @this.OpenrouterMcp;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant19? value)
        {
            OpenrouterMcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromOpenrouterMcp(global::OpenRouter.OutputItemsVariant19? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant20 value) => new OutputItems((global::OpenRouter.OutputItemsVariant20?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant20?(OutputItems @this) => @this.OpenrouterMemory;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant20? value)
        {
            OpenrouterMemory = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromOpenrouterMemory(global::OpenRouter.OutputItemsVariant20? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant21 value) => new OutputItems((global::OpenRouter.OutputItemsVariant21?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant21?(OutputItems @this) => @this.OpenrouterTextEditor;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant21? value)
        {
            OpenrouterTextEditor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromOpenrouterTextEditor(global::OpenRouter.OutputItemsVariant21? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant22 value) => new OutputItems((global::OpenRouter.OutputItemsVariant22?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant22?(OutputItems @this) => @this.OpenrouterToolSearch;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant22? value)
        {
            OpenrouterToolSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromOpenrouterToolSearch(global::OpenRouter.OutputItemsVariant22? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant23 value) => new OutputItems((global::OpenRouter.OutputItemsVariant23?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant23?(OutputItems @this) => @this.OpenrouterWebFetch;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant23? value)
        {
            OpenrouterWebFetch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromOpenrouterWebFetch(global::OpenRouter.OutputItemsVariant23? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant24 value) => new OutputItems((global::OpenRouter.OutputItemsVariant24?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant24?(OutputItems @this) => @this.OpenrouterWebSearch;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant24? value)
        {
            OpenrouterWebSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromOpenrouterWebSearch(global::OpenRouter.OutputItemsVariant24? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant25 value) => new OutputItems((global::OpenRouter.OutputItemsVariant25?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant25?(OutputItems @this) => @this.Reasoning;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant25? value)
        {
            Reasoning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromReasoning(global::OpenRouter.OutputItemsVariant25? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant26 value) => new OutputItems((global::OpenRouter.OutputItemsVariant26?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant26?(OutputItems @this) => @this.WebSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant26? value)
        {
            WebSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputItems FromWebSearchCall(global::OpenRouter.OutputItemsVariant26? value) => new OutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(
            global::OpenRouter.OutputItemsDiscriminatorType? type,
            global::OpenRouter.OutputItemsVariant1? applyPatchCall,
            global::OpenRouter.OutputItemsVariant2? codeInterpreterCall,
            global::OpenRouter.OutputItemsVariant3? computerCall,
            global::OpenRouter.OutputItemsVariant4? customToolCall,
            global::OpenRouter.OutputItemsVariant5? fileSearchCall,
            global::OpenRouter.OutputItemsVariant6? functionCall,
            global::OpenRouter.OutputItemsVariant7? imageGenerationCall,
            global::OpenRouter.OutputItemsVariant8? message,
            global::OpenRouter.OutputItemsVariant9? openrouterAdvisor,
            global::OpenRouter.OutputItemsVariant10? openrouterApplyPatch,
            global::OpenRouter.OutputItemsVariant11? openrouterBash,
            global::OpenRouter.OutputItemsVariant12? openrouterBrowserUse,
            global::OpenRouter.OutputItemsVariant13? openrouterCodeInterpreter,
            global::OpenRouter.OutputItemsVariant14? openrouterDatetime,
            global::OpenRouter.OutputItemsVariant15? openrouterExperimentalSearchModels,
            global::OpenRouter.OutputItemsVariant16? openrouterFileSearch,
            global::OpenRouter.OutputItemsVariant17? openrouterFusion,
            global::OpenRouter.OutputItemsVariant18? openrouterImageGeneration,
            global::OpenRouter.OutputItemsVariant19? openrouterMcp,
            global::OpenRouter.OutputItemsVariant20? openrouterMemory,
            global::OpenRouter.OutputItemsVariant21? openrouterTextEditor,
            global::OpenRouter.OutputItemsVariant22? openrouterToolSearch,
            global::OpenRouter.OutputItemsVariant23? openrouterWebFetch,
            global::OpenRouter.OutputItemsVariant24? openrouterWebSearch,
            global::OpenRouter.OutputItemsVariant25? reasoning,
            global::OpenRouter.OutputItemsVariant26? webSearchCall
            )
        {
            Type = type;

            ApplyPatchCall = applyPatchCall;
            CodeInterpreterCall = codeInterpreterCall;
            ComputerCall = computerCall;
            CustomToolCall = customToolCall;
            FileSearchCall = fileSearchCall;
            FunctionCall = functionCall;
            ImageGenerationCall = imageGenerationCall;
            Message = message;
            OpenrouterAdvisor = openrouterAdvisor;
            OpenrouterApplyPatch = openrouterApplyPatch;
            OpenrouterBash = openrouterBash;
            OpenrouterBrowserUse = openrouterBrowserUse;
            OpenrouterCodeInterpreter = openrouterCodeInterpreter;
            OpenrouterDatetime = openrouterDatetime;
            OpenrouterExperimentalSearchModels = openrouterExperimentalSearchModels;
            OpenrouterFileSearch = openrouterFileSearch;
            OpenrouterFusion = openrouterFusion;
            OpenrouterImageGeneration = openrouterImageGeneration;
            OpenrouterMcp = openrouterMcp;
            OpenrouterMemory = openrouterMemory;
            OpenrouterTextEditor = openrouterTextEditor;
            OpenrouterToolSearch = openrouterToolSearch;
            OpenrouterWebFetch = openrouterWebFetch;
            OpenrouterWebSearch = openrouterWebSearch;
            Reasoning = reasoning;
            WebSearchCall = webSearchCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebSearchCall as object ??
            Reasoning as object ??
            OpenrouterWebSearch as object ??
            OpenrouterWebFetch as object ??
            OpenrouterToolSearch as object ??
            OpenrouterTextEditor as object ??
            OpenrouterMemory as object ??
            OpenrouterMcp as object ??
            OpenrouterImageGeneration as object ??
            OpenrouterFusion as object ??
            OpenrouterFileSearch as object ??
            OpenrouterExperimentalSearchModels as object ??
            OpenrouterDatetime as object ??
            OpenrouterCodeInterpreter as object ??
            OpenrouterBrowserUse as object ??
            OpenrouterBash as object ??
            OpenrouterApplyPatch as object ??
            OpenrouterAdvisor as object ??
            Message as object ??
            ImageGenerationCall as object ??
            FunctionCall as object ??
            FileSearchCall as object ??
            CustomToolCall as object ??
            ComputerCall as object ??
            CodeInterpreterCall as object ??
            ApplyPatchCall as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ApplyPatchCall?.ToString() ??
            CodeInterpreterCall?.ToString() ??
            ComputerCall?.ToString() ??
            CustomToolCall?.ToString() ??
            FileSearchCall?.ToString() ??
            FunctionCall?.ToString() ??
            ImageGenerationCall?.ToString() ??
            Message?.ToString() ??
            OpenrouterAdvisor?.ToString() ??
            OpenrouterApplyPatch?.ToString() ??
            OpenrouterBash?.ToString() ??
            OpenrouterBrowserUse?.ToString() ??
            OpenrouterCodeInterpreter?.ToString() ??
            OpenrouterDatetime?.ToString() ??
            OpenrouterExperimentalSearchModels?.ToString() ??
            OpenrouterFileSearch?.ToString() ??
            OpenrouterFusion?.ToString() ??
            OpenrouterImageGeneration?.ToString() ??
            OpenrouterMcp?.ToString() ??
            OpenrouterMemory?.ToString() ??
            OpenrouterTextEditor?.ToString() ??
            OpenrouterToolSearch?.ToString() ??
            OpenrouterWebFetch?.ToString() ??
            OpenrouterWebSearch?.ToString() ??
            Reasoning?.ToString() ??
            WebSearchCall?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && IsReasoning && !IsWebSearchCall || !IsApplyPatchCall && !IsCodeInterpreterCall && !IsComputerCall && !IsCustomToolCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterAdvisor && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterFusion && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && IsWebSearchCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputItemsVariant1, TResult>? applyPatchCall = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant2, TResult>? codeInterpreterCall = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant3, TResult>? computerCall = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant4, TResult>? customToolCall = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant5, TResult>? fileSearchCall = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant6, TResult>? functionCall = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant7, TResult>? imageGenerationCall = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant8, TResult>? message = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant9, TResult>? openrouterAdvisor = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant10, TResult>? openrouterApplyPatch = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant11, TResult>? openrouterBash = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant12, TResult>? openrouterBrowserUse = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant13, TResult>? openrouterCodeInterpreter = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant14, TResult>? openrouterDatetime = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant15, TResult>? openrouterExperimentalSearchModels = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant16, TResult>? openrouterFileSearch = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant17, TResult>? openrouterFusion = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant18, TResult>? openrouterImageGeneration = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant19, TResult>? openrouterMcp = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant20, TResult>? openrouterMemory = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant21, TResult>? openrouterTextEditor = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant22, TResult>? openrouterToolSearch = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant23, TResult>? openrouterWebFetch = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant24, TResult>? openrouterWebSearch = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant25, TResult>? reasoning = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant26, TResult>? webSearchCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApplyPatchCall && applyPatchCall != null)
            {
                return applyPatchCall(ApplyPatchCall!);
            }
            else if (IsCodeInterpreterCall && codeInterpreterCall != null)
            {
                return codeInterpreterCall(CodeInterpreterCall!);
            }
            else if (IsComputerCall && computerCall != null)
            {
                return computerCall(ComputerCall!);
            }
            else if (IsCustomToolCall && customToolCall != null)
            {
                return customToolCall(CustomToolCall!);
            }
            else if (IsFileSearchCall && fileSearchCall != null)
            {
                return fileSearchCall(FileSearchCall!);
            }
            else if (IsFunctionCall && functionCall != null)
            {
                return functionCall(FunctionCall!);
            }
            else if (IsImageGenerationCall && imageGenerationCall != null)
            {
                return imageGenerationCall(ImageGenerationCall!);
            }
            else if (IsMessage && message != null)
            {
                return message(Message!);
            }
            else if (IsOpenrouterAdvisor && openrouterAdvisor != null)
            {
                return openrouterAdvisor(OpenrouterAdvisor!);
            }
            else if (IsOpenrouterApplyPatch && openrouterApplyPatch != null)
            {
                return openrouterApplyPatch(OpenrouterApplyPatch!);
            }
            else if (IsOpenrouterBash && openrouterBash != null)
            {
                return openrouterBash(OpenrouterBash!);
            }
            else if (IsOpenrouterBrowserUse && openrouterBrowserUse != null)
            {
                return openrouterBrowserUse(OpenrouterBrowserUse!);
            }
            else if (IsOpenrouterCodeInterpreter && openrouterCodeInterpreter != null)
            {
                return openrouterCodeInterpreter(OpenrouterCodeInterpreter!);
            }
            else if (IsOpenrouterDatetime && openrouterDatetime != null)
            {
                return openrouterDatetime(OpenrouterDatetime!);
            }
            else if (IsOpenrouterExperimentalSearchModels && openrouterExperimentalSearchModels != null)
            {
                return openrouterExperimentalSearchModels(OpenrouterExperimentalSearchModels!);
            }
            else if (IsOpenrouterFileSearch && openrouterFileSearch != null)
            {
                return openrouterFileSearch(OpenrouterFileSearch!);
            }
            else if (IsOpenrouterFusion && openrouterFusion != null)
            {
                return openrouterFusion(OpenrouterFusion!);
            }
            else if (IsOpenrouterImageGeneration && openrouterImageGeneration != null)
            {
                return openrouterImageGeneration(OpenrouterImageGeneration!);
            }
            else if (IsOpenrouterMcp && openrouterMcp != null)
            {
                return openrouterMcp(OpenrouterMcp!);
            }
            else if (IsOpenrouterMemory && openrouterMemory != null)
            {
                return openrouterMemory(OpenrouterMemory!);
            }
            else if (IsOpenrouterTextEditor && openrouterTextEditor != null)
            {
                return openrouterTextEditor(OpenrouterTextEditor!);
            }
            else if (IsOpenrouterToolSearch && openrouterToolSearch != null)
            {
                return openrouterToolSearch(OpenrouterToolSearch!);
            }
            else if (IsOpenrouterWebFetch && openrouterWebFetch != null)
            {
                return openrouterWebFetch(OpenrouterWebFetch!);
            }
            else if (IsOpenrouterWebSearch && openrouterWebSearch != null)
            {
                return openrouterWebSearch(OpenrouterWebSearch!);
            }
            else if (IsReasoning && reasoning != null)
            {
                return reasoning(Reasoning!);
            }
            else if (IsWebSearchCall && webSearchCall != null)
            {
                return webSearchCall(WebSearchCall!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputItemsVariant1>? applyPatchCall = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant2>? codeInterpreterCall = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant3>? computerCall = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant4>? customToolCall = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant5>? fileSearchCall = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant6>? functionCall = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant7>? imageGenerationCall = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant8>? message = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant9>? openrouterAdvisor = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant10>? openrouterApplyPatch = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant11>? openrouterBash = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant12>? openrouterBrowserUse = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant13>? openrouterCodeInterpreter = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant14>? openrouterDatetime = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant15>? openrouterExperimentalSearchModels = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant16>? openrouterFileSearch = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant17>? openrouterFusion = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant18>? openrouterImageGeneration = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant19>? openrouterMcp = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant20>? openrouterMemory = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant21>? openrouterTextEditor = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant22>? openrouterToolSearch = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant23>? openrouterWebFetch = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant24>? openrouterWebSearch = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant25>? reasoning = null,

            global::System.Action<global::OpenRouter.OutputItemsVariant26>? webSearchCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApplyPatchCall)
            {
                applyPatchCall?.Invoke(ApplyPatchCall!);
            }
            else if (IsCodeInterpreterCall)
            {
                codeInterpreterCall?.Invoke(CodeInterpreterCall!);
            }
            else if (IsComputerCall)
            {
                computerCall?.Invoke(ComputerCall!);
            }
            else if (IsCustomToolCall)
            {
                customToolCall?.Invoke(CustomToolCall!);
            }
            else if (IsFileSearchCall)
            {
                fileSearchCall?.Invoke(FileSearchCall!);
            }
            else if (IsFunctionCall)
            {
                functionCall?.Invoke(FunctionCall!);
            }
            else if (IsImageGenerationCall)
            {
                imageGenerationCall?.Invoke(ImageGenerationCall!);
            }
            else if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsOpenrouterAdvisor)
            {
                openrouterAdvisor?.Invoke(OpenrouterAdvisor!);
            }
            else if (IsOpenrouterApplyPatch)
            {
                openrouterApplyPatch?.Invoke(OpenrouterApplyPatch!);
            }
            else if (IsOpenrouterBash)
            {
                openrouterBash?.Invoke(OpenrouterBash!);
            }
            else if (IsOpenrouterBrowserUse)
            {
                openrouterBrowserUse?.Invoke(OpenrouterBrowserUse!);
            }
            else if (IsOpenrouterCodeInterpreter)
            {
                openrouterCodeInterpreter?.Invoke(OpenrouterCodeInterpreter!);
            }
            else if (IsOpenrouterDatetime)
            {
                openrouterDatetime?.Invoke(OpenrouterDatetime!);
            }
            else if (IsOpenrouterExperimentalSearchModels)
            {
                openrouterExperimentalSearchModels?.Invoke(OpenrouterExperimentalSearchModels!);
            }
            else if (IsOpenrouterFileSearch)
            {
                openrouterFileSearch?.Invoke(OpenrouterFileSearch!);
            }
            else if (IsOpenrouterFusion)
            {
                openrouterFusion?.Invoke(OpenrouterFusion!);
            }
            else if (IsOpenrouterImageGeneration)
            {
                openrouterImageGeneration?.Invoke(OpenrouterImageGeneration!);
            }
            else if (IsOpenrouterMcp)
            {
                openrouterMcp?.Invoke(OpenrouterMcp!);
            }
            else if (IsOpenrouterMemory)
            {
                openrouterMemory?.Invoke(OpenrouterMemory!);
            }
            else if (IsOpenrouterTextEditor)
            {
                openrouterTextEditor?.Invoke(OpenrouterTextEditor!);
            }
            else if (IsOpenrouterToolSearch)
            {
                openrouterToolSearch?.Invoke(OpenrouterToolSearch!);
            }
            else if (IsOpenrouterWebFetch)
            {
                openrouterWebFetch?.Invoke(OpenrouterWebFetch!);
            }
            else if (IsOpenrouterWebSearch)
            {
                openrouterWebSearch?.Invoke(OpenrouterWebSearch!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputItemsVariant1>? applyPatchCall = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant2>? codeInterpreterCall = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant3>? computerCall = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant4>? customToolCall = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant5>? fileSearchCall = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant6>? functionCall = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant7>? imageGenerationCall = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant8>? message = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant9>? openrouterAdvisor = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant10>? openrouterApplyPatch = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant11>? openrouterBash = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant12>? openrouterBrowserUse = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant13>? openrouterCodeInterpreter = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant14>? openrouterDatetime = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant15>? openrouterExperimentalSearchModels = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant16>? openrouterFileSearch = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant17>? openrouterFusion = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant18>? openrouterImageGeneration = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant19>? openrouterMcp = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant20>? openrouterMemory = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant21>? openrouterTextEditor = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant22>? openrouterToolSearch = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant23>? openrouterWebFetch = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant24>? openrouterWebSearch = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant25>? reasoning = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant26>? webSearchCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApplyPatchCall)
            {
                applyPatchCall?.Invoke(ApplyPatchCall!);
            }
            else if (IsCodeInterpreterCall)
            {
                codeInterpreterCall?.Invoke(CodeInterpreterCall!);
            }
            else if (IsComputerCall)
            {
                computerCall?.Invoke(ComputerCall!);
            }
            else if (IsCustomToolCall)
            {
                customToolCall?.Invoke(CustomToolCall!);
            }
            else if (IsFileSearchCall)
            {
                fileSearchCall?.Invoke(FileSearchCall!);
            }
            else if (IsFunctionCall)
            {
                functionCall?.Invoke(FunctionCall!);
            }
            else if (IsImageGenerationCall)
            {
                imageGenerationCall?.Invoke(ImageGenerationCall!);
            }
            else if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsOpenrouterAdvisor)
            {
                openrouterAdvisor?.Invoke(OpenrouterAdvisor!);
            }
            else if (IsOpenrouterApplyPatch)
            {
                openrouterApplyPatch?.Invoke(OpenrouterApplyPatch!);
            }
            else if (IsOpenrouterBash)
            {
                openrouterBash?.Invoke(OpenrouterBash!);
            }
            else if (IsOpenrouterBrowserUse)
            {
                openrouterBrowserUse?.Invoke(OpenrouterBrowserUse!);
            }
            else if (IsOpenrouterCodeInterpreter)
            {
                openrouterCodeInterpreter?.Invoke(OpenrouterCodeInterpreter!);
            }
            else if (IsOpenrouterDatetime)
            {
                openrouterDatetime?.Invoke(OpenrouterDatetime!);
            }
            else if (IsOpenrouterExperimentalSearchModels)
            {
                openrouterExperimentalSearchModels?.Invoke(OpenrouterExperimentalSearchModels!);
            }
            else if (IsOpenrouterFileSearch)
            {
                openrouterFileSearch?.Invoke(OpenrouterFileSearch!);
            }
            else if (IsOpenrouterFusion)
            {
                openrouterFusion?.Invoke(OpenrouterFusion!);
            }
            else if (IsOpenrouterImageGeneration)
            {
                openrouterImageGeneration?.Invoke(OpenrouterImageGeneration!);
            }
            else if (IsOpenrouterMcp)
            {
                openrouterMcp?.Invoke(OpenrouterMcp!);
            }
            else if (IsOpenrouterMemory)
            {
                openrouterMemory?.Invoke(OpenrouterMemory!);
            }
            else if (IsOpenrouterTextEditor)
            {
                openrouterTextEditor?.Invoke(OpenrouterTextEditor!);
            }
            else if (IsOpenrouterToolSearch)
            {
                openrouterToolSearch?.Invoke(OpenrouterToolSearch!);
            }
            else if (IsOpenrouterWebFetch)
            {
                openrouterWebFetch?.Invoke(OpenrouterWebFetch!);
            }
            else if (IsOpenrouterWebSearch)
            {
                openrouterWebSearch?.Invoke(OpenrouterWebSearch!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ApplyPatchCall,
                typeof(global::OpenRouter.OutputItemsVariant1),
                CodeInterpreterCall,
                typeof(global::OpenRouter.OutputItemsVariant2),
                ComputerCall,
                typeof(global::OpenRouter.OutputItemsVariant3),
                CustomToolCall,
                typeof(global::OpenRouter.OutputItemsVariant4),
                FileSearchCall,
                typeof(global::OpenRouter.OutputItemsVariant5),
                FunctionCall,
                typeof(global::OpenRouter.OutputItemsVariant6),
                ImageGenerationCall,
                typeof(global::OpenRouter.OutputItemsVariant7),
                Message,
                typeof(global::OpenRouter.OutputItemsVariant8),
                OpenrouterAdvisor,
                typeof(global::OpenRouter.OutputItemsVariant9),
                OpenrouterApplyPatch,
                typeof(global::OpenRouter.OutputItemsVariant10),
                OpenrouterBash,
                typeof(global::OpenRouter.OutputItemsVariant11),
                OpenrouterBrowserUse,
                typeof(global::OpenRouter.OutputItemsVariant12),
                OpenrouterCodeInterpreter,
                typeof(global::OpenRouter.OutputItemsVariant13),
                OpenrouterDatetime,
                typeof(global::OpenRouter.OutputItemsVariant14),
                OpenrouterExperimentalSearchModels,
                typeof(global::OpenRouter.OutputItemsVariant15),
                OpenrouterFileSearch,
                typeof(global::OpenRouter.OutputItemsVariant16),
                OpenrouterFusion,
                typeof(global::OpenRouter.OutputItemsVariant17),
                OpenrouterImageGeneration,
                typeof(global::OpenRouter.OutputItemsVariant18),
                OpenrouterMcp,
                typeof(global::OpenRouter.OutputItemsVariant19),
                OpenrouterMemory,
                typeof(global::OpenRouter.OutputItemsVariant20),
                OpenrouterTextEditor,
                typeof(global::OpenRouter.OutputItemsVariant21),
                OpenrouterToolSearch,
                typeof(global::OpenRouter.OutputItemsVariant22),
                OpenrouterWebFetch,
                typeof(global::OpenRouter.OutputItemsVariant23),
                OpenrouterWebSearch,
                typeof(global::OpenRouter.OutputItemsVariant24),
                Reasoning,
                typeof(global::OpenRouter.OutputItemsVariant25),
                WebSearchCall,
                typeof(global::OpenRouter.OutputItemsVariant26),
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
        public bool Equals(OutputItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant1?>.Default.Equals(ApplyPatchCall, other.ApplyPatchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant2?>.Default.Equals(CodeInterpreterCall, other.CodeInterpreterCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant3?>.Default.Equals(ComputerCall, other.ComputerCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant4?>.Default.Equals(CustomToolCall, other.CustomToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant5?>.Default.Equals(FileSearchCall, other.FileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant6?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant7?>.Default.Equals(ImageGenerationCall, other.ImageGenerationCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant8?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant9?>.Default.Equals(OpenrouterAdvisor, other.OpenrouterAdvisor) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant10?>.Default.Equals(OpenrouterApplyPatch, other.OpenrouterApplyPatch) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant11?>.Default.Equals(OpenrouterBash, other.OpenrouterBash) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant12?>.Default.Equals(OpenrouterBrowserUse, other.OpenrouterBrowserUse) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant13?>.Default.Equals(OpenrouterCodeInterpreter, other.OpenrouterCodeInterpreter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant14?>.Default.Equals(OpenrouterDatetime, other.OpenrouterDatetime) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant15?>.Default.Equals(OpenrouterExperimentalSearchModels, other.OpenrouterExperimentalSearchModels) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant16?>.Default.Equals(OpenrouterFileSearch, other.OpenrouterFileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant17?>.Default.Equals(OpenrouterFusion, other.OpenrouterFusion) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant18?>.Default.Equals(OpenrouterImageGeneration, other.OpenrouterImageGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant19?>.Default.Equals(OpenrouterMcp, other.OpenrouterMcp) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant20?>.Default.Equals(OpenrouterMemory, other.OpenrouterMemory) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant21?>.Default.Equals(OpenrouterTextEditor, other.OpenrouterTextEditor) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant22?>.Default.Equals(OpenrouterToolSearch, other.OpenrouterToolSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant23?>.Default.Equals(OpenrouterWebFetch, other.OpenrouterWebFetch) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant24?>.Default.Equals(OpenrouterWebSearch, other.OpenrouterWebSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant25?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant26?>.Default.Equals(WebSearchCall, other.WebSearchCall) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputItems obj1, OutputItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputItems obj1, OutputItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputItems o && Equals(o);
        }
    }
}
