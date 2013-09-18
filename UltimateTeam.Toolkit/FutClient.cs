﻿using System;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Exceptions;
using UltimateTeam.Toolkit.Extensions;
using UltimateTeam.Toolkit.Factories;
using UltimateTeam.Toolkit.Models;

namespace UltimateTeam.Toolkit
{
    public class FutClient : IFutClient
    {
        private readonly IFutRequestFactories _requestFactories;

        public FutClient()
            : this(new FutRequestFactories())
        {
        }

        public FutClient(IFutRequestFactories requestFactories)
        {
            _requestFactories = requestFactories;
        }

        public async Task LoginAsync(LoginDetails loginDetails)
        {
            loginDetails.ThrowIfNullArgument();

            try
            {
                await _requestFactories.LoginRequestFactory(loginDetails).PerformRequest();
            }
            catch (Exception e)
            {
                throw new FutException("Login failed", e);
            }
        }
    }
}
