using System;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            char[] c = original.ToCharArray();
            string reversed = "";

            for (int i = original.Length - 1; i >= 0; i--)
            {                         
                    reversed += c[i];
            }
            
            return reversed;
        }
    }
}
