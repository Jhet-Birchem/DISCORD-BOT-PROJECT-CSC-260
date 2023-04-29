using Newtonsoft.Json;

namespace Drama_Bot_V2
{
    internal struct ConfigJSON
    {
        [JsonProperty("token")]
        public string Token { get; private set; }

        [JsonProperty("prefix")]
        public string Prefix { get; private set; }
    }
}
