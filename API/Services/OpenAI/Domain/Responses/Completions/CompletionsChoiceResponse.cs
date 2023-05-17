using System.Text.Json.Serialization;

namespace Services.OpenAI.Domain.Responses.Completions
{
    internal class CompletionsChoiceResponse : BaseChoiseResponse
    {
        [JsonPropertyName("logprobs")]
        public LogprobsRsponse? LogProbs { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

}

