using Launcher.API.Model.MainMenu;
using Launcher.BusinessLogic.Account.Validation.Logout;
using Launcher.BusinessLogic.RepositoryFactory;
using Launcher.Data.Access.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Launcher.API.Controllers
{
    [Route("api/[controller]")]
    public class MainMenuController
    {
        private IOptions<AppSettings> _appSettings;

        public MainMenuController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public MainMenuLogoutResponse Post([FromBody]MainMenuLogoutRequest logoutRequest)
        {
            AccountLogoutValidation accountLogoutValidation = new AccountLogoutValidation(new RepositoryFactory<AccountEntity>(),_appSettings.Value.MongoConnectionString);
            try
            {
                var accountLogoutStatus = accountLogoutValidation.Logout(logoutRequest.AccountName);
                var returnMessage = accountLogoutStatus.LoggedOut ? $@"{logoutRequest.AccountName} has been logged out" : $@"{logoutRequest.AccountName} have not logged out";
                return new MainMenuLogoutResponse
                {
                    IsValid = accountLogoutStatus.LoggedOut,
                    Message = returnMessage
                };
            }
            catch (KeyNotFoundException keyNotFound)
            {
                return new MainMenuLogoutResponse()
                {
                    IsValid = false,
                    Message = keyNotFound.Message
                };
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
