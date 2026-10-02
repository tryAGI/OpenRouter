
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Optional provider slug to filter by (e.g. `openai`, `anthropic`, `amazon-bedrock`).<br/>
    /// Example: openai
    /// </summary>
    public readonly partial struct ListBYOKKeysProvider : global::System.IEquatable<ListBYOKKeysProvider>
    {
        /// <summary>
        ///
        /// </summary>
        public ListBYOKKeysProvider(string value)
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
        public static ListBYOKKeysProvider Ai21 { get; } = new("ai21");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider AionLabs { get; } = new("aion-labs");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Akashml { get; } = new("akashml");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Alibaba { get; } = new("alibaba");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider AmazonBedrock { get; } = new("amazon-bedrock");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider AmazonBedrockClaudeOnAws { get; } = new("amazon-bedrock/claude-on-aws");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider AmazonNova { get; } = new("amazon-nova");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Ambient { get; } = new("ambient");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Anthropic { get; } = new("anthropic");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Anthropic2 { get; } = new("anthropic/2");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider ArceeAi { get; } = new("arcee-ai");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Assemblyai { get; } = new("assemblyai");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider AtlasCloud { get; } = new("atlas-cloud");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Avian { get; } = new("avian");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Azure { get; } = new("azure");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Baidu { get; } = new("baidu");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Baseten { get; } = new("baseten");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider BlackForestLabs { get; } = new("black-forest-labs");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Byteplus { get; } = new("byteplus");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Cerebras { get; } = new("cerebras");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Chutes { get; } = new("chutes");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Cirrascale { get; } = new("cirrascale");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Clarifai { get; } = new("clarifai");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider ClaudeOnAws { get; } = new("claude-on-aws");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Cloudflare { get; } = new("cloudflare");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Cohere { get; } = new("cohere");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Coreweave { get; } = new("coreweave");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Cosine { get; } = new("cosine");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Crusoe { get; } = new("crusoe");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Darkbloom { get; } = new("darkbloom");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Databricks { get; } = new("databricks");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Decart { get; } = new("decart");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Deepgram { get; } = new("deepgram");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Deepinfra { get; } = new("deepinfra");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Deepseek { get; } = new("deepseek");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Dekallm { get; } = new("dekallm");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Digitalocean { get; } = new("digitalocean");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Elevenlabs { get; } = new("elevenlabs");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Featherless { get; } = new("featherless");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Fireworks { get; } = new("fireworks");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider FishAudio { get; } = new("fish-audio");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Friendli { get; } = new("friendli");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Gmicloud { get; } = new("gmicloud");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider GoogleAiStudio { get; } = new("google-ai-studio");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider GoogleVertex { get; } = new("google-vertex");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Groq { get; } = new("groq");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Heygen { get; } = new("heygen");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Inception { get; } = new("inception");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Inceptron { get; } = new("inceptron");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider InferactVllm { get; } = new("inferact-vllm");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider InferenceNet { get; } = new("inference-net");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Infermatic { get; } = new("infermatic");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Inflection { get; } = new("inflection");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider IoNet { get; } = new("io-net");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Ionstream { get; } = new("ionstream");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Krea { get; } = new("krea");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Liquid { get; } = new("liquid");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Makora { get; } = new("makora");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Mancer { get; } = new("mancer");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Mara { get; } = new("mara");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Meta { get; } = new("meta");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Minimax { get; } = new("minimax");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Mistral { get; } = new("mistral");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Modal { get; } = new("modal");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Modelrun { get; } = new("modelrun");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Modular { get; } = new("modular");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Moonshotai { get; } = new("moonshotai");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Morph { get; } = new("morph");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider NearAi { get; } = new("near-ai");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Nebius { get; } = new("nebius");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider NexAgi { get; } = new("nex-agi");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Nextbit { get; } = new("nextbit");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Novita { get; } = new("novita");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Nvidia { get; } = new("nvidia");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Ollama { get; } = new("ollama");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider OpenInference { get; } = new("open-inference");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Openai { get; } = new("openai");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Parasail { get; } = new("parasail");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Perceptron { get; } = new("perceptron");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Perplexity { get; } = new("perplexity");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Phala { get; } = new("phala");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Poolside { get; } = new("poolside");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Primeintellect { get; } = new("primeintellect");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Quiver { get; } = new("quiver");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Recraft { get; } = new("recraft");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Reka { get; } = new("reka");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Relace { get; } = new("relace");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Respan { get; } = new("respan");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Runway { get; } = new("runway");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider SailResearch { get; } = new("sail-research");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Sakana { get; } = new("sakana");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider SakanaAi { get; } = new("sakana-ai");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Sambanova { get; } = new("sambanova");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Scaledown { get; } = new("scaledown");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Seed { get; } = new("seed");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Siliconflow { get; } = new("siliconflow");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Sourceful { get; } = new("sourceful");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Stepfun { get; } = new("stepfun");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Streamlake { get; } = new("streamlake");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Switchpoint { get; } = new("switchpoint");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Tencent { get; } = new("tencent");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Tenstorrent { get; } = new("tenstorrent");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Thinkingmachines { get; } = new("thinkingmachines");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Together { get; } = new("together");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Typesafe { get; } = new("typesafe");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Unbiased { get; } = new("unbiased");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Upstage { get; } = new("upstage");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Venice { get; } = new("venice");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Voyageai { get; } = new("voyageai");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Wafer { get; } = new("wafer");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Wandb { get; } = new("wandb");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider WandbLegacy { get; } = new("wandb-legacy");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Xai { get; } = new("xai");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider Xiaomi { get; } = new("xiaomi");

        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider ZAi { get; } = new("z-ai");
        /// <summary>
        ///
        /// </summary>
        public static ListBYOKKeysProvider FromValue(string value)
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
                _ => new ListBYOKKeysProvider(value),
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
        public bool Equals(ListBYOKKeysProvider other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListBYOKKeysProvider other && Equals(other);
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
        public static bool operator ==(ListBYOKKeysProvider left, ListBYOKKeysProvider right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ListBYOKKeysProvider left, ListBYOKKeysProvider right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListBYOKKeysProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBYOKKeysProvider value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBYOKKeysProvider? ToEnum(string value)
        {
            return ListBYOKKeysProvider.FromValue(value);
        }
    }
}