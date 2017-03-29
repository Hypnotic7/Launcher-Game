using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BuisnessLogic.Account.Validation
{
    public class AccountValidationStatus
    {
        public bool IsValid { get; set; }
        public AccountEntity Account { get; set; }
    }
}
