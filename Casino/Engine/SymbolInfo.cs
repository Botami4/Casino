using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Casino.Engine
{
    public static class SymbolInfo
    {
        public static(string Lable, Color background, Color Foreground) Get(Symbol s)
        {
            switch (s)
            {
                case Symbol.Cherry:
                    return ("Cseresznye", Color.Red, Color.White);
                case Symbol.Lemon:
                    return ("Citrom", Color.Yellow, Color.Black);
                case Symbol.Bar:
                    return ("BAR", Color.Gray, Color.White);
                case Symbol.Diamond:
                    return ("Gyémánt", Color.Blue, Color.White);
                case Symbol.Seven:
                    return ("777", Color.Green, Color.Black);
                default:
                    return ("?", Color.DarkGray, Color.White);

            }
        }
    }
}
