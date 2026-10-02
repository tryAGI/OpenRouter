
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: OpenAI
    /// </summary>
    public readonly partial struct ProviderName : global::System.IEquatable<ProviderName>
    {
        /// <summary>
        ///
        /// </summary>
        public ProviderName(string value)
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
        public static ProviderName Ai21 { get; } = new("AI21");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName AionLabs { get; } = new("AionLabs");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName AkashML { get; } = new("AkashML");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Alibaba { get; } = new("Alibaba");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName AmazonBedrock { get; } = new("Amazon Bedrock");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName AmazonNova { get; } = new("Amazon Nova");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Ambient { get; } = new("Ambient");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Anthropic { get; } = new("Anthropic");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName ArceeAi { get; } = new("Arcee AI");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName AssemblyAI { get; } = new("AssemblyAI");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName AtlasCloud { get; } = new("AtlasCloud");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Avian { get; } = new("Avian");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Azure { get; } = new("Azure");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Baidu { get; } = new("Baidu");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName BaseTen { get; } = new("BaseTen");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName BlackForestLabs { get; } = new("Black Forest Labs");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName BytePlus { get; } = new("BytePlus");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Cerebras { get; } = new("Cerebras");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Chutes { get; } = new("Chutes");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Cirrascale { get; } = new("Cirrascale");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Clarifai { get; } = new("Clarifai");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName ClaudePlatformOnAws { get; } = new("Claude Platform on AWS");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Cloudflare { get; } = new("Cloudflare");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Cohere { get; } = new("Cohere");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName CoreWeave { get; } = new("CoreWeave");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Cosine { get; } = new("Cosine");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Crucible { get; } = new("Crucible");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Crusoe { get; } = new("Crusoe");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Darkbloom { get; } = new("Darkbloom");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Databricks { get; } = new("Databricks");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Decart { get; } = new("Decart");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName DeepInfra { get; } = new("DeepInfra");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName DeepSeek { get; } = new("DeepSeek");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Deepgram { get; } = new("Deepgram");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName DekaLLM { get; } = new("DekaLLM");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName DigitalOcean { get; } = new("DigitalOcean");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName ElevenLabs { get; } = new("ElevenLabs");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName FakeProvider { get; } = new("FakeProvider");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Featherless { get; } = new("Featherless");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Fireworks { get; } = new("Fireworks");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName FishAudio { get; } = new("Fish Audio");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Friendli { get; } = new("Friendli");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName GMICloud { get; } = new("GMICloud");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Google { get; } = new("Google");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName GoogleAiStudio { get; } = new("Google AI Studio");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Groq { get; } = new("Groq");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName HeyGen { get; } = new("HeyGen");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Inception { get; } = new("Inception");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Inceptron { get; } = new("Inceptron");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName InferactVLLM { get; } = new("Inferact vLLM");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName InferenceNet { get; } = new("InferenceNet");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Infermatic { get; } = new("Infermatic");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Inflection { get; } = new("Inflection");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName IoNet { get; } = new("Io Net");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Ionstream { get; } = new("Ionstream");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Krea { get; } = new("Krea");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Liquid { get; } = new("Liquid");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Makora { get; } = new("Makora");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Mancer2 { get; } = new("Mancer 2");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Mara { get; } = new("Mara");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Meta { get; } = new("Meta");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Minimax { get; } = new("Minimax");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Mistral { get; } = new("Mistral");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Modal { get; } = new("Modal");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName ModelRun { get; } = new("ModelRun");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Modular { get; } = new("Modular");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName MoonshotAi { get; } = new("Moonshot AI");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Morph { get; } = new("Morph");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName NearAi { get; } = new("Near AI");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Nebius { get; } = new("Nebius");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName NexAgi { get; } = new("Nex AGI");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName NextBit { get; } = new("NextBit");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Novita { get; } = new("Novita");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Nvidia { get; } = new("Nvidia");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Ollama { get; } = new("Ollama");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName OpenAI { get; } = new("OpenAI");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName OpenInference { get; } = new("OpenInference");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Parasail { get; } = new("Parasail");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Perceptron { get; } = new("Perceptron");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Perplexity { get; } = new("Perplexity");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Phala { get; } = new("Phala");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Poolside { get; } = new("Poolside");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName PrimeIntellect { get; } = new("PrimeIntellect");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Quiver { get; } = new("Quiver");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Recraft { get; } = new("Recraft");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Reka { get; } = new("Reka");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Relace { get; } = new("Relace");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Respan { get; } = new("Respan");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Runway { get; } = new("Runway");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName SailResearch { get; } = new("Sail Research");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName SakanaAi { get; } = new("Sakana AI");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName SambaNova { get; } = new("SambaNova");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName ScaleDown { get; } = new("ScaleDown");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Seed { get; } = new("Seed");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName SiliconFlow { get; } = new("SiliconFlow");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Sourceful { get; } = new("Sourceful");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Stealth { get; } = new("Stealth");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName StepFun { get; } = new("StepFun");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName StreamLake { get; } = new("StreamLake");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Switchpoint { get; } = new("Switchpoint");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Tencent { get; } = new("Tencent");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Tenstorrent { get; } = new("Tenstorrent");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName ThinkingMachines { get; } = new("Thinking Machines");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Together { get; } = new("Together");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName TypeSafe { get; } = new("TypeSafe");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Unbiased { get; } = new("Unbiased");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Upstage { get; } = new("Upstage");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Venice { get; } = new("Venice");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName VoyageAIByMongoDB { get; } = new("VoyageAI by MongoDB");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Wafer { get; } = new("Wafer");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName WandB { get; } = new("WandB");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Xiaomi { get; } = new("Xiaomi");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName ZAi { get; } = new("Z.AI");

        /// <summary>
        ///
        /// </summary>
        public static ProviderName Xai { get; } = new("xAI");
        /// <summary>
        ///
        /// </summary>
        public static ProviderName FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "AI21" => Ai21,
                "AionLabs" => AionLabs,
                "AkashML" => AkashML,
                "Alibaba" => Alibaba,
                "Amazon Bedrock" => AmazonBedrock,
                "Amazon Nova" => AmazonNova,
                "Ambient" => Ambient,
                "Anthropic" => Anthropic,
                "Arcee AI" => ArceeAi,
                "AssemblyAI" => AssemblyAI,
                "AtlasCloud" => AtlasCloud,
                "Avian" => Avian,
                "Azure" => Azure,
                "Baidu" => Baidu,
                "BaseTen" => BaseTen,
                "Black Forest Labs" => BlackForestLabs,
                "BytePlus" => BytePlus,
                "Cerebras" => Cerebras,
                "Chutes" => Chutes,
                "Cirrascale" => Cirrascale,
                "Clarifai" => Clarifai,
                "Claude Platform on AWS" => ClaudePlatformOnAws,
                "Cloudflare" => Cloudflare,
                "Cohere" => Cohere,
                "CoreWeave" => CoreWeave,
                "Cosine" => Cosine,
                "Crucible" => Crucible,
                "Crusoe" => Crusoe,
                "Darkbloom" => Darkbloom,
                "Databricks" => Databricks,
                "Decart" => Decart,
                "DeepInfra" => DeepInfra,
                "DeepSeek" => DeepSeek,
                "Deepgram" => Deepgram,
                "DekaLLM" => DekaLLM,
                "DigitalOcean" => DigitalOcean,
                "ElevenLabs" => ElevenLabs,
                "FakeProvider" => FakeProvider,
                "Featherless" => Featherless,
                "Fireworks" => Fireworks,
                "Fish Audio" => FishAudio,
                "Friendli" => Friendli,
                "GMICloud" => GMICloud,
                "Google" => Google,
                "Google AI Studio" => GoogleAiStudio,
                "Groq" => Groq,
                "HeyGen" => HeyGen,
                "Inception" => Inception,
                "Inceptron" => Inceptron,
                "Inferact vLLM" => InferactVLLM,
                "InferenceNet" => InferenceNet,
                "Infermatic" => Infermatic,
                "Inflection" => Inflection,
                "Io Net" => IoNet,
                "Ionstream" => Ionstream,
                "Krea" => Krea,
                "Liquid" => Liquid,
                "Makora" => Makora,
                "Mancer 2" => Mancer2,
                "Mara" => Mara,
                "Meta" => Meta,
                "Minimax" => Minimax,
                "Mistral" => Mistral,
                "Modal" => Modal,
                "ModelRun" => ModelRun,
                "Modular" => Modular,
                "Moonshot AI" => MoonshotAi,
                "Morph" => Morph,
                "Near AI" => NearAi,
                "Nebius" => Nebius,
                "Nex AGI" => NexAgi,
                "NextBit" => NextBit,
                "Novita" => Novita,
                "Nvidia" => Nvidia,
                "Ollama" => Ollama,
                "OpenAI" => OpenAI,
                "OpenInference" => OpenInference,
                "Parasail" => Parasail,
                "Perceptron" => Perceptron,
                "Perplexity" => Perplexity,
                "Phala" => Phala,
                "Poolside" => Poolside,
                "PrimeIntellect" => PrimeIntellect,
                "Quiver" => Quiver,
                "Recraft" => Recraft,
                "Reka" => Reka,
                "Relace" => Relace,
                "Respan" => Respan,
                "Runway" => Runway,
                "Sail Research" => SailResearch,
                "Sakana AI" => SakanaAi,
                "SambaNova" => SambaNova,
                "ScaleDown" => ScaleDown,
                "Seed" => Seed,
                "SiliconFlow" => SiliconFlow,
                "Sourceful" => Sourceful,
                "Stealth" => Stealth,
                "StepFun" => StepFun,
                "StreamLake" => StreamLake,
                "Switchpoint" => Switchpoint,
                "Tencent" => Tencent,
                "Tenstorrent" => Tenstorrent,
                "Thinking Machines" => ThinkingMachines,
                "Together" => Together,
                "TypeSafe" => TypeSafe,
                "Unbiased" => Unbiased,
                "Upstage" => Upstage,
                "Venice" => Venice,
                "VoyageAI by MongoDB" => VoyageAIByMongoDB,
                "Wafer" => Wafer,
                "WandB" => WandB,
                "Xiaomi" => Xiaomi,
                "Z.AI" => ZAi,
                "xAI" => Xai,
                _ => new ProviderName(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "AI21" => true,
            "AionLabs" => true,
            "AkashML" => true,
            "Alibaba" => true,
            "Amazon Bedrock" => true,
            "Amazon Nova" => true,
            "Ambient" => true,
            "Anthropic" => true,
            "Arcee AI" => true,
            "AssemblyAI" => true,
            "AtlasCloud" => true,
            "Avian" => true,
            "Azure" => true,
            "Baidu" => true,
            "BaseTen" => true,
            "Black Forest Labs" => true,
            "BytePlus" => true,
            "Cerebras" => true,
            "Chutes" => true,
            "Cirrascale" => true,
            "Clarifai" => true,
            "Claude Platform on AWS" => true,
            "Cloudflare" => true,
            "Cohere" => true,
            "CoreWeave" => true,
            "Cosine" => true,
            "Crucible" => true,
            "Crusoe" => true,
            "Darkbloom" => true,
            "Databricks" => true,
            "Decart" => true,
            "DeepInfra" => true,
            "DeepSeek" => true,
            "Deepgram" => true,
            "DekaLLM" => true,
            "DigitalOcean" => true,
            "ElevenLabs" => true,
            "FakeProvider" => true,
            "Featherless" => true,
            "Fireworks" => true,
            "Fish Audio" => true,
            "Friendli" => true,
            "GMICloud" => true,
            "Google" => true,
            "Google AI Studio" => true,
            "Groq" => true,
            "HeyGen" => true,
            "Inception" => true,
            "Inceptron" => true,
            "Inferact vLLM" => true,
            "InferenceNet" => true,
            "Infermatic" => true,
            "Inflection" => true,
            "Io Net" => true,
            "Ionstream" => true,
            "Krea" => true,
            "Liquid" => true,
            "Makora" => true,
            "Mancer 2" => true,
            "Mara" => true,
            "Meta" => true,
            "Minimax" => true,
            "Mistral" => true,
            "Modal" => true,
            "ModelRun" => true,
            "Modular" => true,
            "Moonshot AI" => true,
            "Morph" => true,
            "Near AI" => true,
            "Nebius" => true,
            "Nex AGI" => true,
            "NextBit" => true,
            "Novita" => true,
            "Nvidia" => true,
            "Ollama" => true,
            "OpenAI" => true,
            "OpenInference" => true,
            "Parasail" => true,
            "Perceptron" => true,
            "Perplexity" => true,
            "Phala" => true,
            "Poolside" => true,
            "PrimeIntellect" => true,
            "Quiver" => true,
            "Recraft" => true,
            "Reka" => true,
            "Relace" => true,
            "Respan" => true,
            "Runway" => true,
            "Sail Research" => true,
            "Sakana AI" => true,
            "SambaNova" => true,
            "ScaleDown" => true,
            "Seed" => true,
            "SiliconFlow" => true,
            "Sourceful" => true,
            "Stealth" => true,
            "StepFun" => true,
            "StreamLake" => true,
            "Switchpoint" => true,
            "Tencent" => true,
            "Tenstorrent" => true,
            "Thinking Machines" => true,
            "Together" => true,
            "TypeSafe" => true,
            "Unbiased" => true,
            "Upstage" => true,
            "Venice" => true,
            "VoyageAI by MongoDB" => true,
            "Wafer" => true,
            "WandB" => true,
            "Xiaomi" => true,
            "Z.AI" => true,
            "xAI" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ProviderName other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProviderName other && Equals(other);
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
        public static bool operator ==(ProviderName left, ProviderName right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ProviderName left, ProviderName right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderName value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderName? ToEnum(string value)
        {
            return ProviderName.FromValue(value);
        }
    }
}