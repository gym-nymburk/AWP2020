﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Tomas
{
    public class Stairs
    {

        /// <summary>
        /// Result for Down("aaaaaaaaaaaaaaaaaaaaaa", 5,2):
        /// aaaaa
        ///    aaaaa
        ///       aaaaa
        ///          aaaaa
        ///             aa
        /// </summary>
        /// <param name="len"></param>
        /// <param name="offset"></param>
        public static void Down(string text, int len, int offset)
        {
            for (int i = 0; i < text.Length - len +1; i = i + len)
            {
                Debug.Write(new string(' ', (i / len) * (len - offset)));
                Debug.WriteLine(text.Substring(i,len));
            }
        }



        /// <summary>
        /// Result for Up("aaaaaaaaaaaaaaaaaaaaaa", 5,2):
        ///             aa
        ///          aaaaa
        ///       aaaaa
        ///   aaaaa
        /// aaaaa
        /// </summary>
        /// <param name="len"></param>
        /// <param name="offset"></param>
        public static void Up(string text, int len, int offset)
        {

        }



        /// <summary>
        /// Result for Down("aaaaaaaaaa", 3,3):
        /// aaa
        ///   a
        ///   aaa
        ///     a
        ///     a
        /// </summary>
        /// <param name="len"></param>
        /// <param name="offset"></param>
        public void Down2(string text, int width, int height)
        {

        }
    }
}
