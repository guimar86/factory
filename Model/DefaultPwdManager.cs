namespace Factory.Model {
    public class DefaultPwdManager : IPwdManager {
        public string resetPassword () {
            return "Default Password reset";
        }

        public string setPassword () {
            return "Default password";
        }
    }
}