using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer
{
    public static class Configuration
    {

        public static IEnumerable<IdentityResource> GetIdentityResources()
          => new List<IdentityResource>()
          {
             new IdentityResources.OpenId(),
             new IdentityResources.Profile(),
             new IdentityResource
             {
                 Name = "rc.scope",
                 UserClaims =
                 {
                     "rc.garndma"
                 }
             }
          };
      
        
        public static IEnumerable<ApiScope> GetApiScopes()
         => new List<ApiScope> 
         { 
            new ApiScope("read"),
            new ApiScope("write")
             
         };

        public static IEnumerable<ApiResource> GetApiResources()
            => new List<ApiResource>
            {
               new ApiResource
               {
                   Name = "ApiOne",
                   DisplayName = "Rights to use first API endpoints",
                   Scopes = new List<string>
                   {
                       "write",
                       "read"
                   }
               }
            };



        public static IEnumerable<Client> GetClients()
           => new List<Client>
           {
              new Client
	    	{
                  ClientId = "client_id_js",
                  AllowedGrantTypes = GrantTypes.Implicit,

                  RedirectUris =  { "https://localhost:44312/Home/signin" },
                  AllowedCorsOrigins = { "https://localhost:44312" },

                  RequireClientSecret = false,
                  AllowedScopes =
	    		  {
                        IdentityServerConstants.StandardScopes.OpenId,
                        "read",
                        "write",
                        "rc.scope",
                  },

                  AccessTokenLifetime = 1,

                  AllowAccessTokensViaBrowser = true,

                  RequireConsent = false,
              }
           };
    }
}
