using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Launcher.API.Model
{
    public class LoginResponse
    {
        public bool IsValid { get; set; }
        public string Message { get; set; }
    }
}
