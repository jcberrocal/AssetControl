using System;

namespace AssetControl.Classes
{
    public class User
    {
        private static User _instance;

        private User() { }
        [Ignore]
        public static User Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new User();
                }
                return _instance;
            }
        }

        public static User CreateNewUser()
        {
            return new User();
        }

        public string UserId { get; set; }
        //[Ignore]
        public string Password { get; set; }
        public string UserName { get; set; }
        [Combo]
        public int Role { get; set; }
        [Optional]
        public string RoleDescription { get; set; }
        [Optional]
        public DateTime? EndDate { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            User anotherUser = (User) obj;
            return UserName == anotherUser.UserName && Password == anotherUser.Password && Role == anotherUser.Role;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(UserName, Password, Role);
        }
    }
}
