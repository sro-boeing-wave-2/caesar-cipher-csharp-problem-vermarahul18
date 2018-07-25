using System;
using System.Linq;
using System.Text;
namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            StringBuilder cipher = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    char letter = Char.IsLower(text[i]) ? 'a' : 'A';
                    cipher.Append((char)((text[i] + shiftKey - letter) % 26 + letter));
                }
                else
                {
                    cipher.Append(text[i]);
                }
            }

            return cipher.ToString();

        }
    }
}
