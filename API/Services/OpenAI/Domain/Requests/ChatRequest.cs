using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Services.OpenAI.Domain.Requests
{
    internal class ChatRequest : BaseRequest
    {
        [JsonPropertyName("messages")]
        public IList<ChatMessage> Messages { get; set; }

    }

    internal class ChatMessage
    {
        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

    }
}
