namespace Factory.Model {
    public class PaxPwdManager : IPwdManager {
        public string resetPassword () {
            return "Pax password reset";
        }

        public string setPassword () {
            return "Pax  password";
        }
    }
}