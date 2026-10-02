
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Name of the provider<br/>
    /// Example: OpenAI
    /// </summary>
    public readonly partial struct ProviderResponseProviderName : global::System.IEquatable<ProviderResponseProviderName>
    {
        /// <summary>
        ///
        /// </summary>
        public ProviderResponseProviderName(string value)
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
        public static ProviderResponseProviderName x01Ai { get; } = new("01.AI");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Ai21 { get; } = new("AI21");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName AionLabs { get; } = new("AionLabs");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName AkashML { get; } = new("AkashML");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Alibaba { get; } = new("Alibaba");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName AmazonBedrock { get; } = new("Amazon Bedrock");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName AmazonNova { get; } = new("Amazon Nova");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Ambient { get; } = new("Ambient");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Anthropic { get; } = new("Anthropic");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName AnyScale { get; } = new("AnyScale");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName ArceeAi { get; } = new("Arcee AI");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName AssemblyAI { get; } = new("AssemblyAI");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName AtlasCloud { get; } = new("AtlasCloud");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Atoma { get; } = new("Atoma");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Avian { get; } = new("Avian");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Azure { get; } = new("Azure");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Baidu { get; } = new("Baidu");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName BaseTen { get; } = new("BaseTen");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName BlackForestLabs { get; } = new("Black Forest Labs");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName BytePlus { get; } = new("BytePlus");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName CentMl { get; } = new("Cent-ML");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Cerebras { get; } = new("Cerebras");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Chutes { get; } = new("Chutes");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Cirrascale { get; } = new("Cirrascale");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Clarifai { get; } = new("Clarifai");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName ClaudePlatformOnAws { get; } = new("Claude Platform on AWS");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Cloudflare { get; } = new("Cloudflare");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Cohere { get; } = new("Cohere");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName CoreWeave { get; } = new("CoreWeave");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Cosine { get; } = new("Cosine");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName CrofAI { get; } = new("CrofAI");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Crucible { get; } = new("Crucible");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Crusoe { get; } = new("Crusoe");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Darkbloom { get; } = new("Darkbloom");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Databricks { get; } = new("Databricks");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Decart { get; } = new("Decart");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName DeepInfra { get; } = new("DeepInfra");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName DeepSeek { get; } = new("DeepSeek");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Deepgram { get; } = new("Deepgram");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName DekaLLM { get; } = new("DekaLLM");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName DigitalOcean { get; } = new("DigitalOcean");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName ElevenLabs { get; } = new("ElevenLabs");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Enfer { get; } = new("Enfer");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName FakeProvider { get; } = new("FakeProvider");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Featherless { get; } = new("Featherless");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Fireworks { get; } = new("Fireworks");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName FishAudio { get; } = new("Fish Audio");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Friendli { get; } = new("Friendli");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName GMICloud { get; } = new("GMICloud");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName GoPomelo { get; } = new("GoPomelo");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Google { get; } = new("Google");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName GoogleAiStudio { get; } = new("Google AI Studio");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Groq { get; } = new("Groq");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName HeyGen { get; } = new("HeyGen");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName HuggingFace { get; } = new("HuggingFace");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Hyperbolic { get; } = new("Hyperbolic");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Hyperbolic2 { get; } = new("Hyperbolic 2");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Inception { get; } = new("Inception");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Inceptron { get; } = new("Inceptron");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName InferactVLLM { get; } = new("Inferact vLLM");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName InferenceNet { get; } = new("InferenceNet");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Infermatic { get; } = new("Infermatic");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Inflection { get; } = new("Inflection");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName InoCloud { get; } = new("InoCloud");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName IoNet { get; } = new("Io Net");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Ionstream { get; } = new("Ionstream");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Kluster { get; } = new("Kluster");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Krea { get; } = new("Krea");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Lambda { get; } = new("Lambda");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Lepton { get; } = new("Lepton");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Liquid { get; } = new("Liquid");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Lynn { get; } = new("Lynn");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Lynn2 { get; } = new("Lynn 2");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Makora { get; } = new("Makora");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Mancer { get; } = new("Mancer");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Mancer2 { get; } = new("Mancer 2");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Mara { get; } = new("Mara");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Meta { get; } = new("Meta");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Minimax { get; } = new("Minimax");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Mistral { get; } = new("Mistral");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Modal { get; } = new("Modal");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName ModelRun { get; } = new("ModelRun");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Modular { get; } = new("Modular");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName MoonshotAi { get; } = new("Moonshot AI");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Morph { get; } = new("Morph");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName NCompass { get; } = new("NCompass");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName NearAi { get; } = new("Near AI");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Nebius { get; } = new("Nebius");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName NexAgi { get; } = new("Nex AGI");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName NextBit { get; } = new("NextBit");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Nineteen { get; } = new("Nineteen");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Novita { get; } = new("Novita");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Nvidia { get; } = new("Nvidia");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName OctoAI { get; } = new("OctoAI");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Ollama { get; } = new("Ollama");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName OpenAI { get; } = new("OpenAI");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName OpenInference { get; } = new("OpenInference");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Parasail { get; } = new("Parasail");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Perceptron { get; } = new("Perceptron");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Perplexity { get; } = new("Perplexity");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Phala { get; } = new("Phala");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Poolside { get; } = new("Poolside");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName PrimeIntellect { get; } = new("PrimeIntellect");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Quiver { get; } = new("Quiver");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Recraft { get; } = new("Recraft");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Recursal { get; } = new("Recursal");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Reflection { get; } = new("Reflection");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Reka { get; } = new("Reka");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Relace { get; } = new("Relace");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Replicate { get; } = new("Replicate");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Respan { get; } = new("Respan");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Runway { get; } = new("Runway");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName SfCompute { get; } = new("SF Compute");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName SailResearch { get; } = new("Sail Research");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName SakanaAi { get; } = new("Sakana AI");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName SambaNova { get; } = new("SambaNova");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName SambaNova2 { get; } = new("SambaNova 2");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName ScaleDown { get; } = new("ScaleDown");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Seed { get; } = new("Seed");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName SiliconFlow { get; } = new("SiliconFlow");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Sourceful { get; } = new("Sourceful");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Stealth { get; } = new("Stealth");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName StepFun { get; } = new("StepFun");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName StreamLake { get; } = new("StreamLake");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Switchpoint { get; } = new("Switchpoint");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Targon { get; } = new("Targon");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Tencent { get; } = new("Tencent");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Tenstorrent { get; } = new("Tenstorrent");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName ThinkingMachines { get; } = new("Thinking Machines");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Together { get; } = new("Together");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Together2 { get; } = new("Together 2");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName TypeSafe { get; } = new("TypeSafe");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Ubicloud { get; } = new("Ubicloud");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Unbiased { get; } = new("Unbiased");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Upstage { get; } = new("Upstage");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Venice { get; } = new("Venice");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName VoyageAIByMongoDB { get; } = new("VoyageAI by MongoDB");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Wafer { get; } = new("Wafer");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName WandB { get; } = new("WandB");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Xiaomi { get; } = new("Xiaomi");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName ZAi { get; } = new("Z.AI");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName Xai { get; } = new("xAI");
        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderName FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "01.AI" => x01Ai,
                "AI21" => Ai21,
                "AionLabs" => AionLabs,
                "AkashML" => AkashML,
                "Alibaba" => Alibaba,
                "Amazon Bedrock" => AmazonBedrock,
                "Amazon Nova" => AmazonNova,
                "Ambient" => Ambient,
                "Anthropic" => Anthropic,
                "AnyScale" => AnyScale,
                "Arcee AI" => ArceeAi,
                "AssemblyAI" => AssemblyAI,
                "AtlasCloud" => AtlasCloud,
                "Atoma" => Atoma,
                "Avian" => Avian,
                "Azure" => Azure,
                "Baidu" => Baidu,
                "BaseTen" => BaseTen,
                "Black Forest Labs" => BlackForestLabs,
                "BytePlus" => BytePlus,
                "Cent-ML" => CentMl,
                "Cerebras" => Cerebras,
                "Chutes" => Chutes,
                "Cirrascale" => Cirrascale,
                "Clarifai" => Clarifai,
                "Claude Platform on AWS" => ClaudePlatformOnAws,
                "Cloudflare" => Cloudflare,
                "Cohere" => Cohere,
                "CoreWeave" => CoreWeave,
                "Cosine" => Cosine,
                "CrofAI" => CrofAI,
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
                "Enfer" => Enfer,
                "FakeProvider" => FakeProvider,
                "Featherless" => Featherless,
                "Fireworks" => Fireworks,
                "Fish Audio" => FishAudio,
                "Friendli" => Friendli,
                "GMICloud" => GMICloud,
                "GoPomelo" => GoPomelo,
                "Google" => Google,
                "Google AI Studio" => GoogleAiStudio,
                "Groq" => Groq,
                "HeyGen" => HeyGen,
                "HuggingFace" => HuggingFace,
                "Hyperbolic" => Hyperbolic,
                "Hyperbolic 2" => Hyperbolic2,
                "Inception" => Inception,
                "Inceptron" => Inceptron,
                "Inferact vLLM" => InferactVLLM,
                "InferenceNet" => InferenceNet,
                "Infermatic" => Infermatic,
                "Inflection" => Inflection,
                "InoCloud" => InoCloud,
                "Io Net" => IoNet,
                "Ionstream" => Ionstream,
                "Kluster" => Kluster,
                "Krea" => Krea,
                "Lambda" => Lambda,
                "Lepton" => Lepton,
                "Liquid" => Liquid,
                "Lynn" => Lynn,
                "Lynn 2" => Lynn2,
                "Makora" => Makora,
                "Mancer" => Mancer,
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
                "NCompass" => NCompass,
                "Near AI" => NearAi,
                "Nebius" => Nebius,
                "Nex AGI" => NexAgi,
                "NextBit" => NextBit,
                "Nineteen" => Nineteen,
                "Novita" => Novita,
                "Nvidia" => Nvidia,
                "OctoAI" => OctoAI,
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
                "Recursal" => Recursal,
                "Reflection" => Reflection,
                "Reka" => Reka,
                "Relace" => Relace,
                "Replicate" => Replicate,
                "Respan" => Respan,
                "Runway" => Runway,
                "SF Compute" => SfCompute,
                "Sail Research" => SailResearch,
                "Sakana AI" => SakanaAi,
                "SambaNova" => SambaNova,
                "SambaNova 2" => SambaNova2,
                "ScaleDown" => ScaleDown,
                "Seed" => Seed,
                "SiliconFlow" => SiliconFlow,
                "Sourceful" => Sourceful,
                "Stealth" => Stealth,
                "StepFun" => StepFun,
                "StreamLake" => StreamLake,
                "Switchpoint" => Switchpoint,
                "Targon" => Targon,
                "Tencent" => Tencent,
                "Tenstorrent" => Tenstorrent,
                "Thinking Machines" => ThinkingMachines,
                "Together" => Together,
                "Together 2" => Together2,
                "TypeSafe" => TypeSafe,
                "Ubicloud" => Ubicloud,
                "Unbiased" => Unbiased,
                "Upstage" => Upstage,
                "Venice" => Venice,
                "VoyageAI by MongoDB" => VoyageAIByMongoDB,
                "Wafer" => Wafer,
                "WandB" => WandB,
                "Xiaomi" => Xiaomi,
                "Z.AI" => ZAi,
                "xAI" => Xai,
                _ => new ProviderResponseProviderName(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "01.AI" => true,
            "AI21" => true,
            "AionLabs" => true,
            "AkashML" => true,
            "Alibaba" => true,
            "Amazon Bedrock" => true,
            "Amazon Nova" => true,
            "Ambient" => true,
            "Anthropic" => true,
            "AnyScale" => true,
            "Arcee AI" => true,
            "AssemblyAI" => true,
            "AtlasCloud" => true,
            "Atoma" => true,
            "Avian" => true,
            "Azure" => true,
            "Baidu" => true,
            "BaseTen" => true,
            "Black Forest Labs" => true,
            "BytePlus" => true,
            "Cent-ML" => true,
            "Cerebras" => true,
            "Chutes" => true,
            "Cirrascale" => true,
            "Clarifai" => true,
            "Claude Platform on AWS" => true,
            "Cloudflare" => true,
            "Cohere" => true,
            "CoreWeave" => true,
            "Cosine" => true,
            "CrofAI" => true,
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
            "Enfer" => true,
            "FakeProvider" => true,
            "Featherless" => true,
            "Fireworks" => true,
            "Fish Audio" => true,
            "Friendli" => true,
            "GMICloud" => true,
            "GoPomelo" => true,
            "Google" => true,
            "Google AI Studio" => true,
            "Groq" => true,
            "HeyGen" => true,
            "HuggingFace" => true,
            "Hyperbolic" => true,
            "Hyperbolic 2" => true,
            "Inception" => true,
            "Inceptron" => true,
            "Inferact vLLM" => true,
            "InferenceNet" => true,
            "Infermatic" => true,
            "Inflection" => true,
            "InoCloud" => true,
            "Io Net" => true,
            "Ionstream" => true,
            "Kluster" => true,
            "Krea" => true,
            "Lambda" => true,
            "Lepton" => true,
            "Liquid" => true,
            "Lynn" => true,
            "Lynn 2" => true,
            "Makora" => true,
            "Mancer" => true,
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
            "NCompass" => true,
            "Near AI" => true,
            "Nebius" => true,
            "Nex AGI" => true,
            "NextBit" => true,
            "Nineteen" => true,
            "Novita" => true,
            "Nvidia" => true,
            "OctoAI" => true,
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
            "Recursal" => true,
            "Reflection" => true,
            "Reka" => true,
            "Relace" => true,
            "Replicate" => true,
            "Respan" => true,
            "Runway" => true,
            "SF Compute" => true,
            "Sail Research" => true,
            "Sakana AI" => true,
            "SambaNova" => true,
            "SambaNova 2" => true,
            "ScaleDown" => true,
            "Seed" => true,
            "SiliconFlow" => true,
            "Sourceful" => true,
            "Stealth" => true,
            "StepFun" => true,
            "StreamLake" => true,
            "Switchpoint" => true,
            "Targon" => true,
            "Tencent" => true,
            "Tenstorrent" => true,
            "Thinking Machines" => true,
            "Together" => true,
            "Together 2" => true,
            "TypeSafe" => true,
            "Ubicloud" => true,
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
        public bool Equals(ProviderResponseProviderName other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProviderResponseProviderName other && Equals(other);
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
        public static bool operator ==(ProviderResponseProviderName left, ProviderResponseProviderName right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ProviderResponseProviderName left, ProviderResponseProviderName right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderResponseProviderNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderResponseProviderName value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderResponseProviderName? ToEnum(string value)
        {
            return ProviderResponseProviderName.FromValue(value);
        }
    }
}