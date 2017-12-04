using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// static class to manage the console game theme
    /// </summary>
    public static class ConsoleTheme
    {
        //
        // splash screen colors
        //
        public static ConsoleColor SplashScreenBackgroundColor = ConsoleColor.Gray;
        public static ConsoleColor SplashScreenForegroundColor = ConsoleColor.DarkCyan;

        //
        // main console window colors
        //
        public static ConsoleColor WindowBackgroundColor = ConsoleColor.DarkCyan;
        public static ConsoleColor WindowForegroundColor = ConsoleColor.White;

        //
        // console window header colors
        //
        public static ConsoleColor HeaderBackgroundColor = ConsoleColor.Gray;
        public static ConsoleColor HeaderForegroundColor = ConsoleColor.DarkCyan;

        //
        // console window footer colors
        //
        public static ConsoleColor FooterBackgroundColor = ConsoleColor.DarkYellow;
        public static ConsoleColor FooterForegroundColor = ConsoleColor.Gray;

        //
        // menu box colors
        //
        public static ConsoleColor MenuBackgroundColor = ConsoleColor.DarkCyan;
        public static ConsoleColor MenuForegroundColor = ConsoleColor.White;
        public static ConsoleColor MenuBorderColor = ConsoleColor.DarkGreen;

        //
        // message box colors
        //
        public static ConsoleColor MessageBoxBackgroundColor = ConsoleColor.DarkCyan;
        public static ConsoleColor MessageBoxForegroundColor = ConsoleColor.White;
        public static ConsoleColor MessageBoxBorderColor = ConsoleColor.DarkGreen;
        public static ConsoleColor MessageBoxHeaderBackgroundColor = ConsoleColor.DarkCyan;
        public static ConsoleColor MessageBoxHeaderForegroundColor = ConsoleColor.White;

        //
        // status box colors
        //
        public static ConsoleColor StatusBoxBackgroundColor = ConsoleColor.DarkCyan;
        public static ConsoleColor StatusBoxForegroundColor = ConsoleColor.White;
        public static ConsoleColor StatusBoxBorderColor = ConsoleColor.DarkGreen;
        public static ConsoleColor StatusBoxHeaderBackgroundColor = ConsoleColor.DarkCyan;
        public static ConsoleColor StatusBoxHeaderForegroundColor = ConsoleColor.White;

        //
        // input box colors
        //
        public static ConsoleColor InputBoxBackgroundColor = ConsoleColor.DarkCyan;
        public static ConsoleColor InputBoxForegroundColor = ConsoleColor.White;
        public static ConsoleColor InputBoxErrorMessageForegroundColor = ConsoleColor.DarkMagenta;
        public static ConsoleColor InputBoxBorderColor = ConsoleColor.DarkGreen;
        public static ConsoleColor InputBoxHeaderBackgroundColor = ConsoleColor.DarkCyan;
        public static ConsoleColor InputBoxHeaderForegroundColor = ConsoleColor.White;
    }
}
