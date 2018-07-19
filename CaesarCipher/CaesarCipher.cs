using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            string newstr = "";
            int x = 0;
            for (int i = 0; i < text.Length; i++) {
                if (shiftKey == 26)
                {
                    return text;
                }
                else if ((int)text[i] >= 65 && (int)text[i] <= 90)
                {
                    x = (int)text[i] + shiftKey;
                    if (x > 90)
                    {
                        newstr += Convert.ToChar(x - 26);
                    }
                    else { newstr += Convert.ToChar(x); }
                }
                else if ((int)text[i] >= 97 && (int)text[i] <= 122)
                {
                    x = (int)text[i] + shiftKey;
                    if (x > 122)
                    {
                        newstr += Convert.ToChar(x - 26);
                    }
                    else { newstr += Convert.ToChar(x); }
                }
                else {
                    newstr += text[i];
                }
            }

            return newstr;

            throw new NotImplementedException("You need to implement this function.");
        }
    }
}
