using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.OpenAI.Domain.Responses.Chat
{
    internal class ChatResponse : BaseResponse
    {
        List<ChatChoisesResponse> ChatChoisesResponse { get; set; }
    }
}
