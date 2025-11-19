using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace Casino.Engine
{
    public static class SymbolInfo
    {
        public static(string Lable, Color background, Color Foreground) Get(Symbol s)
        {
            switch (s)
            {
                case Symbol.Cherry:
                    return ("Cseresznye", Color.FromRgb(239, 68, 68), Colors.White);
                case Symbol.Lemon:
                    return ("Citrom", Color.FromRgb(250,204,21), Colors.Black);
                case Symbol.Bar:
                    return ("BAR", Color.FromRgb(107,114,128), Colors.White);
                case Symbol.Diamond:
                    return ("Gyémánt", Color.FromRgb(59,130,246), Colors.White);
                case Symbol.Seven:
                    return ("777", Color.FromRgb(16,185,129), Colors.Black);
                default:
                    return ("?", Colors.DarkGray, Colors.White);

            }
        }
    }
}
