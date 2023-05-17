using System.Text.Json.Serialization;

namespace Services.OpenAI.Domain.Responses.Completions
{
    public class LogprobsRsponse
    {
        [JsonPropertyName("tokens")]
        public List<string> Tokens { get; set; }

        [JsonPropertyName("token_logprobs")]
        public float[] TokenLogProbs { get; set; }

        [JsonPropertyName("top_logprobs")]
        public IList<IDictionary<string, double>> TopLogprobs { get; set; }

        [JsonPropertyName("text_offset")]
        public List<int> TextOffsets { get; set; }
    }
}