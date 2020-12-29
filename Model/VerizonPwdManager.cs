namespace Factory.Model {
    public class VerizonPwdManager : IPwdManager {
        public string resetPassword () {
            return "Verizon Password Reset";
        }

        public string setPassword () {
            return "Verizon Password set";
        }
    }
}