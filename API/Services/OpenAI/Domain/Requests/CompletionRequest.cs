using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Services.OpenAI.Domain.Requests
{
    internal class CompletionRequest : BaseRequest
    {
        [JsonPropertyName("prompt")]
        private object RequestPrompt {
            get
            {
                if (Prompt?.Length == 1)
                    return Prompt.FirstOrDefault();
                else
                    return Prompt;
            }
        }

        [JsonIgnore]
        public string[] Prompt { get; set; }
    }
}
