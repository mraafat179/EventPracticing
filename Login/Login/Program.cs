
namespace Login
{
    public class Program
    {
        private static void Main(string[] args)
        {
            User user = new User("Mohamed", "Raafat", "@example.com");
            loginManager login = new loginManager();
            login.UserLoginSuccesful += Login_UserLoginSuccesful;
            login.loginUser(user);
            
        }

        private static void Login_UserLoginSuccesful(User user)
        {
            Console.WriteLine($"{user.FirstName} {user.LastName} logged in successfully");
        }
    }
}
