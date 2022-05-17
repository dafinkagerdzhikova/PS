using System;

namespace UserLogin
{
    public class User
    {
        public System.Int32 UserId
        { get; set; }
        public string Username
        { get; set; }

        public string Password
        { get; set; }

        public string FacultyNumber
        { get; set; }

        public UserRoles UserRole
        { get; set; }

        public DateTime Created
        { get; set; }

        public System.DateTime? ActiveTo 
        { get; set; }

        public User()
        {

        }
    }
}
    