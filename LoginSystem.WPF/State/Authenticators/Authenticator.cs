﻿using LoginSystem.Domain.Models;
using LoginSystem.Domain.Services.AuthenticationServices;
using LoginSystem.WPF.State.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.WPF.State.Authenticators
{
    public class Authenticator : IAuthenticator
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IAccountStore _accountStore;

        public Authenticator(IAuthenticationService authenticationService, IAccountStore accountStore)
        {
            _authenticationService = authenticationService;
            _accountStore = accountStore;
        }

        public Account CurrentAccount
        {
            get
            {
                return _accountStore.CurrentAccount;
            }
            private set
            {
                _accountStore.CurrentAccount = value;
                StateChanged?.Invoke();
            }
        }

        public bool IsLoggedIn => CurrentAccount != null;

        public event Action StateChanged;

        public async Task Login(string username, string password)
        {
            CurrentAccount = await _authenticationService.Login(username, password);
        }

        public async Task<bool> Logout()
        {
            CurrentAccount = null;
            return true;
        }

        public async Task<RegistrationResult> Register(string email, string username, string password, string confirmPassword)
        {
            return await _authenticationService.Register(email, username, password, confirmPassword);
        }
    }
}
