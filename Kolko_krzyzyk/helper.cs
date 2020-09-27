using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolko_krzyzyk
{
    /// <summary>
    /// Klasa pomocnicza
    /// </summary>
    public static class helper
    {
        /// <summary>
        /// Metoda sprawdzjąca poprawnosc znaków w loginie
        /// </summary>
        /// <param name="a"></param>
        /// <returns> Zwracane jest true lub false </returns>

        public static bool ver_login (string a)
        {
            if (a.Contains("%"))
            {
                return false;
            }
            else if (a == "")
            {
                return false;
            }
            else if (a == "#")
            {
                return true;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Metoda sprawdzjąca poprawnosc znaków w hasle
        /// </summary>
        /// <param name="a"></param>
        /// <returns> Zwracana jest true lub false </returns>
        public static bool ver_haslo(string a)
        {
            if (a.Contains("%"))
            {
                return false;
            }
            else if (a == "")
            {
                return false;
            }
            else if (a == "#")
            {
                return true;
            }
            else if (a == "!")
            {
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
