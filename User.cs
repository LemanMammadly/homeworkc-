using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class User
    {
        private string _userName;
        private string _passWord;



        public string Username
        {
            get
            {
                return _userName;
            }
            set
            {
                if (value.Length >= 8)
                {
                    _userName = value;
                    
                }
                else
                {
                    Console.WriteLine("Minimum 8 uzunlugunda olmalidir..");
                }
            }
        }

        public string PassWord
        {
            get
            {
                return _passWord;
            }
            set
            {
                if (value.Length >= 8)
                {
                    int countUpper = 0;
                    int countLower = 0;
                    int countDigit = 0;
                    foreach (char item in value)
                    {
                        if (char.IsUpper(item))
                        {
                            countUpper++;
                        }
                        else if (char.IsLower(item))
                        {
                            countLower++;
                        }
                        else if (char.IsDigit(item))
                        {
                            countDigit++;
                        }
                    }
                    if (countUpper >= 1 && countLower >= 1 && countDigit >= 1)
                    {
                        _passWord = value;
                        
                       
                    }
                    else
                    {
                        Console.WriteLine("Yanlis parol..");
                    }

                }
                else
                {
                    Console.WriteLine("Minimum 8 uzunlugunda olmalidir..");
                }
            }
        }

        public User(string username, string password)
        {
            Username = username;
            PassWord = password;
        }
    } 
}
