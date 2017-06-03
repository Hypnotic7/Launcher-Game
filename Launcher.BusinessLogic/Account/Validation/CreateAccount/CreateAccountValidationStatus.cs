using System;
using System.Collections.Generic;
using System.Text;
using Launcher.Data.Access.Models;

namespace Launcher.BusinessLogic.Account.Validation.CreateAccount
{
    public class CreateAccountValidationStatus
    {
        public bool IsValid { get; set; }
        public string Message { get; set; }
    }
}
