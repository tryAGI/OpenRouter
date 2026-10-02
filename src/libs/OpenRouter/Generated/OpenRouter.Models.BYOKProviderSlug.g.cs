
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// The upstream provider this credential authenticates against, as a lowercase slug (e.g. `openai`, `anthropic`, `amazon-bedrock`).<br/>
    /// Example: openai
    /// </summary>
    public readonly partial struct BYOKProviderSlug : global::System.IEquatable<BYOKProviderSlug>
    {
        /// <summary>
        ///
        /// </summary>
        public BYOKProviderSlug(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Ai21 { get; } = new("ai21");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug AionLabs { get; } = new("aion-labs");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Akashml { get; } = new("akashml");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Alibaba { get; } = new("alibaba");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug AmazonBedrock { get; } = new("amazon-bedrock");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug AmazonBedrockClaudeOnAws { get; } = new("amazon-bedrock/claude-on-aws");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug AmazonNova { get; } = new("amazon-nova");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Ambient { get; } = new("ambient");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Anthropic { get; } = new("anthropic");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Anthropic2 { get; } = new("anthropic/2");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug ArceeAi { get; } = new("arcee-ai");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Assemblyai { get; } = new("assemblyai");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug AtlasCloud { get; } = new("atlas-cloud");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Avian { get; } = new("avian");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Azure { get; } = new("azure");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Baidu { get; } = new("baidu");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Baseten { get; } = new("baseten");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug BlackForestLabs { get; } = new("black-forest-labs");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Byteplus { get; } = new("byteplus");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Cerebras { get; } = new("cerebras");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Chutes { get; } = new("chutes");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Cirrascale { get; } = new("cirrascale");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Clarifai { get; } = new("clarifai");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug ClaudeOnAws { get; } = new("claude-on-aws");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Cloudflare { get; } = new("cloudflare");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Cohere { get; } = new("cohere");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Coreweave { get; } = new("coreweave");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Cosine { get; } = new("cosine");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Crusoe { get; } = new("crusoe");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Darkbloom { get; } = new("darkbloom");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Databricks { get; } = new("databricks");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Decart { get; } = new("decart");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Deepgram { get; } = new("deepgram");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Deepinfra { get; } = new("deepinfra");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Deepseek { get; } = new("deepseek");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Dekallm { get; } = new("dekallm");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Digitalocean { get; } = new("digitalocean");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Elevenlabs { get; } = new("elevenlabs");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Featherless { get; } = new("featherless");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Fireworks { get; } = new("fireworks");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug FishAudio { get; } = new("fish-audio");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Friendli { get; } = new("friendli");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Gmicloud { get; } = new("gmicloud");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug GoogleAiStudio { get; } = new("google-ai-studio");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug GoogleVertex { get; } = new("google-vertex");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Groq { get; } = new("groq");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Heygen { get; } = new("heygen");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Inception { get; } = new("inception");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Inceptron { get; } = new("inceptron");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug InferactVllm { get; } = new("inferact-vllm");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug InferenceNet { get; } = new("inference-net");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Infermatic { get; } = new("infermatic");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Inflection { get; } = new("inflection");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug IoNet { get; } = new("io-net");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Ionstream { get; } = new("ionstream");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Krea { get; } = new("krea");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Liquid { get; } = new("liquid");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Makora { get; } = new("makora");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Mancer { get; } = new("mancer");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Mara { get; } = new("mara");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Meta { get; } = new("meta");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Minimax { get; } = new("minimax");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Mistral { get; } = new("mistral");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Modal { get; } = new("modal");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Modelrun { get; } = new("modelrun");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Modular { get; } = new("modular");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Moonshotai { get; } = new("moonshotai");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Morph { get; } = new("morph");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug NearAi { get; } = new("near-ai");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Nebius { get; } = new("nebius");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug NexAgi { get; } = new("nex-agi");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Nextbit { get; } = new("nextbit");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Novita { get; } = new("novita");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Nvidia { get; } = new("nvidia");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Ollama { get; } = new("ollama");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug OpenInference { get; } = new("open-inference");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Openai { get; } = new("openai");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Parasail { get; } = new("parasail");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Perceptron { get; } = new("perceptron");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Perplexity { get; } = new("perplexity");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Phala { get; } = new("phala");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Poolside { get; } = new("poolside");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Primeintellect { get; } = new("primeintellect");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Quiver { get; } = new("quiver");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Recraft { get; } = new("recraft");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Reka { get; } = new("reka");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Relace { get; } = new("relace");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Respan { get; } = new("respan");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Runway { get; } = new("runway");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug SailResearch { get; } = new("sail-research");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Sakana { get; } = new("sakana");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug SakanaAi { get; } = new("sakana-ai");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Sambanova { get; } = new("sambanova");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Scaledown { get; } = new("scaledown");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Seed { get; } = new("seed");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Siliconflow { get; } = new("siliconflow");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Sourceful { get; } = new("sourceful");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Stepfun { get; } = new("stepfun");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Streamlake { get; } = new("streamlake");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Switchpoint { get; } = new("switchpoint");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Tencent { get; } = new("tencent");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Tenstorrent { get; } = new("tenstorrent");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Thinkingmachines { get; } = new("thinkingmachines");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Together { get; } = new("together");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Typesafe { get; } = new("typesafe");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Unbiased { get; } = new("unbiased");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Upstage { get; } = new("upstage");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Venice { get; } = new("venice");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Voyageai { get; } = new("voyageai");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Wafer { get; } = new("wafer");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Wandb { get; } = new("wandb");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug WandbLegacy { get; } = new("wandb-legacy");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Xai { get; } = new("xai");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug Xiaomi { get; } = new("xiaomi");

        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug ZAi { get; } = new("z-ai");
        /// <summary>
        ///
        /// </summary>
        public static BYOKProviderSlug FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "ai21" => Ai21,
                "aion-labs" => AionLabs,
                "akashml" => Akashml,
                "alibaba" => Alibaba,
                "amazon-bedrock" => AmazonBedrock,
                "amazon-bedrock/claude-on-aws" => AmazonBedrockClaudeOnAws,
                "amazon-nova" => AmazonNova,
                "ambient" => Ambient,
                "anthropic" => Anthropic,
                "anthropic/2" => Anthropic2,
                "arcee-ai" => ArceeAi,
                "assemblyai" => Assemblyai,
                "atlas-cloud" => AtlasCloud,
                "avian" => Avian,
                "azure" => Azure,
                "baidu" => Baidu,
                "baseten" => Baseten,
                "black-forest-labs" => BlackForestLabs,
                "byteplus" => Byteplus,
                "cerebras" => Cerebras,
                "chutes" => Chutes,
                "cirrascale" => Cirrascale,
                "clarifai" => Clarifai,
                "claude-on-aws" => ClaudeOnAws,
                "cloudflare" => Cloudflare,
                "cohere" => Cohere,
                "coreweave" => Coreweave,
                "cosine" => Cosine,
                "crusoe" => Crusoe,
                "darkbloom" => Darkbloom,
                "databricks" => Databricks,
                "decart" => Decart,
                "deepgram" => Deepgram,
                "deepinfra" => Deepinfra,
                "deepseek" => Deepseek,
                "dekallm" => Dekallm,
                "digitalocean" => Digitalocean,
                "elevenlabs" => Elevenlabs,
                "featherless" => Featherless,
                "fireworks" => Fireworks,
                "fish-audio" => FishAudio,
                "friendli" => Friendli,
                "gmicloud" => Gmicloud,
                "google-ai-studio" => GoogleAiStudio,
                "google-vertex" => GoogleVertex,
                "groq" => Groq,
                "heygen" => Heygen,
                "inception" => Inception,
                "inceptron" => Inceptron,
                "inferact-vllm" => InferactVllm,
                "inference-net" => InferenceNet,
                "infermatic" => Infermatic,
                "inflection" => Inflection,
                "io-net" => IoNet,
                "ionstream" => Ionstream,
                "krea" => Krea,
                "liquid" => Liquid,
                "makora" => Makora,
                "mancer" => Mancer,
                "mara" => Mara,
                "meta" => Meta,
                "minimax" => Minimax,
                "mistral" => Mistral,
                "modal" => Modal,
                "modelrun" => Modelrun,
                "modular" => Modular,
                "moonshotai" => Moonshotai,
                "morph" => Morph,
                "near-ai" => NearAi,
                "nebius" => Nebius,
                "nex-agi" => NexAgi,
                "nextbit" => Nextbit,
                "novita" => Novita,
                "nvidia" => Nvidia,
                "ollama" => Ollama,
                "open-inference" => OpenInference,
                "openai" => Openai,
                "parasail" => Parasail,
                "perceptron" => Perceptron,
                "perplexity" => Perplexity,
                "phala" => Phala,
                "poolside" => Poolside,
                "primeintellect" => Primeintellect,
                "quiver" => Quiver,
                "recraft" => Recraft,
                "reka" => Reka,
                "relace" => Relace,
                "respan" => Respan,
                "runway" => Runway,
                "sail-research" => SailResearch,
                "sakana" => Sakana,
                "sakana-ai" => SakanaAi,
                "sambanova" => Sambanova,
                "scaledown" => Scaledown,
                "seed" => Seed,
                "siliconflow" => Siliconflow,
                "sourceful" => Sourceful,
                "stepfun" => Stepfun,
                "streamlake" => Streamlake,
                "switchpoint" => Switchpoint,
                "tencent" => Tencent,
                "tenstorrent" => Tenstorrent,
                "thinkingmachines" => Thinkingmachines,
                "together" => Together,
                "typesafe" => Typesafe,
                "unbiased" => Unbiased,
                "upstage" => Upstage,
                "venice" => Venice,
                "voyageai" => Voyageai,
                "wafer" => Wafer,
                "wandb" => Wandb,
                "wandb-legacy" => WandbLegacy,
                "xai" => Xai,
                "xiaomi" => Xiaomi,
                "z-ai" => ZAi,
                _ => new BYOKProviderSlug(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "ai21" => true,
            "aion-labs" => true,
            "akashml" => true,
            "alibaba" => true,
            "amazon-bedrock" => true,
            "amazon-bedrock/claude-on-aws" => true,
            "amazon-nova" => true,
            "ambient" => true,
            "anthropic" => true,
            "anthropic/2" => true,
            "arcee-ai" => true,
            "assemblyai" => true,
            "atlas-cloud" => true,
            "avian" => true,
            "azure" => true,
            "baidu" => true,
            "baseten" => true,
            "black-forest-labs" => true,
            "byteplus" => true,
            "cerebras" => true,
            "chutes" => true,
            "cirrascale" => true,
            "clarifai" => true,
            "claude-on-aws" => true,
            "cloudflare" => true,
            "cohere" => true,
            "coreweave" => true,
            "cosine" => true,
            "crusoe" => true,
            "darkbloom" => true,
            "databricks" => true,
            "decart" => true,
            "deepgram" => true,
            "deepinfra" => true,
            "deepseek" => true,
            "dekallm" => true,
            "digitalocean" => true,
            "elevenlabs" => true,
            "featherless" => true,
            "fireworks" => true,
            "fish-audio" => true,
            "friendli" => true,
            "gmicloud" => true,
            "google-ai-studio" => true,
            "google-vertex" => true,
            "groq" => true,
            "heygen" => true,
            "inception" => true,
            "inceptron" => true,
            "inferact-vllm" => true,
            "inference-net" => true,
            "infermatic" => true,
            "inflection" => true,
            "io-net" => true,
            "ionstream" => true,
            "krea" => true,
            "liquid" => true,
            "makora" => true,
            "mancer" => true,
            "mara" => true,
            "meta" => true,
            "minimax" => true,
            "mistral" => true,
            "modal" => true,
            "modelrun" => true,
            "modular" => true,
            "moonshotai" => true,
            "morph" => true,
            "near-ai" => true,
            "nebius" => true,
            "nex-agi" => true,
            "nextbit" => true,
            "novita" => true,
            "nvidia" => true,
            "ollama" => true,
            "open-inference" => true,
            "openai" => true,
            "parasail" => true,
            "perceptron" => true,
            "perplexity" => true,
            "phala" => true,
            "poolside" => true,
            "primeintellect" => true,
            "quiver" => true,
            "recraft" => true,
            "reka" => true,
            "relace" => true,
            "respan" => true,
            "runway" => true,
            "sail-research" => true,
            "sakana" => true,
            "sakana-ai" => true,
            "sambanova" => true,
            "scaledown" => true,
            "seed" => true,
            "siliconflow" => true,
            "sourceful" => true,
            "stepfun" => true,
            "streamlake" => true,
            "switchpoint" => true,
            "tencent" => true,
            "tenstorrent" => true,
            "thinkingmachines" => true,
            "together" => true,
            "typesafe" => true,
            "unbiased" => true,
            "upstage" => true,
            "venice" => true,
            "voyageai" => true,
            "wafer" => true,
            "wandb" => true,
            "wandb-legacy" => true,
            "xai" => true,
            "xiaomi" => true,
            "z-ai" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(BYOKProviderSlug other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BYOKProviderSlug other && Equals(other);
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BYOKProviderSlug left, BYOKProviderSlug right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BYOKProviderSlug left, BYOKProviderSlug right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BYOKProviderSlugExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BYOKProviderSlug value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BYOKProviderSlug? ToEnum(string value)
        {
            return BYOKProviderSlug.FromValue(value);
        }
    }
}