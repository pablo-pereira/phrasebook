using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.OpenAI.Domain.Responses.Completions
{

    internal class CompletionsResponse
    {        
        public CompletionsChoiceResponse[] choices { get; set; }        
    }
}
