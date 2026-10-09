#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Input for a response request - can be a string or array of items<br/>
    /// Example: [{"content":"What is the weather today?","role":"user"}]
    /// </summary>
    public readonly partial struct Inputs : global::System.IEquatable<Inputs>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? InputsVariant1 { get; init; }
#else
        public string? InputsVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputsVariant1))]
#endif
        public bool IsInputsVariant1 => InputsVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputsVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = InputsVariant1;
            return IsInputsVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickInputsVariant1() => InputsVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputsVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ReasoningItem?, global::OpenRouter.EasyInputMessage, global::OpenRouter.InputMessageItem, global::OpenRouter.FunctionCallItem, global::OpenRouter.FunctionCallOutputItem?, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.AllOf<global::OpenRouter.OutputMessageItem?, global::OpenRouter.InputsVariant2ItemVariant82>?, global::OpenRouter.AllOf<global::OpenRouter.OutputReasoningItem?, global::OpenRouter.InputsVariant2ItemVariant92>?, global::OpenRouter.OutputWebSearchCallItem?, global::OpenRouter.OutputFileSearchCallItem?, global::OpenRouter.OutputImageGenerationCallItem?, global::OpenRouter.OutputCodeInterpreterCallItem?, global::OpenRouter.OutputComputerCallItem, global::OpenRouter.OutputDatetimeItem, global::OpenRouter.OutputWebSearchServerToolItem, global::OpenRouter.OutputCodeInterpreterServerToolItem, global::OpenRouter.OutputFileSearchServerToolItem, global::OpenRouter.OutputImageGenerationServerToolItem, global::OpenRouter.OutputBrowserUseServerToolItem, global::OpenRouter.OutputBashServerToolItem, global::OpenRouter.OutputTextEditorServerToolItem, global::OpenRouter.OutputApplyPatchServerToolItem, global::OpenRouter.OutputWebFetchServerToolItem, global::OpenRouter.OutputToolSearchServerToolItem, global::OpenRouter.OutputMemoryServerToolItem, global::OpenRouter.OutputMcpServerToolItem, global::OpenRouter.OutputSearchModelsServerToolItem, global::OpenRouter.OutputFusionServerToolItem, global::OpenRouter.OutputAdvisorServerToolItem, global::OpenRouter.OutputSubagentServerToolItem, global::OpenRouter.OutputFilesServerToolItem, global::OpenRouter.OutputShellServerToolItem, global::OpenRouter.LocalShellCallItem, global::OpenRouter.LocalShellCallOutputItem, global::OpenRouter.ShellCallItem, global::OpenRouter.ShellCallOutputItem, global::OpenRouter.McpListToolsItem, global::OpenRouter.McpApprovalRequestItem, global::OpenRouter.McpApprovalResponseItem, global::OpenRouter.McpCallItem, global::OpenRouter.CustomToolCallItem, global::OpenRouter.CustomToolCallOutputItem?, global::OpenRouter.CompactionItem, global::OpenRouter.ContextCompactionItem, global::OpenRouter.ItemReferenceItem, global::OpenRouter.AdditionalToolsItem, global::OpenRouter.AgentMessageItem, global::OpenRouter.ConfigurationUpdateItem, global::OpenRouter.ToolSearchCallItem, global::OpenRouter.ToolSearchOutputItem>>? InputsVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ReasoningItem?, global::OpenRouter.EasyInputMessage, global::OpenRouter.InputMessageItem, global::OpenRouter.FunctionCallItem, global::OpenRouter.FunctionCallOutputItem?, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.AllOf<global::OpenRouter.OutputMessageItem?, global::OpenRouter.InputsVariant2ItemVariant82>?, global::OpenRouter.AllOf<global::OpenRouter.OutputReasoningItem?, global::OpenRouter.InputsVariant2ItemVariant92>?, global::OpenRouter.OutputWebSearchCallItem?, global::OpenRouter.OutputFileSearchCallItem?, global::OpenRouter.OutputImageGenerationCallItem?, global::OpenRouter.OutputCodeInterpreterCallItem?, global::OpenRouter.OutputComputerCallItem, global::OpenRouter.OutputDatetimeItem, global::OpenRouter.OutputWebSearchServerToolItem, global::OpenRouter.OutputCodeInterpreterServerToolItem, global::OpenRouter.OutputFileSearchServerToolItem, global::OpenRouter.OutputImageGenerationServerToolItem, global::OpenRouter.OutputBrowserUseServerToolItem, global::OpenRouter.OutputBashServerToolItem, global::OpenRouter.OutputTextEditorServerToolItem, global::OpenRouter.OutputApplyPatchServerToolItem, global::OpenRouter.OutputWebFetchServerToolItem, global::OpenRouter.OutputToolSearchServerToolItem, global::OpenRouter.OutputMemoryServerToolItem, global::OpenRouter.OutputMcpServerToolItem, global::OpenRouter.OutputSearchModelsServerToolItem, global::OpenRouter.OutputFusionServerToolItem, global::OpenRouter.OutputAdvisorServerToolItem, global::OpenRouter.OutputSubagentServerToolItem, global::OpenRouter.OutputFilesServerToolItem, global::OpenRouter.OutputShellServerToolItem, global::OpenRouter.LocalShellCallItem, global::OpenRouter.LocalShellCallOutputItem, global::OpenRouter.ShellCallItem, global::OpenRouter.ShellCallOutputItem, global::OpenRouter.McpListToolsItem, global::OpenRouter.McpApprovalRequestItem, global::OpenRouter.McpApprovalResponseItem, global::OpenRouter.McpCallItem, global::OpenRouter.CustomToolCallItem, global::OpenRouter.CustomToolCallOutputItem?, global::OpenRouter.CompactionItem, global::OpenRouter.ContextCompactionItem, global::OpenRouter.ItemReferenceItem, global::OpenRouter.AdditionalToolsItem, global::OpenRouter.AgentMessageItem, global::OpenRouter.ConfigurationUpdateItem, global::OpenRouter.ToolSearchCallItem, global::OpenRouter.ToolSearchOutputItem>>? InputsVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputsVariant2))]
#endif
        public bool IsInputsVariant2 => InputsVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ReasoningItem?, global::OpenRouter.EasyInputMessage, global::OpenRouter.InputMessageItem, global::OpenRouter.FunctionCallItem, global::OpenRouter.FunctionCallOutputItem?, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.AllOf<global::OpenRouter.OutputMessageItem?, global::OpenRouter.InputsVariant2ItemVariant82>?, global::OpenRouter.AllOf<global::OpenRouter.OutputReasoningItem?, global::OpenRouter.InputsVariant2ItemVariant92>?, global::OpenRouter.OutputWebSearchCallItem?, global::OpenRouter.OutputFileSearchCallItem?, global::OpenRouter.OutputImageGenerationCallItem?, global::OpenRouter.OutputCodeInterpreterCallItem?, global::OpenRouter.OutputComputerCallItem, global::OpenRouter.OutputDatetimeItem, global::OpenRouter.OutputWebSearchServerToolItem, global::OpenRouter.OutputCodeInterpreterServerToolItem, global::OpenRouter.OutputFileSearchServerToolItem, global::OpenRouter.OutputImageGenerationServerToolItem, global::OpenRouter.OutputBrowserUseServerToolItem, global::OpenRouter.OutputBashServerToolItem, global::OpenRouter.OutputTextEditorServerToolItem, global::OpenRouter.OutputApplyPatchServerToolItem, global::OpenRouter.OutputWebFetchServerToolItem, global::OpenRouter.OutputToolSearchServerToolItem, global::OpenRouter.OutputMemoryServerToolItem, global::OpenRouter.OutputMcpServerToolItem, global::OpenRouter.OutputSearchModelsServerToolItem, global::OpenRouter.OutputFusionServerToolItem, global::OpenRouter.OutputAdvisorServerToolItem, global::OpenRouter.OutputSubagentServerToolItem, global::OpenRouter.OutputFilesServerToolItem, global::OpenRouter.OutputShellServerToolItem, global::OpenRouter.LocalShellCallItem, global::OpenRouter.LocalShellCallOutputItem, global::OpenRouter.ShellCallItem, global::OpenRouter.ShellCallOutputItem, global::OpenRouter.McpListToolsItem, global::OpenRouter.McpApprovalRequestItem, global::OpenRouter.McpApprovalResponseItem, global::OpenRouter.McpCallItem, global::OpenRouter.CustomToolCallItem, global::OpenRouter.CustomToolCallOutputItem?, global::OpenRouter.CompactionItem, global::OpenRouter.ContextCompactionItem, global::OpenRouter.ItemReferenceItem, global::OpenRouter.AdditionalToolsItem, global::OpenRouter.AgentMessageItem, global::OpenRouter.ConfigurationUpdateItem, global::OpenRouter.ToolSearchCallItem, global::OpenRouter.ToolSearchOutputItem>>? value)
        {
            value = InputsVariant2;
            return IsInputsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ReasoningItem?, global::OpenRouter.EasyInputMessage, global::OpenRouter.InputMessageItem, global::OpenRouter.FunctionCallItem, global::OpenRouter.FunctionCallOutputItem?, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.AllOf<global::OpenRouter.OutputMessageItem?, global::OpenRouter.InputsVariant2ItemVariant82>?, global::OpenRouter.AllOf<global::OpenRouter.OutputReasoningItem?, global::OpenRouter.InputsVariant2ItemVariant92>?, global::OpenRouter.OutputWebSearchCallItem?, global::OpenRouter.OutputFileSearchCallItem?, global::OpenRouter.OutputImageGenerationCallItem?, global::OpenRouter.OutputCodeInterpreterCallItem?, global::OpenRouter.OutputComputerCallItem, global::OpenRouter.OutputDatetimeItem, global::OpenRouter.OutputWebSearchServerToolItem, global::OpenRouter.OutputCodeInterpreterServerToolItem, global::OpenRouter.OutputFileSearchServerToolItem, global::OpenRouter.OutputImageGenerationServerToolItem, global::OpenRouter.OutputBrowserUseServerToolItem, global::OpenRouter.OutputBashServerToolItem, global::OpenRouter.OutputTextEditorServerToolItem, global::OpenRouter.OutputApplyPatchServerToolItem, global::OpenRouter.OutputWebFetchServerToolItem, global::OpenRouter.OutputToolSearchServerToolItem, global::OpenRouter.OutputMemoryServerToolItem, global::OpenRouter.OutputMcpServerToolItem, global::OpenRouter.OutputSearchModelsServerToolItem, global::OpenRouter.OutputFusionServerToolItem, global::OpenRouter.OutputAdvisorServerToolItem, global::OpenRouter.OutputSubagentServerToolItem, global::OpenRouter.OutputFilesServerToolItem, global::OpenRouter.OutputShellServerToolItem, global::OpenRouter.LocalShellCallItem, global::OpenRouter.LocalShellCallOutputItem, global::OpenRouter.ShellCallItem, global::OpenRouter.ShellCallOutputItem, global::OpenRouter.McpListToolsItem, global::OpenRouter.McpApprovalRequestItem, global::OpenRouter.McpApprovalResponseItem, global::OpenRouter.McpCallItem, global::OpenRouter.CustomToolCallItem, global::OpenRouter.CustomToolCallOutputItem?, global::OpenRouter.CompactionItem, global::OpenRouter.ContextCompactionItem, global::OpenRouter.ItemReferenceItem, global::OpenRouter.AdditionalToolsItem, global::OpenRouter.AgentMessageItem, global::OpenRouter.ConfigurationUpdateItem, global::OpenRouter.ToolSearchCallItem, global::OpenRouter.ToolSearchOutputItem>> PickInputsVariant2() => InputsVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputsVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Inputs(string value) => new Inputs((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(Inputs @this) => @this.InputsVariant1;

        /// <summary>
        ///
        /// </summary>
        public Inputs(string? value)
        {
            InputsVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Inputs FromInputsVariant1(string? value) => new Inputs(value);

        /// <summary>
        ///
        /// </summary>
        public Inputs(
            string? inputsVariant1,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ReasoningItem?, global::OpenRouter.EasyInputMessage, global::OpenRouter.InputMessageItem, global::OpenRouter.FunctionCallItem, global::OpenRouter.FunctionCallOutputItem?, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.AllOf<global::OpenRouter.OutputMessageItem?, global::OpenRouter.InputsVariant2ItemVariant82>?, global::OpenRouter.AllOf<global::OpenRouter.OutputReasoningItem?, global::OpenRouter.InputsVariant2ItemVariant92>?, global::OpenRouter.OutputWebSearchCallItem?, global::OpenRouter.OutputFileSearchCallItem?, global::OpenRouter.OutputImageGenerationCallItem?, global::OpenRouter.OutputCodeInterpreterCallItem?, global::OpenRouter.OutputComputerCallItem, global::OpenRouter.OutputDatetimeItem, global::OpenRouter.OutputWebSearchServerToolItem, global::OpenRouter.OutputCodeInterpreterServerToolItem, global::OpenRouter.OutputFileSearchServerToolItem, global::OpenRouter.OutputImageGenerationServerToolItem, global::OpenRouter.OutputBrowserUseServerToolItem, global::OpenRouter.OutputBashServerToolItem, global::OpenRouter.OutputTextEditorServerToolItem, global::OpenRouter.OutputApplyPatchServerToolItem, global::OpenRouter.OutputWebFetchServerToolItem, global::OpenRouter.OutputToolSearchServerToolItem, global::OpenRouter.OutputMemoryServerToolItem, global::OpenRouter.OutputMcpServerToolItem, global::OpenRouter.OutputSearchModelsServerToolItem, global::OpenRouter.OutputFusionServerToolItem, global::OpenRouter.OutputAdvisorServerToolItem, global::OpenRouter.OutputSubagentServerToolItem, global::OpenRouter.OutputFilesServerToolItem, global::OpenRouter.OutputShellServerToolItem, global::OpenRouter.LocalShellCallItem, global::OpenRouter.LocalShellCallOutputItem, global::OpenRouter.ShellCallItem, global::OpenRouter.ShellCallOutputItem, global::OpenRouter.McpListToolsItem, global::OpenRouter.McpApprovalRequestItem, global::OpenRouter.McpApprovalResponseItem, global::OpenRouter.McpCallItem, global::OpenRouter.CustomToolCallItem, global::OpenRouter.CustomToolCallOutputItem?, global::OpenRouter.CompactionItem, global::OpenRouter.ContextCompactionItem, global::OpenRouter.ItemReferenceItem, global::OpenRouter.AdditionalToolsItem, global::OpenRouter.AgentMessageItem, global::OpenRouter.ConfigurationUpdateItem, global::OpenRouter.ToolSearchCallItem, global::OpenRouter.ToolSearchOutputItem>>? inputsVariant2
            )
        {
            InputsVariant1 = inputsVariant1;
            InputsVariant2 = inputsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            InputsVariant2 as object ??
            InputsVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InputsVariant1?.ToString() ??
            InputsVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInputsVariant1 || IsInputsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? inputsVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ReasoningItem?, global::OpenRouter.EasyInputMessage, global::OpenRouter.InputMessageItem, global::OpenRouter.FunctionCallItem, global::OpenRouter.FunctionCallOutputItem?, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.AllOf<global::OpenRouter.OutputMessageItem?, global::OpenRouter.InputsVariant2ItemVariant82>?, global::OpenRouter.AllOf<global::OpenRouter.OutputReasoningItem?, global::OpenRouter.InputsVariant2ItemVariant92>?, global::OpenRouter.OutputWebSearchCallItem?, global::OpenRouter.OutputFileSearchCallItem?, global::OpenRouter.OutputImageGenerationCallItem?, global::OpenRouter.OutputCodeInterpreterCallItem?, global::OpenRouter.OutputComputerCallItem, global::OpenRouter.OutputDatetimeItem, global::OpenRouter.OutputWebSearchServerToolItem, global::OpenRouter.OutputCodeInterpreterServerToolItem, global::OpenRouter.OutputFileSearchServerToolItem, global::OpenRouter.OutputImageGenerationServerToolItem, global::OpenRouter.OutputBrowserUseServerToolItem, global::OpenRouter.OutputBashServerToolItem, global::OpenRouter.OutputTextEditorServerToolItem, global::OpenRouter.OutputApplyPatchServerToolItem, global::OpenRouter.OutputWebFetchServerToolItem, global::OpenRouter.OutputToolSearchServerToolItem, global::OpenRouter.OutputMemoryServerToolItem, global::OpenRouter.OutputMcpServerToolItem, global::OpenRouter.OutputSearchModelsServerToolItem, global::OpenRouter.OutputFusionServerToolItem, global::OpenRouter.OutputAdvisorServerToolItem, global::OpenRouter.OutputSubagentServerToolItem, global::OpenRouter.OutputFilesServerToolItem, global::OpenRouter.OutputShellServerToolItem, global::OpenRouter.LocalShellCallItem, global::OpenRouter.LocalShellCallOutputItem, global::OpenRouter.ShellCallItem, global::OpenRouter.ShellCallOutputItem, global::OpenRouter.McpListToolsItem, global::OpenRouter.McpApprovalRequestItem, global::OpenRouter.McpApprovalResponseItem, global::OpenRouter.McpCallItem, global::OpenRouter.CustomToolCallItem, global::OpenRouter.CustomToolCallOutputItem?, global::OpenRouter.CompactionItem, global::OpenRouter.ContextCompactionItem, global::OpenRouter.ItemReferenceItem, global::OpenRouter.AdditionalToolsItem, global::OpenRouter.AgentMessageItem, global::OpenRouter.ConfigurationUpdateItem, global::OpenRouter.ToolSearchCallItem, global::OpenRouter.ToolSearchOutputItem>>, TResult>? inputsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputsVariant1 is { } __value0 && inputsVariant1 != null)
            {
                return inputsVariant1(__value0);
            }
            else if (InputsVariant2 is { } __value1 && inputsVariant2 != null)
            {
                return inputsVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? inputsVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ReasoningItem?, global::OpenRouter.EasyInputMessage, global::OpenRouter.InputMessageItem, global::OpenRouter.FunctionCallItem, global::OpenRouter.FunctionCallOutputItem?, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.AllOf<global::OpenRouter.OutputMessageItem?, global::OpenRouter.InputsVariant2ItemVariant82>?, global::OpenRouter.AllOf<global::OpenRouter.OutputReasoningItem?, global::OpenRouter.InputsVariant2ItemVariant92>?, global::OpenRouter.OutputWebSearchCallItem?, global::OpenRouter.OutputFileSearchCallItem?, global::OpenRouter.OutputImageGenerationCallItem?, global::OpenRouter.OutputCodeInterpreterCallItem?, global::OpenRouter.OutputComputerCallItem, global::OpenRouter.OutputDatetimeItem, global::OpenRouter.OutputWebSearchServerToolItem, global::OpenRouter.OutputCodeInterpreterServerToolItem, global::OpenRouter.OutputFileSearchServerToolItem, global::OpenRouter.OutputImageGenerationServerToolItem, global::OpenRouter.OutputBrowserUseServerToolItem, global::OpenRouter.OutputBashServerToolItem, global::OpenRouter.OutputTextEditorServerToolItem, global::OpenRouter.OutputApplyPatchServerToolItem, global::OpenRouter.OutputWebFetchServerToolItem, global::OpenRouter.OutputToolSearchServerToolItem, global::OpenRouter.OutputMemoryServerToolItem, global::OpenRouter.OutputMcpServerToolItem, global::OpenRouter.OutputSearchModelsServerToolItem, global::OpenRouter.OutputFusionServerToolItem, global::OpenRouter.OutputAdvisorServerToolItem, global::OpenRouter.OutputSubagentServerToolItem, global::OpenRouter.OutputFilesServerToolItem, global::OpenRouter.OutputShellServerToolItem, global::OpenRouter.LocalShellCallItem, global::OpenRouter.LocalShellCallOutputItem, global::OpenRouter.ShellCallItem, global::OpenRouter.ShellCallOutputItem, global::OpenRouter.McpListToolsItem, global::OpenRouter.McpApprovalRequestItem, global::OpenRouter.McpApprovalResponseItem, global::OpenRouter.McpCallItem, global::OpenRouter.CustomToolCallItem, global::OpenRouter.CustomToolCallOutputItem?, global::OpenRouter.CompactionItem, global::OpenRouter.ContextCompactionItem, global::OpenRouter.ItemReferenceItem, global::OpenRouter.AdditionalToolsItem, global::OpenRouter.AgentMessageItem, global::OpenRouter.ConfigurationUpdateItem, global::OpenRouter.ToolSearchCallItem, global::OpenRouter.ToolSearchOutputItem>>>? inputsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputsVariant1 is { } __value0)
            {
                inputsVariant1?.Invoke(__value0);
            }
            else if (InputsVariant2 is { } __value1)
            {
                inputsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? inputsVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ReasoningItem?, global::OpenRouter.EasyInputMessage, global::OpenRouter.InputMessageItem, global::OpenRouter.FunctionCallItem, global::OpenRouter.FunctionCallOutputItem?, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.AllOf<global::OpenRouter.OutputMessageItem?, global::OpenRouter.InputsVariant2ItemVariant82>?, global::OpenRouter.AllOf<global::OpenRouter.OutputReasoningItem?, global::OpenRouter.InputsVariant2ItemVariant92>?, global::OpenRouter.OutputWebSearchCallItem?, global::OpenRouter.OutputFileSearchCallItem?, global::OpenRouter.OutputImageGenerationCallItem?, global::OpenRouter.OutputCodeInterpreterCallItem?, global::OpenRouter.OutputComputerCallItem, global::OpenRouter.OutputDatetimeItem, global::OpenRouter.OutputWebSearchServerToolItem, global::OpenRouter.OutputCodeInterpreterServerToolItem, global::OpenRouter.OutputFileSearchServerToolItem, global::OpenRouter.OutputImageGenerationServerToolItem, global::OpenRouter.OutputBrowserUseServerToolItem, global::OpenRouter.OutputBashServerToolItem, global::OpenRouter.OutputTextEditorServerToolItem, global::OpenRouter.OutputApplyPatchServerToolItem, global::OpenRouter.OutputWebFetchServerToolItem, global::OpenRouter.OutputToolSearchServerToolItem, global::OpenRouter.OutputMemoryServerToolItem, global::OpenRouter.OutputMcpServerToolItem, global::OpenRouter.OutputSearchModelsServerToolItem, global::OpenRouter.OutputFusionServerToolItem, global::OpenRouter.OutputAdvisorServerToolItem, global::OpenRouter.OutputSubagentServerToolItem, global::OpenRouter.OutputFilesServerToolItem, global::OpenRouter.OutputShellServerToolItem, global::OpenRouter.LocalShellCallItem, global::OpenRouter.LocalShellCallOutputItem, global::OpenRouter.ShellCallItem, global::OpenRouter.ShellCallOutputItem, global::OpenRouter.McpListToolsItem, global::OpenRouter.McpApprovalRequestItem, global::OpenRouter.McpApprovalResponseItem, global::OpenRouter.McpCallItem, global::OpenRouter.CustomToolCallItem, global::OpenRouter.CustomToolCallOutputItem?, global::OpenRouter.CompactionItem, global::OpenRouter.ContextCompactionItem, global::OpenRouter.ItemReferenceItem, global::OpenRouter.AdditionalToolsItem, global::OpenRouter.AgentMessageItem, global::OpenRouter.ConfigurationUpdateItem, global::OpenRouter.ToolSearchCallItem, global::OpenRouter.ToolSearchOutputItem>>>? inputsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputsVariant1 is { } __value0)
            {
                inputsVariant1?.Invoke(__value0);
            }
            else if (InputsVariant2 is { } __value1)
            {
                inputsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputsVariant1,
                typeof(string),
                InputsVariant2,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ReasoningItem?, global::OpenRouter.EasyInputMessage, global::OpenRouter.InputMessageItem, global::OpenRouter.FunctionCallItem, global::OpenRouter.FunctionCallOutputItem?, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.AllOf<global::OpenRouter.OutputMessageItem?, global::OpenRouter.InputsVariant2ItemVariant82>?, global::OpenRouter.AllOf<global::OpenRouter.OutputReasoningItem?, global::OpenRouter.InputsVariant2ItemVariant92>?, global::OpenRouter.OutputWebSearchCallItem?, global::OpenRouter.OutputFileSearchCallItem?, global::OpenRouter.OutputImageGenerationCallItem?, global::OpenRouter.OutputCodeInterpreterCallItem?, global::OpenRouter.OutputComputerCallItem, global::OpenRouter.OutputDatetimeItem, global::OpenRouter.OutputWebSearchServerToolItem, global::OpenRouter.OutputCodeInterpreterServerToolItem, global::OpenRouter.OutputFileSearchServerToolItem, global::OpenRouter.OutputImageGenerationServerToolItem, global::OpenRouter.OutputBrowserUseServerToolItem, global::OpenRouter.OutputBashServerToolItem, global::OpenRouter.OutputTextEditorServerToolItem, global::OpenRouter.OutputApplyPatchServerToolItem, global::OpenRouter.OutputWebFetchServerToolItem, global::OpenRouter.OutputToolSearchServerToolItem, global::OpenRouter.OutputMemoryServerToolItem, global::OpenRouter.OutputMcpServerToolItem, global::OpenRouter.OutputSearchModelsServerToolItem, global::OpenRouter.OutputFusionServerToolItem, global::OpenRouter.OutputAdvisorServerToolItem, global::OpenRouter.OutputSubagentServerToolItem, global::OpenRouter.OutputFilesServerToolItem, global::OpenRouter.OutputShellServerToolItem, global::OpenRouter.LocalShellCallItem, global::OpenRouter.LocalShellCallOutputItem, global::OpenRouter.ShellCallItem, global::OpenRouter.ShellCallOutputItem, global::OpenRouter.McpListToolsItem, global::OpenRouter.McpApprovalRequestItem, global::OpenRouter.McpApprovalResponseItem, global::OpenRouter.McpCallItem, global::OpenRouter.CustomToolCallItem, global::OpenRouter.CustomToolCallOutputItem?, global::OpenRouter.CompactionItem, global::OpenRouter.ContextCompactionItem, global::OpenRouter.ItemReferenceItem, global::OpenRouter.AdditionalToolsItem, global::OpenRouter.AgentMessageItem, global::OpenRouter.ConfigurationUpdateItem, global::OpenRouter.ToolSearchCallItem, global::OpenRouter.ToolSearchOutputItem>>),
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
        public bool Equals(Inputs other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(InputsVariant1, other.InputsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ReasoningItem?, global::OpenRouter.EasyInputMessage, global::OpenRouter.InputMessageItem, global::OpenRouter.FunctionCallItem, global::OpenRouter.FunctionCallOutputItem?, global::OpenRouter.ApplyPatchCallItem, global::OpenRouter.ApplyPatchCallOutputItem, global::OpenRouter.AllOf<global::OpenRouter.OutputMessageItem?, global::OpenRouter.InputsVariant2ItemVariant82>?, global::OpenRouter.AllOf<global::OpenRouter.OutputReasoningItem?, global::OpenRouter.InputsVariant2ItemVariant92>?, global::OpenRouter.OutputWebSearchCallItem?, global::OpenRouter.OutputFileSearchCallItem?, global::OpenRouter.OutputImageGenerationCallItem?, global::OpenRouter.OutputCodeInterpreterCallItem?, global::OpenRouter.OutputComputerCallItem, global::OpenRouter.OutputDatetimeItem, global::OpenRouter.OutputWebSearchServerToolItem, global::OpenRouter.OutputCodeInterpreterServerToolItem, global::OpenRouter.OutputFileSearchServerToolItem, global::OpenRouter.OutputImageGenerationServerToolItem, global::OpenRouter.OutputBrowserUseServerToolItem, global::OpenRouter.OutputBashServerToolItem, global::OpenRouter.OutputTextEditorServerToolItem, global::OpenRouter.OutputApplyPatchServerToolItem, global::OpenRouter.OutputWebFetchServerToolItem, global::OpenRouter.OutputToolSearchServerToolItem, global::OpenRouter.OutputMemoryServerToolItem, global::OpenRouter.OutputMcpServerToolItem, global::OpenRouter.OutputSearchModelsServerToolItem, global::OpenRouter.OutputFusionServerToolItem, global::OpenRouter.OutputAdvisorServerToolItem, global::OpenRouter.OutputSubagentServerToolItem, global::OpenRouter.OutputFilesServerToolItem, global::OpenRouter.OutputShellServerToolItem, global::OpenRouter.LocalShellCallItem, global::OpenRouter.LocalShellCallOutputItem, global::OpenRouter.ShellCallItem, global::OpenRouter.ShellCallOutputItem, global::OpenRouter.McpListToolsItem, global::OpenRouter.McpApprovalRequestItem, global::OpenRouter.McpApprovalResponseItem, global::OpenRouter.McpCallItem, global::OpenRouter.CustomToolCallItem, global::OpenRouter.CustomToolCallOutputItem?, global::OpenRouter.CompactionItem, global::OpenRouter.ContextCompactionItem, global::OpenRouter.ItemReferenceItem, global::OpenRouter.AdditionalToolsItem, global::OpenRouter.AgentMessageItem, global::OpenRouter.ConfigurationUpdateItem, global::OpenRouter.ToolSearchCallItem, global::OpenRouter.ToolSearchOutputItem>>?>.Default.Equals(InputsVariant2, other.InputsVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Inputs obj1, Inputs obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Inputs>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Inputs obj1, Inputs obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Inputs o && Equals(o);
        }
    }
}
