
namespace LoginSystem.Model
{
    public class User
    {
        public string Nickname { get; set; }
        public string Password { get; set; }

        public User()
        {
            
        }

        public User(string nickname,string password)
        {
            Nickname = nickname;
            Password = password;
        }

        public override bool Equals(object user)
        {
            if (user == null || GetType() != user.GetType())
                return false;
            User other = user as User;
            return Nickname.Equals(other.Nickname) && Password.Equals(other.Password);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Password?.GetHashCode() ?? 0) ^ (Nickname?.GetHashCode() ?? 0);
            }
        }
    }
}