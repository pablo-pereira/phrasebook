﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Services.OpenAI.Domain.Responses.Chat
{
    internal class ChatChoisesResponse : BaseChoiseResponse
    {
        [JsonPropertyName("message")]
        MessageResponse MessageResponse { get; set; }
    }
}
