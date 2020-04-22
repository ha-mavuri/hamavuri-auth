using System;

namespace hamavuri.identityserver.models
{
    public class Client
    {
        public Guid Id { get; set; }
        public int AbsoluteRefreshTokenLifetime { get; set; }
        public int AccessTokenLifetime { get; set; }
        public int AccessTokenType { get; set; }
        public bool AllowAccessTokensViaBrowser { get; set; }
        public bool AllowOfflineAccess { get; set; }
        public bool AllowPlainTextPkce { get; set; }
        public bool AllowRememberConsent { get; set; }
        public bool AlwaysIncludeUserClaimsInIdToken { get; set; }
        public bool AlwaysSendClientClaims { get; set; }
        public int AuthorizationCodeLifetime { get; set; }
        public bool BackChannelLogoutSessionRequired { get; set; }
        public string BackChannelLogoutUri { get; set; }
        public string ClientClaimsPrefix { get; set; }
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientUri { get; set; }
        public int ConsentLifetime { get; set; }
        public string Description { get; set; }
        public bool EnableLocalLogin { get; set; }
        public bool Enabled { get; set; }
        public bool FrontChannelLogoutSessionRequired { get; set; }
        public string FrontChannelLogoutUri { get; set; }
        public int IdentityTokenLifetime { get; set; }
        public bool IncludeJwtId { get; set; }
        public string LogoUri { get; set; }
        public string PairWiseSubjectSalt { get; set; }
        public string ProtocolType { get; set; }
        public int RefreshTokenExpiration { get; set; }
        public int RefreshTokenUsage { get; set; }
        public bool RequireClientSecret { get; set; }
        public bool RequireConsent { get; set; }
        public bool RequirePkce { get; set; }
        public int SlidingRefreshTokenLifetime { get; set; }
        public bool UpdateAccessTokenClaimsOnRefresh { get; set; }
    }

    public class ClientCorsOrigin
    {
        public int Id { get; set; }
        public Guid ClientId { get; set; }
        public string Origin { get; set; }
    }

    public class ClientRedirectUri
    {
        public int Id { get; set; }
        public Guid ClientId { get; set; }
        public string RedirectUri { get; set; }
    }

    public class ClientPostLogoutRedirectUri
    {
        public int Id { get; set; }
        public Guid ClientId { get; set; }
        public string PostLogoutRedirectUri { get; set; }
    }


    public class ClientSecret
    {
        public int Id { get; set; }
        public Guid ClientId { get; set; }
        public string Description { get; set; }
        public DateTime Expiration { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }

    public class ClientScope
    {
        public int Id { get; set; }
        public Guid ClientId { get; set; }
        public string Scope { get; set; }
    }

    public class ClientProperties
    {
        public int Id { get; set; }
        public Guid ClientId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class ClientClaims
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public Guid ClientId { get; set; }
    }

    public class ClientGrantTypes
    {
        public int Id { get; set; }
        public string GrantType { get; set; }
        public Guid ClientId { get; set; }
    }

    public class ClientIdPRestrictions
    {
        public int Id { get; set; }
        public string Provider { get; set; }
        public Guid ClientId { get; set; }
    }

}
