using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.OpenAI.Domain.Responses
{
    internal class BaseResponse
    {
        public string id { get; set; }
        public string _object { get; set; }
        public int created { get; set; }
        public string model { get; set; }
        public UsageResponse usage { get; set; }
    }
}
