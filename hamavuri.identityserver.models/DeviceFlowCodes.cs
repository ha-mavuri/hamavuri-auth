using System;
using System.Collections.Generic;
using System.Text;

namespace hamavuri.identityserver.models
{
    public class DeviceFlowCodes
    {
        public string UserCode { get; set; }
        public string Code { get; set; }
        public string SubjectId { get; set; }
        public string ClientId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime Expiration { get; set; }
        public string Data { get; set; }
    }
}
