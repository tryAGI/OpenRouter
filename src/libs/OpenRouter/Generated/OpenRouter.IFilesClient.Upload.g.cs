#nullable enable

namespace OpenRouter
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload a file<br/>
        /// Uploads a file to be referenced in future API calls. The file is stored under the workspace of the authenticating API key. Maximum file size: 100 MB; empty files are rejected. The file type is determined from the file contents — not the filename or the declared content type — and must be a PDF, a PNG/JPEG/GIF/WebP image, a DOCX/XLSX/PPTX document, an MP3/WAV/FLAC/OGG audio file, or UTF-8 text. Text is reported by its structure as `application/json`, `application/x-ndjson`, `text/csv`, `text/markdown`, or `text/plain`.
        /// </summary>
        /// <param name="workspaceId">
        /// Workspace to scope the request to. Defaults to the caller’s default workspace.<br/>
        /// Example: a103d8b6-42f0-4e50-9a3c-bf41e2c3c1a7
        /// </param>
        /// <param name="provider">
        /// Store or read this file on the named provider using your own API key for it. Omit to use OpenRouter storage.<br/>
        /// Example: openai
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.FileResponse> UploadAsync(

            global::OpenRouter.UploadFileRequest request,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.FileProvider? provider = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file<br/>
        /// Uploads a file to be referenced in future API calls. The file is stored under the workspace of the authenticating API key. Maximum file size: 100 MB; empty files are rejected. The file type is determined from the file contents — not the filename or the declared content type — and must be a PDF, a PNG/JPEG/GIF/WebP image, a DOCX/XLSX/PPTX document, an MP3/WAV/FLAC/OGG audio file, or UTF-8 text. Text is reported by its structure as `application/json`, `application/x-ndjson`, `text/csv`, `text/markdown`, or `text/plain`.
        /// </summary>
        /// <param name="workspaceId">
        /// Workspace to scope the request to. Defaults to the caller’s default workspace.<br/>
        /// Example: a103d8b6-42f0-4e50-9a3c-bf41e2c3c1a7
        /// </param>
        /// <param name="provider">
        /// Store or read this file on the named provider using your own API key for it. Omit to use OpenRouter storage.<br/>
        /// Example: openai
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.FileResponse>> UploadAsResponseAsync(

            global::OpenRouter.UploadFileRequest request,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.FileProvider? provider = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file<br/>
        /// Uploads a file to be referenced in future API calls. The file is stored under the workspace of the authenticating API key. Maximum file size: 100 MB; empty files are rejected. The file type is determined from the file contents — not the filename or the declared content type — and must be a PDF, a PNG/JPEG/GIF/WebP image, a DOCX/XLSX/PPTX document, an MP3/WAV/FLAC/OGG audio file, or UTF-8 text. Text is reported by its structure as `application/json`, `application/x-ndjson`, `text/csv`, `text/markdown`, or `text/plain`.
        /// </summary>
        /// <param name="workspaceId">
        /// Workspace to scope the request to. Defaults to the caller’s default workspace.<br/>
        /// Example: a103d8b6-42f0-4e50-9a3c-bf41e2c3c1a7
        /// </param>
        /// <param name="provider">
        /// Store or read this file on the named provider using your own API key for it. Omit to use OpenRouter storage.<br/>
        /// Example: openai
        /// </param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.FileResponse> UploadAsync(
            byte[] file,
            string filename,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.FileProvider? provider = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a file<br/>
        /// Uploads a file to be referenced in future API calls. The file is stored under the workspace of the authenticating API key. Maximum file size: 100 MB; empty files are rejected. The file type is determined from the file contents — not the filename or the declared content type — and must be a PDF, a PNG/JPEG/GIF/WebP image, a DOCX/XLSX/PPTX document, an MP3/WAV/FLAC/OGG audio file, or UTF-8 text. Text is reported by its structure as `application/json`, `application/x-ndjson`, `text/csv`, `text/markdown`, or `text/plain`.
        /// </summary>
        /// <param name="workspaceId">
        /// Workspace to scope the request to. Defaults to the caller’s default workspace.<br/>
        /// Example: a103d8b6-42f0-4e50-9a3c-bf41e2c3c1a7
        /// </param>
        /// <param name="provider">
        /// Store or read this file on the named provider using your own API key for it. Omit to use OpenRouter storage.<br/>
        /// Example: openai
        /// </param>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.FileResponse> UploadAsync(
            global::System.IO.Stream file,
            string filename,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.FileProvider? provider = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file<br/>
        /// Uploads a file to be referenced in future API calls. The file is stored under the workspace of the authenticating API key. Maximum file size: 100 MB; empty files are rejected. The file type is determined from the file contents — not the filename or the declared content type — and must be a PDF, a PNG/JPEG/GIF/WebP image, a DOCX/XLSX/PPTX document, an MP3/WAV/FLAC/OGG audio file, or UTF-8 text. Text is reported by its structure as `application/json`, `application/x-ndjson`, `text/csv`, `text/markdown`, or `text/plain`.
        /// </summary>
        /// <param name="workspaceId">
        /// Workspace to scope the request to. Defaults to the caller’s default workspace.<br/>
        /// Example: a103d8b6-42f0-4e50-9a3c-bf41e2c3c1a7
        /// </param>
        /// <param name="provider">
        /// Store or read this file on the named provider using your own API key for it. Omit to use OpenRouter storage.<br/>
        /// Example: openai
        /// </param>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.FileResponse>> UploadAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.FileProvider? provider = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}