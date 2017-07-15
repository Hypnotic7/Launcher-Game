using System.Collections.Generic;
using Launcher.API.Model.CreateAccount;
using Launcher.BusinessLogic.Account.Validation.CreateAccount;
using Launcher.BusinessLogic.RepositoryFactory;
using Launcher.Data.Access.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Launcher.API.Controllers
{
    [Route("api/[controller]")]
    public class CreateAccountController : Controller
    {
        private IOptions<AppSettings> _appSettings;

        public CreateAccountController(IOptions<AppSettings> appSettings)
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
        public CreateAccountResponse Post([FromBody]CreateAccountRequest createAccountRequest)
        {
            var createAccountValidation = new CreateAccountValidation(new RepositoryFactory<AccountEntity>(),
                _appSettings.Value.MongoConnectionString);

            var createAccountValidationStatus = createAccountValidation.CreateAccount(
                createAccountRequest.AccountName,
                createAccountRequest.AccountPassword, createAccountRequest.Email);

            if (createAccountValidationStatus.IsValid)
                return new CreateAccountResponse
                {
                    IsValid = createAccountValidationStatus.IsValid,
                    Message = createAccountValidationStatus.IsValid ?  $@"{createAccountRequest.AccountName} has been created"
                                                                    :  $@"{createAccountRequest.AccountName} Already exists in Database"
                };

            return new CreateAccountResponse
            {
                IsValid = false,
                Message = $@"Could Not Add to Database because Account Name is already used"
            };
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
