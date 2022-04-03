using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordChecker
{
    internal interface IAccount
    {
        bool PasswordChecker(string pass);

        void ShowInfo();
    }
}
