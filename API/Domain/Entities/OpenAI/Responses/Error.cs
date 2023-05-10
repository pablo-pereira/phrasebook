using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.OpenAI.Responses
{
    internal class Error
    {
        public string Message { get; set; }
        public string Type { get; set; }
        public object Param { get; set; }
        public object Code { get; set; }
    }
}
