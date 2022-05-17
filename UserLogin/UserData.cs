using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogin
{
    public static class UserData
    {
       // private static List<User> testUsers;

        public static List<User> TestUsers
        {
            get
            {
                ResetTestUserData();
                return _testUsers;
            }
            set { }
        }
        static private List<User> _testUsers;
        static private void ResetTestUserData()
        {
            if (_testUsers == null)
            {
                _testUsers = new List<User>
                {
                    new User
                    {
                        Username = "yo23ana",
                        Password = "12345",
                        FacultyNumber = "121219009",
                        UserRole = UserRoles.ADMIN,
                        Created = DateTime.Now,
                        ActiveTo = DateTime.MaxValue
                    },
                    new User
                    {
                        Username = "didito",
                        Password = "23456",
                        FacultyNumber = "121219092",
                        UserRole = UserRoles.STUDENT,
                        Created = DateTime.Now,
                        ActiveTo = DateTime.MaxValue
                    },
                    new User
                    {
                        Username = "deni",
                        Password = "34567",
                        FacultyNumber = "121219099",
                        UserRole = UserRoles.STUDENT,
                        Created = DateTime.Now,
                        ActiveTo = DateTime.MaxValue
                    },
                };
            }
        }
      

        public static User IsUserPassCorrect(string UserName, string PassWord)
        {

            UserContext context = new UserContext();
            User user = (from u in context.Users
                         where u.Username.Equals(UserName) &&
                         u.Password.Equals(PassWord)
                         select u).DefaultIfEmpty(null).First();

            return user;

        }

        public static void SetUserActiveTo(string UserName, DateTime date)
        {
            foreach (User user in TestUsers)
            {
                if (user.Username == UserName)
                {
                    user.ActiveTo = date;
                    Logger.LogActivity("The activity has been changed for " + UserName);
                }
            }
        }

        public static void AssignUserRole(string UserName, UserRoles userRole)
        {
            UserContext context = new UserContext();


            User usr =
           (from u in context.Users
            where u.Username.Equals(UserName)
            select u).First();

            usr.UserRole = (UserRoles)(int)userRole;
            Logger.LogActivity("Role has been changed for " + UserName);

            context.SaveChanges();

        }
        static public void GetUsers()
        {
            foreach (User user in TestUsers)
            {
                Console.WriteLine("Username: " + user.Username);
                Console.WriteLine("User password: " + user.Password);
                Console.WriteLine("User faculty number: " + user.FacultyNumber);
                Console.WriteLine("User Role: " + (UserRoles)user.UserRole);
                Console.WriteLine("Created on: " + user.Created);
                Console.WriteLine("Expire on: " + user.ActiveTo);
            }
        }

    }
}



    
