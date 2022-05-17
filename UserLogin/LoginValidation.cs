using System;

namespace UserLogin
{
    public class LoginValidation
    {
        public static UserRoles currentUserRole { get; private set; }
        public static string currentUserName { get; private set; }

        private string _userName;
        private string _password;
        private string _errorMessage;
        private ActionOnError _actionOnError;

        public delegate void ActionOnError(string errorMess);
        public LoginValidation() { }
        public LoginValidation(string UserName, string Password, ActionOnError actionOnError)
        {
            this._userName = UserName;
            this._password = Password;
            this._actionOnError = actionOnError;
        }

        public bool ValidateUserInput(ref User user)
        {
            if (_userName.Equals(string.Empty))
            {
                _errorMessage = "Missing username!";
                _actionOnError(_errorMessage);
                return false;
            }
            else if (_userName.Length < 5)
            {
                _errorMessage = "The username should be 5 or more symbols!";
                _actionOnError(_errorMessage);
                return false;
            }

            if (_password.Equals(string.Empty))
            {
                _errorMessage = "Missing password!";
                _actionOnError(_errorMessage);
                return false;
            }
            else if (_password.Length < 5)
            {
                _errorMessage = "The password should be 5 or more symbols!";
                _actionOnError(_errorMessage);
                return false;
            }

            user = UserData.IsUserPassCorrect(_userName, _password);
            if (user == null)
            {
                _errorMessage = "There is no such user!";
                _actionOnError(_errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }
            currentUserRole = (UserRoles)user.UserRole;
            currentUserName = _userName;

            return true;
        }
    }
}