using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;

namespace Assignment1.Data.Login
{
    public class CustomAuthProvider : AuthenticationStateProvider
    {
        private readonly IJSRuntime _jsRuntime;
        private readonly IUserService _userService;

        private User _cachedUser;

        public CustomAuthProvider(IJSRuntime jsRuntime, IUserService userService)
        {
            _jsRuntime = jsRuntime;
            _userService = userService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            if (_cachedUser == null)
            {
                var userAsJson = await _jsRuntime.InvokeAsync<string>("sessionStorage.getItem", "currentUser");
                if (!string.IsNullOrEmpty(userAsJson))
                {
                    var tmp = JsonSerializer.Deserialize<User>(userAsJson);
                    ValidateLogin(tmp.Username, tmp.Password);
                }
            }
            else
            {
                identity = SetupClaimsForUser(_cachedUser);
            }

            var cachedClaimsPrincipal = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(cachedClaimsPrincipal));
        }

        private ClaimsIdentity SetupClaimsForUser(User cachedUser)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, cachedUser.Username),
                new Claim("Level", cachedUser.SecurityLvl.ToString()),
                new Claim("Age", cachedUser.Age.ToString())
            };

            var identity = new ClaimsIdentity(claims, "apiauth_type");
            return identity;
        }

        public void ValidateLogin(string tmpUsername, string tmpPassword)
        {
            Console.WriteLine("Validating login");
            if (string.IsNullOrEmpty(tmpUsername)) throw new Exception("No username specified");
            if (string.IsNullOrEmpty(tmpPassword)) throw new Exception("No password specified");

            var identity = new ClaimsIdentity();
            try
            {
                var user = _userService.ValidateUser(tmpUsername, tmpPassword);
                identity = SetupClaimsForUser(user);
                var serializedData = JsonSerializer.Serialize(user);
                _jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", serializedData);
                _cachedUser = user;
            }
            catch (Exception e)
            {
                throw e;
            }

            NotifyAuthenticationStateChanged(
                Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
        }

        public void Logout()
        {
            _cachedUser = null;
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            _jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", "");
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
}