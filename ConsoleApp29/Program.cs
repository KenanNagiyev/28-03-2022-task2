using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            User users = new User();
            Console.WriteLine("FulName-i daxil et");
            users.Fullname = Console.ReadLine();
            Console.WriteLine("Email-i daxil et");
            users.Email = Console.ReadLine();
            Console.WriteLine("Pasword-u daxil et");
            users.Password = Console.ReadLine();
            Console.WriteLine(users.ShowInfo());
            Console.WriteLine(users.PaswordChecker());


        }


        internal interface IAccount
        {
            public bool PasswordChecker(string passport);

        }

        class User : IAccount
        {

            public string Fullname;
            public string Email;
            public string Password;
            public string pasport()
            {
                if (PaswordChecker(Password))
                {
                    return Password;
                }
                return "passporti duzgun daxil et";
            }
            public bool PaswordChecker()
            {
                for (int i = 0; i < Password.Length; i++)
                {
                    if (hasdig(pasport()) && haslav(pasport()) && hasUpp(pasport()) && haslench(pasport()))
                    {
                        return true;

                    }
                }
                return false;
            }

            public bool haslench(string Password)
            {
                for (int i = 0; i < Password.Length; i++)
                {
                    if (Password.Length >= 8)
                    {
                        return true;
                    }

                }
                throw new Exception("uzunlugu 8 den kicikdir");
            }
            public bool hasUpp(string Password)
            {
                for (int i = 0; i < Password.Length; i++)
                {
                    if (char.IsUpper(Password[i]))
                    {
                        return true;
                    }
                }
                throw new Exception("boyuk herf yoxdur");
            }
            public bool hasdig(string Password)
            {
                for (int i = 0; i < Password.Length; i++)
                {
                    if (char.IsDigit(Password[i]))
                    {
                        return true;
                    }
                }
                throw new Exception("reqem yoxdur yoxdur");
            }
            public bool haslav(string Password)
            {
                for (int i = 0; i < Password.Length; i++)
                {
                    if (char.IsLower(Password[i]))
                    {
                        return true;
                    }
                }
                throw new Exception("kicik herf yoxdur");
            }

            public bool PaswordChecker(string passport)
            {
                return true;
            }

            public bool PasswordChecker(string passport)
            {
                return true;
            }
            public string ShowInfo()
            {
                return ("Fulname: " + Fullname + " " + "Email: " + Email);
            }
        }
    }

}
    

