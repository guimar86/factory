using Factory.Service;
using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers {

    [ApiController]
    [Route ("[controller]")]
    public class PasswordController : ControllerBase {

        [HttpGet ("[action]")]
        public ActionResult PasswordReset (string type) {

            var PwdManager = PasswordFactory.Create (type);
            return (Ok (PwdManager.resetPassword ()));
        }

        [HttpGet ("[action]")]
        public ActionResult SetPassword (string type) {

            var PwdManager = PasswordFactory.Create (type);
            return (Ok (PwdManager.setPassword ()));
        }
    }
}