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
        /// code_interpreter_call variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant1? CodeInterpreterCall { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant1? CodeInterpreterCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCall))]
#endif
        public bool IsCodeInterpreterCall => CodeInterpreterCall != null;

        /// <summary>
        /// computer_call variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant2? ComputerCall { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant2? ComputerCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerCall))]
#endif
        public bool IsComputerCall => ComputerCall != null;

        /// <summary>
        /// file_search_call variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant3? FileSearchCall { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant3? FileSearchCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchCall))]
#endif
        public bool IsFileSearchCall => FileSearchCall != null;

        /// <summary>
        /// function_call variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant4? FunctionCall { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant4? FunctionCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCall))]
#endif
        public bool IsFunctionCall => FunctionCall != null;

        /// <summary>
        /// image_generation_call variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant5? ImageGenerationCall { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant5? ImageGenerationCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenerationCall))]
#endif
        public bool IsImageGenerationCall => ImageGenerationCall != null;

        /// <summary>
        /// message variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant6? Message { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant6? Message { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        /// openrouter:apply_patch variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant7? OpenrouterApplyPatch { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant7? OpenrouterApplyPatch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterApplyPatch))]
#endif
        public bool IsOpenrouterApplyPatch => OpenrouterApplyPatch != null;

        /// <summary>
        /// openrouter:bash variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant8? OpenrouterBash { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant8? OpenrouterBash { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterBash))]
#endif
        public bool IsOpenrouterBash => OpenrouterBash != null;

        /// <summary>
        /// openrouter:browser_use variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant9? OpenrouterBrowserUse { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant9? OpenrouterBrowserUse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterBrowserUse))]
#endif
        public bool IsOpenrouterBrowserUse => OpenrouterBrowserUse != null;

        /// <summary>
        /// openrouter:code_interpreter variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant10? OpenrouterCodeInterpreter { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant10? OpenrouterCodeInterpreter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterCodeInterpreter))]
#endif
        public bool IsOpenrouterCodeInterpreter => OpenrouterCodeInterpreter != null;

        /// <summary>
        /// openrouter:datetime variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant11? OpenrouterDatetime { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant11? OpenrouterDatetime { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterDatetime))]
#endif
        public bool IsOpenrouterDatetime => OpenrouterDatetime != null;

        /// <summary>
        /// openrouter:experimental__search_models variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant12? OpenrouterExperimentalSearchModels { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant12? OpenrouterExperimentalSearchModels { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterExperimentalSearchModels))]
#endif
        public bool IsOpenrouterExperimentalSearchModels => OpenrouterExperimentalSearchModels != null;

        /// <summary>
        /// openrouter:file_search variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant13? OpenrouterFileSearch { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant13? OpenrouterFileSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterFileSearch))]
#endif
        public bool IsOpenrouterFileSearch => OpenrouterFileSearch != null;

        /// <summary>
        /// openrouter:image_generation variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant14? OpenrouterImageGeneration { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant14? OpenrouterImageGeneration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterImageGeneration))]
#endif
        public bool IsOpenrouterImageGeneration => OpenrouterImageGeneration != null;

        /// <summary>
        /// openrouter:mcp variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant15? OpenrouterMcp { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant15? OpenrouterMcp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterMcp))]
#endif
        public bool IsOpenrouterMcp => OpenrouterMcp != null;

        /// <summary>
        /// openrouter:memory variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant16? OpenrouterMemory { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant16? OpenrouterMemory { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterMemory))]
#endif
        public bool IsOpenrouterMemory => OpenrouterMemory != null;

        /// <summary>
        /// openrouter:text_editor variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant17? OpenrouterTextEditor { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant17? OpenrouterTextEditor { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterTextEditor))]
#endif
        public bool IsOpenrouterTextEditor => OpenrouterTextEditor != null;

        /// <summary>
        /// openrouter:tool_search variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant18? OpenrouterToolSearch { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant18? OpenrouterToolSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterToolSearch))]
#endif
        public bool IsOpenrouterToolSearch => OpenrouterToolSearch != null;

        /// <summary>
        /// openrouter:web_fetch variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant19? OpenrouterWebFetch { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant19? OpenrouterWebFetch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterWebFetch))]
#endif
        public bool IsOpenrouterWebFetch => OpenrouterWebFetch != null;

        /// <summary>
        /// openrouter:web_search variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant20? OpenrouterWebSearch { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant20? OpenrouterWebSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterWebSearch))]
#endif
        public bool IsOpenrouterWebSearch => OpenrouterWebSearch != null;

        /// <summary>
        /// reasoning variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant21? Reasoning { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant21? Reasoning { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Reasoning))]
#endif
        public bool IsReasoning => Reasoning != null;

        /// <summary>
        /// web_search_call variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant22? WebSearchCall { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant22? WebSearchCall { get; }
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
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant1 value) => new OutputItems((global::OpenRouter.OutputItemsVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant1?(OutputItems @this) => @this.CodeInterpreterCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant1? value)
        {
            CodeInterpreterCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant2 value) => new OutputItems((global::OpenRouter.OutputItemsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant2?(OutputItems @this) => @this.ComputerCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant2? value)
        {
            ComputerCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant3 value) => new OutputItems((global::OpenRouter.OutputItemsVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant3?(OutputItems @this) => @this.FileSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant3? value)
        {
            FileSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant4 value) => new OutputItems((global::OpenRouter.OutputItemsVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant4?(OutputItems @this) => @this.FunctionCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant4? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant5 value) => new OutputItems((global::OpenRouter.OutputItemsVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant5?(OutputItems @this) => @this.ImageGenerationCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant5? value)
        {
            ImageGenerationCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant6 value) => new OutputItems((global::OpenRouter.OutputItemsVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant6?(OutputItems @this) => @this.Message;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant6? value)
        {
            Message = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant7 value) => new OutputItems((global::OpenRouter.OutputItemsVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant7?(OutputItems @this) => @this.OpenrouterApplyPatch;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant7? value)
        {
            OpenrouterApplyPatch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant8 value) => new OutputItems((global::OpenRouter.OutputItemsVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant8?(OutputItems @this) => @this.OpenrouterBash;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant8? value)
        {
            OpenrouterBash = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant9 value) => new OutputItems((global::OpenRouter.OutputItemsVariant9?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant9?(OutputItems @this) => @this.OpenrouterBrowserUse;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant9? value)
        {
            OpenrouterBrowserUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant10 value) => new OutputItems((global::OpenRouter.OutputItemsVariant10?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant10?(OutputItems @this) => @this.OpenrouterCodeInterpreter;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant10? value)
        {
            OpenrouterCodeInterpreter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant11 value) => new OutputItems((global::OpenRouter.OutputItemsVariant11?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant11?(OutputItems @this) => @this.OpenrouterDatetime;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant11? value)
        {
            OpenrouterDatetime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant12 value) => new OutputItems((global::OpenRouter.OutputItemsVariant12?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant12?(OutputItems @this) => @this.OpenrouterExperimentalSearchModels;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant12? value)
        {
            OpenrouterExperimentalSearchModels = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant13 value) => new OutputItems((global::OpenRouter.OutputItemsVariant13?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant13?(OutputItems @this) => @this.OpenrouterFileSearch;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant13? value)
        {
            OpenrouterFileSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant14 value) => new OutputItems((global::OpenRouter.OutputItemsVariant14?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant14?(OutputItems @this) => @this.OpenrouterImageGeneration;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant14? value)
        {
            OpenrouterImageGeneration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant15 value) => new OutputItems((global::OpenRouter.OutputItemsVariant15?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant15?(OutputItems @this) => @this.OpenrouterMcp;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant15? value)
        {
            OpenrouterMcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant16 value) => new OutputItems((global::OpenRouter.OutputItemsVariant16?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant16?(OutputItems @this) => @this.OpenrouterMemory;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant16? value)
        {
            OpenrouterMemory = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant17 value) => new OutputItems((global::OpenRouter.OutputItemsVariant17?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant17?(OutputItems @this) => @this.OpenrouterTextEditor;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant17? value)
        {
            OpenrouterTextEditor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant18 value) => new OutputItems((global::OpenRouter.OutputItemsVariant18?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant18?(OutputItems @this) => @this.OpenrouterToolSearch;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant18? value)
        {
            OpenrouterToolSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant19 value) => new OutputItems((global::OpenRouter.OutputItemsVariant19?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant19?(OutputItems @this) => @this.OpenrouterWebFetch;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant19? value)
        {
            OpenrouterWebFetch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant20 value) => new OutputItems((global::OpenRouter.OutputItemsVariant20?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant20?(OutputItems @this) => @this.OpenrouterWebSearch;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant20? value)
        {
            OpenrouterWebSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant21 value) => new OutputItems((global::OpenRouter.OutputItemsVariant21?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant21?(OutputItems @this) => @this.Reasoning;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant21? value)
        {
            Reasoning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant22 value) => new OutputItems((global::OpenRouter.OutputItemsVariant22?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant22?(OutputItems @this) => @this.WebSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant22? value)
        {
            WebSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(
            global::OpenRouter.OutputItemsVariant1? codeInterpreterCall,
            global::OpenRouter.OutputItemsVariant2? computerCall,
            global::OpenRouter.OutputItemsVariant3? fileSearchCall,
            global::OpenRouter.OutputItemsVariant4? functionCall,
            global::OpenRouter.OutputItemsVariant5? imageGenerationCall,
            global::OpenRouter.OutputItemsVariant6? message,
            global::OpenRouter.OutputItemsVariant7? openrouterApplyPatch,
            global::OpenRouter.OutputItemsVariant8? openrouterBash,
            global::OpenRouter.OutputItemsVariant9? openrouterBrowserUse,
            global::OpenRouter.OutputItemsVariant10? openrouterCodeInterpreter,
            global::OpenRouter.OutputItemsVariant11? openrouterDatetime,
            global::OpenRouter.OutputItemsVariant12? openrouterExperimentalSearchModels,
            global::OpenRouter.OutputItemsVariant13? openrouterFileSearch,
            global::OpenRouter.OutputItemsVariant14? openrouterImageGeneration,
            global::OpenRouter.OutputItemsVariant15? openrouterMcp,
            global::OpenRouter.OutputItemsVariant16? openrouterMemory,
            global::OpenRouter.OutputItemsVariant17? openrouterTextEditor,
            global::OpenRouter.OutputItemsVariant18? openrouterToolSearch,
            global::OpenRouter.OutputItemsVariant19? openrouterWebFetch,
            global::OpenRouter.OutputItemsVariant20? openrouterWebSearch,
            global::OpenRouter.OutputItemsVariant21? reasoning,
            global::OpenRouter.OutputItemsVariant22? webSearchCall
            )
        {
            CodeInterpreterCall = codeInterpreterCall;
            ComputerCall = computerCall;
            FileSearchCall = fileSearchCall;
            FunctionCall = functionCall;
            ImageGenerationCall = imageGenerationCall;
            Message = message;
            OpenrouterApplyPatch = openrouterApplyPatch;
            OpenrouterBash = openrouterBash;
            OpenrouterBrowserUse = openrouterBrowserUse;
            OpenrouterCodeInterpreter = openrouterCodeInterpreter;
            OpenrouterDatetime = openrouterDatetime;
            OpenrouterExperimentalSearchModels = openrouterExperimentalSearchModels;
            OpenrouterFileSearch = openrouterFileSearch;
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
            OpenrouterFileSearch as object ??
            OpenrouterExperimentalSearchModels as object ??
            OpenrouterDatetime as object ??
            OpenrouterCodeInterpreter as object ??
            OpenrouterBrowserUse as object ??
            OpenrouterBash as object ??
            OpenrouterApplyPatch as object ??
            Message as object ??
            ImageGenerationCall as object ??
            FunctionCall as object ??
            FileSearchCall as object ??
            ComputerCall as object ??
            CodeInterpreterCall as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CodeInterpreterCall?.ToString() ??
            ComputerCall?.ToString() ??
            FileSearchCall?.ToString() ??
            FunctionCall?.ToString() ??
            ImageGenerationCall?.ToString() ??
            Message?.ToString() ??
            OpenrouterApplyPatch?.ToString() ??
            OpenrouterBash?.ToString() ??
            OpenrouterBrowserUse?.ToString() ??
            OpenrouterCodeInterpreter?.ToString() ??
            OpenrouterDatetime?.ToString() ??
            OpenrouterExperimentalSearchModels?.ToString() ??
            OpenrouterFileSearch?.ToString() ??
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
            return IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && IsComputerCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && !IsFunctionCall && IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && IsReasoning && !IsWebSearchCall || !IsCodeInterpreterCall && !IsComputerCall && !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterApplyPatch && !IsOpenrouterBash && !IsOpenrouterBrowserUse && !IsOpenrouterCodeInterpreter && !IsOpenrouterDatetime && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterMcp && !IsOpenrouterMemory && !IsOpenrouterTextEditor && !IsOpenrouterToolSearch && !IsOpenrouterWebFetch && !IsOpenrouterWebSearch && !IsReasoning && IsWebSearchCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputItemsVariant1?, TResult>? codeInterpreterCall = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant2?, TResult>? computerCall = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant3?, TResult>? fileSearchCall = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant4?, TResult>? functionCall = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant5?, TResult>? imageGenerationCall = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant6?, TResult>? message = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant7?, TResult>? openrouterApplyPatch = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant8?, TResult>? openrouterBash = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant9?, TResult>? openrouterBrowserUse = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant10?, TResult>? openrouterCodeInterpreter = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant11?, TResult>? openrouterDatetime = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant12?, TResult>? openrouterExperimentalSearchModels = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant13?, TResult>? openrouterFileSearch = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant14?, TResult>? openrouterImageGeneration = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant15?, TResult>? openrouterMcp = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant16?, TResult>? openrouterMemory = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant17?, TResult>? openrouterTextEditor = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant18?, TResult>? openrouterToolSearch = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant19?, TResult>? openrouterWebFetch = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant20?, TResult>? openrouterWebSearch = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant21?, TResult>? reasoning = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant22?, TResult>? webSearchCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeInterpreterCall && codeInterpreterCall != null)
            {
                return codeInterpreterCall(CodeInterpreterCall!);
            }
            else if (IsComputerCall && computerCall != null)
            {
                return computerCall(ComputerCall!);
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
            global::System.Action<global::OpenRouter.OutputItemsVariant1?>? codeInterpreterCall = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant2?>? computerCall = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant3?>? fileSearchCall = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant4?>? functionCall = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant5?>? imageGenerationCall = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant6?>? message = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant7?>? openrouterApplyPatch = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant8?>? openrouterBash = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant9?>? openrouterBrowserUse = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant10?>? openrouterCodeInterpreter = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant11?>? openrouterDatetime = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant12?>? openrouterExperimentalSearchModels = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant13?>? openrouterFileSearch = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant14?>? openrouterImageGeneration = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant15?>? openrouterMcp = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant16?>? openrouterMemory = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant17?>? openrouterTextEditor = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant18?>? openrouterToolSearch = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant19?>? openrouterWebFetch = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant20?>? openrouterWebSearch = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant21?>? reasoning = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant22?>? webSearchCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeInterpreterCall)
            {
                codeInterpreterCall?.Invoke(CodeInterpreterCall!);
            }
            else if (IsComputerCall)
            {
                computerCall?.Invoke(ComputerCall!);
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
                CodeInterpreterCall,
                typeof(global::OpenRouter.OutputItemsVariant1),
                ComputerCall,
                typeof(global::OpenRouter.OutputItemsVariant2),
                FileSearchCall,
                typeof(global::OpenRouter.OutputItemsVariant3),
                FunctionCall,
                typeof(global::OpenRouter.OutputItemsVariant4),
                ImageGenerationCall,
                typeof(global::OpenRouter.OutputItemsVariant5),
                Message,
                typeof(global::OpenRouter.OutputItemsVariant6),
                OpenrouterApplyPatch,
                typeof(global::OpenRouter.OutputItemsVariant7),
                OpenrouterBash,
                typeof(global::OpenRouter.OutputItemsVariant8),
                OpenrouterBrowserUse,
                typeof(global::OpenRouter.OutputItemsVariant9),
                OpenrouterCodeInterpreter,
                typeof(global::OpenRouter.OutputItemsVariant10),
                OpenrouterDatetime,
                typeof(global::OpenRouter.OutputItemsVariant11),
                OpenrouterExperimentalSearchModels,
                typeof(global::OpenRouter.OutputItemsVariant12),
                OpenrouterFileSearch,
                typeof(global::OpenRouter.OutputItemsVariant13),
                OpenrouterImageGeneration,
                typeof(global::OpenRouter.OutputItemsVariant14),
                OpenrouterMcp,
                typeof(global::OpenRouter.OutputItemsVariant15),
                OpenrouterMemory,
                typeof(global::OpenRouter.OutputItemsVariant16),
                OpenrouterTextEditor,
                typeof(global::OpenRouter.OutputItemsVariant17),
                OpenrouterToolSearch,
                typeof(global::OpenRouter.OutputItemsVariant18),
                OpenrouterWebFetch,
                typeof(global::OpenRouter.OutputItemsVariant19),
                OpenrouterWebSearch,
                typeof(global::OpenRouter.OutputItemsVariant20),
                Reasoning,
                typeof(global::OpenRouter.OutputItemsVariant21),
                WebSearchCall,
                typeof(global::OpenRouter.OutputItemsVariant22),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant1?>.Default.Equals(CodeInterpreterCall, other.CodeInterpreterCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant2?>.Default.Equals(ComputerCall, other.ComputerCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant3?>.Default.Equals(FileSearchCall, other.FileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant4?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant5?>.Default.Equals(ImageGenerationCall, other.ImageGenerationCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant6?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant7?>.Default.Equals(OpenrouterApplyPatch, other.OpenrouterApplyPatch) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant8?>.Default.Equals(OpenrouterBash, other.OpenrouterBash) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant9?>.Default.Equals(OpenrouterBrowserUse, other.OpenrouterBrowserUse) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant10?>.Default.Equals(OpenrouterCodeInterpreter, other.OpenrouterCodeInterpreter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant11?>.Default.Equals(OpenrouterDatetime, other.OpenrouterDatetime) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant12?>.Default.Equals(OpenrouterExperimentalSearchModels, other.OpenrouterExperimentalSearchModels) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant13?>.Default.Equals(OpenrouterFileSearch, other.OpenrouterFileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant14?>.Default.Equals(OpenrouterImageGeneration, other.OpenrouterImageGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant15?>.Default.Equals(OpenrouterMcp, other.OpenrouterMcp) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant16?>.Default.Equals(OpenrouterMemory, other.OpenrouterMemory) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant17?>.Default.Equals(OpenrouterTextEditor, other.OpenrouterTextEditor) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant18?>.Default.Equals(OpenrouterToolSearch, other.OpenrouterToolSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant19?>.Default.Equals(OpenrouterWebFetch, other.OpenrouterWebFetch) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant20?>.Default.Equals(OpenrouterWebSearch, other.OpenrouterWebSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant21?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant22?>.Default.Equals(WebSearchCall, other.WebSearchCall) 
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
