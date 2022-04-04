using System;

namespace PasswordChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Fullname = "Dumbuw Dumbuwzade";
            user1.Password = "Dumbuw2022";
            user1.Email = "dumbuw2022@gmail.com";

            user1.ShowInfo();

        }
    }
}
