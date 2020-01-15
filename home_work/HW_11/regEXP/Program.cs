using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace regEXP
{
    class Program
    {

        static public void Auth()
        {
            SortedList<string, string> _userData = new SortedList<string, string>();
            _userData.Add("root", "toor");

            if (CheckData(_userData)) { Console.WriteLine("Authorizated"); }
            else { Console.WriteLine("Authorization failed"); }
        }


        static public bool CheckData(SortedList<string, string> userData)
        {
            Console.Write("Enter an login => ");
            string login = Console.ReadLine();
            login = login.Trim(' ');

            if (login == "")
            {
                Console.WriteLine("Login can't be an empty");
                return false;
            }

            var _regExpLogin = new Regex(@"^[a-zA-Z][a-zA-Z0-9_-]{3,16}$");
            if (!_regExpLogin.IsMatch(login))
            {
                Console.WriteLine("Incorrect Login");
                return false;
            }
            else
            {
                Console.Write($"Enter password for {login} => ");

                string pass = Console.ReadLine();
                pass = pass.Trim(' ');

                if (pass == "")
                {
                    Console.WriteLine("Password can't be an empty");
                    return false;
                }

                var _regExpPass = new Regex(@"^[a-zA-Z][a-zA-Z0-9_]{3,16}$");
                if (!_regExpPass.IsMatch(pass))
                {
                    Console.WriteLine("Incorrect Password");
                    return false;
                }
                else
                {
                    if (userData[$"{login}"] == pass)
                        return true;
                    else
                        return false;
                }
            }
        }

        static void Main(string[] args)
        {
            Auth();
        }
    }
}
