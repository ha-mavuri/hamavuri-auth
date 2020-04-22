using System;
using System.Collections.Generic;
using System.Text;

namespace hamavuri.identityserver.models
{
    public class PersistedGrant
    {
        public string Key { get; set; }
        public string Type { get; set; }
        public string SubjectId { get; set; }
        public string ClientId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime Expiration { get; set; }
        public string Data { get; set; }
    }
}