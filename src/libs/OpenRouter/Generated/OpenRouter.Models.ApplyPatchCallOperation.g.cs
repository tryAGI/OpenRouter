#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The patch operation requested by an `apply_patch_call`. `create_file` and `update_file` carry a V4A diff; `delete_file` omits it.<br/>
    /// Example: {"diff":"@@ function main() {\n\u002B  console.log(\u0022hi\u0022);\n }","path":"/src/main.ts","type":"update_file"}
    /// </summary>
    public readonly partial struct ApplyPatchCallOperation : global::System.IEquatable<ApplyPatchCallOperation>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiscriminatorType? Type { get; }

        /// <summary>
        /// The `create_file` variant of an `apply_patch_call.operation`. Carries a V4A diff describing the new file contents.<br/>
        /// Example: {"diff":"@@\n\u002Bconsole.log(\u0022hi\u0022);\n","path":"/src/main.ts","type":"create_file"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchCreateFileOperation? CreateFile { get; init; }
#else
        public global::OpenRouter.ApplyPatchCreateFileOperation? CreateFile { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateFile))]
#endif
        public bool IsCreateFile => CreateFile != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchCreateFileOperation? value)
        {
            value = CreateFile;
            return IsCreateFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCreateFileOperation PickCreateFile() => CreateFile is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateFile' but the value was {ToString()}.");

        /// <summary>
        /// The `update_file` variant of an `apply_patch_call.operation`. Carries a V4A diff describing edits to an existing file.<br/>
        /// Example: {"diff":"@@ function main() {\n\u002B  console.log(\u0022hi\u0022);\n }","path":"/src/main.ts","type":"update_file"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchUpdateFileOperation? UpdateFile { get; init; }
#else
        public global::OpenRouter.ApplyPatchUpdateFileOperation? UpdateFile { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateFile))]
#endif
        public bool IsUpdateFile => UpdateFile != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUpdateFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchUpdateFileOperation? value)
        {
            value = UpdateFile;
            return IsUpdateFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchUpdateFileOperation PickUpdateFile() => UpdateFile is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateFile' but the value was {ToString()}.");

        /// <summary>
        /// The `delete_file` variant of an `apply_patch_call.operation`. Identifies the file to remove; no diff is required.<br/>
        /// Example: {"path":"/src/main.ts","type":"delete_file"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchDeleteFileOperation? DeleteFile { get; init; }
#else
        public global::OpenRouter.ApplyPatchDeleteFileOperation? DeleteFile { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteFile))]
#endif
        public bool IsDeleteFile => DeleteFile != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDeleteFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchDeleteFileOperation? value)
        {
            value = DeleteFile;
            return IsDeleteFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchDeleteFileOperation PickDeleteFile() => DeleteFile is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeleteFile' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ApplyPatchCallOperation(global::OpenRouter.ApplyPatchCreateFileOperation value) => new ApplyPatchCallOperation((global::OpenRouter.ApplyPatchCreateFileOperation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchCreateFileOperation?(ApplyPatchCallOperation @this) => @this.CreateFile;

        /// <summary>
        ///
        /// </summary>
        public ApplyPatchCallOperation(global::OpenRouter.ApplyPatchCreateFileOperation? value)
        {
            CreateFile = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ApplyPatchCallOperation FromCreateFile(global::OpenRouter.ApplyPatchCreateFileOperation? value) => new ApplyPatchCallOperation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ApplyPatchCallOperation(global::OpenRouter.ApplyPatchUpdateFileOperation value) => new ApplyPatchCallOperation((global::OpenRouter.ApplyPatchUpdateFileOperation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchUpdateFileOperation?(ApplyPatchCallOperation @this) => @this.UpdateFile;

        /// <summary>
        ///
        /// </summary>
        public ApplyPatchCallOperation(global::OpenRouter.ApplyPatchUpdateFileOperation? value)
        {
            UpdateFile = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ApplyPatchCallOperation FromUpdateFile(global::OpenRouter.ApplyPatchUpdateFileOperation? value) => new ApplyPatchCallOperation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ApplyPatchCallOperation(global::OpenRouter.ApplyPatchDeleteFileOperation value) => new ApplyPatchCallOperation((global::OpenRouter.ApplyPatchDeleteFileOperation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchDeleteFileOperation?(ApplyPatchCallOperation @this) => @this.DeleteFile;

        /// <summary>
        ///
        /// </summary>
        public ApplyPatchCallOperation(global::OpenRouter.ApplyPatchDeleteFileOperation? value)
        {
            DeleteFile = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ApplyPatchCallOperation FromDeleteFile(global::OpenRouter.ApplyPatchDeleteFileOperation? value) => new ApplyPatchCallOperation(value);

        /// <summary>
        ///
        /// </summary>
        public ApplyPatchCallOperation(
            global::OpenRouter.ApplyPatchCallOperationDiscriminatorType? type,
            global::OpenRouter.ApplyPatchCreateFileOperation? createFile,
            global::OpenRouter.ApplyPatchUpdateFileOperation? updateFile,
            global::OpenRouter.ApplyPatchDeleteFileOperation? deleteFile
            )
        {
            Type = type;

            CreateFile = createFile;
            UpdateFile = updateFile;
            DeleteFile = deleteFile;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            DeleteFile as object ??
            UpdateFile as object ??
            CreateFile as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CreateFile?.ToString() ??
            UpdateFile?.ToString() ??
            DeleteFile?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCreateFile && !IsUpdateFile && !IsDeleteFile || !IsCreateFile && IsUpdateFile && !IsDeleteFile || !IsCreateFile && !IsUpdateFile && IsDeleteFile;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ApplyPatchCreateFileOperation, TResult>? createFile = null,
            global::System.Func<global::OpenRouter.ApplyPatchUpdateFileOperation, TResult>? updateFile = null,
            global::System.Func<global::OpenRouter.ApplyPatchDeleteFileOperation, TResult>? deleteFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CreateFile is { } __value0 && createFile != null)
            {
                return createFile(__value0);
            }
            else if (UpdateFile is { } __value1 && updateFile != null)
            {
                return updateFile(__value1);
            }
            else if (DeleteFile is { } __value2 && deleteFile != null)
            {
                return deleteFile(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ApplyPatchCreateFileOperation>? createFile = null,

            global::System.Action<global::OpenRouter.ApplyPatchUpdateFileOperation>? updateFile = null,

            global::System.Action<global::OpenRouter.ApplyPatchDeleteFileOperation>? deleteFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CreateFile is { } __value0)
            {
                createFile?.Invoke(__value0);
            }
            else if (UpdateFile is { } __value1)
            {
                updateFile?.Invoke(__value1);
            }
            else if (DeleteFile is { } __value2)
            {
                deleteFile?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ApplyPatchCreateFileOperation>? createFile = null,
            global::System.Action<global::OpenRouter.ApplyPatchUpdateFileOperation>? updateFile = null,
            global::System.Action<global::OpenRouter.ApplyPatchDeleteFileOperation>? deleteFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CreateFile is { } __value0)
            {
                createFile?.Invoke(__value0);
            }
            else if (UpdateFile is { } __value1)
            {
                updateFile?.Invoke(__value1);
            }
            else if (DeleteFile is { } __value2)
            {
                deleteFile?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateFile,
                typeof(global::OpenRouter.ApplyPatchCreateFileOperation),
                UpdateFile,
                typeof(global::OpenRouter.ApplyPatchUpdateFileOperation),
                DeleteFile,
                typeof(global::OpenRouter.ApplyPatchDeleteFileOperation),
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
        public bool Equals(ApplyPatchCallOperation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCreateFileOperation?>.Default.Equals(CreateFile, other.CreateFile) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchUpdateFileOperation?>.Default.Equals(UpdateFile, other.UpdateFile) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchDeleteFileOperation?>.Default.Equals(DeleteFile, other.DeleteFile)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ApplyPatchCallOperation obj1, ApplyPatchCallOperation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ApplyPatchCallOperation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ApplyPatchCallOperation obj1, ApplyPatchCallOperation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ApplyPatchCallOperation o && Equals(o);
        }
    }
}
