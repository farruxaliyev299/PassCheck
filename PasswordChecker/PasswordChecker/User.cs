using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordChecker
{
    internal class User : IAccount
    {
        private string _fullname;
        public string Fullname 
        {
            get
            {
                return _fullname;
            }
            set
            {
                _fullname = value;
            } 
        }
        private string _email;
        public string Email 
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        private string _password;
        public string Password 
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Parol teleblere uygun deyil!");
                    return;
                }
            }
        }
        public bool PasswordChecker(string pass)
        {
            bool isLong=false;
            bool isUpper=false;
            bool isLower=false;
            bool isDigit=false;

            if(pass.Length >= 8)
            {
                isLong = true;
            }
            else
            {
                Console.WriteLine("Parol 8 xarakter ve ya daha uzun olmalidir\n");
            }
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsUpper(pass[i]))
                {
                    isUpper = true;
                }
                

                if (char.IsLower(pass[i]))
                {
                    isLower = true;
                }
                

                if (char.IsDigit(pass[i]))
                {
                    isDigit = true;
                }
                

                
            }

            if (isLong && isUpper && isLower && isDigit)
            {
                return true;
            }
            return false;
        }

        public void ShowInfo()
        {
            if (Password != null)
            {
                Console.WriteLine($"Full Name : {Fullname}\nE-mail: {Email}");
            }           
        }
    }
}
