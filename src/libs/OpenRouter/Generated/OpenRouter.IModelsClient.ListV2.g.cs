#nullable enable

namespace OpenRouter
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List models with V2 endpoint documents<br/>
        /// Returns every publicly served model together with each of its endpoints in the Models API V2 document format. The V2 document is the schema providers publish to OpenRouter, so each endpoint is reported in the shape it was declared, with pricing attached to the modality it applies to (`inputs`/`outputs`, each with its `params`). Operator-only fields such as capacity and `discount_to_user` are not part of the public document.<br/>
        /// Without credentials the response is the public catalog. With an API key it is the catalog that key can route to, the same one `GET /api/v1/models/user` serves: models and endpoints the account was granted private access to are included, and endpoints the account or key guardrails, provider preferences, BYOK and privacy settings exclude are omitted, along with routers and aliases left with nothing to route to. A key that does not resolve is rejected with 401.<br/>
        /// Every field of the response document is a filter, named by its dotted JSON path: `&lt;path&gt;=&lt;value&gt;` tests equality and `&lt;path&gt;.&lt;operator&gt;=&lt;value&gt;` applies `gt`, `gte`, `lt`, `lte`, `between`, `in`, `exists`, `contains`, `starts_with` or `ends_with` as the field type allows; `&lt;path&gt;.not.&lt;operator&gt;=&lt;value&gt;` (or `&lt;path&gt;.not=&lt;value&gt;` for not-equal) keeps the records where no value matches. Suffixes, arithmetic operators, parentheses and the list comma are read before percent-decoding, so an encoded character is always literal: a map key spelled like an operator or `not` is reached by encoding one of its characters (`params.n%6Ft.exists=true`), a `/` or `+` inside a literal is `%2F` or `%2B`, and arithmetic is spelled with the bare characters (`created/10`, `context_length+1`). `in` takes a comma-separated list and `between` the inclusive lower and upper bound (a literal comma is `%2C`); strings compare trimmed and lower-cased on both sides, so `author=Anthropic` and `name.contains=claude` match. A filter under `endpoints.` keeps only the endpoints that satisfy every such filter and omits models left with none. A path through a repeated object is existential (`endpoints.pricing.type=request` matches an endpoint with some request-priced entry); the members of a typed collection are addressed by their type (`endpoints.inputs.text.params.max_length.value.gte=1000000`, `endpoints.inputs.text.pricing.prompt.cost_usd.lte=0.000001`), and a dynamic key is written in the path (`endpoints.outputs.text.params.tools.type=boolean`, `endpoints.outputs.text.params.temperature.range.max.gte=2`). Both sides of an operator are operands of one grammar: a literal, a path, or an arithmetic expression over numeric paths and numbers, so a filter relates any two of them (`endpoints.inputs.text.pricing.prompt.cost_usd.gte=endpoints.outputs.text.pricing.completion.cost_usd*100`, `10000.lte=endpoints.inputs.text.params.max_length.value`, `endpoints.id=id`). Arithmetic requires numeric paths, each operator applies to the type its operands share, and text that names no field path is a literal (`id=openai/gpt-4`), so the field names at the root of the document are reserved words. A parameter that is not a field path is rejected with a 400 whose `error.metadata` names the `code`, `parameter` and `reason`.<br/>
        /// `sort` takes comma-separated paths or expressions, `-` prefixed for descending; a key must be a scalar path or expression (`created`, `endpoints.inputs.text.pricing.prompt.cost_usd`); a model sorts by the best value in the sort direction across its endpoints and across the time windows of a price, missing values sort last and `id` ascending breaks ties, so the order is total even without `sort`. Pagination is opt-in: pass `limit` and follow `links.next`, which carries an opaque `cursor` bound to the filters and sort; `offset` remains supported. `total_count` is the number of models matching the filters.
        /// </summary>
        /// <param name="offset">
        /// Number of records to skip (0 when omitted); kept for compatibility, prefer `cursor`. Supplying limit, cursor or offset paginates the list; when all are omitted, the full list is returned.<br/>
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to return (500 when omitted, max 1000). Supplying limit, cursor or offset paginates the list; when all are omitted, the full list is returned.<br/>
        /// Example: 500
        /// </param>
        /// <param name="cursor">
        /// Opaque keyset cursor from the previous page's `links.next`. Bound to the filters and sort it was issued for; a cursor sent with different filters or sort is rejected.<br/>
        /// Example: eyJ2IjoxLCJxIjoiYjVmMWE4MDEiLCJrIjpbIm9wZW5haS9ncHQtNCJdfQ
        /// </param>
        /// <param name="region">
        /// Only return endpoints in the given data region ("eu" or "us"); models left without an endpoint are omitted.<br/>
        /// Example: eu
        /// </param>
        /// <param name="sort">
        /// Comma-separated sort keys, each a path below or an arithmetic expression over numeric paths; prefix with `-` for descending. A key under `endpoints.` ranks each model by its best endpoint value in the sort direction. Missing values sort last and `id` ascending breaks ties. Keys: `id`, `canonical_slug`, `author`, `name`, `variant`, `kind`, `alias_target.slug`, `alias_target.name`, `created`, `description`, `context_length`, `hugging_face_id`, `endpoints.schema_version`, `endpoints.id`, `endpoints.hugging_face_id`, `endpoints.name`, `endpoints.created`, `endpoints.quantization`, `endpoints.tokenizer`, `endpoints.description`, `endpoints.pricing.request.unit`, `endpoints.pricing.request.cost_usd`, `endpoints.pricing.web_search.unit`, `endpoints.pricing.web_search.cost_usd`, `endpoints.capacity.request.unit`, `endpoints.capacity.request.per`, `endpoints.capacity.request.value`, `endpoints.capacity.web_search.unit`, `endpoints.capacity.web_search.per`, `endpoints.capacity.web_search.value`, `endpoints.capacity.concurrency.unit`, `endpoints.capacity.concurrency.value`, `endpoints.deprecation_date`, `endpoints.is_ready`, `endpoints.is_free`, `endpoints.service_tier`, `endpoints.discount_to_user`, `endpoints.openrouter.slug`, `endpoints.deployment_region`, `endpoints.inputs.text.pricing.prompt.unit`, `endpoints.inputs.text.pricing.prompt.cost_usd`, `endpoints.inputs.text.pricing.prompt.utc_start`, `endpoints.inputs.text.pricing.prompt.utc_end`, `endpoints.inputs.text.pricing.cached_prompt.unit`, `endpoints.inputs.text.pricing.cached_prompt.cost_usd`, `endpoints.inputs.text.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.text.pricing.cached_prompt.implicit`, `endpoints.inputs.text.pricing.cached_prompt.utc_start`, `endpoints.inputs.text.pricing.cached_prompt.utc_end`, `endpoints.inputs.text.pricing.cache_write.unit`, `endpoints.inputs.text.pricing.cache_write.cost_usd`, `endpoints.inputs.text.pricing.cache_write.ttl_seconds`, `endpoints.inputs.text.pricing.cache_write.implicit`, `endpoints.inputs.text.pricing.cache_write.utc_start`, `endpoints.inputs.text.pricing.cache_write.utc_end`, `endpoints.inputs.text.capacity.prompt.unit`, `endpoints.inputs.text.capacity.prompt.per`, `endpoints.inputs.text.capacity.prompt.value`, `endpoints.inputs.text.capacity.cached_prompt.unit`, `endpoints.inputs.text.capacity.cached_prompt.per`, `endpoints.inputs.text.capacity.cached_prompt.value`, `endpoints.inputs.text.capacity.cache_write.unit`, `endpoints.inputs.text.capacity.cache_write.per`, `endpoints.inputs.text.capacity.cache_write.value`, `endpoints.inputs.text.params.max_prompt_length.value`, `endpoints.inputs.text.params.max_prompt_length.unit`, `endpoints.inputs.text.params.max_length.value`, `endpoints.inputs.text.params.max_length.unit`, `endpoints.inputs.image.pricing.prompt.unit`, `endpoints.inputs.image.pricing.prompt.cost_usd`, `endpoints.inputs.image.pricing.prompt.utc_start`, `endpoints.inputs.image.pricing.prompt.utc_end`, `endpoints.inputs.image.pricing.cached_prompt.unit`, `endpoints.inputs.image.pricing.cached_prompt.cost_usd`, `endpoints.inputs.image.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.image.pricing.cached_prompt.implicit`, `endpoints.inputs.image.pricing.cached_prompt.utc_start`, `endpoints.inputs.image.pricing.cached_prompt.utc_end`, `endpoints.inputs.image.pricing.cache_write.unit`, `endpoints.inputs.image.pricing.cache_write.cost_usd`, `endpoints.inputs.image.pricing.cache_write.ttl_seconds`, `endpoints.inputs.image.pricing.cache_write.implicit`, `endpoints.inputs.image.pricing.cache_write.utc_start`, `endpoints.inputs.image.pricing.cache_write.utc_end`, `endpoints.inputs.image.capacity.prompt.unit`, `endpoints.inputs.image.capacity.prompt.per`, `endpoints.inputs.image.capacity.prompt.value`, `endpoints.inputs.image.capacity.cached_prompt.unit`, `endpoints.inputs.image.capacity.cached_prompt.per`, `endpoints.inputs.image.capacity.cached_prompt.value`, `endpoints.inputs.image.capacity.cache_write.unit`, `endpoints.inputs.image.capacity.cache_write.per`, `endpoints.inputs.image.capacity.cache_write.value`, `endpoints.inputs.image.params.sources.type`, `endpoints.inputs.image.params.formats.type`, `endpoints.inputs.image.params.detail_levels.type`, `endpoints.inputs.image.params.references.type`, `endpoints.inputs.image.params.references.min`, `endpoints.inputs.image.params.references.max`, `endpoints.inputs.image.params.references.unit`, `endpoints.inputs.image.params.role.type`, `endpoints.inputs.image.params.max_content_size_bytes.value`, `endpoints.inputs.image.params.max_content_size_bytes.unit`, `endpoints.inputs.video.pricing.prompt.unit`, `endpoints.inputs.video.pricing.prompt.cost_usd`, `endpoints.inputs.video.pricing.prompt.utc_start`, `endpoints.inputs.video.pricing.prompt.utc_end`, `endpoints.inputs.video.pricing.cached_prompt.unit`, `endpoints.inputs.video.pricing.cached_prompt.cost_usd`, `endpoints.inputs.video.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.video.pricing.cached_prompt.implicit`, `endpoints.inputs.video.pricing.cached_prompt.utc_start`, `endpoints.inputs.video.pricing.cached_prompt.utc_end`, `endpoints.inputs.video.pricing.cache_write.unit`, `endpoints.inputs.video.pricing.cache_write.cost_usd`, `endpoints.inputs.video.pricing.cache_write.ttl_seconds`, `endpoints.inputs.video.pricing.cache_write.implicit`, `endpoints.inputs.video.pricing.cache_write.utc_start`, `endpoints.inputs.video.pricing.cache_write.utc_end`, `endpoints.inputs.video.capacity.prompt.unit`, `endpoints.inputs.video.capacity.prompt.per`, `endpoints.inputs.video.capacity.prompt.value`, `endpoints.inputs.video.capacity.cached_prompt.unit`, `endpoints.inputs.video.capacity.cached_prompt.per`, `endpoints.inputs.video.capacity.cached_prompt.value`, `endpoints.inputs.video.capacity.cache_write.unit`, `endpoints.inputs.video.capacity.cache_write.per`, `endpoints.inputs.video.capacity.cache_write.value`, `endpoints.inputs.video.params.sources.type`, `endpoints.inputs.video.params.formats.type`, `endpoints.inputs.video.params.max_duration_seconds.value`, `endpoints.inputs.video.params.max_duration_seconds.unit`, `endpoints.inputs.video.params.max_content_size_bytes.value`, `endpoints.inputs.video.params.max_content_size_bytes.unit`, `endpoints.inputs.audio.pricing.prompt.unit`, `endpoints.inputs.audio.pricing.prompt.cost_usd`, `endpoints.inputs.audio.pricing.prompt.utc_start`, `endpoints.inputs.audio.pricing.prompt.utc_end`, `endpoints.inputs.audio.pricing.cached_prompt.unit`, `endpoints.inputs.audio.pricing.cached_prompt.cost_usd`, `endpoints.inputs.audio.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.audio.pricing.cached_prompt.implicit`, `endpoints.inputs.audio.pricing.cached_prompt.utc_start`, `endpoints.inputs.audio.pricing.cached_prompt.utc_end`, `endpoints.inputs.audio.pricing.cache_write.unit`, `endpoints.inputs.audio.pricing.cache_write.cost_usd`, `endpoints.inputs.audio.pricing.cache_write.ttl_seconds`, `endpoints.inputs.audio.pricing.cache_write.implicit`, `endpoints.inputs.audio.pricing.cache_write.utc_start`, `endpoints.inputs.audio.pricing.cache_write.utc_end`, `endpoints.inputs.audio.capacity.prompt.unit`, `endpoints.inputs.audio.capacity.prompt.per`, `endpoints.inputs.audio.capacity.prompt.value`, `endpoints.inputs.audio.capacity.cached_prompt.unit`, `endpoints.inputs.audio.capacity.cached_prompt.per`, `endpoints.inputs.audio.capacity.cached_prompt.value`, `endpoints.inputs.audio.capacity.cache_write.unit`, `endpoints.inputs.audio.capacity.cache_write.per`, `endpoints.inputs.audio.capacity.cache_write.value`, `endpoints.inputs.audio.params.sources.type`, `endpoints.inputs.audio.params.formats.type`, `endpoints.inputs.audio.params.max_duration_seconds.value`, `endpoints.inputs.audio.params.max_duration_seconds.unit`, `endpoints.inputs.audio.params.max_content_size_bytes.value`, `endpoints.inputs.audio.params.max_content_size_bytes.unit`, `endpoints.inputs.file.pricing.prompt.unit`, `endpoints.inputs.file.pricing.prompt.cost_usd`, `endpoints.inputs.file.pricing.prompt.utc_start`, `endpoints.inputs.file.pricing.prompt.utc_end`, `endpoints.inputs.file.pricing.cached_prompt.unit`, `endpoints.inputs.file.pricing.cached_prompt.cost_usd`, `endpoints.inputs.file.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.file.pricing.cached_prompt.implicit`, `endpoints.inputs.file.pricing.cached_prompt.utc_start`, `endpoints.inputs.file.pricing.cached_prompt.utc_end`, `endpoints.inputs.file.pricing.cache_write.unit`, `endpoints.inputs.file.pricing.cache_write.cost_usd`, `endpoints.inputs.file.pricing.cache_write.ttl_seconds`, `endpoints.inputs.file.pricing.cache_write.implicit`, `endpoints.inputs.file.pricing.cache_write.utc_start`, `endpoints.inputs.file.pricing.cache_write.utc_end`, `endpoints.inputs.file.capacity.prompt.unit`, `endpoints.inputs.file.capacity.prompt.per`, `endpoints.inputs.file.capacity.prompt.value`, `endpoints.inputs.file.capacity.cached_prompt.unit`, `endpoints.inputs.file.capacity.cached_prompt.per`, `endpoints.inputs.file.capacity.cached_prompt.value`, `endpoints.inputs.file.capacity.cache_write.unit`, `endpoints.inputs.file.capacity.cache_write.per`, `endpoints.inputs.file.capacity.cache_write.value`, `endpoints.inputs.file.params.sources.type`, `endpoints.inputs.file.params.formats.type`, `endpoints.inputs.file.params.references.type`, `endpoints.inputs.file.params.references.min`, `endpoints.inputs.file.params.references.max`, `endpoints.inputs.file.params.references.unit`, `endpoints.inputs.file.params.max_content_size_bytes.value`, `endpoints.inputs.file.params.max_content_size_bytes.unit`, `endpoints.outputs.text.max_length.value`, `endpoints.outputs.text.max_length.unit`, `endpoints.outputs.text.pricing.completion.unit`, `endpoints.outputs.text.pricing.completion.cost_usd`, `endpoints.outputs.text.pricing.completion.utc_start`, `endpoints.outputs.text.pricing.completion.utc_end`, `endpoints.outputs.text.pricing.internal_reasoning.unit`, `endpoints.outputs.text.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.text.pricing.internal_reasoning.utc_start`, `endpoints.outputs.text.pricing.internal_reasoning.utc_end`, `endpoints.outputs.text.capacity.completion.unit`, `endpoints.outputs.text.capacity.completion.per`, `endpoints.outputs.text.capacity.completion.value`, `endpoints.outputs.text.capacity.internal_reasoning.unit`, `endpoints.outputs.text.capacity.internal_reasoning.per`, `endpoints.outputs.text.capacity.internal_reasoning.value`, `endpoints.outputs.text.capacity.concurrency.unit`, `endpoints.outputs.text.capacity.concurrency.value`, `endpoints.outputs.text.streaming`, `endpoints.outputs.image.pricing.completion.unit`, `endpoints.outputs.image.pricing.completion.cost_usd`, `endpoints.outputs.image.pricing.completion.utc_start`, `endpoints.outputs.image.pricing.completion.utc_end`, `endpoints.outputs.image.pricing.internal_reasoning.unit`, `endpoints.outputs.image.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.image.pricing.internal_reasoning.utc_start`, `endpoints.outputs.image.pricing.internal_reasoning.utc_end`, `endpoints.outputs.image.capacity.completion.unit`, `endpoints.outputs.image.capacity.completion.per`, `endpoints.outputs.image.capacity.completion.value`, `endpoints.outputs.image.capacity.internal_reasoning.unit`, `endpoints.outputs.image.capacity.internal_reasoning.per`, `endpoints.outputs.image.capacity.internal_reasoning.value`, `endpoints.outputs.image.capacity.concurrency.unit`, `endpoints.outputs.image.capacity.concurrency.value`, `endpoints.outputs.image.streaming`, `endpoints.outputs.video.pricing.completion.unit`, `endpoints.outputs.video.pricing.completion.cost_usd`, `endpoints.outputs.video.pricing.completion.utc_start`, `endpoints.outputs.video.pricing.completion.utc_end`, `endpoints.outputs.video.pricing.internal_reasoning.unit`, `endpoints.outputs.video.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.video.pricing.internal_reasoning.utc_start`, `endpoints.outputs.video.pricing.internal_reasoning.utc_end`, `endpoints.outputs.video.capacity.completion.unit`, `endpoints.outputs.video.capacity.completion.per`, `endpoints.outputs.video.capacity.completion.value`, `endpoints.outputs.video.capacity.internal_reasoning.unit`, `endpoints.outputs.video.capacity.internal_reasoning.per`, `endpoints.outputs.video.capacity.internal_reasoning.value`, `endpoints.outputs.video.capacity.concurrency.unit`, `endpoints.outputs.video.capacity.concurrency.value`, `endpoints.outputs.video.streaming`, `endpoints.outputs.speech.pricing.completion.unit`, `endpoints.outputs.speech.pricing.completion.cost_usd`, `endpoints.outputs.speech.pricing.completion.utc_start`, `endpoints.outputs.speech.pricing.completion.utc_end`, `endpoints.outputs.speech.pricing.internal_reasoning.unit`, `endpoints.outputs.speech.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.speech.pricing.internal_reasoning.utc_start`, `endpoints.outputs.speech.pricing.internal_reasoning.utc_end`, `endpoints.outputs.speech.capacity.completion.unit`, `endpoints.outputs.speech.capacity.completion.per`, `endpoints.outputs.speech.capacity.completion.value`, `endpoints.outputs.speech.capacity.internal_reasoning.unit`, `endpoints.outputs.speech.capacity.internal_reasoning.per`, `endpoints.outputs.speech.capacity.internal_reasoning.value`, `endpoints.outputs.speech.capacity.concurrency.unit`, `endpoints.outputs.speech.capacity.concurrency.value`, `endpoints.outputs.speech.streaming`, `endpoints.outputs.transcription.pricing.completion.unit`, `endpoints.outputs.transcription.pricing.completion.cost_usd`, `endpoints.outputs.transcription.pricing.completion.utc_start`, `endpoints.outputs.transcription.pricing.completion.utc_end`, `endpoints.outputs.transcription.pricing.internal_reasoning.unit`, `endpoints.outputs.transcription.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.transcription.pricing.internal_reasoning.utc_start`, `endpoints.outputs.transcription.pricing.internal_reasoning.utc_end`, `endpoints.outputs.transcription.capacity.completion.unit`, `endpoints.outputs.transcription.capacity.completion.per`, `endpoints.outputs.transcription.capacity.completion.value`, `endpoints.outputs.transcription.capacity.internal_reasoning.unit`, `endpoints.outputs.transcription.capacity.internal_reasoning.per`, `endpoints.outputs.transcription.capacity.internal_reasoning.value`, `endpoints.outputs.transcription.capacity.concurrency.unit`, `endpoints.outputs.transcription.capacity.concurrency.value`, `endpoints.outputs.transcription.streaming`, `endpoints.outputs.embeddings.pricing.completion.unit`, `endpoints.outputs.embeddings.pricing.completion.cost_usd`, `endpoints.outputs.embeddings.pricing.completion.utc_start`, `endpoints.outputs.embeddings.pricing.completion.utc_end`, `endpoints.outputs.embeddings.pricing.internal_reasoning.unit`, `endpoints.outputs.embeddings.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_start`, `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_end`, `endpoints.outputs.embeddings.capacity.completion.unit`, `endpoints.outputs.embeddings.capacity.completion.per`, `endpoints.outputs.embeddings.capacity.completion.value`, `endpoints.outputs.embeddings.capacity.internal_reasoning.unit`, `endpoints.outputs.embeddings.capacity.internal_reasoning.per`, `endpoints.outputs.embeddings.capacity.internal_reasoning.value`, `endpoints.outputs.embeddings.capacity.concurrency.unit`, `endpoints.outputs.embeddings.capacity.concurrency.value`, `endpoints.outputs.rerank.pricing.completion.unit`, `endpoints.outputs.rerank.pricing.completion.cost_usd`, `endpoints.outputs.rerank.pricing.completion.utc_start`, `endpoints.outputs.rerank.pricing.completion.utc_end`, `endpoints.outputs.rerank.pricing.internal_reasoning.unit`, `endpoints.outputs.rerank.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.rerank.pricing.internal_reasoning.utc_start`, `endpoints.outputs.rerank.pricing.internal_reasoning.utc_end`, `endpoints.outputs.rerank.capacity.completion.unit`, `endpoints.outputs.rerank.capacity.completion.per`, `endpoints.outputs.rerank.capacity.completion.value`, `endpoints.outputs.rerank.capacity.internal_reasoning.unit`, `endpoints.outputs.rerank.capacity.internal_reasoning.per`, `endpoints.outputs.rerank.capacity.internal_reasoning.value`, `endpoints.outputs.rerank.capacity.concurrency.unit`, `endpoints.outputs.rerank.capacity.concurrency.value`, `endpoints.outputs.decisions.pricing.completion.unit`, `endpoints.outputs.decisions.pricing.completion.cost_usd`, `endpoints.outputs.decisions.pricing.completion.utc_start`, `endpoints.outputs.decisions.pricing.completion.utc_end`, `endpoints.outputs.decisions.pricing.internal_reasoning.unit`, `endpoints.outputs.decisions.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.decisions.pricing.internal_reasoning.utc_start`, `endpoints.outputs.decisions.pricing.internal_reasoning.utc_end`, `endpoints.outputs.decisions.capacity.completion.unit`, `endpoints.outputs.decisions.capacity.completion.per`, `endpoints.outputs.decisions.capacity.completion.value`, `endpoints.outputs.decisions.capacity.internal_reasoning.unit`, `endpoints.outputs.decisions.capacity.internal_reasoning.per`, `endpoints.outputs.decisions.capacity.internal_reasoning.value`, `endpoints.outputs.decisions.capacity.concurrency.unit`, `endpoints.outputs.decisions.capacity.concurrency.value`, `endpoints.outputs.audio.pricing.completion.unit`, `endpoints.outputs.audio.pricing.completion.cost_usd`, `endpoints.outputs.audio.pricing.completion.utc_start`, `endpoints.outputs.audio.pricing.completion.utc_end`, `endpoints.outputs.audio.pricing.internal_reasoning.unit`, `endpoints.outputs.audio.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.audio.pricing.internal_reasoning.utc_start`, `endpoints.outputs.audio.pricing.internal_reasoning.utc_end`, `endpoints.outputs.audio.capacity.completion.unit`, `endpoints.outputs.audio.capacity.completion.per`, `endpoints.outputs.audio.capacity.completion.value`, `endpoints.outputs.audio.capacity.internal_reasoning.unit`, `endpoints.outputs.audio.capacity.internal_reasoning.per`, `endpoints.outputs.audio.capacity.internal_reasoning.value`, `endpoints.outputs.audio.capacity.concurrency.unit`, `endpoints.outputs.audio.capacity.concurrency.value`, `endpoints.outputs.audio.streaming`, `endpoints.provider.slug`, `endpoints.provider.tag`, `endpoints.provider.name`, `endpoints.data_policy.training`, `endpoints.data_policy.retains_prompts`, `endpoints.data_policy.retention_days`.<br/>
        /// Example: -created,endpoints.inputs.text.pricing.prompt.cost_usd
        /// </param>
        /// <param name="id">
        /// Filter where the value at `id` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="canonicalSlug">
        /// Filter where the value at `canonical_slug` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="author">
        /// Filter where the value at `author` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="name">
        /// Filter where the value at `name` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="variant">
        /// Filter where the value at `variant` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `free`, `extended`, `standard`, `thinking`, `batch`.
        /// </param>
        /// <param name="kind">
        /// Filter where the value at `kind` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `model`, `router`, `alias`.
        /// </param>
        /// <param name="aliasTargetSlug">
        /// Filter where the value at `alias_target.slug` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="aliasTargetName">
        /// Filter where the value at `alias_target.name` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="created">
        /// Filter where the value at `created` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="description">
        /// Filter where the value at `description` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="contextLength">
        /// Filter where the value at `context_length` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="huggingFaceId">
        /// Filter where the value at `hugging_face_id` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="inputs">
        /// Filter where any element at `inputs` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `text`, `image`, `file`, `audio`, `video`.
        /// </param>
        /// <param name="outputs">
        /// Filter where any element at `outputs` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `text`, `image`, `embeddings`, `audio`, `video`, `rerank`, `decisions`, `speech`, `transcription`.
        /// </param>
        /// <param name="endpointsSchemaVersion">
        /// Filter where the value at `endpoints.schema_version` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsId">
        /// Filter where the value at `endpoints.id` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsHuggingFaceId">
        /// Filter where the value at `endpoints.hugging_face_id` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsName">
        /// Filter where the value at `endpoints.name` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsCreated">
        /// Filter where the value at `endpoints.created` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsQuantization">
        /// Filter where the value at `endpoints.quantization` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `int4`, `int8`, `fp4`, `mxfp4`, `nvfp4`, `fp6`, `fp8`, `mxfp8`, `fp16`, `bf16`, `fp32`.
        /// </param>
        /// <param name="endpointsTokenizer">
        /// Filter where the value at `endpoints.tokenizer` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDescription">
        /// Filter where the value at `endpoints.description` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPricingType">
        /// Filter where any value at `endpoints.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`, `web_search`.
        /// </param>
        /// <param name="endpointsPricingRequestUnit">
        /// Filter where the value at `endpoints.pricing.request.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsPricingRequestCostUsd">
        /// Filter where the value at `endpoints.pricing.request.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPricingRequestOverridesCostUsd">
        /// Filter where any value at `endpoints.pricing.request.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPricingWebSearchUnit">
        /// Filter where the value at `endpoints.pricing.web_search.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `search`.
        /// </param>
        /// <param name="endpointsPricingWebSearchCostUsd">
        /// Filter where the value at `endpoints.pricing.web_search.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPricingWebSearchOverridesCostUsd">
        /// Filter where any value at `endpoints.pricing.web_search.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsCapacityType">
        /// Filter where any value at `endpoints.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`, `web_search`, `concurrency`.
        /// </param>
        /// <param name="endpointsCapacityRequestUnit">
        /// Filter where the value at `endpoints.capacity.request.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsCapacityRequestPer">
        /// Filter where the value at `endpoints.capacity.request.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsCapacityRequestValue">
        /// Filter where the value at `endpoints.capacity.request.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsCapacityWebSearchUnit">
        /// Filter where the value at `endpoints.capacity.web_search.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `search`.
        /// </param>
        /// <param name="endpointsCapacityWebSearchPer">
        /// Filter where the value at `endpoints.capacity.web_search.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsCapacityWebSearchValue">
        /// Filter where the value at `endpoints.capacity.web_search.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPassthroughParameters">
        /// Filter on the entries of `endpoints.passthrough_parameters`: `endpoints.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.passthrough_parameters.&lt;key&gt;.type`, `endpoints.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsDeprecationDate">
        /// Filter where the value at `endpoints.deprecation_date` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsIsReady">
        /// Filter where the value at `endpoints.is_ready` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsIsFree">
        /// Filter where the value at `endpoints.is_free` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsServiceTier">
        /// Filter where the value at `endpoints.service_tier` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `flex`, `priority`, `ultrafast`, `fast`.
        /// </param>
        /// <param name="endpointsDiscountToUser">
        /// Filter where the value at `endpoints.discount_to_user` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOpenrouterSlug">
        /// Filter where the value at `endpoints.openrouter.slug` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDatacentersCountryCode">
        /// Filter where any value at `endpoints.datacenters.country_code` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDatacentersRegion">
        /// Filter where any value at `endpoints.datacenters.region` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDeploymentRegion">
        /// Filter where the value at `endpoints.deployment_region` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsType">
        /// Filter where any value at `endpoints.inputs.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `text`, `image`, `video`, `audio`, `file`.
        /// </param>
        /// <param name="endpointsInputsTextPricingType">
        /// Filter where any value at `endpoints.inputs.text.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.text.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.text.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.text.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.text.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.text.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.text.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.text.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.text.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.text.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.text.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityType">
        /// Filter where any value at `endpoints.inputs.text.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.text.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.text.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.text.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.text.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.text.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.text.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.text.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.text.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.text.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.text.passthrough_parameters`: `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsTextParamsMaxPromptLengthValue">
        /// Filter where the value at `endpoints.inputs.text.params.max_prompt_length.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextParamsMaxPromptLengthUnit">
        /// Filter where the value at `endpoints.inputs.text.params.max_prompt_length.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextParamsMaxLengthValue">
        /// Filter where the value at `endpoints.inputs.text.params.max_length.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextParamsMaxLengthUnit">
        /// Filter where the value at `endpoints.inputs.text.params.max_length.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsImagePricingType">
        /// Filter where any value at `endpoints.inputs.image.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.image.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.image.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.image.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.image.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.image.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.image.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.image.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.image.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.image.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.image.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityType">
        /// Filter where any value at `endpoints.inputs.image.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.image.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.image.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.image.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.image.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.image.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.image.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.image.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.image.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.image.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.image.passthrough_parameters`: `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsImageParamsSourcesType">
        /// Filter where the value at `endpoints.inputs.image.params.sources.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsImageParamsSourcesValues">
        /// Filter where any element at `endpoints.inputs.image.params.sources.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `url`, `base64`.
        /// </param>
        /// <param name="endpointsInputsImageParamsFormatsType">
        /// Filter where the value at `endpoints.inputs.image.params.formats.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsImageParamsFormatsValues">
        /// Filter where any element at `endpoints.inputs.image.params.formats.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `image/png`, `image/jpeg`, `image/webp`, `image/gif`.
        /// </param>
        /// <param name="endpointsInputsImageParamsDetailLevelsType">
        /// Filter where the value at `endpoints.inputs.image.params.detail_levels.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsImageParamsDetailLevelsValues">
        /// Filter where any element at `endpoints.inputs.image.params.detail_levels.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `auto`, `low`, `high`, `original`.
        /// </param>
        /// <param name="endpointsInputsImageParamsReferencesType">
        /// Filter where the value at `endpoints.inputs.image.params.references.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `integer`.
        /// </param>
        /// <param name="endpointsInputsImageParamsReferencesMin">
        /// Filter where the value at `endpoints.inputs.image.params.references.min` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageParamsReferencesMax">
        /// Filter where the value at `endpoints.inputs.image.params.references.max` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageParamsReferencesUnit">
        /// Filter where the value at `endpoints.inputs.image.params.references.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsImageParamsRoleType">
        /// Filter where the value at `endpoints.inputs.image.params.role.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsImageParamsRoleValues">
        /// Filter where any element at `endpoints.inputs.image.params.role.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `reference`, `first_frame`, `last_frame`.
        /// </param>
        /// <param name="endpointsInputsImageParamsMaxContentSizeBytesValue">
        /// Filter where the value at `endpoints.inputs.image.params.max_content_size_bytes.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageParamsMaxContentSizeBytesUnit">
        /// Filter where the value at `endpoints.inputs.image.params.max_content_size_bytes.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingType">
        /// Filter where any value at `endpoints.inputs.video.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.video.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.video.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.video.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.video.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.video.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.video.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.video.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.video.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.video.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.video.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityType">
        /// Filter where any value at `endpoints.inputs.video.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.video.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.video.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.video.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.video.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.video.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.video.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.video.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.video.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.video.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.video.passthrough_parameters`: `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsVideoParamsSourcesType">
        /// Filter where the value at `endpoints.inputs.video.params.sources.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsSourcesValues">
        /// Filter where any element at `endpoints.inputs.video.params.sources.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `url`, `base64`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsFormatsType">
        /// Filter where the value at `endpoints.inputs.video.params.formats.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsFormatsValues">
        /// Filter where any element at `endpoints.inputs.video.params.formats.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `video/mp4`, `video/webm`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsMaxDurationSecondsValue">
        /// Filter where the value at `endpoints.inputs.video.params.max_duration_seconds.value` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoParamsMaxDurationSecondsUnit">
        /// Filter where the value at `endpoints.inputs.video.params.max_duration_seconds.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsMaxContentSizeBytesValue">
        /// Filter where the value at `endpoints.inputs.video.params.max_content_size_bytes.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoParamsMaxContentSizeBytesUnit">
        /// Filter where the value at `endpoints.inputs.video.params.max_content_size_bytes.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingType">
        /// Filter where any value at `endpoints.inputs.audio.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.audio.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.audio.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.audio.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.audio.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.audio.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.audio.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.audio.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityType">
        /// Filter where any value at `endpoints.inputs.audio.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.audio.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.audio.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.audio.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.audio.passthrough_parameters`: `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsAudioParamsSourcesType">
        /// Filter where the value at `endpoints.inputs.audio.params.sources.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsSourcesValues">
        /// Filter where any element at `endpoints.inputs.audio.params.sources.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `url`, `base64`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsFormatsType">
        /// Filter where the value at `endpoints.inputs.audio.params.formats.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsFormatsValues">
        /// Filter where any element at `endpoints.inputs.audio.params.formats.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `audio/wav`, `audio/mpeg`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsMaxDurationSecondsValue">
        /// Filter where the value at `endpoints.inputs.audio.params.max_duration_seconds.value` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioParamsMaxDurationSecondsUnit">
        /// Filter where the value at `endpoints.inputs.audio.params.max_duration_seconds.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsMaxContentSizeBytesValue">
        /// Filter where the value at `endpoints.inputs.audio.params.max_content_size_bytes.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioParamsMaxContentSizeBytesUnit">
        /// Filter where the value at `endpoints.inputs.audio.params.max_content_size_bytes.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsFilePricingType">
        /// Filter where any value at `endpoints.inputs.file.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.file.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.file.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.file.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.file.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.file.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.file.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.file.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.file.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.file.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.file.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityType">
        /// Filter where any value at `endpoints.inputs.file.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.file.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.file.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.file.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.file.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.file.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.file.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.file.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.file.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.file.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.file.passthrough_parameters`: `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsFileParamsSourcesType">
        /// Filter where the value at `endpoints.inputs.file.params.sources.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsFileParamsSourcesValues">
        /// Filter where any element at `endpoints.inputs.file.params.sources.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `url`, `base64`.
        /// </param>
        /// <param name="endpointsInputsFileParamsFormatsType">
        /// Filter where the value at `endpoints.inputs.file.params.formats.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsFileParamsFormatsValues">
        /// Filter where any element at `endpoints.inputs.file.params.formats.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `application/pdf`, `text/plain`, `text/markdown`, `text/html`, `text/csv`, `application/json`.
        /// </param>
        /// <param name="endpointsInputsFileParamsReferencesType">
        /// Filter where the value at `endpoints.inputs.file.params.references.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `integer`.
        /// </param>
        /// <param name="endpointsInputsFileParamsReferencesMin">
        /// Filter where the value at `endpoints.inputs.file.params.references.min` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileParamsReferencesMax">
        /// Filter where the value at `endpoints.inputs.file.params.references.max` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileParamsReferencesUnit">
        /// Filter where the value at `endpoints.inputs.file.params.references.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsFileParamsMaxContentSizeBytesValue">
        /// Filter where the value at `endpoints.inputs.file.params.max_content_size_bytes.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileParamsMaxContentSizeBytesUnit">
        /// Filter where the value at `endpoints.inputs.file.params.max_content_size_bytes.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsOutputsType">
        /// Filter where any value at `endpoints.outputs.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `text`, `image`, `video`, `speech`, `transcription`, `embeddings`, `rerank`, `decisions`, `audio`.
        /// </param>
        /// <param name="endpointsOutputsTextMaxLengthValue">
        /// Filter where the value at `endpoints.outputs.text.max_length.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextMaxLengthUnit">
        /// Filter where the value at `endpoints.outputs.text.max_length.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsOutputsTextPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.text.passthrough_parameters`: `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsTextPricingType">
        /// Filter where any value at `endpoints.outputs.text.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.text.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.text.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.text.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.text.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.text.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.text.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.text.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.text.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.text.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.text.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.text.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.text.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityType">
        /// Filter where any value at `endpoints.outputs.text.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.text.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.text.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.text.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.text.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.text.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.text.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.text.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.text.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextStreaming">
        /// Filter where the value at `endpoints.outputs.text.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextParams">
        /// Filter on the entries of `endpoints.outputs.text.params`: `endpoints.outputs.text.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.text.params.&lt;key&gt;.type`, `endpoints.outputs.text.params.&lt;key&gt;.range.min`, `endpoints.outputs.text.params.&lt;key&gt;.range.max`, `endpoints.outputs.text.params.&lt;key&gt;.range.default`, `endpoints.outputs.text.params.&lt;key&gt;.range.values`, `endpoints.outputs.text.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsImagePassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.image.passthrough_parameters`: `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsImagePricingType">
        /// Filter where any value at `endpoints.outputs.image.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.image.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.image.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.image.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.image.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.image.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.image.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.image.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.image.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.image.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.image.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.image.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.image.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityType">
        /// Filter where any value at `endpoints.outputs.image.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.image.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.image.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.image.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.image.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.image.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.image.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.image.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.image.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImageStreaming">
        /// Filter where the value at `endpoints.outputs.image.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImageParams">
        /// Filter on the entries of `endpoints.outputs.image.params`: `endpoints.outputs.image.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.image.params.&lt;key&gt;.type`, `endpoints.outputs.image.params.&lt;key&gt;.range.min`, `endpoints.outputs.image.params.&lt;key&gt;.range.max`, `endpoints.outputs.image.params.&lt;key&gt;.range.default`, `endpoints.outputs.image.params.&lt;key&gt;.range.values`, `endpoints.outputs.image.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsVideoPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.video.passthrough_parameters`: `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingType">
        /// Filter where any value at `endpoints.outputs.video.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.video.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.video.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.video.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.video.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.video.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.video.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.video.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.video.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.video.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.video.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.video.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.video.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityType">
        /// Filter where any value at `endpoints.outputs.video.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.video.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.video.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.video.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.video.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.video.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.video.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.video.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.video.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoStreaming">
        /// Filter where the value at `endpoints.outputs.video.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoParams">
        /// Filter on the entries of `endpoints.outputs.video.params`: `endpoints.outputs.video.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.video.params.&lt;key&gt;.type`, `endpoints.outputs.video.params.&lt;key&gt;.range.min`, `endpoints.outputs.video.params.&lt;key&gt;.range.max`, `endpoints.outputs.video.params.&lt;key&gt;.range.default`, `endpoints.outputs.video.params.&lt;key&gt;.range.values`, `endpoints.outputs.video.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsSpeechPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.speech.passthrough_parameters`: `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingType">
        /// Filter where any value at `endpoints.outputs.speech.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.speech.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.speech.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.speech.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.speech.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.speech.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.speech.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.speech.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.speech.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.speech.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.speech.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.speech.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.speech.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityType">
        /// Filter where any value at `endpoints.outputs.speech.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.speech.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.speech.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.speech.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.speech.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.speech.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.speech.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.speech.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.speech.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechStreaming">
        /// Filter where the value at `endpoints.outputs.speech.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechParams">
        /// Filter on the entries of `endpoints.outputs.speech.params`: `endpoints.outputs.speech.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.speech.params.&lt;key&gt;.type`, `endpoints.outputs.speech.params.&lt;key&gt;.range.min`, `endpoints.outputs.speech.params.&lt;key&gt;.range.max`, `endpoints.outputs.speech.params.&lt;key&gt;.range.default`, `endpoints.outputs.speech.params.&lt;key&gt;.range.values`, `endpoints.outputs.speech.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.transcription.passthrough_parameters`: `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingType">
        /// Filter where any value at `endpoints.outputs.transcription.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.transcription.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.transcription.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.transcription.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.transcription.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityType">
        /// Filter where any value at `endpoints.outputs.transcription.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionStreaming">
        /// Filter where the value at `endpoints.outputs.transcription.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionParams">
        /// Filter on the entries of `endpoints.outputs.transcription.params`: `endpoints.outputs.transcription.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.transcription.params.&lt;key&gt;.type`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.min`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.max`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.default`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.values`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.embeddings.passthrough_parameters`: `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingType">
        /// Filter where any value at `endpoints.outputs.embeddings.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.embeddings.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.embeddings.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.embeddings.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityType">
        /// Filter where any value at `endpoints.outputs.embeddings.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsParams">
        /// Filter on the entries of `endpoints.outputs.embeddings.params`: `endpoints.outputs.embeddings.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.embeddings.params.&lt;key&gt;.type`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.min`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.max`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.default`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.values`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsRerankPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.rerank.passthrough_parameters`: `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingType">
        /// Filter where any value at `endpoints.outputs.rerank.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.rerank.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.rerank.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.rerank.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.rerank.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityType">
        /// Filter where any value at `endpoints.outputs.rerank.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankParams">
        /// Filter on the entries of `endpoints.outputs.rerank.params`: `endpoints.outputs.rerank.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.rerank.params.&lt;key&gt;.type`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.min`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.max`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.default`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.values`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.decisions.passthrough_parameters`: `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingType">
        /// Filter where any value at `endpoints.outputs.decisions.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.decisions.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.decisions.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.decisions.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.decisions.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityType">
        /// Filter where any value at `endpoints.outputs.decisions.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsParams">
        /// Filter on the entries of `endpoints.outputs.decisions.params`: `endpoints.outputs.decisions.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.decisions.params.&lt;key&gt;.type`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.min`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.max`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.default`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.values`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsAudioPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.audio.passthrough_parameters`: `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingType">
        /// Filter where any value at `endpoints.outputs.audio.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.audio.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.audio.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.audio.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.audio.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.audio.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.audio.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.audio.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.audio.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.audio.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.audio.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.audio.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.audio.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityType">
        /// Filter where any value at `endpoints.outputs.audio.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.audio.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.audio.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.audio.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.audio.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.audio.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.audio.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.audio.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.audio.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioStreaming">
        /// Filter where the value at `endpoints.outputs.audio.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioParams">
        /// Filter on the entries of `endpoints.outputs.audio.params`: `endpoints.outputs.audio.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.audio.params.&lt;key&gt;.type`, `endpoints.outputs.audio.params.&lt;key&gt;.range.min`, `endpoints.outputs.audio.params.&lt;key&gt;.range.max`, `endpoints.outputs.audio.params.&lt;key&gt;.range.default`, `endpoints.outputs.audio.params.&lt;key&gt;.range.values`, `endpoints.outputs.audio.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsProviderSlug">
        /// Filter where the value at `endpoints.provider.slug` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsProviderTag">
        /// Filter where the value at `endpoints.provider.tag` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsProviderName">
        /// Filter where the value at `endpoints.provider.name` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDataPolicyTraining">
        /// Filter where the value at `endpoints.data_policy.training` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDataPolicyRetainsPrompts">
        /// Filter where the value at `endpoints.data_policy.retains_prompts` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDataPolicyRetentionDays">
        /// Filter where the value at `endpoints.data_policy.retention_days` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ModelsV2ListResponse> ListV2Async(
            int? offset = default,
            int? limit = default,
            string? cursor = default,
            global::OpenRouter.ListModelsV2Region? region = default,
            string? sort = default,
            string? id = default,
            string? canonicalSlug = default,
            string? author = default,
            string? name = default,
            string? variant = default,
            string? kind = default,
            string? aliasTargetSlug = default,
            string? aliasTargetName = default,
            string? created = default,
            string? description = default,
            string? contextLength = default,
            string? huggingFaceId = default,
            string? inputs = default,
            string? outputs = default,
            string? endpointsSchemaVersion = default,
            string? endpointsId = default,
            string? endpointsHuggingFaceId = default,
            string? endpointsName = default,
            string? endpointsCreated = default,
            string? endpointsQuantization = default,
            string? endpointsTokenizer = default,
            string? endpointsDescription = default,
            string? endpointsPricingType = default,
            string? endpointsPricingRequestUnit = default,
            string? endpointsPricingRequestCostUsd = default,
            string? endpointsPricingRequestOverridesCostUsd = default,
            string? endpointsPricingWebSearchUnit = default,
            string? endpointsPricingWebSearchCostUsd = default,
            string? endpointsPricingWebSearchOverridesCostUsd = default,
            string? endpointsCapacityType = default,
            string? endpointsCapacityRequestUnit = default,
            string? endpointsCapacityRequestPer = default,
            string? endpointsCapacityRequestValue = default,
            string? endpointsCapacityWebSearchUnit = default,
            string? endpointsCapacityWebSearchPer = default,
            string? endpointsCapacityWebSearchValue = default,
            string? endpointsCapacityConcurrencyUnit = default,
            string? endpointsCapacityConcurrencyValue = default,
            string? endpointsPassthroughParameters = default,
            string? endpointsDeprecationDate = default,
            string? endpointsIsReady = default,
            string? endpointsIsFree = default,
            string? endpointsServiceTier = default,
            string? endpointsDiscountToUser = default,
            string? endpointsOpenrouterSlug = default,
            string? endpointsDatacentersCountryCode = default,
            string? endpointsDatacentersRegion = default,
            string? endpointsDeploymentRegion = default,
            string? endpointsInputsType = default,
            string? endpointsInputsTextPricingType = default,
            string? endpointsInputsTextPricingPromptUnit = default,
            string? endpointsInputsTextPricingPromptCostUsd = default,
            string? endpointsInputsTextPricingPromptOverridesCostUsd = default,
            string? endpointsInputsTextPricingPromptUtcStart = default,
            string? endpointsInputsTextPricingPromptUtcEnd = default,
            string? endpointsInputsTextPricingPromptUtcDays = default,
            string? endpointsInputsTextPricingCachedPromptUnit = default,
            string? endpointsInputsTextPricingCachedPromptCostUsd = default,
            string? endpointsInputsTextPricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsTextPricingCachedPromptTtlSeconds = default,
            string? endpointsInputsTextPricingCachedPromptImplicit = default,
            string? endpointsInputsTextPricingCachedPromptUtcStart = default,
            string? endpointsInputsTextPricingCachedPromptUtcEnd = default,
            string? endpointsInputsTextPricingCachedPromptUtcDays = default,
            string? endpointsInputsTextPricingCacheWriteUnit = default,
            string? endpointsInputsTextPricingCacheWriteCostUsd = default,
            string? endpointsInputsTextPricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsTextPricingCacheWriteTtlSeconds = default,
            string? endpointsInputsTextPricingCacheWriteImplicit = default,
            string? endpointsInputsTextPricingCacheWriteUtcStart = default,
            string? endpointsInputsTextPricingCacheWriteUtcEnd = default,
            string? endpointsInputsTextPricingCacheWriteUtcDays = default,
            string? endpointsInputsTextCapacityType = default,
            string? endpointsInputsTextCapacityPromptUnit = default,
            string? endpointsInputsTextCapacityPromptPer = default,
            string? endpointsInputsTextCapacityPromptValue = default,
            string? endpointsInputsTextCapacityCachedPromptUnit = default,
            string? endpointsInputsTextCapacityCachedPromptPer = default,
            string? endpointsInputsTextCapacityCachedPromptValue = default,
            string? endpointsInputsTextCapacityCacheWriteUnit = default,
            string? endpointsInputsTextCapacityCacheWritePer = default,
            string? endpointsInputsTextCapacityCacheWriteValue = default,
            string? endpointsInputsTextPassthroughParameters = default,
            string? endpointsInputsTextParamsMaxPromptLengthValue = default,
            string? endpointsInputsTextParamsMaxPromptLengthUnit = default,
            string? endpointsInputsTextParamsMaxLengthValue = default,
            string? endpointsInputsTextParamsMaxLengthUnit = default,
            string? endpointsInputsImagePricingType = default,
            string? endpointsInputsImagePricingPromptUnit = default,
            string? endpointsInputsImagePricingPromptCostUsd = default,
            string? endpointsInputsImagePricingPromptOverridesCostUsd = default,
            string? endpointsInputsImagePricingPromptUtcStart = default,
            string? endpointsInputsImagePricingPromptUtcEnd = default,
            string? endpointsInputsImagePricingPromptUtcDays = default,
            string? endpointsInputsImagePricingCachedPromptUnit = default,
            string? endpointsInputsImagePricingCachedPromptCostUsd = default,
            string? endpointsInputsImagePricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsImagePricingCachedPromptTtlSeconds = default,
            string? endpointsInputsImagePricingCachedPromptImplicit = default,
            string? endpointsInputsImagePricingCachedPromptUtcStart = default,
            string? endpointsInputsImagePricingCachedPromptUtcEnd = default,
            string? endpointsInputsImagePricingCachedPromptUtcDays = default,
            string? endpointsInputsImagePricingCacheWriteUnit = default,
            string? endpointsInputsImagePricingCacheWriteCostUsd = default,
            string? endpointsInputsImagePricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsImagePricingCacheWriteTtlSeconds = default,
            string? endpointsInputsImagePricingCacheWriteImplicit = default,
            string? endpointsInputsImagePricingCacheWriteUtcStart = default,
            string? endpointsInputsImagePricingCacheWriteUtcEnd = default,
            string? endpointsInputsImagePricingCacheWriteUtcDays = default,
            string? endpointsInputsImageCapacityType = default,
            string? endpointsInputsImageCapacityPromptUnit = default,
            string? endpointsInputsImageCapacityPromptPer = default,
            string? endpointsInputsImageCapacityPromptValue = default,
            string? endpointsInputsImageCapacityCachedPromptUnit = default,
            string? endpointsInputsImageCapacityCachedPromptPer = default,
            string? endpointsInputsImageCapacityCachedPromptValue = default,
            string? endpointsInputsImageCapacityCacheWriteUnit = default,
            string? endpointsInputsImageCapacityCacheWritePer = default,
            string? endpointsInputsImageCapacityCacheWriteValue = default,
            string? endpointsInputsImagePassthroughParameters = default,
            string? endpointsInputsImageParamsSourcesType = default,
            string? endpointsInputsImageParamsSourcesValues = default,
            string? endpointsInputsImageParamsFormatsType = default,
            string? endpointsInputsImageParamsFormatsValues = default,
            string? endpointsInputsImageParamsDetailLevelsType = default,
            string? endpointsInputsImageParamsDetailLevelsValues = default,
            string? endpointsInputsImageParamsReferencesType = default,
            string? endpointsInputsImageParamsReferencesMin = default,
            string? endpointsInputsImageParamsReferencesMax = default,
            string? endpointsInputsImageParamsReferencesUnit = default,
            string? endpointsInputsImageParamsRoleType = default,
            string? endpointsInputsImageParamsRoleValues = default,
            string? endpointsInputsImageParamsMaxContentSizeBytesValue = default,
            string? endpointsInputsImageParamsMaxContentSizeBytesUnit = default,
            string? endpointsInputsVideoPricingType = default,
            string? endpointsInputsVideoPricingPromptUnit = default,
            string? endpointsInputsVideoPricingPromptCostUsd = default,
            string? endpointsInputsVideoPricingPromptOverridesCostUsd = default,
            string? endpointsInputsVideoPricingPromptUtcStart = default,
            string? endpointsInputsVideoPricingPromptUtcEnd = default,
            string? endpointsInputsVideoPricingPromptUtcDays = default,
            string? endpointsInputsVideoPricingCachedPromptUnit = default,
            string? endpointsInputsVideoPricingCachedPromptCostUsd = default,
            string? endpointsInputsVideoPricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsVideoPricingCachedPromptTtlSeconds = default,
            string? endpointsInputsVideoPricingCachedPromptImplicit = default,
            string? endpointsInputsVideoPricingCachedPromptUtcStart = default,
            string? endpointsInputsVideoPricingCachedPromptUtcEnd = default,
            string? endpointsInputsVideoPricingCachedPromptUtcDays = default,
            string? endpointsInputsVideoPricingCacheWriteUnit = default,
            string? endpointsInputsVideoPricingCacheWriteCostUsd = default,
            string? endpointsInputsVideoPricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsVideoPricingCacheWriteTtlSeconds = default,
            string? endpointsInputsVideoPricingCacheWriteImplicit = default,
            string? endpointsInputsVideoPricingCacheWriteUtcStart = default,
            string? endpointsInputsVideoPricingCacheWriteUtcEnd = default,
            string? endpointsInputsVideoPricingCacheWriteUtcDays = default,
            string? endpointsInputsVideoCapacityType = default,
            string? endpointsInputsVideoCapacityPromptUnit = default,
            string? endpointsInputsVideoCapacityPromptPer = default,
            string? endpointsInputsVideoCapacityPromptValue = default,
            string? endpointsInputsVideoCapacityCachedPromptUnit = default,
            string? endpointsInputsVideoCapacityCachedPromptPer = default,
            string? endpointsInputsVideoCapacityCachedPromptValue = default,
            string? endpointsInputsVideoCapacityCacheWriteUnit = default,
            string? endpointsInputsVideoCapacityCacheWritePer = default,
            string? endpointsInputsVideoCapacityCacheWriteValue = default,
            string? endpointsInputsVideoPassthroughParameters = default,
            string? endpointsInputsVideoParamsSourcesType = default,
            string? endpointsInputsVideoParamsSourcesValues = default,
            string? endpointsInputsVideoParamsFormatsType = default,
            string? endpointsInputsVideoParamsFormatsValues = default,
            string? endpointsInputsVideoParamsMaxDurationSecondsValue = default,
            string? endpointsInputsVideoParamsMaxDurationSecondsUnit = default,
            string? endpointsInputsVideoParamsMaxContentSizeBytesValue = default,
            string? endpointsInputsVideoParamsMaxContentSizeBytesUnit = default,
            string? endpointsInputsAudioPricingType = default,
            string? endpointsInputsAudioPricingPromptUnit = default,
            string? endpointsInputsAudioPricingPromptCostUsd = default,
            string? endpointsInputsAudioPricingPromptOverridesCostUsd = default,
            string? endpointsInputsAudioPricingPromptUtcStart = default,
            string? endpointsInputsAudioPricingPromptUtcEnd = default,
            string? endpointsInputsAudioPricingPromptUtcDays = default,
            string? endpointsInputsAudioPricingCachedPromptUnit = default,
            string? endpointsInputsAudioPricingCachedPromptCostUsd = default,
            string? endpointsInputsAudioPricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsAudioPricingCachedPromptTtlSeconds = default,
            string? endpointsInputsAudioPricingCachedPromptImplicit = default,
            string? endpointsInputsAudioPricingCachedPromptUtcStart = default,
            string? endpointsInputsAudioPricingCachedPromptUtcEnd = default,
            string? endpointsInputsAudioPricingCachedPromptUtcDays = default,
            string? endpointsInputsAudioPricingCacheWriteUnit = default,
            string? endpointsInputsAudioPricingCacheWriteCostUsd = default,
            string? endpointsInputsAudioPricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsAudioPricingCacheWriteTtlSeconds = default,
            string? endpointsInputsAudioPricingCacheWriteImplicit = default,
            string? endpointsInputsAudioPricingCacheWriteUtcStart = default,
            string? endpointsInputsAudioPricingCacheWriteUtcEnd = default,
            string? endpointsInputsAudioPricingCacheWriteUtcDays = default,
            string? endpointsInputsAudioCapacityType = default,
            string? endpointsInputsAudioCapacityPromptUnit = default,
            string? endpointsInputsAudioCapacityPromptPer = default,
            string? endpointsInputsAudioCapacityPromptValue = default,
            string? endpointsInputsAudioCapacityCachedPromptUnit = default,
            string? endpointsInputsAudioCapacityCachedPromptPer = default,
            string? endpointsInputsAudioCapacityCachedPromptValue = default,
            string? endpointsInputsAudioCapacityCacheWriteUnit = default,
            string? endpointsInputsAudioCapacityCacheWritePer = default,
            string? endpointsInputsAudioCapacityCacheWriteValue = default,
            string? endpointsInputsAudioPassthroughParameters = default,
            string? endpointsInputsAudioParamsSourcesType = default,
            string? endpointsInputsAudioParamsSourcesValues = default,
            string? endpointsInputsAudioParamsFormatsType = default,
            string? endpointsInputsAudioParamsFormatsValues = default,
            string? endpointsInputsAudioParamsMaxDurationSecondsValue = default,
            string? endpointsInputsAudioParamsMaxDurationSecondsUnit = default,
            string? endpointsInputsAudioParamsMaxContentSizeBytesValue = default,
            string? endpointsInputsAudioParamsMaxContentSizeBytesUnit = default,
            string? endpointsInputsFilePricingType = default,
            string? endpointsInputsFilePricingPromptUnit = default,
            string? endpointsInputsFilePricingPromptCostUsd = default,
            string? endpointsInputsFilePricingPromptOverridesCostUsd = default,
            string? endpointsInputsFilePricingPromptUtcStart = default,
            string? endpointsInputsFilePricingPromptUtcEnd = default,
            string? endpointsInputsFilePricingPromptUtcDays = default,
            string? endpointsInputsFilePricingCachedPromptUnit = default,
            string? endpointsInputsFilePricingCachedPromptCostUsd = default,
            string? endpointsInputsFilePricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsFilePricingCachedPromptTtlSeconds = default,
            string? endpointsInputsFilePricingCachedPromptImplicit = default,
            string? endpointsInputsFilePricingCachedPromptUtcStart = default,
            string? endpointsInputsFilePricingCachedPromptUtcEnd = default,
            string? endpointsInputsFilePricingCachedPromptUtcDays = default,
            string? endpointsInputsFilePricingCacheWriteUnit = default,
            string? endpointsInputsFilePricingCacheWriteCostUsd = default,
            string? endpointsInputsFilePricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsFilePricingCacheWriteTtlSeconds = default,
            string? endpointsInputsFilePricingCacheWriteImplicit = default,
            string? endpointsInputsFilePricingCacheWriteUtcStart = default,
            string? endpointsInputsFilePricingCacheWriteUtcEnd = default,
            string? endpointsInputsFilePricingCacheWriteUtcDays = default,
            string? endpointsInputsFileCapacityType = default,
            string? endpointsInputsFileCapacityPromptUnit = default,
            string? endpointsInputsFileCapacityPromptPer = default,
            string? endpointsInputsFileCapacityPromptValue = default,
            string? endpointsInputsFileCapacityCachedPromptUnit = default,
            string? endpointsInputsFileCapacityCachedPromptPer = default,
            string? endpointsInputsFileCapacityCachedPromptValue = default,
            string? endpointsInputsFileCapacityCacheWriteUnit = default,
            string? endpointsInputsFileCapacityCacheWritePer = default,
            string? endpointsInputsFileCapacityCacheWriteValue = default,
            string? endpointsInputsFilePassthroughParameters = default,
            string? endpointsInputsFileParamsSourcesType = default,
            string? endpointsInputsFileParamsSourcesValues = default,
            string? endpointsInputsFileParamsFormatsType = default,
            string? endpointsInputsFileParamsFormatsValues = default,
            string? endpointsInputsFileParamsReferencesType = default,
            string? endpointsInputsFileParamsReferencesMin = default,
            string? endpointsInputsFileParamsReferencesMax = default,
            string? endpointsInputsFileParamsReferencesUnit = default,
            string? endpointsInputsFileParamsMaxContentSizeBytesValue = default,
            string? endpointsInputsFileParamsMaxContentSizeBytesUnit = default,
            string? endpointsOutputsType = default,
            string? endpointsOutputsTextMaxLengthValue = default,
            string? endpointsOutputsTextMaxLengthUnit = default,
            string? endpointsOutputsTextPassthroughParameters = default,
            string? endpointsOutputsTextPricingType = default,
            string? endpointsOutputsTextPricingCompletionUnit = default,
            string? endpointsOutputsTextPricingCompletionCostUsd = default,
            string? endpointsOutputsTextPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsTextPricingCompletionUtcStart = default,
            string? endpointsOutputsTextPricingCompletionUtcEnd = default,
            string? endpointsOutputsTextPricingCompletionUtcDays = default,
            string? endpointsOutputsTextPricingInternalReasoningUnit = default,
            string? endpointsOutputsTextPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsTextPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsTextPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsTextPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsTextPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsTextCapacityType = default,
            string? endpointsOutputsTextCapacityCompletionUnit = default,
            string? endpointsOutputsTextCapacityCompletionPer = default,
            string? endpointsOutputsTextCapacityCompletionValue = default,
            string? endpointsOutputsTextCapacityInternalReasoningUnit = default,
            string? endpointsOutputsTextCapacityInternalReasoningPer = default,
            string? endpointsOutputsTextCapacityInternalReasoningValue = default,
            string? endpointsOutputsTextCapacityConcurrencyUnit = default,
            string? endpointsOutputsTextCapacityConcurrencyValue = default,
            string? endpointsOutputsTextStreaming = default,
            string? endpointsOutputsTextParams = default,
            string? endpointsOutputsImagePassthroughParameters = default,
            string? endpointsOutputsImagePricingType = default,
            string? endpointsOutputsImagePricingCompletionUnit = default,
            string? endpointsOutputsImagePricingCompletionCostUsd = default,
            string? endpointsOutputsImagePricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsImagePricingCompletionUtcStart = default,
            string? endpointsOutputsImagePricingCompletionUtcEnd = default,
            string? endpointsOutputsImagePricingCompletionUtcDays = default,
            string? endpointsOutputsImagePricingInternalReasoningUnit = default,
            string? endpointsOutputsImagePricingInternalReasoningCostUsd = default,
            string? endpointsOutputsImagePricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsImagePricingInternalReasoningUtcStart = default,
            string? endpointsOutputsImagePricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsImagePricingInternalReasoningUtcDays = default,
            string? endpointsOutputsImageCapacityType = default,
            string? endpointsOutputsImageCapacityCompletionUnit = default,
            string? endpointsOutputsImageCapacityCompletionPer = default,
            string? endpointsOutputsImageCapacityCompletionValue = default,
            string? endpointsOutputsImageCapacityInternalReasoningUnit = default,
            string? endpointsOutputsImageCapacityInternalReasoningPer = default,
            string? endpointsOutputsImageCapacityInternalReasoningValue = default,
            string? endpointsOutputsImageCapacityConcurrencyUnit = default,
            string? endpointsOutputsImageCapacityConcurrencyValue = default,
            string? endpointsOutputsImageStreaming = default,
            string? endpointsOutputsImageParams = default,
            string? endpointsOutputsVideoPassthroughParameters = default,
            string? endpointsOutputsVideoPricingType = default,
            string? endpointsOutputsVideoPricingCompletionUnit = default,
            string? endpointsOutputsVideoPricingCompletionCostUsd = default,
            string? endpointsOutputsVideoPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsVideoPricingCompletionUtcStart = default,
            string? endpointsOutputsVideoPricingCompletionUtcEnd = default,
            string? endpointsOutputsVideoPricingCompletionUtcDays = default,
            string? endpointsOutputsVideoPricingInternalReasoningUnit = default,
            string? endpointsOutputsVideoPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsVideoPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsVideoPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsVideoPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsVideoPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsVideoCapacityType = default,
            string? endpointsOutputsVideoCapacityCompletionUnit = default,
            string? endpointsOutputsVideoCapacityCompletionPer = default,
            string? endpointsOutputsVideoCapacityCompletionValue = default,
            string? endpointsOutputsVideoCapacityInternalReasoningUnit = default,
            string? endpointsOutputsVideoCapacityInternalReasoningPer = default,
            string? endpointsOutputsVideoCapacityInternalReasoningValue = default,
            string? endpointsOutputsVideoCapacityConcurrencyUnit = default,
            string? endpointsOutputsVideoCapacityConcurrencyValue = default,
            string? endpointsOutputsVideoStreaming = default,
            string? endpointsOutputsVideoParams = default,
            string? endpointsOutputsSpeechPassthroughParameters = default,
            string? endpointsOutputsSpeechPricingType = default,
            string? endpointsOutputsSpeechPricingCompletionUnit = default,
            string? endpointsOutputsSpeechPricingCompletionCostUsd = default,
            string? endpointsOutputsSpeechPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsSpeechPricingCompletionUtcStart = default,
            string? endpointsOutputsSpeechPricingCompletionUtcEnd = default,
            string? endpointsOutputsSpeechPricingCompletionUtcDays = default,
            string? endpointsOutputsSpeechPricingInternalReasoningUnit = default,
            string? endpointsOutputsSpeechPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsSpeechPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsSpeechPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsSpeechPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsSpeechPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsSpeechCapacityType = default,
            string? endpointsOutputsSpeechCapacityCompletionUnit = default,
            string? endpointsOutputsSpeechCapacityCompletionPer = default,
            string? endpointsOutputsSpeechCapacityCompletionValue = default,
            string? endpointsOutputsSpeechCapacityInternalReasoningUnit = default,
            string? endpointsOutputsSpeechCapacityInternalReasoningPer = default,
            string? endpointsOutputsSpeechCapacityInternalReasoningValue = default,
            string? endpointsOutputsSpeechCapacityConcurrencyUnit = default,
            string? endpointsOutputsSpeechCapacityConcurrencyValue = default,
            string? endpointsOutputsSpeechStreaming = default,
            string? endpointsOutputsSpeechParams = default,
            string? endpointsOutputsTranscriptionPassthroughParameters = default,
            string? endpointsOutputsTranscriptionPricingType = default,
            string? endpointsOutputsTranscriptionPricingCompletionUnit = default,
            string? endpointsOutputsTranscriptionPricingCompletionCostUsd = default,
            string? endpointsOutputsTranscriptionPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsTranscriptionPricingCompletionUtcStart = default,
            string? endpointsOutputsTranscriptionPricingCompletionUtcEnd = default,
            string? endpointsOutputsTranscriptionPricingCompletionUtcDays = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUnit = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsTranscriptionCapacityType = default,
            string? endpointsOutputsTranscriptionCapacityCompletionUnit = default,
            string? endpointsOutputsTranscriptionCapacityCompletionPer = default,
            string? endpointsOutputsTranscriptionCapacityCompletionValue = default,
            string? endpointsOutputsTranscriptionCapacityInternalReasoningUnit = default,
            string? endpointsOutputsTranscriptionCapacityInternalReasoningPer = default,
            string? endpointsOutputsTranscriptionCapacityInternalReasoningValue = default,
            string? endpointsOutputsTranscriptionCapacityConcurrencyUnit = default,
            string? endpointsOutputsTranscriptionCapacityConcurrencyValue = default,
            string? endpointsOutputsTranscriptionStreaming = default,
            string? endpointsOutputsTranscriptionParams = default,
            string? endpointsOutputsEmbeddingsPassthroughParameters = default,
            string? endpointsOutputsEmbeddingsPricingType = default,
            string? endpointsOutputsEmbeddingsPricingCompletionUnit = default,
            string? endpointsOutputsEmbeddingsPricingCompletionCostUsd = default,
            string? endpointsOutputsEmbeddingsPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsEmbeddingsPricingCompletionUtcStart = default,
            string? endpointsOutputsEmbeddingsPricingCompletionUtcEnd = default,
            string? endpointsOutputsEmbeddingsPricingCompletionUtcDays = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUnit = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsEmbeddingsCapacityType = default,
            string? endpointsOutputsEmbeddingsCapacityCompletionUnit = default,
            string? endpointsOutputsEmbeddingsCapacityCompletionPer = default,
            string? endpointsOutputsEmbeddingsCapacityCompletionValue = default,
            string? endpointsOutputsEmbeddingsCapacityInternalReasoningUnit = default,
            string? endpointsOutputsEmbeddingsCapacityInternalReasoningPer = default,
            string? endpointsOutputsEmbeddingsCapacityInternalReasoningValue = default,
            string? endpointsOutputsEmbeddingsCapacityConcurrencyUnit = default,
            string? endpointsOutputsEmbeddingsCapacityConcurrencyValue = default,
            string? endpointsOutputsEmbeddingsParams = default,
            string? endpointsOutputsRerankPassthroughParameters = default,
            string? endpointsOutputsRerankPricingType = default,
            string? endpointsOutputsRerankPricingCompletionUnit = default,
            string? endpointsOutputsRerankPricingCompletionCostUsd = default,
            string? endpointsOutputsRerankPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsRerankPricingCompletionUtcStart = default,
            string? endpointsOutputsRerankPricingCompletionUtcEnd = default,
            string? endpointsOutputsRerankPricingCompletionUtcDays = default,
            string? endpointsOutputsRerankPricingInternalReasoningUnit = default,
            string? endpointsOutputsRerankPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsRerankPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsRerankPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsRerankPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsRerankPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsRerankCapacityType = default,
            string? endpointsOutputsRerankCapacityCompletionUnit = default,
            string? endpointsOutputsRerankCapacityCompletionPer = default,
            string? endpointsOutputsRerankCapacityCompletionValue = default,
            string? endpointsOutputsRerankCapacityInternalReasoningUnit = default,
            string? endpointsOutputsRerankCapacityInternalReasoningPer = default,
            string? endpointsOutputsRerankCapacityInternalReasoningValue = default,
            string? endpointsOutputsRerankCapacityConcurrencyUnit = default,
            string? endpointsOutputsRerankCapacityConcurrencyValue = default,
            string? endpointsOutputsRerankParams = default,
            string? endpointsOutputsDecisionsPassthroughParameters = default,
            string? endpointsOutputsDecisionsPricingType = default,
            string? endpointsOutputsDecisionsPricingCompletionUnit = default,
            string? endpointsOutputsDecisionsPricingCompletionCostUsd = default,
            string? endpointsOutputsDecisionsPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsDecisionsPricingCompletionUtcStart = default,
            string? endpointsOutputsDecisionsPricingCompletionUtcEnd = default,
            string? endpointsOutputsDecisionsPricingCompletionUtcDays = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningUnit = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsDecisionsCapacityType = default,
            string? endpointsOutputsDecisionsCapacityCompletionUnit = default,
            string? endpointsOutputsDecisionsCapacityCompletionPer = default,
            string? endpointsOutputsDecisionsCapacityCompletionValue = default,
            string? endpointsOutputsDecisionsCapacityInternalReasoningUnit = default,
            string? endpointsOutputsDecisionsCapacityInternalReasoningPer = default,
            string? endpointsOutputsDecisionsCapacityInternalReasoningValue = default,
            string? endpointsOutputsDecisionsCapacityConcurrencyUnit = default,
            string? endpointsOutputsDecisionsCapacityConcurrencyValue = default,
            string? endpointsOutputsDecisionsParams = default,
            string? endpointsOutputsAudioPassthroughParameters = default,
            string? endpointsOutputsAudioPricingType = default,
            string? endpointsOutputsAudioPricingCompletionUnit = default,
            string? endpointsOutputsAudioPricingCompletionCostUsd = default,
            string? endpointsOutputsAudioPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsAudioPricingCompletionUtcStart = default,
            string? endpointsOutputsAudioPricingCompletionUtcEnd = default,
            string? endpointsOutputsAudioPricingCompletionUtcDays = default,
            string? endpointsOutputsAudioPricingInternalReasoningUnit = default,
            string? endpointsOutputsAudioPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsAudioPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsAudioPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsAudioPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsAudioPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsAudioCapacityType = default,
            string? endpointsOutputsAudioCapacityCompletionUnit = default,
            string? endpointsOutputsAudioCapacityCompletionPer = default,
            string? endpointsOutputsAudioCapacityCompletionValue = default,
            string? endpointsOutputsAudioCapacityInternalReasoningUnit = default,
            string? endpointsOutputsAudioCapacityInternalReasoningPer = default,
            string? endpointsOutputsAudioCapacityInternalReasoningValue = default,
            string? endpointsOutputsAudioCapacityConcurrencyUnit = default,
            string? endpointsOutputsAudioCapacityConcurrencyValue = default,
            string? endpointsOutputsAudioStreaming = default,
            string? endpointsOutputsAudioParams = default,
            string? endpointsProviderSlug = default,
            string? endpointsProviderTag = default,
            string? endpointsProviderName = default,
            string? endpointsDataPolicyTraining = default,
            string? endpointsDataPolicyRetainsPrompts = default,
            string? endpointsDataPolicyRetentionDays = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List models with V2 endpoint documents<br/>
        /// Returns every publicly served model together with each of its endpoints in the Models API V2 document format. The V2 document is the schema providers publish to OpenRouter, so each endpoint is reported in the shape it was declared, with pricing attached to the modality it applies to (`inputs`/`outputs`, each with its `params`). Operator-only fields such as capacity and `discount_to_user` are not part of the public document.<br/>
        /// Without credentials the response is the public catalog. With an API key it is the catalog that key can route to, the same one `GET /api/v1/models/user` serves: models and endpoints the account was granted private access to are included, and endpoints the account or key guardrails, provider preferences, BYOK and privacy settings exclude are omitted, along with routers and aliases left with nothing to route to. A key that does not resolve is rejected with 401.<br/>
        /// Every field of the response document is a filter, named by its dotted JSON path: `&lt;path&gt;=&lt;value&gt;` tests equality and `&lt;path&gt;.&lt;operator&gt;=&lt;value&gt;` applies `gt`, `gte`, `lt`, `lte`, `between`, `in`, `exists`, `contains`, `starts_with` or `ends_with` as the field type allows; `&lt;path&gt;.not.&lt;operator&gt;=&lt;value&gt;` (or `&lt;path&gt;.not=&lt;value&gt;` for not-equal) keeps the records where no value matches. Suffixes, arithmetic operators, parentheses and the list comma are read before percent-decoding, so an encoded character is always literal: a map key spelled like an operator or `not` is reached by encoding one of its characters (`params.n%6Ft.exists=true`), a `/` or `+` inside a literal is `%2F` or `%2B`, and arithmetic is spelled with the bare characters (`created/10`, `context_length+1`). `in` takes a comma-separated list and `between` the inclusive lower and upper bound (a literal comma is `%2C`); strings compare trimmed and lower-cased on both sides, so `author=Anthropic` and `name.contains=claude` match. A filter under `endpoints.` keeps only the endpoints that satisfy every such filter and omits models left with none. A path through a repeated object is existential (`endpoints.pricing.type=request` matches an endpoint with some request-priced entry); the members of a typed collection are addressed by their type (`endpoints.inputs.text.params.max_length.value.gte=1000000`, `endpoints.inputs.text.pricing.prompt.cost_usd.lte=0.000001`), and a dynamic key is written in the path (`endpoints.outputs.text.params.tools.type=boolean`, `endpoints.outputs.text.params.temperature.range.max.gte=2`). Both sides of an operator are operands of one grammar: a literal, a path, or an arithmetic expression over numeric paths and numbers, so a filter relates any two of them (`endpoints.inputs.text.pricing.prompt.cost_usd.gte=endpoints.outputs.text.pricing.completion.cost_usd*100`, `10000.lte=endpoints.inputs.text.params.max_length.value`, `endpoints.id=id`). Arithmetic requires numeric paths, each operator applies to the type its operands share, and text that names no field path is a literal (`id=openai/gpt-4`), so the field names at the root of the document are reserved words. A parameter that is not a field path is rejected with a 400 whose `error.metadata` names the `code`, `parameter` and `reason`.<br/>
        /// `sort` takes comma-separated paths or expressions, `-` prefixed for descending; a key must be a scalar path or expression (`created`, `endpoints.inputs.text.pricing.prompt.cost_usd`); a model sorts by the best value in the sort direction across its endpoints and across the time windows of a price, missing values sort last and `id` ascending breaks ties, so the order is total even without `sort`. Pagination is opt-in: pass `limit` and follow `links.next`, which carries an opaque `cursor` bound to the filters and sort; `offset` remains supported. `total_count` is the number of models matching the filters.
        /// </summary>
        /// <param name="offset">
        /// Number of records to skip (0 when omitted); kept for compatibility, prefer `cursor`. Supplying limit, cursor or offset paginates the list; when all are omitted, the full list is returned.<br/>
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to return (500 when omitted, max 1000). Supplying limit, cursor or offset paginates the list; when all are omitted, the full list is returned.<br/>
        /// Example: 500
        /// </param>
        /// <param name="cursor">
        /// Opaque keyset cursor from the previous page's `links.next`. Bound to the filters and sort it was issued for; a cursor sent with different filters or sort is rejected.<br/>
        /// Example: eyJ2IjoxLCJxIjoiYjVmMWE4MDEiLCJrIjpbIm9wZW5haS9ncHQtNCJdfQ
        /// </param>
        /// <param name="region">
        /// Only return endpoints in the given data region ("eu" or "us"); models left without an endpoint are omitted.<br/>
        /// Example: eu
        /// </param>
        /// <param name="sort">
        /// Comma-separated sort keys, each a path below or an arithmetic expression over numeric paths; prefix with `-` for descending. A key under `endpoints.` ranks each model by its best endpoint value in the sort direction. Missing values sort last and `id` ascending breaks ties. Keys: `id`, `canonical_slug`, `author`, `name`, `variant`, `kind`, `alias_target.slug`, `alias_target.name`, `created`, `description`, `context_length`, `hugging_face_id`, `endpoints.schema_version`, `endpoints.id`, `endpoints.hugging_face_id`, `endpoints.name`, `endpoints.created`, `endpoints.quantization`, `endpoints.tokenizer`, `endpoints.description`, `endpoints.pricing.request.unit`, `endpoints.pricing.request.cost_usd`, `endpoints.pricing.web_search.unit`, `endpoints.pricing.web_search.cost_usd`, `endpoints.capacity.request.unit`, `endpoints.capacity.request.per`, `endpoints.capacity.request.value`, `endpoints.capacity.web_search.unit`, `endpoints.capacity.web_search.per`, `endpoints.capacity.web_search.value`, `endpoints.capacity.concurrency.unit`, `endpoints.capacity.concurrency.value`, `endpoints.deprecation_date`, `endpoints.is_ready`, `endpoints.is_free`, `endpoints.service_tier`, `endpoints.discount_to_user`, `endpoints.openrouter.slug`, `endpoints.deployment_region`, `endpoints.inputs.text.pricing.prompt.unit`, `endpoints.inputs.text.pricing.prompt.cost_usd`, `endpoints.inputs.text.pricing.prompt.utc_start`, `endpoints.inputs.text.pricing.prompt.utc_end`, `endpoints.inputs.text.pricing.cached_prompt.unit`, `endpoints.inputs.text.pricing.cached_prompt.cost_usd`, `endpoints.inputs.text.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.text.pricing.cached_prompt.implicit`, `endpoints.inputs.text.pricing.cached_prompt.utc_start`, `endpoints.inputs.text.pricing.cached_prompt.utc_end`, `endpoints.inputs.text.pricing.cache_write.unit`, `endpoints.inputs.text.pricing.cache_write.cost_usd`, `endpoints.inputs.text.pricing.cache_write.ttl_seconds`, `endpoints.inputs.text.pricing.cache_write.implicit`, `endpoints.inputs.text.pricing.cache_write.utc_start`, `endpoints.inputs.text.pricing.cache_write.utc_end`, `endpoints.inputs.text.capacity.prompt.unit`, `endpoints.inputs.text.capacity.prompt.per`, `endpoints.inputs.text.capacity.prompt.value`, `endpoints.inputs.text.capacity.cached_prompt.unit`, `endpoints.inputs.text.capacity.cached_prompt.per`, `endpoints.inputs.text.capacity.cached_prompt.value`, `endpoints.inputs.text.capacity.cache_write.unit`, `endpoints.inputs.text.capacity.cache_write.per`, `endpoints.inputs.text.capacity.cache_write.value`, `endpoints.inputs.text.params.max_prompt_length.value`, `endpoints.inputs.text.params.max_prompt_length.unit`, `endpoints.inputs.text.params.max_length.value`, `endpoints.inputs.text.params.max_length.unit`, `endpoints.inputs.image.pricing.prompt.unit`, `endpoints.inputs.image.pricing.prompt.cost_usd`, `endpoints.inputs.image.pricing.prompt.utc_start`, `endpoints.inputs.image.pricing.prompt.utc_end`, `endpoints.inputs.image.pricing.cached_prompt.unit`, `endpoints.inputs.image.pricing.cached_prompt.cost_usd`, `endpoints.inputs.image.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.image.pricing.cached_prompt.implicit`, `endpoints.inputs.image.pricing.cached_prompt.utc_start`, `endpoints.inputs.image.pricing.cached_prompt.utc_end`, `endpoints.inputs.image.pricing.cache_write.unit`, `endpoints.inputs.image.pricing.cache_write.cost_usd`, `endpoints.inputs.image.pricing.cache_write.ttl_seconds`, `endpoints.inputs.image.pricing.cache_write.implicit`, `endpoints.inputs.image.pricing.cache_write.utc_start`, `endpoints.inputs.image.pricing.cache_write.utc_end`, `endpoints.inputs.image.capacity.prompt.unit`, `endpoints.inputs.image.capacity.prompt.per`, `endpoints.inputs.image.capacity.prompt.value`, `endpoints.inputs.image.capacity.cached_prompt.unit`, `endpoints.inputs.image.capacity.cached_prompt.per`, `endpoints.inputs.image.capacity.cached_prompt.value`, `endpoints.inputs.image.capacity.cache_write.unit`, `endpoints.inputs.image.capacity.cache_write.per`, `endpoints.inputs.image.capacity.cache_write.value`, `endpoints.inputs.image.params.sources.type`, `endpoints.inputs.image.params.formats.type`, `endpoints.inputs.image.params.detail_levels.type`, `endpoints.inputs.image.params.references.type`, `endpoints.inputs.image.params.references.min`, `endpoints.inputs.image.params.references.max`, `endpoints.inputs.image.params.references.unit`, `endpoints.inputs.image.params.role.type`, `endpoints.inputs.image.params.max_content_size_bytes.value`, `endpoints.inputs.image.params.max_content_size_bytes.unit`, `endpoints.inputs.video.pricing.prompt.unit`, `endpoints.inputs.video.pricing.prompt.cost_usd`, `endpoints.inputs.video.pricing.prompt.utc_start`, `endpoints.inputs.video.pricing.prompt.utc_end`, `endpoints.inputs.video.pricing.cached_prompt.unit`, `endpoints.inputs.video.pricing.cached_prompt.cost_usd`, `endpoints.inputs.video.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.video.pricing.cached_prompt.implicit`, `endpoints.inputs.video.pricing.cached_prompt.utc_start`, `endpoints.inputs.video.pricing.cached_prompt.utc_end`, `endpoints.inputs.video.pricing.cache_write.unit`, `endpoints.inputs.video.pricing.cache_write.cost_usd`, `endpoints.inputs.video.pricing.cache_write.ttl_seconds`, `endpoints.inputs.video.pricing.cache_write.implicit`, `endpoints.inputs.video.pricing.cache_write.utc_start`, `endpoints.inputs.video.pricing.cache_write.utc_end`, `endpoints.inputs.video.capacity.prompt.unit`, `endpoints.inputs.video.capacity.prompt.per`, `endpoints.inputs.video.capacity.prompt.value`, `endpoints.inputs.video.capacity.cached_prompt.unit`, `endpoints.inputs.video.capacity.cached_prompt.per`, `endpoints.inputs.video.capacity.cached_prompt.value`, `endpoints.inputs.video.capacity.cache_write.unit`, `endpoints.inputs.video.capacity.cache_write.per`, `endpoints.inputs.video.capacity.cache_write.value`, `endpoints.inputs.video.params.sources.type`, `endpoints.inputs.video.params.formats.type`, `endpoints.inputs.video.params.max_duration_seconds.value`, `endpoints.inputs.video.params.max_duration_seconds.unit`, `endpoints.inputs.video.params.max_content_size_bytes.value`, `endpoints.inputs.video.params.max_content_size_bytes.unit`, `endpoints.inputs.audio.pricing.prompt.unit`, `endpoints.inputs.audio.pricing.prompt.cost_usd`, `endpoints.inputs.audio.pricing.prompt.utc_start`, `endpoints.inputs.audio.pricing.prompt.utc_end`, `endpoints.inputs.audio.pricing.cached_prompt.unit`, `endpoints.inputs.audio.pricing.cached_prompt.cost_usd`, `endpoints.inputs.audio.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.audio.pricing.cached_prompt.implicit`, `endpoints.inputs.audio.pricing.cached_prompt.utc_start`, `endpoints.inputs.audio.pricing.cached_prompt.utc_end`, `endpoints.inputs.audio.pricing.cache_write.unit`, `endpoints.inputs.audio.pricing.cache_write.cost_usd`, `endpoints.inputs.audio.pricing.cache_write.ttl_seconds`, `endpoints.inputs.audio.pricing.cache_write.implicit`, `endpoints.inputs.audio.pricing.cache_write.utc_start`, `endpoints.inputs.audio.pricing.cache_write.utc_end`, `endpoints.inputs.audio.capacity.prompt.unit`, `endpoints.inputs.audio.capacity.prompt.per`, `endpoints.inputs.audio.capacity.prompt.value`, `endpoints.inputs.audio.capacity.cached_prompt.unit`, `endpoints.inputs.audio.capacity.cached_prompt.per`, `endpoints.inputs.audio.capacity.cached_prompt.value`, `endpoints.inputs.audio.capacity.cache_write.unit`, `endpoints.inputs.audio.capacity.cache_write.per`, `endpoints.inputs.audio.capacity.cache_write.value`, `endpoints.inputs.audio.params.sources.type`, `endpoints.inputs.audio.params.formats.type`, `endpoints.inputs.audio.params.max_duration_seconds.value`, `endpoints.inputs.audio.params.max_duration_seconds.unit`, `endpoints.inputs.audio.params.max_content_size_bytes.value`, `endpoints.inputs.audio.params.max_content_size_bytes.unit`, `endpoints.inputs.file.pricing.prompt.unit`, `endpoints.inputs.file.pricing.prompt.cost_usd`, `endpoints.inputs.file.pricing.prompt.utc_start`, `endpoints.inputs.file.pricing.prompt.utc_end`, `endpoints.inputs.file.pricing.cached_prompt.unit`, `endpoints.inputs.file.pricing.cached_prompt.cost_usd`, `endpoints.inputs.file.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.file.pricing.cached_prompt.implicit`, `endpoints.inputs.file.pricing.cached_prompt.utc_start`, `endpoints.inputs.file.pricing.cached_prompt.utc_end`, `endpoints.inputs.file.pricing.cache_write.unit`, `endpoints.inputs.file.pricing.cache_write.cost_usd`, `endpoints.inputs.file.pricing.cache_write.ttl_seconds`, `endpoints.inputs.file.pricing.cache_write.implicit`, `endpoints.inputs.file.pricing.cache_write.utc_start`, `endpoints.inputs.file.pricing.cache_write.utc_end`, `endpoints.inputs.file.capacity.prompt.unit`, `endpoints.inputs.file.capacity.prompt.per`, `endpoints.inputs.file.capacity.prompt.value`, `endpoints.inputs.file.capacity.cached_prompt.unit`, `endpoints.inputs.file.capacity.cached_prompt.per`, `endpoints.inputs.file.capacity.cached_prompt.value`, `endpoints.inputs.file.capacity.cache_write.unit`, `endpoints.inputs.file.capacity.cache_write.per`, `endpoints.inputs.file.capacity.cache_write.value`, `endpoints.inputs.file.params.sources.type`, `endpoints.inputs.file.params.formats.type`, `endpoints.inputs.file.params.references.type`, `endpoints.inputs.file.params.references.min`, `endpoints.inputs.file.params.references.max`, `endpoints.inputs.file.params.references.unit`, `endpoints.inputs.file.params.max_content_size_bytes.value`, `endpoints.inputs.file.params.max_content_size_bytes.unit`, `endpoints.outputs.text.max_length.value`, `endpoints.outputs.text.max_length.unit`, `endpoints.outputs.text.pricing.completion.unit`, `endpoints.outputs.text.pricing.completion.cost_usd`, `endpoints.outputs.text.pricing.completion.utc_start`, `endpoints.outputs.text.pricing.completion.utc_end`, `endpoints.outputs.text.pricing.internal_reasoning.unit`, `endpoints.outputs.text.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.text.pricing.internal_reasoning.utc_start`, `endpoints.outputs.text.pricing.internal_reasoning.utc_end`, `endpoints.outputs.text.capacity.completion.unit`, `endpoints.outputs.text.capacity.completion.per`, `endpoints.outputs.text.capacity.completion.value`, `endpoints.outputs.text.capacity.internal_reasoning.unit`, `endpoints.outputs.text.capacity.internal_reasoning.per`, `endpoints.outputs.text.capacity.internal_reasoning.value`, `endpoints.outputs.text.capacity.concurrency.unit`, `endpoints.outputs.text.capacity.concurrency.value`, `endpoints.outputs.text.streaming`, `endpoints.outputs.image.pricing.completion.unit`, `endpoints.outputs.image.pricing.completion.cost_usd`, `endpoints.outputs.image.pricing.completion.utc_start`, `endpoints.outputs.image.pricing.completion.utc_end`, `endpoints.outputs.image.pricing.internal_reasoning.unit`, `endpoints.outputs.image.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.image.pricing.internal_reasoning.utc_start`, `endpoints.outputs.image.pricing.internal_reasoning.utc_end`, `endpoints.outputs.image.capacity.completion.unit`, `endpoints.outputs.image.capacity.completion.per`, `endpoints.outputs.image.capacity.completion.value`, `endpoints.outputs.image.capacity.internal_reasoning.unit`, `endpoints.outputs.image.capacity.internal_reasoning.per`, `endpoints.outputs.image.capacity.internal_reasoning.value`, `endpoints.outputs.image.capacity.concurrency.unit`, `endpoints.outputs.image.capacity.concurrency.value`, `endpoints.outputs.image.streaming`, `endpoints.outputs.video.pricing.completion.unit`, `endpoints.outputs.video.pricing.completion.cost_usd`, `endpoints.outputs.video.pricing.completion.utc_start`, `endpoints.outputs.video.pricing.completion.utc_end`, `endpoints.outputs.video.pricing.internal_reasoning.unit`, `endpoints.outputs.video.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.video.pricing.internal_reasoning.utc_start`, `endpoints.outputs.video.pricing.internal_reasoning.utc_end`, `endpoints.outputs.video.capacity.completion.unit`, `endpoints.outputs.video.capacity.completion.per`, `endpoints.outputs.video.capacity.completion.value`, `endpoints.outputs.video.capacity.internal_reasoning.unit`, `endpoints.outputs.video.capacity.internal_reasoning.per`, `endpoints.outputs.video.capacity.internal_reasoning.value`, `endpoints.outputs.video.capacity.concurrency.unit`, `endpoints.outputs.video.capacity.concurrency.value`, `endpoints.outputs.video.streaming`, `endpoints.outputs.speech.pricing.completion.unit`, `endpoints.outputs.speech.pricing.completion.cost_usd`, `endpoints.outputs.speech.pricing.completion.utc_start`, `endpoints.outputs.speech.pricing.completion.utc_end`, `endpoints.outputs.speech.pricing.internal_reasoning.unit`, `endpoints.outputs.speech.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.speech.pricing.internal_reasoning.utc_start`, `endpoints.outputs.speech.pricing.internal_reasoning.utc_end`, `endpoints.outputs.speech.capacity.completion.unit`, `endpoints.outputs.speech.capacity.completion.per`, `endpoints.outputs.speech.capacity.completion.value`, `endpoints.outputs.speech.capacity.internal_reasoning.unit`, `endpoints.outputs.speech.capacity.internal_reasoning.per`, `endpoints.outputs.speech.capacity.internal_reasoning.value`, `endpoints.outputs.speech.capacity.concurrency.unit`, `endpoints.outputs.speech.capacity.concurrency.value`, `endpoints.outputs.speech.streaming`, `endpoints.outputs.transcription.pricing.completion.unit`, `endpoints.outputs.transcription.pricing.completion.cost_usd`, `endpoints.outputs.transcription.pricing.completion.utc_start`, `endpoints.outputs.transcription.pricing.completion.utc_end`, `endpoints.outputs.transcription.pricing.internal_reasoning.unit`, `endpoints.outputs.transcription.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.transcription.pricing.internal_reasoning.utc_start`, `endpoints.outputs.transcription.pricing.internal_reasoning.utc_end`, `endpoints.outputs.transcription.capacity.completion.unit`, `endpoints.outputs.transcription.capacity.completion.per`, `endpoints.outputs.transcription.capacity.completion.value`, `endpoints.outputs.transcription.capacity.internal_reasoning.unit`, `endpoints.outputs.transcription.capacity.internal_reasoning.per`, `endpoints.outputs.transcription.capacity.internal_reasoning.value`, `endpoints.outputs.transcription.capacity.concurrency.unit`, `endpoints.outputs.transcription.capacity.concurrency.value`, `endpoints.outputs.transcription.streaming`, `endpoints.outputs.embeddings.pricing.completion.unit`, `endpoints.outputs.embeddings.pricing.completion.cost_usd`, `endpoints.outputs.embeddings.pricing.completion.utc_start`, `endpoints.outputs.embeddings.pricing.completion.utc_end`, `endpoints.outputs.embeddings.pricing.internal_reasoning.unit`, `endpoints.outputs.embeddings.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_start`, `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_end`, `endpoints.outputs.embeddings.capacity.completion.unit`, `endpoints.outputs.embeddings.capacity.completion.per`, `endpoints.outputs.embeddings.capacity.completion.value`, `endpoints.outputs.embeddings.capacity.internal_reasoning.unit`, `endpoints.outputs.embeddings.capacity.internal_reasoning.per`, `endpoints.outputs.embeddings.capacity.internal_reasoning.value`, `endpoints.outputs.embeddings.capacity.concurrency.unit`, `endpoints.outputs.embeddings.capacity.concurrency.value`, `endpoints.outputs.rerank.pricing.completion.unit`, `endpoints.outputs.rerank.pricing.completion.cost_usd`, `endpoints.outputs.rerank.pricing.completion.utc_start`, `endpoints.outputs.rerank.pricing.completion.utc_end`, `endpoints.outputs.rerank.pricing.internal_reasoning.unit`, `endpoints.outputs.rerank.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.rerank.pricing.internal_reasoning.utc_start`, `endpoints.outputs.rerank.pricing.internal_reasoning.utc_end`, `endpoints.outputs.rerank.capacity.completion.unit`, `endpoints.outputs.rerank.capacity.completion.per`, `endpoints.outputs.rerank.capacity.completion.value`, `endpoints.outputs.rerank.capacity.internal_reasoning.unit`, `endpoints.outputs.rerank.capacity.internal_reasoning.per`, `endpoints.outputs.rerank.capacity.internal_reasoning.value`, `endpoints.outputs.rerank.capacity.concurrency.unit`, `endpoints.outputs.rerank.capacity.concurrency.value`, `endpoints.outputs.decisions.pricing.completion.unit`, `endpoints.outputs.decisions.pricing.completion.cost_usd`, `endpoints.outputs.decisions.pricing.completion.utc_start`, `endpoints.outputs.decisions.pricing.completion.utc_end`, `endpoints.outputs.decisions.pricing.internal_reasoning.unit`, `endpoints.outputs.decisions.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.decisions.pricing.internal_reasoning.utc_start`, `endpoints.outputs.decisions.pricing.internal_reasoning.utc_end`, `endpoints.outputs.decisions.capacity.completion.unit`, `endpoints.outputs.decisions.capacity.completion.per`, `endpoints.outputs.decisions.capacity.completion.value`, `endpoints.outputs.decisions.capacity.internal_reasoning.unit`, `endpoints.outputs.decisions.capacity.internal_reasoning.per`, `endpoints.outputs.decisions.capacity.internal_reasoning.value`, `endpoints.outputs.decisions.capacity.concurrency.unit`, `endpoints.outputs.decisions.capacity.concurrency.value`, `endpoints.outputs.audio.pricing.completion.unit`, `endpoints.outputs.audio.pricing.completion.cost_usd`, `endpoints.outputs.audio.pricing.completion.utc_start`, `endpoints.outputs.audio.pricing.completion.utc_end`, `endpoints.outputs.audio.pricing.internal_reasoning.unit`, `endpoints.outputs.audio.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.audio.pricing.internal_reasoning.utc_start`, `endpoints.outputs.audio.pricing.internal_reasoning.utc_end`, `endpoints.outputs.audio.capacity.completion.unit`, `endpoints.outputs.audio.capacity.completion.per`, `endpoints.outputs.audio.capacity.completion.value`, `endpoints.outputs.audio.capacity.internal_reasoning.unit`, `endpoints.outputs.audio.capacity.internal_reasoning.per`, `endpoints.outputs.audio.capacity.internal_reasoning.value`, `endpoints.outputs.audio.capacity.concurrency.unit`, `endpoints.outputs.audio.capacity.concurrency.value`, `endpoints.outputs.audio.streaming`, `endpoints.provider.slug`, `endpoints.provider.tag`, `endpoints.provider.name`, `endpoints.data_policy.training`, `endpoints.data_policy.retains_prompts`, `endpoints.data_policy.retention_days`.<br/>
        /// Example: -created,endpoints.inputs.text.pricing.prompt.cost_usd
        /// </param>
        /// <param name="id">
        /// Filter where the value at `id` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="canonicalSlug">
        /// Filter where the value at `canonical_slug` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="author">
        /// Filter where the value at `author` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="name">
        /// Filter where the value at `name` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="variant">
        /// Filter where the value at `variant` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `free`, `extended`, `standard`, `thinking`, `batch`.
        /// </param>
        /// <param name="kind">
        /// Filter where the value at `kind` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `model`, `router`, `alias`.
        /// </param>
        /// <param name="aliasTargetSlug">
        /// Filter where the value at `alias_target.slug` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="aliasTargetName">
        /// Filter where the value at `alias_target.name` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="created">
        /// Filter where the value at `created` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="description">
        /// Filter where the value at `description` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="contextLength">
        /// Filter where the value at `context_length` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="huggingFaceId">
        /// Filter where the value at `hugging_face_id` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="inputs">
        /// Filter where any element at `inputs` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `text`, `image`, `file`, `audio`, `video`.
        /// </param>
        /// <param name="outputs">
        /// Filter where any element at `outputs` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `text`, `image`, `embeddings`, `audio`, `video`, `rerank`, `decisions`, `speech`, `transcription`.
        /// </param>
        /// <param name="endpointsSchemaVersion">
        /// Filter where the value at `endpoints.schema_version` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsId">
        /// Filter where the value at `endpoints.id` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsHuggingFaceId">
        /// Filter where the value at `endpoints.hugging_face_id` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsName">
        /// Filter where the value at `endpoints.name` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsCreated">
        /// Filter where the value at `endpoints.created` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsQuantization">
        /// Filter where the value at `endpoints.quantization` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `int4`, `int8`, `fp4`, `mxfp4`, `nvfp4`, `fp6`, `fp8`, `mxfp8`, `fp16`, `bf16`, `fp32`.
        /// </param>
        /// <param name="endpointsTokenizer">
        /// Filter where the value at `endpoints.tokenizer` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDescription">
        /// Filter where the value at `endpoints.description` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPricingType">
        /// Filter where any value at `endpoints.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`, `web_search`.
        /// </param>
        /// <param name="endpointsPricingRequestUnit">
        /// Filter where the value at `endpoints.pricing.request.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsPricingRequestCostUsd">
        /// Filter where the value at `endpoints.pricing.request.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPricingRequestOverridesCostUsd">
        /// Filter where any value at `endpoints.pricing.request.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPricingWebSearchUnit">
        /// Filter where the value at `endpoints.pricing.web_search.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `search`.
        /// </param>
        /// <param name="endpointsPricingWebSearchCostUsd">
        /// Filter where the value at `endpoints.pricing.web_search.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPricingWebSearchOverridesCostUsd">
        /// Filter where any value at `endpoints.pricing.web_search.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsCapacityType">
        /// Filter where any value at `endpoints.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`, `web_search`, `concurrency`.
        /// </param>
        /// <param name="endpointsCapacityRequestUnit">
        /// Filter where the value at `endpoints.capacity.request.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsCapacityRequestPer">
        /// Filter where the value at `endpoints.capacity.request.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsCapacityRequestValue">
        /// Filter where the value at `endpoints.capacity.request.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsCapacityWebSearchUnit">
        /// Filter where the value at `endpoints.capacity.web_search.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `search`.
        /// </param>
        /// <param name="endpointsCapacityWebSearchPer">
        /// Filter where the value at `endpoints.capacity.web_search.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsCapacityWebSearchValue">
        /// Filter where the value at `endpoints.capacity.web_search.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPassthroughParameters">
        /// Filter on the entries of `endpoints.passthrough_parameters`: `endpoints.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.passthrough_parameters.&lt;key&gt;.type`, `endpoints.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsDeprecationDate">
        /// Filter where the value at `endpoints.deprecation_date` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsIsReady">
        /// Filter where the value at `endpoints.is_ready` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsIsFree">
        /// Filter where the value at `endpoints.is_free` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsServiceTier">
        /// Filter where the value at `endpoints.service_tier` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `flex`, `priority`, `ultrafast`, `fast`.
        /// </param>
        /// <param name="endpointsDiscountToUser">
        /// Filter where the value at `endpoints.discount_to_user` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOpenrouterSlug">
        /// Filter where the value at `endpoints.openrouter.slug` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDatacentersCountryCode">
        /// Filter where any value at `endpoints.datacenters.country_code` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDatacentersRegion">
        /// Filter where any value at `endpoints.datacenters.region` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDeploymentRegion">
        /// Filter where the value at `endpoints.deployment_region` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsType">
        /// Filter where any value at `endpoints.inputs.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `text`, `image`, `video`, `audio`, `file`.
        /// </param>
        /// <param name="endpointsInputsTextPricingType">
        /// Filter where any value at `endpoints.inputs.text.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.text.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.text.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.text.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.text.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.text.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.text.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.text.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.text.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.text.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.text.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityType">
        /// Filter where any value at `endpoints.inputs.text.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.text.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.text.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.text.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.text.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.text.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.text.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.text.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.text.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.text.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.text.passthrough_parameters`: `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsTextParamsMaxPromptLengthValue">
        /// Filter where the value at `endpoints.inputs.text.params.max_prompt_length.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextParamsMaxPromptLengthUnit">
        /// Filter where the value at `endpoints.inputs.text.params.max_prompt_length.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextParamsMaxLengthValue">
        /// Filter where the value at `endpoints.inputs.text.params.max_length.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextParamsMaxLengthUnit">
        /// Filter where the value at `endpoints.inputs.text.params.max_length.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsImagePricingType">
        /// Filter where any value at `endpoints.inputs.image.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.image.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.image.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.image.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.image.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.image.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.image.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.image.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.image.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.image.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.image.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityType">
        /// Filter where any value at `endpoints.inputs.image.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.image.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.image.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.image.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.image.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.image.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.image.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.image.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.image.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.image.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.image.passthrough_parameters`: `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsImageParamsSourcesType">
        /// Filter where the value at `endpoints.inputs.image.params.sources.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsImageParamsSourcesValues">
        /// Filter where any element at `endpoints.inputs.image.params.sources.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `url`, `base64`.
        /// </param>
        /// <param name="endpointsInputsImageParamsFormatsType">
        /// Filter where the value at `endpoints.inputs.image.params.formats.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsImageParamsFormatsValues">
        /// Filter where any element at `endpoints.inputs.image.params.formats.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `image/png`, `image/jpeg`, `image/webp`, `image/gif`.
        /// </param>
        /// <param name="endpointsInputsImageParamsDetailLevelsType">
        /// Filter where the value at `endpoints.inputs.image.params.detail_levels.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsImageParamsDetailLevelsValues">
        /// Filter where any element at `endpoints.inputs.image.params.detail_levels.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `auto`, `low`, `high`, `original`.
        /// </param>
        /// <param name="endpointsInputsImageParamsReferencesType">
        /// Filter where the value at `endpoints.inputs.image.params.references.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `integer`.
        /// </param>
        /// <param name="endpointsInputsImageParamsReferencesMin">
        /// Filter where the value at `endpoints.inputs.image.params.references.min` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageParamsReferencesMax">
        /// Filter where the value at `endpoints.inputs.image.params.references.max` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageParamsReferencesUnit">
        /// Filter where the value at `endpoints.inputs.image.params.references.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsImageParamsRoleType">
        /// Filter where the value at `endpoints.inputs.image.params.role.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsImageParamsRoleValues">
        /// Filter where any element at `endpoints.inputs.image.params.role.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `reference`, `first_frame`, `last_frame`.
        /// </param>
        /// <param name="endpointsInputsImageParamsMaxContentSizeBytesValue">
        /// Filter where the value at `endpoints.inputs.image.params.max_content_size_bytes.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageParamsMaxContentSizeBytesUnit">
        /// Filter where the value at `endpoints.inputs.image.params.max_content_size_bytes.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingType">
        /// Filter where any value at `endpoints.inputs.video.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.video.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.video.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.video.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.video.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.video.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.video.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.video.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.video.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.video.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.video.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityType">
        /// Filter where any value at `endpoints.inputs.video.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.video.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.video.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.video.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.video.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.video.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.video.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.video.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.video.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.video.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.video.passthrough_parameters`: `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsVideoParamsSourcesType">
        /// Filter where the value at `endpoints.inputs.video.params.sources.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsSourcesValues">
        /// Filter where any element at `endpoints.inputs.video.params.sources.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `url`, `base64`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsFormatsType">
        /// Filter where the value at `endpoints.inputs.video.params.formats.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsFormatsValues">
        /// Filter where any element at `endpoints.inputs.video.params.formats.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `video/mp4`, `video/webm`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsMaxDurationSecondsValue">
        /// Filter where the value at `endpoints.inputs.video.params.max_duration_seconds.value` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoParamsMaxDurationSecondsUnit">
        /// Filter where the value at `endpoints.inputs.video.params.max_duration_seconds.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsMaxContentSizeBytesValue">
        /// Filter where the value at `endpoints.inputs.video.params.max_content_size_bytes.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoParamsMaxContentSizeBytesUnit">
        /// Filter where the value at `endpoints.inputs.video.params.max_content_size_bytes.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingType">
        /// Filter where any value at `endpoints.inputs.audio.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.audio.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.audio.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.audio.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.audio.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.audio.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.audio.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.audio.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityType">
        /// Filter where any value at `endpoints.inputs.audio.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.audio.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.audio.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.audio.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.audio.passthrough_parameters`: `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsAudioParamsSourcesType">
        /// Filter where the value at `endpoints.inputs.audio.params.sources.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsSourcesValues">
        /// Filter where any element at `endpoints.inputs.audio.params.sources.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `url`, `base64`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsFormatsType">
        /// Filter where the value at `endpoints.inputs.audio.params.formats.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsFormatsValues">
        /// Filter where any element at `endpoints.inputs.audio.params.formats.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `audio/wav`, `audio/mpeg`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsMaxDurationSecondsValue">
        /// Filter where the value at `endpoints.inputs.audio.params.max_duration_seconds.value` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioParamsMaxDurationSecondsUnit">
        /// Filter where the value at `endpoints.inputs.audio.params.max_duration_seconds.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsMaxContentSizeBytesValue">
        /// Filter where the value at `endpoints.inputs.audio.params.max_content_size_bytes.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioParamsMaxContentSizeBytesUnit">
        /// Filter where the value at `endpoints.inputs.audio.params.max_content_size_bytes.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsFilePricingType">
        /// Filter where any value at `endpoints.inputs.file.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.file.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.file.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.file.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.file.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.file.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.file.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.file.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.file.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.file.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.file.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityType">
        /// Filter where any value at `endpoints.inputs.file.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.file.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.file.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.file.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.file.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.file.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.file.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.file.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.file.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.file.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.file.passthrough_parameters`: `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsFileParamsSourcesType">
        /// Filter where the value at `endpoints.inputs.file.params.sources.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsFileParamsSourcesValues">
        /// Filter where any element at `endpoints.inputs.file.params.sources.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `url`, `base64`.
        /// </param>
        /// <param name="endpointsInputsFileParamsFormatsType">
        /// Filter where the value at `endpoints.inputs.file.params.formats.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsFileParamsFormatsValues">
        /// Filter where any element at `endpoints.inputs.file.params.formats.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `application/pdf`, `text/plain`, `text/markdown`, `text/html`, `text/csv`, `application/json`.
        /// </param>
        /// <param name="endpointsInputsFileParamsReferencesType">
        /// Filter where the value at `endpoints.inputs.file.params.references.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `integer`.
        /// </param>
        /// <param name="endpointsInputsFileParamsReferencesMin">
        /// Filter where the value at `endpoints.inputs.file.params.references.min` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileParamsReferencesMax">
        /// Filter where the value at `endpoints.inputs.file.params.references.max` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileParamsReferencesUnit">
        /// Filter where the value at `endpoints.inputs.file.params.references.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsFileParamsMaxContentSizeBytesValue">
        /// Filter where the value at `endpoints.inputs.file.params.max_content_size_bytes.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileParamsMaxContentSizeBytesUnit">
        /// Filter where the value at `endpoints.inputs.file.params.max_content_size_bytes.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsOutputsType">
        /// Filter where any value at `endpoints.outputs.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `text`, `image`, `video`, `speech`, `transcription`, `embeddings`, `rerank`, `decisions`, `audio`.
        /// </param>
        /// <param name="endpointsOutputsTextMaxLengthValue">
        /// Filter where the value at `endpoints.outputs.text.max_length.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextMaxLengthUnit">
        /// Filter where the value at `endpoints.outputs.text.max_length.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsOutputsTextPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.text.passthrough_parameters`: `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsTextPricingType">
        /// Filter where any value at `endpoints.outputs.text.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.text.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.text.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.text.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.text.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.text.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.text.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.text.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.text.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.text.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.text.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.text.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.text.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityType">
        /// Filter where any value at `endpoints.outputs.text.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.text.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.text.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.text.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.text.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.text.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.text.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.text.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.text.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextStreaming">
        /// Filter where the value at `endpoints.outputs.text.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextParams">
        /// Filter on the entries of `endpoints.outputs.text.params`: `endpoints.outputs.text.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.text.params.&lt;key&gt;.type`, `endpoints.outputs.text.params.&lt;key&gt;.range.min`, `endpoints.outputs.text.params.&lt;key&gt;.range.max`, `endpoints.outputs.text.params.&lt;key&gt;.range.default`, `endpoints.outputs.text.params.&lt;key&gt;.range.values`, `endpoints.outputs.text.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsImagePassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.image.passthrough_parameters`: `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsImagePricingType">
        /// Filter where any value at `endpoints.outputs.image.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.image.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.image.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.image.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.image.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.image.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.image.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.image.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.image.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.image.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.image.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.image.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.image.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityType">
        /// Filter where any value at `endpoints.outputs.image.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.image.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.image.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.image.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.image.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.image.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.image.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.image.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.image.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImageStreaming">
        /// Filter where the value at `endpoints.outputs.image.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImageParams">
        /// Filter on the entries of `endpoints.outputs.image.params`: `endpoints.outputs.image.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.image.params.&lt;key&gt;.type`, `endpoints.outputs.image.params.&lt;key&gt;.range.min`, `endpoints.outputs.image.params.&lt;key&gt;.range.max`, `endpoints.outputs.image.params.&lt;key&gt;.range.default`, `endpoints.outputs.image.params.&lt;key&gt;.range.values`, `endpoints.outputs.image.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsVideoPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.video.passthrough_parameters`: `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingType">
        /// Filter where any value at `endpoints.outputs.video.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.video.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.video.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.video.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.video.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.video.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.video.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.video.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.video.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.video.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.video.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.video.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.video.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityType">
        /// Filter where any value at `endpoints.outputs.video.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.video.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.video.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.video.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.video.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.video.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.video.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.video.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.video.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoStreaming">
        /// Filter where the value at `endpoints.outputs.video.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoParams">
        /// Filter on the entries of `endpoints.outputs.video.params`: `endpoints.outputs.video.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.video.params.&lt;key&gt;.type`, `endpoints.outputs.video.params.&lt;key&gt;.range.min`, `endpoints.outputs.video.params.&lt;key&gt;.range.max`, `endpoints.outputs.video.params.&lt;key&gt;.range.default`, `endpoints.outputs.video.params.&lt;key&gt;.range.values`, `endpoints.outputs.video.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsSpeechPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.speech.passthrough_parameters`: `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingType">
        /// Filter where any value at `endpoints.outputs.speech.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.speech.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.speech.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.speech.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.speech.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.speech.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.speech.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.speech.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.speech.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.speech.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.speech.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.speech.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.speech.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityType">
        /// Filter where any value at `endpoints.outputs.speech.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.speech.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.speech.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.speech.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.speech.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.speech.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.speech.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.speech.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.speech.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechStreaming">
        /// Filter where the value at `endpoints.outputs.speech.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechParams">
        /// Filter on the entries of `endpoints.outputs.speech.params`: `endpoints.outputs.speech.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.speech.params.&lt;key&gt;.type`, `endpoints.outputs.speech.params.&lt;key&gt;.range.min`, `endpoints.outputs.speech.params.&lt;key&gt;.range.max`, `endpoints.outputs.speech.params.&lt;key&gt;.range.default`, `endpoints.outputs.speech.params.&lt;key&gt;.range.values`, `endpoints.outputs.speech.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.transcription.passthrough_parameters`: `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingType">
        /// Filter where any value at `endpoints.outputs.transcription.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.transcription.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.transcription.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.transcription.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.transcription.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityType">
        /// Filter where any value at `endpoints.outputs.transcription.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionStreaming">
        /// Filter where the value at `endpoints.outputs.transcription.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionParams">
        /// Filter on the entries of `endpoints.outputs.transcription.params`: `endpoints.outputs.transcription.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.transcription.params.&lt;key&gt;.type`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.min`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.max`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.default`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.values`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.embeddings.passthrough_parameters`: `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingType">
        /// Filter where any value at `endpoints.outputs.embeddings.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.embeddings.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.embeddings.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.embeddings.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityType">
        /// Filter where any value at `endpoints.outputs.embeddings.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsParams">
        /// Filter on the entries of `endpoints.outputs.embeddings.params`: `endpoints.outputs.embeddings.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.embeddings.params.&lt;key&gt;.type`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.min`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.max`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.default`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.values`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsRerankPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.rerank.passthrough_parameters`: `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingType">
        /// Filter where any value at `endpoints.outputs.rerank.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.rerank.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.rerank.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.rerank.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.rerank.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityType">
        /// Filter where any value at `endpoints.outputs.rerank.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankParams">
        /// Filter on the entries of `endpoints.outputs.rerank.params`: `endpoints.outputs.rerank.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.rerank.params.&lt;key&gt;.type`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.min`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.max`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.default`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.values`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.decisions.passthrough_parameters`: `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingType">
        /// Filter where any value at `endpoints.outputs.decisions.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.decisions.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.decisions.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.decisions.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.decisions.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityType">
        /// Filter where any value at `endpoints.outputs.decisions.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsParams">
        /// Filter on the entries of `endpoints.outputs.decisions.params`: `endpoints.outputs.decisions.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.decisions.params.&lt;key&gt;.type`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.min`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.max`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.default`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.values`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsAudioPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.audio.passthrough_parameters`: `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingType">
        /// Filter where any value at `endpoints.outputs.audio.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.audio.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.audio.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.audio.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.audio.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.audio.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.audio.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.audio.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.audio.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.audio.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.audio.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.audio.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.audio.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityType">
        /// Filter where any value at `endpoints.outputs.audio.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.audio.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.audio.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.audio.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.audio.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.audio.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.audio.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.audio.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.audio.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioStreaming">
        /// Filter where the value at `endpoints.outputs.audio.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioParams">
        /// Filter on the entries of `endpoints.outputs.audio.params`: `endpoints.outputs.audio.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.audio.params.&lt;key&gt;.type`, `endpoints.outputs.audio.params.&lt;key&gt;.range.min`, `endpoints.outputs.audio.params.&lt;key&gt;.range.max`, `endpoints.outputs.audio.params.&lt;key&gt;.range.default`, `endpoints.outputs.audio.params.&lt;key&gt;.range.values`, `endpoints.outputs.audio.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsProviderSlug">
        /// Filter where the value at `endpoints.provider.slug` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsProviderTag">
        /// Filter where the value at `endpoints.provider.tag` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsProviderName">
        /// Filter where the value at `endpoints.provider.name` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDataPolicyTraining">
        /// Filter where the value at `endpoints.data_policy.training` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDataPolicyRetainsPrompts">
        /// Filter where the value at `endpoints.data_policy.retains_prompts` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDataPolicyRetentionDays">
        /// Filter where the value at `endpoints.data_policy.retention_days` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ModelsV2ListResponse>> ListV2AsResponseAsync(
            int? offset = default,
            int? limit = default,
            string? cursor = default,
            global::OpenRouter.ListModelsV2Region? region = default,
            string? sort = default,
            string? id = default,
            string? canonicalSlug = default,
            string? author = default,
            string? name = default,
            string? variant = default,
            string? kind = default,
            string? aliasTargetSlug = default,
            string? aliasTargetName = default,
            string? created = default,
            string? description = default,
            string? contextLength = default,
            string? huggingFaceId = default,
            string? inputs = default,
            string? outputs = default,
            string? endpointsSchemaVersion = default,
            string? endpointsId = default,
            string? endpointsHuggingFaceId = default,
            string? endpointsName = default,
            string? endpointsCreated = default,
            string? endpointsQuantization = default,
            string? endpointsTokenizer = default,
            string? endpointsDescription = default,
            string? endpointsPricingType = default,
            string? endpointsPricingRequestUnit = default,
            string? endpointsPricingRequestCostUsd = default,
            string? endpointsPricingRequestOverridesCostUsd = default,
            string? endpointsPricingWebSearchUnit = default,
            string? endpointsPricingWebSearchCostUsd = default,
            string? endpointsPricingWebSearchOverridesCostUsd = default,
            string? endpointsCapacityType = default,
            string? endpointsCapacityRequestUnit = default,
            string? endpointsCapacityRequestPer = default,
            string? endpointsCapacityRequestValue = default,
            string? endpointsCapacityWebSearchUnit = default,
            string? endpointsCapacityWebSearchPer = default,
            string? endpointsCapacityWebSearchValue = default,
            string? endpointsCapacityConcurrencyUnit = default,
            string? endpointsCapacityConcurrencyValue = default,
            string? endpointsPassthroughParameters = default,
            string? endpointsDeprecationDate = default,
            string? endpointsIsReady = default,
            string? endpointsIsFree = default,
            string? endpointsServiceTier = default,
            string? endpointsDiscountToUser = default,
            string? endpointsOpenrouterSlug = default,
            string? endpointsDatacentersCountryCode = default,
            string? endpointsDatacentersRegion = default,
            string? endpointsDeploymentRegion = default,
            string? endpointsInputsType = default,
            string? endpointsInputsTextPricingType = default,
            string? endpointsInputsTextPricingPromptUnit = default,
            string? endpointsInputsTextPricingPromptCostUsd = default,
            string? endpointsInputsTextPricingPromptOverridesCostUsd = default,
            string? endpointsInputsTextPricingPromptUtcStart = default,
            string? endpointsInputsTextPricingPromptUtcEnd = default,
            string? endpointsInputsTextPricingPromptUtcDays = default,
            string? endpointsInputsTextPricingCachedPromptUnit = default,
            string? endpointsInputsTextPricingCachedPromptCostUsd = default,
            string? endpointsInputsTextPricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsTextPricingCachedPromptTtlSeconds = default,
            string? endpointsInputsTextPricingCachedPromptImplicit = default,
            string? endpointsInputsTextPricingCachedPromptUtcStart = default,
            string? endpointsInputsTextPricingCachedPromptUtcEnd = default,
            string? endpointsInputsTextPricingCachedPromptUtcDays = default,
            string? endpointsInputsTextPricingCacheWriteUnit = default,
            string? endpointsInputsTextPricingCacheWriteCostUsd = default,
            string? endpointsInputsTextPricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsTextPricingCacheWriteTtlSeconds = default,
            string? endpointsInputsTextPricingCacheWriteImplicit = default,
            string? endpointsInputsTextPricingCacheWriteUtcStart = default,
            string? endpointsInputsTextPricingCacheWriteUtcEnd = default,
            string? endpointsInputsTextPricingCacheWriteUtcDays = default,
            string? endpointsInputsTextCapacityType = default,
            string? endpointsInputsTextCapacityPromptUnit = default,
            string? endpointsInputsTextCapacityPromptPer = default,
            string? endpointsInputsTextCapacityPromptValue = default,
            string? endpointsInputsTextCapacityCachedPromptUnit = default,
            string? endpointsInputsTextCapacityCachedPromptPer = default,
            string? endpointsInputsTextCapacityCachedPromptValue = default,
            string? endpointsInputsTextCapacityCacheWriteUnit = default,
            string? endpointsInputsTextCapacityCacheWritePer = default,
            string? endpointsInputsTextCapacityCacheWriteValue = default,
            string? endpointsInputsTextPassthroughParameters = default,
            string? endpointsInputsTextParamsMaxPromptLengthValue = default,
            string? endpointsInputsTextParamsMaxPromptLengthUnit = default,
            string? endpointsInputsTextParamsMaxLengthValue = default,
            string? endpointsInputsTextParamsMaxLengthUnit = default,
            string? endpointsInputsImagePricingType = default,
            string? endpointsInputsImagePricingPromptUnit = default,
            string? endpointsInputsImagePricingPromptCostUsd = default,
            string? endpointsInputsImagePricingPromptOverridesCostUsd = default,
            string? endpointsInputsImagePricingPromptUtcStart = default,
            string? endpointsInputsImagePricingPromptUtcEnd = default,
            string? endpointsInputsImagePricingPromptUtcDays = default,
            string? endpointsInputsImagePricingCachedPromptUnit = default,
            string? endpointsInputsImagePricingCachedPromptCostUsd = default,
            string? endpointsInputsImagePricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsImagePricingCachedPromptTtlSeconds = default,
            string? endpointsInputsImagePricingCachedPromptImplicit = default,
            string? endpointsInputsImagePricingCachedPromptUtcStart = default,
            string? endpointsInputsImagePricingCachedPromptUtcEnd = default,
            string? endpointsInputsImagePricingCachedPromptUtcDays = default,
            string? endpointsInputsImagePricingCacheWriteUnit = default,
            string? endpointsInputsImagePricingCacheWriteCostUsd = default,
            string? endpointsInputsImagePricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsImagePricingCacheWriteTtlSeconds = default,
            string? endpointsInputsImagePricingCacheWriteImplicit = default,
            string? endpointsInputsImagePricingCacheWriteUtcStart = default,
            string? endpointsInputsImagePricingCacheWriteUtcEnd = default,
            string? endpointsInputsImagePricingCacheWriteUtcDays = default,
            string? endpointsInputsImageCapacityType = default,
            string? endpointsInputsImageCapacityPromptUnit = default,
            string? endpointsInputsImageCapacityPromptPer = default,
            string? endpointsInputsImageCapacityPromptValue = default,
            string? endpointsInputsImageCapacityCachedPromptUnit = default,
            string? endpointsInputsImageCapacityCachedPromptPer = default,
            string? endpointsInputsImageCapacityCachedPromptValue = default,
            string? endpointsInputsImageCapacityCacheWriteUnit = default,
            string? endpointsInputsImageCapacityCacheWritePer = default,
            string? endpointsInputsImageCapacityCacheWriteValue = default,
            string? endpointsInputsImagePassthroughParameters = default,
            string? endpointsInputsImageParamsSourcesType = default,
            string? endpointsInputsImageParamsSourcesValues = default,
            string? endpointsInputsImageParamsFormatsType = default,
            string? endpointsInputsImageParamsFormatsValues = default,
            string? endpointsInputsImageParamsDetailLevelsType = default,
            string? endpointsInputsImageParamsDetailLevelsValues = default,
            string? endpointsInputsImageParamsReferencesType = default,
            string? endpointsInputsImageParamsReferencesMin = default,
            string? endpointsInputsImageParamsReferencesMax = default,
            string? endpointsInputsImageParamsReferencesUnit = default,
            string? endpointsInputsImageParamsRoleType = default,
            string? endpointsInputsImageParamsRoleValues = default,
            string? endpointsInputsImageParamsMaxContentSizeBytesValue = default,
            string? endpointsInputsImageParamsMaxContentSizeBytesUnit = default,
            string? endpointsInputsVideoPricingType = default,
            string? endpointsInputsVideoPricingPromptUnit = default,
            string? endpointsInputsVideoPricingPromptCostUsd = default,
            string? endpointsInputsVideoPricingPromptOverridesCostUsd = default,
            string? endpointsInputsVideoPricingPromptUtcStart = default,
            string? endpointsInputsVideoPricingPromptUtcEnd = default,
            string? endpointsInputsVideoPricingPromptUtcDays = default,
            string? endpointsInputsVideoPricingCachedPromptUnit = default,
            string? endpointsInputsVideoPricingCachedPromptCostUsd = default,
            string? endpointsInputsVideoPricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsVideoPricingCachedPromptTtlSeconds = default,
            string? endpointsInputsVideoPricingCachedPromptImplicit = default,
            string? endpointsInputsVideoPricingCachedPromptUtcStart = default,
            string? endpointsInputsVideoPricingCachedPromptUtcEnd = default,
            string? endpointsInputsVideoPricingCachedPromptUtcDays = default,
            string? endpointsInputsVideoPricingCacheWriteUnit = default,
            string? endpointsInputsVideoPricingCacheWriteCostUsd = default,
            string? endpointsInputsVideoPricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsVideoPricingCacheWriteTtlSeconds = default,
            string? endpointsInputsVideoPricingCacheWriteImplicit = default,
            string? endpointsInputsVideoPricingCacheWriteUtcStart = default,
            string? endpointsInputsVideoPricingCacheWriteUtcEnd = default,
            string? endpointsInputsVideoPricingCacheWriteUtcDays = default,
            string? endpointsInputsVideoCapacityType = default,
            string? endpointsInputsVideoCapacityPromptUnit = default,
            string? endpointsInputsVideoCapacityPromptPer = default,
            string? endpointsInputsVideoCapacityPromptValue = default,
            string? endpointsInputsVideoCapacityCachedPromptUnit = default,
            string? endpointsInputsVideoCapacityCachedPromptPer = default,
            string? endpointsInputsVideoCapacityCachedPromptValue = default,
            string? endpointsInputsVideoCapacityCacheWriteUnit = default,
            string? endpointsInputsVideoCapacityCacheWritePer = default,
            string? endpointsInputsVideoCapacityCacheWriteValue = default,
            string? endpointsInputsVideoPassthroughParameters = default,
            string? endpointsInputsVideoParamsSourcesType = default,
            string? endpointsInputsVideoParamsSourcesValues = default,
            string? endpointsInputsVideoParamsFormatsType = default,
            string? endpointsInputsVideoParamsFormatsValues = default,
            string? endpointsInputsVideoParamsMaxDurationSecondsValue = default,
            string? endpointsInputsVideoParamsMaxDurationSecondsUnit = default,
            string? endpointsInputsVideoParamsMaxContentSizeBytesValue = default,
            string? endpointsInputsVideoParamsMaxContentSizeBytesUnit = default,
            string? endpointsInputsAudioPricingType = default,
            string? endpointsInputsAudioPricingPromptUnit = default,
            string? endpointsInputsAudioPricingPromptCostUsd = default,
            string? endpointsInputsAudioPricingPromptOverridesCostUsd = default,
            string? endpointsInputsAudioPricingPromptUtcStart = default,
            string? endpointsInputsAudioPricingPromptUtcEnd = default,
            string? endpointsInputsAudioPricingPromptUtcDays = default,
            string? endpointsInputsAudioPricingCachedPromptUnit = default,
            string? endpointsInputsAudioPricingCachedPromptCostUsd = default,
            string? endpointsInputsAudioPricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsAudioPricingCachedPromptTtlSeconds = default,
            string? endpointsInputsAudioPricingCachedPromptImplicit = default,
            string? endpointsInputsAudioPricingCachedPromptUtcStart = default,
            string? endpointsInputsAudioPricingCachedPromptUtcEnd = default,
            string? endpointsInputsAudioPricingCachedPromptUtcDays = default,
            string? endpointsInputsAudioPricingCacheWriteUnit = default,
            string? endpointsInputsAudioPricingCacheWriteCostUsd = default,
            string? endpointsInputsAudioPricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsAudioPricingCacheWriteTtlSeconds = default,
            string? endpointsInputsAudioPricingCacheWriteImplicit = default,
            string? endpointsInputsAudioPricingCacheWriteUtcStart = default,
            string? endpointsInputsAudioPricingCacheWriteUtcEnd = default,
            string? endpointsInputsAudioPricingCacheWriteUtcDays = default,
            string? endpointsInputsAudioCapacityType = default,
            string? endpointsInputsAudioCapacityPromptUnit = default,
            string? endpointsInputsAudioCapacityPromptPer = default,
            string? endpointsInputsAudioCapacityPromptValue = default,
            string? endpointsInputsAudioCapacityCachedPromptUnit = default,
            string? endpointsInputsAudioCapacityCachedPromptPer = default,
            string? endpointsInputsAudioCapacityCachedPromptValue = default,
            string? endpointsInputsAudioCapacityCacheWriteUnit = default,
            string? endpointsInputsAudioCapacityCacheWritePer = default,
            string? endpointsInputsAudioCapacityCacheWriteValue = default,
            string? endpointsInputsAudioPassthroughParameters = default,
            string? endpointsInputsAudioParamsSourcesType = default,
            string? endpointsInputsAudioParamsSourcesValues = default,
            string? endpointsInputsAudioParamsFormatsType = default,
            string? endpointsInputsAudioParamsFormatsValues = default,
            string? endpointsInputsAudioParamsMaxDurationSecondsValue = default,
            string? endpointsInputsAudioParamsMaxDurationSecondsUnit = default,
            string? endpointsInputsAudioParamsMaxContentSizeBytesValue = default,
            string? endpointsInputsAudioParamsMaxContentSizeBytesUnit = default,
            string? endpointsInputsFilePricingType = default,
            string? endpointsInputsFilePricingPromptUnit = default,
            string? endpointsInputsFilePricingPromptCostUsd = default,
            string? endpointsInputsFilePricingPromptOverridesCostUsd = default,
            string? endpointsInputsFilePricingPromptUtcStart = default,
            string? endpointsInputsFilePricingPromptUtcEnd = default,
            string? endpointsInputsFilePricingPromptUtcDays = default,
            string? endpointsInputsFilePricingCachedPromptUnit = default,
            string? endpointsInputsFilePricingCachedPromptCostUsd = default,
            string? endpointsInputsFilePricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsFilePricingCachedPromptTtlSeconds = default,
            string? endpointsInputsFilePricingCachedPromptImplicit = default,
            string? endpointsInputsFilePricingCachedPromptUtcStart = default,
            string? endpointsInputsFilePricingCachedPromptUtcEnd = default,
            string? endpointsInputsFilePricingCachedPromptUtcDays = default,
            string? endpointsInputsFilePricingCacheWriteUnit = default,
            string? endpointsInputsFilePricingCacheWriteCostUsd = default,
            string? endpointsInputsFilePricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsFilePricingCacheWriteTtlSeconds = default,
            string? endpointsInputsFilePricingCacheWriteImplicit = default,
            string? endpointsInputsFilePricingCacheWriteUtcStart = default,
            string? endpointsInputsFilePricingCacheWriteUtcEnd = default,
            string? endpointsInputsFilePricingCacheWriteUtcDays = default,
            string? endpointsInputsFileCapacityType = default,
            string? endpointsInputsFileCapacityPromptUnit = default,
            string? endpointsInputsFileCapacityPromptPer = default,
            string? endpointsInputsFileCapacityPromptValue = default,
            string? endpointsInputsFileCapacityCachedPromptUnit = default,
            string? endpointsInputsFileCapacityCachedPromptPer = default,
            string? endpointsInputsFileCapacityCachedPromptValue = default,
            string? endpointsInputsFileCapacityCacheWriteUnit = default,
            string? endpointsInputsFileCapacityCacheWritePer = default,
            string? endpointsInputsFileCapacityCacheWriteValue = default,
            string? endpointsInputsFilePassthroughParameters = default,
            string? endpointsInputsFileParamsSourcesType = default,
            string? endpointsInputsFileParamsSourcesValues = default,
            string? endpointsInputsFileParamsFormatsType = default,
            string? endpointsInputsFileParamsFormatsValues = default,
            string? endpointsInputsFileParamsReferencesType = default,
            string? endpointsInputsFileParamsReferencesMin = default,
            string? endpointsInputsFileParamsReferencesMax = default,
            string? endpointsInputsFileParamsReferencesUnit = default,
            string? endpointsInputsFileParamsMaxContentSizeBytesValue = default,
            string? endpointsInputsFileParamsMaxContentSizeBytesUnit = default,
            string? endpointsOutputsType = default,
            string? endpointsOutputsTextMaxLengthValue = default,
            string? endpointsOutputsTextMaxLengthUnit = default,
            string? endpointsOutputsTextPassthroughParameters = default,
            string? endpointsOutputsTextPricingType = default,
            string? endpointsOutputsTextPricingCompletionUnit = default,
            string? endpointsOutputsTextPricingCompletionCostUsd = default,
            string? endpointsOutputsTextPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsTextPricingCompletionUtcStart = default,
            string? endpointsOutputsTextPricingCompletionUtcEnd = default,
            string? endpointsOutputsTextPricingCompletionUtcDays = default,
            string? endpointsOutputsTextPricingInternalReasoningUnit = default,
            string? endpointsOutputsTextPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsTextPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsTextPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsTextPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsTextPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsTextCapacityType = default,
            string? endpointsOutputsTextCapacityCompletionUnit = default,
            string? endpointsOutputsTextCapacityCompletionPer = default,
            string? endpointsOutputsTextCapacityCompletionValue = default,
            string? endpointsOutputsTextCapacityInternalReasoningUnit = default,
            string? endpointsOutputsTextCapacityInternalReasoningPer = default,
            string? endpointsOutputsTextCapacityInternalReasoningValue = default,
            string? endpointsOutputsTextCapacityConcurrencyUnit = default,
            string? endpointsOutputsTextCapacityConcurrencyValue = default,
            string? endpointsOutputsTextStreaming = default,
            string? endpointsOutputsTextParams = default,
            string? endpointsOutputsImagePassthroughParameters = default,
            string? endpointsOutputsImagePricingType = default,
            string? endpointsOutputsImagePricingCompletionUnit = default,
            string? endpointsOutputsImagePricingCompletionCostUsd = default,
            string? endpointsOutputsImagePricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsImagePricingCompletionUtcStart = default,
            string? endpointsOutputsImagePricingCompletionUtcEnd = default,
            string? endpointsOutputsImagePricingCompletionUtcDays = default,
            string? endpointsOutputsImagePricingInternalReasoningUnit = default,
            string? endpointsOutputsImagePricingInternalReasoningCostUsd = default,
            string? endpointsOutputsImagePricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsImagePricingInternalReasoningUtcStart = default,
            string? endpointsOutputsImagePricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsImagePricingInternalReasoningUtcDays = default,
            string? endpointsOutputsImageCapacityType = default,
            string? endpointsOutputsImageCapacityCompletionUnit = default,
            string? endpointsOutputsImageCapacityCompletionPer = default,
            string? endpointsOutputsImageCapacityCompletionValue = default,
            string? endpointsOutputsImageCapacityInternalReasoningUnit = default,
            string? endpointsOutputsImageCapacityInternalReasoningPer = default,
            string? endpointsOutputsImageCapacityInternalReasoningValue = default,
            string? endpointsOutputsImageCapacityConcurrencyUnit = default,
            string? endpointsOutputsImageCapacityConcurrencyValue = default,
            string? endpointsOutputsImageStreaming = default,
            string? endpointsOutputsImageParams = default,
            string? endpointsOutputsVideoPassthroughParameters = default,
            string? endpointsOutputsVideoPricingType = default,
            string? endpointsOutputsVideoPricingCompletionUnit = default,
            string? endpointsOutputsVideoPricingCompletionCostUsd = default,
            string? endpointsOutputsVideoPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsVideoPricingCompletionUtcStart = default,
            string? endpointsOutputsVideoPricingCompletionUtcEnd = default,
            string? endpointsOutputsVideoPricingCompletionUtcDays = default,
            string? endpointsOutputsVideoPricingInternalReasoningUnit = default,
            string? endpointsOutputsVideoPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsVideoPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsVideoPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsVideoPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsVideoPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsVideoCapacityType = default,
            string? endpointsOutputsVideoCapacityCompletionUnit = default,
            string? endpointsOutputsVideoCapacityCompletionPer = default,
            string? endpointsOutputsVideoCapacityCompletionValue = default,
            string? endpointsOutputsVideoCapacityInternalReasoningUnit = default,
            string? endpointsOutputsVideoCapacityInternalReasoningPer = default,
            string? endpointsOutputsVideoCapacityInternalReasoningValue = default,
            string? endpointsOutputsVideoCapacityConcurrencyUnit = default,
            string? endpointsOutputsVideoCapacityConcurrencyValue = default,
            string? endpointsOutputsVideoStreaming = default,
            string? endpointsOutputsVideoParams = default,
            string? endpointsOutputsSpeechPassthroughParameters = default,
            string? endpointsOutputsSpeechPricingType = default,
            string? endpointsOutputsSpeechPricingCompletionUnit = default,
            string? endpointsOutputsSpeechPricingCompletionCostUsd = default,
            string? endpointsOutputsSpeechPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsSpeechPricingCompletionUtcStart = default,
            string? endpointsOutputsSpeechPricingCompletionUtcEnd = default,
            string? endpointsOutputsSpeechPricingCompletionUtcDays = default,
            string? endpointsOutputsSpeechPricingInternalReasoningUnit = default,
            string? endpointsOutputsSpeechPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsSpeechPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsSpeechPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsSpeechPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsSpeechPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsSpeechCapacityType = default,
            string? endpointsOutputsSpeechCapacityCompletionUnit = default,
            string? endpointsOutputsSpeechCapacityCompletionPer = default,
            string? endpointsOutputsSpeechCapacityCompletionValue = default,
            string? endpointsOutputsSpeechCapacityInternalReasoningUnit = default,
            string? endpointsOutputsSpeechCapacityInternalReasoningPer = default,
            string? endpointsOutputsSpeechCapacityInternalReasoningValue = default,
            string? endpointsOutputsSpeechCapacityConcurrencyUnit = default,
            string? endpointsOutputsSpeechCapacityConcurrencyValue = default,
            string? endpointsOutputsSpeechStreaming = default,
            string? endpointsOutputsSpeechParams = default,
            string? endpointsOutputsTranscriptionPassthroughParameters = default,
            string? endpointsOutputsTranscriptionPricingType = default,
            string? endpointsOutputsTranscriptionPricingCompletionUnit = default,
            string? endpointsOutputsTranscriptionPricingCompletionCostUsd = default,
            string? endpointsOutputsTranscriptionPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsTranscriptionPricingCompletionUtcStart = default,
            string? endpointsOutputsTranscriptionPricingCompletionUtcEnd = default,
            string? endpointsOutputsTranscriptionPricingCompletionUtcDays = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUnit = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsTranscriptionCapacityType = default,
            string? endpointsOutputsTranscriptionCapacityCompletionUnit = default,
            string? endpointsOutputsTranscriptionCapacityCompletionPer = default,
            string? endpointsOutputsTranscriptionCapacityCompletionValue = default,
            string? endpointsOutputsTranscriptionCapacityInternalReasoningUnit = default,
            string? endpointsOutputsTranscriptionCapacityInternalReasoningPer = default,
            string? endpointsOutputsTranscriptionCapacityInternalReasoningValue = default,
            string? endpointsOutputsTranscriptionCapacityConcurrencyUnit = default,
            string? endpointsOutputsTranscriptionCapacityConcurrencyValue = default,
            string? endpointsOutputsTranscriptionStreaming = default,
            string? endpointsOutputsTranscriptionParams = default,
            string? endpointsOutputsEmbeddingsPassthroughParameters = default,
            string? endpointsOutputsEmbeddingsPricingType = default,
            string? endpointsOutputsEmbeddingsPricingCompletionUnit = default,
            string? endpointsOutputsEmbeddingsPricingCompletionCostUsd = default,
            string? endpointsOutputsEmbeddingsPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsEmbeddingsPricingCompletionUtcStart = default,
            string? endpointsOutputsEmbeddingsPricingCompletionUtcEnd = default,
            string? endpointsOutputsEmbeddingsPricingCompletionUtcDays = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUnit = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsEmbeddingsCapacityType = default,
            string? endpointsOutputsEmbeddingsCapacityCompletionUnit = default,
            string? endpointsOutputsEmbeddingsCapacityCompletionPer = default,
            string? endpointsOutputsEmbeddingsCapacityCompletionValue = default,
            string? endpointsOutputsEmbeddingsCapacityInternalReasoningUnit = default,
            string? endpointsOutputsEmbeddingsCapacityInternalReasoningPer = default,
            string? endpointsOutputsEmbeddingsCapacityInternalReasoningValue = default,
            string? endpointsOutputsEmbeddingsCapacityConcurrencyUnit = default,
            string? endpointsOutputsEmbeddingsCapacityConcurrencyValue = default,
            string? endpointsOutputsEmbeddingsParams = default,
            string? endpointsOutputsRerankPassthroughParameters = default,
            string? endpointsOutputsRerankPricingType = default,
            string? endpointsOutputsRerankPricingCompletionUnit = default,
            string? endpointsOutputsRerankPricingCompletionCostUsd = default,
            string? endpointsOutputsRerankPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsRerankPricingCompletionUtcStart = default,
            string? endpointsOutputsRerankPricingCompletionUtcEnd = default,
            string? endpointsOutputsRerankPricingCompletionUtcDays = default,
            string? endpointsOutputsRerankPricingInternalReasoningUnit = default,
            string? endpointsOutputsRerankPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsRerankPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsRerankPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsRerankPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsRerankPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsRerankCapacityType = default,
            string? endpointsOutputsRerankCapacityCompletionUnit = default,
            string? endpointsOutputsRerankCapacityCompletionPer = default,
            string? endpointsOutputsRerankCapacityCompletionValue = default,
            string? endpointsOutputsRerankCapacityInternalReasoningUnit = default,
            string? endpointsOutputsRerankCapacityInternalReasoningPer = default,
            string? endpointsOutputsRerankCapacityInternalReasoningValue = default,
            string? endpointsOutputsRerankCapacityConcurrencyUnit = default,
            string? endpointsOutputsRerankCapacityConcurrencyValue = default,
            string? endpointsOutputsRerankParams = default,
            string? endpointsOutputsDecisionsPassthroughParameters = default,
            string? endpointsOutputsDecisionsPricingType = default,
            string? endpointsOutputsDecisionsPricingCompletionUnit = default,
            string? endpointsOutputsDecisionsPricingCompletionCostUsd = default,
            string? endpointsOutputsDecisionsPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsDecisionsPricingCompletionUtcStart = default,
            string? endpointsOutputsDecisionsPricingCompletionUtcEnd = default,
            string? endpointsOutputsDecisionsPricingCompletionUtcDays = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningUnit = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsDecisionsCapacityType = default,
            string? endpointsOutputsDecisionsCapacityCompletionUnit = default,
            string? endpointsOutputsDecisionsCapacityCompletionPer = default,
            string? endpointsOutputsDecisionsCapacityCompletionValue = default,
            string? endpointsOutputsDecisionsCapacityInternalReasoningUnit = default,
            string? endpointsOutputsDecisionsCapacityInternalReasoningPer = default,
            string? endpointsOutputsDecisionsCapacityInternalReasoningValue = default,
            string? endpointsOutputsDecisionsCapacityConcurrencyUnit = default,
            string? endpointsOutputsDecisionsCapacityConcurrencyValue = default,
            string? endpointsOutputsDecisionsParams = default,
            string? endpointsOutputsAudioPassthroughParameters = default,
            string? endpointsOutputsAudioPricingType = default,
            string? endpointsOutputsAudioPricingCompletionUnit = default,
            string? endpointsOutputsAudioPricingCompletionCostUsd = default,
            string? endpointsOutputsAudioPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsAudioPricingCompletionUtcStart = default,
            string? endpointsOutputsAudioPricingCompletionUtcEnd = default,
            string? endpointsOutputsAudioPricingCompletionUtcDays = default,
            string? endpointsOutputsAudioPricingInternalReasoningUnit = default,
            string? endpointsOutputsAudioPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsAudioPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsAudioPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsAudioPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsAudioPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsAudioCapacityType = default,
            string? endpointsOutputsAudioCapacityCompletionUnit = default,
            string? endpointsOutputsAudioCapacityCompletionPer = default,
            string? endpointsOutputsAudioCapacityCompletionValue = default,
            string? endpointsOutputsAudioCapacityInternalReasoningUnit = default,
            string? endpointsOutputsAudioCapacityInternalReasoningPer = default,
            string? endpointsOutputsAudioCapacityInternalReasoningValue = default,
            string? endpointsOutputsAudioCapacityConcurrencyUnit = default,
            string? endpointsOutputsAudioCapacityConcurrencyValue = default,
            string? endpointsOutputsAudioStreaming = default,
            string? endpointsOutputsAudioParams = default,
            string? endpointsProviderSlug = default,
            string? endpointsProviderTag = default,
            string? endpointsProviderName = default,
            string? endpointsDataPolicyTraining = default,
            string? endpointsDataPolicyRetainsPrompts = default,
            string? endpointsDataPolicyRetentionDays = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}