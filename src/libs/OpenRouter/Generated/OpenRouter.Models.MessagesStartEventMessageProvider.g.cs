
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct MessagesStartEventMessageProvider : global::System.IEquatable<MessagesStartEventMessageProvider>
    {
        /// <summary>
        ///
        /// </summary>
        public MessagesStartEventMessageProvider(string value)
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
        public static MessagesStartEventMessageProvider x01Ai { get; } = new("01.AI");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Ai21 { get; } = new("AI21");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider AionLabs { get; } = new("AionLabs");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider AkashML { get; } = new("AkashML");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Alibaba { get; } = new("Alibaba");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider AmazonBedrock { get; } = new("Amazon Bedrock");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider AmazonNova { get; } = new("Amazon Nova");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Ambient { get; } = new("Ambient");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Anthropic { get; } = new("Anthropic");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider AnyScale { get; } = new("AnyScale");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider ArceeAi { get; } = new("Arcee AI");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider AssemblyAI { get; } = new("AssemblyAI");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider AtlasCloud { get; } = new("AtlasCloud");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Atoma { get; } = new("Atoma");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Avian { get; } = new("Avian");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Azure { get; } = new("Azure");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Baidu { get; } = new("Baidu");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider BaseTen { get; } = new("BaseTen");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider BlackForestLabs { get; } = new("Black Forest Labs");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider BytePlus { get; } = new("BytePlus");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider CentMl { get; } = new("Cent-ML");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Cerebras { get; } = new("Cerebras");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Chutes { get; } = new("Chutes");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Cirrascale { get; } = new("Cirrascale");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Clarifai { get; } = new("Clarifai");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider ClaudePlatformOnAws { get; } = new("Claude Platform on AWS");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Cloudflare { get; } = new("Cloudflare");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Cohere { get; } = new("Cohere");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider CoreWeave { get; } = new("CoreWeave");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Cosine { get; } = new("Cosine");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider CrofAI { get; } = new("CrofAI");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Crucible { get; } = new("Crucible");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Crusoe { get; } = new("Crusoe");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Darkbloom { get; } = new("Darkbloom");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Databricks { get; } = new("Databricks");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Decart { get; } = new("Decart");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider DeepInfra { get; } = new("DeepInfra");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider DeepSeek { get; } = new("DeepSeek");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Deepgram { get; } = new("Deepgram");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider DekaLLM { get; } = new("DekaLLM");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider DigitalOcean { get; } = new("DigitalOcean");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider ElevenLabs { get; } = new("ElevenLabs");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Enfer { get; } = new("Enfer");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider FakeProvider { get; } = new("FakeProvider");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Featherless { get; } = new("Featherless");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Fireworks { get; } = new("Fireworks");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider FishAudio { get; } = new("Fish Audio");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Friendli { get; } = new("Friendli");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider GMICloud { get; } = new("GMICloud");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider GoPomelo { get; } = new("GoPomelo");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Google { get; } = new("Google");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider GoogleAiStudio { get; } = new("Google AI Studio");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Groq { get; } = new("Groq");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider HeyGen { get; } = new("HeyGen");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider HuggingFace { get; } = new("HuggingFace");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Hyperbolic { get; } = new("Hyperbolic");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Hyperbolic2 { get; } = new("Hyperbolic 2");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Inception { get; } = new("Inception");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Inceptron { get; } = new("Inceptron");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider InferactVLLM { get; } = new("Inferact vLLM");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider InferenceNet { get; } = new("InferenceNet");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Infermatic { get; } = new("Infermatic");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Inflection { get; } = new("Inflection");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider InoCloud { get; } = new("InoCloud");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider IoNet { get; } = new("Io Net");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Ionstream { get; } = new("Ionstream");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Kluster { get; } = new("Kluster");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Krea { get; } = new("Krea");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Lambda { get; } = new("Lambda");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Lepton { get; } = new("Lepton");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Liquid { get; } = new("Liquid");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Lynn { get; } = new("Lynn");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Lynn2 { get; } = new("Lynn 2");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Makora { get; } = new("Makora");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Mancer { get; } = new("Mancer");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Mancer2 { get; } = new("Mancer 2");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Mara { get; } = new("Mara");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Meta { get; } = new("Meta");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Minimax { get; } = new("Minimax");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Mistral { get; } = new("Mistral");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Modal { get; } = new("Modal");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider ModelRun { get; } = new("ModelRun");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Modular { get; } = new("Modular");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider MoonshotAi { get; } = new("Moonshot AI");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Morph { get; } = new("Morph");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider NCompass { get; } = new("NCompass");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider NearAi { get; } = new("Near AI");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Nebius { get; } = new("Nebius");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider NexAgi { get; } = new("Nex AGI");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider NextBit { get; } = new("NextBit");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Nineteen { get; } = new("Nineteen");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Novita { get; } = new("Novita");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Nvidia { get; } = new("Nvidia");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider OctoAI { get; } = new("OctoAI");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Ollama { get; } = new("Ollama");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider OpenAI { get; } = new("OpenAI");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider OpenInference { get; } = new("OpenInference");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Parasail { get; } = new("Parasail");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Perceptron { get; } = new("Perceptron");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Perplexity { get; } = new("Perplexity");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Phala { get; } = new("Phala");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Poolside { get; } = new("Poolside");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider PrimeIntellect { get; } = new("PrimeIntellect");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Quiver { get; } = new("Quiver");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Recraft { get; } = new("Recraft");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Recursal { get; } = new("Recursal");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Reflection { get; } = new("Reflection");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Reka { get; } = new("Reka");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Relace { get; } = new("Relace");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Replicate { get; } = new("Replicate");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Respan { get; } = new("Respan");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Runway { get; } = new("Runway");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider SfCompute { get; } = new("SF Compute");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider SailResearch { get; } = new("Sail Research");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider SakanaAi { get; } = new("Sakana AI");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider SambaNova { get; } = new("SambaNova");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider SambaNova2 { get; } = new("SambaNova 2");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider ScaleDown { get; } = new("ScaleDown");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Seed { get; } = new("Seed");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider SiliconFlow { get; } = new("SiliconFlow");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Sourceful { get; } = new("Sourceful");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Stealth { get; } = new("Stealth");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider StepFun { get; } = new("StepFun");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider StreamLake { get; } = new("StreamLake");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Switchpoint { get; } = new("Switchpoint");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Targon { get; } = new("Targon");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Tencent { get; } = new("Tencent");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Tenstorrent { get; } = new("Tenstorrent");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider ThinkingMachines { get; } = new("Thinking Machines");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Together { get; } = new("Together");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Together2 { get; } = new("Together 2");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider TypeSafe { get; } = new("TypeSafe");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Ubicloud { get; } = new("Ubicloud");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Unbiased { get; } = new("Unbiased");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Upstage { get; } = new("Upstage");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Venice { get; } = new("Venice");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider VoyageAIByMongoDB { get; } = new("VoyageAI by MongoDB");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Wafer { get; } = new("Wafer");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider WandB { get; } = new("WandB");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Xiaomi { get; } = new("Xiaomi");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider ZAi { get; } = new("Z.AI");

        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider Xai { get; } = new("xAI");
        /// <summary>
        ///
        /// </summary>
        public static MessagesStartEventMessageProvider FromValue(string value)
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
                _ => new MessagesStartEventMessageProvider(value),
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
        public bool Equals(MessagesStartEventMessageProvider other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesStartEventMessageProvider other && Equals(other);
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
        public static bool operator ==(MessagesStartEventMessageProvider left, MessagesStartEventMessageProvider right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(MessagesStartEventMessageProvider left, MessagesStartEventMessageProvider right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesStartEventMessageProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesStartEventMessageProvider value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesStartEventMessageProvider? ToEnum(string value)
        {
            return MessagesStartEventMessageProvider.FromValue(value);
        }
    }
}