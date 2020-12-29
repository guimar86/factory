using Factory.Model;

namespace Factory.Service {
    public class PasswordFactory {

        public static IPwdManager Create (string type) {

            type = type.ToUpper ();
            switch (type) {

                case "":
                    return new DefaultPwdManager ();
                case "PAX":
                    return new PaxPwdManager ();
                case "VERIZON":
                    return new VerizonPwdManager ();
                default:
                    return new DefaultPwdManager ();
            }
        }
    }
}