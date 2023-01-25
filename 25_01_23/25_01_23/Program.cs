using System;

namespace _25_01_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string names =  "Vugar1" ;

            //Console.WriteLine(Numberfinder(names));



            string name = "Vuqar Ismayilov";

            Console.WriteLine(CheckNumber(name));
        }
        static bool Numberfinder(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (charfinder(str[i]))
                    return true;
            }

            return false;
        }
        static bool charfinder(char cr)
        {
            char[] num = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == cr)
                    return true;
            }

            return false;
        }

        static bool IsName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            if (!char.IsUpper(name[0]))
            {
                return false;
            }
            for (int i = 1; i < name.Length; i++)
            {
                if (!char.IsLower(name[i]))
                {
                    return false;

                }
            }
            return true;

        }
        static bool CheckNumber(string number)
        {
            number = number.Trim();
            var arrr = number.Split(' ');
            if (IsName(arrr[0]) && IsName(arrr[1]))
            {
                return true;

            }
            return false;

        }
    }
}
