using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Tomas
{
    /// <summary>
    /// Příklady na použití metod tříd System.IO.Directory, System.IO.File, System.IO.Path,
    /// Příklad na rekurzi
    /// </summary>
    public class Soubory
    {

        /// <summary>
        /// Vypíše seznam souborů v zadané složce a všech podsložkách
        /// </summary>
        /// <param name="path">zadaná složka</param>
        /// <param name="mask">filtrovací podmínka, syntaxe *.*</param>
        public static void FileList(string path, string mask="*.*")
        {

            string[] soubory = Directory.GetFiles(path, mask, SearchOption.AllDirectories);

            foreach (string soubor in soubory)
            {
                Console.WriteLine(soubor);
            }
        }

        /// <summary>
        ///  Vypíše seznam souborů v zadané složce a jejích podsložkách do definované úrovně vnoření
        /// </summary>
        /// <param name="path">zadaná složka</param>
        /// <param name="mask">filtrovací podmínka, syntaxe *.*</param>
        /// <param name="maxLevel">maximální hloubka vnoření procházených podsložek</param>
        public static void FileList(string path, string mask = "*.*", int maxLevel = 99)
        {
            FileListInternal(path, mask, maxLevel, 1);
        }
        
        private static void FileListInternal(string path, string mask, int maxLevel, int currentLevel )
        {
            if (currentLevel < maxLevel)
            {
                string[] slozky = Directory.GetDirectories(path);

                foreach (string slozka in slozky)
                {
                    FileListInternal(slozka, mask, maxLevel, currentLevel + 1);     //rekurze !!!
                }
            }


            string[] soubory = Directory.GetFiles(path, mask);

            foreach (string soubor in soubory)
            {
                Console.WriteLine(soubor);
            }
        }


        /// <summary>
        /// Vypíše seznam souborů v zadané složce a všech podsložkách
        /// </summary>
        /// <param name="path">zadaná složka</param>
        /// <param name="olderThan">jen soubory starší než</param>
        /// <param name="mask">filtrovací podmínka, syntaxe *.*</param>
        public static void FileList(string path, DateTime olderThan, string mask = "*.*")
        {

            string[] soubory = Directory.GetFiles(path, mask, SearchOption.AllDirectories);

            foreach (string soubor in soubory)
            {
                DateTime zmeneno =  File.GetLastWriteTime(soubor);

                if (zmeneno < olderThan)
                {
                    string nazev = Path.GetFileNameWithoutExtension(soubor);

                    Console.WriteLine(nazev);
                }
            }
        }

    }
}
