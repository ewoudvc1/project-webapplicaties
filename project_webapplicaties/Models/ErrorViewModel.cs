using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_webapplicaties.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
