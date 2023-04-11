using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    public class CustomString
    {
        public string Empty = "";


        public bool StartWith(string str, char checkValue)
        {
            if (str[0] == checkValue)
            {
                return true;
            }
            return false;
        }

        public bool EndWith(string str, char checkValue)
        {
            if (str[str.Length - 1] == checkValue)
            {
                return true;
            }
            return false;
        }

        public int Length(string str)
        {
            int count = 0;
            foreach (var item in str)
            {
                count++;
            }
            return count;
        }

        public int IndexOf(string str, char checkValue)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == checkValue)
                {
                    return i;
                }
            }
            return -1;
        }

        public int LastIndexOf(string str, char checkValue)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == checkValue)
                {
                    return i;
                }
            }
            return -1;
        }

        public string Replace(string str, char replacement1, char replacement2)
        {
            StringBuilder sb = new StringBuilder(str);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == replacement1)
                {
                    sb[i] = replacement2;
                }
            }
            return sb.ToString();
        }

        public string Remove(string str, int beginIndex)
        {
            string result = string.Empty;
            for (int i = 0; i < beginIndex; i++)
            {
                result += str[i];
            }
            return result;
        }

        public string SubString(string str, int startIndex, int length)
        {
            string result = string.Empty;
            for (int i = startIndex; i < length; i++)
            {
                result += str[i];
            }
            return result;
        }

        public string Trim(string str)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            int countReverse = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
                else if (str[i] != ' ')
                {
                    break;
                }
            }

            for (int i = str.Length-1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    countReverse++;
                }
                else if (str[i] != ' ')
                {
                    break;
                }

            }

            for (int i = count; i < str.Length-countReverse; i++)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }

        public int Compare(string a, string b)
        {
            if (a == b)
            {
                return 0;
            }
            else if (a.Length > b.Length)
            {
                return 1;
            }
            return -1;
        }

        public bool IsNullOrEmpty(string str)
        {
            if (str == "" || str == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNullOrWhiteSpace(string str)
        {
            if (str == " " || str == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
