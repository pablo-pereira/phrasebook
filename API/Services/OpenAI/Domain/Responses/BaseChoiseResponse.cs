using System.Text.Json.Serialization;

namespace Services.OpenAI.Domain.Responses
{
    internal class BaseChoiseResponse
    {
        [JsonPropertyName("finish_reason")]
        public string FinishReason { get; set; }

        [JsonPropertyName("index")]
        public int Index { get; set; }
    }
}
