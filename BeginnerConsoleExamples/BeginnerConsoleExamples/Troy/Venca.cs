using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Troy
{
    public class Venca
    {

        /// <summary>
        /// Do zadaného textu opakovaně na každé N.té slovo vkládá zadané sprosté slovo
        /// </summary>
        /// <param name="text">zadaný text</param>
        /// <param name="sprosteSlovo">slovo, které se opakovaně vkládá do zadaného textu</param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string Sprosty(string text, string sprosteSlovo, int n)
        {
            string[] slova = text.Split(' ');
            string vysledek = "";
            int i = 0;

            foreach (string slovo in slova)
            {
                i++;
                vysledek = vysledek + " " + slovo;

                if (i == n)
                {
                    vysledek = vysledek + " " + sprosteSlovo;
                    i = 0;
                }
            }

            return vysledek.Substring(1);   //vynechání úvodní mezery
        }
    }
}
