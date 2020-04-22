using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace hamavuri.identityserver.models
{
    public class ApiResource
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }

    public class ApiClaims
    {
        public int Id { get; set; }
        public int ApiResourceId { get; set; }
        public string Type { get; set; }
    }

    public class ApiScopes
    {
        public int Id { get; set; }
        public int ApiResourceId { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public bool Emphasize { get; set; }
        public bool Enabled { get; set; }
        public string Name { get; set; }
        public bool Required { get; set; }
        public bool ShowInDiscoveryDocument { get; set; }
    }

    public class ApiSecrets
    {
        public int Id { get; set; }
        public int ApiResourceId { get; set; }
        public string Description { get; set; }
        public DateTime Expiration { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }

    public class ApiScopeClaims
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int ApiScopeId { get; set; }
    }
}
