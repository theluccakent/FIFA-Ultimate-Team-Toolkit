﻿using UltimateTeam.Toolkit.Extensions;

namespace UltimateTeam.Toolkit.Models
{
    public class LoginResponse
    {
        public string NucleusId { get; private set; }

        public Shards Shards { get; private set; }
        
        public UserAccounts UserAccounts { get; private set; }
        
        public string SessionId { get; private set; }

        public LoginResponse(string nucleusId, Shards shards, UserAccounts userAccounts, string sessionId)
        {
            nucleusId.ThrowIfInvalidArgument();
            shards.ThrowIfNullArgument();
            userAccounts.ThrowIfNullArgument();
            sessionId.ThrowIfInvalidArgument();
            NucleusId = nucleusId;
            Shards = shards;
            UserAccounts = userAccounts;
            SessionId = sessionId;
        }
    }
}