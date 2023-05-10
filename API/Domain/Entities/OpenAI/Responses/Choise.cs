using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.OpenAI.Responses
{
    internal class Choice
    {
        public string Text { get; set; }
        public int Index { get; set; }
        public object LogProbs { get; set; }
        public string FinishReason { get; set; }
    }

}

