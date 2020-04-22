﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hmavuri.identityserver.Data;

namespace hmavuri.identityserver.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200421074421_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            #region Identity
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("hmavuri.identityserver.models.ApplicationRole", b =>
            {
                b.Property<Guid>("Id")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(256)")
                    .HasMaxLength(256);

                b.Property<string>("NormalizedName")
                    .HasColumnType("nvarchar(256)")
                    .HasMaxLength(256);

                b.HasKey("Id");

                b.HasIndex("NormalizedName")
                    .IsUnique()
                    .HasName("RoleNameIndex")
                    .HasFilter("[NormalizedName] IS NOT NULL");

                b.ToTable("ApplicationRoles");
            });

            modelBuilder.Entity("hmavuri.identityserver.models.ApplicationRoleClaim", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValue();

                b.Property<string>("ClaimType")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ClaimValue")
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid>("RoleId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("Id");

                b.HasIndex("RoleId");

                b.ToTable("ApplicationRoleClaims");
            });

            modelBuilder.Entity("hmavuri.identityserver.models.ApplicationUser", b =>
            {
                b.Property<Guid>("Id")
                    .HasColumnType("uniqueidentifier");

                b.Property<int>("AccessFailedCount")
                    .HasColumnType("int");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Email")
                    .HasColumnType("nvarchar(256)")
                    .HasMaxLength(256);

                b.Property<bool>("EmailConfirmed")
                    .HasColumnType("bit");

                b.Property<bool>("LockoutEnabled")
                    .HasColumnType("bit");

                b.Property<DateTimeOffset?>("LockoutEnd")
                    .HasColumnType("datetimeoffset");

                b.Property<string>("NormalizedEmail")
                    .HasColumnType("nvarchar(256)")
                    .HasMaxLength(256);

                b.Property<string>("NormalizedUserName")
                    .HasColumnType("nvarchar(256)")
                    .HasMaxLength(256);

                b.Property<string>("PasswordHash")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("PhoneNumber")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("PhoneNumberConfirmed")
                    .HasColumnType("bit");

                b.Property<string>("SecurityStamp")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("TwoFactorEnabled")
                    .HasColumnType("bit");

                b.Property<string>("UserName")
                    .HasColumnType("nvarchar(256)")
                    .HasMaxLength(256);

                b.Property<string>("FirstName")
                    .HasColumnType("nvarchar(256)")
                    .HasMaxLength(100);

                b.HasKey("Id");

                b.HasIndex("NormalizedEmail")
                    .HasName("EmailIndex");

                b.HasIndex("NormalizedUserName")
                    .IsUnique()
                    .HasName("UserNameIndex")
                    .HasFilter("[NormalizedUserName] IS NOT NULL");

                b.ToTable("ApplicationUsers");
            });

            modelBuilder.Entity("hmavuri.identityserver.models.ApplicationUserClaim", b =>
            {
                b.Property<Guid>("uniqueidentifier")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValue();

                b.Property<string>("ClaimType")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ClaimValue")
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid>("UserId")
                    .IsRequired()
                    .HasColumnType("uniqueidentifier");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("ApplicationUserClaims");
            });

            modelBuilder.Entity("hmavuri.identityserver.models.ApplicationUserLogin", b =>
            {
                b.Property<string>("LoginProvider")
                    .HasColumnType("nvarchar(128)")
                    .HasMaxLength(128);

                b.Property<string>("ProviderKey")
                    .HasColumnType("nvarchar(128)")
                    .HasMaxLength(128);

                b.Property<string>("ProviderDisplayName")
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid>("UserId")
                    .IsRequired()
                    .HasColumnType("uniqueidentifier");

                b.HasKey("LoginProvider", "ProviderKey");

                b.HasIndex("UserId");

                b.ToTable("ApplicationUserLogins");
            });

            modelBuilder.Entity("hmavuri.identityserver.models.ApplicationUserRole", b =>
            {
                b.Property<Guid>("UserId")
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("RoleId")
                    .HasColumnType("uniqueidentifier");

                b.HasKey("UserId", "RoleId");

                b.HasIndex("RoleId");

                b.ToTable("ApplicationUserRoles");
            });

            modelBuilder.Entity("hmavuri.identityserver.models.ApplicationUserToken", b =>
            {
                b.Property<Guid>("UserId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("LoginProvider")
                    .HasColumnType("nvarchar(128)")
                    .HasMaxLength(128);

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(128)")
                    .HasMaxLength(128);

                b.Property<string>("Value")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("UserId", "LoginProvider", "Name");

                b.ToTable("ApplicationUserTokens");
            });

            modelBuilder.Entity("hmavuri.identityserver.models.ApplicationRoleClaim", b =>
            {
                b.HasOne("hmavuri.identityserver.models.ApplicationRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("hmavuri.identityserver.models.ApplicationUserClaim", b =>
            {
                b.HasOne("hmavuri.identityserver.models.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("hmavuri.identityserver.models.ApplicationUserLogin", b =>
            {
                b.HasOne("hmavuri.identityserver.models.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("hmavuri.identityserver.models.ApplicationUserRole", b =>
            {
                b.HasOne("hmavuri.identityserver.models.ApplicationRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("hmavuri.identityserver.models.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("hmavuri.identityserver.models.ApplicationUserToken", b =>
            {
                b.HasOne("hmavuri.identityserver.models.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            #endregion 

            modelBuilder.Entity("hamavuri.identityserver.models.DeviceFlowCodes", b =>
            {
                b.Property<string>("UserCode")
                    .HasColumnType("nvarchar(200)")
                    .HasMaxLength(200);

                b.Property<string>("ClientId")
                    .IsRequired()
                    .HasColumnType("nvarchar(200)")
                    .HasMaxLength(200);

                b.Property<DateTimeOffset>("CreationTime")
                    .HasColumnType("datetimeoffset");

                b.Property<string>("Data")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)")
                    .HasMaxLength(50000);

                b.Property<string>("DeviceCode")
                    .IsRequired()
                    .HasColumnType("nvarchar(200)")
                    .HasMaxLength(200);

                b.Property<DateTimeOffset?>("Expiration")
                    .IsRequired()
                    .HasColumnType("datetimeoffset");

                b.Property<string>("SubjectId")
                    .HasColumnType("nvarchar(200)")
                    .HasMaxLength(200);

                b.HasKey("UserCode");

                b.HasIndex("DeviceCode")
                    .IsUnique();

                b.HasIndex("Expiration");

                b.ToTable("DeviceCodes");
            });

            modelBuilder.Entity("hamavuri.identityserver.models.PersistedGrant", b =>
            {
                b.Property<string>("Key")
                    .HasColumnType("nvarchar(200)")
                    .HasMaxLength(200);

                b.Property<string>("ClientId")
                    .IsRequired()
                    .HasColumnType("nvarchar(200)")
                    .HasMaxLength(200);

                b.Property<DateTimeOffset>("CreationTime")
                    .HasColumnType("datetimeoffset");

                b.Property<string>("Data")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)")
                    .HasMaxLength(50000);

                b.Property<DateTimeOffset?>("Expiration")
                    .HasColumnType("datetimeoffset");

                b.Property<string>("SubjectId")
                    .HasColumnType("nvarchar(200)")
                    .HasMaxLength(200);

                b.Property<string>("Type")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasMaxLength(50);

                b.HasKey("Key");

                b.HasIndex("Expiration");

                b.HasIndex("SubjectId", "ClientId", "Type");

                b.ToTable("PersistedGrants");
            });

            #region Client
            modelBuilder.Entity("hamavuri.identityserver.models.ApiResource", b =>
            {
                b.Property<int>("Id")
                    .HasColumnType("int")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Description")
                    .HasColumnType("nvarchar(1000)")
                    .HasMaxLength(1000);

                b.Property<string>("DisplayName")
                    .HasColumnType("nvarchar(200)")
                    .HasMaxLength(200);

                b.Property<bool>("Enabled")
                    .HasColumnType("bit");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(200)")
                    .IsRequired()
                    .HasMaxLength(200);

                b.HasKey("Id");

                b.HasIndex("Name")
                    .HasName("ApiResourceNameIndex")
                    .HasFilter("[Name] IS NOT NULL")
                    .IsUnique();

                b.ToTable("ApiResources");
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ApiResourceClaim", b =>
            {
                b.Property<int>("Id")
                    .HasColumnType("int")
                    .ValueGeneratedOnAdd();

                b.Property<int?>("ApiResourceId")
                    .HasColumnType("int")
                    .IsRequired();

                b.Property<string>("Type")
                    .HasColumnType("nvarchar(200)")
                    .IsRequired()
                    .HasMaxLength(200);

                b.HasKey("Id");

                b.HasIndex("ApiResourceId");

                b.ToTable("ApiClaims");
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ApiScope", b =>
            {
                b.Property<int>("Id")
                    .HasColumnType("int")
                    .ValueGeneratedOnAdd();

                b.Property<int?>("ApiResourceId")
                    .HasColumnType("int")
                    .IsRequired();

                b.Property<string>("Description")
                    .HasColumnType("nvarchar(1000)")
                    .HasMaxLength(1000);

                b.Property<string>("DisplayName")
                .HasColumnType("nvarchar(200)")
                    .HasMaxLength(200);

                b.Property<bool>("Emphasize")
                    .HasColumnType("bit");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(200)")
                    .IsRequired()
                    .HasMaxLength(200);

                b.Property<bool>("Required");

                b.Property<bool>("ShowInDiscoveryDocument");

                b.HasKey("Id");

                b.HasIndex("ApiResourceId");

                b.HasIndex("Name")
                    .IsUnique();

                b.ToTable("ApiScopes");
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ApiScopeClaim", b =>
            {
                b.Property<int>("Id")
                    .HasColumnType("int");

                b.Property<int?>("ApiScopeId")
                    .HasColumnType("int")
                    .IsRequired();

                b.Property<string>("Type")
                    .HasColumnType("nvarchar(200)")
                    .IsRequired()
                    .HasMaxLength(200);

                b.HasKey("Id");

                b.HasIndex("ApiScopeId");

                b.ToTable("ApiScopeClaims");
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ApiSecret", b =>
            {
                b.Property<int>("Id")
                    .HasColumnType("int")
                    .ValueGeneratedOnAdd();

                b.Property<int?>("ApiResourceId")
                    .HasColumnType("int")
                    .IsRequired();

                b.Property<string>("Description")
                    .HasColumnType("nvarchar(1000)")
                    .HasMaxLength(1000);

                b.Property<DateTimeOffset?>("Expiration")
                    .HasColumnType("datetimeoffset");

                b.Property<string>("Type")
                    .HasColumnType("nvarchar(250)")
                    .HasMaxLength(250);

                b.Property<string>("Value")
                    .HasColumnType("nvarchar(2000)")
                    .HasMaxLength(2000);

                b.HasKey("Id");

                b.HasIndex("ApiResourceId");

                b.ToTable("ApiSecrets");
            });

            modelBuilder.Entity("hamavuri.identityserver.models.Client", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<int>("AbsoluteRefreshTokenLifetime");

                b.Property<int>("AccessTokenLifetime");

                b.Property<int>("AccessTokenType");

                b.Property<bool>("AllowAccessTokensViaBrowser");

                b.Property<bool>("AllowOfflineAccess");

                b.Property<bool>("AllowPlainTextPkce");

                b.Property<bool>("AllowRememberConsent");

                b.Property<bool>("AlwaysIncludeUserClaimsInIdToken");

                b.Property<bool>("AlwaysSendClientClaims");

                b.Property<int>("AuthorizationCodeLifetime");

                b.Property<bool>("BackChannelLogoutSessionRequired");

                b.Property<string>("BackChannelLogoutUri")
                    .HasMaxLength(2000);

                b.Property<string>("ClientClaimsPrefix")
                    .HasMaxLength(200);

                b.Property<string>("ClientId")
                    .IsRequired()
                    .HasMaxLength(200);

                b.Property<string>("ClientName")
                    .HasMaxLength(200);

                b.Property<string>("ClientUri")
                    .HasMaxLength(2000);

                b.Property<int?>("ConsentLifetime");

                b.Property<string>("Description")
                    .HasMaxLength(1000);

                b.Property<bool>("EnableLocalLogin");

                b.Property<bool>("Enabled");

                b.Property<bool>("FrontChannelLogoutSessionRequired");

                b.Property<string>("FrontChannelLogoutUri")
                    .HasMaxLength(2000);

                b.Property<int>("IdentityTokenLifetime");

                b.Property<bool>("IncludeJwtId");

                b.Property<string>("LogoUri")
                    .HasMaxLength(2000);

                b.Property<string>("PairWiseSubjectSalt")
                    .HasMaxLength(200);

                b.Property<string>("ProtocolType")
                    .IsRequired()
                    .HasMaxLength(200);

                b.Property<int>("RefreshTokenExpiration");

                b.Property<int>("RefreshTokenUsage");

                b.Property<bool>("RequireClientSecret");

                b.Property<bool>("RequireConsent");

                b.Property<bool>("RequirePkce");

                b.Property<int>("SlidingRefreshTokenLifetime");

                b.Property<bool>("UpdateAccessTokenClaimsOnRefresh");

                b.HasKey("Id");

                b.HasIndex("ClientId")
                    .IsUnique();

                b.ToTable("Clients");
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ClientClaim", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<int?>("ClientId")
                    .IsRequired();

                b.Property<string>("Type")
                    .IsRequired()
                    .HasMaxLength(250);

                b.Property<string>("Value")
                    .IsRequired()
                    .HasMaxLength(250);

                b.HasKey("Id");

                b.HasIndex("ClientId");

                b.ToTable("ClientClaims");
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ClientCorsOrigin", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<int?>("ClientId")
                    .IsRequired();

                b.Property<string>("Origin")
                    .IsRequired()
                    .HasMaxLength(150);

                b.HasKey("Id");

                b.HasIndex("ClientId");

                b.ToTable("ClientCorsOrigins");
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ClientGrantType", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<int?>("ClientId")
                    .IsRequired();

                b.Property<string>("GrantType")
                    .IsRequired()
                    .HasMaxLength(250);

                b.HasKey("Id");

                b.HasIndex("ClientId");

                b.ToTable("ClientGrantTypes");
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ClientIdPRestriction", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<int?>("ClientId")
                    .IsRequired();

                b.Property<string>("Provider")
                    .IsRequired()
                    .HasMaxLength(200);

                b.HasKey("Id");

                b.HasIndex("ClientId");

                b.ToTable("ClientIdPRestrictions");
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ClientPostLogoutRedirectUri", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<int?>("ClientId")
                    .IsRequired();

                b.Property<string>("PostLogoutRedirectUri")
                    .IsRequired()
                    .HasMaxLength(2000);

                b.HasKey("Id");

                b.HasIndex("ClientId");

                b.ToTable("ClientPostLogoutRedirectUris");
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ClientProperty", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<int?>("ClientId")
                    .IsRequired();

                b.Property<string>("Key")
                    .IsRequired()
                    .HasMaxLength(250);

                b.Property<string>("Value")
                    .IsRequired()
                    .HasMaxLength(2000);

                b.HasKey("Id");

                b.HasIndex("ClientId");

                b.ToTable("ClientProperties");
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ClientRedirectUri", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<int?>("ClientId")
                    .IsRequired();

                b.Property<string>("RedirectUri")
                    .IsRequired()
                    .HasMaxLength(2000);

                b.HasKey("Id");

                b.HasIndex("ClientId");

                b.ToTable("ClientRedirectUris");
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ClientScope", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<int?>("ClientId")
                    .IsRequired();

                b.Property<string>("Scope")
                    .IsRequired()
                    .HasMaxLength(200);

                b.HasKey("Id");

                b.HasIndex("ClientId");

                b.ToTable("ClientScopes");
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ClientSecret", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<int?>("ClientId")
                    .IsRequired();

                b.Property<string>("Description")
                    .HasMaxLength(2000);

                b.Property<DateTime?>("Expiration");

                b.Property<string>("Type")
                    .HasMaxLength(250);

                b.Property<string>("Value")
                    .IsRequired()
                    .HasMaxLength(2000);

                b.HasKey("Id");

                b.HasIndex("ClientId");

                b.ToTable("ClientSecrets");
            });

            modelBuilder.Entity("hamavuri.identityserver.models.IdentityClaim", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<int?>("IdentityResourceId")
                    .IsRequired();

                b.Property<string>("Type")
                    .IsRequired()
                    .HasMaxLength(200);

                b.HasKey("Id");

                b.HasIndex("IdentityResourceId");

                b.ToTable("IdentityClaims");
            });

            modelBuilder.Entity("hamavuri.identityserver.models.IdentityResource", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Description")
                    .HasMaxLength(1000);

                b.Property<string>("DisplayName")
                    .HasMaxLength(200);

                b.Property<bool>("Emphasize");

                b.Property<bool>("Enabled");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(200);

                b.Property<bool>("Required");

                b.Property<bool>("ShowInDiscoveryDocument");

                b.HasKey("Id");

                b.HasIndex("Name")
                    .IsUnique();

                b.ToTable("IdentityResources");
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ApiResourceClaim", b =>
            {
                b.HasOne("hamavuri.identityserver.models.ApiResource", "ApiResource")
                    .WithMany("UserClaims")
                    .HasForeignKey("ApiResourceId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ApiScope", b =>
            {
                b.HasOne("hamavuri.identityserver.models.ApiResource", "ApiResource")
                    .WithMany("Scopes")
                    .HasForeignKey("ApiResourceId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ApiScopeClaim", b =>
            {
                b.HasOne("hamavuri.identityserver.models.ApiScope", "ApiScope")
                    .WithMany("UserClaims")
                    .HasForeignKey("ApiScopeId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ApiSecret", b =>
            {
                b.HasOne("hamavuri.identityserver.models.ApiResource", "ApiResource")
                    .WithMany("Secrets")
                    .HasForeignKey("ApiResourceId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ClientClaim", b =>
            {
                b.HasOne("hamavuri.identityserver.models.Client", "Client")
                    .WithMany("Claims")
                    .HasForeignKey("ClientId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ClientCorsOrigin", b =>
            {
                b.HasOne("hamavuri.identityserver.models.Client", "Client")
                    .WithMany("AllowedCorsOrigins")
                    .HasForeignKey("ClientId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ClientGrantType", b =>
            {
                b.HasOne("hamavuri.identityserver.models.Client", "Client")
                    .WithMany("AllowedGrantTypes")
                    .HasForeignKey("ClientId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ClientIdPRestriction", b =>
            {
                b.HasOne("hamavuri.identityserver.models.Client", "Client")
                    .WithMany("IdentityProviderRestrictions")
                    .HasForeignKey("ClientId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ClientPostLogoutRedirectUri", b =>
            {
                b.HasOne("hamavuri.identityserver.models.Client", "Client")
                    .WithMany("PostLogoutRedirectUris")
                    .HasForeignKey("ClientId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ClientProperty", b =>
            {
                b.HasOne("hamavuri.identityserver.models.Client", "Client")
                    .WithMany("Properties")
                    .HasForeignKey("ClientId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ClientRedirectUri", b =>
            {
                b.HasOne("hamavuri.identityserver.models.Client", "Client")
                    .WithMany("RedirectUris")
                    .HasForeignKey("ClientId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ClientScope", b =>
            {
                b.HasOne("hamavuri.identityserver.models.Client", "Client")
                    .WithMany("AllowedScopes")
                    .HasForeignKey("ClientId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("hamavuri.identityserver.models.ClientSecret", b =>
            {
                b.HasOne("hamavuri.identityserver.models.Client", "Client")
                    .WithMany("ClientSecrets")
                    .HasForeignKey("ClientId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("hamavuri.identityserver.models.IdentityClaim", b =>
            {
                b.HasOne("hamavuri.identityserver.models.IdentityResource", "IdentityResource")
                    .WithMany("UserClaims")
                    .HasForeignKey("IdentityResourceId")
                    .OnDelete(DeleteBehavior.Cascade);
            });
            #endregion
        }
    }
}
