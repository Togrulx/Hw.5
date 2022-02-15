using System;

namespace Hw5Task3.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Xos Geldiniz Istifatecini yaradin");

            User user1 = new User("Eliyev Vusal", "vusal1y3v@gmail.com", "lotu6768");

            Console.WriteLine(user1.ShowInfo());
            Console.WriteLine("Passwordu girin");

            string password = Console.ReadLine();

            user1.PasswordCheker(password);

        }
    }
}

namespace Hw5Task3.cs
{
    interface IAccout
    {
        public string PasswordCheker(string password);

    }

class User : IAccout
{
    public string Fullname;
    public string Email;
    public string Password;

    public User(string fullname, string email)
    {
        Fullname = fullname;
        Email = email;
    }

    public User(string fullname, string email, string password) : this(fullname, email)
    {

        Password = password;

    }

    public string PasswordCheker(string password)
    {
        while (true)
        {
            if (password.Length < 8)
            {
                Console.WriteLine("Sifre 8 simvoldan boyuk olmalidir");
                password = Console.ReadLine();
            }
            else
            {

                bool chekUpper = false;
                bool chekLower = false;
                bool chekDigis = false;

                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i]))
                    {
                        chekUpper = true;
                    }
                    if (char.IsLower(password[i]))
                    {
                        chekLower = true;
                    }
                    if (char.IsDigit(password[i]))
                    {
                        chekDigis = true;
                    }
                }
                if (chekDigis && chekLower && chekUpper)
                {
                    Password = password;
                    break;
                }
                else
                {
                    Console.WriteLine("Parolu duzgun daxil edin");
                    password = Console.ReadLine();
                }

            }

        }
        return password;
    }


    public string ShowInfo()
    {
        return $"{Fullname} {Email}";
    }
}

}