using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Services.OpenAI.Domain.Responses.Completions
{

    internal class CompletionsResponse : BaseResponse
    {
        [JsonPropertyName("choices")]
        public CompletionsChoiceResponse[] Choices { get; set; }        
    }
}
