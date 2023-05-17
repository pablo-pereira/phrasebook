using System.Text.Json.Serialization;

namespace Services.OpenAI.Domain.Responses
{
    internal class Error
    {
        [JsonPropertyName("Code")]
        public string? Code { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }

        [JsonPropertyName("param")]
        public string? Param { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
